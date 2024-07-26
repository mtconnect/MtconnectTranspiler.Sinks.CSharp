
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.DataItems.DataItemTypes;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.DataItems {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class DataItemTypesPackage {


	private Package.EventClass _Event;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EventClass Event => _Event ?? (_Event = new Package.EventClass());

	private Package.SampleClass _Sample;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SampleClass Sample => _Sample ?? (_Sample = new Package.SampleClass());

	private Package.ConditionClass _Condition;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ConditionClass Condition => _Condition ?? (_Condition = new Package.ConditionClass());
	}
}