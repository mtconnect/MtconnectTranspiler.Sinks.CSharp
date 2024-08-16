using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems
{
	/// <summary>
	﻿/// process of transforming to the origin position of the coordinate system from a parent coordinate system using <see cref="Translation">Translation</see> and <see cref="Rotation">Rotation</see>.<br/><br />Description<br/>At a minimum, a <see cref="Translation">Translation</see> or a <see cref="Rotation">Rotation</see> <b>MUST</b> be defined for a <see cref="Transformation">Transformation</see>.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579103900791_417826_16362">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class TransformationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579103900791_417826_16362";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;process of transforming to the origin position of the coordinate system from a parent coordinate system using {{block(Translation)}} and {{block(Rotation)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;At a minimum, a {{block(Translation)}} or a {{block(Rotation)}} **MUST** be defined for a {{block(Transformation)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Transformation";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.6";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public TransformationClassProperties Properties { get; } = new TransformationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class TransformationClassProperties : IPropertyList
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
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems.TranslationClass);
				
				/// <inheritdoc />
				public string Name => "hasTranslation";
				
				/// <inheritdoc />
				public string Summary => @"";

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
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems.RotationClass);
				
				/// <inheritdoc />
				public string Name => "hasRotation";
				
				/// <inheritdoc />
				public string Summary => @"";

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