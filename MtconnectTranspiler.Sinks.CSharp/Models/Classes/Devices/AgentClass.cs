using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.Devices
{
	/// <summary>
	/// <see cref="Device">Device</see> composed of an <i>MTConnect Agent</i> and all its connected data sources./// Description
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605101231735_42972_30">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AgentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605101231735_42972_30";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Device"">Device</see> composed of an <i>MTConnect Agent</i> and all its connected data sources./// Description";

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