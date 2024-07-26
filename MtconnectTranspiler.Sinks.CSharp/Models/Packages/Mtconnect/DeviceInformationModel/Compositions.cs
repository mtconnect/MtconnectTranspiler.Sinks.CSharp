
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Compositions;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CompositionsPackage {


	private Package.CompositionClass _Composition;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CompositionClass Composition => _Composition ?? (_Composition = new Package.CompositionClass());
	}
}