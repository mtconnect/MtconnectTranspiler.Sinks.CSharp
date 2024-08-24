using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System;

namespace MtconnectTranspiler.Sinks.CSharp
{
    /// <summary>
    /// Representation of a MTConnect observation as described by the model browser.
    /// </summary>
    public sealed class ObservationType
    {
        /// <summary>
        /// The superclass of the type (aka is-a). For example: CONDITION, EVENT, or SAMPLE
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Name of the type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Descriptive summary of the type.
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// Indication of the version this type was introduced into the MTConnect standard.
        /// </summary>
        public string Introduced { get; set; }

        /// <summary>
        /// If applicable, the indiciation of the version this type was deprecated from the MTConnect standard.
        /// </summary>
        public string Deprecated { get; set; }

        /// <summary>
        /// Collection of properties copied from the observation type, including result types and unit types.
        /// </summary>
        public IProperty[] Properties { get; set; }

        /// <summary>
        /// Collection of any applicable sub-types for this observation type.
        /// </summary>
        public IClass[] SubTypes { get; set; }
    }
}
