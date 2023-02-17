using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Sinks.CSharp.Models;
using Scriban;
using Scriban.Runtime;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.Extensions.Logging;

namespace MtconnectTranspiler.Sinks.CSharp
{
    /// <summary>
    /// A base class for transpiling the MTConnect Standard SysML model into C# files.
    /// </summary>
    public abstract class CsharpTranspiler : ITranspilerSink
    {
        protected ILogger<ITranspilerSink> _logger;

        /// <summary>
        /// The root output directory for the transpiled code.
        /// </summary>
        public string ProjectPath { get; set; }

        private string _templatesPath { get; set; }
        /// <summary>
        /// Reference to the directory containing all Scriban template files.
        /// </summary>
        public string TemplatesPath
        {
            get
            {
                if (string.IsNullOrEmpty(_templatesPath))
                {
                    _templatesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates");
                }
                return _templatesPath;
            }
            set
            {
                _templatesPath = value;
                (TemplateContext.TemplateLoader as IncludeSharedTemplates).TemplatesPath = value;
            }
        }

        /// <summary>
        /// Reference to the template rendering context.
        /// </summary>
        protected TemplateContext TemplateContext { get; set; }

        /// <summary>
        /// Reference to the core template rendering model.
        /// </summary>
        protected ScriptObject Model { get; set; }

        /// <summary>
        /// Constructs a new instance of the transpiler that can transpile the model into C# files.
        /// </summary>
        /// <param name="projectPath"><inheritdoc cref="ProjectPath" path="/summary"/></param>
        public CsharpTranspiler(string projectPath, ILogger<ITranspilerSink> logger = default)
        {
            ProjectPath = projectPath;
            _logger = logger;

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

        /// <summary>
        /// <inheritdoc cref="ITranspilerSink.Transpile(MTConnectModel, CancellationToken)" path="/summary"/>
        /// </summary>
        /// <param name="model"><inheritdoc cref="MTConnectModel" path="/summary"/></param>
        /// <param name="cancellationToken"><inheritdoc cref="CancellationToken" path="/summary"/></param>
        public abstract void Transpile(MTConnectModel model, CancellationToken cancellationToken = default);

        /// <summary>
        /// An internal cache of <see cref="Template"/>s based on the source <c>.scriban</c> file location.
        /// </summary>
        protected Dictionary<string, Template> templateCache = new Dictionary<string, Template>();
        /// <summary>
        /// Retrieves a <see cref="Template"/> from a <c>.scriban</c> file at the given <paramref name="filepath"/>.
        /// </summary>
        /// <param name="filepath">Location of the <c>.scriban</c> file to parse a <see cref="Template"/>.</param>
        /// <returns>Reference to the <see cref="Template"/> parsed from the given <c>.scriban</c> at the <paramref name="filepath"/>.</returns>
        /// <exception cref="InvalidOperationException"></exception>
        protected Template getTemplate(string filepath)
        {
            if (templateCache.TryGetValue(filepath, out Template template)) return template;

            if (!File.Exists(filepath)) throw new FileNotFoundException("Could not find template file", filepath);

            string templateContent = File.ReadAllText(filepath);
            template = Template.Parse(templateContent);

            if (template != null)
            {
                if (templateCache.ContainsKey(filepath)) return templateCache[filepath];
                _logger?.LogInformation("Registering Template from file: {Filepath}", filepath);
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
        protected void processTemplate<T>(IEnumerable<T> items, string folderPath, bool overwriteExisting = false) where T : IFileSource
        {
            if (items == null || items.Any() == false) return;

            foreach (var item in items) processTemplate(item, folderPath, overwriteExisting);
        }
        /// <summary>
        /// Processes an object, decorated with the <see cref="ScribanTemplateAttribute"/>, into a C# file.
        /// </summary>
        /// <typeparam name="T">An implementation of <see cref="IFileSource"/>.</typeparam>
        /// <param name="item">An object, decorated with <see cref="ScribanTemplateAttribute"/>.</param>
        /// <param name="folderPath">Location to save the <c>.cs</c> file.</param>
        /// <exception cref="NotImplementedException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        protected void processTemplate<T>(T item, string folderPath, bool overwriteExisting = false) where T : IFileSource
        {
            if (item == null) return;

            System.Type type = typeof(T);
            ScribanTemplateAttribute attr = type.GetCustomAttribute<ScribanTemplateAttribute>();

            if (attr == null)
            {
                throw new NotImplementedException("The type of " + typeof(T).Name + " must be decorated with the ScribanTemplateAttribute");
            }

            Template template = getTemplate(Path.Combine(TemplatesPath, attr.Filename));
            if (template == null)
            {
                throw new FileNotFoundException();
            }

            string csharp = renderTemplateWithModel("source", item, template);
            XmiTranspilerExtensions.WriteToFile(Path.Combine(folderPath, item.Filename), csharp, overwriteExisting);
        }
    }
}