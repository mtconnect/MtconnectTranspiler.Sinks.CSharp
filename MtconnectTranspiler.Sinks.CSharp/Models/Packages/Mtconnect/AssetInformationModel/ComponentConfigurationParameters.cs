
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AssetInformationModel.ComponentConfigurationParameters;

using Mtconnect;

namespace Mtconnect.AssetInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ComponentConfigurationParametersPackage {


	private Package.ComponentConfigurationParametersClass _ComponentConfigurationParameters;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ComponentConfigurationParametersClass ComponentConfigurationParameters => _ComponentConfigurationParameters ?? (_ComponentConfigurationParameters = new Package.ComponentConfigurationParametersClass());

	private Package.ParameterSetClass _ParameterSet;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ParameterSetClass ParameterSet => _ParameterSet ?? (_ParameterSet = new Package.ParameterSetClass());

	private Package.ParameterClass _Parameter;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ParameterClass Parameter => _Parameter ?? (_Parameter = new Package.ParameterClass());
	}
}