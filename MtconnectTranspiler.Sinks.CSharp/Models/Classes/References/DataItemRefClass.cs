#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.References
{
	/// <summary>﻿<see cref="Reference">Reference</see> that is a pointer to a <see cref="DataItem">DataItem</see> associated with another entity defined for a piece of equipment.<br /><br /><br />Description<br /><br /><see cref="DataItemRef">DataItemRef</see> allows the data associated with a <see cref="DataItem">DataItem</see> defined in another entity to be directly associated with this entity.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581212127193_199949_213">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DataItemRefClass : IClass
	{
		/// <summary>Constant value for <see cref="DataItemRefClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1581212127193_199949_213";
		/// <summary>Constant value for <see cref="DataItemRefClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581212127193_199949_213";
		/// <summary>Constant value for <see cref="DataItemRefClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Reference)}} that is a pointer to a {{block(DataItem)}} associated with another entity defined for a piece of equipment.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(DataItemRef)}} allows the data associated with a {{block(DataItem)}} defined in another entity to be directly associated with this entity.&#10;
";
		/// <summary>Constant value for <see cref="DataItemRefClass.Name" /></summary>
		public const string NAME = "DataItemRef";
		/// <summary>Constant value for <see cref="DataItemRefClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DataItemRefClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DataItemRefClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.4";
		/// <summary>Constant value for <see cref="DataItemRefClass.DeprecatedVersion" /></summary>
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
		/// Original Type: EAID_25A13743_B12C_4c6c_B1DA_8E2EFDD156EF
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.References.ReferenceClass);

		/// <inheritdoc />
		public new DataItemRefClassProperties Properties { get; } = new DataItemRefClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DataItemRefClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.References.ReferenceClass.ReferenceClassProperties" />.
		/// </summary>
		public class DataItemRefClassProperties : Mtconnect.DeviceInformationModel.References.ReferenceClass.ReferenceClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				IdRef,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="IdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IdRef</remarks>
			/// </summary>
			public new IdRefProperty IdRef { get; } = new IdRefProperty();
			
			/// <summary>﻿pointer to the <see cref="DataItem.id">id in DataItem</see> that contains the information to be associated with this entity.<br /><br /><br />
			/// </summary>
			public new sealed class IdRefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IdRefProperty.Name" /></summary>
				public const string NAME = "idRef";
				/// <summary>Constant value for <see cref="IdRefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;pointer to the {{property(DataItem::id)}} that contains the information to be associated with this entity.&#10;
";
				/// <summary>Constant value for <see cref="IdRefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
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
				/// <remarks> Type: DataItemClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.DataItemClass);
				
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