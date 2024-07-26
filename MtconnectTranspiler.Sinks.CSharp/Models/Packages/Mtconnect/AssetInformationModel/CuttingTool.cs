
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AssetInformationModel.CuttingTool;

using Mtconnect;

namespace Mtconnect.AssetInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CuttingToolPackage {

	private Package.CuttingItemPackage _CuttingItemPackage;
	public Package.CuttingItemPackage CuttingItemPackage => _CuttingItemPackage ?? (_CuttingItemPackage = new Package.CuttingItemPackage());

	private Package.CuttingToolMeasurementSubtypesPackage _CuttingToolMeasurementSubtypesPackage;
	public Package.CuttingToolMeasurementSubtypesPackage CuttingToolMeasurementSubtypesPackage => _CuttingToolMeasurementSubtypesPackage ?? (_CuttingToolMeasurementSubtypesPackage = new Package.CuttingToolMeasurementSubtypesPackage());

	private Package.CuttingToolLifeCyclePackage _CuttingToolLifeCyclePackage;
	public Package.CuttingToolLifeCyclePackage CuttingToolLifeCyclePackage => _CuttingToolLifeCyclePackage ?? (_CuttingToolLifeCyclePackage = new Package.CuttingToolLifeCyclePackage());


	private Package.CuttingToolClass _CuttingTool;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CuttingToolClass CuttingTool => _CuttingTool ?? (_CuttingTool = new Package.CuttingToolClass());

	private Package.CuttingToolArchetypeClass _CuttingToolArchetype;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CuttingToolArchetypeClass CuttingToolArchetype => _CuttingToolArchetype ?? (_CuttingToolArchetype = new Package.CuttingToolArchetypeClass());

	private Package.CuttingToolArchetypeReferenceClass _CuttingToolArchetypeReference;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CuttingToolArchetypeReferenceClass CuttingToolArchetypeReference => _CuttingToolArchetypeReference ?? (_CuttingToolArchetypeReference = new Package.CuttingToolArchetypeReferenceClass());

	private Package.CuttingToolDefinitionClass _CuttingToolDefinition;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CuttingToolDefinitionClass CuttingToolDefinition => _CuttingToolDefinition ?? (_CuttingToolDefinition = new Package.CuttingToolDefinitionClass());
	}
}