using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.AgentArchitecture.InformationModel;

namespace Mtconnect.AgentArchitecture.InformationModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ObservationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1585536700946_684682_2787";
		
		/// <inheritdoc />
		public string Name => "ObservationClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public ObservationClassProperties Properties { get; } = new ObservationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ObservationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasValue,
			};
			/// <remarks>Original Name: HasValue</remarks>
			public HasValueProperty HasValue { get; } = new HasValueProperty();
			public sealed class HasValueProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1585537591558_380255_3580</item>
				/// <item>Type: ObservationValueClass</item>
				/// <item>Namespace: Mtconnect.AgentArchitecture.InformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AgentArchitecture.InformationModel.ObservationValueClass);
				
				/// <inheritdoc />
				public string Name => "HasValue";
				
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

				// TODO: Add Summary
			}
		};

	}
}