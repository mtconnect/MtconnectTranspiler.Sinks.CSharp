#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectExceptionsReportResponseDocument
{
	/// <summary>﻿<see cref="MTConnectExceptionsReport">MTConnectExceptionsReport</see> where exception is encountered in the <i>MTConnectAssets Response Document</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1744801819916_205144_23417">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class MTConnectAssetsExceptionsReportClass : IClass
	{
		/// <summary>Constant value for <see cref="MTConnectAssetsExceptionsReportClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744801819916_205144_23417";
		/// <summary>Constant value for <see cref="MTConnectAssetsExceptionsReportClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1744801819916_205144_23417";
		/// <summary>Constant value for <see cref="MTConnectAssetsExceptionsReportClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(MTConnectExceptionsReport)}} where exception is encountered in the {{term(MTConnectAssets Response Document)}}.&#10;
";
		/// <summary>Constant value for <see cref="MTConnectAssetsExceptionsReportClass.Name" /></summary>
		public const string NAME = "MTConnectAssetsExceptionsReport";
		/// <summary>Constant value for <see cref="MTConnectAssetsExceptionsReportClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MTConnectAssetsExceptionsReportClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MTConnectAssetsExceptionsReportClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="MTConnectAssetsExceptionsReportClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _2024x_68e0225_1744801655431_368883_23324
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectExceptionsReportResponseDocument.MTConnectExceptionsReportClass);

		/// <inheritdoc />
		public new MTConnectAssetsExceptionsReportClassProperties Properties { get; } = new MTConnectAssetsExceptionsReportClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectAssetsExceptionsReportClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Fundamentals.MTConnectProtocol.MTConnectExceptionsReportResponseDocument.MTConnectExceptionsReportClass.MTConnectExceptionsReportClassProperties" />.
		/// </summary>
		public class MTConnectAssetsExceptionsReportClassProperties : Mtconnect.Fundamentals.MTConnectProtocol.MTConnectExceptionsReportResponseDocument.MTConnectExceptionsReportClass.MTConnectExceptionsReportClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				HasMTConnectAssetsExceptionPart,
				HasHeaderPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="HasMTConnectAssetsExceptionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasMTConnectAssetsException</remarks>
			/// </summary>
			public new HasMTConnectAssetsExceptionPartProperty HasMTConnectAssetsExceptionPart { get; } = new HasMTConnectAssetsExceptionPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasMTConnectAssetsExceptionPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.Name" /></summary>
				public const string NAME = "hasMTConnectAssetsException";
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Exceptions";
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasMTConnectAssetsExceptionPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1..*";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ExceptionClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectExceptionsReportResponseDocument.ExceptionClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="HasHeaderPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasHeader</remarks>
			/// </summary>
			public new HasHeaderPartProperty HasHeaderPart { get; } = new HasHeaderPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasHeaderPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Name" /></summary>
				public const string NAME = "hasHeader";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Header";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: HeaderClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument.HeaderClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="MTConnectAssetsExceptionsReportClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
