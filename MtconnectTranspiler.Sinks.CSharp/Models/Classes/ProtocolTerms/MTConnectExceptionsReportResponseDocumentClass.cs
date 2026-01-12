#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>﻿<i>response document</i> returned by an <i>agent</i> when it encounters an exception in the <i>MTConnectAssets Response Document</i>, <i>MTConnectDevices Response Document</i> or <i>MTConnectStreams Response Document</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1744887463498_501211_23681">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class MTConnectExceptionsReportResponseDocumentClass : IClass
	{
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744887463498_501211_23681";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1744887463498_501211_23681";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(response document)}} returned by an {{term(agent)}} when it encounters an exception in the {{term(MTConnectAssets Response Document)}}, {{term(MTConnectDevices Response Document)}} or {{term(MTConnectStreams Response Document)}}.&#10;
";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentClass.Name" /></summary>
		public const string NAME = "MTConnectExceptionsReport Response Document";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_68e0225_1623664375173_527411_2040
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass);

		/// <inheritdoc />
		public new MTConnectExceptionsReportResponseDocumentClassProperties Properties { get; } = new MTConnectExceptionsReportResponseDocumentClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectExceptionsReportResponseDocumentClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass.MTConnectResponseDocumentClassProperties" />.
		/// </summary>
		public class MTConnectExceptionsReportResponseDocumentClassProperties : Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass.MTConnectResponseDocumentClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="MTConnectExceptionsReportResponseDocumentClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}