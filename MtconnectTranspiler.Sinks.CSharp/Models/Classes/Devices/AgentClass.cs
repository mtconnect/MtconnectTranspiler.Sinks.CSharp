using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.Devices
{
	/// <summary>
	/// <see cref="Device">Device</see> composed of an <i>MTConnect Agent</i> and all its connected data sources./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AgentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605101231735_42972_30";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Device"">Device</see> composed of an <i>MTConnect Agent</i> and all its connected data sources./// Description";

		/// <inheritdoc />
		public string Name => "AgentClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1620240839406_285612_1596";

		public IPropertyList Properties => null;

	}
}