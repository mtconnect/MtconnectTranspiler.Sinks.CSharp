
using System;

namespace MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces
{
    public interface IEnum
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
        /// Reference to the data type for elements of the enum.
        /// </summary>
        Type DataType { get; }

        /// <summary>
        /// Instance of the defined enum.
        /// </summary>
        Type Instance { get; }

        /// <summary>
        /// The normative introduction version for the SysML entity when applicable. Note: Not all entities have a normative version.
        /// </summary>
        string NormativeVersion { get; }

        /// <summary>
        /// The normative deprecation version for the SysML entity when applicable.
        /// </summary>
        string DeprecatedVersion { get; }

        /// <summary>
        /// Concatenation of all Comments.
        /// </summary>
        string Summary { get; }

        IEnumInstance[] Values { get; }
    }
}
