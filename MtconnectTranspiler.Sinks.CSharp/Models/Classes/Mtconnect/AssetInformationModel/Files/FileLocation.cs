
using System;
using System.CodeDom.Compiler;


namespace Mtconnect.AssetInformationModel.Files
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class FileLocationClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1605277122154_664309_406";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "FileLocation";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_7_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public FileLocationProperties Properties { get; } = new FileLocationProperties();
		public sealed class FileLocationProperties
		{
		
		
			/// <remarks>Original Name: Href</remarks>
			public HrefProperty Href { get; } = new HrefProperty();
			public sealed class HrefProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579298271303_312832_6966
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Href";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_7_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Xlink:Type</remarks>
			public Xlink_TypeProperty Xlink_Type { get; } = new Xlink_TypeProperty();
			public sealed class Xlink_TypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579298283941_424312_6968
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Xlink:Type";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_7_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

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