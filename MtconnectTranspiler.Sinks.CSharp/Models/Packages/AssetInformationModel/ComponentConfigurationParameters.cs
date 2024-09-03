#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.ComponentConfigurationParameters;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="ComponentConfigurationParameters">ComponentConfigurationParameters</see> model.<br /><br />![ComponentConfigurationParameters](figures/ComponentConfigurationParameters.png "ComponentConfigurationParameters"){: width="0.8"}<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1678197141009_35817_17749">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ComponentConfigurationParametersPackage : IPackage
	{
		/// <summary>Constant value for <see cref="ComponentConfigurationParametersPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1678197141009_35817_17749";
		/// <summary>Constant value for <see cref="ComponentConfigurationParametersPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1678197141009_35817_17749";
		/// <summary>Constant value for <see cref="ComponentConfigurationParametersPackage.Name" /></summary>
		public const string NAME = "Component Configuration Parameters";
		/// <summary>Constant value for <see cref="ComponentConfigurationParametersPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(ComponentConfigurationParameters)}} model.

![ComponentConfigurationParameters](figures/ComponentConfigurationParameters.png ""ComponentConfigurationParameters""){: width=""0.8""}
&#10;
";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ComponentConfigurationParametersClass,
			ParameterSetClass,
			ParameterClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}