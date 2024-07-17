using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Printer;
// using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class PrinterPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			XmlPrinterClass,
			JsonPrinterClass,
		};

	private Package.XmlPrinterClass _XmlPrinterClass;
	public Package.XmlPrinterClass XmlPrinterClass => _XmlPrinterClass ?? (_XmlPrinterClass = new Package.XmlPrinterClass());
	private Package.JsonPrinterClass _JsonPrinterClass;
	public Package.JsonPrinterClass JsonPrinterClass => _JsonPrinterClass ?? (_JsonPrinterClass = new Package.JsonPrinterClass());
	}
}