using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// discrete item that has both defined and measurable physical characteristics including mass, material, and features, and is created by applying one or more manufacturing process steps to a workpiece
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PartClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375178_991512_2059";
		
		/// <inheritdoc />
		public string Summary => @"/// discrete item that has both defined and measurable physical characteristics including mass, material, and features, and is created by applying one or more manufacturing process steps to a workpiece";

		/// <inheritdoc />
		public string Name => "PartClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		public IPropertyList Properties => null;

	}
}