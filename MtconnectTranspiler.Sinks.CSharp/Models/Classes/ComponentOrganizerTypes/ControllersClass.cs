#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes.ComponentOrganizerTypes
{
	/// <summary>﻿<see cref="Component">Component</see> that <i>organize</i>s <see cref="Controller">Controller</see> entities.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1648551529939_657918_1127">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class ControllersClass : IClass
	{
		/// <summary>Constant value for <see cref="ControllersClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1648551529939_657918_1127";
		/// <summary>Constant value for <see cref="ControllersClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1648551529939_657918_1127";
		/// <summary>Constant value for <see cref="ControllersClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} that {{termplural(organize)}} {{block(Controller)}} entities.&#10;
";
		/// <summary>Constant value for <see cref="ControllersClass.Name" /></summary>
		public const string NAME = "Controllers";
		/// <summary>Constant value for <see cref="ControllersClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ControllersClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ControllersClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.0";
		/// <summary>Constant value for <see cref="ControllersClass.DeprecatedVersion" /></summary>
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
		public Type Generalization => null;

		/// <inheritdoc />
		public new ControllersClassProperties Properties { get; } = new ControllersClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ControllersClass" />.
		/// </summary>
		public class ControllersClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Device,
				Controller,
			};
			/// <summary>
			/// <inheritdoc cref="DeviceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Device</remarks>
			/// </summary>
			public DeviceProperty Device { get; } = new DeviceProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class DeviceProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DeviceProperty.Name" /></summary>
				public const string NAME = "device";
				/// <summary>Constant value for <see cref="DeviceProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="DeviceProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="DeviceProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DeviceProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="DeviceProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DeviceProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="DeviceProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="DeviceProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DeviceProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="DeviceProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DeviceClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DeviceClass);
				
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
			/// <inheritdoc cref="ControllerProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Controller</remarks>
			/// </summary>
			public ControllerProperty Controller { get; } = new ControllerProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class ControllerProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ControllerProperty.Name" /></summary>
				public const string NAME = "controller";
				/// <summary>Constant value for <see cref="ControllerProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ControllerProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ControllerProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ControllerProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ControllerProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ControllerProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="ControllerProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="ControllerProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ControllerProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="ControllerProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ControllerClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ControllerClass);
				
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
		/// List of constraint rules for <see cref="ControllersClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
