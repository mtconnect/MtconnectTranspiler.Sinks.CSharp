
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AgentArchitecture.Rest.Storage;

using Mtconnect;

namespace Mtconnect.AgentArchitecture.Rest {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class StoragePackage {


	private Package.CircularBuffferClass _CircularBufffer;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CircularBuffferClass CircularBufffer => _CircularBufffer ?? (_CircularBufffer = new Package.CircularBuffferClass());
	}
}