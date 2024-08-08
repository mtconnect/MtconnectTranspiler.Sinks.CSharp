using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Components.Devices;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Components
{
	/// <summary>
	/// This section provides semantic information for the <see cref="Device">Device</see> types.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class DevicesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1588604708900_376505_13";
		
		/// <inheritdoc />
		public string Name => "Devices";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""Device"">Device</see> types.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			AgentClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.AgentClass _AgentClass;
	/// <summary>
	/// <inheritdoc cref="Package.AgentClass" path="/summary" />
	/// </summary>
	public Package.AgentClass AgentClass => _AgentClass ?? (_AgentClass = new Package.AgentClass());

	#endregion
	}
}