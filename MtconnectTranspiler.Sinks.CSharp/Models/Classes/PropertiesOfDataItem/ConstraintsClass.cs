#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>﻿<i>organize</i>s a set of expected values that can be reported for a <see cref="DataItem">DataItem</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_E6F955EB_46CA_4c72_B547_8F4465A9620A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ConstraintsClass : IClass
	{
		/// <summary>Constant value for <see cref="ConstraintsClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_E6F955EB_46CA_4c72_B547_8F4465A9620A";
		/// <summary>Constant value for <see cref="ConstraintsClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_E6F955EB_46CA_4c72_B547_8F4465A9620A";
		/// <summary>Constant value for <see cref="ConstraintsClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{termplural(organize)}} a set of expected values that can be reported for a {{block(DataItem)}}.&#10;
";
		/// <summary>Constant value for <see cref="ConstraintsClass.Name" /></summary>
		public const string NAME = "Constraints";
		/// <summary>Constant value for <see cref="ConstraintsClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ConstraintsClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ConstraintsClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="ConstraintsClass.DeprecatedVersion" /></summary>
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
		public new ConstraintsClassProperties Properties { get; } = new ConstraintsClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ConstraintsClass" />.
		/// </summary>
		public class ConstraintsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Maximum,
				Minimum,
				Nominal,
				Value,
				HasFilterPart,
			};
			/// <summary>
			/// <inheritdoc cref="MaximumProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Maximum</remarks>
			/// </summary>
			public MaximumProperty Maximum { get; } = new MaximumProperty();
			
			/// <summary>﻿numeric upper constraint.<br /><br /><br />If the data reported for a data item is a range of numeric values, the expected value reported <b>MAY</b> be described with an upper limit defined by this constraint.<br /><br /><br />
			/// </summary>
			public sealed class MaximumProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MaximumProperty.Name" /></summary>
				public const string NAME = "Maximum";
				/// <summary>Constant value for <see cref="MaximumProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;numeric upper constraint.

If the data reported for a data item is a range of numeric values, the expected value reported **MAY** be described with an upper limit defined by this constraint.&#10;
";
				/// <summary>Constant value for <see cref="MaximumProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="MaximumProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MaximumProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.1";
				/// <summary>Constant value for <see cref="MaximumProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MaximumProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="MaximumProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MaximumProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MaximumProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="MinimumProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Minimum</remarks>
			/// </summary>
			public MinimumProperty Minimum { get; } = new MinimumProperty();
			
			/// <summary>﻿numeric lower constraint.<br /><br />If the data reported for a data item is a range of numeric values, the expected value reported <b>MAY</b> be described with a lower limit defined by this constraint.<br /><br /><br />
			/// </summary>
			public sealed class MinimumProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MinimumProperty.Name" /></summary>
				public const string NAME = "Minimum";
				/// <summary>Constant value for <see cref="MinimumProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;numeric lower constraint.

If the data reported for a data item is a range of numeric values, the expected value reported **MAY** be described with a lower limit defined by this constraint.&#10;
";
				/// <summary>Constant value for <see cref="MinimumProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="MinimumProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MinimumProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.1";
				/// <summary>Constant value for <see cref="MinimumProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MinimumProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="MinimumProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MinimumProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MinimumProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="NominalProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Nominal</remarks>
			/// </summary>
			public NominalProperty Nominal { get; } = new NominalProperty();
			
			/// <summary>﻿numeric target or expected value.<br /><br /><br />
			/// </summary>
			public sealed class NominalProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NominalProperty.Name" /></summary>
				public const string NAME = "Nominal";
				/// <summary>Constant value for <see cref="NominalProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;numeric target or expected value.&#10;
";
				/// <summary>Constant value for <see cref="NominalProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NominalProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NominalProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.4";
				/// <summary>Constant value for <see cref="NominalProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NominalProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="NominalProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="NominalProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NominalProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			
			/// <summary>﻿single data value that is expected to be reported for a <see cref="DataItem">DataItem</see>.<br /><br /><see cref="Constraints.Value">Value in Constraints</see> <b>MUST NOT</b> be used in conjunction with any other <see cref="Constraint">Constraint</see> elements.<br /><br /><br />
			/// </summary>
			public sealed class ValueProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ValueProperty.Name" /></summary>
				public const string NAME = "Value";
				/// <summary>Constant value for <see cref="ValueProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;single data value that is expected to be reported for a {{block(DataItem)}}.

{{property(Constraints::Value)}} **MUST NOT** be used in conjunction with any other {{block(Constraint)}} elements.&#10;
";
				/// <summary>Constant value for <see cref="ValueProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ValueProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ValueProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.1";
				/// <summary>Constant value for <see cref="ValueProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ValueProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="ValueProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="ValueProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ValueProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasFilterPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasFilter</remarks>
			/// </summary>
			public HasFilterPartProperty HasFilterPart { get; } = new HasFilterPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasFilterPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasFilterPartProperty.Name" /></summary>
				public const string NAME = "hasFilter";
				/// <summary>Constant value for <see cref="HasFilterPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasFilterPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasFilterPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasFilterPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasFilterPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasFilterPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasFilterPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasFilterPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Filter";
				/// <summary>Constant value for <see cref="HasFilterPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: FilterClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.FilterClass);
				
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