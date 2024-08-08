using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.ComponentConfigurationParameters;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="ComponentConfigurationParameters">ComponentConfigurationParameters</see> model.  ![ComponentConfigurationParameters](figures/ComponentConfigurationParameters.png "ComponentConfigurationParameters"){: width="0.8"} 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class ComponentConfigurationParametersPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678197141009_35817_17749";
		
		/// <inheritdoc />
		public string Name => "ComponentConfigurationParameters";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""ComponentConfigurationParameters"">ComponentConfigurationParameters</see> model.  ![ComponentConfigurationParameters](figures/ComponentConfigurationParameters.png ""ComponentConfigurationParameters""){: width=""0.8""} ";

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