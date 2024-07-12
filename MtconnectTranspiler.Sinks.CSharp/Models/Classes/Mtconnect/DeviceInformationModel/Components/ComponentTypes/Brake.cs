
using System;
using System.CodeDom.Compiler;

using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class BrakeClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_45f01b9_1580312106461_720908_44375";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Brake";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_4_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public BrakeProperties Properties { get; } = new BrakeProperties();
		public sealed class BrakeProperties
		{
		
		
			/// <remarks>Original Name: HasComposition</remarks>
			public HasCompositionProperty HasComposition { get; } = new HasCompositionProperty();
			public sealed class HasCompositionProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1658936424016_561586_139
				public Type Type => typeof(CompositionClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasComposition";
				
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
		
		
			/// <remarks>Original Name: HasComponent</remarks>
			public HasComponentProperty HasComponent { get; } = new HasComponentProperty();
			public sealed class HasComponentProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
				public Type Type => typeof(ComponentClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasComponent";
				
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