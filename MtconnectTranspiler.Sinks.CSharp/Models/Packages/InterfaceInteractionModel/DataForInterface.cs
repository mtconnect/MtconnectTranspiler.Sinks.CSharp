using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel
{
	/// <summary>
	/// Each <i>interface</i> <b>MUST</b> provide the data associated with the specific <i>interface</i> to implement the <i>interaction model</i> and any additional data that may be needed by another piece of equipment to understand the operating states and conditions of the first piece of equipment as it applies to the <i>interface</i>.  Details on data items specific to the <i>interaction model</i> for each type of <i>interface</i> are provided in <see cref="DataItem Types for Interface">DataItem Types for Interface</see>.  An implementer may choose any other data available from a piece of equipment to describe the operating states and other information needed to support an <i>interface</i>.  ### References for Interface  Some of the data items needed to support a specific <i>interface</i> may already be defined elsewhere in the <i>MTConnectDevices Response Document</i> for a piece of equipment.  However, the implementer may not be able to directly associate this data with the <i>interface</i> since the MTConnect Standard does not permit multiple occurrences of a piece of data to be configured in an <i>MTConnectDevices Response Document</i>.  <see cref="References">References</see> provides a mechanism for associating information defined elsewhere in the <i>information model</i> for a piece of equipment with a specific <i>interface</i>.    <see cref="References">References</see> <i>organize</i>s <see cref="Reference">Reference</see> elements.  <see cref="Reference">Reference</see> is a pointer to information that is associated with another entity defined elsewhere for a piece of equipment.  <see cref="References">References</see> is an economical syntax for providing interface specific information without directly duplicating the occurrence of the data. It provides a mechanism to include all necessary information required for interaction and deterministic information flow between pieces of equipment.  For more information on the <see cref="References">References</see> model, see <see cref="Device Information Model">Device Information Model</see>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1629374886900_914612_22">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class DataForInterfacePackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1629374886900_914612_22";
		
		/// <inheritdoc />
		public string Name => "Data for Interface";

		/// <inheritdoc />
		public string Summary => @"/// Each <i>interface</i> <b>MUST</b> provide the data associated with the specific <i>interface</i> to implement the <i>interaction model</i> and any additional data that may be needed by another piece of equipment to understand the operating states and conditions of the first piece of equipment as it applies to the <i>interface</i>.  Details on data items specific to the <i>interaction model</i> for each type of <i>interface</i> are provided in <see cref=""DataItem Types for Interface"">DataItem Types for Interface</see>.  An implementer may choose any other data available from a piece of equipment to describe the operating states and other information needed to support an <i>interface</i>.  ### References for Interface  Some of the data items needed to support a specific <i>interface</i> may already be defined elsewhere in the <i>MTConnectDevices Response Document</i> for a piece of equipment.  However, the implementer may not be able to directly associate this data with the <i>interface</i> since the MTConnect Standard does not permit multiple occurrences of a piece of data to be configured in an <i>MTConnectDevices Response Document</i>.  <see cref=""References"">References</see> provides a mechanism for associating information defined elsewhere in the <i>information model</i> for a piece of equipment with a specific <i>interface</i>.    <see cref=""References"">References</see> <i>organize</i>s <see cref=""Reference"">Reference</see> elements.  <see cref=""Reference"">Reference</see> is a pointer to information that is associated with another entity defined elsewhere for a piece of equipment.  <see cref=""References"">References</see> is an economical syntax for providing interface specific information without directly duplicating the occurrence of the data. It provides a mechanism to include all necessary information required for interaction and deterministic information flow between pieces of equipment.  For more information on the <see cref=""References"">References</see> model, see <see cref=""Device Information Model"">Device Information Model</see>.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	#endregion

	#region Classes
	#endregion
	}
}