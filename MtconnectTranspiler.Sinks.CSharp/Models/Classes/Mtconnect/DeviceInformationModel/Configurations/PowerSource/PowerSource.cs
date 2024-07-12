
using System;
using System.CodeDom.Compiler;

using Mtconnect.DataTypes;

namespace Mtconnect.DeviceInformationModel.Configurations.PowerSource
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class PowerSourceClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1696870815347_556704_3251";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "PowerSource";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_2_3_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public PowerSourceProperties Properties { get; } = new PowerSourceProperties();
		public sealed class PowerSourceProperties
		{
		
		
			/// <remarks>Original Name: Type</remarks>
			public TypeProperty Type { get; } = new TypeProperty();
			public sealed class TypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1696871537426_335818_3541
				public Type Type => typeof(PowerSourceTypeEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Type";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_2_3_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Id</remarks>
			public IdProperty Id { get; } = new IdProperty();
			public sealed class IdProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272245466_691733_672
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Id";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_2_3_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: ComponentIdRef</remarks>
			public ComponentIdRefProperty ComponentIdRef { get; } = new ComponentIdRefProperty();
			public sealed class ComponentIdRefProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272245466_691733_672
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ComponentIdRef";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_2_3_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Value</remarks>
			public ValueProperty Value { get; } = new ValueProperty();
			public sealed class ValueProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272360416_763325_681
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Value";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_2_3_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}