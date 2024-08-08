using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.IndustrialTerms
{
	/// <summary>
	/// property holder.  > Note 1 to entry: Property holders are used to define properties that have no specific owner, or “top level” properties. These properties are generally referenced by other properties. <seealso href="https://www.google.com/search?q=https://www.omg.org/spec/NIEM-UML/1.0&btnI=I">https://www.omg.org/spec/NIEM-UML/1.0</seealso>  > Note 2 to entry: Property holder is equivalent to one topmost class of which all other classes are subclasses.  !MTConnect Terms.png!
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ThingClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581733974550_623533_615";
		
		/// <inheritdoc />
		public string Summary => @"/// property holder.  > Note 1 to entry: Property holders are used to define properties that have no specific owner, or “top level” properties. These properties are generally referenced by other properties. <seealso href=""https://www.google.com/search?q=https://www.omg.org/spec/NIEM-UML/1.0&btnI=I"">https://www.omg.org/spec/NIEM-UML/1.0</seealso>  > Note 2 to entry: Property holder is equivalent to one topmost class of which all other classes are subclasses.  !MTConnect Terms.png!";

		/// <inheritdoc />
		public string Name => "ThingClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		public IPropertyList Properties => null;

	}
}