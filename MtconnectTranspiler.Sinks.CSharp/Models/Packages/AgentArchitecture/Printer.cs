using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Printer;
// using Mtconnect;

namespace Mtconnect.AgentArchitecture
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class PrinterPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1585535835198_757615_2085";
		
		/// <inheritdoc />
		public string Name => "Printer";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			XmlPrinterClass,
			JsonPrinterClass,
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
	}
}