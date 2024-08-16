using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.Devices
{
	/// <summary>
	﻿/// <see cref="Device">Device</see> composed of an <i>MTConnect Agent</i> and all its connected data sources.<br/><br />Description<br/>An <see cref="Agent">Agent</see> <b>MUST</b> be provided by all <i>MTConnect Agent</i> implementations.<br /><br />An <see cref="Agent">Agent</see> <b>MUST</b> provide notifications when devices are added or changed.<br /><br />An <see cref="Agent">Agent</see> <b>MUST</b> provide connection information for each data source currently supplying data to the <i>MTConnect Agent</i>.<br /><br />An <see cref="Agent">Agent</see> <b>MAY</b> provide information about telemetry relating to data sources.<br /><br />An <see cref="Agent">Agent</see> <b>MAY</b> provide information about the <i>MTConnect Agent</i> resource utilization.<br /><br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605101231735_42972_30">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AgentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605101231735_42972_30";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Device)}} composed of an {{term(MTConnect Agent)}} and all its connected data sources.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;An {{block(Agent)}} **MUST** be provided by all {{term(MTConnect Agent)}} implementations.

An {{block(Agent)}} **MUST** provide notifications when devices are added or changed.

An {{block(Agent)}} **MUST** provide connection information for each data source currently supplying data to the {{term(MTConnect Agent)}}.

An {{block(Agent)}} **MAY** provide information about telemetry relating to data sources.

An {{block(Agent)}} **MAY** provide information about the {{term(MTConnect Agent)}} resource utilization.
&#10;
";

		/// <inheritdoc />
		public string Name => "Agent";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1620240839406_285612_1596
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.DeviceClass);

		/// <inheritdoc />
		public AgentClassProperties Properties { get; } = new AgentClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class AgentClassProperties : Mtconnect.DeviceInformationModel.DeviceClass.DeviceClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}