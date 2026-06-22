#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorTypes
{
	/// <summary>﻿property of the <i>HTTP Request</i> that modifies the information returned by the <i>HTTP Request</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1744716058059_95687_23361">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class QueryParameterClass : IClass
	{
		/// <summary>Constant value for <see cref="QueryParameterClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744716058059_95687_23361";
		/// <summary>Constant value for <see cref="QueryParameterClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1744716058059_95687_23361";
		/// <summary>Constant value for <see cref="QueryParameterClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;property of the {{term(HTTP Request)}} that modifies the information returned by the {{term(HTTP Request)}}.&#10;
";
		/// <summary>Constant value for <see cref="QueryParameterClass.Name" /></summary>
		public const string NAME = "QueryParameter";
		/// <summary>Constant value for <see cref="QueryParameterClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="QueryParameterClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="QueryParameterClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="QueryParameterClass.DeprecatedVersion" /></summary>
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
		public new QueryParameterClassProperties Properties { get; } = new QueryParameterClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="QueryParameterClass" />.
		/// </summary>
		public class QueryParameterClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Name,
				Maximum,
				Minimum,
				Value,
				Type,
				Format,
			};
			/// <summary>
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿name of the parameter.<br /><br /><br />
			/// </summary>
			public sealed class NameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NameProperty.Name" /></summary>
				public const string NAME = "name";
				/// <summary>Constant value for <see cref="NameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;name of the parameter.&#10;
";
				/// <summary>Constant value for <see cref="NameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="NameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.6";
				/// <summary>Constant value for <see cref="NameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="NameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x;MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="NameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NameProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="NameProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: QueryParameterEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.QueryParameterEnumMetaClass);
				
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
			/// <inheritdoc cref="MaximumProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Maximum</remarks>
			/// </summary>
			public MaximumProperty Maximum { get; } = new MaximumProperty();
			
			/// <summary>﻿maximum allowed value.<br /><br /><br />
			/// </summary>
			public sealed class MaximumProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MaximumProperty.Name" /></summary>
				public const string NAME = "Maximum";
				/// <summary>Constant value for <see cref="MaximumProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;maximum allowed value.&#10;
";
				/// <summary>Constant value for <see cref="MaximumProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="MaximumProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MaximumProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.6";
				/// <summary>Constant value for <see cref="MaximumProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MaximumProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MaximumProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="MaximumProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MaximumProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="MaximumProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Double </remarks>
				/// </summary>
				public System.Type Type => typeof(Double);
				
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
			/// <inheritdoc cref="MinimumProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Minimum</remarks>
			/// </summary>
			public MinimumProperty Minimum { get; } = new MinimumProperty();
			
			/// <summary>﻿minimal allowed value.<br /><br /><br />
			/// </summary>
			public sealed class MinimumProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MinimumProperty.Name" /></summary>
				public const string NAME = "Minimum";
				/// <summary>Constant value for <see cref="MinimumProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;minimal allowed value.&#10;
";
				/// <summary>Constant value for <see cref="MinimumProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="MinimumProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MinimumProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.6";
				/// <summary>Constant value for <see cref="MinimumProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MinimumProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MinimumProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="MinimumProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MinimumProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="MinimumProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Double </remarks>
				/// </summary>
				public System.Type Type => typeof(Double);
				
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
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			
			/// <summary>﻿given value.<br /><br /><br />
			/// </summary>
			public sealed class ValueProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ValueProperty.Name" /></summary>
				public const string NAME = "Value";
				/// <summary>Constant value for <see cref="ValueProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;given value.&#10;
";
				/// <summary>Constant value for <see cref="ValueProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="ValueProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ValueProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.6";
				/// <summary>Constant value for <see cref="ValueProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ValueProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ValueProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="ValueProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ValueProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="ValueProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿expected datatype of the parameter.<br /><br /><br />
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TypeProperty.Name" /></summary>
				public const string NAME = "Type";
				/// <summary>Constant value for <see cref="TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;expected datatype of the parameter.&#10;
";
				/// <summary>Constant value for <see cref="TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.6";
				/// <summary>Constant value for <see cref="TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="TypeProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="FormatProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Format</remarks>
			/// </summary>
			public FormatProperty Format { get; } = new FormatProperty();
			
			/// <summary>﻿expected datatype format of the parameter.<br /><br /><br />
			/// </summary>
			public sealed class FormatProperty : IProperty
			{
				/// <summary>Constant value for <see cref="FormatProperty.Name" /></summary>
				public const string NAME = "Format";
				/// <summary>Constant value for <see cref="FormatProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;expected datatype format of the parameter.&#10;
";
				/// <summary>Constant value for <see cref="FormatProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="FormatProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="FormatProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.6";
				/// <summary>Constant value for <see cref="FormatProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="FormatProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="FormatProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="FormatProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="FormatProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="FormatProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
		/// List of constraint rules for <see cref="QueryParameterClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
