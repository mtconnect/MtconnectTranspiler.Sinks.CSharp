
using System;
using System.CodeDom.Compiler;


namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG.Representation
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class WorkOffsetsClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1634045367649_547336_746";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "WorkOffsets";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public WorkOffsetsProperties Properties { get; } = new WorkOffsetsProperties();
		public sealed class WorkOffsetsProperties
		{
		
		
			/// <remarks>Original Name: Count</remarks>
			public CountProperty Count { get; } = new CountProperty();
			public sealed class CountProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272271512_537408_674
				public Type Type => typeof(Int32);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Count";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
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
		};

	}
}