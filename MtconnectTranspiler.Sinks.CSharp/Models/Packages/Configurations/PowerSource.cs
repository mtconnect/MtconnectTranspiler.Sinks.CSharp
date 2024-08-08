using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.PowerSource;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>
	/// This section provides semantic information for the <see cref="PowerSource">PowerSource</see> entity.  ![PowerSource](figures/PowerSource.png "PowerSource"){: width="0.8"}
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class PowerSourcePackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1696870885238_252064_3316";
		
		/// <inheritdoc />
		public string Name => "PowerSource";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""PowerSource"">PowerSource</see> entity.  ![PowerSource](figures/PowerSource.png ""PowerSource""){: width=""0.8""}";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			PowerSourceClass,
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
	}
}