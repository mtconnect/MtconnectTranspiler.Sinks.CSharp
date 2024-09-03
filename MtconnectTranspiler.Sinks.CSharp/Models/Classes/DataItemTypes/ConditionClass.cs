#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.DataItems.DataItemTypes
{
	/// <summary>﻿abstract <see cref="DataItem">DataItem</see> that is about an entity's status regarding its ability to operate or it provides an indication whether the data reported for the entity is within an expected range.<br /><br /><br />Description<br /><br /><see cref="Condition">Condition</see> is reported differently than <see cref="Sample">Sample</see> or <see cref="Event">Event</see>.  <see cref="Condition">Condition</see> <b>MUST</b> be reported as <see cref="Normal">Normal</see>, <see cref="Warning">Warning</see>, or <see cref="Fault">Fault</see>.<br /><br />All <see cref="Sample">Sample</see>s <b>MAY</b> have associated <see cref="Condition">Condition</see> states.  <see cref="Condition">Condition</see> states indicate whether the value for the data is within an expected range and <b>MUST</b> be reported as <see cref="Normal">Normal</see>, or the value is unexpected or out of tolerance for the data and a <see cref="Warning">Warning</see> or <see cref="Fault">Fault</see> <b>MUST</b> be provided.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_3F5927FF_5B8D_4307_8D27_9654F724A657">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ConditionClass : IClass
	{
		/// <summary>Constant value for <see cref="ConditionClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_3F5927FF_5B8D_4307_8D27_9654F724A657";
		/// <summary>Constant value for <see cref="ConditionClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_3F5927FF_5B8D_4307_8D27_9654F724A657";
		/// <summary>Constant value for <see cref="ConditionClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;abstract {{block(DataItem)}} that is about an entity's status regarding its ability to operate or it provides an indication whether the data reported for the entity is within an expected range.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(Condition)}} is reported differently than {{block(Sample)}} or {{block(Event)}}.  {{block(Condition)}} **MUST** be reported as {{block(Normal)}}, {{block(Warning)}}, or {{block(Fault)}}.

All {{block(Sample)}}s **MAY** have associated {{block(Condition)}} states.  {{block(Condition)}} states indicate whether the value for the data is within an expected range and **MUST** be reported as {{block(Normal)}}, or the value is unexpected or out of tolerance for the data and a {{block(Warning)}} or {{block(Fault)}} **MUST** be provided.&#10;
";
		/// <summary>Constant value for <see cref="ConditionClass.Name" /></summary>
		public const string NAME = "Condition";
		/// <summary>Constant value for <see cref="ConditionClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ConditionClass.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="ConditionClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="ConditionClass.DeprecatedVersion" /></summary>
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
		/// Original Type: EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.DataItems.DataItemClass);

		/// <inheritdoc />
		public new ConditionClassProperties Properties { get; } = new ConditionClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ConditionClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.DataItems.DataItemClass.DataItemClassProperties" />.
		/// </summary>
		public class ConditionClassProperties : Mtconnect.DeviceInformationModel.DataItems.DataItemClass.DataItemClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Category,
				Type,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="CategoryProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Category</remarks>
			/// </summary>
			public new CategoryProperty Category { get; } = new CategoryProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class CategoryProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CategoryProperty.Name" /></summary>
				public const string NAME = "category";
				/// <summary>Constant value for <see cref="CategoryProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="CategoryProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CategoryProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CategoryProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="CategoryProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CategoryProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CategoryProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
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
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public new TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TypeProperty.Name" /></summary>
				public const string NAME = "type";
				/// <summary>Constant value for <see cref="TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ConditionEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ConditionEnumMetaClass);
				
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