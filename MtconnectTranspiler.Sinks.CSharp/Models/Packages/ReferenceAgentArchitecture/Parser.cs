#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ReferenceAgentArchitecture.Parser;

namespace Mtconnect.ReferenceAgentArchitecture
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1585535931462_942074_2200">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ParserPackage : IPackage
	{
		/// <summary>Constant value for <see cref="ParserPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1585535931462_942074_2200";
		/// <summary>Constant value for <see cref="ParserPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1585535931462_942074_2200";
		/// <summary>Constant value for <see cref="ParserPackage.Name" /></summary>
		public const string NAME = "Parser";
		/// <summary>Constant value for <see cref="ParserPackage.Summary" /></summary>
		public const string SUMMARY = @"";

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