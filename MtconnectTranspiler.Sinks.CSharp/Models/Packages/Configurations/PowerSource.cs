#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.PowerSource;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>﻿This section provides semantic information for the <see cref="PowerSource">PowerSource</see> entity.<br /><br />![PowerSource](figures/PowerSource.png "PowerSource"){: width="0.8"}<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1696870885238_252064_3316">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class PowerSourcePackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1696870885238_252064_3316";
		
		/// <inheritdoc />
		public string Name => "PowerSource";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(PowerSource)}} entity.

![PowerSource](figures/PowerSource.png ""PowerSource""){: width=""0.8""}&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			PowerSourceClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.PowerSourceClass _PowerSourceClass;
	/// <summary>
	/// <inheritdoc cref="Package.PowerSourceClass" path="/summary" />
	/// </summary>
	public Package.PowerSourceClass PowerSourceClass => _PowerSourceClass ?? (_PowerSourceClass = new Package.PowerSourceClass());

	#endregion

	#region Enums
	#endregion
	}
}