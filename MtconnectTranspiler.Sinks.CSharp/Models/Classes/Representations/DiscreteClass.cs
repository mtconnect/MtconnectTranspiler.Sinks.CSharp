using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>
	/// <b>DEPRECATED</b> <see cref="Representation">Representation</see> for an <see cref="Observation">Observation</see> where each discrete occurrence of the data may have the same value as the previous occurrence of the data. /// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DiscreteClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566531114_595827_25728";
		
		/// <inheritdoc />
		public string Summary => @"/// <b>DEPRECATED</b> <see cref=""Representation"">Representation</see> for an <see cref=""Observation"">Observation</see> where each discrete occurrence of the data may have the same value as the previous occurrence of the data. /// Description";

		/// <inheritdoc />
		public string Name => "DiscreteClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "1.5";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1633615188301_96457_1251";

		/// <inheritdoc />
		public DiscreteClassProperties Properties { get; } = new DiscreteClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class DiscreteClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Result,
			};
			/// <summary>
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public ResultProperty Result { get; } = new ResultProperty();
			public sealed class ResultProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "Result";
				
				/// <inheritdoc />
				public string Summary => @"/// <b>DEPRECATED</b> <see cref=""Representation"">Representation</see> for an <see cref=""Observation"">Observation</see> where each discrete occurrence of the data may have the same value as the previous occurrence of the data. /// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.3";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "1.5";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}