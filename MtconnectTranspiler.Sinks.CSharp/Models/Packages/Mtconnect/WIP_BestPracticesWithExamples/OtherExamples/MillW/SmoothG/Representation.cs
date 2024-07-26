
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG.Representation;

using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RepresentationPackage {


	private Package.VariableClass _Variable;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.VariableClass Variable => _Variable ?? (_Variable = new Package.VariableClass());

	private Package.WorkOffsetsClass _WorkOffsets;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.WorkOffsetsClass WorkOffsets => _WorkOffsets ?? (_WorkOffsets = new Package.WorkOffsetsClass());

	private Package.TemperatureClass _Temperature;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TemperatureClass Temperature => _Temperature ?? (_Temperature = new Package.TemperatureClass());
	}
}