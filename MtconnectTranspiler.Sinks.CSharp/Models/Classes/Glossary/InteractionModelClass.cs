using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// model that defines how information is exchanged across an <i>interface</i> to enable interactions between independent systems.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375166_552865_2017">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class InteractionModelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375166_552865_2017";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;model that defines how information is exchanged across an {{term(interface)}} to enable interactions between independent systems.&#10;
";

		/// <inheritdoc />
		public string Name => "interaction model";
		
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
		public InteractionModelClassProperties Properties { get; } = new InteractionModelClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class InteractionModelClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}