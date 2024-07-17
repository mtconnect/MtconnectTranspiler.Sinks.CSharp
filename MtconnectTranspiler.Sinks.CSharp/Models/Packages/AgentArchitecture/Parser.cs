using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Parser;
// using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ParserPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			XmlParserClass,
			JsonParserClass,
		};

	private Package.XmlParserClass _XmlParserClass;
	public Package.XmlParserClass XmlParserClass => _XmlParserClass ?? (_XmlParserClass = new Package.XmlParserClass());
	private Package.JsonParserClass _JsonParserClass;
	public Package.JsonParserClass JsonParserClass => _JsonParserClass ?? (_JsonParserClass = new Package.JsonParserClass());
	}
}