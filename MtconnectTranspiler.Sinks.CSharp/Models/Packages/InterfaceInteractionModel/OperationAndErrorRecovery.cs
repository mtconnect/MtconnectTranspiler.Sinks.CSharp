#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.OperationAndErrorRecovery;

namespace Mtconnect.InterfaceInteractionModel
{
	/// <summary>﻿The <i>request and response</i> state model implemented for <i>interface</i>s may also be represented by a graphical model.  The scenario in {{figure(Success Scenario)}} demonstrates the state transitions that occur during a successful <i>request</i> for service and the resulting <i>response</i> to fulfill that service <i>request</i>. <br /><br />![Success Scenario](figures/Success%20Scenario.png "Success Scenario"){: width="0.8"}<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1623755007633_105506_1249">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class OperationAndErrorRecoveryPackage : IPackage
	{
		/// <summary>Constant value for <see cref="OperationAndErrorRecoveryPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623755007633_105506_1249";
		/// <summary>Constant value for <see cref="OperationAndErrorRecoveryPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1623755007633_105506_1249";
		/// <summary>Constant value for <see cref="OperationAndErrorRecoveryPackage.Name" /></summary>
		public const string NAME = "Operation and Error Recovery";
		/// <summary>Constant value for <see cref="OperationAndErrorRecoveryPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;The {{term(request and response)}} state model implemented for {{termplural(interface)}} may also be represented by a graphical model.  The scenario in {{figure(Success Scenario)}} demonstrates the state transitions that occur during a successful {{term(request)}} for service and the resulting {{term(response)}} to fulfill that service {{term(request)}}. 

![Success Scenario](figures/Success%20Scenario.png ""Success Scenario""){: width=""0.8""}&#10;
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
			RequestAndResponseFailureHandlingAndRecoveryPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.RequestAndResponseFailureHandlingAndRecoveryPackage _RequestAndResponseFailureHandlingAndRecoveryPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RequestAndResponseFailureHandlingAndRecoveryPackage" path="/summary" />
	/// </summary>
	public Package.RequestAndResponseFailureHandlingAndRecoveryPackage RequestAndResponseFailureHandlingAndRecoveryPackage => _RequestAndResponseFailureHandlingAndRecoveryPackage ?? (_RequestAndResponseFailureHandlingAndRecoveryPackage = new Package.RequestAndResponseFailureHandlingAndRecoveryPackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}