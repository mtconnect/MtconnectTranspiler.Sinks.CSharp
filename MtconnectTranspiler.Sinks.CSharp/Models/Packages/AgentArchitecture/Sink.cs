#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Sink;

namespace Mtconnect.AgentArchitecture
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1585535659050_502398_1913">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class SinkPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1585535659050_502398_1913";
		
		/// <inheritdoc />
		public string Name => "Sink";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			RestSinkGeneralization,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.RestSinkGeneralization _RestSinkGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.RestSinkGeneralization" path="/summary" />
	/// </summary>
	public Package.RestSinkGeneralization RestSinkGeneralization => _RestSinkGeneralization ?? (_RestSinkGeneralization = new Package.RestSinkGeneralization());

	#endregion

	#region Enums
	#endregion
	}
}