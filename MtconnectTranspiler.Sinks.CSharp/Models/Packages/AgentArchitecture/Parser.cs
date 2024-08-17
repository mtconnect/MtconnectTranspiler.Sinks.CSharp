#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Parser;

namespace Mtconnect.AgentArchitecture
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1585535931462_942074_2200">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ParserPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1585535931462_942074_2200";
		
		/// <inheritdoc />
		public string Name => "Parser";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			XmlParserClass,
			JsonParserClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.XmlParserClass _XmlParserClass;
	/// <summary>
	/// <inheritdoc cref="Package.XmlParserClass" path="/summary" />
	/// </summary>
	public Package.XmlParserClass XmlParserClass => _XmlParserClass ?? (_XmlParserClass = new Package.XmlParserClass());

	private Package.JsonParserClass _JsonParserClass;
	/// <summary>
	/// <inheritdoc cref="Package.JsonParserClass" path="/summary" />
	/// </summary>
	public Package.JsonParserClass JsonParserClass => _JsonParserClass ?? (_JsonParserClass = new Package.JsonParserClass());

	#endregion

	#region Enums
	#endregion
	}
}