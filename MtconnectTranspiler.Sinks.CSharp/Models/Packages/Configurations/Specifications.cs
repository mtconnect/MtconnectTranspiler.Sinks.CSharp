using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.Specifications;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SpecificationsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			SpecificationClass,
			ProcessSpecificationGeneralization,
			ControlLimitsClass,
			AlarmLimitsClass,
			SpecificationLimitsClass,
			UpperWarningClass,
			UpperLimitClass,
			MaximumClass,
			LowerLimitClass,
			LowerWarningClass,
			MinimumClass,
			NominalClass,
		};

	private Package.SpecificationClass _SpecificationClass;
	public Package.SpecificationClass SpecificationClass => _SpecificationClass ?? (_SpecificationClass = new Package.SpecificationClass());
	private Package.ProcessSpecificationGeneralization _ProcessSpecificationGeneralization;
	public Package.ProcessSpecificationGeneralization ProcessSpecificationGeneralization => _ProcessSpecificationGeneralization ?? (_ProcessSpecificationGeneralization = new Package.ProcessSpecificationGeneralization());
	private Package.ControlLimitsClass _ControlLimitsClass;
	public Package.ControlLimitsClass ControlLimitsClass => _ControlLimitsClass ?? (_ControlLimitsClass = new Package.ControlLimitsClass());
	private Package.AlarmLimitsClass _AlarmLimitsClass;
	public Package.AlarmLimitsClass AlarmLimitsClass => _AlarmLimitsClass ?? (_AlarmLimitsClass = new Package.AlarmLimitsClass());
	private Package.SpecificationLimitsClass _SpecificationLimitsClass;
	public Package.SpecificationLimitsClass SpecificationLimitsClass => _SpecificationLimitsClass ?? (_SpecificationLimitsClass = new Package.SpecificationLimitsClass());
	private Package.UpperWarningClass _UpperWarningClass;
	public Package.UpperWarningClass UpperWarningClass => _UpperWarningClass ?? (_UpperWarningClass = new Package.UpperWarningClass());
	private Package.UpperLimitClass _UpperLimitClass;
	public Package.UpperLimitClass UpperLimitClass => _UpperLimitClass ?? (_UpperLimitClass = new Package.UpperLimitClass());
	private Package.MaximumClass _MaximumClass;
	public Package.MaximumClass MaximumClass => _MaximumClass ?? (_MaximumClass = new Package.MaximumClass());
	private Package.LowerLimitClass _LowerLimitClass;
	public Package.LowerLimitClass LowerLimitClass => _LowerLimitClass ?? (_LowerLimitClass = new Package.LowerLimitClass());
	private Package.LowerWarningClass _LowerWarningClass;
	public Package.LowerWarningClass LowerWarningClass => _LowerWarningClass ?? (_LowerWarningClass = new Package.LowerWarningClass());
	private Package.MinimumClass _MinimumClass;
	public Package.MinimumClass MinimumClass => _MinimumClass ?? (_MinimumClass = new Package.MinimumClass());
	private Package.NominalClass _NominalClass;
	public Package.NominalClass NominalClass => _NominalClass ?? (_NominalClass = new Package.NominalClass());
	}
}