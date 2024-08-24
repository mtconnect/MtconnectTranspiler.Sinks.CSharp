#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples.OperationalState
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1679487876615_368541_256">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectDeviceWithOperationalStatesClass : IClass
	{
		/// <summary>Constant value for <see cref="MTConnectDeviceWithOperationalStatesClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1679487876615_368541_256";
		/// <summary>Constant value for <see cref="MTConnectDeviceWithOperationalStatesClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1679487876615_368541_256";
		/// <summary>Constant value for <see cref="MTConnectDeviceWithOperationalStatesClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="MTConnectDeviceWithOperationalStatesClass.Name" /></summary>
		public const string NAME = "MTConnect Device with Operational States";
		/// <summary>Constant value for <see cref="MTConnectDeviceWithOperationalStatesClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MTConnectDeviceWithOperationalStatesClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MTConnectDeviceWithOperationalStatesClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="MTConnectDeviceWithOperationalStatesClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_68e0225_1620240839406_285612_1596
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.DeviceClass);

		/// <inheritdoc />
		public new MTConnectDeviceWithOperationalStatesClassProperties Properties { get; } = new MTConnectDeviceWithOperationalStatesClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectDeviceWithOperationalStatesClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.DeviceClass.DeviceClassProperties" />.
		/// </summary>
		public class MTConnectDeviceWithOperationalStatesClassProperties : Mtconnect.DeviceInformationModel.DeviceClass.DeviceClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}