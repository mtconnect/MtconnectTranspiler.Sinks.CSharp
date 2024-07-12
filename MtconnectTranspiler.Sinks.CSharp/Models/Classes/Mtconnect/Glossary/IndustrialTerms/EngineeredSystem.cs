
using System;
using System.CodeDom.Compiler;

using Mtconnect.ObservationInformationModel;

namespace Mtconnect.Glossary.IndustrialTerms
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class EngineeredSystemClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1635250812908_628647_270";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "EngineeredSystem";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public EngineeredSystemProperties Properties { get; } = new EngineeredSystemProperties();
		public sealed class EngineeredSystemProperties
		{
		
		
			/// <remarks>Original Name: PartOf</remarks>
			public PartOfProperty PartOf { get; } = new PartOfProperty();
			public sealed class PartOfProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1635250812908_628647_270
				public Type Type => typeof(EngineeredSystemClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "PartOf";
				
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
		
		
			/// <remarks>Original Name: HasPart</remarks>
			public HasPartProperty HasPart { get; } = new HasPartProperty();
			public sealed class HasPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1635250812908_628647_270
				public Type Type => typeof(EngineeredSystemClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasPart";
				
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
		
		
			/// <remarks>Original Name: MakesObservation</remarks>
			public MakesObservationProperty MakesObservation { get; } = new MakesObservationProperty();
			public sealed class MakesObservationProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1629291060726_222338_26
				public Type Type => typeof(ObservationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "MakesObservation";
				
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
		
		
			/// <remarks>Original Name: Observes</remarks>
			public ObservesProperty Observes { get; } = new ObservesProperty();
			public sealed class ObservesProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1629291153288_544363_79
				public Type Type => typeof(ObservableClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Observes";
				
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
		
		
			/// <remarks>Original Name: MadeObservation</remarks>
			public MadeObservationProperty MadeObservation { get; } = new MadeObservationProperty();
			public sealed class MadeObservationProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1581812901326_593856_4168
				public Type Type => typeof(ObservationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "MadeObservation";
				
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