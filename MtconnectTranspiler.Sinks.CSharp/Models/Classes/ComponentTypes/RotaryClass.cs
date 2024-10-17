#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="Component Types::Axis">Component Types::Axis</see> that provides rotation about a fixed axis.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382015_53595_42288">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RotaryClass : IClass
	{
		/// <summary>Constant value for <see cref="RotaryClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579572382015_53595_42288";
		/// <summary>Constant value for <see cref="RotaryClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382015_53595_42288";
		/// <summary>Constant value for <see cref="RotaryClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component Types::Axis)}} that provides rotation about a fixed axis.&#10;
";
		/// <summary>Constant value for <see cref="RotaryClass.Name" /></summary>
		public const string NAME = "Rotary";
		/// <summary>Constant value for <see cref="RotaryClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="RotaryClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="RotaryClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="RotaryClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1579572381972_553005_42207
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.AxisClass);

		/// <inheritdoc />
		public new RotaryClassProperties Properties { get; } = new RotaryClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="RotaryClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.AxisClass.AxisClassProperties" />.
		/// </summary>
		public class RotaryClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.AxisClass.AxisClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				ObservesLoad,
				ObservesTemperature,
				ObservesRotaryVelocity,
				ObservesAxisFeedrate,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ObservesLoadProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesLoad</remarks>
			/// </summary>
			public new ObservesLoadProperty ObservesLoad { get; } = new ObservesLoadProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesLoadProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesLoadProperty.Name" /></summary>
				public const string NAME = "observesLoad";
				/// <summary>Constant value for <see cref="ObservesLoadProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesLoadProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesLoadProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesLoadProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesLoadProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesLoadProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesLoadProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesLoadProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesLoadProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: LoadClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.LoadClass);
				
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
			/// <inheritdoc cref="ObservesTemperatureProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesTemperature</remarks>
			/// </summary>
			public new ObservesTemperatureProperty ObservesTemperature { get; } = new ObservesTemperatureProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesTemperatureProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesTemperatureProperty.Name" /></summary>
				public const string NAME = "observesTemperature";
				/// <summary>Constant value for <see cref="ObservesTemperatureProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesTemperatureProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesTemperatureProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesTemperatureProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesTemperatureProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesTemperatureProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesTemperatureProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesTemperatureProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesTemperatureProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: TemperatureClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.TemperatureClass);
				
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
			/// <inheritdoc cref="ObservesRotaryVelocityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesRotaryVelocity</remarks>
			/// </summary>
			public new ObservesRotaryVelocityProperty ObservesRotaryVelocity { get; } = new ObservesRotaryVelocityProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesRotaryVelocityProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityProperty.Name" /></summary>
				public const string NAME = "observesRotaryVelocity";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: RotaryVelocityClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.RotaryVelocityClass);
				
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
			/// <inheritdoc cref="ObservesAxisFeedrateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesAxisFeedrate</remarks>
			/// </summary>
			public new ObservesAxisFeedrateProperty ObservesAxisFeedrate { get; } = new ObservesAxisFeedrateProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesAxisFeedrateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesAxisFeedrateProperty.Name" /></summary>
				public const string NAME = "observesAxisFeedrate";
				/// <summary>Constant value for <see cref="ObservesAxisFeedrateProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesAxisFeedrateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesAxisFeedrateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesAxisFeedrateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesAxisFeedrateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesAxisFeedrateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesAxisFeedrateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesAxisFeedrateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesAxisFeedrateProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AxisFeedrateClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.AxisFeedrateClass);
				
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