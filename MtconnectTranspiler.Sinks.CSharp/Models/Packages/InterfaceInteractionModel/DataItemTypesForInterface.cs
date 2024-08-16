using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.DataItemTypesForInterface;

namespace Mtconnect.InterfaceInteractionModel
{
	/// <summary>
	﻿/// Each <see cref="Interface">Interface</see> contains data items which are used to communicate information required to execute the <i>interface</i>. When these data items are read by another piece of equipment, that piece of equipment can then determine the actions that it may take based upon that data.<br /><br /><see cref="InterfaceState">InterfaceState</see> is a data item specifically defined for <i>interface</i>s.  It defines the operational state of the <i>interface</i>.  This is an indicator identifying whether the <i>interface</i> is functioning or not. See <see cref="InterfaceState">InterfaceState</see> for complete semantic details.<br /><br />Some data items <b>MAY</b> be directly associated with the <see cref="Interface">Interface</see> element and others will be organized by a <see cref="References">References</see> element. It is up to an implementer to determine which additional data items are required for a particular <i>interface</i>.<br /><br />### Specific Data Items for the Interaction Model for Interface<br /><br />A special set of data items have been defined to be used in conjunction with <see cref="Interface">Interface</see>. They provide information from a piece of equipment to <i>request</i> a service to be performed by another associated piece of equipment; and for the associated piece of equipment to indicate its progress in performing its <i>response</i> to the <i>request</i> for service.  .<br /><br />Many of the data items describing the services associated with an <i>interface</i> are paired to describe two distinct actions – one to <i>request</i> an action to be performed and a second to reverse the action or to return to an original state.  For example, a <see cref="DoorInterface">DoorInterface</see> will have two actions <see cref="OpenDoor">OpenDoor</see> and <see cref="CloseDoor">CloseDoor</see>. An example of an implementation of this would be a robot that indicates to a machine that it would like to have a door opened so that the robot could extract a part from the machine and then asks the machine to close that door once the part has been removed. <br /><br />When these data items are used to describe a service associated with an <i>interface</i>, they <b>MUST</b> have one of the following two <c>subType</c> elements: <c>REQUEST</c> or <c>RESPONSE</c>.  These <b>MUST</b> be specified to define whether the piece of equipment is functioning as the <i>requester</i> or <i>responder</i> for the service to be performed.  The <i>requester</i> <b>MUST</b> specify the <c>REQUEST</c> <c>subType</c> for the data item and the <i>responder</i> <b>MUST</b> specify a corresponding <c>RESPONSE</c> <c>subType</c> for the data item to enable the coordination between the two pieces of equipment.   <br /><br />These data items and their associated <c>subType</c> provide the basic structure for implementing the <i>interaction model</i> for an <i>interface</i> and are defined in the following sections.<br /><br />{{figure(Request State Machine)}} and {{figure(Response State Machine)}} show possible state transitions for a <i>request</i> and <i>response</i> respectively. The state machine diagrams provide the permissible values of the <i>observation</i>s for the <see cref="DataItem">DataItem</see> types listed in this section.<br /><br />![Request State Machine](figures/Request%20State%20Machine.png "Request State Machine"){: width="0.8"}<br /><br />![Response State Machine](figures/Response%20State%20Machine.png "Response State Machine"){: width="0.8"}<br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1629373205367_975278_21">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class DataItemTypesForInterfacePackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1629373205367_975278_21";
		
		/// <inheritdoc />
		public string Name => "DataItem Types for Interface";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;Each {{block(Interface)}} contains data items which are used to communicate information required to execute the {{term(interface)}}. When these data items are read by another piece of equipment, that piece of equipment can then determine the actions that it may take based upon that data.

{{block(InterfaceState)}} is a data item specifically defined for {{termplural(interface)}}.  It defines the operational state of the {{term(interface)}}.  This is an indicator identifying whether the {{term(interface)}} is functioning or not. See {{sect(InterfaceState)}} for complete semantic details.

Some data items **MAY** be directly associated with the {{block(Interface)}} element and others will be organized by a {{block(References)}} element. It is up to an implementer to determine which additional data items are required for a particular {{term(interface)}}.

### Specific Data Items for the Interaction Model for Interface

A special set of data items have been defined to be used in conjunction with {{block(Interface)}}. They provide information from a piece of equipment to {{term(request)}} a service to be performed by another associated piece of equipment; and for the associated piece of equipment to indicate its progress in performing its {{term(response)}} to the {{term(request)}} for service.  .

Many of the data items describing the services associated with an {{term(interface)}} are paired to describe two distinct actions – one to {{term(request)}} an action to be performed and a second to reverse the action or to return to an original state.  For example, a {{block(DoorInterface)}} will have two actions {{block(OpenDoor)}} and {{block(CloseDoor)}}. An example of an implementation of this would be a robot that indicates to a machine that it would like to have a door opened so that the robot could extract a part from the machine and then asks the machine to close that door once the part has been removed. 

When these data items are used to describe a service associated with an {{term(interface)}}, they **MUST** have one of the following two `subType` elements: `REQUEST` or `RESPONSE`.  These **MUST** be specified to define whether the piece of equipment is functioning as the {{term(requester)}} or {{term(responder)}} for the service to be performed.  The {{term(requester)}} **MUST** specify the `REQUEST` `subType` for the data item and the {{term(responder)}} **MUST** specify a corresponding `RESPONSE` `subType` for the data item to enable the coordination between the two pieces of equipment.   

These data items and their associated `subType` provide the basic structure for implementing the {{term(interaction model)}} for an {{term(interface)}} and are defined in the following sections.

{{figure(Request State Machine)}} and {{figure(Response State Machine)}} show possible state transitions for a {{term(request)}} and {{term(response)}} respectively. The state machine diagrams provide the permissible values of the {{termplural(observation)}} for the {{block(DataItem)}} types listed in this section.

![Request State Machine](figures/Request%20State%20Machine.png ""Request State Machine""){: width=""0.8""}

![Response State Machine](figures/Response%20State%20Machine.png ""Response State Machine""){: width=""0.8""}
&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MaterialFeedClass,
			MaterialChangeClass,
			MaterialChangeRequestClass,
			MaterialChangeResponseClass,
			MaterialFeedRequestClass,
			MaterialFeedResponseClass,
			MaterialRetractClass,
			MaterialRetractRequestClass,
			MaterialRetractResponseClass,
			MaterialLoadClass,
			MaterialLoadRequestClass,
			MaterialLoadResponseClass,
			MaterialUnloadClass,
			MaterialUnloadRequestClass,
			MaterialUnloadResponseClass,
			OpenChuckClass,
			OpenChuckRequestClass,
			OpenChuckResponseClass,
			OpenDoorClass,
			OpenDoorRequestClass,
			OpenDoorResponseClass,
			PartChangeClass,
			PartChangeRequestClass,
			PartChangeResponseClass,
			CloseDoorClass,
			CloseDoorRequestClass,
			CloseDoorResponseClass,
			CloseChuckClass,
			CloseChuckRequestClass,
			CloseChuckResponseClass,
			InterfaceStateClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.MaterialFeedClass _MaterialFeedClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialFeedClass" path="/summary" />
	/// </summary>
	public Package.MaterialFeedClass MaterialFeedClass => _MaterialFeedClass ?? (_MaterialFeedClass = new Package.MaterialFeedClass());

	private Package.MaterialChangeClass _MaterialChangeClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialChangeClass" path="/summary" />
	/// </summary>
	public Package.MaterialChangeClass MaterialChangeClass => _MaterialChangeClass ?? (_MaterialChangeClass = new Package.MaterialChangeClass());

	private Package.MaterialChangeRequestClass _MaterialChangeRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialChangeRequestClass" path="/summary" />
	/// </summary>
	public Package.MaterialChangeRequestClass MaterialChangeRequestClass => _MaterialChangeRequestClass ?? (_MaterialChangeRequestClass = new Package.MaterialChangeRequestClass());

	private Package.MaterialChangeResponseClass _MaterialChangeResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialChangeResponseClass" path="/summary" />
	/// </summary>
	public Package.MaterialChangeResponseClass MaterialChangeResponseClass => _MaterialChangeResponseClass ?? (_MaterialChangeResponseClass = new Package.MaterialChangeResponseClass());

	private Package.MaterialFeedRequestClass _MaterialFeedRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialFeedRequestClass" path="/summary" />
	/// </summary>
	public Package.MaterialFeedRequestClass MaterialFeedRequestClass => _MaterialFeedRequestClass ?? (_MaterialFeedRequestClass = new Package.MaterialFeedRequestClass());

	private Package.MaterialFeedResponseClass _MaterialFeedResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialFeedResponseClass" path="/summary" />
	/// </summary>
	public Package.MaterialFeedResponseClass MaterialFeedResponseClass => _MaterialFeedResponseClass ?? (_MaterialFeedResponseClass = new Package.MaterialFeedResponseClass());

	private Package.MaterialRetractClass _MaterialRetractClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialRetractClass" path="/summary" />
	/// </summary>
	public Package.MaterialRetractClass MaterialRetractClass => _MaterialRetractClass ?? (_MaterialRetractClass = new Package.MaterialRetractClass());

	private Package.MaterialRetractRequestClass _MaterialRetractRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialRetractRequestClass" path="/summary" />
	/// </summary>
	public Package.MaterialRetractRequestClass MaterialRetractRequestClass => _MaterialRetractRequestClass ?? (_MaterialRetractRequestClass = new Package.MaterialRetractRequestClass());

	private Package.MaterialRetractResponseClass _MaterialRetractResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialRetractResponseClass" path="/summary" />
	/// </summary>
	public Package.MaterialRetractResponseClass MaterialRetractResponseClass => _MaterialRetractResponseClass ?? (_MaterialRetractResponseClass = new Package.MaterialRetractResponseClass());

	private Package.MaterialLoadClass _MaterialLoadClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialLoadClass" path="/summary" />
	/// </summary>
	public Package.MaterialLoadClass MaterialLoadClass => _MaterialLoadClass ?? (_MaterialLoadClass = new Package.MaterialLoadClass());

	private Package.MaterialLoadRequestClass _MaterialLoadRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialLoadRequestClass" path="/summary" />
	/// </summary>
	public Package.MaterialLoadRequestClass MaterialLoadRequestClass => _MaterialLoadRequestClass ?? (_MaterialLoadRequestClass = new Package.MaterialLoadRequestClass());

	private Package.MaterialLoadResponseClass _MaterialLoadResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialLoadResponseClass" path="/summary" />
	/// </summary>
	public Package.MaterialLoadResponseClass MaterialLoadResponseClass => _MaterialLoadResponseClass ?? (_MaterialLoadResponseClass = new Package.MaterialLoadResponseClass());

	private Package.MaterialUnloadClass _MaterialUnloadClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialUnloadClass" path="/summary" />
	/// </summary>
	public Package.MaterialUnloadClass MaterialUnloadClass => _MaterialUnloadClass ?? (_MaterialUnloadClass = new Package.MaterialUnloadClass());

	private Package.MaterialUnloadRequestClass _MaterialUnloadRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialUnloadRequestClass" path="/summary" />
	/// </summary>
	public Package.MaterialUnloadRequestClass MaterialUnloadRequestClass => _MaterialUnloadRequestClass ?? (_MaterialUnloadRequestClass = new Package.MaterialUnloadRequestClass());

	private Package.MaterialUnloadResponseClass _MaterialUnloadResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialUnloadResponseClass" path="/summary" />
	/// </summary>
	public Package.MaterialUnloadResponseClass MaterialUnloadResponseClass => _MaterialUnloadResponseClass ?? (_MaterialUnloadResponseClass = new Package.MaterialUnloadResponseClass());

	private Package.OpenChuckClass _OpenChuckClass;
	/// <summary>
	/// <inheritdoc cref="Package.OpenChuckClass" path="/summary" />
	/// </summary>
	public Package.OpenChuckClass OpenChuckClass => _OpenChuckClass ?? (_OpenChuckClass = new Package.OpenChuckClass());

	private Package.OpenChuckRequestClass _OpenChuckRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.OpenChuckRequestClass" path="/summary" />
	/// </summary>
	public Package.OpenChuckRequestClass OpenChuckRequestClass => _OpenChuckRequestClass ?? (_OpenChuckRequestClass = new Package.OpenChuckRequestClass());

	private Package.OpenChuckResponseClass _OpenChuckResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.OpenChuckResponseClass" path="/summary" />
	/// </summary>
	public Package.OpenChuckResponseClass OpenChuckResponseClass => _OpenChuckResponseClass ?? (_OpenChuckResponseClass = new Package.OpenChuckResponseClass());

	private Package.OpenDoorClass _OpenDoorClass;
	/// <summary>
	/// <inheritdoc cref="Package.OpenDoorClass" path="/summary" />
	/// </summary>
	public Package.OpenDoorClass OpenDoorClass => _OpenDoorClass ?? (_OpenDoorClass = new Package.OpenDoorClass());

	private Package.OpenDoorRequestClass _OpenDoorRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.OpenDoorRequestClass" path="/summary" />
	/// </summary>
	public Package.OpenDoorRequestClass OpenDoorRequestClass => _OpenDoorRequestClass ?? (_OpenDoorRequestClass = new Package.OpenDoorRequestClass());

	private Package.OpenDoorResponseClass _OpenDoorResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.OpenDoorResponseClass" path="/summary" />
	/// </summary>
	public Package.OpenDoorResponseClass OpenDoorResponseClass => _OpenDoorResponseClass ?? (_OpenDoorResponseClass = new Package.OpenDoorResponseClass());

	private Package.PartChangeClass _PartChangeClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartChangeClass" path="/summary" />
	/// </summary>
	public Package.PartChangeClass PartChangeClass => _PartChangeClass ?? (_PartChangeClass = new Package.PartChangeClass());

	private Package.PartChangeRequestClass _PartChangeRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartChangeRequestClass" path="/summary" />
	/// </summary>
	public Package.PartChangeRequestClass PartChangeRequestClass => _PartChangeRequestClass ?? (_PartChangeRequestClass = new Package.PartChangeRequestClass());

	private Package.PartChangeResponseClass _PartChangeResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartChangeResponseClass" path="/summary" />
	/// </summary>
	public Package.PartChangeResponseClass PartChangeResponseClass => _PartChangeResponseClass ?? (_PartChangeResponseClass = new Package.PartChangeResponseClass());

	private Package.CloseDoorClass _CloseDoorClass;
	/// <summary>
	/// <inheritdoc cref="Package.CloseDoorClass" path="/summary" />
	/// </summary>
	public Package.CloseDoorClass CloseDoorClass => _CloseDoorClass ?? (_CloseDoorClass = new Package.CloseDoorClass());

	private Package.CloseDoorRequestClass _CloseDoorRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.CloseDoorRequestClass" path="/summary" />
	/// </summary>
	public Package.CloseDoorRequestClass CloseDoorRequestClass => _CloseDoorRequestClass ?? (_CloseDoorRequestClass = new Package.CloseDoorRequestClass());

	private Package.CloseDoorResponseClass _CloseDoorResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.CloseDoorResponseClass" path="/summary" />
	/// </summary>
	public Package.CloseDoorResponseClass CloseDoorResponseClass => _CloseDoorResponseClass ?? (_CloseDoorResponseClass = new Package.CloseDoorResponseClass());

	private Package.CloseChuckClass _CloseChuckClass;
	/// <summary>
	/// <inheritdoc cref="Package.CloseChuckClass" path="/summary" />
	/// </summary>
	public Package.CloseChuckClass CloseChuckClass => _CloseChuckClass ?? (_CloseChuckClass = new Package.CloseChuckClass());

	private Package.CloseChuckRequestClass _CloseChuckRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.CloseChuckRequestClass" path="/summary" />
	/// </summary>
	public Package.CloseChuckRequestClass CloseChuckRequestClass => _CloseChuckRequestClass ?? (_CloseChuckRequestClass = new Package.CloseChuckRequestClass());

	private Package.CloseChuckResponseClass _CloseChuckResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.CloseChuckResponseClass" path="/summary" />
	/// </summary>
	public Package.CloseChuckResponseClass CloseChuckResponseClass => _CloseChuckResponseClass ?? (_CloseChuckResponseClass = new Package.CloseChuckResponseClass());

	private Package.InterfaceStateClass _InterfaceStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.InterfaceStateClass" path="/summary" />
	/// </summary>
	public Package.InterfaceStateClass InterfaceStateClass => _InterfaceStateClass ?? (_InterfaceStateClass = new Package.InterfaceStateClass());

	#endregion
	}
}