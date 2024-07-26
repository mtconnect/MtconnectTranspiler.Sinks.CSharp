
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Components;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ComponentsPackage {

	private Package.ComponentTypesPackage _ComponentTypesPackage;
	public Package.ComponentTypesPackage ComponentTypesPackage => _ComponentTypesPackage ?? (_ComponentTypesPackage = new Package.ComponentTypesPackage());

	private Package.DevicesPackage _DevicesPackage;
	public Package.DevicesPackage DevicesPackage => _DevicesPackage ?? (_DevicesPackage = new Package.DevicesPackage());


	private Package.ComponentClass _Component;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ComponentClass Component => _Component ?? (_Component = new Package.ComponentClass());

	private Package.DescriptionClass _Description;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DescriptionClass Description => _Description ?? (_Description = new Package.DescriptionClass());
	}
}