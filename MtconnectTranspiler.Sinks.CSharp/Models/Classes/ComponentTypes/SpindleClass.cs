using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component">Component</see> that provides an axis of rotation for the purpose of rapidly rotating a part or a tool to provide sufficient surface speed for cutting operations.  <see cref="Spindle">Spindle</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.1</i>s and was replaced by <see cref="RotaryMode">RotaryMode</see>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SpindleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1643678227814_87818_1410";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> that provides an axis of rotation for the purpose of rapidly rotating a part or a tool to provide sufficient surface speed for cutting operations.  <see cref=""Spindle"">Spindle</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.1</i>s and was replaced by <see cref=""RotaryMode"">RotaryMode</see>.";

		/// <inheritdoc />
		public string Name => "SpindleClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "1.1";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572381972_553005_42207";

		public IPropertyList Properties => null;

	}
}