using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG.Representation;
// using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RepresentationPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			VariableClass,
			WorkOffsetsClass,
			TemperatureClass,
		};

	private Package.VariableClass _VariableClass;
	public Package.VariableClass VariableClass => _VariableClass ?? (_VariableClass = new Package.VariableClass());
	private Package.WorkOffsetsClass _WorkOffsetsClass;
	public Package.WorkOffsetsClass WorkOffsetsClass => _WorkOffsetsClass ?? (_WorkOffsetsClass = new Package.WorkOffsetsClass());
	private Package.TemperatureClass _TemperatureClass;
	public Package.TemperatureClass TemperatureClass => _TemperatureClass ?? (_TemperatureClass = new Package.TemperatureClass());
	}
}