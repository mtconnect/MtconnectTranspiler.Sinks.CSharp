using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Sinks.CSharp.Models;
using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Threading;

namespace MtconnectTranspiler.Sinks.CSharp
{
    public class IncludeSharedTemplates : ITemplateLoader
    {
        public string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName)
        {
            return Path.Combine("Templates", templateName);
        }

        public string Load(TemplateContext context, SourceSpan callerSpan, string templatePath)
        {
            var mtconnectFunctions = new MTConnectHelperMethods();
            context.PushGlobal(mtconnectFunctions);
            return File.ReadAllText(templatePath);
        }

        public async ValueTask<string> LoadAsync(TemplateContext context, SourceSpan callerSpan, string templatePath)
        {
            var mtconnectFunctions = new MTConnectHelperMethods();
            context.PushGlobal(mtconnectFunctions);
            return await Task.FromResult(File.ReadAllText(templatePath));
        }
    }
    public abstract class CsharpTranspiler : ITranspilerSink
    {
        /// <summary>
        /// The root output directory for the transpiled code.
        /// </summary>
        public string ProjectPath { get; set; }

        protected TemplateContext TemplateContext { get; set; }

        protected ScriptObject Model { get; set; }

        public CsharpTranspiler(string projectPath)
        {
            ProjectPath = projectPath;

            TemplateContext = new TemplateContext();
            TemplateContext.TemplateLoader = new IncludeSharedTemplates();

            var helperFunctions = new ScribanHelperMethods();
            TemplateContext.PushGlobal(helperFunctions);

            var mtconnectFunctions = new MTConnectHelperMethods();
            TemplateContext.PushGlobal(mtconnectFunctions);


            Model = new ScriptObject();
            Model.SetValue("version", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString(), true);
            TemplateContext.PushGlobal(Model);
        }

        public abstract void Transpile(MTConnectModel model, CancellationToken cancellationToken = default);

        private void processDeviceModel(MTConnectDeviceInformationModel model, string @namespace = "MtconnectCore.Standard")
        {
            if (model == null) return;

            if (model.Classes != null && model.Classes.Any())
            {
                processTemplate(
                    model.Classes.Select(o => new Class(Model["model"] as MTConnectModel, o) { Namespace = $"{@namespace}.{o.Name}" }),
                    ProjectPath//Path.Combine(ProjectPath, value.Name),
                );
            }

            if (model.SubModels != null && model.SubModels.Any())
            {
                // Recursively build sub-class structure
                foreach (var subModel in model.SubModels)
                {
                    if (subModel.Name == "Component Types")
                    {
                        // Convert Component Classes into Enums
                        // Process Enums
                        processTemplate(
                            new Models.Enum(Model["model"] as MTConnectModel, subModel),
                            Path.Combine(ProjectPath, "Enums"));
                    }
                    else
                    {
                        processDeviceModel(subModel, $"{@namespace}.{model.Name}");
                    }
                }
            }
        }

        private Dictionary<string, Template> templateCache = new Dictionary<string, Template>();
        private Template getTemplate(string filepath)
        {
            if (templateCache.TryGetValue(filepath, out Template template)) return template;

            string templateContent = File.ReadAllText(filepath);
            template = Template.Parse(templateContent);

            if (template != null)
            {
                if (templateCache.ContainsKey(filepath)) return templateCache[filepath];
                templateCache.Add(filepath, template);
                return template;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Renders the <paramref name="template"/> into C#.
        /// </summary>
        /// <param name="member">The member name used in the <paramref name="template"/> for the provided <paramref name="value"/>.</param>
        /// <param name="value">The value for the provided <paramref name="member"/> reference.</param>
        /// <param name="template">The <see cref="Template"/> to render C#.</param>
        /// <returns>Raw C# code.</returns>
        protected string renderTemplateWithModel(string member, object value, Template template)
        {
            if (value == null) return String.Empty;
            if (Model.Contains(member))
            {
                Model.Remove(member);
            }
            Model.SetValue(member, value, true);
            string csharp = template.Render(TemplateContext);

            Model.Remove(member);

            return csharp;
        }

        /// <summary>
        /// Processes a collection of objects, decorated with the <see cref="ScribanTemplateAttribute"/>, into a C# file.
        /// </summary>
        /// <typeparam name="T">An implementation of <see cref="IFileSource"/>.</typeparam>
        /// <param name="items">Collection of objects, decorated with <see cref="ScribanTemplateAttribute"/>.</param>
        /// <param name="folderPath">Location to save the <c>.cs</c> files.</param>
        protected void processTemplate<T>(IEnumerable<T> items, string folderPath) where T : IFileSource
        {
            if (items == null || items.Any() == false) return;

            foreach (var item in items) processTemplate(item, folderPath);
        }
        /// <summary>
        /// Processes an object, decorated with the <see cref="ScribanTemplateAttribute"/>, into a C# file.
        /// </summary>
        /// <typeparam name="T">An implementation of <see cref="IFileSource"/>.</typeparam>
        /// <param name="item">An object, decorated with <see cref="ScribanTemplateAttribute"/>.</param>
        /// <param name="folderPath">Location to save the <c>.cs</c> file.</param>
        /// <exception cref="NotImplementedException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        protected void processTemplate<T>(T item, string folderPath) where T : IFileSource
        {
            if (item == null) return;

            System.Type type = typeof(T);
            ScribanTemplateAttribute attr = type.GetCustomAttribute<ScribanTemplateAttribute>();

            if (attr == null)
            {
                throw new NotImplementedException("The type of " + typeof(T).Name + " must be decorated with the ScribanTemplateAttribute");
            }

            Template template = getTemplate($"Templates\\{attr.Filename}");
            if (template == null)
            {
                throw new FileNotFoundException();
            }

            string csharp = renderTemplateWithModel("source", item, template);
            XmiTranspilerExtensions.WriteToFile(Path.Combine(folderPath, item.Filename), csharp);
        }
    }
}