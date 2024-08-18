#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.InformationModelTerms
{
	/// <summary>﻿<i>information model</i> that provides semantic models for <i>Asset</i>s.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375143_753891_1954">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AssetInformationModelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375143_753891_1954";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(information model)}} that provides semantic models for {{termplural(Asset)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Asset Information Model";
		
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
		public new AssetInformationModelClassProperties Properties { get; } = new AssetInformationModelClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AssetInformationModelClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization.MTConnectInformationModelGeneralizationProperties" />.
		/// </summary>
		public class AssetInformationModelClassProperties : Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization.MTConnectInformationModelGeneralizationProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}