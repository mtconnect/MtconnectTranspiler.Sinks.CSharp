using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component">Component</see> that observes the surroundings of another <see cref="Component">Component</see>.  > Note: <see cref="Environmental">Environmental</see> <b>SHOULD</b> be organized by <see cref="Auxillaries">Auxillaries</see>, <see cref="Systems">Systems</see> or <see cref="Parts">Parts</see> depending on the relationship to the <see cref="Component">Component</see>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class EnvironmentalClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381990_149427_42240";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> that observes the surroundings of another <see cref=""Component"">Component</see>.  > Note: <see cref=""Environmental"">Environmental</see> <b>SHOULD</b> be organized by <see cref=""Auxillaries"">Auxillaries</see>, <see cref=""Systems"">Systems</see> or <see cref=""Parts"">Parts</see> depending on the relationship to the <see cref=""Component"">Component</see>.";

		/// <inheritdoc />
		public string Name => "EnvironmentalClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";

		public IPropertyList Properties => null;

	}
}