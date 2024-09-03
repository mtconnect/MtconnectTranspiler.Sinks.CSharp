#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingToolMeasurementSubtypes
{
	/// <summary>﻿distance measured along the X axis from that point of the item closest to the workpiece, including the cutting item for a tool item but excluding a protruding locking mechanism for an adaptive item, to either the front of the flange on a flanged body or the beginning of the connection interface feature on the machine side for cylindrical or prismatic shanks.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1582919119498_219776_1408">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class BodyLengthMaxClass : IClass
	{
		/// <summary>Constant value for <see cref="BodyLengthMaxClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1582919119498_219776_1408";
		/// <summary>Constant value for <see cref="BodyLengthMaxClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1582919119498_219776_1408";
		/// <summary>Constant value for <see cref="BodyLengthMaxClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;distance measured along the X axis from that point of the item closest to the workpiece, including the cutting item for a tool item but excluding a protruding locking mechanism for an adaptive item, to either the front of the flange on a flanged body or the beginning of the connection interface feature on the machine side for cylindrical or prismatic shanks.&#10;
";
		/// <summary>Constant value for <see cref="BodyLengthMaxClass.Name" /></summary>
		public const string NAME = "BodyLengthMax";
		/// <summary>Constant value for <see cref="BodyLengthMaxClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="BodyLengthMaxClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="BodyLengthMaxClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="BodyLengthMaxClass.DeprecatedVersion" /></summary>
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
		/// Original Type: EAID_C09F377D_8946_421b_B746_E23C01D97EAC
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.MeasurementClass);

		/// <inheritdoc />
		public new BodyLengthMaxClassProperties Properties { get; } = new BodyLengthMaxClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="BodyLengthMaxClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.MeasurementClass.MeasurementClassProperties" />.
		/// </summary>
		public class BodyLengthMaxClassProperties : Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.MeasurementClass.MeasurementClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Code,
				Units,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="CodeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Code</remarks>
			/// </summary>
			public new CodeProperty Code { get; } = new CodeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class CodeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CodeProperty.Name" /></summary>
				public const string NAME = "code";
				/// <summary>Constant value for <see cref="CodeProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="CodeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CodeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CodeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="CodeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CodeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="CodeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="CodeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CodeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "LBX";

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
			/// <summary>
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public new UnitsProperty Units { get; } = new UnitsProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class UnitsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UnitsProperty.Name" /></summary>
				public const string NAME = "units";
				/// <summary>Constant value for <see cref="UnitsProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="UnitsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UnitsProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="UnitsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="UnitsProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="UnitsProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "MILLIMETER";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UnitEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnumMetaClass);
				
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