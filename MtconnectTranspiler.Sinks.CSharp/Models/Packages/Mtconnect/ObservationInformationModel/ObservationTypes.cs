
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes;


namespace Mtconnect.ObservationInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ObservationTypesPackage {

	private Package.SampleTypesPackage _SampleTypesPackage;
	public Package.SampleTypesPackage SampleTypesPackage => _SampleTypesPackage ?? (_SampleTypesPackage = new Package.SampleTypesPackage());

	private Package.EventTypesPackage _EventTypesPackage;
	public Package.EventTypesPackage EventTypesPackage => _EventTypesPackage ?? (_EventTypesPackage = new Package.EventTypesPackage());

	private Package.ConditionTypesPackage _ConditionTypesPackage;
	public Package.ConditionTypesPackage ConditionTypesPackage => _ConditionTypesPackage ?? (_ConditionTypesPackage = new Package.ConditionTypesPackage());

	}
}