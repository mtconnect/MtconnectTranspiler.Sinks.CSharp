#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ReferenceAgentArchitecture.Printer;

namespace Mtconnect.ReferenceAgentArchitecture
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1585535835198_757615_2085">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class PrinterPackage : IPackage
	{
		/// <summary>Constant value for <see cref="PrinterPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1585535835198_757615_2085";
		/// <summary>Constant value for <see cref="PrinterPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1585535835198_757615_2085";
		/// <summary>Constant value for <see cref="PrinterPackage.Name" /></summary>
		public const string NAME = "Printer";
		/// <summary>Constant value for <see cref="PrinterPackage.Summary" /></summary>
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
			XmlPrinterClass,
			JsonPrinterClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.XmlPrinterClass _XmlPrinterClass;
	/// <summary>
	/// <inheritdoc cref="Package.XmlPrinterClass" path="/summary" />
	/// </summary>
	public Package.XmlPrinterClass XmlPrinterClass => _XmlPrinterClass ?? (_XmlPrinterClass = new Package.XmlPrinterClass());

	private Package.JsonPrinterClass _JsonPrinterClass;
	/// <summary>
	/// <inheritdoc cref="Package.JsonPrinterClass" path="/summary" />
	/// </summary>
	public Package.JsonPrinterClass JsonPrinterClass => _JsonPrinterClass ?? (_JsonPrinterClass = new Package.JsonPrinterClass());

	#endregion

	#region Enums
	#endregion
	}
}