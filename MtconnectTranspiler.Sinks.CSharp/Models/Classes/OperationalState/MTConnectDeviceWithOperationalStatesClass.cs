using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples.OperationalState
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MTConnectDeviceWithOperationalStatesClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1679487876615_368541_256";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "MTConnect Device with Operational States";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1620240839406_285612_1596
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.DeviceClass);

		/// <inheritdoc />
		public MTConnectDeviceWithOperationalStatesClassProperties Properties { get; } = new MTConnectDeviceWithOperationalStatesClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class MTConnectDeviceWithOperationalStatesClassProperties : Mtconnect.DeviceInformationModel.DeviceClass.DeviceClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}