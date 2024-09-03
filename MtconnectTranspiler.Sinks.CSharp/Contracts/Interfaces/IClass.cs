
using System;
using System.Diagnostics.Contracts;

namespace MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces
{
    /// <summary>
    /// Representation of a SysML class entity related to a literal C# class.
    /// </summary>
    public interface IClass
    {
        /// <summary>
        /// Reference to the SysML Id defined in the XMI document.
        /// </summary>
        string ReferenceId { get; }

        /// <summary>
        /// Link to the MTConnect model browser.
        /// </summary>
        string HelpUrl { get; }

        /// <summary>
        /// Reference to the name of the SysML entity.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// C# access modifier.
        /// </summary>
        string AccessModifier { get; }

        /// <summary>
        /// C# modifier.
        /// </summary>
        string Modifier { get; }

        /// <summary>
        /// The normative introduction version for the SysML entity when applicable. Note: Not all entities have a normative version.
        /// </summary>
        string NormativeVersion { get; }

        /// <summary>
        /// The normative deprecation version for the SysML entity when applicable.
        /// </summary>
        string DeprecatedVersion { get; }

        /// <summary>
        /// Generalized SysML type, referenced by SysML Id defined in the XMI document.
        /// </summary>
        Type Generalization { get; }

        /// <summary>
        /// Collection of properties associated with the representation of the SysML class entity.
        /// </summary>
        IPropertyList Properties { get; }

        /// <summary>
        /// Concatenation of all Comments.
        /// </summary>
        string Summary { get; }
    }
}
