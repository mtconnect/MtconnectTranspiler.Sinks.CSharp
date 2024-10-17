#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1620206902894_670781_812">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AlarmLimitResultClass : IClass
	{
		/// <summary>Constant value for <see cref="AlarmLimitResultClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1620206902894_670781_812";
		/// <summary>Constant value for <see cref="AlarmLimitResultClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1620206902894_670781_812";
		/// <summary>Constant value for <see cref="AlarmLimitResultClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="AlarmLimitResultClass.Name" /></summary>
		public const string NAME = "AlarmLimitResult";
		/// <summary>Constant value for <see cref="AlarmLimitResultClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="AlarmLimitResultClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="AlarmLimitResultClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="AlarmLimitResultClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1579566531114_503405_25727
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.DataSetClass);

		/// <inheritdoc />
		public new AlarmLimitResultClassProperties Properties { get; } = new AlarmLimitResultClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AlarmLimitResultClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties" />.
		/// </summary>
		public class AlarmLimitResultClassProperties : Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				UpperLimit,
				UpperWarning,
				LowerWarning,
				LowerLimit,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="UpperLimitProperty" path="/summary" /><br/>
			/// <remarks>Original Name: UpperLimit</remarks>
			/// </summary>
			public new UpperLimitProperty UpperLimit { get; } = new UpperLimitProperty();
			
			/// <summary>﻿upper conformance boundary for a variable.<br /><br />&gt; Note: immediate concern or action may be required.<br /><br /><br /><br /><br />
			/// </summary>
			public new sealed class UpperLimitProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UpperLimitProperty.Name" /></summary>
				public const string NAME = "UpperLimit";
				/// <summary>Constant value for <see cref="UpperLimitProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;upper conformance boundary for a variable.

> Note: immediate concern or action may be required.

&#10;
";
				/// <summary>Constant value for <see cref="UpperLimitProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UpperLimitProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="UpperLimitProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.7";
				/// <summary>Constant value for <see cref="UpperLimitProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UpperLimitProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="UpperLimitProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="UpperLimitProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UpperLimitProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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
			/// <inheritdoc cref="UpperWarningProperty" path="/summary" /><br/>
			/// <remarks>Original Name: UpperWarning</remarks>
			/// </summary>
			public new UpperWarningProperty UpperWarning { get; } = new UpperWarningProperty();
			
			/// <summary>﻿upper boundary indicating increased concern and supervision may be required.<br /><br /><br />
			/// </summary>
			public new sealed class UpperWarningProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UpperWarningProperty.Name" /></summary>
				public const string NAME = "UpperWarning";
				/// <summary>Constant value for <see cref="UpperWarningProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;upper boundary indicating increased concern and supervision may be required.&#10;
";
				/// <summary>Constant value for <see cref="UpperWarningProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UpperWarningProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="UpperWarningProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.7";
				/// <summary>Constant value for <see cref="UpperWarningProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UpperWarningProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="UpperWarningProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="UpperWarningProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UpperWarningProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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
			/// <inheritdoc cref="LowerWarningProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LowerWarning</remarks>
			/// </summary>
			public new LowerWarningProperty LowerWarning { get; } = new LowerWarningProperty();
			
			/// <summary>﻿lower boundary indicating increased concern and supervision may be required.<br /><br /><br />
			/// </summary>
			public new sealed class LowerWarningProperty : IProperty
			{
				/// <summary>Constant value for <see cref="LowerWarningProperty.Name" /></summary>
				public const string NAME = "LowerWarning";
				/// <summary>Constant value for <see cref="LowerWarningProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;lower boundary indicating increased concern and supervision may be required.&#10;
";
				/// <summary>Constant value for <see cref="LowerWarningProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="LowerWarningProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="LowerWarningProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.7";
				/// <summary>Constant value for <see cref="LowerWarningProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="LowerWarningProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="LowerWarningProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="LowerWarningProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="LowerWarningProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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
			/// <inheritdoc cref="LowerLimitProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LowerLimit</remarks>
			/// </summary>
			public new LowerLimitProperty LowerLimit { get; } = new LowerLimitProperty();
			
			/// <summary>﻿lower conformance boundary for a variable.<br /><br />&gt; Note: immediate concern or action may be required.<br /><br /><br /><br /><br />
			/// </summary>
			public new sealed class LowerLimitProperty : IProperty
			{
				/// <summary>Constant value for <see cref="LowerLimitProperty.Name" /></summary>
				public const string NAME = "LowerLimit";
				/// <summary>Constant value for <see cref="LowerLimitProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;lower conformance boundary for a variable.

> Note: immediate concern or action may be required.

&#10;
";
				/// <summary>Constant value for <see cref="LowerLimitProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="LowerLimitProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="LowerLimitProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.7";
				/// <summary>Constant value for <see cref="LowerLimitProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="LowerLimitProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="LowerLimitProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="LowerLimitProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="LowerLimitProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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