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
	/// <summary>﻿method for an <i>agent</i> to provide a continuous stream of information in response to a single <i>request</i> from a <i>client</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375154_395455_1977">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DataStreamingClass : IClass
	{
		/// <summary>Constant value for <see cref="DataStreamingClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664375154_395455_1977";
		/// <summary>Constant value for <see cref="DataStreamingClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375154_395455_1977";
		/// <summary>Constant value for <see cref="DataStreamingClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;method for an {{term(agent)}} to provide a continuous stream of information in response to a single {{term(request)}} from a {{term(client)}}.&#10;
";
		/// <summary>Constant value for <see cref="DataStreamingClass.Name" /></summary>
		public const string NAME = "data streaming";
		/// <summary>Constant value for <see cref="DataStreamingClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DataStreamingClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DataStreamingClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="DataStreamingClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_68e0225_1623664375187_272252_2094
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.StreamingDataClass);

		/// <inheritdoc />
		public new DataStreamingClassProperties Properties { get; } = new DataStreamingClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DataStreamingClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.StreamingDataClass.StreamingDataClassProperties" />.
		/// </summary>
		public class DataStreamingClassProperties : Mtconnect.Glossary.ProtocolTerms.StreamingDataClass.StreamingDataClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}