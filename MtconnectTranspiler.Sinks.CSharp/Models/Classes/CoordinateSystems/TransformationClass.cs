#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems
{
	/// <summary>﻿process of transforming to the origin position of the coordinate system from a parent coordinate system using <see cref="Translation">Translation</see> and <see cref="Rotation">Rotation</see>.<br /><br /><br />Description<br /><br />At a minimum, a <see cref="Translation">Translation</see> or a <see cref="Rotation">Rotation</see> <b>MUST</b> be defined for a <see cref="Transformation">Transformation</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579103900791_417826_16362">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class TransformationClass : IClass
	{
		/// <summary>Constant value for <see cref="TransformationClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579103900791_417826_16362";
		/// <summary>Constant value for <see cref="TransformationClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579103900791_417826_16362";
		/// <summary>Constant value for <see cref="TransformationClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;process of transforming to the origin position of the coordinate system from a parent coordinate system using {{block(Translation)}} and {{block(Rotation)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;At a minimum, a {{block(Translation)}} or a {{block(Rotation)}} **MUST** be defined for a {{block(Transformation)}}.&#10;
";
		/// <summary>Constant value for <see cref="TransformationClass.Name" /></summary>
		public const string NAME = "Transformation";
		/// <summary>Constant value for <see cref="TransformationClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="TransformationClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="TransformationClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.6";
		/// <summary>Constant value for <see cref="TransformationClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new TransformationClassProperties Properties { get; } = new TransformationClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="TransformationClass" />.
		/// </summary>
		public class TransformationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				HasTranslationPart,
				HasRotationPart,
			};
			/// <summary>
			/// <inheritdoc cref="HasTranslationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasTranslation</remarks>
			/// </summary>
			public HasTranslationPartProperty HasTranslationPart { get; } = new HasTranslationPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasTranslationPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.Name" /></summary>
				public const string NAME = "hasTranslation";
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Translation";
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasTranslationPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AbstractTranslationClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems.AbstractTranslationClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="HasRotationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasRotation</remarks>
			/// </summary>
			public HasRotationPartProperty HasRotationPart { get; } = new HasRotationPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasRotationPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasRotationPartProperty.Name" /></summary>
				public const string NAME = "hasRotation";
				/// <summary>Constant value for <see cref="HasRotationPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasRotationPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasRotationPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasRotationPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasRotationPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasRotationPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasRotationPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasRotationPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Rotation";
				/// <summary>Constant value for <see cref="HasRotationPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasRotationPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AbstractRotationClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems.AbstractRotationClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="TransformationClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			Transform,
		};
		/// <summary>
		/// Transform
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Transform => @"val:TransformationMustHaveRotationOrTranslation
    a sh:NodeShape ;
    sh:message ""`Transformation` MUST have at least one of `Rotation` or `Translation` defined, and neither can be multiply defined."" ;
    sh:targetClass mt:Transformation ;

    sh:property [
        sh:path mt:hasRotation ;
        sh:maxCount 1 ;
        sh:class mt:Rotation ;
    ] ;
    sh:property [
        sh:path mt:hasTranslation ;
        sh:maxCount 1 ;
        sh:class mt:Translation ;
    ] ;

    sh:or (
        [ sh:property [
            sh:path mt:hasRotation ;
            sh:minCount 1 ;
        ] ]
        [ sh:property [
            sh:path mt:hasTranslation ;
            sh:minCount 1 ;
        ] ]
    ) .";
		/*
		val:TransformationMustHaveRotationOrTranslation
		    a sh:NodeShape ;
		    sh:message "`Transformation` MUST have at least one of `Rotation` or `Translation` defined, and neither can be multiply defined." ;
		    sh:targetClass mt:Transformation ;
		
		    sh:property [
		        sh:path mt:hasRotation ;
		        sh:maxCount 1 ;
		        sh:class mt:Rotation ;
		    ] ;
		    sh:property [
		        sh:path mt:hasTranslation ;
		        sh:maxCount 1 ;
		        sh:class mt:Translation ;
		    ] ;
		
		    sh:or (
		        [ sh:property [
		            sh:path mt:hasRotation ;
		            sh:minCount 1 ;
		        ] ]
		        [ sh:property [
		            sh:path mt:hasTranslation ;
		            sh:minCount 1 ;
		        ] ]
		    ) .
		*/
		# endregion
	}
}