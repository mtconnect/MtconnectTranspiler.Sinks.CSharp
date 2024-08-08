using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems
{
	/// <summary>
	/// process of transforming to the origin position of the coordinate system from a parent coordinate system using <see cref="Translation">Translation</see> and <see cref="Rotation">Rotation</see>./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class TransformationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579103900791_417826_16362";
		
		/// <inheritdoc />
		public string Summary => @"/// process of transforming to the origin position of the coordinate system from a parent coordinate system using <see cref=""Translation"">Translation</see> and <see cref=""Rotation"">Rotation</see>./// Description";

		/// <inheritdoc />
		public string Name => "TransformationClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.6";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public TransformationClassProperties Properties { get; } = new TransformationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class TransformationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasTranslationPart,
				HasRotationPart,
			};
			/// <summary>
			/// <inheritdoc cref="HasTranslationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasTranslation</remarks>
			/// </summary>
			public HasTranslationPartProperty HasTranslationPart { get; } = new HasTranslationPartProperty();
			public sealed class HasTranslationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1583182362743_846297_4736</item>
				/// <item>Type: TranslationClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.TranslationClass);
				
				/// <inheritdoc />
				public string Name => "HasTranslation";
				
				/// <inheritdoc />
				public string Summary => @"/// process of transforming to the origin position of the coordinate system from a parent coordinate system using <see cref=""Translation"">Translation</see> and <see cref=""Rotation"">Rotation</see>./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "Translation";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasRotationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasRotation</remarks>
			/// </summary>
			public HasRotationPartProperty HasRotationPart { get; } = new HasRotationPartProperty();
			public sealed class HasRotationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1583182385473_997250_4783</item>
				/// <item>Type: RotationClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.RotationClass);
				
				/// <inheritdoc />
				public string Name => "HasRotation";
				
				/// <inheritdoc />
				public string Summary => @"/// process of transforming to the origin position of the coordinate system from a parent coordinate system using <see cref=""Translation"">Translation</see> and <see cref=""Rotation"">Rotation</see>./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "Rotation";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

		# region Rules
		/// <summary>
		/// Transform
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Transform => @"hasTranslation->size() + hasRotation->size() = 1 and hasTranslation->size() + hasRotation->size() <> 0 ";
		/*
		hasTranslation->size() + hasRotation->size() = 1 and hasTranslation->size() + hasRotation->size() <> 0 
		*/
		# endregion
	}
}