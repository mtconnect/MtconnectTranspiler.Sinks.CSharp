
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AgentArchitecture.Parser;

using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ParserPackage {


	private Package.XmlParserClass _XmlParser;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.XmlParserClass XmlParser => _XmlParser ?? (_XmlParser = new Package.XmlParserClass());

	private Package.JsonParserClass _JsonParser;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.JsonParserClass JsonParser => _JsonParser ?? (_JsonParser = new Package.JsonParserClass());
	}
}