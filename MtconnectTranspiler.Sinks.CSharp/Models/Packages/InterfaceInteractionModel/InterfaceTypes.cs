using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.InterfaceTypes;

namespace Mtconnect.InterfaceInteractionModel
{
	/// <summary>
	﻿/// The abstract <see cref="Interface">Interface</see> is realized by the following types listed in this section. <br /><br />In order to implement the <i>interaction model</i> for <i>interface</i>s, each piece of equipment associated with an <i>interface</i> <b>MUST</b> provide the corresponding <see cref="Interface">Interface</see> type. A piece of equipment <b>MAY</b> support any number of unique <i>interface</i>s.<br/><br />Interfaces for Device and Observation Information Models<br/>The <i>interaction model</i> for implementing <i>interface</i>s is defined in the MTConnect Standard as an extension to the <i>Device Information Model</i> and <i>Observation Information Model</i>.<br /><br />A piece of equipment <b>MAY</b> support multiple different <i>interface</i>s. Each piece of equipment supporting <i>interface</i>s <b>MUST</b> model the information associated with each <i>interface</i> as an <see cref="Interface">Interface</see> component.  <see cref="Interface">Interface</see> is an abstract <see cref="Component">Component</see> and is realized by <see cref="Interface">Interface</see> component types. <br /><br />The {{figure(Interfaces in Entity Hierarchy)}} illustrates where an <see cref="Interface">Interface</see> is modeled in the <i>Device Information Model</i> for a piece of equipment.<br /><br />![Interfaces in Entity Hierarchy](figures/Interfaces%20in%20Entity%20Hierarchy.png "Interfaces in Entity Hierarchy"){: width="0.8"}<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1622717338882_321462_855">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class InterfaceTypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622717338882_321462_855";
		
		/// <inheritdoc />
		public string Name => "Interface Types";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;The abstract {{block(Interface)}} is realized by the following types listed in this section. 

In order to implement the {{term(interaction model)}} for {{termplural(interface)}}, each piece of equipment associated with an {{term(interface)}} **MUST** provide the corresponding {{block(Interface)}} type. A piece of equipment **MAY** support any number of unique {{termplural(interface)}}.&#10;
&#10;&#10;&#10;Interfaces for Device and Observation Information Models&#10;&#10;&#10;&#10;The {{term(interaction model)}} for implementing {{termplural(interface)}} is defined in the MTConnect Standard as an extension to the {{term(Device Information Model)}} and {{term(Observation Information Model)}}.

A piece of equipment **MAY** support multiple different {{termplural(interface)}}. Each piece of equipment supporting {{termplural(interface)}} **MUST** model the information associated with each {{term(interface)}} as an {{block(Interface)}} component.  {{block(Interface)}} is an abstract {{block(Component)}} and is realized by {{block(Interface)}} component types. 

The {{figure(Interfaces in Entity Hierarchy)}} illustrates where an {{block(Interface)}} is modeled in the {{term(Device Information Model)}} for a piece of equipment.

![Interfaces in Entity Hierarchy](figures/Interfaces%20in%20Entity%20Hierarchy.png ""Interfaces in Entity Hierarchy""){: width=""0.8""}&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			BarFeederInterfaceGeneralization,
			MaterialHandlerInterfaceGeneralization,
			DoorInterfaceGeneralization,
			ChuckInterfaceGeneralization,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.BarFeederInterfaceGeneralization _BarFeederInterfaceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.BarFeederInterfaceGeneralization" path="/summary" />
	/// </summary>
	public Package.BarFeederInterfaceGeneralization BarFeederInterfaceGeneralization => _BarFeederInterfaceGeneralization ?? (_BarFeederInterfaceGeneralization = new Package.BarFeederInterfaceGeneralization());

	private Package.MaterialHandlerInterfaceGeneralization _MaterialHandlerInterfaceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialHandlerInterfaceGeneralization" path="/summary" />
	/// </summary>
	public Package.MaterialHandlerInterfaceGeneralization MaterialHandlerInterfaceGeneralization => _MaterialHandlerInterfaceGeneralization ?? (_MaterialHandlerInterfaceGeneralization = new Package.MaterialHandlerInterfaceGeneralization());

	private Package.DoorInterfaceGeneralization _DoorInterfaceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.DoorInterfaceGeneralization" path="/summary" />
	/// </summary>
	public Package.DoorInterfaceGeneralization DoorInterfaceGeneralization => _DoorInterfaceGeneralization ?? (_DoorInterfaceGeneralization = new Package.DoorInterfaceGeneralization());

	private Package.ChuckInterfaceGeneralization _ChuckInterfaceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.ChuckInterfaceGeneralization" path="/summary" />
	/// </summary>
	public Package.ChuckInterfaceGeneralization ChuckInterfaceGeneralization => _ChuckInterfaceGeneralization ?? (_ChuckInterfaceGeneralization = new Package.ChuckInterfaceGeneralization());

	#endregion
	}
}