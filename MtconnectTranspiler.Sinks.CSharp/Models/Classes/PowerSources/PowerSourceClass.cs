#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.PowerSources
{
	/// <summary>﻿potential energy sources for the <see cref="Component">Component</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1696870815347_556704_3251">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PowerSourceClass : IClass
	{
		/// <summary>Constant value for <see cref="PowerSourceClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1696870815347_556704_3251";
		/// <summary>Constant value for <see cref="PowerSourceClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1696870815347_556704_3251";
		/// <summary>Constant value for <see cref="PowerSourceClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;potential energy sources for the {{block(Component)}}.&#10;
";
		/// <summary>Constant value for <see cref="PowerSourceClass.Name" /></summary>
		public const string NAME = "PowerSource";
		/// <summary>Constant value for <see cref="PowerSourceClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="PowerSourceClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="PowerSourceClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.3";
		/// <summary>Constant value for <see cref="PowerSourceClass.DeprecatedVersion" /></summary>
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
		public new PowerSourceClassProperties Properties { get; } = new PowerSourceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="PowerSourceClass" />.
		/// </summary>
		public class PowerSourceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Type,
				Id,
				ComponentIdRef,
				Order,
				Value,
			};
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿type of the power source.<br /><br /><br />
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TypeProperty.Name" /></summary>
				public const string NAME = "type";
				/// <summary>Constant value for <see cref="TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;type of the power source.&#10;
";
				/// <summary>Constant value for <see cref="TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PowerSourceTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.PowerSourceTypeEnumMetaClass);
				
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
			/// <inheritdoc cref="IdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Id</remarks>
			/// </summary>
			public IdProperty Id { get; } = new IdProperty();
			
			/// <summary>﻿unique identifier for the power source.<br /><br /><br />
			/// </summary>
			public sealed class IdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IdProperty.Name" /></summary>
				public const string NAME = "id";
				/// <summary>Constant value for <see cref="IdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;unique identifier for the power source.&#10;
";
				/// <summary>Constant value for <see cref="IdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="IdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="IdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="IdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="IdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="IdProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="ComponentIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ComponentIdRef</remarks>
			/// </summary>
			public ComponentIdRefProperty ComponentIdRef { get; } = new ComponentIdRefProperty();
			
			/// <summary>﻿reference to the <see cref="Component">Component</see> providing observations about the power source.<br /><br /><br />
			/// </summary>
			public sealed class ComponentIdRefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ComponentIdRefProperty.Name" /></summary>
				public const string NAME = "componentIdRef";
				/// <summary>Constant value for <see cref="ComponentIdRefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;reference to the {{block(Component)}} providing observations about the power source.&#10;
";
				/// <summary>Constant value for <see cref="ComponentIdRefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ComponentIdRefProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ComponentIdRefProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="ComponentIdRefProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ComponentIdRefProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ComponentIdRefProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ComponentIdRefProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ComponentIdRefProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="OrderProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Order</remarks>
			/// </summary>
			public OrderProperty Order { get; } = new OrderProperty();
			
			/// <summary>﻿optional precedence for a given power source.<br /><br /><br />
			/// </summary>
			public sealed class OrderProperty : IProperty
			{
				/// <summary>Constant value for <see cref="OrderProperty.Name" /></summary>
				public const string NAME = "order";
				/// <summary>Constant value for <see cref="OrderProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;optional precedence for a given power source.&#10;
";
				/// <summary>Constant value for <see cref="OrderProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="OrderProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="OrderProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="OrderProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="OrderProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="OrderProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="OrderProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="OrderProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Int32 </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
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
			
			/// <summary>﻿name of the power source.<br /><br /><br />
			/// </summary>
			public sealed class ValueProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ValueProperty.Name" /></summary>
				public const string NAME = "value";
				/// <summary>Constant value for <see cref="ValueProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;name of the power source.&#10;
";
				/// <summary>Constant value for <see cref="ValueProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ValueProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ValueProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="ValueProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ValueProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ValueProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
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
		};

	}
}