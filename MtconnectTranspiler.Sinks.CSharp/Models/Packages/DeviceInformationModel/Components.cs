#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Components;

namespace Mtconnect.DeviceInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="Component">Component</see> entity. {{figure(Components)}} shows the <see cref="Component">Component</see> model. <br /><br />![Components](figures/Components.png "Components"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Components Schema Diagrams">Components Schema Diagrams</see> for XML schema.<br /><br /><br /><br />Components Model<br /><br /><see cref="MTConnectDevices">MTConnectDevices</see> provides the physical and logical architecture of a piece of equipment. {{figure(Device Entity Hierarchy Example)}} provides an overview of the entities used in an example of an <see cref="MTConnectDevices">MTConnectDevices</see> entity.<br /><br />![Device Entity Hierarchy Example](figures/Device%20Entity%20Hierarchy%20Example.png "Device Entity Hierarchy Example"){: width="0.8"}<br /><br />&gt; Note 1 to entry: See {{lst(device-entity-hierarchy-example)}} for the <i>XML</i> representation of the same example.<br /><br />&gt; Note 2 to entry: Example above only shows the <see cref="Component">Component</see> and <see cref="Composition">Composition</see> level hierarchy. For a complete semantics on each kind see <see cref="Components">Components</see> and <see cref="Compositions">Compositions</see>.<br /><br />A variety of entities are defined to describe a piece of equipment.  Some of these entities <b>MUST</b> always be defined for an <see cref="MTConnectDevices">MTConnectDevices</see> entity, while others are optional and <b>MAY</b> be used, as required, to provide additional structure.<br /><br />The first, or highest level, entity defined for an <see cref="MTConnectDevices">MTConnectDevices</see> entity is <see cref="Devices">Devices</see>. <see cref="Devices">Devices</see> is used to group one or more pieces of equipment into a single document.  <see cref="Devices">Devices</see> <b>MUST</b> always be defined for an <see cref="MTConnectDevices">MTConnectDevices</see> entity.<br /><br /><see cref="Device">Device</see> is the next entity defined for the <see cref="MTConnectDevices">MTConnectDevices</see> entity. A separate <see cref="Device">Device</see> entity is used to identify each piece of equipment for an <see cref="MTConnectDevices">MTConnectDevices</see> entity. Each <see cref="Device">Device</see> provides information on the physical and logical structure of the piece of equipment and the data associated with that equipment. <see cref="Device">Device</see> can also represent any logical grouping of pieces of equipment that function as a unit or any other data source that provides data through an <i>agent</i>.<br /><br />One or more <see cref="Device">Device</see> entities <b>MUST</b> always be defined for an <see cref="MTConnectDevices">MTConnectDevices</see> entity.<br /><br /><see cref="Components">Components</see> is the next entity defined for the <see cref="MTConnectDevices">MTConnectDevices</see> entity. <see cref="Components">Components</see> is used to group information describing lower level physical parts or logical functions of a piece of equipment.<br /><br /><see cref="Component">Component</see> is the next level of entity defined for the <see cref="MTConnectDevices">MTConnectDevices</see> entity. <see cref="Component">Component</see> is both an abstract type entity and an <i>organizer</i> type entity. <br /><br />As an abstract entity, <see cref="Component">Component</see> will always be realized by a specific <see cref="Component">Component</see> type defined in <see cref="Component Types">Component Types</see>. Each <see cref="Component">Component</see> can also be used to organize information describing <i>lower level</i> entities or <i>DataItem</i>s associated with the <see cref="Component">Component</see>.<br /><br />If <i>lower level</i> entities are described, these entities are by definition child <see cref="Component">Component</see> entities of a parent <see cref="Component">Component</see>. At this next level, the <i>lower level</i> child <see cref="Component">Component</see> entities are grouped by <see cref="Components">Components</see>.<br /><br />A <see cref="Component">Component</see> <b>MAY</b> be further decomposed into <see cref="Composition">Composition</see> entities that are grouped by <see cref="Compositions">Compositions</see>. These describe the lowest level basic structural or functional building blocks contained within a <see cref="Component">Component</see>. Data provided for a <see cref="Component">Component</see> provides more specific meaning when it is associated with one of the <see cref="Composition">Composition</see> entities of the <see cref="Component">Component</see>. The different <see cref="Composition">Composition</see> types that <b>MAY</b> be defined for the <see cref="MTConnectDevices">MTConnectDevices</see> entity are defined in <see cref="Compositions">Compositions</see>.<br /><br />This parent-child relationship can continue to any depth required to fully define a piece of equipment.<br /><br />&gt; Note: See {{figure(Device Entity Hierarchy Example)}} for an example.<br /><br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_6F87CB48_AFED_473f_92DF_E7AFDAFD3CAC">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ComponentsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_6F87CB48_AFED_473f_92DF_E7AFDAFD3CAC";
		
		/// <inheritdoc />
		public string Name => "Components";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(Component)}} entity. {{figure(Components)}} shows the {{block(Component)}} model. 

![Components](figures/Components.png ""Components""){: width=""0.8""}

> Note: See {{sect(Components Schema Diagrams)}} for XML schema.
&#10;
&#10;&#10;&#10;Components Model&#10;&#10;&#10;&#10;{{block(MTConnectDevices)}} provides the physical and logical architecture of a piece of equipment. {{figure(Device Entity Hierarchy Example)}} provides an overview of the entities used in an example of an {{block(MTConnectDevices)}} entity.

![Device Entity Hierarchy Example](figures/Device%20Entity%20Hierarchy%20Example.png ""Device Entity Hierarchy Example""){: width=""0.8""}

> Note 1 to entry: See {{lst(device-entity-hierarchy-example)}} for the {{term(XML)}} representation of the same example.

> Note 2 to entry: Example above only shows the {{block(Component)}} and {{block(Composition)}} level hierarchy. For a complete semantics on each kind see {{package(Components)}} and {{package(Compositions)}}.

A variety of entities are defined to describe a piece of equipment.  Some of these entities **MUST** always be defined for an {{block(MTConnectDevices)}} entity, while others are optional and **MAY** be used, as required, to provide additional structure.

The first, or highest level, entity defined for an {{block(MTConnectDevices)}} entity is {{block(Devices)}}. {{block(Devices)}} is used to group one or more pieces of equipment into a single document.  {{block(Devices)}} **MUST** always be defined for an {{block(MTConnectDevices)}} entity.

{{block(Device)}} is the next entity defined for the {{block(MTConnectDevices)}} entity. A separate {{block(Device)}} entity is used to identify each piece of equipment for an {{block(MTConnectDevices)}} entity. Each {{block(Device)}} provides information on the physical and logical structure of the piece of equipment and the data associated with that equipment. {{block(Device)}} can also represent any logical grouping of pieces of equipment that function as a unit or any other data source that provides data through an {{term(agent)}}.

One or more {{block(Device)}} entities **MUST** always be defined for an {{block(MTConnectDevices)}} entity.

{{block(Components)}} is the next entity defined for the {{block(MTConnectDevices)}} entity. {{block(Components)}} is used to group information describing lower level physical parts or logical functions of a piece of equipment.

{{block(Component)}} is the next level of entity defined for the {{block(MTConnectDevices)}} entity. {{block(Component)}} is both an abstract type entity and an {{term(organizer)}} type entity. 

As an abstract entity, {{block(Component)}} will always be realized by a specific {{block(Component)}} type defined in {{package(Component Types)}}. Each {{block(Component)}} can also be used to organize information describing {{term(lower level)}} entities or {{termplural(DataItem)}} associated with the {{block(Component)}}.

If {{term(lower level)}} entities are described, these entities are by definition child {{block(Component)}} entities of a parent {{block(Component)}}. At this next level, the {{term(lower level)}} child {{block(Component)}} entities are grouped by {{block(Components)}}.

A {{block(Component)}} **MAY** be further decomposed into {{block(Composition)}} entities that are grouped by {{block(Compositions)}}. These describe the lowest level basic structural or functional building blocks contained within a {{block(Component)}}. Data provided for a {{block(Component)}} provides more specific meaning when it is associated with one of the {{block(Composition)}} entities of the {{block(Component)}}. The different {{block(Composition)}} types that **MAY** be defined for the {{block(MTConnectDevices)}} entity are defined in {{package(Compositions)}}.

This parent-child relationship can continue to any depth required to fully define a piece of equipment.

> Note: See {{figure(Device Entity Hierarchy Example)}} for an example.
&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			ComponentTypesPackage,
			DevicesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ComponentGeneralization,
			DescriptionClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.ComponentTypesPackage _ComponentTypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentTypesPackage" path="/summary" />
	/// </summary>
	public Package.ComponentTypesPackage ComponentTypesPackage => _ComponentTypesPackage ?? (_ComponentTypesPackage = new Package.ComponentTypesPackage());

	private Package.DevicesPackage _DevicesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.DevicesPackage" path="/summary" />
	/// </summary>
	public Package.DevicesPackage DevicesPackage => _DevicesPackage ?? (_DevicesPackage = new Package.DevicesPackage());

	#endregion

	#region Classes
	private Package.ComponentGeneralization _ComponentGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentGeneralization" path="/summary" />
	/// </summary>
	public Package.ComponentGeneralization ComponentGeneralization => _ComponentGeneralization ?? (_ComponentGeneralization = new Package.ComponentGeneralization());

	private Package.DescriptionClass _DescriptionClass;
	/// <summary>
	/// <inheritdoc cref="Package.DescriptionClass" path="/summary" />
	/// </summary>
	public Package.DescriptionClass DescriptionClass => _DescriptionClass ?? (_DescriptionClass = new Package.DescriptionClass());

	#endregion

	#region Enums
	#endregion
	}
}