#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.OperationAndErrorRecovery
{
	/// <summary>﻿A significant feature of the <i>request and response</i> <i>interaction model</i> is the ability for either piece of equipment to detect a failure associated with either the <i>request</i> or <i>response</i> actions.  When either a failure or unexpected action occurs, the <i>request</i> and the <i>response</i> portion of the <i>interaction model</i> can announce a <c>FAIL</c> state upon detecting a problem.  The following are graphical models describing multiple scenarios where either the <i>requester</i> or <i>responder</i> detects and reacts to a failure.  In these examples, either the <i>requester</i> or <i>responder</i> announces the detection of a failure by setting either the <i>request</i> or the <i>response</i> state to <c>FAIL</c>.  <br /><br />Once a failure is detected, the <i>interaction model</i> provides information from each piece of equipment as they attempt to recover from a failure, reset all of their functions associated with the <i>interface</i> to their original state, and return to normal operation.<br /><br />The following sections are scenarios that describe how pieces of equipment may react to different types of failures and how they indicate when they are again ready to request a service or respond to a request for service after recovering from those failures:<br /><br />### Responder Fails Immediately<br /><br />In this scenario, a failure is detected by the <i>responder</i> immediately after a <i>request</i> for service has been initiated by the <i>requester</i>.<br /><br />![Responder Fails Immediately](figures/Responder%20Fails%20Immediately.png "Responder Fails Immediately"){: width="0.8"}<br /><br />In this case, the <i>request</i> transitions to <c>ACTIVE</c> and the <i>responder</i> immediately detects a failure before it can transition the <i>response</i> state to <c>ACTIVE</c>.  When this occurs, the <i>responder</i> transitions the <i>response</i> state to <c>FAIL</c>.<br /><br />After detecting that the <i>responder</i> has transitioned its state to <c>FAIL</c>, the <i>requester</i> <b>MUST</b> change its state to <c>FAIL</c>.<br /><br />The <i>requester</i>, as part of clearing a failure, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to request a service.  If the recovery is successful, the <i>requester</i> changes its state from <c>FAIL</c> to <c>READY</c>.  If for some reason the <i>requester</i> cannot return to a condition where it is again ready to request a service, it transitions its state from <c>FAIL</c> to <c>NOT_READY</c>.<br /><br />The <i>responder</i>, as part of clearing a failure, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to perform a service.  If the recovery is successful, the <i>responder</i> changes its <i>response</i> state from <c>FAIL</c> to <c>READY</c>.  If for some reason the <i>responder</i> is not again prepared to perform a service, it transitions its state from <c>FAIL</c> to <c>NOT_READY</c>.<br /><br />### Responder Fails While Providing a Service<br /><br />This is the most common failure scenario.  In this case, the <i>responder</i> will begin the actions required to provide a service.  During these actions, the <i>responder</i> detects a failure and transitions its <i>response</i> state to <c>FAIL</c>.<br /><br />![Responder Fails While Providing a Service](figures/Responder%20Fails%20While%20Providing%20a%20Service.png "Responder Fails While Providing a Service"){: width="0.8"}<br /><br />When a <i>requester</i> detects a failure of a <i>responder</i>, it transitions it state from <c>ACTIVE</c> to <c>FAIL</c>.  <br /><br />The <i>requester</i> resets any partial actions that were initiated and attempts to return to a condition where it is again ready to request a service.  If the recovery is successful, the <i>requester</i> changes its state from <c>FAIL</c> to <c>READY</c> if the failure has been cleared and it is again prepared to request another service.  If for some reason the <i>requester</i> cannot return to a condition where it is again ready to request a service, it transitions its state from <c>FAIL</c> to <c>NOT_READY</c>.<br /><br />The <i>responder</i>, as part of clearing a failure, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to perform a service.  If the recovery is successful, the <i>responder</i> changes its <i>response</i> state from <c>FAIL</c> to <c>READY</c> if it is again prepared to perform a service.  If for some reason the <i>responder</i> is not again prepared to perform a service, it transitions its state from <c>FAIL</c> to <c>NOT_READY</c>.<br /><br />### Requester Failure During a Service Request<br /><br />In this scenario, the <i>responder</i> will begin the actions required to provide a service.  During these actions, the <i>requester</i> detects a failure and transitions its <i>request</i> state to <c>FAIL</c>.<br /><br />![Requester Fails During a Service Request](figures/Requester%20Fails%20During%20a%20Service%20Request.png "Requester Fails During a Service Request"){: width="0.8"}<br /><br />When the <i>responder</i> detects that the <i>requester</i> has transitioned its <i>request</i> state to <c>FAIL</c>, the <i>responder</i> also transitions its <i>response</i> state to <c>FAIL</c>. <br /><br />The <i>requester</i>, as part of clearing a failure, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to request a service.  If the recovery is successful, the <i>requester</i> changes its state from <c>FAIL</c> to <c>READY</c>.  If for some reason the <i>requester</i> cannot return to a condition where it is again ready to request a service, it transitions its state from <c>FAIL</c> to <c>NOT_READY</c>.<br /><br />The <i>responder</i>, as part of clearing a failure, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to perform a service.  If the recovery is successful, the <i>responder</i> changes its <i>response</i> state from <c>FAIL</c> to <c>READY</c>.  If for some reason the <i>responder</i> is not again prepared to perform a service, it transitions its state from <c>FAIL</c> to <c>NOT_READY</c>.<br /><br />### Requester Changes to an Unexpected State While Responder is Providing a Service<br /><br />In some cases, a <i>requester</i> may transition to an unexpected state after it has initiated a <i>request</i> for service.  <br /><br />As demonstrated in {{figure(Requester Makes Unexpected State Change)}}, the <i>requester</i> has initiated a <i>request</i> for service and its <i>request</i> state has been changed to <c>ACTIVE</c>.  The <i>responder</i> begins the actions required to provide the service.  During these actions, the <i>requester</i> transitions its <i>request</i> state back to <c>READY</c> before the <i>responder</i> can complete its actions.  This <b>SHOULD</b> be regarded as a failure of the <i>requester</i>.<br /><br />![Requester Makes Unexpected State Change](figures/Requester%20Makes%20Unexpected%20State%20Change.png "Requester Makes Unexpected State Change"){: width="0.8"}<br /><br />In this case, the <i>responder</i> reacts to this change of state of the <i>requester</i> in the same way as though the <i>requester</i> had transitioned its <i>request</i> state to <c>FAIL</c> (i.e., the same as in Scenario 3 above).<br /><br />At this point, the <i>responder</i> then transitions its <i>response</i> state to <c>FAIL</c>.<br /><br />The <i>responder</i> resets any partial actions that were initiated and attempts to return to its original condition where it is again ready to perform a service.  If the recovery is successful, the <i>responder</i> changes its <i>response</i> state from <c>FAIL</c> to <c>READY</c>.  If for some reason the <i>responder</i> is not again prepared to perform a service, it transitions its state from <c>FAIL</c> to <c>NOT_READY</c>.<br /><br />&gt; Note: The same scenario exists if the <i>requester</i> transitions its <i>request</i> state to <c>NOT_READY</c>.  However, in this case, the <i>requester</i> then transitions its <i>request</i> state to <c>READY</c> after it resets all of its functions back to a condition where it is again prepared to make a <i>request</i> for service.<br /><br /><br />### Responder Changes to an Unexpected State While Providing a Service<br /><br />Similar to Scenario 5, a <i>responder</i> may transition to an unexpected state while providing a service.  <br /><br />As demonstrated in {{figure(Responder Makes Unexpected State Change)}}, the <i>responder</i> is performing the actions to provide a service and the <i>response</i> state is <c>ACTIVE</c>.  During these actions, the <i>responder</i> transitions its state to <c>NOT_READY</c> before completing its actions.  This should be regarded as a failure of the <i>responder</i>.<br /><br />![Responder Makes Unexpected State Change](figures/Responder%20Makes%20Unexpected%20State%20Change.png "Responder Makes Unexpected State Change"){: width="0.8"}<br /><br />Upon detecting an unexpected state change of the <i>responder</i>, the <i>requester</i> transitions its state to <c>FAIL</c>.  <br /><br />The <i>requester</i> resets any partial actions that were initiated and attempts to return to a condition where it is again ready to request a service.  If the recovery is successful, the <i>requester</i> changes its state from <c>FAIL</c> to <c>READY</c>.  If for some reason the <i>requester</i> cannot return to a condition where it is again ready to request a service, it transitions its state from <c>FAIL</c> to <c>NOT_READY</c>.<br /><br />Since the <i>responder</i> has failed to an invalid state, the condition of the <i>responder</i> is unknown.  Where possible, the <i>responder</i> should try to reset to an initial state. <br /><br />The <i>responder</i>, as part of clearing the cause for the change to the unexpected state, should attempt to reset any partial actions that were initiated and then return to a condition where it is again ready to perform a service.  If the recovery is successful, the <i>responder</i> changes its <i>response</i> state from the unexpected state to <c>READY</c>.  If for some reason the <i>responder</i> is not again prepared to perform a service, it maintains its state as <c>NOT_READY</c>. <br /><br />### Responder or Requester Become UNAVAILABLE or Experience a Loss of Communication<br /><br />In this scenario, a failure occurs in the communications connection between the <i>responder</i> and <i>requester</i>.  This failure may result from the <see cref="InterfaceState">InterfaceState</see> from either piece of equipment returning a value of <c>UNAVAILABLE</c> or one of the pieces of equipment does not provide a heartbeat within the desired amount of time (See <see cref="Fundamentals">Fundamentals</see> for details on heartbeat).   <br /><br />![Requester - Responder Communication Failure 1](figures/Requester%20-%20Responder%20Communication%20Failure%201.png "Requester - Responder Communication Failure 1"){: width="0.8"}<br /><br />![Requester - Responder Communication Failure 2](figures/Requester%20-%20Responder%20Communication%20Failure%202.png "Requester - Responder Communication Failure 2"){: width="0.8"}<br /><br />When one of these situations occurs, each piece of equipment assumes that there has been a failure of the other piece of equipment.<br /><br />When normal communications are re-established, neither piece of equipment should assume that the <i>request and response</i> state of the other piece of equipment remains valid.  Both pieces of equipment should set their state to <c>FAIL</c>.<br /><br />The <i>requester</i>, as part of clearing its <c>FAIL</c> state, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to request a service.  If the recovery is successful, the <i>requester</i> changes its state from <c>FAIL</c> to <c>READY</c>.  If for some reason the <i>requester</i> cannot return to a condition where it is again ready to request a service, it transitions its state from <c>FAIL</c> to <c>NOT_READY</c>.<br /><br />The <i>responder</i>, as part of clearing its <c>FAIL</c> state, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to perform a service.  If the recovery is successful, the <i>responder</i> changes its <i>response</i> state from <c>FAIL</c> to <c>READY</c>.  If for some reason the <i>responder</i> is not again prepared to perform a service, it transitions its state from <c>FAIL</c> to <c>NOT_READY</c>.<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1623839073431_500021_2262">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class RequestAndResponseFailureHandlingAndRecoveryPackage : IPackage
	{
		/// <summary>Constant value for <see cref="RequestAndResponseFailureHandlingAndRecoveryPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623839073431_500021_2262";
		/// <summary>Constant value for <see cref="RequestAndResponseFailureHandlingAndRecoveryPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1623839073431_500021_2262";
		/// <summary>Constant value for <see cref="RequestAndResponseFailureHandlingAndRecoveryPackage.Name" /></summary>
		public const string NAME = "Request and Response Failure Handling and Recovery";
		/// <summary>Constant value for <see cref="RequestAndResponseFailureHandlingAndRecoveryPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;A significant feature of the {{term(request and response)}} {{term(interaction model)}} is the ability for either piece of equipment to detect a failure associated with either the {{term(request)}} or {{term(response)}} actions.  When either a failure or unexpected action occurs, the {{term(request)}} and the {{term(response)}} portion of the {{term(interaction model)}} can announce a `FAIL` state upon detecting a problem.  The following are graphical models describing multiple scenarios where either the {{term(requester)}} or {{term(responder)}} detects and reacts to a failure.  In these examples, either the {{term(requester)}} or {{term(responder)}} announces the detection of a failure by setting either the {{term(request)}} or the {{term(response)}} state to `FAIL`.  

Once a failure is detected, the {{term(interaction model)}} provides information from each piece of equipment as they attempt to recover from a failure, reset all of their functions associated with the {{term(interface)}} to their original state, and return to normal operation.

The following sections are scenarios that describe how pieces of equipment may react to different types of failures and how they indicate when they are again ready to request a service or respond to a request for service after recovering from those failures:

### Responder Fails Immediately

In this scenario, a failure is detected by the {{term(responder)}} immediately after a {{term(request)}} for service has been initiated by the {{term(requester)}}.

![Responder Fails Immediately](figures/Responder%20Fails%20Immediately.png ""Responder Fails Immediately""){: width=""0.8""}

In this case, the {{term(request)}} transitions to `ACTIVE` and the {{term(responder)}} immediately detects a failure before it can transition the {{term(response)}} state to `ACTIVE`.  When this occurs, the {{term(responder)}} transitions the {{term(response)}} state to `FAIL`.

After detecting that the {{term(responder)}} has transitioned its state to `FAIL`, the {{term(requester)}} **MUST** change its state to `FAIL`.

The {{term(requester)}}, as part of clearing a failure, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to request a service.  If the recovery is successful, the {{term(requester)}} changes its state from `FAIL` to `READY`.  If for some reason the {{term(requester)}} cannot return to a condition where it is again ready to request a service, it transitions its state from `FAIL` to `NOT_READY`.

The {{term(responder)}}, as part of clearing a failure, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to perform a service.  If the recovery is successful, the {{term(responder)}} changes its {{term(response)}} state from `FAIL` to `READY`.  If for some reason the {{term(responder)}} is not again prepared to perform a service, it transitions its state from `FAIL` to `NOT_READY`.

### Responder Fails While Providing a Service

This is the most common failure scenario.  In this case, the {{term(responder)}} will begin the actions required to provide a service.  During these actions, the {{term(responder)}} detects a failure and transitions its {{term(response)}} state to `FAIL`.

![Responder Fails While Providing a Service](figures/Responder%20Fails%20While%20Providing%20a%20Service.png ""Responder Fails While Providing a Service""){: width=""0.8""}

When a {{term(requester)}} detects a failure of a {{term(responder)}}, it transitions it state from `ACTIVE` to `FAIL`.  

The {{term(requester)}} resets any partial actions that were initiated and attempts to return to a condition where it is again ready to request a service.  If the recovery is successful, the {{term(requester)}} changes its state from `FAIL` to `READY` if the failure has been cleared and it is again prepared to request another service.  If for some reason the {{term(requester)}} cannot return to a condition where it is again ready to request a service, it transitions its state from `FAIL` to `NOT_READY`.

The {{term(responder)}}, as part of clearing a failure, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to perform a service.  If the recovery is successful, the {{term(responder)}} changes its {{term(response)}} state from `FAIL` to `READY` if it is again prepared to perform a service.  If for some reason the {{term(responder)}} is not again prepared to perform a service, it transitions its state from `FAIL` to `NOT_READY`.

### Requester Failure During a Service Request

In this scenario, the {{term(responder)}} will begin the actions required to provide a service.  During these actions, the {{term(requester)}} detects a failure and transitions its {{term(request)}} state to `FAIL`.

![Requester Fails During a Service Request](figures/Requester%20Fails%20During%20a%20Service%20Request.png ""Requester Fails During a Service Request""){: width=""0.8""}

When the {{term(responder)}} detects that the {{term(requester)}} has transitioned its {{term(request)}} state to `FAIL`, the {{term(responder)}} also transitions its {{term(response)}} state to `FAIL`. 

The {{term(requester)}}, as part of clearing a failure, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to request a service.  If the recovery is successful, the {{term(requester)}} changes its state from `FAIL` to `READY`.  If for some reason the {{term(requester)}} cannot return to a condition where it is again ready to request a service, it transitions its state from `FAIL` to `NOT_READY`.

The {{term(responder)}}, as part of clearing a failure, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to perform a service.  If the recovery is successful, the {{term(responder)}} changes its {{term(response)}} state from `FAIL` to `READY`.  If for some reason the {{term(responder)}} is not again prepared to perform a service, it transitions its state from `FAIL` to `NOT_READY`.

### Requester Changes to an Unexpected State While Responder is Providing a Service

In some cases, a {{term(requester)}} may transition to an unexpected state after it has initiated a {{term(request)}} for service.  

As demonstrated in {{figure(Requester Makes Unexpected State Change)}}, the {{term(requester)}} has initiated a {{term(request)}} for service and its {{term(request)}} state has been changed to `ACTIVE`.  The {{term(responder)}} begins the actions required to provide the service.  During these actions, the {{term(requester)}} transitions its {{term(request)}} state back to `READY` before the {{term(responder)}} can complete its actions.  This **SHOULD** be regarded as a failure of the {{term(requester)}}.

![Requester Makes Unexpected State Change](figures/Requester%20Makes%20Unexpected%20State%20Change.png ""Requester Makes Unexpected State Change""){: width=""0.8""}

In this case, the {{term(responder)}} reacts to this change of state of the {{term(requester)}} in the same way as though the {{term(requester)}} had transitioned its {{term(request)}} state to `FAIL` (i.e., the same as in Scenario 3 above).

At this point, the {{term(responder)}} then transitions its {{term(response)}} state to `FAIL`.

The {{term(responder)}} resets any partial actions that were initiated and attempts to return to its original condition where it is again ready to perform a service.  If the recovery is successful, the {{term(responder)}} changes its {{term(response)}} state from `FAIL` to `READY`.  If for some reason the {{term(responder)}} is not again prepared to perform a service, it transitions its state from `FAIL` to `NOT_READY`.

> Note: The same scenario exists if the {{term(requester)}} transitions its {{term(request)}} state to `NOT_READY`.  However, in this case, the {{term(requester)}} then transitions its {{term(request)}} state to `READY` after it resets all of its functions back to a condition where it is again prepared to make a {{term(request)}} for service.


### Responder Changes to an Unexpected State While Providing a Service

Similar to Scenario 5, a {{term(responder)}} may transition to an unexpected state while providing a service.  

As demonstrated in {{figure(Responder Makes Unexpected State Change)}}, the {{term(responder)}} is performing the actions to provide a service and the {{term(response)}} state is `ACTIVE`.  During these actions, the {{term(responder)}} transitions its state to `NOT_READY` before completing its actions.  This should be regarded as a failure of the {{term(responder)}}.

![Responder Makes Unexpected State Change](figures/Responder%20Makes%20Unexpected%20State%20Change.png ""Responder Makes Unexpected State Change""){: width=""0.8""}

Upon detecting an unexpected state change of the {{term(responder)}}, the {{term(requester)}} transitions its state to `FAIL`.  

The {{term(requester)}} resets any partial actions that were initiated and attempts to return to a condition where it is again ready to request a service.  If the recovery is successful, the {{term(requester)}} changes its state from `FAIL` to `READY`.  If for some reason the {{term(requester)}} cannot return to a condition where it is again ready to request a service, it transitions its state from `FAIL` to `NOT_READY`.

Since the {{term(responder)}} has failed to an invalid state, the condition of the {{term(responder)}} is unknown.  Where possible, the {{term(responder)}} should try to reset to an initial state. 

The {{term(responder)}}, as part of clearing the cause for the change to the unexpected state, should attempt to reset any partial actions that were initiated and then return to a condition where it is again ready to perform a service.  If the recovery is successful, the {{term(responder)}} changes its {{term(response)}} state from the unexpected state to `READY`.  If for some reason the {{term(responder)}} is not again prepared to perform a service, it maintains its state as `NOT_READY`. 

### Responder or Requester Become UNAVAILABLE or Experience a Loss of Communication

In this scenario, a failure occurs in the communications connection between the {{term(responder)}} and {{term(requester)}}.  This failure may result from the {{block(InterfaceState)}} from either piece of equipment returning a value of `UNAVAILABLE` or one of the pieces of equipment does not provide a heartbeat within the desired amount of time (See {{package(Fundamentals)}} for details on heartbeat).   

![Requester - Responder Communication Failure 1](figures/Requester%20-%20Responder%20Communication%20Failure%201.png ""Requester - Responder Communication Failure 1""){: width=""0.8""}

![Requester - Responder Communication Failure 2](figures/Requester%20-%20Responder%20Communication%20Failure%202.png ""Requester - Responder Communication Failure 2""){: width=""0.8""}

When one of these situations occurs, each piece of equipment assumes that there has been a failure of the other piece of equipment.

When normal communications are re-established, neither piece of equipment should assume that the {{term(request and response)}} state of the other piece of equipment remains valid.  Both pieces of equipment should set their state to `FAIL`.

The {{term(requester)}}, as part of clearing its `FAIL` state, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to request a service.  If the recovery is successful, the {{term(requester)}} changes its state from `FAIL` to `READY`.  If for some reason the {{term(requester)}} cannot return to a condition where it is again ready to request a service, it transitions its state from `FAIL` to `NOT_READY`.

The {{term(responder)}}, as part of clearing its `FAIL` state, resets any partial actions that were initiated and attempts to return to a condition where it is again ready to perform a service.  If the recovery is successful, the {{term(responder)}} changes its {{term(response)}} state from `FAIL` to `READY`.  If for some reason the {{term(responder)}} is not again prepared to perform a service, it transitions its state from `FAIL` to `NOT_READY`.
&#10;
";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}