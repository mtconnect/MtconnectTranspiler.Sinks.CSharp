#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.DataItems
{
	/// <summary>﻿information reported about a piece of equipment.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DataItemClass : IClass
	{
		/// <summary>Constant value for <see cref="DataItemClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A";
		/// <summary>Constant value for <see cref="DataItemClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A";
		/// <summary>Constant value for <see cref="DataItemClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;information reported about a piece of equipment.&#10;
";
		/// <summary>Constant value for <see cref="DataItemClass.Name" /></summary>
		public const string NAME = "DataItem";
		/// <summary>Constant value for <see cref="DataItemClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DataItemClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DataItemClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="DataItemClass.DeprecatedVersion" /></summary>
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
		public new DataItemClassProperties Properties { get; } = new DataItemClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DataItemClass" />.
		/// </summary>
		public class DataItemClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Category,
				CompositionId,
				CoordinateSystem,
				Discrete,
				Id,
				Name,
				NativeScale,
				NativeUnits,
				SampleRate,
				SignificantDigits,
				Statistic,
				SubType,
				Type,
				Units,
				IsObservedByPart,
				Representation,
				HasSourcePart,
				HasConstraintPart,
				HasFilterPart,
				HasInitialValuePart,
				HasResetTriggerPart,
				HasObservationPart,
				HasDefinitionPart,
				CoordinateSystemIdRef,
				HasRelationshipPart,
			};
			/// <summary>
			/// <inheritdoc cref="CategoryProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Category</remarks>
			/// </summary>
			public CategoryProperty Category { get; } = new CategoryProperty();
			
			/// <summary>﻿specifies the kind of information provided by a data item.<br /><br /><br />
			/// </summary>
			public sealed class CategoryProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CategoryProperty.Name" /></summary>
				public const string NAME = "category";
				/// <summary>Constant value for <see cref="CategoryProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;specifies the kind of information provided by a data item.&#10;
";
				/// <summary>Constant value for <see cref="CategoryProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CategoryProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CategoryProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="CategoryProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CategoryProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CategoryProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CategoryProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CategoryProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CategoryEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CategoryEnumMetaClass);
				
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
			/// <inheritdoc cref="CompositionIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CompositionId</remarks>
			/// </summary>
			public CompositionIdProperty CompositionId { get; } = new CompositionIdProperty();
			
			/// <summary>﻿identifier attribute of the <see cref="Composition">Composition</see> that the reported data is most closely associated.<br /><br /><br />
			/// </summary>
			public sealed class CompositionIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CompositionIdProperty.Name" /></summary>
				public const string NAME = "compositionId";
				/// <summary>Constant value for <see cref="CompositionIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier attribute of the {{block(Composition)}} that the reported data is most closely associated.&#10;
";
				/// <summary>Constant value for <see cref="CompositionIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CompositionIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CompositionIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.4";
				/// <summary>Constant value for <see cref="CompositionIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CompositionIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CompositionIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CompositionIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CompositionIdProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="CoordinateSystemProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CoordinateSystem</remarks>
			/// </summary>
			public CoordinateSystemProperty CoordinateSystem { get; } = new CoordinateSystemProperty();
			
			/// <summary>﻿for measured values relative to a coordinate system like <see cref="Position">Position</see>, the coordinate system used may be reported.<br /><br /><b>DEPRECATED</b> in <i>Version 2.0</i>. Replaced by <see cref="Component.coordinateSystemIdRef">coordinateSystemIdRef in Component</see>. <br /><br /><br />
			/// </summary>
			public sealed class CoordinateSystemProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CoordinateSystemProperty.Name" /></summary>
				public const string NAME = "coordinateSystem";
				/// <summary>Constant value for <see cref="CoordinateSystemProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;for measured values relative to a coordinate system like {{block(Position)}}, the coordinate system used may be reported.

**DEPRECATED** in *Version 2.0*. Replaced by {{property(Component::coordinateSystemIdRef)}}. &#10;
";
				/// <summary>Constant value for <see cref="CoordinateSystemProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CoordinateSystemProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CoordinateSystemProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="CoordinateSystemProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "2.0";
				/// <summary>Constant value for <see cref="CoordinateSystemProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CoordinateSystemProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CoordinateSystemProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CoordinateSystemProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CoordinateSystemEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CoordinateSystemEnumMetaClass);
				
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
			/// <inheritdoc cref="DiscreteProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Discrete</remarks>
			/// </summary>
			public DiscreteProperty Discrete { get; } = new DiscreteProperty();
			
			/// <summary>﻿indication signifying whether each value reported for the <i>Observation</i> is significant and whether duplicate values are to be suppressed.<br /><br />If a value is not defined for <see cref="DataItem.discrete">discrete in DataItem</see>, the default value <b>MUST</b> be <c>false</c>.<br /><br /><br />
			/// </summary>
			public sealed class DiscreteProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DiscreteProperty.Name" /></summary>
				public const string NAME = "discrete";
				/// <summary>Constant value for <see cref="DiscreteProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;indication signifying whether each value reported for the {{term(Observation)}} is significant and whether duplicate values are to be suppressed.

If a value is not defined for {{property(DataItem::discrete)}}, the default value **MUST** be `false`.&#10;
";
				/// <summary>Constant value for <see cref="DiscreteProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="DiscreteProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DiscreteProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.5";
				/// <summary>Constant value for <see cref="DiscreteProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DiscreteProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="DiscreteProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DiscreteProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DiscreteProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Boolean </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
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
			
			/// <summary>﻿unique identifier for this data item.<br /><br /><br />
			/// </summary>
			public sealed class IdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IdProperty.Name" /></summary>
				public const string NAME = "id";
				/// <summary>Constant value for <see cref="IdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;unique identifier for this data item.&#10;
";
				/// <summary>Constant value for <see cref="IdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="IdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="IdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
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
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿name of the data item.<br /><br /><br />
			/// </summary>
			public sealed class NameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NameProperty.Name" /></summary>
				public const string NAME = "name";
				/// <summary>Constant value for <see cref="NameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;name of the data item.&#10;
";
				/// <summary>Constant value for <see cref="NameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="NameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="NameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="NameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NameProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="NativeScaleProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeScale</remarks>
			/// </summary>
			public NativeScaleProperty NativeScale { get; } = new NativeScaleProperty();
			
			/// <summary>﻿used to convert the reported value to represent the original measured value.<br /><br /><br />
			/// </summary>
			public sealed class NativeScaleProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NativeScaleProperty.Name" /></summary>
				public const string NAME = "nativeScale";
				/// <summary>Constant value for <see cref="NativeScaleProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;used to convert the reported value to represent the original measured value.&#10;
";
				/// <summary>Constant value for <see cref="NativeScaleProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NativeScaleProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NativeScaleProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="NativeScaleProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NativeScaleProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="NativeScaleProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="NativeScaleProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NativeScaleProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="NativeUnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeUnits</remarks>
			/// </summary>
			public NativeUnitsProperty NativeUnits { get; } = new NativeUnitsProperty();
			
			/// <summary>﻿native units of measurement for the reported value of the data item.<br /><br /><br />
			/// </summary>
			public sealed class NativeUnitsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NativeUnitsProperty.Name" /></summary>
				public const string NAME = "nativeUnits";
				/// <summary>Constant value for <see cref="NativeUnitsProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;native units of measurement for the reported value of the data item.&#10;
";
				/// <summary>Constant value for <see cref="NativeUnitsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NativeUnitsProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NativeUnitsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="NativeUnitsProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NativeUnitsProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="NativeUnitsProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="NativeUnitsProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NativeUnitsProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: NativeUnitEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.NativeUnitEnumMetaClass);
				
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
			/// <inheritdoc cref="SampleRateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SampleRate</remarks>
			/// </summary>
			public SampleRateProperty SampleRate { get; } = new SampleRateProperty();
			
			/// <summary>﻿rate at which successive samples of a data item are recorded by a piece of equipment.<br /><br /><br />
			/// </summary>
			public sealed class SampleRateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SampleRateProperty.Name" /></summary>
				public const string NAME = "sampleRate";
				/// <summary>Constant value for <see cref="SampleRateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;rate at which successive samples of a data item are recorded by a piece of equipment.&#10;
";
				/// <summary>Constant value for <see cref="SampleRateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SampleRateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="SampleRateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SampleRateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="SignificantDigitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SignificantDigits</remarks>
			/// </summary>
			public SignificantDigitsProperty SignificantDigits { get; } = new SignificantDigitsProperty();
			
			/// <summary>﻿number of significant digits in the reported value.<br /><br /><br />
			/// </summary>
			public sealed class SignificantDigitsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SignificantDigitsProperty.Name" /></summary>
				public const string NAME = "significantDigits";
				/// <summary>Constant value for <see cref="SignificantDigitsProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;number of significant digits in the reported value.&#10;
";
				/// <summary>Constant value for <see cref="SignificantDigitsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SignificantDigitsProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SignificantDigitsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="SignificantDigitsProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SignificantDigitsProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SignificantDigitsProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SignificantDigitsProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SignificantDigitsProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="StatisticProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Statistic</remarks>
			/// </summary>
			public StatisticProperty Statistic { get; } = new StatisticProperty();
			
			/// <summary>﻿type of statistical calculation performed on a series of data samples to provide the reported data value.<br /><br /><br />
			/// </summary>
			public sealed class StatisticProperty : IProperty
			{
				/// <summary>Constant value for <see cref="StatisticProperty.Name" /></summary>
				public const string NAME = "statistic";
				/// <summary>Constant value for <see cref="StatisticProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;type of statistical calculation performed on a series of data samples to provide the reported data value.&#10;
";
				/// <summary>Constant value for <see cref="StatisticProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="StatisticProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="StatisticProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="StatisticProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="StatisticProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="StatisticProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="StatisticProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="StatisticProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: StatisticEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.StatisticEnumMetaClass);
				
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
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			
			/// <summary>﻿sub-categorization of the <see cref="DataItem.type">type in DataItem</see>.<br /><br /><br />
			/// </summary>
			public sealed class SubTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SubTypeProperty.Name" /></summary>
				public const string NAME = "subType";
				/// <summary>Constant value for <see cref="SubTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;sub-categorization of the {{property(DataItem::type)}}.&#10;
";
				/// <summary>Constant value for <see cref="SubTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SubTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="SubTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SubTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DataItemSubTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnumMetaClass);
				
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
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿type of data being measured. See <see cref="DataItem Types">DataItem Types</see>.<br /><br /><br />
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TypeProperty.Name" /></summary>
				public const string NAME = "type";
				/// <summary>Constant value for <see cref="TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;type of data being measured. See {{package(DataItem Types)}}.&#10;
";
				/// <summary>Constant value for <see cref="TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DataItemTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemTypeEnumMetaClass);
				
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
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public UnitsProperty Units { get; } = new UnitsProperty();
			
			/// <summary>﻿unit of measurement for the reported value of the data item.<br /><br /><br />
			/// </summary>
			public sealed class UnitsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UnitsProperty.Name" /></summary>
				public const string NAME = "units";
				/// <summary>Constant value for <see cref="UnitsProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;unit of measurement for the reported value of the data item.&#10;
";
				/// <summary>Constant value for <see cref="UnitsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UnitsProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="UnitsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="UnitsProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="UnitsProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UnitEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnumMetaClass);
				
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
			/// <inheritdoc cref="IsObservedByPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsObservedBy</remarks>
			/// </summary>
			public IsObservedByPartProperty IsObservedByPart { get; } = new IsObservedByPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class IsObservedByPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IsObservedByPartProperty.Name" /></summary>
				public const string NAME = "isObservedBy";
				/// <summary>Constant value for <see cref="IsObservedByPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="IsObservedByPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="IsObservedByPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IsObservedByPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="IsObservedByPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IsObservedByPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="IsObservedByPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="IsObservedByPartProperty.Association" /></summary>
				public const string ASSOCIATION = "DataItems";
				/// <summary>Constant value for <see cref="IsObservedByPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ComponentGeneralization </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);
				
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
			/// <inheritdoc cref="RepresentationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Representation</remarks>
			/// </summary>
			public RepresentationProperty Representation { get; } = new RepresentationProperty();
			
			/// <summary>﻿description of a means to interpret data consisting of multiple data points or samples reported as a single value.  <br /><br />If <see cref="DataItem.representation">representation in DataItem</see> is not specified, it <b>MUST</b> be determined to be <c>VALUE</c>.<br /><br /><br /><br />
			/// </summary>
			public sealed class RepresentationProperty : IProperty
			{
				/// <summary>Constant value for <see cref="RepresentationProperty.Name" /></summary>
				public const string NAME = "representation";
				/// <summary>Constant value for <see cref="RepresentationProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;description of a means to interpret data consisting of multiple data points or samples reported as a single value.  

If {{property(DataItem::representation)}} is not specified, it **MUST** be determined to be `VALUE`.
&#10;
";
				/// <summary>Constant value for <see cref="RepresentationProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="RepresentationProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="RepresentationProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="RepresentationProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="RepresentationProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="RepresentationProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="RepresentationProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="RepresentationProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: RepresentationEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.RepresentationEnumMetaClass);
				
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
			/// <inheritdoc cref="HasSourcePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasSource</remarks>
			/// </summary>
			public HasSourcePartProperty HasSourcePart { get; } = new HasSourcePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasSourcePartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasSourcePartProperty.Name" /></summary>
				public const string NAME = "hasSource";
				/// <summary>Constant value for <see cref="HasSourcePartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasSourcePartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasSourcePartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasSourcePartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasSourcePartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasSourcePartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasSourcePartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasSourcePartProperty.Association" /></summary>
				public const string ASSOCIATION = "Source";
				/// <summary>Constant value for <see cref="HasSourcePartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: SourceClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.SourceClass);
				
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
			/// <inheritdoc cref="HasConstraintPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasConstraint</remarks>
			/// </summary>
			public HasConstraintPartProperty HasConstraintPart { get; } = new HasConstraintPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasConstraintPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasConstraintPartProperty.Name" /></summary>
				public const string NAME = "hasConstraint";
				/// <summary>Constant value for <see cref="HasConstraintPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasConstraintPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasConstraintPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasConstraintPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasConstraintPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasConstraintPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasConstraintPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasConstraintPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Constraints";
				/// <summary>Constant value for <see cref="HasConstraintPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ConstraintsClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.ConstraintsClass);
				
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
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasFilterPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Filters";
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
			/// <summary>
			/// <inheritdoc cref="HasInitialValuePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasInitialValue</remarks>
			/// </summary>
			public HasInitialValuePartProperty HasInitialValuePart { get; } = new HasInitialValuePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasInitialValuePartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasInitialValuePartProperty.Name" /></summary>
				public const string NAME = "hasInitialValue";
				/// <summary>Constant value for <see cref="HasInitialValuePartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasInitialValuePartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasInitialValuePartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasInitialValuePartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasInitialValuePartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasInitialValuePartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasInitialValuePartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasInitialValuePartProperty.Association" /></summary>
				public const string ASSOCIATION = "InitialValue";
				/// <summary>Constant value for <see cref="HasInitialValuePartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: InitialValueClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.InitialValueClass);
				
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
			/// <inheritdoc cref="HasResetTriggerPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasResetTrigger</remarks>
			/// </summary>
			public HasResetTriggerPartProperty HasResetTriggerPart { get; } = new HasResetTriggerPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasResetTriggerPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasResetTriggerPartProperty.Name" /></summary>
				public const string NAME = "hasResetTrigger";
				/// <summary>Constant value for <see cref="HasResetTriggerPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasResetTriggerPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasResetTriggerPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasResetTriggerPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasResetTriggerPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasResetTriggerPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasResetTriggerPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasResetTriggerPartProperty.Association" /></summary>
				public const string ASSOCIATION = "ResetTrigger";
				/// <summary>Constant value for <see cref="HasResetTriggerPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ResetTriggerClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.ResetTriggerClass);
				
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
			/// <inheritdoc cref="HasObservationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasObservation</remarks>
			/// </summary>
			public HasObservationPartProperty HasObservationPart { get; } = new HasObservationPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasObservationPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Name" /></summary>
				public const string NAME = "hasObservation";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "shared";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Observations";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ObservationGeneralization </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationGeneralization);
				
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
			/// <inheritdoc cref="HasDefinitionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDefinition</remarks>
			/// </summary>
			public HasDefinitionPartProperty HasDefinitionPart { get; } = new HasDefinitionPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasDefinitionPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasDefinitionPartProperty.Name" /></summary>
				public const string NAME = "hasDefinition";
				/// <summary>Constant value for <see cref="HasDefinitionPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasDefinitionPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasDefinitionPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasDefinitionPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasDefinitionPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasDefinitionPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasDefinitionPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasDefinitionPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Definition";
				/// <summary>Constant value for <see cref="HasDefinitionPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DefinitionClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.DefinitionClass);
				
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
			/// <inheritdoc cref="CoordinateSystemIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CoordinateSystemIdRef</remarks>
			/// </summary>
			public CoordinateSystemIdRefProperty CoordinateSystemIdRef { get; } = new CoordinateSystemIdRefProperty();
			
			/// <summary>﻿associated <see cref="CoordinateSystem">CoordinateSystem</see> context for the <see cref="DataItem">DataItem</see>.<br /><br /><br />
			/// </summary>
			public sealed class CoordinateSystemIdRefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Name" /></summary>
				public const string NAME = "coordinateSystemIdRef";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;associated {{block(CoordinateSystem)}} context for the {{block(DataItem)}}.&#10;
";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.5";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="HasRelationshipPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasRelationship</remarks>
			/// </summary>
			public HasRelationshipPartProperty HasRelationshipPart { get; } = new HasRelationshipPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasRelationshipPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasRelationshipPartProperty.Name" /></summary>
				public const string NAME = "hasRelationship";
				/// <summary>Constant value for <see cref="HasRelationshipPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasRelationshipPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasRelationshipPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasRelationshipPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasRelationshipPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasRelationshipPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasRelationshipPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasRelationshipPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Relationships";
				/// <summary>Constant value for <see cref="HasRelationshipPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AbstractDataItemRelationshipClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem.AbstractDataItemRelationshipClass);
				
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

		# region Rules
		/// <summary>
		/// Dataitem1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Dataitem1 => @"id->size() = 1 and
(self.oclAsType(DataItems::""DataItem Types""::Event).type->size() = 1 or
self.oclAsType(DataItems::""DataItem Types""::Sample).type->size() = 1 or
self.oclAsType(DataItems::""DataItem Types""::Condition).type->size() = 1
) and
(self.oclAsType(DataItems::""DataItem Types""::Event).category->size() = 1 or
self.oclAsType(DataItems::""DataItem Types""::Sample).category->size() = 1 or
self.oclAsType(DataItems::""DataItem Types""::Condition).category->size() = 1
)";
		/*
		id->size() = 1 and
		(self.oclAsType(DataItems::"DataItem Types"::Event).type->size() = 1 or
		self.oclAsType(DataItems::"DataItem Types"::Sample).type->size() = 1 or
		self.oclAsType(DataItems::"DataItem Types"::Condition).type->size() = 1
		) and
		(self.oclAsType(DataItems::"DataItem Types"::Event).category->size() = 1 or
		self.oclAsType(DataItems::"DataItem Types"::Sample).category->size() = 1 or
		self.oclAsType(DataItems::"DataItem Types"::Condition).category->size() = 1
		)
		*/
		/// <summary>
		/// Dataitem2
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Dataitem2 => @"self.oclAsType(DataItems::""DataItem Types""::Event).category = DataTypes::CategoryEnum::EVENT or 
self.oclAsType(DataItems::""DataItem Types""::Sample).category =  DataTypes::CategoryEnum::SAMPLE or
self.oclAsType(DataItems::""DataItem Types""::Condition).category =  DataTypes::CategoryEnum::CONDITION";
		/*
		self.oclAsType(DataItems::"DataItem Types"::Event).category = DataTypes::CategoryEnum::EVENT or 
		self.oclAsType(DataItems::"DataItem Types"::Sample).category =  DataTypes::CategoryEnum::SAMPLE or
		self.oclAsType(DataItems::"DataItem Types"::Condition).category =  DataTypes::CategoryEnum::CONDITION
		*/
		# endregion
	}
}