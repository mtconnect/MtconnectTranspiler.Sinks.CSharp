
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.References;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ReferencesPackage {


	private Package.ReferenceClass _Reference;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ReferenceClass Reference => _Reference ?? (_Reference = new Package.ReferenceClass());

	private Package.DataItemRefClass _DataItemRef;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DataItemRefClass DataItemRef => _DataItemRef ?? (_DataItemRef = new Package.DataItemRefClass());

	private Package.ComponentRefClass _ComponentRef;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ComponentRefClass ComponentRef => _ComponentRef ?? (_ComponentRef = new Package.ComponentRefClass());
	}
}