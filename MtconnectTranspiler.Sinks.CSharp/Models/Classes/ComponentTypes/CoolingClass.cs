using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="System">System</see> that extracts controlled amounts of heat to achieve a target temperature at a specified cooling rate./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CoolingClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605117088875_728711_1893";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""System"">System</see> that extracts controlled amounts of heat to achieve a target temperature at a specified cooling rate./// Description";

		/// <inheritdoc />
		public string Name => "CoolingClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382020_336298_42297";

		public IPropertyList Properties => null;

	}
}