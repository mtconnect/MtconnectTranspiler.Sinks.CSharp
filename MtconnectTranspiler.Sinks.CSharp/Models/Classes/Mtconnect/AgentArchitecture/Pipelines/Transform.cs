
using System;
using System.CodeDom.Compiler;

using Mtconnect.AgentArchitecture.Pipelines;

namespace Mtconnect.AgentArchitecture.Pipelines
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class TransformClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_4_45f01b9_1674413898061_196217_3470";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Transform";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public TransformProperties Properties { get; } = new TransformProperties();
		public sealed class TransformProperties
		{
		
		
			/// <remarks>Original Name: Guard</remarks>
			public GuardProperty Guard { get; } = new GuardProperty();
			public sealed class GuardProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_4_45f01b9_1674414211400_186233_3570
				public Type Type => typeof(GuardClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Guard";
				
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
		
		
			/// <remarks>Original Name: Next</remarks>
			public NextProperty Next { get; } = new NextProperty();
			public sealed class NextProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_4_45f01b9_1674413898061_196217_3470
				public Type Type => typeof(TransformClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Next";
				
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