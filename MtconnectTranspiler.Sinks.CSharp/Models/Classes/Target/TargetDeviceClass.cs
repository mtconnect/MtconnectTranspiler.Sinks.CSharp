#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.Process.Target
{
	/// <summary>﻿reference to a <see cref="Device">Device</see> that is required to implement a <see cref="Process">Process</see> or a <see cref="Task">Task</see><br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1758718146180_5233_930">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class TargetDeviceClass : IClass
	{
		/// <summary>Constant value for <see cref="TargetDeviceClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1758718146180_5233_930";
		/// <summary>Constant value for <see cref="TargetDeviceClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1758718146180_5233_930";
		/// <summary>Constant value for <see cref="TargetDeviceClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;reference to a {{block(Device)}} that is required to implement a {{block(Process)}} or a {{block(Task)}}

&#10;
";
		/// <summary>Constant value for <see cref="TargetDeviceClass.Name" /></summary>
		public const string NAME = "TargetDevice";
		/// <summary>Constant value for <see cref="TargetDeviceClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="TargetDeviceClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="TargetDeviceClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.7";
		/// <summary>Constant value for <see cref="TargetDeviceClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _2024x_68e0225_1758718089527_408759_881
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.Process.Target.TargetClass);

		/// <inheritdoc />
		public new TargetDeviceClassProperties Properties { get; } = new TargetDeviceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="TargetDeviceClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.Process.Target.TargetClass.TargetClassProperties" />.
		/// </summary>
		public class TargetDeviceClassProperties : Mtconnect.AssetInformationModel.Process.Target.TargetClass.TargetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				DeviceUuid,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="DeviceUuidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DeviceUuid</remarks>
			/// </summary>
			public new DeviceUuidProperty DeviceUuid { get; } = new DeviceUuidProperty();
			
			/// <summary>﻿reference to the <see cref="Device.uuid">uuid in Device</see><br /><br /><br />
			/// </summary>
			public new sealed class DeviceUuidProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Name" /></summary>
				public const string NAME = "deviceUuid";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;reference to the {{property(Device::uuid)}}&#10;
";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.7";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x;MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(string);
				
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
		/// List of constraint rules for <see cref="TargetDeviceClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}