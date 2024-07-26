
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AgentArchitecture.Printer;

using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class PrinterPackage {


	private Package.XmlPrinterClass _XmlPrinter;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.XmlPrinterClass XmlPrinter => _XmlPrinter ?? (_XmlPrinter = new Package.XmlPrinterClass());

	private Package.JsonPrinterClass _JsonPrinter;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.JsonPrinterClass JsonPrinter => _JsonPrinter ?? (_JsonPrinter = new Package.JsonPrinterClass());
	}
}