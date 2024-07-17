using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms;
// using Mtconnect;

namespace Mtconnect.Glossary.MTConnectTerms {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class AdditionalObservationTermsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			ObservedMeasurementClass,
			ObservedConditionClass,
			ObservableEventClass,
			ObservableSampleClass,
			ObservedStateClass,
			ObservedNormalClass,
			ObservableConditionClass,
			ObservedEventClass,
			ObservableMeasurementClass,
			ObservableStateClass,
			ObservedFaultClass,
			ObservedWarningClass,
			EventClass,
			SampleClass,
			ConditionClass,
		};

	private Package.ObservedMeasurementClass _ObservedMeasurementClass;
	public Package.ObservedMeasurementClass ObservedMeasurementClass => _ObservedMeasurementClass ?? (_ObservedMeasurementClass = new Package.ObservedMeasurementClass());
	private Package.ObservedConditionClass _ObservedConditionClass;
	public Package.ObservedConditionClass ObservedConditionClass => _ObservedConditionClass ?? (_ObservedConditionClass = new Package.ObservedConditionClass());
	private Package.ObservableEventClass _ObservableEventClass;
	public Package.ObservableEventClass ObservableEventClass => _ObservableEventClass ?? (_ObservableEventClass = new Package.ObservableEventClass());
	private Package.ObservableSampleClass _ObservableSampleClass;
	public Package.ObservableSampleClass ObservableSampleClass => _ObservableSampleClass ?? (_ObservableSampleClass = new Package.ObservableSampleClass());
	private Package.ObservedStateClass _ObservedStateClass;
	public Package.ObservedStateClass ObservedStateClass => _ObservedStateClass ?? (_ObservedStateClass = new Package.ObservedStateClass());
	private Package.ObservedNormalClass _ObservedNormalClass;
	public Package.ObservedNormalClass ObservedNormalClass => _ObservedNormalClass ?? (_ObservedNormalClass = new Package.ObservedNormalClass());
	private Package.ObservableConditionClass _ObservableConditionClass;
	public Package.ObservableConditionClass ObservableConditionClass => _ObservableConditionClass ?? (_ObservableConditionClass = new Package.ObservableConditionClass());
	private Package.ObservedEventClass _ObservedEventClass;
	public Package.ObservedEventClass ObservedEventClass => _ObservedEventClass ?? (_ObservedEventClass = new Package.ObservedEventClass());
	private Package.ObservableMeasurementClass _ObservableMeasurementClass;
	public Package.ObservableMeasurementClass ObservableMeasurementClass => _ObservableMeasurementClass ?? (_ObservableMeasurementClass = new Package.ObservableMeasurementClass());
	private Package.ObservableStateClass _ObservableStateClass;
	public Package.ObservableStateClass ObservableStateClass => _ObservableStateClass ?? (_ObservableStateClass = new Package.ObservableStateClass());
	private Package.ObservedFaultClass _ObservedFaultClass;
	public Package.ObservedFaultClass ObservedFaultClass => _ObservedFaultClass ?? (_ObservedFaultClass = new Package.ObservedFaultClass());
	private Package.ObservedWarningClass _ObservedWarningClass;
	public Package.ObservedWarningClass ObservedWarningClass => _ObservedWarningClass ?? (_ObservedWarningClass = new Package.ObservedWarningClass());
	private Package.EventClass _EventClass;
	public Package.EventClass EventClass => _EventClass ?? (_EventClass = new Package.EventClass());
	private Package.SampleClass _SampleClass;
	public Package.SampleClass SampleClass => _SampleClass ?? (_SampleClass = new Package.SampleClass());
	private Package.ConditionClass _ConditionClass;
	public Package.ConditionClass ConditionClass => _ConditionClass ?? (_ConditionClass = new Package.ConditionClass());
	}
}