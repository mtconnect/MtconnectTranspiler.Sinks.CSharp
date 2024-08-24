namespace MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces
{
    /// <summary>
    /// Represents a property of a SysML class entity.
    /// </summary>
    public interface IProperty
    {
        /// <summary>
        /// Reference to the expected property type.
        /// </summary>
        System.Type Type { get; }

        /// <summary>
        /// Reference to the name of the SysML entity.
        /// </summary>
        string Name { get; }

        // TODO: Convert to Enum
        /// <summary>
        /// C# access modifier.
        /// </summary>
        string AccessModifier { get; }

        // TODO: Convert to Enum
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
        /// Relationship between two or more classes where this class contains an <see cref="Extension"/>.
        /// </summary>
        string Aggregation { get; }

        // Note: Extension.Extender
        /// <summary>
        /// Reference to the class this property adds to.
        /// </summary>
        string Extension { get; }

        /// <summary>
        /// Relationship between classes that allows one object instance to cause another to perform and action on its behalf
        /// </summary>
        string Association { get; }

        // Note: DefaultValue.Name
        /// <summary>
        /// Expected default value for an implementation of this property.
        /// </summary>
        string DefaultValue { get; }

        /// <summary>
        /// Concatenation of all Comments.
        /// </summary>
        string Summary { get; }
    }
}
