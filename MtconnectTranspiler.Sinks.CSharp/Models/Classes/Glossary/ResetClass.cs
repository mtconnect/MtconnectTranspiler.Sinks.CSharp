using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// act of reverting back the accumulated value or statistic to their initial value.  > Note: An <i>Observation</i> with a <i>data set</i> representation removes all <i>key-value pair</i>s, setting the <i>data set</i> to an empty set.  
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375182_524550_2074">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ResetClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375182_524550_2074";
		
		/// <inheritdoc />
		public string Summary => @"/// act of reverting back the accumulated value or statistic to their initial value.  > Note: An <i>Observation</i> with a <i>data set</i> representation removes all <i>key-value pair</i>s, setting the <i>data set</i> to an empty set.  ";

		/// <inheritdoc />
		public string Name => "reset";
		
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
		public ResetClassProperties Properties { get; } = new ResetClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ResetClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}