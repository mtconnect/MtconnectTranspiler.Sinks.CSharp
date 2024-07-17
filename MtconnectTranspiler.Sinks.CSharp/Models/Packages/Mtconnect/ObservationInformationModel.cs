using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel;
// using Mtconnect;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ObservationInformationModelPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			RepresentationsPackage,
			ObservationTypesPackage,
		};

		public IClass[] Classes => new IClass[] {
			DeviceStreamClass,
			ComponentStreamClass,
			ObservationGeneralization,
			SampleClass,
			EventClass,
			ConditionClass,
		};
	private Package.RepresentationsPackage _RepresentationsPackage;
	public Package.RepresentationsPackage RepresentationsPackage => _RepresentationsPackage ?? (_RepresentationsPackage = new Package.RepresentationsPackage());
	private Package.ObservationTypesPackage _ObservationTypesPackage;
	public Package.ObservationTypesPackage ObservationTypesPackage => _ObservationTypesPackage ?? (_ObservationTypesPackage = new Package.ObservationTypesPackage());

	private Package.DeviceStreamClass _DeviceStreamClass;
	public Package.DeviceStreamClass DeviceStreamClass => _DeviceStreamClass ?? (_DeviceStreamClass = new Package.DeviceStreamClass());
	private Package.ComponentStreamClass _ComponentStreamClass;
	public Package.ComponentStreamClass ComponentStreamClass => _ComponentStreamClass ?? (_ComponentStreamClass = new Package.ComponentStreamClass());
	private Package.ObservationGeneralization _ObservationGeneralization;
	public Package.ObservationGeneralization ObservationGeneralization => _ObservationGeneralization ?? (_ObservationGeneralization = new Package.ObservationGeneralization());
	private Package.SampleClass _SampleClass;
	public Package.SampleClass SampleClass => _SampleClass ?? (_SampleClass = new Package.SampleClass());
	private Package.EventClass _EventClass;
	public Package.EventClass EventClass => _EventClass ?? (_EventClass = new Package.EventClass());
	private Package.ConditionClass _ConditionClass;
	public Package.ConditionClass ConditionClass => _ConditionClass ?? (_ConditionClass = new Package.ConditionClass());
	}
}