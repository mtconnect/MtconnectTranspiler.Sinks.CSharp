using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Source;

namespace Mtconnect.AgentArchitecture
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class SourcePackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1585535650368_627874_1904";
		
		/// <inheritdoc />
		public string Name => "Source";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MQTTDataSourceGeneralization,
			AdapterDataSourceGeneralization,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.MQTTDataSourceGeneralization _MQTTDataSourceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.MQTTDataSourceGeneralization" path="/summary" />
	/// </summary>
	public Package.MQTTDataSourceGeneralization MQTTDataSourceGeneralization => _MQTTDataSourceGeneralization ?? (_MQTTDataSourceGeneralization = new Package.MQTTDataSourceGeneralization());

	private Package.AdapterDataSourceGeneralization _AdapterDataSourceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.AdapterDataSourceGeneralization" path="/summary" />
	/// </summary>
	public Package.AdapterDataSourceGeneralization AdapterDataSourceGeneralization => _AdapterDataSourceGeneralization ?? (_AdapterDataSourceGeneralization = new Package.AdapterDataSourceGeneralization());

	#endregion
	}
}