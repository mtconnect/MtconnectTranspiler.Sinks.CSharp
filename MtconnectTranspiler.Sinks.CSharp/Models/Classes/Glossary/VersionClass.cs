using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// unique identifier of the administered item. <seealso href="https://www.google.com/search?q=ISO/IEC 11179-:2015&btnI=I">ISO/IEC 11179-:2015</seealso>
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375191_736215_2108">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class VersionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375191_736215_2108";
		
		/// <inheritdoc />
		public string Summary => @"/// unique identifier of the administered item. <seealso href=""https://www.google.com/search?q=ISO/IEC 11179-:2015&btnI=I"">ISO/IEC 11179-:2015</seealso>";

		/// <inheritdoc />
		public string Name => "version";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public VersionClassProperties Properties { get; } = new VersionClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class VersionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}