
using System;
using System.CodeDom.Compiler;


namespace Mtconnect.AgentArchitecture.Pipelines
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class LambdaGuardClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_4_45f01b9_1674414517415_840067_3791";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "LambdaGuard";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public LambdaGuardProperties Properties { get; } = new LambdaGuardProperties();
		public sealed class LambdaGuardProperties
		{
		
		
			/// <remarks>Original Name: Lambda</remarks>
			public LambdaProperty Lambda { get; } = new LambdaProperty();
			public sealed class LambdaProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_4_45f01b9_1674414564913_988496_3836
				public Type Type => typeof(Object);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Lambda";
				
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