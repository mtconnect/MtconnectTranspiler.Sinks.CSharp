using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.References;

namespace Mtconnect.DeviceInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="Reference">Reference</see> entity. {{figure(References)}} shows the <see cref="Reference">Reference</see> model.   <see cref="Reference">Reference</see> may be modeled as part of a <see cref="Device">Device</see>, <see cref="Component">Component</see> or <see cref="Interface">Interface</see> type.  ![References](figures/References.png "References"){: width="0.8"}  > Note: See <see cref="References Schema Diagrams">References Schema Diagrams</see> for XML schema of <see cref="Reference">Reference</see> and its types./// References Model
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_F54CCA63_E73C_468b_B64E_F97DEE70FFC6">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class ReferencesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_F54CCA63_E73C_468b_B64E_F97DEE70FFC6";
		
		/// <inheritdoc />
		public string Name => "References";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""Reference"">Reference</see> entity. {{figure(References)}} shows the <see cref=""Reference"">Reference</see> model.   <see cref=""Reference"">Reference</see> may be modeled as part of a <see cref=""Device"">Device</see>, <see cref=""Component"">Component</see> or <see cref=""Interface"">Interface</see> type.  ![References](figures/References.png ""References""){: width=""0.8""}  > Note: See <see cref=""References Schema Diagrams"">References Schema Diagrams</see> for XML schema of <see cref=""Reference"">Reference</see> and its types./// References Model";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ReferenceClass,
			DataItemRefClass,
			ComponentRefClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.ReferenceClass _ReferenceClass;
	/// <summary>
	/// <inheritdoc cref="Package.ReferenceClass" path="/summary" />
	/// </summary>
	public Package.ReferenceClass ReferenceClass => _ReferenceClass ?? (_ReferenceClass = new Package.ReferenceClass());

	private Package.DataItemRefClass _DataItemRefClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemRefClass" path="/summary" />
	/// </summary>
	public Package.DataItemRefClass DataItemRefClass => _DataItemRefClass ?? (_DataItemRefClass = new Package.DataItemRefClass());

	private Package.ComponentRefClass _ComponentRefClass;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentRefClass" path="/summary" />
	/// </summary>
	public Package.ComponentRefClass ComponentRefClass => _ComponentRefClass ?? (_ComponentRefClass = new Package.ComponentRefClass());

	#endregion
	}
}