using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool.CuttingToolMeasurementSubtypes;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>
	﻿/// This section lists the <see cref="Measurement">Measurement</see> subtypes for <see cref="CuttingTool">CuttingTool</see>.<br /><br />These <see cref="Measurement">Measurement</see> subtypes for <see cref="CuttingTool">CuttingTool</see> are specific to the entire assembly and <b>MUST NOT</b> be used for the <see cref="Measurement">Measurement</see> pertaining to a <see cref="CuttingItem">CuttingItem</see>. {{figure(Cutting Tool Measurement 1)}} and {{figure(Cutting Tool Measurement 2)}} will be used to reference the assembly specific <see cref="Measurement">Measurement</see> subtypes.<br /><br />![Cutting Tool Measurement 1](figures/Cutting%20Tool%20Measurement%201.png "Cutting Tool Measurement 1"){: width="0.8"}<br /><br />![Cutting Tool Measurement 2](figures/Cutting%20Tool%20Measurement%202.png "Cutting Tool Measurement 2"){: width="0.8"}<br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1582918427874_472723_1238">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class CuttingToolMeasurementSubtypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1582918427874_472723_1238";
		
		/// <inheritdoc />
		public string Name => "Cutting Tool Measurement Subtypes";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section lists the {{block(Measurement)}} subtypes for {{block(CuttingTool)}}.

These {{block(Measurement)}} subtypes for {{block(CuttingTool)}} are specific to the entire assembly and **MUST NOT** be used for the {{block(Measurement)}} pertaining to a {{block(CuttingItem)}}. {{figure(Cutting Tool Measurement 1)}} and {{figure(Cutting Tool Measurement 2)}} will be used to reference the assembly specific {{block(Measurement)}} subtypes.

![Cutting Tool Measurement 1](figures/Cutting%20Tool%20Measurement%201.png ""Cutting Tool Measurement 1""){: width=""0.8""}

![Cutting Tool Measurement 2](figures/Cutting%20Tool%20Measurement%202.png ""Cutting Tool Measurement 2""){: width=""0.8""}
&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			BodyDiameterMaxClass,
			BodyLengthMaxClass,
			DepthOfCutMaxClass,
			CuttingDiameterMaxClass,
			FlangeDiameterMaxClass,
			OverallToolLengthClass,
			ShankDiameterClass,
			ShankHeightClass,
			ShankLengthClass,
			UsableLengthMaxClass,
			ProtrudingLengthClass,
			FunctionalLengthClass,
			WeightClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.BodyDiameterMaxClass _BodyDiameterMaxClass;
	/// <summary>
	/// <inheritdoc cref="Package.BodyDiameterMaxClass" path="/summary" />
	/// </summary>
	public Package.BodyDiameterMaxClass BodyDiameterMaxClass => _BodyDiameterMaxClass ?? (_BodyDiameterMaxClass = new Package.BodyDiameterMaxClass());

	private Package.BodyLengthMaxClass _BodyLengthMaxClass;
	/// <summary>
	/// <inheritdoc cref="Package.BodyLengthMaxClass" path="/summary" />
	/// </summary>
	public Package.BodyLengthMaxClass BodyLengthMaxClass => _BodyLengthMaxClass ?? (_BodyLengthMaxClass = new Package.BodyLengthMaxClass());

	private Package.DepthOfCutMaxClass _DepthOfCutMaxClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepthOfCutMaxClass" path="/summary" />
	/// </summary>
	public Package.DepthOfCutMaxClass DepthOfCutMaxClass => _DepthOfCutMaxClass ?? (_DepthOfCutMaxClass = new Package.DepthOfCutMaxClass());

	private Package.CuttingDiameterMaxClass _CuttingDiameterMaxClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingDiameterMaxClass" path="/summary" />
	/// </summary>
	public Package.CuttingDiameterMaxClass CuttingDiameterMaxClass => _CuttingDiameterMaxClass ?? (_CuttingDiameterMaxClass = new Package.CuttingDiameterMaxClass());

	private Package.FlangeDiameterMaxClass _FlangeDiameterMaxClass;
	/// <summary>
	/// <inheritdoc cref="Package.FlangeDiameterMaxClass" path="/summary" />
	/// </summary>
	public Package.FlangeDiameterMaxClass FlangeDiameterMaxClass => _FlangeDiameterMaxClass ?? (_FlangeDiameterMaxClass = new Package.FlangeDiameterMaxClass());

	private Package.OverallToolLengthClass _OverallToolLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.OverallToolLengthClass" path="/summary" />
	/// </summary>
	public Package.OverallToolLengthClass OverallToolLengthClass => _OverallToolLengthClass ?? (_OverallToolLengthClass = new Package.OverallToolLengthClass());

	private Package.ShankDiameterClass _ShankDiameterClass;
	/// <summary>
	/// <inheritdoc cref="Package.ShankDiameterClass" path="/summary" />
	/// </summary>
	public Package.ShankDiameterClass ShankDiameterClass => _ShankDiameterClass ?? (_ShankDiameterClass = new Package.ShankDiameterClass());

	private Package.ShankHeightClass _ShankHeightClass;
	/// <summary>
	/// <inheritdoc cref="Package.ShankHeightClass" path="/summary" />
	/// </summary>
	public Package.ShankHeightClass ShankHeightClass => _ShankHeightClass ?? (_ShankHeightClass = new Package.ShankHeightClass());

	private Package.ShankLengthClass _ShankLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.ShankLengthClass" path="/summary" />
	/// </summary>
	public Package.ShankLengthClass ShankLengthClass => _ShankLengthClass ?? (_ShankLengthClass = new Package.ShankLengthClass());

	private Package.UsableLengthMaxClass _UsableLengthMaxClass;
	/// <summary>
	/// <inheritdoc cref="Package.UsableLengthMaxClass" path="/summary" />
	/// </summary>
	public Package.UsableLengthMaxClass UsableLengthMaxClass => _UsableLengthMaxClass ?? (_UsableLengthMaxClass = new Package.UsableLengthMaxClass());

	private Package.ProtrudingLengthClass _ProtrudingLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProtrudingLengthClass" path="/summary" />
	/// </summary>
	public Package.ProtrudingLengthClass ProtrudingLengthClass => _ProtrudingLengthClass ?? (_ProtrudingLengthClass = new Package.ProtrudingLengthClass());

	private Package.FunctionalLengthClass _FunctionalLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.FunctionalLengthClass" path="/summary" />
	/// </summary>
	public Package.FunctionalLengthClass FunctionalLengthClass => _FunctionalLengthClass ?? (_FunctionalLengthClass = new Package.FunctionalLengthClass());

	private Package.WeightClass _WeightClass;
	/// <summary>
	/// <inheritdoc cref="Package.WeightClass" path="/summary" />
	/// </summary>
	public Package.WeightClass WeightClass => _WeightClass ?? (_WeightClass = new Package.WeightClass());

	#endregion
	}
}