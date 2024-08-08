using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel;
// using Mtconnect;

namespace Mtconnect
{
	/// <summary>
	/// In many manufacturing processes, multiple pieces of equipment must work together to perform a task.  The traditional method for coordinating the activities between individual pieces of equipment is to connect them using a series of wires to communicate equipment states and demands for action.  These interactions use simple binary ON/OFF signals to accomplished their intention.  In the MTConnect Standard, <i>interface</i>s provides a means to replace this traditional method for interconnecting pieces of equipment with a structured <i>interaction model</i> that provides a rich set of information used to coordinate the actions between pieces of equipment.  Implementers may utilize the information provided by this data model to (1) realize the interaction between pieces of equipment and (2) to extend the functionality of the equipment to improve the overall performance of the manufacturing process.   The <i>interaction model</i> used to implement <i>interface</i>s provides a lightweight and efficient protocol, simplifies failure recovery scenarios, and defines a structure for implementing a Plug-And-Play relationship between pieces of equipment.  By standardizing the information exchange using this higher-level semantic information model, an implementer may more readily replace a piece of equipment in a manufacturing system with any other piece of equipment capable of providing similar <i>interaction model</i> functions.  Two primary functions are required to implement the <i>interaction model</i> for an <i>interface</i>s and manage the flow of information between pieces of equipment.  Each piece of equipment needs to have the following:  * An <i>agent</i> which provides:       - The data required to implement the <i>interaction model</i>.       - Any other data from a piece of equipment needed to implement the <i>interface</i> – operating states of the equipment, position information, execution modes, process information, etc.    * A client software application that enables the piece of equipment to acquire and interpret information from another piece of equipment.    ## Interfaces Architecture  MTConnect Standard is based on a communications method that provides no direct way for one piece of equipment to change the state of or cause an action to occur in another piece of equipment.  The <i>interaction model</i> used to implement <i>interface</i>s is based on a <i>publish and subscribe</i> type of communications as described in <see cref="Fundamentals">Fundamentals</see> and utilizes a <i>request</i> and <i>response</i> information exchange mechanism.  For <i>interface</i>s, pieces of equipment must perform both the publish (<i>agent</i>) and subscribe (client) functions.     > Note: The current definition of <i>interface</i>s addresses the interaction between two pieces of equipment.  Future releases of the MTConnect Standard may address the interaction between multiple (more than two) pieces of equipment.  ![Data Flow Architecture for Interfaces](figures/Data%20Flow%20Architecture%20for%20Interfaces.png "Data Flow Architecture for Interfaces"){: width="0.8"}  > Note: The data flow architecture illustrated in {{figure(Data Flow Architecture for Interfaces)}} was historically referred to in the MTConnect Standard as a read-read concept.  In the implementation of the <i>interaction model</i> for <i>interface</i>s, two pieces of equipment can exchange information in the following manner.  One piece of equipment indicates a <i>request</i> for service by publishing a type of <i>request</i> using a data item provided through an <i>agent</i> as defined in <see cref="DataItem Types for Interface">DataItem Types for Interface</see>.  The client associated with the second piece of equipment, which is subscribing to data from the first machine, detects and interprets that <i>request</i>.  If the second machine chooses to take any action to fulfill this <i>request</i>, it can indicate its acceptance by publishing a <i>response</i> using a data item provided through its <i>agent</i>.  The client on the first piece of equipment continues to monitor information from the second piece of equipment until it detects an indication that the <i>response</i> to the <i>request</i> has been completed or has failed.  An example of this type of interaction between pieces of equipment can be represented by a machine tool that wants the material to be loaded by a robot.  In this example, the machine tool is the <i>requester</i>, and the robot is the <i>responder</i>.  On the other hand, if the robot wants the machine tool to open a door, the robot becomes the <i>requester</i> and the machine tool the <i>responder</i>.  ## Request and Response Information Exchange  The <see cref="DataItem">DataItem</see> elements defined by the <i>interaction model</i> each have a <c>REQUEST</c> and <c>RESPONSE</c> subtype.  These subtypes identify if the data item represents a <i>request</i> or a <i>response</i>.  Using these data items, a piece of equipment changes the state of its <i>request</i> or <i>response</i> to indicate information that can be read by the other piece of equipment.  To aid in understanding how the <i>interaction model</i> functions, one can view this <i>interaction model</i> as a simple state machine.   The interaction between two pieces of equipment can be described as follows.  When the <i>requester</i> wants an activity to be performed, it transitions its <i>request</i> state from a <c>READY</c> state to an <c>ACTIVE</c> state.  In turn, when the client on the <i>responder</i> reads this information and interprets the <i>request</i>, the <i>responder</i> announces that it is performing the requested task by changing its response state to <c>ACTIVE</c>.  When the action is finished, the <i>responder</i> changes its response state to <c>COMPLETE</c>.  This pattern of <i>request</i> and <i>response</i> provides the basis for the coordination of actions between pieces of equipment.  These actions are implemented using <c>EVENT</c> category data items.  (See <see cref="DataItem Types for Interface">DataItem Types for Interface</see> for details on the <see cref="Event">Event</see> type data items defined for <i>interface</i>s.)  > Note: The implementation details of how the <i>responder</i> piece of equipment reacts to the <i>request</i> and then completes the requested task are up to the implementer.  ![Request and Response Overview](figures/Request%20and%20Response%20Overview.png "Request and Response Overview"){: width="0.8"}  The initial condition of both the <i>request</i> and <i>response</i> states on both pieces of equipment is <c>READY</c>.  The dotted lines indicate the on-going communications that occur to monitor the progress of the interactions between the pieces of equipment.  The interaction between the pieces of equipment as illustrated in {{figure(Request and Response Overview)}} progresses through the sequence listed below.  * The <i>request</i> transitions from <c>READY</c> to <c>ACTIVE</c> signaling that a service is needed.  * The <i>response</i> detects the transition of the <i>request</i>.  * The <i>response</i> transitions from <c>READY</c> to <c>ACTIVE</c> indicating that it is performing the action.  * Once the action has been performed, the <i>response</i> transitions to <c>COMPLETE</c>.  * The <i>request</i> detects the action is <c>COMPLETE</c>.  * The <i>request</i> transitions back to <c>READY</c> acknowledging that the service has been performed.  * The <i>response</i> detects the <i>request</i> has returned to <c>READY</c>.  * In recognition of this acknowledgement, the <i>response</i> transitions back to <c>READY</c>.  After the final action has been completed, both pieces of equipment are back in the <c>READY</c> state indicating that they are able to perform another action.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class InterfaceInteractionModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_3DD65740_A905_4d89_9C80_C12E8199625A";
		
		/// <inheritdoc />
		public string Name => "InterfaceInteractionModel";

		/// <inheritdoc />
		public string Summary => @"/// In many manufacturing processes, multiple pieces of equipment must work together to perform a task.  The traditional method for coordinating the activities between individual pieces of equipment is to connect them using a series of wires to communicate equipment states and demands for action.  These interactions use simple binary ON/OFF signals to accomplished their intention.  In the MTConnect Standard, <i>interface</i>s provides a means to replace this traditional method for interconnecting pieces of equipment with a structured <i>interaction model</i> that provides a rich set of information used to coordinate the actions between pieces of equipment.  Implementers may utilize the information provided by this data model to (1) realize the interaction between pieces of equipment and (2) to extend the functionality of the equipment to improve the overall performance of the manufacturing process.   The <i>interaction model</i> used to implement <i>interface</i>s provides a lightweight and efficient protocol, simplifies failure recovery scenarios, and defines a structure for implementing a Plug-And-Play relationship between pieces of equipment.  By standardizing the information exchange using this higher-level semantic information model, an implementer may more readily replace a piece of equipment in a manufacturing system with any other piece of equipment capable of providing similar <i>interaction model</i> functions.  Two primary functions are required to implement the <i>interaction model</i> for an <i>interface</i>s and manage the flow of information between pieces of equipment.  Each piece of equipment needs to have the following:  * An <i>agent</i> which provides:       - The data required to implement the <i>interaction model</i>.       - Any other data from a piece of equipment needed to implement the <i>interface</i> – operating states of the equipment, position information, execution modes, process information, etc.    * A client software application that enables the piece of equipment to acquire and interpret information from another piece of equipment.    ## Interfaces Architecture  MTConnect Standard is based on a communications method that provides no direct way for one piece of equipment to change the state of or cause an action to occur in another piece of equipment.  The <i>interaction model</i> used to implement <i>interface</i>s is based on a <i>publish and subscribe</i> type of communications as described in <see cref=""Fundamentals"">Fundamentals</see> and utilizes a <i>request</i> and <i>response</i> information exchange mechanism.  For <i>interface</i>s, pieces of equipment must perform both the publish (<i>agent</i>) and subscribe (client) functions.     > Note: The current definition of <i>interface</i>s addresses the interaction between two pieces of equipment.  Future releases of the MTConnect Standard may address the interaction between multiple (more than two) pieces of equipment.  ![Data Flow Architecture for Interfaces](figures/Data%20Flow%20Architecture%20for%20Interfaces.png ""Data Flow Architecture for Interfaces""){: width=""0.8""}  > Note: The data flow architecture illustrated in {{figure(Data Flow Architecture for Interfaces)}} was historically referred to in the MTConnect Standard as a read-read concept.  In the implementation of the <i>interaction model</i> for <i>interface</i>s, two pieces of equipment can exchange information in the following manner.  One piece of equipment indicates a <i>request</i> for service by publishing a type of <i>request</i> using a data item provided through an <i>agent</i> as defined in <see cref=""DataItem Types for Interface"">DataItem Types for Interface</see>.  The client associated with the second piece of equipment, which is subscribing to data from the first machine, detects and interprets that <i>request</i>.  If the second machine chooses to take any action to fulfill this <i>request</i>, it can indicate its acceptance by publishing a <i>response</i> using a data item provided through its <i>agent</i>.  The client on the first piece of equipment continues to monitor information from the second piece of equipment until it detects an indication that the <i>response</i> to the <i>request</i> has been completed or has failed.  An example of this type of interaction between pieces of equipment can be represented by a machine tool that wants the material to be loaded by a robot.  In this example, the machine tool is the <i>requester</i>, and the robot is the <i>responder</i>.  On the other hand, if the robot wants the machine tool to open a door, the robot becomes the <i>requester</i> and the machine tool the <i>responder</i>.  ## Request and Response Information Exchange  The <see cref=""DataItem"">DataItem</see> elements defined by the <i>interaction model</i> each have a <c>REQUEST</c> and <c>RESPONSE</c> subtype.  These subtypes identify if the data item represents a <i>request</i> or a <i>response</i>.  Using these data items, a piece of equipment changes the state of its <i>request</i> or <i>response</i> to indicate information that can be read by the other piece of equipment.  To aid in understanding how the <i>interaction model</i> functions, one can view this <i>interaction model</i> as a simple state machine.   The interaction between two pieces of equipment can be described as follows.  When the <i>requester</i> wants an activity to be performed, it transitions its <i>request</i> state from a <c>READY</c> state to an <c>ACTIVE</c> state.  In turn, when the client on the <i>responder</i> reads this information and interprets the <i>request</i>, the <i>responder</i> announces that it is performing the requested task by changing its response state to <c>ACTIVE</c>.  When the action is finished, the <i>responder</i> changes its response state to <c>COMPLETE</c>.  This pattern of <i>request</i> and <i>response</i> provides the basis for the coordination of actions between pieces of equipment.  These actions are implemented using <c>EVENT</c> category data items.  (See <see cref=""DataItem Types for Interface"">DataItem Types for Interface</see> for details on the <see cref=""Event"">Event</see> type data items defined for <i>interface</i>s.)  > Note: The implementation details of how the <i>responder</i> piece of equipment reacts to the <i>request</i> and then completes the requested task are up to the implementer.  ![Request and Response Overview](figures/Request%20and%20Response%20Overview.png ""Request and Response Overview""){: width=""0.8""}  The initial condition of both the <i>request</i> and <i>response</i> states on both pieces of equipment is <c>READY</c>.  The dotted lines indicate the on-going communications that occur to monitor the progress of the interactions between the pieces of equipment.  The interaction between the pieces of equipment as illustrated in {{figure(Request and Response Overview)}} progresses through the sequence listed below.  * The <i>request</i> transitions from <c>READY</c> to <c>ACTIVE</c> signaling that a service is needed.  * The <i>response</i> detects the transition of the <i>request</i>.  * The <i>response</i> transitions from <c>READY</c> to <c>ACTIVE</c> indicating that it is performing the action.  * Once the action has been performed, the <i>response</i> transitions to <c>COMPLETE</c>.  * The <i>request</i> detects the action is <c>COMPLETE</c>.  * The <i>request</i> transitions back to <c>READY</c> acknowledging that the service has been performed.  * The <i>response</i> detects the <i>request</i> has returned to <c>READY</c>.  * In recognition of this acknowledgement, the <i>response</i> transitions back to <c>READY</c>.  After the final action has been completed, both pieces of equipment are back in the <c>READY</c> state indicating that they are able to perform another action.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			SignalsPackage,
			InterfaceTypesPackage,
			MultiDeviceInteractionModelPackage,
			OperationAndErrorRecoveryPackage,
			DataItemTypesForInterfacePackage,
			DataForInterfacePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			InterfaceClass,
			RequesterClass,
			ResponderClass,
		};
		#region Packages
	private Package.SignalsPackage _SignalsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.SignalsPackage" path="/summary" />
	/// </summary>
	public Package.SignalsPackage SignalsPackage => _SignalsPackage ?? (_SignalsPackage = new Package.SignalsPackage());

	private Package.InterfaceTypesPackage _InterfaceTypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.InterfaceTypesPackage" path="/summary" />
	/// </summary>
	public Package.InterfaceTypesPackage InterfaceTypesPackage => _InterfaceTypesPackage ?? (_InterfaceTypesPackage = new Package.InterfaceTypesPackage());

	private Package.MultiDeviceInteractionModelPackage _MultiDeviceInteractionModelPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MultiDeviceInteractionModelPackage" path="/summary" />
	/// </summary>
	public Package.MultiDeviceInteractionModelPackage MultiDeviceInteractionModelPackage => _MultiDeviceInteractionModelPackage ?? (_MultiDeviceInteractionModelPackage = new Package.MultiDeviceInteractionModelPackage());

	private Package.OperationAndErrorRecoveryPackage _OperationAndErrorRecoveryPackage;
	/// <summary>
	/// <inheritdoc cref="Package.OperationAndErrorRecoveryPackage" path="/summary" />
	/// </summary>
	public Package.OperationAndErrorRecoveryPackage OperationAndErrorRecoveryPackage => _OperationAndErrorRecoveryPackage ?? (_OperationAndErrorRecoveryPackage = new Package.OperationAndErrorRecoveryPackage());

	private Package.DataItemTypesForInterfacePackage _DataItemTypesForInterfacePackage;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemTypesForInterfacePackage" path="/summary" />
	/// </summary>
	public Package.DataItemTypesForInterfacePackage DataItemTypesForInterfacePackage => _DataItemTypesForInterfacePackage ?? (_DataItemTypesForInterfacePackage = new Package.DataItemTypesForInterfacePackage());

	private Package.DataForInterfacePackage _DataForInterfacePackage;
	/// <summary>
	/// <inheritdoc cref="Package.DataForInterfacePackage" path="/summary" />
	/// </summary>
	public Package.DataForInterfacePackage DataForInterfacePackage => _DataForInterfacePackage ?? (_DataForInterfacePackage = new Package.DataForInterfacePackage());

	#endregion

	#region Classes
	private Package.InterfaceClass _InterfaceClass;
	/// <summary>
	/// <inheritdoc cref="Package.InterfaceClass" path="/summary" />
	/// </summary>
	public Package.InterfaceClass InterfaceClass => _InterfaceClass ?? (_InterfaceClass = new Package.InterfaceClass());

	private Package.RequesterClass _RequesterClass;
	/// <summary>
	/// <inheritdoc cref="Package.RequesterClass" path="/summary" />
	/// </summary>
	public Package.RequesterClass RequesterClass => _RequesterClass ?? (_RequesterClass = new Package.RequesterClass());

	private Package.ResponderClass _ResponderClass;
	/// <summary>
	/// <inheritdoc cref="Package.ResponderClass" path="/summary" />
	/// </summary>
	public Package.ResponderClass ResponderClass => _ResponderClass ?? (_ResponderClass = new Package.ResponderClass());

	#endregion
	}
}