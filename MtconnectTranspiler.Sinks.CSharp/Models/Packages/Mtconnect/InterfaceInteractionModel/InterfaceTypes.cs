
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.InterfaceInteractionModel.InterfaceTypes;

using Mtconnect;

namespace Mtconnect.InterfaceInteractionModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class InterfaceTypesPackage {


	private Package.BarFeederInterfaceClass _BarFeederInterface;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.BarFeederInterfaceClass BarFeederInterface => _BarFeederInterface ?? (_BarFeederInterface = new Package.BarFeederInterfaceClass());

	private Package.MaterialHandlerInterfaceClass _MaterialHandlerInterface;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MaterialHandlerInterfaceClass MaterialHandlerInterface => _MaterialHandlerInterface ?? (_MaterialHandlerInterface = new Package.MaterialHandlerInterfaceClass());

	private Package.DoorInterfaceClass _DoorInterface;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DoorInterfaceClass DoorInterface => _DoorInterface ?? (_DoorInterface = new Package.DoorInterfaceClass());

	private Package.ChuckInterfaceClass _ChuckInterface;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ChuckInterfaceClass ChuckInterface => _ChuckInterface ?? (_ChuckInterface = new Package.ChuckInterfaceClass());
	}
}