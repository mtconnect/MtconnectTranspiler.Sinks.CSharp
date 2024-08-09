using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Rest.Storage;

namespace Mtconnect.AgentArchitecture.Rest
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class StoragePackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1585535517110_128182_1817";
		
		/// <inheritdoc />
		public string Name => "Storage";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			CircularBuffferClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.CircularBuffferClass _CircularBuffferClass;
	/// <summary>
	/// <inheritdoc cref="Package.CircularBuffferClass" path="/summary" />
	/// </summary>
	public Package.CircularBuffferClass CircularBuffferClass => _CircularBuffferClass ?? (_CircularBuffferClass = new Package.CircularBuffferClass());

	#endregion
	}
}