#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.InformationModelTerms
{
	/// <summary>﻿<i>information model</i> that defines the semantics of the MTConnect Standard.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375172_792733_2037">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectInformationModelGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="MTConnectInformationModelGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664375172_792733_2037";
		/// <summary>Constant value for <see cref="MTConnectInformationModelGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375172_792733_2037";
		/// <summary>Constant value for <see cref="MTConnectInformationModelGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(information model)}} that defines the semantics of the MTConnect Standard.&#10;
";
		/// <summary>Constant value for <see cref="MTConnectInformationModelGeneralization.Name" /></summary>
		public const string NAME = "MTConnect Information Model";
		/// <summary>Constant value for <see cref="MTConnectInformationModelGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MTConnectInformationModelGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MTConnectInformationModelGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="MTConnectInformationModelGeneralization.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1623664375166_600079_2015
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.InformationModelClass);

		/// <inheritdoc />
		public new MTConnectInformationModelGeneralizationProperties Properties { get; } = new MTConnectInformationModelGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectInformationModelGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.InformationModelClass.InformationModelClassProperties" />.
		/// </summary>
		public class MTConnectInformationModelGeneralizationProperties : Mtconnect.Glossary.InformationModelClass.InformationModelClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}