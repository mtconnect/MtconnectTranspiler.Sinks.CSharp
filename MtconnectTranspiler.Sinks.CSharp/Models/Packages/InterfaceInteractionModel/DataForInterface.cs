#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel
{
	/// <summary>﻿Each <i>interface</i> <b>MUST</b> provide the data associated with the specific <i>interface</i> to implement the <i>interaction model</i> and any additional data that may be needed by another piece of equipment to understand the operating states and conditions of the first piece of equipment as it applies to the <i>interface</i>.<br /><br />Details on data items specific to the <i>interaction model</i> for each type of <i>interface</i> are provided in <see cref="DataItem Types for Interface">DataItem Types for Interface</see>.<br /><br />An implementer may choose any other data available from a piece of equipment to describe the operating states and other information needed to support an <i>interface</i>.<br /><br />### References for Interface<br /><br />Some of the data items needed to support a specific <i>interface</i> may already be defined elsewhere in the <i>MTConnectDevices Response Document</i> for a piece of equipment.  However, the implementer may not be able to directly associate this data with the <i>interface</i> since the MTConnect Standard does not permit multiple occurrences of a piece of data to be configured in an <i>MTConnectDevices Response Document</i>.  <see cref="References">References</see> provides a mechanism for associating information defined elsewhere in the <i>information model</i> for a piece of equipment with a specific <i>interface</i>.  <br /><br /><see cref="References">References</see> <i>organize</i>s <see cref="Reference">Reference</see> elements.<br /><br /><see cref="Reference">Reference</see> is a pointer to information that is associated with another entity defined elsewhere for a piece of equipment.<br /><br /><see cref="References">References</see> is an economical syntax for providing interface specific information without directly duplicating the occurrence of the data. It provides a mechanism to include all necessary information required for interaction and deterministic information flow between pieces of equipment.<br /><br />For more information on the <see cref="References">References</see> model, see <see cref="Device Information Model">Device Information Model</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1629374886900_914612_22">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class DataForInterfacePackage : IPackage
	{
		/// <summary>Constant value for <see cref="DataForInterfacePackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1629374886900_914612_22";
		/// <summary>Constant value for <see cref="DataForInterfacePackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1629374886900_914612_22";
		/// <summary>Constant value for <see cref="DataForInterfacePackage.Name" /></summary>
		public const string NAME = "Data for Interface";
		/// <summary>Constant value for <see cref="DataForInterfacePackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;Each {{term(interface)}} **MUST** provide the data associated with the specific {{term(interface)}} to implement the {{term(interaction model)}} and any additional data that may be needed by another piece of equipment to understand the operating states and conditions of the first piece of equipment as it applies to the {{term(interface)}}.

Details on data items specific to the {{term(interaction model)}} for each type of {{term(interface)}} are provided in {{package(DataItem Types for Interface)}}.

An implementer may choose any other data available from a piece of equipment to describe the operating states and other information needed to support an {{term(interface)}}.

### References for Interface

Some of the data items needed to support a specific {{term(interface)}} may already be defined elsewhere in the {{term(MTConnectDevices Response Document)}} for a piece of equipment.  However, the implementer may not be able to directly associate this data with the {{term(interface)}} since the MTConnect Standard does not permit multiple occurrences of a piece of data to be configured in an {{term(MTConnectDevices Response Document)}}.  {{block(References)}} provides a mechanism for associating information defined elsewhere in the {{term(information model)}} for a piece of equipment with a specific {{term(interface)}}.  

{{block(References)}} {{termplural(organize)}} {{block(Reference)}} elements.

{{block(Reference)}} is a pointer to information that is associated with another entity defined elsewhere for a piece of equipment.

{{block(References)}} is an economical syntax for providing interface specific information without directly duplicating the occurrence of the data. It provides a mechanism to include all necessary information required for interaction and deterministic information flow between pieces of equipment.

For more information on the {{block(References)}} model, see {{package(Device Information Model)}}.&#10;
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