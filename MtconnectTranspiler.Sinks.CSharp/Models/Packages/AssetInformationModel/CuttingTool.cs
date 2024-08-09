using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="CuttingTool">CuttingTool</see> and <see cref="CuttingToolArchetype">CuttingToolArchetype</see> models.  ![CuttingTool](figures/CuttingTool.png "CuttingTool"){: width="0.8"}  > Note: See <see cref="CuttingTool Schema Diagrams">CuttingTool Schema Diagrams</see> for XML schema. /// Cutting Tool Asset Information Model
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_E48B3DBE_1F88_44a2_A30D_869E9C800DEB">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class CuttingToolPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_E48B3DBE_1F88_44a2_A30D_869E9C800DEB";
		
		/// <inheritdoc />
		public string Name => "Cutting Tool";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""CuttingTool"">CuttingTool</see> and <see cref=""CuttingToolArchetype"">CuttingToolArchetype</see> models.  ![CuttingTool](figures/CuttingTool.png ""CuttingTool""){: width=""0.8""}  > Note: See <see cref=""CuttingTool Schema Diagrams"">CuttingTool Schema Diagrams</see> for XML schema. /// Cutting Tool Asset Information Model";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			CuttingItemPackage,
			CuttingToolMeasurementSubtypesPackage,
			CuttingToolLifeCyclePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			CuttingToolClass,
			CuttingToolArchetypeClass,
			CuttingToolArchetypeReferenceClass,
			CuttingToolDefinitionClass,
		};
		#region Packages
	private Package.CuttingItemPackage _CuttingItemPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingItemPackage" path="/summary" />
	/// </summary>
	public Package.CuttingItemPackage CuttingItemPackage => _CuttingItemPackage ?? (_CuttingItemPackage = new Package.CuttingItemPackage());

	private Package.CuttingToolMeasurementSubtypesPackage _CuttingToolMeasurementSubtypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingToolMeasurementSubtypesPackage" path="/summary" />
	/// </summary>
	public Package.CuttingToolMeasurementSubtypesPackage CuttingToolMeasurementSubtypesPackage => _CuttingToolMeasurementSubtypesPackage ?? (_CuttingToolMeasurementSubtypesPackage = new Package.CuttingToolMeasurementSubtypesPackage());

	private Package.CuttingToolLifeCyclePackage _CuttingToolLifeCyclePackage;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingToolLifeCyclePackage" path="/summary" />
	/// </summary>
	public Package.CuttingToolLifeCyclePackage CuttingToolLifeCyclePackage => _CuttingToolLifeCyclePackage ?? (_CuttingToolLifeCyclePackage = new Package.CuttingToolLifeCyclePackage());

	#endregion

	#region Classes
	private Package.CuttingToolClass _CuttingToolClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingToolClass" path="/summary" />
	/// </summary>
	public Package.CuttingToolClass CuttingToolClass => _CuttingToolClass ?? (_CuttingToolClass = new Package.CuttingToolClass());

	private Package.CuttingToolArchetypeClass _CuttingToolArchetypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingToolArchetypeClass" path="/summary" />
	/// </summary>
	public Package.CuttingToolArchetypeClass CuttingToolArchetypeClass => _CuttingToolArchetypeClass ?? (_CuttingToolArchetypeClass = new Package.CuttingToolArchetypeClass());

	private Package.CuttingToolArchetypeReferenceClass _CuttingToolArchetypeReferenceClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingToolArchetypeReferenceClass" path="/summary" />
	/// </summary>
	public Package.CuttingToolArchetypeReferenceClass CuttingToolArchetypeReferenceClass => _CuttingToolArchetypeReferenceClass ?? (_CuttingToolArchetypeReferenceClass = new Package.CuttingToolArchetypeReferenceClass());

	private Package.CuttingToolDefinitionClass _CuttingToolDefinitionClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingToolDefinitionClass" path="/summary" />
	/// </summary>
	public Package.CuttingToolDefinitionClass CuttingToolDefinitionClass => _CuttingToolDefinitionClass ?? (_CuttingToolDefinitionClass = new Package.CuttingToolDefinitionClass());

	#endregion
	}
}