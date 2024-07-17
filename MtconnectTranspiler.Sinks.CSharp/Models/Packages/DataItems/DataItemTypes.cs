using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.DataItemTypes;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.DataItems {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class DataItemTypesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			EventClass,
			SampleClass,
			ConditionClass,
		};

	private Package.EventClass _EventClass;
	public Package.EventClass EventClass => _EventClass ?? (_EventClass = new Package.EventClass());
	private Package.SampleClass _SampleClass;
	public Package.SampleClass SampleClass => _SampleClass ?? (_SampleClass = new Package.SampleClass());
	private Package.ConditionClass _ConditionClass;
	public Package.ConditionClass ConditionClass => _ConditionClass ?? (_ConditionClass = new Package.ConditionClass());
	}
}