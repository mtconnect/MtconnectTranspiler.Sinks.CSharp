#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Configurations.Specifications
{
	/// <summary>﻿<see cref="Specification">Specification</see> that provides information used to assess the conformance of a variable to process requirements.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605643801279_773776_859">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ProcessSpecificationGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="ProcessSpecificationGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605643801279_773776_859";
		/// <summary>Constant value for <see cref="ProcessSpecificationGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605643801279_773776_859";
		/// <summary>Constant value for <see cref="ProcessSpecificationGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Specification)}} that provides information used to assess the conformance of a variable to process requirements.&#10;
";
		/// <summary>Constant value for <see cref="ProcessSpecificationGeneralization.Name" /></summary>
		public const string NAME = "ProcessSpecification";
		/// <summary>Constant value for <see cref="ProcessSpecificationGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ProcessSpecificationGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ProcessSpecificationGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="ProcessSpecificationGeneralization.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1580315898400_607214_47155
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Configurations.Specifications.SpecificationClass);

		/// <inheritdoc />
		public new ProcessSpecificationGeneralizationProperties Properties { get; } = new ProcessSpecificationGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ProcessSpecificationGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Configurations.Specifications.SpecificationClass.SpecificationClassProperties" />.
		/// </summary>
		public class ProcessSpecificationGeneralizationProperties : Mtconnect.DeviceInformationModel.Configurations.Specifications.SpecificationClass.SpecificationClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				HasSpecificationLimitsPart,
				HasControlLimitsPart,
				HasAlarmLimitsPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="HasSpecificationLimitsPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasSpecificationLimits</remarks>
			/// </summary>
			public new HasSpecificationLimitsPartProperty HasSpecificationLimitsPart { get; } = new HasSpecificationLimitsPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasSpecificationLimitsPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasSpecificationLimitsPartProperty.Name" /></summary>
				public const string NAME = "hasSpecificationLimits";
				/// <summary>Constant value for <see cref="HasSpecificationLimitsPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasSpecificationLimitsPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasSpecificationLimitsPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasSpecificationLimitsPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasSpecificationLimitsPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasSpecificationLimitsPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasSpecificationLimitsPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="HasSpecificationLimitsPartProperty.Association" /></summary>
				public const string ASSOCIATION = "SpecificationLimits";
				/// <summary>Constant value for <see cref="HasSpecificationLimitsPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: SpecificationLimitsClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.Specifications.SpecificationLimitsClass);
				
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
			/// <inheritdoc cref="HasControlLimitsPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasControlLimits</remarks>
			/// </summary>
			public new HasControlLimitsPartProperty HasControlLimitsPart { get; } = new HasControlLimitsPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasControlLimitsPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasControlLimitsPartProperty.Name" /></summary>
				public const string NAME = "hasControlLimits";
				/// <summary>Constant value for <see cref="HasControlLimitsPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasControlLimitsPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasControlLimitsPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasControlLimitsPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasControlLimitsPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasControlLimitsPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasControlLimitsPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="HasControlLimitsPartProperty.Association" /></summary>
				public const string ASSOCIATION = "ControlLimits";
				/// <summary>Constant value for <see cref="HasControlLimitsPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ControlLimitsClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.Specifications.ControlLimitsClass);
				
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
			/// <inheritdoc cref="HasAlarmLimitsPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAlarmLimits</remarks>
			/// </summary>
			public new HasAlarmLimitsPartProperty HasAlarmLimitsPart { get; } = new HasAlarmLimitsPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasAlarmLimitsPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasAlarmLimitsPartProperty.Name" /></summary>
				public const string NAME = "hasAlarmLimits";
				/// <summary>Constant value for <see cref="HasAlarmLimitsPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasAlarmLimitsPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasAlarmLimitsPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasAlarmLimitsPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasAlarmLimitsPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasAlarmLimitsPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasAlarmLimitsPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="HasAlarmLimitsPartProperty.Association" /></summary>
				public const string ASSOCIATION = "AlarmLimits";
				/// <summary>Constant value for <see cref="HasAlarmLimitsPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AlarmLimitsClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.Specifications.AlarmLimitsClass);
				
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