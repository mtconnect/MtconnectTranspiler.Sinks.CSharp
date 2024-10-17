#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="Part">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp.<br /><br /><br />Description<br /><br /><see cref="PartId">PartId</see> <b>MUST</b> be defined for <see cref="PartOccurrence">PartOccurrence</see>.<br /><br /><br /><br /><br />Example<br /><br /><br />~~~~xml<br />&lt;Parts id="partOccSet"&gt;<br />   &lt;Components&gt;<br />	   &lt;PartOccurrence id="partOccur"&gt;<br />		 &lt;DataItems&gt;<br />		   &lt;DataItem id="partSet" category="EVENT" representation="TABLE" type ="COMPONENT_DATA"&gt;<br />			  &lt;Definition&gt;<br />				 &lt;EntryDefinitions&gt;<br />					  &lt;EntryDefinition keyType="PART_UNIQUE_ID"/&gt;<br />				 &lt;/EntryDefinitions&gt;<br />				 &lt;CellDefinitions&gt;<br />					&lt;CellDefinition key="partNumber" type="PART_KIND_ID" subType="PART_NUMBER"/&gt;<br />					&lt;CellDefinition key="batchId" type="PART_GROUP_ID" subType="BATCH"/&gt;<br />					&lt;CellDefinition key="quantity" type="PART_COUNT" subType="TARGET"/&gt;<br />					&lt;CellDefinition key="actualCompleteTime" type="PROCESS_TIME" subType="COMPLETE"/&gt;<br />					&lt;CellDefinition key="partState" type="PROCESS_STATE"/&gt;<br />				&lt;/CellDefinitions&gt;<br />			  &lt;/Definition&gt;<br />			&lt;/DataItem&gt;<br />		 &lt;/DataItems&gt;<br />	   &lt;/PartOccurrence&gt;<br />	&lt;/Components&gt;<br />&lt;/Parts&gt;<br />~~~~<br />{: caption="XML Device Model Example for PartOccurrence and ComponentData"}<br /><br /><br />~~~~xml<br />&lt;?xml version="1.0" encoding="UTF-8"?&gt;<br />&lt;?xml-stylesheet type="text/xsl" href="/styles/Streams.xsl"?&gt;<br />&lt;MTConnectStreams&gt;<br />  &lt;Streams&gt;<br />    &lt;DeviceStream name="VMC-3Axis" uuid="test_27MAY"&gt;<br />      &lt;ComponentStream component="PartOccurrence" name="partSet" componentId="partOccur"&gt;<br />        &lt;Events&gt;<br />          &lt;ComponentDataTable dataItemId="partSet" timestamp="2020-10-28T19:45:43.070010Z" sequence="95" count="2"&gt;<br />            &lt;Entry key="part1"&gt;<br />              &lt;Cell key="actualStartTime"&gt;2009-06-15T00:00:00.000000&lt;/Cell&gt;<br />              &lt;Cell key="partId"&gt;part1&lt;/Cell&gt;<br />              &lt;Cell key="partName"&gt;SomeName&lt;/Cell&gt;<br />              &lt;Cell key="uniqueID"&gt;abc-123&lt;/Cell&gt;<br />            &lt;/Entry&gt;<br />            &lt;Entry key="part2"&gt;<br />              &lt;Cell key="actualStartTime"&gt;2009-06-15T00:00:00.007925&lt;/Cell&gt;<br />              &lt;Cell key="partId"&gt;part2&lt;/Cell&gt;<br />              &lt;Cell key="partName"&gt;AnotherName&lt;/Cell&gt;<br />              &lt;Cell key="uniqueID"&gt;def-123&lt;/Cell&gt;<br />            &lt;/Entry&gt;<br />          &lt;/ComponentDataTable&gt;<br />        &lt;/Events&gt;<br />      &lt;/ComponentStream&gt;<br />    &lt;/DeviceStream&gt;<br />  &lt;/Streams&gt;<br />&lt;/MTConnectStreams&gt;<br />~~~~<br />{: caption="XML Streams Response Example for PartOccurrence and ComponentData"}<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605547467172_656422_264">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PartOccurrenceClass : IClass
	{
		/// <summary>Constant value for <see cref="PartOccurrenceClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605547467172_656422_264";
		/// <summary>Constant value for <see cref="PartOccurrenceClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605547467172_656422_264";
		/// <summary>Constant value for <see cref="PartOccurrenceClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Part)}} that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(PartId)}} **MUST** be defined for {{block(PartOccurrence)}}.&#10;
&#10;&#10;&#10;Example&#10;&#10;&#10;&#10;
~~~~xml
<Parts id=""partOccSet"">
   <Components>
	   <PartOccurrence id=""partOccur"">
		 <DataItems>
		   <DataItem id=""partSet"" category=""EVENT"" representation=""TABLE"" type =""COMPONENT_DATA"">
			  <Definition>
				 <EntryDefinitions>
					  <EntryDefinition keyType=""PART_UNIQUE_ID""/>
				 </EntryDefinitions>
				 <CellDefinitions>
					<CellDefinition key=""partNumber"" type=""PART_KIND_ID"" subType=""PART_NUMBER""/>
					<CellDefinition key=""batchId"" type=""PART_GROUP_ID"" subType=""BATCH""/>
					<CellDefinition key=""quantity"" type=""PART_COUNT"" subType=""TARGET""/>
					<CellDefinition key=""actualCompleteTime"" type=""PROCESS_TIME"" subType=""COMPLETE""/>
					<CellDefinition key=""partState"" type=""PROCESS_STATE""/>
				</CellDefinitions>
			  </Definition>
			</DataItem>
		 </DataItems>
	   </PartOccurrence>
	</Components>
</Parts>
~~~~
{: caption=""XML Device Model Example for PartOccurrence and ComponentData""}


~~~~xml
<?xml version=""1.0"" encoding=""UTF-8""?>
<?xml-stylesheet type=""text/xsl"" href=""/styles/Streams.xsl""?>
<MTConnectStreams>
  <Streams>
    <DeviceStream name=""VMC-3Axis"" uuid=""test_27MAY"">
      <ComponentStream component=""PartOccurrence"" name=""partSet"" componentId=""partOccur"">
        <Events>
          <ComponentDataTable dataItemId=""partSet"" timestamp=""2020-10-28T19:45:43.070010Z"" sequence=""95"" count=""2"">
            <Entry key=""part1"">
              <Cell key=""actualStartTime"">2009-06-15T00:00:00.000000</Cell>
              <Cell key=""partId"">part1</Cell>
              <Cell key=""partName"">SomeName</Cell>
              <Cell key=""uniqueID"">abc-123</Cell>
            </Entry>
            <Entry key=""part2"">
              <Cell key=""actualStartTime"">2009-06-15T00:00:00.007925</Cell>
              <Cell key=""partId"">part2</Cell>
              <Cell key=""partName"">AnotherName</Cell>
              <Cell key=""uniqueID"">def-123</Cell>
            </Entry>
          </ComponentDataTable>
        </Events>
      </ComponentStream>
    </DeviceStream>
  </Streams>
</MTConnectStreams>
~~~~
{: caption=""XML Streams Response Example for PartOccurrence and ComponentData""}&#10;
";
		/// <summary>Constant value for <see cref="PartOccurrenceClass.Name" /></summary>
		public const string NAME = "PartOccurrence";
		/// <summary>Constant value for <see cref="PartOccurrenceClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="PartOccurrenceClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="PartOccurrenceClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="PartOccurrenceClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_68e0225_1622456766067_72580_282
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.PartClass);

		/// <inheritdoc />
		public new PartOccurrenceClassProperties Properties { get; } = new PartOccurrenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="PartOccurrenceClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.PartClass.PartClassProperties" />.
		/// </summary>
		public class PartOccurrenceClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.PartClass.PartClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				ObservesPartId,
				ObservesPartUniqueId,
				ObservesPartGroupId,
				ObservesPartKindId,
				ObservesPartCount,
				ObservesPartStatus,
				ObservesProcessOccurrenceId,
				ObservesProcessTime,
				ObservesUser,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ObservesPartIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartId</remarks>
			/// </summary>
			public new ObservesPartIdProperty ObservesPartId { get; } = new ObservesPartIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPartIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPartIdProperty.Name" /></summary>
				public const string NAME = "observesPartId";
				/// <summary>Constant value for <see cref="ObservesPartIdProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPartIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPartIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPartIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPartIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesPartIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesPartIdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PartIdClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartIdClass);
				
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
			/// <inheritdoc cref="ObservesPartUniqueIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartUniqueId</remarks>
			/// </summary>
			public new ObservesPartUniqueIdProperty ObservesPartUniqueId { get; } = new ObservesPartUniqueIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPartUniqueIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPartUniqueIdProperty.Name" /></summary>
				public const string NAME = "observesPartUniqueId";
				/// <summary>Constant value for <see cref="ObservesPartUniqueIdProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPartUniqueIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPartUniqueIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPartUniqueIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartUniqueIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartUniqueIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPartUniqueIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesPartUniqueIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesPartUniqueIdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PartUniqueIdClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartUniqueIdClass);
				
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
			/// <inheritdoc cref="ObservesPartGroupIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartGroupId</remarks>
			/// </summary>
			public new ObservesPartGroupIdProperty ObservesPartGroupId { get; } = new ObservesPartGroupIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPartGroupIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPartGroupIdProperty.Name" /></summary>
				public const string NAME = "observesPartGroupId";
				/// <summary>Constant value for <see cref="ObservesPartGroupIdProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPartGroupIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPartGroupIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPartGroupIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartGroupIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartGroupIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPartGroupIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesPartGroupIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesPartGroupIdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PartGroupIdClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartGroupIdClass);
				
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
			/// <inheritdoc cref="ObservesPartKindIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartKindId</remarks>
			/// </summary>
			public new ObservesPartKindIdProperty ObservesPartKindId { get; } = new ObservesPartKindIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPartKindIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPartKindIdProperty.Name" /></summary>
				public const string NAME = "observesPartKindId";
				/// <summary>Constant value for <see cref="ObservesPartKindIdProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPartKindIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPartKindIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPartKindIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartKindIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartKindIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPartKindIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesPartKindIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesPartKindIdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PartKindIdClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartKindIdClass);
				
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
			/// <inheritdoc cref="ObservesPartCountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartCount</remarks>
			/// </summary>
			public new ObservesPartCountProperty ObservesPartCount { get; } = new ObservesPartCountProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPartCountProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Name" /></summary>
				public const string NAME = "observesPartCount";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PartCountClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartCountClass);
				
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
			/// <inheritdoc cref="ObservesPartStatusProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartStatus</remarks>
			/// </summary>
			public new ObservesPartStatusProperty ObservesPartStatus { get; } = new ObservesPartStatusProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPartStatusProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPartStatusProperty.Name" /></summary>
				public const string NAME = "observesPartStatus";
				/// <summary>Constant value for <see cref="ObservesPartStatusProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPartStatusProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPartStatusProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPartStatusProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartStatusProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartStatusProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPartStatusProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesPartStatusProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesPartStatusProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PartStatusClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartStatusClass);
				
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
			/// <inheritdoc cref="ObservesProcessOccurrenceIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProcessOccurrenceId</remarks>
			/// </summary>
			public new ObservesProcessOccurrenceIdProperty ObservesProcessOccurrenceId { get; } = new ObservesProcessOccurrenceIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesProcessOccurrenceIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesProcessOccurrenceIdProperty.Name" /></summary>
				public const string NAME = "observesProcessOccurrenceId";
				/// <summary>Constant value for <see cref="ObservesProcessOccurrenceIdProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesProcessOccurrenceIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesProcessOccurrenceIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesProcessOccurrenceIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesProcessOccurrenceIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesProcessOccurrenceIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesProcessOccurrenceIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesProcessOccurrenceIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesProcessOccurrenceIdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ProcessOccurrenceIdClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProcessOccurrenceIdClass);
				
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
			/// <inheritdoc cref="ObservesProcessTimeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProcessTime</remarks>
			/// </summary>
			public new ObservesProcessTimeProperty ObservesProcessTime { get; } = new ObservesProcessTimeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesProcessTimeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesProcessTimeProperty.Name" /></summary>
				public const string NAME = "observesProcessTime";
				/// <summary>Constant value for <see cref="ObservesProcessTimeProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesProcessTimeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesProcessTimeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesProcessTimeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesProcessTimeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesProcessTimeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesProcessTimeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesProcessTimeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesProcessTimeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ProcessTimeClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProcessTimeClass);
				
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
			/// <inheritdoc cref="ObservesUserProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesUser</remarks>
			/// </summary>
			public new ObservesUserProperty ObservesUser { get; } = new ObservesUserProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesUserProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesUserProperty.Name" /></summary>
				public const string NAME = "observesUser";
				/// <summary>Constant value for <see cref="ObservesUserProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesUserProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesUserProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesUserProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesUserProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesUserProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesUserProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesUserProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesUserProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UserClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.UserClass);
				
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