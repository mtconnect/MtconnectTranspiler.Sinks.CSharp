using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="System">System</see> that manages a chemical mixture used in a manufacturing process being performed at that piece of equipment./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DielectricClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381982_394383_42225";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""System"">System</see> that manages a chemical mixture used in a manufacturing process being performed at that piece of equipment./// Description";

		/// <inheritdoc />
		public string Name => "DielectricClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382020_336298_42297";

		public IPropertyList Properties => null;

	}
}