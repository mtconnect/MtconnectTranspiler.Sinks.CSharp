
using System;
using System.CodeDom.Compiler;

using Mtconnect.AssetInformationModel.ComponentConfigurationParameters;

namespace Mtconnect.AssetInformationModel.ComponentConfigurationParameters
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ComponentConfigurationParametersClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1678197202508_829668_17803";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "ComponentConfigurationParameters";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_2_2_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public ComponentConfigurationParametersProperties Properties { get; } = new ComponentConfigurationParametersProperties();
		public sealed class ComponentConfigurationParametersProperties
		{
		
		
			/// <remarks>Original Name: HasParameterSet</remarks>
			public HasParameterSetPartProperty HasParameterSetPart { get; } = new HasParameterSetPartProperty();
			public sealed class HasParameterSetPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1678197254209_96040_17915
				public Type Type => typeof(ParameterSetClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasParameterSet";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "ParameterSets";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}