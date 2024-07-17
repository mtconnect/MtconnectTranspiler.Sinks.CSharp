using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool.CuttingItem.CuttingItemMeasurementSubtypes;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingItem {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CuttingItemMeasurementSubtypesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

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

	private Package.FunctionalLengthClass _FunctionalLengthClass;
	public Package.FunctionalLengthClass FunctionalLengthClass => _FunctionalLengthClass ?? (_FunctionalLengthClass = new Package.FunctionalLengthClass());
	private Package.CuttingReferencePointClass _CuttingReferencePointClass;
	public Package.CuttingReferencePointClass CuttingReferencePointClass => _CuttingReferencePointClass ?? (_CuttingReferencePointClass = new Package.CuttingReferencePointClass());
	private Package.CuttingEdgeLengthClass _CuttingEdgeLengthClass;
	public Package.CuttingEdgeLengthClass CuttingEdgeLengthClass => _CuttingEdgeLengthClass ?? (_CuttingEdgeLengthClass = new Package.CuttingEdgeLengthClass());
	private Package.DriveAngleClass _DriveAngleClass;
	public Package.DriveAngleClass DriveAngleClass => _DriveAngleClass ?? (_DriveAngleClass = new Package.DriveAngleClass());
	private Package.FlangeDiameterClass _FlangeDiameterClass;
	public Package.FlangeDiameterClass FlangeDiameterClass => _FlangeDiameterClass ?? (_FlangeDiameterClass = new Package.FlangeDiameterClass());
	private Package.FunctionalWidthClass _FunctionalWidthClass;
	public Package.FunctionalWidthClass FunctionalWidthClass => _FunctionalWidthClass ?? (_FunctionalWidthClass = new Package.FunctionalWidthClass());
	private Package.IncribedCircleDiameterClass _IncribedCircleDiameterClass;
	public Package.IncribedCircleDiameterClass IncribedCircleDiameterClass => _IncribedCircleDiameterClass ?? (_IncribedCircleDiameterClass = new Package.IncribedCircleDiameterClass());
	private Package.PointAngleClass _PointAngleClass;
	public Package.PointAngleClass PointAngleClass => _PointAngleClass ?? (_PointAngleClass = new Package.PointAngleClass());
	private Package.ToolCuttingEdgeAngleClass _ToolCuttingEdgeAngleClass;
	public Package.ToolCuttingEdgeAngleClass ToolCuttingEdgeAngleClass => _ToolCuttingEdgeAngleClass ?? (_ToolCuttingEdgeAngleClass = new Package.ToolCuttingEdgeAngleClass());
	private Package.ToolLeadAngleClass _ToolLeadAngleClass;
	public Package.ToolLeadAngleClass ToolLeadAngleClass => _ToolLeadAngleClass ?? (_ToolLeadAngleClass = new Package.ToolLeadAngleClass());
	private Package.ToolOrientationClass _ToolOrientationClass;
	public Package.ToolOrientationClass ToolOrientationClass => _ToolOrientationClass ?? (_ToolOrientationClass = new Package.ToolOrientationClass());
	private Package.StepDiameterLengthClass _StepDiameterLengthClass;
	public Package.StepDiameterLengthClass StepDiameterLengthClass => _StepDiameterLengthClass ?? (_StepDiameterLengthClass = new Package.StepDiameterLengthClass());
	private Package.StepIncludedAngleClass _StepIncludedAngleClass;
	public Package.StepIncludedAngleClass StepIncludedAngleClass => _StepIncludedAngleClass ?? (_StepIncludedAngleClass = new Package.StepIncludedAngleClass());
	private Package.WiperEdgeLengthClass _WiperEdgeLengthClass;
	public Package.WiperEdgeLengthClass WiperEdgeLengthClass => _WiperEdgeLengthClass ?? (_WiperEdgeLengthClass = new Package.WiperEdgeLengthClass());
	private Package.CuttingDiameterClass _CuttingDiameterClass;
	public Package.CuttingDiameterClass CuttingDiameterClass => _CuttingDiameterClass ?? (_CuttingDiameterClass = new Package.CuttingDiameterClass());
	private Package.CuttingHeightClass _CuttingHeightClass;
	public Package.CuttingHeightClass CuttingHeightClass => _CuttingHeightClass ?? (_CuttingHeightClass = new Package.CuttingHeightClass());
	private Package.CornerRadiusClass _CornerRadiusClass;
	public Package.CornerRadiusClass CornerRadiusClass => _CornerRadiusClass ?? (_CornerRadiusClass = new Package.CornerRadiusClass());
	private Package.WeightClass _WeightClass;
	public Package.WeightClass WeightClass => _WeightClass ?? (_WeightClass = new Package.WeightClass());
	private Package.ChamferFlatLengthClass _ChamferFlatLengthClass;
	public Package.ChamferFlatLengthClass ChamferFlatLengthClass => _ChamferFlatLengthClass ?? (_ChamferFlatLengthClass = new Package.ChamferFlatLengthClass());
	private Package.ChamferWidthClass _ChamferWidthClass;
	public Package.ChamferWidthClass ChamferWidthClass => _ChamferWidthClass ?? (_ChamferWidthClass = new Package.ChamferWidthClass());
	private Package.InsertWidthClass _InsertWidthClass;
	public Package.InsertWidthClass InsertWidthClass => _InsertWidthClass ?? (_InsertWidthClass = new Package.InsertWidthClass());
	}
}