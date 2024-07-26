
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes;

using Mtconnect;

namespace Mtconnect.ObservationInformationModel.ObservationTypes {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ConditionTypesPackage {


	private Package.ActuatorClass _Actuator;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActuatorClass Actuator => _Actuator ?? (_Actuator = new Package.ActuatorClass());

	private Package.CommunicationsClass _Communications;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CommunicationsClass Communications => _Communications ?? (_Communications = new Package.CommunicationsClass());

	private Package.DataRangeClass _DataRange;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DataRangeClass DataRange => _DataRange ?? (_DataRange = new Package.DataRangeClass());

	private Package.LogicProgramClass _LogicProgram;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LogicProgramClass LogicProgram => _LogicProgram ?? (_LogicProgram = new Package.LogicProgramClass());

	private Package.MotionProgramClass _MotionProgram;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MotionProgramClass MotionProgram => _MotionProgram ?? (_MotionProgram = new Package.MotionProgramClass());

	private Package.SystemClass _System;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SystemClass System => _System ?? (_System = new Package.SystemClass());
	}
}