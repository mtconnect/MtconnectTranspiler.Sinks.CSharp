
using System;
using System.CodeDom.Compiler;


namespace Mtconnect.AgentArchitecture.Pipelines
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class TypeGuardClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_4_45f01b9_1674414404246_737265_3635";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "TypeGuard";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public TypeGuardProperties Properties { get; } = new TypeGuardProperties();
		public sealed class TypeGuardProperties
		{
		
		
			/// <remarks>Original Name: Type</remarks>
			public TypeProperty Type { get; } = new TypeProperty();
			public sealed class TypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_4_45f01b9_1674414484722_669698_3782
				public Type Type => typeof(Object);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Type";
				
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