using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// control placed on an element of a <i>feature</i> such as its size, location, or form, which may be a specification limit, a nominal with tolerance, or some other numerical or non-numerical control. <seealso href="https://www.google.com/search?q=QIF 3.0 3.4.29&btnI=I">QIF 3.0 3.4.29</seealso>. <seealso href="https://www.google.com/search?q=AS9102-B&btnI=I">AS9102-B</seealso>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1677579209252_492424_316">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CharacteristicClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1677579209252_492424_316";
		
		/// <inheritdoc />
		public string Summary => @"/// control placed on an element of a <i>feature</i> such as its size, location, or form, which may be a specification limit, a nominal with tolerance, or some other numerical or non-numerical control. <seealso href=""https://www.google.com/search?q=QIF 3.0 3.4.29&btnI=I"">QIF 3.0 3.4.29</seealso>. <seealso href=""https://www.google.com/search?q=AS9102-B&btnI=I"">AS9102-B</seealso>.";

		/// <inheritdoc />
		public string Name => "characteristic";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public CharacteristicClassProperties Properties { get; } = new CharacteristicClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class CharacteristicClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}