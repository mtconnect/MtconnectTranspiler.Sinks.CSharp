using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel.CuttingTool {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CuttingToolLifeCyclePackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			CuttingToolLifeCycleClass,
			ToolLifeClass,
			LocationClass,
			ReconditionCountClass,
			ProcessSpindleSpeedClass,
			ProcessFeedRateClass,
			StatusClass,
			MeasurementClass,
		};

	private Package.CuttingToolLifeCycleClass _CuttingToolLifeCycleClass;
	public Package.CuttingToolLifeCycleClass CuttingToolLifeCycleClass => _CuttingToolLifeCycleClass ?? (_CuttingToolLifeCycleClass = new Package.CuttingToolLifeCycleClass());
	private Package.ToolLifeClass _ToolLifeClass;
	public Package.ToolLifeClass ToolLifeClass => _ToolLifeClass ?? (_ToolLifeClass = new Package.ToolLifeClass());
	private Package.LocationClass _LocationClass;
	public Package.LocationClass LocationClass => _LocationClass ?? (_LocationClass = new Package.LocationClass());
	private Package.ReconditionCountClass _ReconditionCountClass;
	public Package.ReconditionCountClass ReconditionCountClass => _ReconditionCountClass ?? (_ReconditionCountClass = new Package.ReconditionCountClass());
	private Package.ProcessSpindleSpeedClass _ProcessSpindleSpeedClass;
	public Package.ProcessSpindleSpeedClass ProcessSpindleSpeedClass => _ProcessSpindleSpeedClass ?? (_ProcessSpindleSpeedClass = new Package.ProcessSpindleSpeedClass());
	private Package.ProcessFeedRateClass _ProcessFeedRateClass;
	public Package.ProcessFeedRateClass ProcessFeedRateClass => _ProcessFeedRateClass ?? (_ProcessFeedRateClass = new Package.ProcessFeedRateClass());
	private Package.StatusClass _StatusClass;
	public Package.StatusClass StatusClass => _StatusClass ?? (_StatusClass = new Package.StatusClass());
	private Package.MeasurementClass _MeasurementClass;
	public Package.MeasurementClass MeasurementClass => _MeasurementClass ?? (_MeasurementClass = new Package.MeasurementClass());
	}
}