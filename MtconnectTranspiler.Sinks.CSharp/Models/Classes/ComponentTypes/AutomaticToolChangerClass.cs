using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="ToolingDelivery">ToolingDelivery</see> composed of a tool delivery mechanism that moves tools between a <see cref="ToolMagazine">ToolMagazine</see> and a <i>spindle</i> a <see cref="Turret">Turret</see>./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AutomaticToolChangerClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605551853978_27109_2354";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""ToolingDelivery"">ToolingDelivery</see> composed of a tool delivery mechanism that moves tools between a <see cref=""ToolMagazine"">ToolMagazine</see> and a <i>spindle</i> a <see cref=""Turret"">Turret</see>./// Description";

		/// <inheritdoc />
		public string Name => "AutomaticToolChangerClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382021_741508_42300";

		public IPropertyList Properties => null;

	}
}