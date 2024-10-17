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
	/// <summary>﻿<see cref="System">System</see> that provides distribution and management of fluids that remove heat from a piece of equipment.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381979_456626_42219">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CoolantClass : IClass
	{
		/// <summary>Constant value for <see cref="CoolantClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579572381979_456626_42219";
		/// <summary>Constant value for <see cref="CoolantClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381979_456626_42219";
		/// <summary>Constant value for <see cref="CoolantClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(System)}} that provides distribution and management of fluids that remove heat from a piece of equipment.&#10;
";
		/// <summary>Constant value for <see cref="CoolantClass.Name" /></summary>
		public const string NAME = "Coolant";
		/// <summary>Constant value for <see cref="CoolantClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="CoolantClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="CoolantClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="CoolantClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1579572382020_336298_42297
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass);

		/// <inheritdoc />
		public new CoolantClassProperties Properties { get; } = new CoolantClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CoolantClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass.SystemClassProperties" />.
		/// </summary>
		public class CoolantClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass.SystemClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				ObservesConcentration,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ObservesConcentrationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesConcentration</remarks>
			/// </summary>
			public new ObservesConcentrationProperty ObservesConcentration { get; } = new ObservesConcentrationProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesConcentrationProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesConcentrationProperty.Name" /></summary>
				public const string NAME = "observesConcentration";
				/// <summary>Constant value for <see cref="ObservesConcentrationProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesConcentrationProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesConcentrationProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesConcentrationProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesConcentrationProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesConcentrationProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesConcentrationProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesConcentrationProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesConcentrationProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ConcentrationClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.ConcentrationClass);
				
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