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
        /// Collection of hard-coded enum references. Note: Each hard-coded enum property lazy-loads the target entity.
        /// </summary>
        IEnum[] Enums { get; }

        /// <summary>
        /// Concatenation of all Comments.
        /// </summary>
        string Summary { get; }
    }
}
