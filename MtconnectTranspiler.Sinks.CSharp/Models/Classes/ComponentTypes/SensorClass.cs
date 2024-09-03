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
	/// <summary>﻿<see cref="Component">Component</see> that responds to a physical stimulus and transmits a resulting impulse or value from a sensing unit.<br /><br /><br />Description<br /><br />If modeling individual sensors, then sensor should be associated with the <see cref="Component">Component</see> that the measured value is most closely associated.<br /><br />When modeled as an <see cref="Auxiliary">Auxiliary</see>, sensor <b>SHOULD</b> represent an integrated <i>sensor unit</i> system that provides signal processing, conversion, and communications. A <i>sensor unit</i> may have multiple <i>sensing element</i>s.<br /><br />See <see cref="SensorConfiguration">SensorConfiguration</see> for more details on the use and configuration of a <see cref="Sensor">Sensor</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382017_874684_42291">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SensorClass : IClass
	{
		/// <summary>Constant value for <see cref="SensorClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579572382017_874684_42291";
		/// <summary>Constant value for <see cref="SensorClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382017_874684_42291";
		/// <summary>Constant value for <see cref="SensorClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} that responds to a physical stimulus and transmits a resulting impulse or value from a sensing unit.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;If modeling individual sensors, then sensor should be associated with the {{block(Component)}} that the measured value is most closely associated.

When modeled as an {{block(Auxiliary)}}, sensor **SHOULD** represent an integrated {{term(sensor unit)}} system that provides signal processing, conversion, and communications. A {{term(sensor unit)}} may have multiple {{termplural(sensing element)}}.

See {{block(SensorConfiguration)}} for more details on the use and configuration of a {{block(Sensor)}}.&#10;
";
		/// <summary>Constant value for <see cref="SensorClass.Name" /></summary>
		public const string NAME = "Sensor";
		/// <summary>Constant value for <see cref="SensorClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="SensorClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="SensorClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="SensorClass.DeprecatedVersion" /></summary>
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
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public new SensorClassProperties Properties { get; } = new SensorClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="SensorClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties" />.
		/// </summary>
		public class SensorClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}