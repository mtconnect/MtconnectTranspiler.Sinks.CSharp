#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle
{
	/// <summary>﻿constrained scalar value associated with a cutting tool.<br /><br /><br />Description<br /><br />A <see cref="Measurement">Measurement</see> is specific to the tool management policy at a particular shop. The tool zero reference point or gauge line will be different depending on the particular implementation and will be assumed to be consistent within the shop. MTConnect Standard does not standardize the manufacturing process or the definition of the zero point.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_C09F377D_8946_421b_B746_E23C01D97EAC">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ToolingMeasurementGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="ToolingMeasurementGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_C09F377D_8946_421b_B746_E23C01D97EAC";
		/// <summary>Constant value for <see cref="ToolingMeasurementGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_C09F377D_8946_421b_B746_E23C01D97EAC";
		/// <summary>Constant value for <see cref="ToolingMeasurementGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;constrained scalar value associated with a cutting tool.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;A {{block(Measurement)}} is specific to the tool management policy at a particular shop. The tool zero reference point or gauge line will be different depending on the particular implementation and will be assumed to be consistent within the shop. MTConnect Standard does not standardize the manufacturing process or the definition of the zero point.&#10;
";
		/// <summary>Constant value for <see cref="ToolingMeasurementGeneralization.Name" /></summary>
		public const string NAME = "ToolingMeasurement";
		/// <summary>Constant value for <see cref="ToolingMeasurementGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ToolingMeasurementGeneralization.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="ToolingMeasurementGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="ToolingMeasurementGeneralization.DeprecatedVersion" /></summary>
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
		/// Original Type: _2024x_68e0225_1727793846441_986747_23754
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.Pallet.Measurements.MeasurementClass);

		/// <inheritdoc />
		public new ToolingMeasurementGeneralizationProperties Properties { get; } = new ToolingMeasurementGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ToolingMeasurementGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.Pallet.Measurements.MeasurementClass.MeasurementClassProperties" />.
		/// </summary>
		public class ToolingMeasurementGeneralizationProperties : Mtconnect.AssetInformationModel.Pallet.Measurements.MeasurementClass.MeasurementClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Code,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="CodeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Code</remarks>
			/// </summary>
			public new CodeProperty Code { get; } = new CodeProperty();
			
			/// <summary>﻿shop specific code for the measurement. <br /><br />ISO 13399 codes <b>MAY</b> be used for these codes as well. <br /><br />See <see cref="Cutting Tool Measurement Subtypes">Cutting Tool Measurement Subtypes</see> and <see cref="Cutting Item Measurement Subtypes">Cutting Item Measurement Subtypes</see> for details on <see cref="Measurement">Measurement</see> types and their respective <see cref="Measurement.code">code in Measurement</see> values.<br /><br /><br />
			/// </summary>
			public new sealed class CodeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CodeProperty.Name" /></summary>
				public const string NAME = "code";
				/// <summary>Constant value for <see cref="CodeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;shop specific code for the measurement. 

ISO 13399 codes **MAY** be used for these codes as well. 

See {{package(Cutting Tool Measurement Subtypes)}} and {{package(Cutting Item Measurement Subtypes)}} for details on {{block(Measurement)}} types and their respective {{property(Measurement::code)}} values.&#10;
";
				/// <summary>Constant value for <see cref="CodeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CodeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CodeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="CodeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CodeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CodeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CodeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CodeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CodeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CodeEnumMetaClass);
				
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
			}
		};

	}
}