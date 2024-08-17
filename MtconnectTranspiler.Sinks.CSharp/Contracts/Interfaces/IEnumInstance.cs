namespace MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces
{
    public interface IEnumInstance
    {
        /// <summary>
        /// Reference to the name of the SysML entity.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Reference to the value of the SysML entity.
        /// </summary>
        object Value { get; }

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
    }
}
