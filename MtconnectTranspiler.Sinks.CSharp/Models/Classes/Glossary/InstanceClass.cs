using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// describes a set of <i>streaming data</i> in an <i>agent</i>.  Each time an <i>agent</i> is restarted with an empty <i>buffer</i>, data placed in the <i>buffer</i> represents a new <i>instance</i> of the <i>agent</i>.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375166_228257_2016">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class InstanceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375166_228257_2016";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;describes a set of {{term(streaming data)}} in an {{term(agent)}}.  Each time an {{term(agent)}} is restarted with an empty {{term(buffer)}}, data placed in the {{term(buffer)}} represents a new {{term(instance)}} of the {{term(agent)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "instance";
		
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
		public InstanceClassProperties Properties { get; } = new InstanceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class InstanceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}