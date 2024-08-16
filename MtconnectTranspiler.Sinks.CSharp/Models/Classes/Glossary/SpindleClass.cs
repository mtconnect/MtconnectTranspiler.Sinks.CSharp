using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// mechanism that provides rotational capabilities to a piece of equipment. <br /><br />> Note: Typically used for either work holding, materials or cutting tools.<br /><br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375187_921725_2092">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SpindleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375187_921725_2092";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;mechanism that provides rotational capabilities to a piece of equipment. 

> Note: Typically used for either work holding, materials or cutting tools.

&#10;
";

		/// <inheritdoc />
		public string Name => "spindle";
		
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
		public SpindleClassProperties Properties { get; } = new SpindleClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class SpindleClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}