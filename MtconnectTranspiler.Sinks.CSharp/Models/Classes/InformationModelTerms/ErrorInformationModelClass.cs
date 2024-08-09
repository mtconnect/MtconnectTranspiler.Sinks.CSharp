using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.InformationModelTerms
{
	/// <summary>
	/// <i>information model</i> that describes the <i>response document</i> returned by an <i>agent</i> when it encounters an error while interpreting a <i>request</i> for information from a <i>client</i> or when an <i>agent</i> experiences an error while publishing the <i>response</i> to a <i>request</i> for information.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375159_827377_1990">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ErrorInformationModelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375159_827377_1990";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>information model</i> that describes the <i>response document</i> returned by an <i>agent</i> when it encounters an error while interpreting a <i>request</i> for information from a <i>client</i> or when an <i>agent</i> experiences an error while publishing the <i>response</i> to a <i>request</i> for information.";

		/// <inheritdoc />
		public string Name => "Error Information Model";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375172_792733_2037
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization);

		/// <inheritdoc />
		public ErrorInformationModelClassProperties Properties { get; } = new ErrorInformationModelClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ErrorInformationModelClassProperties : Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization.MTConnectInformationModelGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}