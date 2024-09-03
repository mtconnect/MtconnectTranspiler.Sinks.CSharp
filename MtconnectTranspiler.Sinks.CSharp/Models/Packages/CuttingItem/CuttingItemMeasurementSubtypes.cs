#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool.CuttingItem.CuttingItemMeasurementSubtypes;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingItem
{
	/// <summary>﻿This section lists the <see cref="Measurement">Measurement</see> subtypes for <see cref="CuttingItem">CuttingItem</see>.<br /><br />These <see cref="Measurement">Measurement</see> subtypes for <see cref="CuttingItem">CuttingItem</see> are specific to an individual <see cref="CuttingItem">CuttingItem</see> and <b>MUST NOT</b> be used for the <see cref="Measurement">Measurement</see> pertaining to an assembly. Figures below will be used to for reference for the <see cref="CuttingItem">CuttingItem</see> specific <see cref="Measurement">Measurement</see> types.<br /><br />![Cutting Tool](figures/Cutting%20Tool.png "Cutting Tool"){: width="0.8"}<br /><br />![Cutting Item](figures/Cutting%20Item.png "Cutting Item"){: width="0.8"}<br /><br />![Cutting Item Measurement](figures/Cutting%20Item%20Measurement.png "Cutting Item Measurement"){: width="0.8"}<br /><br />![Cutting Item Drive Angle](figures/Cutting%20Item%20Drive%20Angle.png "Cutting Item Drive Angle"){: width="0.8"}<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1582919154044_31808_1537">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class CuttingItemMeasurementSubtypesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="CuttingItemMeasurementSubtypesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1582919154044_31808_1537";
		/// <summary>Constant value for <see cref="CuttingItemMeasurementSubtypesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1582919154044_31808_1537";
		/// <summary>Constant value for <see cref="CuttingItemMeasurementSubtypesPackage.Name" /></summary>
		public const string NAME = "Cutting Item Measurement Subtypes";
		/// <summary>Constant value for <see cref="CuttingItemMeasurementSubtypesPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section lists the {{block(Measurement)}} subtypes for {{block(CuttingItem)}}.

These {{block(Measurement)}} subtypes for {{block(CuttingItem)}} are specific to an individual {{block(CuttingItem)}} and **MUST NOT** be used for the {{block(Measurement)}} pertaining to an assembly. Figures below will be used to for reference for the {{block(CuttingItem)}} specific {{block(Measurement)}} types.

![Cutting Tool](figures/Cutting%20Tool.png ""Cutting Tool""){: width=""0.8""}

![Cutting Item](figures/Cutting%20Item.png ""Cutting Item""){: width=""0.8""}

![Cutting Item Measurement](figures/Cutting%20Item%20Measurement.png ""Cutting Item Measurement""){: width=""0.8""}

![Cutting Item Drive Angle](figures/Cutting%20Item%20Drive%20Angle.png ""Cutting Item Drive Angle""){: width=""0.8""}&#10;
";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			FunctionalLengthClass,
			CuttingReferencePointClass,
			CuttingEdgeLengthClass,
			DriveAngleClass,
			FlangeDiameterClass,
			FunctionalWidthClass,
			IncribedCircleDiameterClass,
			PointAngleClass,
			ToolCuttingEdgeAngleClass,
			ToolLeadAngleClass,
			ToolOrientationClass,
			StepDiameterLengthClass,
			StepIncludedAngleClass,
			WiperEdgeLengthClass,
			CuttingDiameterClass,
			CuttingHeightClass,
			CornerRadiusClass,
			WeightClass,
			ChamferFlatLengthClass,
			ChamferWidthClass,
			InsertWidthClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.FunctionalLengthClass _FunctionalLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.FunctionalLengthClass" path="/summary" />
	/// </summary>
	public Package.FunctionalLengthClass FunctionalLengthClass => _FunctionalLengthClass ?? (_FunctionalLengthClass = new Package.FunctionalLengthClass());

	private Package.CuttingReferencePointClass _CuttingReferencePointClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingReferencePointClass" path="/summary" />
	/// </summary>
	public Package.CuttingReferencePointClass CuttingReferencePointClass => _CuttingReferencePointClass ?? (_CuttingReferencePointClass = new Package.CuttingReferencePointClass());

	private Package.CuttingEdgeLengthClass _CuttingEdgeLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingEdgeLengthClass" path="/summary" />
	/// </summary>
	public Package.CuttingEdgeLengthClass CuttingEdgeLengthClass => _CuttingEdgeLengthClass ?? (_CuttingEdgeLengthClass = new Package.CuttingEdgeLengthClass());

	private Package.DriveAngleClass _DriveAngleClass;
	/// <summary>
	/// <inheritdoc cref="Package.DriveAngleClass" path="/summary" />
	/// </summary>
	public Package.DriveAngleClass DriveAngleClass => _DriveAngleClass ?? (_DriveAngleClass = new Package.DriveAngleClass());

	private Package.FlangeDiameterClass _FlangeDiameterClass;
	/// <summary>
	/// <inheritdoc cref="Package.FlangeDiameterClass" path="/summary" />
	/// </summary>
	public Package.FlangeDiameterClass FlangeDiameterClass => _FlangeDiameterClass ?? (_FlangeDiameterClass = new Package.FlangeDiameterClass());

	private Package.FunctionalWidthClass _FunctionalWidthClass;
	/// <summary>
	/// <inheritdoc cref="Package.FunctionalWidthClass" path="/summary" />
	/// </summary>
	public Package.FunctionalWidthClass FunctionalWidthClass => _FunctionalWidthClass ?? (_FunctionalWidthClass = new Package.FunctionalWidthClass());

	private Package.IncribedCircleDiameterClass _IncribedCircleDiameterClass;
	/// <summary>
	/// <inheritdoc cref="Package.IncribedCircleDiameterClass" path="/summary" />
	/// </summary>
	public Package.IncribedCircleDiameterClass IncribedCircleDiameterClass => _IncribedCircleDiameterClass ?? (_IncribedCircleDiameterClass = new Package.IncribedCircleDiameterClass());

	private Package.PointAngleClass _PointAngleClass;
	/// <summary>
	/// <inheritdoc cref="Package.PointAngleClass" path="/summary" />
	/// </summary>
	public Package.PointAngleClass PointAngleClass => _PointAngleClass ?? (_PointAngleClass = new Package.PointAngleClass());

	private Package.ToolCuttingEdgeAngleClass _ToolCuttingEdgeAngleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolCuttingEdgeAngleClass" path="/summary" />
	/// </summary>
	public Package.ToolCuttingEdgeAngleClass ToolCuttingEdgeAngleClass => _ToolCuttingEdgeAngleClass ?? (_ToolCuttingEdgeAngleClass = new Package.ToolCuttingEdgeAngleClass());

	private Package.ToolLeadAngleClass _ToolLeadAngleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolLeadAngleClass" path="/summary" />
	/// </summary>
	public Package.ToolLeadAngleClass ToolLeadAngleClass => _ToolLeadAngleClass ?? (_ToolLeadAngleClass = new Package.ToolLeadAngleClass());

	private Package.ToolOrientationClass _ToolOrientationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolOrientationClass" path="/summary" />
	/// </summary>
	public Package.ToolOrientationClass ToolOrientationClass => _ToolOrientationClass ?? (_ToolOrientationClass = new Package.ToolOrientationClass());

	private Package.StepDiameterLengthClass _StepDiameterLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.StepDiameterLengthClass" path="/summary" />
	/// </summary>
	public Package.StepDiameterLengthClass StepDiameterLengthClass => _StepDiameterLengthClass ?? (_StepDiameterLengthClass = new Package.StepDiameterLengthClass());

	private Package.StepIncludedAngleClass _StepIncludedAngleClass;
	/// <summary>
	/// <inheritdoc cref="Package.StepIncludedAngleClass" path="/summary" />
	/// </summary>
	public Package.StepIncludedAngleClass StepIncludedAngleClass => _StepIncludedAngleClass ?? (_StepIncludedAngleClass = new Package.StepIncludedAngleClass());

	private Package.WiperEdgeLengthClass _WiperEdgeLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.WiperEdgeLengthClass" path="/summary" />
	/// </summary>
	public Package.WiperEdgeLengthClass WiperEdgeLengthClass => _WiperEdgeLengthClass ?? (_WiperEdgeLengthClass = new Package.WiperEdgeLengthClass());

	private Package.CuttingDiameterClass _CuttingDiameterClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingDiameterClass" path="/summary" />
	/// </summary>
	public Package.CuttingDiameterClass CuttingDiameterClass => _CuttingDiameterClass ?? (_CuttingDiameterClass = new Package.CuttingDiameterClass());

	private Package.CuttingHeightClass _CuttingHeightClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingHeightClass" path="/summary" />
	/// </summary>
	public Package.CuttingHeightClass CuttingHeightClass => _CuttingHeightClass ?? (_CuttingHeightClass = new Package.CuttingHeightClass());

	private Package.CornerRadiusClass _CornerRadiusClass;
	/// <summary>
	/// <inheritdoc cref="Package.CornerRadiusClass" path="/summary" />
	/// </summary>
	public Package.CornerRadiusClass CornerRadiusClass => _CornerRadiusClass ?? (_CornerRadiusClass = new Package.CornerRadiusClass());

	private Package.WeightClass _WeightClass;
	/// <summary>
	/// <inheritdoc cref="Package.WeightClass" path="/summary" />
	/// </summary>
	public Package.WeightClass WeightClass => _WeightClass ?? (_WeightClass = new Package.WeightClass());

	private Package.ChamferFlatLengthClass _ChamferFlatLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChamferFlatLengthClass" path="/summary" />
	/// </summary>
	public Package.ChamferFlatLengthClass ChamferFlatLengthClass => _ChamferFlatLengthClass ?? (_ChamferFlatLengthClass = new Package.ChamferFlatLengthClass());

	private Package.ChamferWidthClass _ChamferWidthClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChamferWidthClass" path="/summary" />
	/// </summary>
	public Package.ChamferWidthClass ChamferWidthClass => _ChamferWidthClass ?? (_ChamferWidthClass = new Package.ChamferWidthClass());

	private Package.InsertWidthClass _InsertWidthClass;
	/// <summary>
	/// <inheritdoc cref="Package.InsertWidthClass" path="/summary" />
	/// </summary>
	public Package.InsertWidthClass InsertWidthClass => _InsertWidthClass ?? (_InsertWidthClass = new Package.InsertWidthClass());

	#endregion

	#region Enums
	#endregion
	}
}