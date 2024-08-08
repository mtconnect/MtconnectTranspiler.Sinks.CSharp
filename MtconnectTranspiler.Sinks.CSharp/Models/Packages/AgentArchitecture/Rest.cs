using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Rest;

namespace Mtconnect.AgentArchitecture
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class RestPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1585535305817_81941_1692";
		
		/// <inheritdoc />
		public string Name => "Rest";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			StoragePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.StoragePackage _StoragePackage;
	/// <summary>
	/// <inheritdoc cref="Package.StoragePackage" path="/summary" />
	/// </summary>
	public Package.StoragePackage StoragePackage => _StoragePackage ?? (_StoragePackage = new Package.StoragePackage());

	#endregion

	#region Classes
	#endregion
	}
}