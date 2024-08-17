#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="CuttingTool">CuttingTool</see> and <see cref="CuttingToolArchetype">CuttingToolArchetype</see> models.<br /><br />![CuttingTool](figures/CuttingTool.png "CuttingTool"){: width="0.8"}<br /><br />&gt; Note: See <see cref="CuttingTool Schema Diagrams">CuttingTool Schema Diagrams</see> for XML schema.<br /><br /><br /><br />Cutting Tool Asset Information Model<br /><br />There are two <i>information model</i>s used to represent a cutting tool, <see cref="CuttingToolArchetype">CuttingToolArchetype</see> and <see cref="CuttingTool">CuttingTool</see>. The <see cref="CuttingToolArchetype">CuttingToolArchetype</see> represents the static cutting tool geometries and nominal values as one would expect from a tool catalog and the <see cref="CuttingTool">CuttingTool</see> represents the use or application of the tool on the shop floor with actual measured values and process data. In Version 1.3.0 of the MTConnect Standard it was decided to separate out these two concerns since not all pieces of equipment will have access to both sets of information. In this way, a generic definition of the cutting tool can coexist with a specific assembly <i>information model</i> with minimal redundancy of data.<br /><br />MTConnect Standard will adopt the ISO 13399 structure when formulating the vocabulary for Cutting Tool geometries and structure to be represented in the <see cref="CuttingToolArchetype">CuttingToolArchetype</see>. The nominal values provided in the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> section are only concerned with two aspects of the Cutting Tool; the Cutting Tool and the cutting item. The tool item, Adaptive Item, and Assembly Item will only be covered in the <see cref="CuttingToolDefinition">CuttingToolDefinition</see> section of this document since this section contains the full ISO 13399 information about a Cutting Tool.<br /><br />![Cutting Tool Parts](figures/Cutting%20Tool%20Parts.png "Cutting Tool Parts"){: width="0.8"}<br /><br />The {{figure(Cutting Tool Parts)}} illustrates the parts of a Cutting Tool. The Cutting Tool is the aggregate of all the components and the cutting item is the part of the tool that removes the material from the workpiece. These are the primary focus of the MTConnect Standard.<br /><br />![Cutting Tool Composition](figures/Cutting%20Tool%20Composition.png "Cutting Tool Composition"){: width="0.8"}<br /><br />{{figure(Cutting Tool Composition)}} provides another view of the composition of a Cutting Tool. The Adaptive Items and tool items will be used for measurements, but will not be modeled as separate entities. When we are referencing the Cutting Tool we are referring to the entirety of the assembly and when we provide data regarding the cutting item we are referencing each individual item as illustrated on the left of the previous diagram.<br /><br />![Cutting Tool, Tool Item, and Cutting Item](figures/Cutting%20Tool,%20Tool%20Item,%20and%20Cutting%20Item.png "Cutting Tool, Tool Item, and Cutting Item"){: width="0.8"}<br /><br />![Cutting Tool, Tool Item, and Cutting Item 2](figures/Cutting%20Tool,%20Tool%20Item,%20and%20Cutting%20Item%202.png "Cutting Tool, Tool Item, and Cutting Item 2"){: width="0.8"}<br /><br /><br />{{figure(Cutting Tool, Tool Item, and Cutting Item)}} and {{figure(Cutting Tool, Tool Item, and Cutting Item 2)}} further illustrates the components of the Cutting Tool. As we compose the tool item, cutting item, Adaptive Item, we get a Cutting Tool. The tool item, Adaptive Item, and Assembly Item will only be in the <see cref="CuttingToolDefinition">CuttingToolDefinition</see> section that will contain the full ISO 13399 information. These figures also use the ISO 13399 codes for each of the measurements. These codes will be translated into the MTConnect Standard vocabulary as illustrated below. The measurements will have a maximum, minimum, and nominal value representing the tolerance of allowable values for this dimension.<br /><br />The MTConnect Standard will not define the entire geometry of the Cutting Tool, but will provide the information necessary to use the tool in the manufacturing process. Additional information can be added to the definition of the Cutting Tool by means of schema extensions.<br /><br />Additional diagrams will reference these dimensions by their codes that will be defined in the measurement tables. The codes are consistent with the codes used in ISO 13399 and have been standardized. MTConnect Standard will use the full text name for clarity in the <i>response document</i>s.<br /><br /><br /><br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_E48B3DBE_1F88_44a2_A30D_869E9C800DEB">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class CuttingToolPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_E48B3DBE_1F88_44a2_A30D_869E9C800DEB";
		
		/// <inheritdoc />
		public string Name => "Cutting Tool";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(CuttingTool)}} and {{block(CuttingToolArchetype)}} models.

![CuttingTool](figures/CuttingTool.png ""CuttingTool""){: width=""0.8""}

> Note: See {{sect(CuttingTool Schema Diagrams)}} for XML schema.
&#10;
&#10;&#10;&#10;Cutting Tool Asset Information Model&#10;&#10;&#10;&#10;There are two {{termplural(information model)}} used to represent a cutting tool, {{block(CuttingToolArchetype)}} and {{block(CuttingTool)}}. The {{block(CuttingToolArchetype)}} represents the static cutting tool geometries and nominal values as one would expect from a tool catalog and the {{block(CuttingTool)}} represents the use or application of the tool on the shop floor with actual measured values and process data. In Version 1.3.0 of the MTConnect Standard it was decided to separate out these two concerns since not all pieces of equipment will have access to both sets of information. In this way, a generic definition of the cutting tool can coexist with a specific assembly {{term(information model)}} with minimal redundancy of data.

MTConnect Standard will adopt the ISO 13399 structure when formulating the vocabulary for Cutting Tool geometries and structure to be represented in the {{block(CuttingToolArchetype)}}. The nominal values provided in the {{block(CuttingToolLifeCycle)}} section are only concerned with two aspects of the Cutting Tool; the Cutting Tool and the cutting item. The tool item, Adaptive Item, and Assembly Item will only be covered in the {{block(CuttingToolDefinition)}} section of this document since this section contains the full ISO 13399 information about a Cutting Tool.

![Cutting Tool Parts](figures/Cutting%20Tool%20Parts.png ""Cutting Tool Parts""){: width=""0.8""}

The {{figure(Cutting Tool Parts)}} illustrates the parts of a Cutting Tool. The Cutting Tool is the aggregate of all the components and the cutting item is the part of the tool that removes the material from the workpiece. These are the primary focus of the MTConnect Standard.

![Cutting Tool Composition](figures/Cutting%20Tool%20Composition.png ""Cutting Tool Composition""){: width=""0.8""}

{{figure(Cutting Tool Composition)}} provides another view of the composition of a Cutting Tool. The Adaptive Items and tool items will be used for measurements, but will not be modeled as separate entities. When we are referencing the Cutting Tool we are referring to the entirety of the assembly and when we provide data regarding the cutting item we are referencing each individual item as illustrated on the left of the previous diagram.

![Cutting Tool, Tool Item, and Cutting Item](figures/Cutting%20Tool,%20Tool%20Item,%20and%20Cutting%20Item.png ""Cutting Tool, Tool Item, and Cutting Item""){: width=""0.8""}

![Cutting Tool, Tool Item, and Cutting Item 2](figures/Cutting%20Tool,%20Tool%20Item,%20and%20Cutting%20Item%202.png ""Cutting Tool, Tool Item, and Cutting Item 2""){: width=""0.8""}


{{figure(Cutting Tool, Tool Item, and Cutting Item)}} and {{figure(Cutting Tool, Tool Item, and Cutting Item 2)}} further illustrates the components of the Cutting Tool. As we compose the tool item, cutting item, Adaptive Item, we get a Cutting Tool. The tool item, Adaptive Item, and Assembly Item will only be in the {{block(CuttingToolDefinition)}} section that will contain the full ISO 13399 information. These figures also use the ISO 13399 codes for each of the measurements. These codes will be translated into the MTConnect Standard vocabulary as illustrated below. The measurements will have a maximum, minimum, and nominal value representing the tolerance of allowable values for this dimension.

The MTConnect Standard will not define the entire geometry of the Cutting Tool, but will provide the information necessary to use the tool in the manufacturing process. Additional information can be added to the definition of the Cutting Tool by means of schema extensions.

Additional diagrams will reference these dimensions by their codes that will be defined in the measurement tables. The codes are consistent with the codes used in ISO 13399 and have been standardized. MTConnect Standard will use the full text name for clarity in the {{termplural(response document)}}.


&#10;
";

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
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}