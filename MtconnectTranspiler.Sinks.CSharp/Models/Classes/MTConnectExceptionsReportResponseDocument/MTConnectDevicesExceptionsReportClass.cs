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
	/// <summary>﻿<see cref="MTConnectExceptionsReport">MTConnectExceptionsReport</see> where exception is encountered in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1744801795004_49643_23355">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class MTConnectDevicesExceptionsReportClass : IClass
	{
		/// <summary>Constant value for <see cref="MTConnectDevicesExceptionsReportClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744801795004_49643_23355";
		/// <summary>Constant value for <see cref="MTConnectDevicesExceptionsReportClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1744801795004_49643_23355";
		/// <summary>Constant value for <see cref="MTConnectDevicesExceptionsReportClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(MTConnectExceptionsReport)}} where exception is encountered in the {{term(MTConnectDevices Response Document)}}.&#10;
";
		/// <summary>Constant value for <see cref="MTConnectDevicesExceptionsReportClass.Name" /></summary>
		public const string NAME = "MTConnectDevicesExceptionsReport";
		/// <summary>Constant value for <see cref="MTConnectDevicesExceptionsReportClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MTConnectDevicesExceptionsReportClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MTConnectDevicesExceptionsReportClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="MTConnectDevicesExceptionsReportClass.DeprecatedVersion" /></summary>
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
		public new MTConnectDevicesExceptionsReportClassProperties Properties { get; } = new MTConnectDevicesExceptionsReportClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectDevicesExceptionsReportClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Fundamentals.MTConnectProtocol.MTConnectExceptionsReportResponseDocument.MTConnectExceptionsReportClass.MTConnectExceptionsReportClassProperties" />.
		/// </summary>
		public class MTConnectDevicesExceptionsReportClassProperties : Mtconnect.Fundamentals.MTConnectProtocol.MTConnectExceptionsReportResponseDocument.MTConnectExceptionsReportClass.MTConnectExceptionsReportClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				HasMTConnectDevicesExceptionPart,
				HasHeaderPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="HasMTConnectDevicesExceptionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasMTConnectDevicesException</remarks>
			/// </summary>
			public new HasMTConnectDevicesExceptionPartProperty HasMTConnectDevicesExceptionPart { get; } = new HasMTConnectDevicesExceptionPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasMTConnectDevicesExceptionPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.Name" /></summary>
				public const string NAME = "hasMTConnectDevicesException";
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Exceptions";
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasMTConnectDevicesExceptionPartProperty.Multiplicity" /></summary>
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
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument.HeaderClass);
				
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
		/// List of constraint rules for <see cref="MTConnectDevicesExceptionsReportClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
