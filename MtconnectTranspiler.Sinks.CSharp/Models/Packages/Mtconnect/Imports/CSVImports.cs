
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.Imports.CSVImports;

using Mtconnect;

namespace Mtconnect.Imports {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CSVImportsPackage {


	private Package.PropertyMapClass _PropertyMap;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PropertyMapClass PropertyMap => _PropertyMap ?? (_PropertyMap = new Package.PropertyMapClass());

	private Package.ImportDescriptorClass _ImportDescriptor;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ImportDescriptorClass ImportDescriptor => _ImportDescriptor ?? (_ImportDescriptor = new Package.ImportDescriptorClass());
	}
}