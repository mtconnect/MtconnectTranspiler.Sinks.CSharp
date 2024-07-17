using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.InterfaceTypes;
// using Mtconnect;

namespace Mtconnect.InterfaceInteractionModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class InterfaceTypesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			BarFeederInterfaceGeneralization,
			MaterialHandlerInterfaceGeneralization,
			DoorInterfaceGeneralization,
			ChuckInterfaceGeneralization,
		};

	private Package.BarFeederInterfaceGeneralization _BarFeederInterfaceGeneralization;
	public Package.BarFeederInterfaceGeneralization BarFeederInterfaceGeneralization => _BarFeederInterfaceGeneralization ?? (_BarFeederInterfaceGeneralization = new Package.BarFeederInterfaceGeneralization());
	private Package.MaterialHandlerInterfaceGeneralization _MaterialHandlerInterfaceGeneralization;
	public Package.MaterialHandlerInterfaceGeneralization MaterialHandlerInterfaceGeneralization => _MaterialHandlerInterfaceGeneralization ?? (_MaterialHandlerInterfaceGeneralization = new Package.MaterialHandlerInterfaceGeneralization());
	private Package.DoorInterfaceGeneralization _DoorInterfaceGeneralization;
	public Package.DoorInterfaceGeneralization DoorInterfaceGeneralization => _DoorInterfaceGeneralization ?? (_DoorInterfaceGeneralization = new Package.DoorInterfaceGeneralization());
	private Package.ChuckInterfaceGeneralization _ChuckInterfaceGeneralization;
	public Package.ChuckInterfaceGeneralization ChuckInterfaceGeneralization => _ChuckInterfaceGeneralization ?? (_ChuckInterfaceGeneralization = new Package.ChuckInterfaceGeneralization());
	}
}