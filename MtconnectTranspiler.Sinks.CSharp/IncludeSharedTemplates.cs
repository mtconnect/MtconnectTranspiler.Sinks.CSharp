using MtconnectTranspiler.Sinks.CSharp.Models;
using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;
using System.IO;
using System.Threading.Tasks;

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
}