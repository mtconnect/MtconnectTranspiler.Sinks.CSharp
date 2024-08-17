#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>﻿This section provides semantic information for the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> model.<br /><br />![CuttingToolLifeCycle](figures/CuttingToolLifeCycle.png "CuttingToolLifeCycle"){: width="0.8"}<br /><br />&gt; Note: See <see cref="CuttingToolLifeCycle Schema Diagrams">CuttingToolLifeCycle Schema Diagrams</see> for XML schema.<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1612424133851_339632_344">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class CuttingToolLifeCyclePackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1612424133851_339632_344";
		
		/// <inheritdoc />
		public string Name => "Cutting Tool Life Cycle";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(CuttingToolLifeCycle)}} model.

![CuttingToolLifeCycle](figures/CuttingToolLifeCycle.png ""CuttingToolLifeCycle""){: width=""0.8""}

> Note: See {{sect(CuttingToolLifeCycle Schema Diagrams)}} for XML schema.
&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
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
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.CuttingToolLifeCycleClass _CuttingToolLifeCycleClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingToolLifeCycleClass" path="/summary" />
	/// </summary>
	public Package.CuttingToolLifeCycleClass CuttingToolLifeCycleClass => _CuttingToolLifeCycleClass ?? (_CuttingToolLifeCycleClass = new Package.CuttingToolLifeCycleClass());

	private Package.ToolLifeClass _ToolLifeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolLifeClass" path="/summary" />
	/// </summary>
	public Package.ToolLifeClass ToolLifeClass => _ToolLifeClass ?? (_ToolLifeClass = new Package.ToolLifeClass());

	private Package.LocationClass _LocationClass;
	/// <summary>
	/// <inheritdoc cref="Package.LocationClass" path="/summary" />
	/// </summary>
	public Package.LocationClass LocationClass => _LocationClass ?? (_LocationClass = new Package.LocationClass());

	private Package.ReconditionCountClass _ReconditionCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.ReconditionCountClass" path="/summary" />
	/// </summary>
	public Package.ReconditionCountClass ReconditionCountClass => _ReconditionCountClass ?? (_ReconditionCountClass = new Package.ReconditionCountClass());

	private Package.ProcessSpindleSpeedClass _ProcessSpindleSpeedClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessSpindleSpeedClass" path="/summary" />
	/// </summary>
	public Package.ProcessSpindleSpeedClass ProcessSpindleSpeedClass => _ProcessSpindleSpeedClass ?? (_ProcessSpindleSpeedClass = new Package.ProcessSpindleSpeedClass());

	private Package.ProcessFeedRateClass _ProcessFeedRateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessFeedRateClass" path="/summary" />
	/// </summary>
	public Package.ProcessFeedRateClass ProcessFeedRateClass => _ProcessFeedRateClass ?? (_ProcessFeedRateClass = new Package.ProcessFeedRateClass());

	private Package.StatusClass _StatusClass;
	/// <summary>
	/// <inheritdoc cref="Package.StatusClass" path="/summary" />
	/// </summary>
	public Package.StatusClass StatusClass => _StatusClass ?? (_StatusClass = new Package.StatusClass());

	private Package.MeasurementClass _MeasurementClass;
	/// <summary>
	/// <inheritdoc cref="Package.MeasurementClass" path="/summary" />
	/// </summary>
	public Package.MeasurementClass MeasurementClass => _MeasurementClass ?? (_MeasurementClass = new Package.MeasurementClass());

	#endregion

	#region Enums
	#endregion
	}
}