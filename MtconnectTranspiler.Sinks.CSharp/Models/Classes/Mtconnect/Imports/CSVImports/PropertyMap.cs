
using System;
using System.CodeDom.Compiler;


namespace Mtconnect.Imports.CSVImports
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class PropertyMapClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_45f01b9_1579210647406_198412_3583";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "PropertyMap";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public PropertyMapProperties Properties { get; } = new PropertyMapProperties();
		public sealed class PropertyMapProperties
		{
		
		
			/// <remarks>Original Name: PropertyName</remarks>
			public PropertyNameProperty PropertyName { get; } = new PropertyNameProperty();
			public sealed class PropertyNameProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: 
				public Type Type => typeof(Object);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "PropertyName";
				
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
		
		
			/// <remarks>Original Name: StereotypeName</remarks>
			public StereotypeNameProperty StereotypeName { get; } = new StereotypeNameProperty();
			public sealed class StereotypeNameProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: 
				public Type Type => typeof(Object);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "StereotypeName";
				
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
		
		
			/// <remarks>Original Name: ColumnIndex</remarks>
			public ColumnIndexProperty ColumnIndex { get; } = new ColumnIndexProperty();
			public sealed class ColumnIndexProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: 
				public Type Type => typeof(Object);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ColumnIndex";
				
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