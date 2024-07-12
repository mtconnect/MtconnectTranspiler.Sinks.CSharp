
using System;
using System.CodeDom.Compiler;

using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class TransformationClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_45f01b9_1579103900791_417826_16362";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Transformation";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_6_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public TransformationProperties Properties { get; } = new TransformationProperties();
		public sealed class TransformationProperties
		{
		
		
			/// <remarks>Original Name: HasTranslation</remarks>
			public HasTranslationPartProperty HasTranslationPart { get; } = new HasTranslationPartProperty();
			public sealed class HasTranslationPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1583182362743_846297_4736
				public Type Type => typeof(TranslationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasTranslation";
				
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
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Translation";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasRotation</remarks>
			public HasRotationPartProperty HasRotationPart { get; } = new HasRotationPartProperty();
			public sealed class HasRotationPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1583182385473_997250_4783
				public Type Type => typeof(RotationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasRotation";
				
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
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Rotation";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

		# region Rules
		/// <summary>
		/// Transform
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		/*
		hasTranslation->size() + hasRotation->size() = 1 and hasTranslation->size() + hasRotation->size() <> 0 
		*/
		# endregion
	}
}