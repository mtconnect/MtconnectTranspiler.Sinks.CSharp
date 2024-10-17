#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1727808122960_76782_23993">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class OriginDataSetGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="OriginDataSetGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727808122960_76782_23993";
		/// <summary>Constant value for <see cref="OriginDataSetGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1727808122960_76782_23993";
		/// <summary>Constant value for <see cref="OriginDataSetGeneralization.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="OriginDataSetGeneralization.Name" /></summary>
		public const string NAME = "OriginDataSet";
		/// <summary>Constant value for <see cref="OriginDataSetGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="OriginDataSetGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="OriginDataSetGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.5";
		/// <summary>Constant value for <see cref="OriginDataSetGeneralization.DeprecatedVersion" /></summary>
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
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579566531114_503405_25727
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.DataSetClass);

		/// <inheritdoc />
		public new OriginDataSetGeneralizationProperties Properties { get; } = new OriginDataSetGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="OriginDataSetGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties" />.
		/// </summary>
		public class OriginDataSetGeneralizationProperties : Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				X,
				Y,
				Z,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="XProperty" path="/summary" /><br/>
			/// <remarks>Original Name: X</remarks>
			/// </summary>
			public new XProperty X { get; } = new XProperty();
			
			/// <summary>﻿x-coordinate.<br /><br /><br />
			/// </summary>
			public new sealed class XProperty : IProperty
			{
				/// <summary>Constant value for <see cref="XProperty.Name" /></summary>
				public const string NAME = "X";
				/// <summary>Constant value for <see cref="XProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;x-coordinate.&#10;
";
				/// <summary>Constant value for <see cref="XProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="XProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="XProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="XProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="XProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="XProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="XProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="XProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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
			}
			/// <summary>
			/// <inheritdoc cref="YProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Y</remarks>
			/// </summary>
			public new YProperty Y { get; } = new YProperty();
			
			/// <summary>﻿y-coordinate.<br /><br /><br />
			/// </summary>
			public new sealed class YProperty : IProperty
			{
				/// <summary>Constant value for <see cref="YProperty.Name" /></summary>
				public const string NAME = "Y";
				/// <summary>Constant value for <see cref="YProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;y-coordinate.&#10;
";
				/// <summary>Constant value for <see cref="YProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="YProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="YProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="YProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="YProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="YProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="YProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="YProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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
			}
			/// <summary>
			/// <inheritdoc cref="ZProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Z</remarks>
			/// </summary>
			public new ZProperty Z { get; } = new ZProperty();
			
			/// <summary>﻿x-coordinate.<br /><br /><br />
			/// </summary>
			public new sealed class ZProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ZProperty.Name" /></summary>
				public const string NAME = "Z";
				/// <summary>Constant value for <see cref="ZProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;x-coordinate.&#10;
";
				/// <summary>Constant value for <see cref="ZProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ZProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ZProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="ZProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ZProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ZProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ZProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ZProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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
			}
		};

	}
}