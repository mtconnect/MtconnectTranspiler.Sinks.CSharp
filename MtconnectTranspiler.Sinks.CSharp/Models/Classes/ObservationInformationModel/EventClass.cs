#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿<see cref="Observation">Observation</see> that is a discrete piece of information from a piece of equipment.<br /><br /><br /><br />Description<br /><br /><br />It provides the information and data reported from a piece of equipment for those <see cref="DataItem">DataItem</see> entities defined with <see cref="DataItem.category">category in DataItem</see> as <c>EVENT</c> in the <i>MTConnectDevices Response Document</i>.<br /><br />{{figure(Event Example)}} shows <see cref="Event">Event</see> type examples. It also shows an example for when the <see cref="Observation.result">result in Observation</see> is not available (<c>dataItemId</c>=<c>d1_asset_rem</c>).<br /><br />![Event Example](figures/Event%20Example.png "Event Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(event-example)}} for the <i>XML</i> representation of the same example.<br /><br />The following <see cref="Value Properties of Event">Value Properties of Event</see> lists the additional and/or updated attributes for <see cref="Event">Event</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531115_47447_25730">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EventClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566531115_47447_25730";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Observation)}} that is a discrete piece of information from a piece of equipment.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;
It provides the information and data reported from a piece of equipment for those {{block(DataItem)}} entities defined with {{property(DataItem::category)}} as `EVENT` in the {{term(MTConnectDevices Response Document)}}.

{{figure(Event Example)}} shows {{block(Event)}} type examples. It also shows an example for when the {{property(Observation::result)}} is not available (`dataItemId`=`d1_asset_rem`).

![Event Example](figures/Event%20Example.png ""Event Example""){: width=""0.8""}

> Note: See {{lst(event-example)}} for the {{term(XML)}} representation of the same example.

The following {{sect(Value Properties of Event)}} lists the additional and/or updated attributes for {{block(Event)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Event";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531118_10952_25736</item>
				/// <item>Type: ResetTriggeredEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ResetTriggeredEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "resetTriggered";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;identifies when a reported value has been reset and what has caused that reset to occur for those {{block(DataItem)}} entities that may be periodically reset to an initial value.

`resetTriggered` **MUST** only be provided for the specific occurrence of a {{block(DataItem)}} reported in the {{term(MTConnectStreams Response Document)}} when the reset occurred.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.4";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_9057AAF9_4687_42be_BD2B_E2F18DF049DC</item>
				/// <item>Type: ComponentStreamClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ComponentStreamClass);
				
				/// <inheritdoc />
				public string Name => "organizedByComponentStream";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Events";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580398379726_606068_12802</item>
				/// <item>Type: EventEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.EventEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}