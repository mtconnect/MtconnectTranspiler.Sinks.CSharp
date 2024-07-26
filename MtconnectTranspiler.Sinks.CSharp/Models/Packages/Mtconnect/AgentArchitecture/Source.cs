
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AgentArchitecture.Source;

using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SourcePackage {


	private Package.MQTTDataSourceClass _MQTTDataSource;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MQTTDataSourceClass MQTTDataSource => _MQTTDataSource ?? (_MQTTDataSource = new Package.MQTTDataSourceClass());

	private Package.AdapterDataSourceClass _AdapterDataSource;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AdapterDataSourceClass AdapterDataSource => _AdapterDataSource ?? (_AdapterDataSource = new Package.AdapterDataSourceClass());
	}
}