using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Sinks.ScribanTemplates;

namespace MtconnectTranspiler.Sinks.CSharp
{
    /// <summary>
    /// A base class for transpiling the MTConnect Standard SysML model into C# files.
    /// </summary>
    public abstract class CsharpTranspiler : ScribanTranspiler
    {
        /// <summary>
        /// Constructs a new instance of the transpiler that can transpile the model into C# files.
        /// </summary>
        /// <param name="projectPath"><inheritdoc cref="ScribanTranspiler.ProjectPath" path="/summary"/></param>
        /// <param name="logger"><inheritdoc cref="ILogger"/></param>
        public CsharpTranspiler(string projectPath, ILogger<ITranspilerSink> logger = default) : base(projectPath, logger) { }
    }
}