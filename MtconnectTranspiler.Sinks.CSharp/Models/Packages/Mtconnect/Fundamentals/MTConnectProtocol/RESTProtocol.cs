
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.RESTProtocol;

using Mtconnect;

namespace Mtconnect.Fundamentals.MTConnectProtocol {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RESTProtocolPackage {


	private Package.AgentClass _Agent;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AgentClass Agent => _Agent ?? (_Agent = new Package.AgentClass());
	}
}