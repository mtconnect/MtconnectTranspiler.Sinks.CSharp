
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Configurations.Specifications;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SpecificationsPackage {


	private Package.SpecificationClass _Specification;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SpecificationClass Specification => _Specification ?? (_Specification = new Package.SpecificationClass());

	private Package.ProcessSpecificationClass _ProcessSpecification;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessSpecificationClass ProcessSpecification => _ProcessSpecification ?? (_ProcessSpecification = new Package.ProcessSpecificationClass());

	private Package.ControlLimitsClass _ControlLimits;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControlLimitsClass ControlLimits => _ControlLimits ?? (_ControlLimits = new Package.ControlLimitsClass());

	private Package.AlarmLimitsClass _AlarmLimits;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AlarmLimitsClass AlarmLimits => _AlarmLimits ?? (_AlarmLimits = new Package.AlarmLimitsClass());

	private Package.SpecificationLimitsClass _SpecificationLimits;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SpecificationLimitsClass SpecificationLimits => _SpecificationLimits ?? (_SpecificationLimits = new Package.SpecificationLimitsClass());

	private Package.UpperWarningClass _UpperWarning;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UpperWarningClass UpperWarning => _UpperWarning ?? (_UpperWarning = new Package.UpperWarningClass());

	private Package.UpperLimitClass _UpperLimit;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UpperLimitClass UpperLimit => _UpperLimit ?? (_UpperLimit = new Package.UpperLimitClass());

	private Package.MaximumClass _Maximum;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MaximumClass Maximum => _Maximum ?? (_Maximum = new Package.MaximumClass());

	private Package.LowerLimitClass _LowerLimit;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LowerLimitClass LowerLimit => _LowerLimit ?? (_LowerLimit = new Package.LowerLimitClass());

	private Package.LowerWarningClass _LowerWarning;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LowerWarningClass LowerWarning => _LowerWarning ?? (_LowerWarning = new Package.LowerWarningClass());

	private Package.MinimumClass _Minimum;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MinimumClass Minimum => _Minimum ?? (_Minimum = new Package.MinimumClass());

	private Package.NominalClass _Nominal;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NominalClass Nominal => _Nominal ?? (_Nominal = new Package.NominalClass());
	}
}