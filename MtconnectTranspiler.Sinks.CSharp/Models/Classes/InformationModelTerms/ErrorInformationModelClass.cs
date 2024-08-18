#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.InformationModelTerms
{
	/// <summary>﻿<i>information model</i> that describes the <i>response document</i> returned by an <i>agent</i> when it encounters an error while interpreting a <i>request</i> for information from a <i>client</i> or when an <i>agent</i> experiences an error while publishing the <i>response</i> to a <i>request</i> for information.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375159_827377_1990">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ErrorInformationModelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375159_827377_1990";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(information model)}} that describes the {{term(response document)}} returned by an {{term(agent)}} when it encounters an error while interpreting a {{term(request)}} for information from a {{term(client)}} or when an {{term(agent)}} experiences an error while publishing the {{term(response)}} to a {{term(request)}} for information.&#10;
";

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
		public new ErrorInformationModelClassProperties Properties { get; } = new ErrorInformationModelClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ErrorInformationModelClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization.MTConnectInformationModelGeneralizationProperties" />.
		/// </summary>
		public class ErrorInformationModelClassProperties : Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization.MTConnectInformationModelGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}