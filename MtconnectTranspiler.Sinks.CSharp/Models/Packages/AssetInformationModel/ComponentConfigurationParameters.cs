using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.ComponentConfigurationParameters;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>
	﻿/// This section provides semantic information for the <see cref="ComponentConfigurationParameters">ComponentConfigurationParameters</see> model.<br /><br />![ComponentConfigurationParameters](figures/ComponentConfigurationParameters.png "ComponentConfigurationParameters"){: width="0.8"}<br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1678197141009_35817_17749">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ComponentConfigurationParametersPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678197141009_35817_17749";
		
		/// <inheritdoc />
		public string Name => "Component Configuration Parameters";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(ComponentConfigurationParameters)}} model.

![ComponentConfigurationParameters](figures/ComponentConfigurationParameters.png ""ComponentConfigurationParameters""){: width=""0.8""}
&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ComponentConfigurationParametersClass,
			ParameterSetClass,
			ParameterClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.ComponentConfigurationParametersClass _ComponentConfigurationParametersClass;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentConfigurationParametersClass" path="/summary" />
	/// </summary>
	public Package.ComponentConfigurationParametersClass ComponentConfigurationParametersClass => _ComponentConfigurationParametersClass ?? (_ComponentConfigurationParametersClass = new Package.ComponentConfigurationParametersClass());

	private Package.ParameterSetClass _ParameterSetClass;
	/// <summary>
	/// <inheritdoc cref="Package.ParameterSetClass" path="/summary" />
	/// </summary>
	public Package.ParameterSetClass ParameterSetClass => _ParameterSetClass ?? (_ParameterSetClass = new Package.ParameterSetClass());

	private Package.ParameterClass _ParameterClass;
	/// <summary>
	/// <inheritdoc cref="Package.ParameterClass" path="/summary" />
	/// </summary>
	public Package.ParameterClass ParameterClass => _ParameterClass ?? (_ParameterClass = new Package.ParameterClass());

	#endregion
	}
}