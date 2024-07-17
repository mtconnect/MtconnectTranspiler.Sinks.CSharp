using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.ComponentConfigurationParameters;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ComponentConfigurationParametersPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			ComponentConfigurationParametersClass,
			ParameterSetClass,
			ParameterClass,
		};

	private Package.ComponentConfigurationParametersClass _ComponentConfigurationParametersClass;
	public Package.ComponentConfigurationParametersClass ComponentConfigurationParametersClass => _ComponentConfigurationParametersClass ?? (_ComponentConfigurationParametersClass = new Package.ComponentConfigurationParametersClass());
	private Package.ParameterSetClass _ParameterSetClass;
	public Package.ParameterSetClass ParameterSetClass => _ParameterSetClass ?? (_ParameterSetClass = new Package.ParameterSetClass());
	private Package.ParameterClass _ParameterClass;
	public Package.ParameterClass ParameterClass => _ParameterClass ?? (_ParameterClass = new Package.ParameterClass());
	}
}