
using System;
using System.CodeDom.Compiler;

using Mtconnect.DataTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class DecelerationClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1605642679847_825017_142";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Deceleration";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_7_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public DecelerationProperties Properties { get; } = new DecelerationProperties();
		public sealed class DecelerationProperties
		{
		
		
			/// <remarks>Original Name: Units</remarks>
			public UnitsProperty Units { get; } = new UnitsProperty();
			public sealed class UnitsProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A
				public Type Type => typeof(UnitEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Units";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "static";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Type</remarks>
			public TypeProperty Type { get; } = new TypeProperty();
			public sealed class TypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580398370126_672808_12777
				public Type Type => typeof(SampleEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Type";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "static";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: SubType</remarks>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			public sealed class SubTypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1579563592155_977172_22064
				public Type Type => typeof(DataItemSubTypeEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "SubType";
				
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
				public string Extension => "";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}