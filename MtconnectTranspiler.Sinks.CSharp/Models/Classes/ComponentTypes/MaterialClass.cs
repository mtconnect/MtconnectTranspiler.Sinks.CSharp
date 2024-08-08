using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Resource">Resource</see> composed of material that is consumed or used by the piece of equipment for production of parts, materials, or other types of goods.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MaterialClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382002_513291_42264";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Resource"">Resource</see> composed of material that is consumed or used by the piece of equipment for production of parts, materials, or other types of goods.";

		/// <inheritdoc />
		public string Name => "MaterialClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.8";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382014_307743_42285";

		public IPropertyList Properties => null;

	}
}