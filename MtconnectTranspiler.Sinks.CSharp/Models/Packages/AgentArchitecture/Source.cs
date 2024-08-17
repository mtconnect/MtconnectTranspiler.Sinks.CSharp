#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Source;

namespace Mtconnect.AgentArchitecture
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1585535650368_627874_1904">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
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
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}