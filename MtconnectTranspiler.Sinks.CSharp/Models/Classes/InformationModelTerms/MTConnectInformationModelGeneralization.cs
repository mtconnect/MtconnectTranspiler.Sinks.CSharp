using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.InformationModelTerms
{
	/// <summary>
	/// <i>information model</i> that defines the semantics of the MTConnect Standard.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375172_792733_2037">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MTConnectInformationModelGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375172_792733_2037";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>information model</i> that defines the semantics of the MTConnect Standard.";

		/// <inheritdoc />
		public string Name => "MTConnect Information Model";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375166_600079_2015
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.InformationModelClass);

		/// <inheritdoc />
		public MTConnectInformationModelGeneralizationProperties Properties { get; } = new MTConnectInformationModelGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class MTConnectInformationModelGeneralizationProperties : Mtconnect.Glossary.InformationModelClass.InformationModelClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}