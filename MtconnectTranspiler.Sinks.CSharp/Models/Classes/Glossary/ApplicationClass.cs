using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// software or a program that is specific to the solution of an application problem.<br /><seealso href="https://www.google.com/search?q=ISO/IEC 20944-1:2013&btnI=I">ISO/IEC 20944-1:2013</seealso><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375141_18140_1949">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ApplicationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375141_18140_1949";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;software or a program that is specific to the solution of an application problem.
{{cite(ISO/IEC 20944-1:2013)}}&#10;
";

		/// <inheritdoc />
		public string Name => "application";
		
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
		public ApplicationClassProperties Properties { get; } = new ApplicationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ApplicationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}