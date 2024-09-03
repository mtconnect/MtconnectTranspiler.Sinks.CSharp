#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.References
{
	/// <summary>﻿pointer to information that is associated with another entity defined elsewhere in the <see cref="MTConnectDevices">MTConnectDevices</see> entity for a piece of equipment.<br /><br /><br />Description<br /><br /><see cref="Reference">Reference</see> is an abstract entity and will be realized by a specific <see cref="Reference">Reference</see> type for an <see cref="MTConnectDevices">MTConnectDevices</see> entity. See <see cref="ComponentRef">ComponentRef</see> and <see cref="DataItemRef">DataItemRef</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_25A13743_B12C_4c6c_B1DA_8E2EFDD156EF">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ReferenceClass : IClass
	{
		/// <summary>Constant value for <see cref="ReferenceClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_25A13743_B12C_4c6c_B1DA_8E2EFDD156EF";
		/// <summary>Constant value for <see cref="ReferenceClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_25A13743_B12C_4c6c_B1DA_8E2EFDD156EF";
		/// <summary>Constant value for <see cref="ReferenceClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;pointer to information that is associated with another entity defined elsewhere in the {{block(MTConnectDevices)}} entity for a piece of equipment.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(Reference)}} is an abstract entity and will be realized by a specific {{block(Reference)}} type for an {{block(MTConnectDevices)}} entity. See {{sect(ComponentRef)}} and {{sect(DataItemRef)}}.&#10;
";
		/// <summary>Constant value for <see cref="ReferenceClass.Name" /></summary>
		public const string NAME = "Reference";
		/// <summary>Constant value for <see cref="ReferenceClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ReferenceClass.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="ReferenceClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="ReferenceClass.DeprecatedVersion" /></summary>
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
		public new ReferenceClassProperties Properties { get; } = new ReferenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ReferenceClass" />.
		/// </summary>
		public class ReferenceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				IdRef,
				Name,
				DataItemId,
				RefDataItemId,
			};
			/// <summary>
			/// <inheritdoc cref="IdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IdRef</remarks>
			/// </summary>
			public IdRefProperty IdRef { get; } = new IdRefProperty();
			
			/// <summary>﻿pointer to the <c>id</c> of an entity that contains the information to be associated with this entity.<br /><br /><br />
			/// </summary>
			public sealed class IdRefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IdRefProperty.Name" /></summary>
				public const string NAME = "idRef";
				/// <summary>Constant value for <see cref="IdRefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;pointer to the `id` of an entity that contains the information to be associated with this entity.&#10;
";
				/// <summary>Constant value for <see cref="IdRefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="IdRefProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IdRefProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.4";
				/// <summary>Constant value for <see cref="IdRefProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IdRefProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="IdRefProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="IdRefProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="IdRefProperty.DefaultValue" /></summary>
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
			
			/// <summary>﻿ name of an element or a piece of equipment.<br /><br /><br />
			/// </summary>
			public sealed class NameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NameProperty.Name" /></summary>
				public const string NAME = "name";
				/// <summary>Constant value for <see cref="NameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10; name of an element or a piece of equipment.&#10;
";
				/// <summary>Constant value for <see cref="NameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.3";
				/// <summary>Constant value for <see cref="NameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="NameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
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
			/// <inheritdoc cref="DataItemIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DataItemId</remarks>
			/// </summary>
			public DataItemIdProperty DataItemId { get; } = new DataItemIdProperty();
			
			/// <summary>﻿pointer to the <see cref="DataItem.id">id in DataItem</see> that contains the information to be associated with this entity.<br /><br /><br />
			/// </summary>
			public sealed class DataItemIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DataItemIdProperty.Name" /></summary>
				public const string NAME = "dataItemId";
				/// <summary>Constant value for <see cref="DataItemIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;pointer to the {{property(DataItem::id)}} that contains the information to be associated with this entity.&#10;
";
				/// <summary>Constant value for <see cref="DataItemIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="DataItemIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DataItemIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.3";
				/// <summary>Constant value for <see cref="DataItemIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "1.4";
				/// <summary>Constant value for <see cref="DataItemIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="DataItemIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="DataItemIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DataItemIdProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="RefDataItemIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: RefDataItemId</remarks>
			/// </summary>
			public RefDataItemIdProperty RefDataItemId { get; } = new RefDataItemIdProperty();
			
			/// <summary>﻿pointer to the <see cref="DataItem.id">id in DataItem</see> that contains the information to be associated with this entity.<br /><br /><br />
			/// </summary>
			public sealed class RefDataItemIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="RefDataItemIdProperty.Name" /></summary>
				public const string NAME = "refDataItemId";
				/// <summary>Constant value for <see cref="RefDataItemIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;pointer to the {{property(DataItem::id)}} that contains the information to be associated with this entity.&#10;
";
				/// <summary>Constant value for <see cref="RefDataItemIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="RefDataItemIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="RefDataItemIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.3";
				/// <summary>Constant value for <see cref="RefDataItemIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "1.4";
				/// <summary>Constant value for <see cref="RefDataItemIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="RefDataItemIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="RefDataItemIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="RefDataItemIdProperty.DefaultValue" /></summary>
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