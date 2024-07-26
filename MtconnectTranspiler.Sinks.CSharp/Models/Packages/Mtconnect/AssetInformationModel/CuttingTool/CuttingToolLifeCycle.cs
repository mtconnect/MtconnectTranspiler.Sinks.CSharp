
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle;

using Mtconnect;

namespace Mtconnect.AssetInformationModel.CuttingTool {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CuttingToolLifeCyclePackage {


	private Package.CuttingToolLifeCycleClass _CuttingToolLifeCycle;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CuttingToolLifeCycleClass CuttingToolLifeCycle => _CuttingToolLifeCycle ?? (_CuttingToolLifeCycle = new Package.CuttingToolLifeCycleClass());

	private Package.ToolLifeClass _ToolLife;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ToolLifeClass ToolLife => _ToolLife ?? (_ToolLife = new Package.ToolLifeClass());

	private Package.LocationClass _Location;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LocationClass Location => _Location ?? (_Location = new Package.LocationClass());

	private Package.ReconditionCountClass _ReconditionCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ReconditionCountClass ReconditionCount => _ReconditionCount ?? (_ReconditionCount = new Package.ReconditionCountClass());

	private Package.ProcessSpindleSpeedClass _ProcessSpindleSpeed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessSpindleSpeedClass ProcessSpindleSpeed => _ProcessSpindleSpeed ?? (_ProcessSpindleSpeed = new Package.ProcessSpindleSpeedClass());

	private Package.ProcessFeedRateClass _ProcessFeedRate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessFeedRateClass ProcessFeedRate => _ProcessFeedRate ?? (_ProcessFeedRate = new Package.ProcessFeedRateClass());

	private Package.StatusClass _Status;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.StatusClass Status => _Status ?? (_Status = new Package.StatusClass());

	private Package.MeasurementClass _Measurement;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MeasurementClass Measurement => _Measurement ?? (_Measurement = new Package.MeasurementClass());
	}
}