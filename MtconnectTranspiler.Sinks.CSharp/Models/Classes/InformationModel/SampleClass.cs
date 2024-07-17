using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.AgentArchitecture.InformationModel;

namespace Mtconnect.AgentArchitecture.InformationModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class SampleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1585536710703_127812_2820";
		
		/// <inheritdoc />
		public string Name => "SampleClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1585536700946_684682_2787";

		/// <inheritdoc />
		public SampleClassProperties Properties { get; } = new SampleClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class SampleClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasValue,
			};
			/// <remarks>Original Name: HasValue</remarks>
			public HasValueProperty HasValue { get; } = new HasValueProperty();
			public sealed class HasValueProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1585537604855_334365_3646</item>
				/// <item>Type: NumericValueClass</item>
				/// <item>Namespace: Mtconnect.AgentArchitecture.InformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AgentArchitecture.InformationModel.NumericValueClass);
				
				/// <inheritdoc />
				public string Name => "HasValue";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}