#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿<see cref="Observation">Observation</see> that is a discrete piece of information from a piece of equipment.<br /><br /><br /><br />Description<br /><br /><br />It provides the information and data reported from a piece of equipment for those <see cref="DataItem">DataItem</see> entities defined with <see cref="DataItem.category">category in DataItem</see> as <c>EVENT</c> in the <i>MTConnectDevices Response Document</i>.<br /><br />{{figure(Event Example)}} shows <see cref="Event">Event</see> type examples. It also shows an example for when the <see cref="Observation.result">result in Observation</see> is not available (<c>dataItemId</c>=<c>d1_asset_rem</c>).<br /><br />![Event Example](figures/Event%20Example.png "Event Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(event-example)}} for the <i>XML</i> representation of the same example.<br /><br />The following <see cref="Value Properties of Event">Value Properties of Event</see> lists the additional and/or updated attributes for <see cref="Event">Event</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531115_47447_25730">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EventClass : IClass
	{
		/// <summary>Constant value for <see cref="EventClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579566531115_47447_25730";
		/// <summary>Constant value for <see cref="EventClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531115_47447_25730";
		/// <summary>Constant value for <see cref="EventClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Observation)}} that is a discrete piece of information from a piece of equipment.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;
It provides the information and data reported from a piece of equipment for those {{block(DataItem)}} entities defined with {{property(DataItem::category)}} as `EVENT` in the {{term(MTConnectDevices Response Document)}}.

{{figure(Event Example)}} shows {{block(Event)}} type examples. It also shows an example for when the {{property(Observation::result)}} is not available (`dataItemId`=`d1_asset_rem`).

![Event Example](figures/Event%20Example.png ""Event Example""){: width=""0.8""}

> Note: See {{lst(event-example)}} for the {{term(XML)}} representation of the same example.

The following {{sect(Value Properties of Event)}} lists the additional and/or updated attributes for {{block(Event)}}.&#10;
";
		/// <summary>Constant value for <see cref="EventClass.Name" /></summary>
		public const string NAME = "Event";
		/// <summary>Constant value for <see cref="EventClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="EventClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="EventClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="EventClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1579566531115_47734_25731
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationGeneralization);

		/// <inheritdoc />
		public new EventClassProperties Properties { get; } = new EventClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="EventClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.ObservationGeneralization.ObservationGeneralizationProperties" />.
		/// </summary>
		public class EventClassProperties : Mtconnect.ObservationInformationModel.ObservationGeneralization.ObservationGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				ResetTriggered,
				OrganizedByComponentStreamPart,
				Type,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ResetTriggeredProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ResetTriggered</remarks>
			/// </summary>
			public new ResetTriggeredProperty ResetTriggered { get; } = new ResetTriggeredProperty();
			
			/// <summary>﻿identifies when a reported value has been reset and what has caused that reset to occur for those <see cref="DataItem">DataItem</see> entities that may be periodically reset to an initial value.<br /><br /><c>resetTriggered</c> <b>MUST</b> only be provided for the specific occurrence of a <see cref="DataItem">DataItem</see> reported in the <i>MTConnectStreams Response Document</i> when the reset occurred.<br /><br /><br />
			/// </summary>
			public new sealed class ResetTriggeredProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Name" /></summary>
				public const string NAME = "resetTriggered";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifies when a reported value has been reset and what has caused that reset to occur for those {{block(DataItem)}} entities that may be periodically reset to an initial value.

`resetTriggered` **MUST** only be provided for the specific occurrence of a {{block(DataItem)}} reported in the {{term(MTConnectStreams Response Document)}} when the reset occurred.&#10;
";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.4";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ResetTriggeredEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ResetTriggeredEnumMetaClass);
				
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
			/// <inheritdoc cref="OrganizedByComponentStreamPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizedByComponentStream</remarks>
			/// </summary>
			public new OrganizedByComponentStreamPartProperty OrganizedByComponentStreamPart { get; } = new OrganizedByComponentStreamPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class OrganizedByComponentStreamPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Name" /></summary>
				public const string NAME = "organizedByComponentStream";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Events";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ComponentStreamClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ComponentStreamClass);
				
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
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
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
				/// <remarks> Type: EventEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.EventEnumMetaClass);
				
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