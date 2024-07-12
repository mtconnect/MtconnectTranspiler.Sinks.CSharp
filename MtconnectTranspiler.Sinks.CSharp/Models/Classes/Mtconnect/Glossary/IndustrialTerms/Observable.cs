
using System;
using System.CodeDom.Compiler;


namespace Mtconnect.Glossary.IndustrialTerms
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ObservableClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1629291153288_544363_79";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Observable";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public ObservableProperties Properties { get; } = new ObservableProperties();
		public sealed class ObservableProperties
		{
		
		
			/// <remarks>Original Name: ObservedBy</remarks>
			public ObservedByProperty ObservedBy { get; } = new ObservedByProperty();
			public sealed class ObservedByProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1635250812908_628647_270
				public Type Type => typeof(EngineeredSystemClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservedBy";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasObservation</remarks>
			public HasObservationProperty HasObservation { get; } = new HasObservationProperty();
			public sealed class HasObservationProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1629291060726_222338_26
				public Type Type => typeof(ObservationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasObservation";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

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