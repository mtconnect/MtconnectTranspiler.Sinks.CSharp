using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>
	/// <i>observation</i> that provides telemetry data for a <i>DataItem</i>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581812901326_593856_4168">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ObservationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581812901326_593856_4168";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>observation</i> that provides telemetry data for a <i>DataItem</i>.";

		/// <inheritdoc />
		public string Name => "Observation";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1581733974550_623533_615
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.IndustrialTerms.ThingClass);

		/// <inheritdoc />
		public ObservationClassProperties Properties { get; } = new ObservationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ObservationClassProperties : Mtconnect.Glossary.IndustrialTerms.ThingClass.ThingClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				MadeBy,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="MadeByProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MadeBy</remarks>
			/// </summary>
			public MadeByProperty MadeBy { get; } = new MadeByProperty();
			public sealed class MadeByProperty : IProperty
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
				public string Name => "made by";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>observation</i> that provides telemetry data for a <i>DataItem</i>.";

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
		};

	}
}