using MtconnectTranspiler.Sinks.CSharp.Models;
using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MtconnectTranspiler.Sinks.CSharp
{
    public class IncludeSharedTemplates : ITemplateLoader
    {
        /// <summary>
        /// Reference to the directory containing all Scriban template files.
        /// </summary>
        public string TemplatesPath { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates");

        public string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName)
        {
            return Path.Combine(TemplatesPath, templateName);
        }

        public string Load(TemplateContext context, SourceSpan callerSpan, string templatePath)
        {
            if (!File.Exists(templatePath)) templatePath = Path.Combine(TemplatesPath, templatePath);
            if (!File.Exists(templatePath)) throw new FileNotFoundException("Could not find template file", templatePath);

            var mtconnectFunctions = new MTConnectHelperMethods();
            context.PushGlobal(mtconnectFunctions);
            return File.ReadAllText(templatePath);
        }

        public async ValueTask<string> LoadAsync(TemplateContext context, SourceSpan callerSpan, string templatePath)
        {
            if (!File.Exists(templatePath)) templatePath = Path.Combine(TemplatesPath, templatePath);
            if (!File.Exists(templatePath)) throw new FileNotFoundException("Could not find template file", templatePath);

            var mtconnectFunctions = new MTConnectHelperMethods();
            context.PushGlobal(mtconnectFunctions);
            return await Task.FromResult(File.ReadAllText(templatePath));
        }
    }
}