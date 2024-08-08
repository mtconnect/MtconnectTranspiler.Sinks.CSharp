using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// mechanism that provides rotational capabilities to a piece of equipment.   > Note: Typically used for either work holding, materials or cutting tools.  
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SpindleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375187_921725_2092";
		
		/// <inheritdoc />
		public string Summary => @"/// mechanism that provides rotational capabilities to a piece of equipment.   > Note: Typically used for either work holding, materials or cutting tools.  ";

		/// <inheritdoc />
		public string Name => "SpindleClass";
		
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