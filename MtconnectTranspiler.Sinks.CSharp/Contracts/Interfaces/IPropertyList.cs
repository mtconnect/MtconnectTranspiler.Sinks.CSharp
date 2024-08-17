namespace MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces
{
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
}
