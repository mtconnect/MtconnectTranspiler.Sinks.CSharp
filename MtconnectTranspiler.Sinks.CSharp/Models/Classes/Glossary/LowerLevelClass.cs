using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// nested element that is below a higher level element.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375168_248191_2022">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class LowerLevelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375168_248191_2022";
		
		/// <inheritdoc />
		public string Summary => @"/// nested element that is below a higher level element.";

		/// <inheritdoc />
		public string Name => "lower level";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1623664375146_261316_1961
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.XMLTerms.ChildElementGeneralization);

		/// <inheritdoc />
		public LowerLevelClassProperties Properties { get; } = new LowerLevelClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class LowerLevelClassProperties : Mtconnect.Glossary.XMLTerms.ChildElementGeneralization.ChildElementGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}