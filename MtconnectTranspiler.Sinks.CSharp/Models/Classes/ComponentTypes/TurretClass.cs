using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="ToolingDelivery">ToolingDelivery</see> composed of a tool mounting mechanism that holds any number of tools./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class TurretClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605551876111_523604_2450";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""ToolingDelivery"">ToolingDelivery</see> composed of a tool mounting mechanism that holds any number of tools./// Description";

		/// <inheritdoc />
		public string Name => "TurretClass";
		
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