
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AgentArchitecture.Sink;

using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SinkPackage {


	private Package.RestSinkClass _RestSink;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.RestSinkClass RestSink => _RestSink ?? (_RestSink = new Package.RestSinkClass());
	}
}