using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.IndustrialTerms;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.Glossary.IndustrialTerms
{
	/// <summary>
	/// logical or physical entity that may produce <i>observation</i>s about itself.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class EngineeredSystemClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1635250812908_628647_270";
		
		/// <inheritdoc />
		public string Summary => @"/// logical or physical entity that may produce <i>observation</i>s about itself.";

		/// <inheritdoc />
		public string Name => "EngineeredSystemClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1581733974550_623533_615";

		/// <inheritdoc />
		public EngineeredSystemClassProperties Properties { get; } = new EngineeredSystemClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class EngineeredSystemClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				PartOf,
				HasPart,
				MakesObservation,
				Observes,
				MadeObservation,
			};
			/// <summary>
			/// <inheritdoc cref="PartOfProperty" path="/summary" /><br/>
			/// <remarks>Original Name: PartOf</remarks>
			/// </summary>
			public PartOfProperty PartOf { get; } = new PartOfProperty();
			public sealed class PartOfProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1635250812908_628647_270</item>
				/// <item>Type: EngineeredSystemClass</item>
				/// <item>Namespace: Mtconnect.Glossary.IndustrialTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.IndustrialTerms.EngineeredSystemClass);
				
				/// <inheritdoc />
				public string Name => "PartOf";
				
				/// <inheritdoc />
				public string Summary => @"/// logical or physical entity that may produce <i>observation</i>s about itself.";

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
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasPart</remarks>
			/// </summary>
			public HasPartProperty HasPart { get; } = new HasPartProperty();
			public sealed class HasPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1635250812908_628647_270</item>
				/// <item>Type: EngineeredSystemClass</item>
				/// <item>Namespace: Mtconnect.Glossary.IndustrialTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.IndustrialTerms.EngineeredSystemClass);
				
				/// <inheritdoc />
				public string Name => "HasPart";
				
				/// <inheritdoc />
				public string Summary => @"/// logical or physical entity that may produce <i>observation</i>s about itself.";

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
			}
			/// <summary>
			/// <inheritdoc cref="MakesObservationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MakesObservation</remarks>
			/// </summary>
			public MakesObservationProperty MakesObservation { get; } = new MakesObservationProperty();
			public sealed class MakesObservationProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1629291060726_222338_26</item>
				/// <item>Type: ObservationClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.ObservationClass);
				
				/// <inheritdoc />
				public string Name => "MakesObservation";
				
				/// <inheritdoc />
				public string Summary => @"/// logical or physical entity that may produce <i>observation</i>s about itself.";

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
			}
			/// <summary>
			/// <inheritdoc cref="ObservesProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Observes</remarks>
			/// </summary>
			public ObservesProperty Observes { get; } = new ObservesProperty();
			public sealed class ObservesProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1629291153288_544363_79</item>
				/// <item>Type: ObservableClass</item>
				/// <item>Namespace: Mtconnect.Glossary.IndustrialTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.IndustrialTerms.ObservableClass);
				
				/// <inheritdoc />
				public string Name => "Observes";
				
				/// <inheritdoc />
				public string Summary => @"/// logical or physical entity that may produce <i>observation</i>s about itself.";

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
			}
			/// <summary>
			/// <inheritdoc cref="MadeObservationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MadeObservation</remarks>
			/// </summary>
			public MadeObservationProperty MadeObservation { get; } = new MadeObservationProperty();
			public sealed class MadeObservationProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1581812901326_593856_4168</item>
				/// <item>Type: ObservationClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.ObservationClass);
				
				/// <inheritdoc />
				public string Name => "MadeObservation";
				
				/// <inheritdoc />
				public string Summary => @"/// logical or physical entity that may produce <i>observation</i>s about itself.";

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
			}
		};

	}
}