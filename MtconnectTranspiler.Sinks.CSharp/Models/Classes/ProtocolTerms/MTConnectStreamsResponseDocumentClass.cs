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
	/// <summary>﻿<i>response document</i> published by an <i>MTConnect Agent</i> in response to a <i>current request</i> or a <i>sample request</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375174_472178_2046">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectStreamsResponseDocumentClass : IClass
	{
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664375174_472178_2046";
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375174_472178_2046";
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(response document)}} published by an {{term(MTConnect Agent)}} in response to a {{term(current request)}} or a {{term(sample request)}}.&#10;
";
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentClass.Name" /></summary>
		public const string NAME = "MTConnectStreams Response Document";
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentClass.DeprecatedVersion" /></summary>
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
		public new MTConnectStreamsResponseDocumentClassProperties Properties { get; } = new MTConnectStreamsResponseDocumentClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectStreamsResponseDocumentClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass.MTConnectResponseDocumentClassProperties" />.
		/// </summary>
		public class MTConnectStreamsResponseDocumentClassProperties : Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass.MTConnectResponseDocumentClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}