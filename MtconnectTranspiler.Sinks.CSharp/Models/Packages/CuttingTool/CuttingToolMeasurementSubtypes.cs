using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool.CuttingToolMeasurementSubtypes;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel.CuttingTool {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CuttingToolMeasurementSubtypesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

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

	private Package.BodyDiameterMaxClass _BodyDiameterMaxClass;
	public Package.BodyDiameterMaxClass BodyDiameterMaxClass => _BodyDiameterMaxClass ?? (_BodyDiameterMaxClass = new Package.BodyDiameterMaxClass());
	private Package.BodyLengthMaxClass _BodyLengthMaxClass;
	public Package.BodyLengthMaxClass BodyLengthMaxClass => _BodyLengthMaxClass ?? (_BodyLengthMaxClass = new Package.BodyLengthMaxClass());
	private Package.DepthOfCutMaxClass _DepthOfCutMaxClass;
	public Package.DepthOfCutMaxClass DepthOfCutMaxClass => _DepthOfCutMaxClass ?? (_DepthOfCutMaxClass = new Package.DepthOfCutMaxClass());
	private Package.CuttingDiameterMaxClass _CuttingDiameterMaxClass;
	public Package.CuttingDiameterMaxClass CuttingDiameterMaxClass => _CuttingDiameterMaxClass ?? (_CuttingDiameterMaxClass = new Package.CuttingDiameterMaxClass());
	private Package.FlangeDiameterMaxClass _FlangeDiameterMaxClass;
	public Package.FlangeDiameterMaxClass FlangeDiameterMaxClass => _FlangeDiameterMaxClass ?? (_FlangeDiameterMaxClass = new Package.FlangeDiameterMaxClass());
	private Package.OverallToolLengthClass _OverallToolLengthClass;
	public Package.OverallToolLengthClass OverallToolLengthClass => _OverallToolLengthClass ?? (_OverallToolLengthClass = new Package.OverallToolLengthClass());
	private Package.ShankDiameterClass _ShankDiameterClass;
	public Package.ShankDiameterClass ShankDiameterClass => _ShankDiameterClass ?? (_ShankDiameterClass = new Package.ShankDiameterClass());
	private Package.ShankHeightClass _ShankHeightClass;
	public Package.ShankHeightClass ShankHeightClass => _ShankHeightClass ?? (_ShankHeightClass = new Package.ShankHeightClass());
	private Package.ShankLengthClass _ShankLengthClass;
	public Package.ShankLengthClass ShankLengthClass => _ShankLengthClass ?? (_ShankLengthClass = new Package.ShankLengthClass());
	private Package.UsableLengthMaxClass _UsableLengthMaxClass;
	public Package.UsableLengthMaxClass UsableLengthMaxClass => _UsableLengthMaxClass ?? (_UsableLengthMaxClass = new Package.UsableLengthMaxClass());
	private Package.ProtrudingLengthClass _ProtrudingLengthClass;
	public Package.ProtrudingLengthClass ProtrudingLengthClass => _ProtrudingLengthClass ?? (_ProtrudingLengthClass = new Package.ProtrudingLengthClass());
	private Package.FunctionalLengthClass _FunctionalLengthClass;
	public Package.FunctionalLengthClass FunctionalLengthClass => _FunctionalLengthClass ?? (_FunctionalLengthClass = new Package.FunctionalLengthClass());
	private Package.WeightClass _WeightClass;
	public Package.WeightClass WeightClass => _WeightClass ?? (_WeightClass = new Package.WeightClass());
	}
}