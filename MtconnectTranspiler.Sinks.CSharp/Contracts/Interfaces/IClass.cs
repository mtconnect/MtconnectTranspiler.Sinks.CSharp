
using System;

namespace MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces
{
    /// <summary>
    /// Representation of a SysML package entity related to a literal C# class. Package classes behave slightly similar to static classes with lazy-loaded properties.
    /// </summary>
    public interface IPackage
    {
        /// <summary>
        /// Reference to the SysML Id defined in the XMI document.
        /// </summary>
        string ReferenceId { get; }

        /// <summary>
        /// Reference to the SysML name defined in the XMI document.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Collection of hard-coded package references. Note: Each hard-coded package property lazy-loads the target entity.
        /// </summary>
        IPackage[] Packages { get; }

        /// <summary>
        /// Collection of hard-coded class references. Note: Each hard-coded class property lazy-loads the target entity.
        /// </summary>
        IClass[] Classes { get; }

        /// <summary>
        /// Concatenation of all Comments.
        /// </summary>
        string Summary { get; }
    }
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
    /// <summary>
    /// Represents a collection of C# class properties translated from a SysML class entity.
    /// </summary>
    public interface IPropertyList
    {
        /// <summary>
        /// Reference to the collection of hard-coded SysML class entity properties.
        /// </summary>
        IProperty[] Properties { get; }
    }
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

        string Aggregation { get; }

        // Note: Extension.Extender
        string Extension { get; }

        string Association { get; }

        // Note: DefaultValue.Name
        string DefaultValue { get; }

        /// <summary>
        /// Concatenation of all Comments.
        /// </summary>
        string Summary { get; }
    }
}
