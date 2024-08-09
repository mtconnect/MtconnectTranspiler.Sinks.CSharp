using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.InterfaceTypes;

namespace Mtconnect.InterfaceInteractionModel
{
	/// <summary>
	/// The abstract <see cref="Interface">Interface</see> is realized by the following types listed in this section.   In order to implement the <i>interaction model</i> for <i>interface</i>s, each piece of equipment associated with an <i>interface</i> <b>MUST</b> provide the corresponding <see cref="Interface">Interface</see> type. A piece of equipment <b>MAY</b> support any number of unique <i>interface</i>s./// Interfaces for Device and Observation Information Models
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1622717338882_321462_855">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class InterfaceTypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622717338882_321462_855";
		
		/// <inheritdoc />
		public string Name => "Interface Types";

		/// <inheritdoc />
		public string Summary => @"/// The abstract <see cref=""Interface"">Interface</see> is realized by the following types listed in this section.   In order to implement the <i>interaction model</i> for <i>interface</i>s, each piece of equipment associated with an <i>interface</i> <b>MUST</b> provide the corresponding <see cref=""Interface"">Interface</see> type. A piece of equipment <b>MAY</b> support any number of unique <i>interface</i>s./// Interfaces for Device and Observation Information Models";

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