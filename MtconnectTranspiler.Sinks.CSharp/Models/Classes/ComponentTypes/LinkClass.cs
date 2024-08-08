using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Structure">Structure</see> that provides a connection between <see cref="Component">Component</see> entities.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class LinkClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1587597430378_591532_1084";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Structure"">Structure</see> that provides a connection between <see cref=""Component"">Component</see> entities.";

		/// <inheritdoc />
		public string Name => "LinkClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1587597358521_716746_1028";

		public IPropertyList Properties => null;

	}
}