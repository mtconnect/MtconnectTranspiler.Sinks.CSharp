using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.AssetInformationModel.ComponentConfigurationParameters;

namespace Mtconnect.AssetInformationModel.ComponentConfigurationParameters
{
	/// <summary>
	/// set of <see cref="ParameterSet">ParameterSet</see>s that govern the functionality of the related <see cref="Component">Component</see>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ComponentConfigurationParametersClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678197202508_829668_17803";
		
		/// <inheritdoc />
		public string Summary => @"/// set of <see cref=""ParameterSet"">ParameterSet</see>s that govern the functionality of the related <see cref=""Component"">Component</see>.";

		/// <inheritdoc />
		public string Name => "ComponentConfigurationParametersClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_C7D39183_23CB_416b_A62D_F60815E08B1A";

		/// <inheritdoc />
		public ComponentConfigurationParametersClassProperties Properties { get; } = new ComponentConfigurationParametersClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ComponentConfigurationParametersClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasParameterSetPart,
			};
			/// <summary>
			/// <inheritdoc cref="HasParameterSetPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasParameterSet</remarks>
			/// </summary>
			public HasParameterSetPartProperty HasParameterSetPart { get; } = new HasParameterSetPartProperty();
			public sealed class HasParameterSetPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678197254209_96040_17915</item>
				/// <item>Type: ParameterSetClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.ComponentConfigurationParameters</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.ComponentConfigurationParameters.ParameterSetClass);
				
				/// <inheritdoc />
				public string Name => "HasParameterSet";
				
				/// <inheritdoc />
				public string Summary => @"/// set of <see cref=""ParameterSet"">ParameterSet</see>s that govern the functionality of the related <see cref=""Component"">Component</see>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "ParameterSets";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}