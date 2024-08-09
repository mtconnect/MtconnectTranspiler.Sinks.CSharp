using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// indication that specific content in an <i>MTConnect Document</i> may be changed to <i>deprecated</i> in a future release of the standard.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375155_239668_1979">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DeprecationWarningClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375155_239668_1979";
		
		/// <inheritdoc />
		public string Summary => @"/// indication that specific content in an <i>MTConnect Document</i> may be changed to <i>deprecated</i> in a future release of the standard.";

		/// <inheritdoc />
		public string Name => "deprecation warning";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public DeprecationWarningClassProperties Properties { get; } = new DeprecationWarningClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DeprecationWarningClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}