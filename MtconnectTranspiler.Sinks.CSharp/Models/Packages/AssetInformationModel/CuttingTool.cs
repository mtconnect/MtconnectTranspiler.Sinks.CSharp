using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CuttingToolPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			CuttingItemPackage,
			CuttingToolMeasurementSubtypesPackage,
			CuttingToolLifeCyclePackage,
		};

		public IClass[] Classes => new IClass[] {
			CuttingToolClass,
			CuttingToolArchetypeClass,
			CuttingToolArchetypeReferenceClass,
			CuttingToolDefinitionClass,
		};
	private Package.CuttingItemPackage _CuttingItemPackage;
	public Package.CuttingItemPackage CuttingItemPackage => _CuttingItemPackage ?? (_CuttingItemPackage = new Package.CuttingItemPackage());
	private Package.CuttingToolMeasurementSubtypesPackage _CuttingToolMeasurementSubtypesPackage;
	public Package.CuttingToolMeasurementSubtypesPackage CuttingToolMeasurementSubtypesPackage => _CuttingToolMeasurementSubtypesPackage ?? (_CuttingToolMeasurementSubtypesPackage = new Package.CuttingToolMeasurementSubtypesPackage());
	private Package.CuttingToolLifeCyclePackage _CuttingToolLifeCyclePackage;
	public Package.CuttingToolLifeCyclePackage CuttingToolLifeCyclePackage => _CuttingToolLifeCyclePackage ?? (_CuttingToolLifeCyclePackage = new Package.CuttingToolLifeCyclePackage());

	private Package.CuttingToolClass _CuttingToolClass;
	public Package.CuttingToolClass CuttingToolClass => _CuttingToolClass ?? (_CuttingToolClass = new Package.CuttingToolClass());
	private Package.CuttingToolArchetypeClass _CuttingToolArchetypeClass;
	public Package.CuttingToolArchetypeClass CuttingToolArchetypeClass => _CuttingToolArchetypeClass ?? (_CuttingToolArchetypeClass = new Package.CuttingToolArchetypeClass());
	private Package.CuttingToolArchetypeReferenceClass _CuttingToolArchetypeReferenceClass;
	public Package.CuttingToolArchetypeReferenceClass CuttingToolArchetypeReferenceClass => _CuttingToolArchetypeReferenceClass ?? (_CuttingToolArchetypeReferenceClass = new Package.CuttingToolArchetypeReferenceClass());
	private Package.CuttingToolDefinitionClass _CuttingToolDefinitionClass;
	public Package.CuttingToolDefinitionClass CuttingToolDefinitionClass => _CuttingToolDefinitionClass ?? (_CuttingToolDefinitionClass = new Package.CuttingToolDefinitionClass());
	}
}