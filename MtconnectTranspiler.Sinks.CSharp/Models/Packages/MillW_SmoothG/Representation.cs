using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG.Representation;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class RepresentationPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1634044347705_111979_477";
		
		/// <inheritdoc />
		public string Name => "Representation";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			VariableClass,
			WorkOffsetsClass,
			TemperatureClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.VariableClass _VariableClass;
	/// <summary>
	/// <inheritdoc cref="Package.VariableClass" path="/summary" />
	/// </summary>
	public Package.VariableClass VariableClass => _VariableClass ?? (_VariableClass = new Package.VariableClass());

	private Package.WorkOffsetsClass _WorkOffsetsClass;
	/// <summary>
	/// <inheritdoc cref="Package.WorkOffsetsClass" path="/summary" />
	/// </summary>
	public Package.WorkOffsetsClass WorkOffsetsClass => _WorkOffsetsClass ?? (_WorkOffsetsClass = new Package.WorkOffsetsClass());

	private Package.TemperatureClass _TemperatureClass;
	/// <summary>
	/// <inheritdoc cref="Package.TemperatureClass" path="/summary" />
	/// </summary>
	public Package.TemperatureClass TemperatureClass => _TemperatureClass ?? (_TemperatureClass = new Package.TemperatureClass());

	#endregion
	}
}