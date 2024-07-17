using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes;
// using Mtconnect;

namespace Mtconnect.ObservationInformationModel.ObservationTypes {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ConditionTypesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			ActuatorClass,
			CommunicationsClass,
			DataRangeClass,
			LogicProgramClass,
			MotionProgramClass,
			SystemClass,
		};

	private Package.ActuatorClass _ActuatorClass;
	public Package.ActuatorClass ActuatorClass => _ActuatorClass ?? (_ActuatorClass = new Package.ActuatorClass());
	private Package.CommunicationsClass _CommunicationsClass;
	public Package.CommunicationsClass CommunicationsClass => _CommunicationsClass ?? (_CommunicationsClass = new Package.CommunicationsClass());
	private Package.DataRangeClass _DataRangeClass;
	public Package.DataRangeClass DataRangeClass => _DataRangeClass ?? (_DataRangeClass = new Package.DataRangeClass());
	private Package.LogicProgramClass _LogicProgramClass;
	public Package.LogicProgramClass LogicProgramClass => _LogicProgramClass ?? (_LogicProgramClass = new Package.LogicProgramClass());
	private Package.MotionProgramClass _MotionProgramClass;
	public Package.MotionProgramClass MotionProgramClass => _MotionProgramClass ?? (_MotionProgramClass = new Package.MotionProgramClass());
	private Package.SystemClass _SystemClass;
	public Package.SystemClass SystemClass => _SystemClass ?? (_SystemClass = new Package.SystemClass());
	}
}