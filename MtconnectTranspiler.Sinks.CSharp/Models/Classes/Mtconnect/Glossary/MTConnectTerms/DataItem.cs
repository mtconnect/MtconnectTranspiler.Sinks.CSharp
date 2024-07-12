
using System;
using System.CodeDom.Compiler;

using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.Glossary.MTConnectTerms
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class DataItemClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1635251889215_363828_393";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "DataItem";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public DataItemProperties Properties { get; } = new DataItemProperties();
		public sealed class DataItemProperties
		{
		
		
			/// <remarks>Original Name: ObservedBy</remarks>
			public ObservedByProperty ObservedBy { get; } = new ObservedByProperty();
			public sealed class ObservedByProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1581734537697_742151_1119
				public Type Type => typeof(ComponentClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservedBy";
				
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
		};

	}
}