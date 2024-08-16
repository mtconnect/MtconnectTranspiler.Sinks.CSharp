using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="Part">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp.<br/><br />Description<br/><see cref="PartId">PartId</see> <b>MUST</b> be defined for <see cref="PartOccurrence">PartOccurrence</see>.<br/><br/><br />Example<br/><br />~~~~xml<br /><Parts id="partOccSet"><br />   <Components><br />	   <PartOccurrence id="partOccur"><br />		 <DataItems><br />		   <DataItem id="partSet" category="EVENT" representation="TABLE" type ="COMPONENT_DATA"><br />			  <Definition><br />				 <EntryDefinitions><br />					  <EntryDefinition keyType="PART_UNIQUE_ID"/><br />				 </EntryDefinitions><br />				 <CellDefinitions><br />					<CellDefinition key="partNumber" type="PART_KIND_ID" subType="PART_NUMBER"/><br />					<CellDefinition key="batchId" type="PART_GROUP_ID" subType="BATCH"/><br />					<CellDefinition key="quantity" type="PART_COUNT" subType="TARGET"/><br />					<CellDefinition key="actualCompleteTime" type="PROCESS_TIME" subType="COMPLETE"/><br />					<CellDefinition key="partState" type="PROCESS_STATE"/><br />				</CellDefinitions><br />			  </Definition><br />			</DataItem><br />		 </DataItems><br />	   </PartOccurrence><br />	</Components><br /></Parts><br />~~~~<br />{: caption="XML Device Model Example for PartOccurrence and ComponentData"}<br /><br /><br />~~~~xml<br /><?xml version="1.0" encoding="UTF-8"?><br /><?xml-stylesheet type="text/xsl" href="/styles/Streams.xsl"?><br /><MTConnectStreams><br />  <Streams><br />    <DeviceStream name="VMC-3Axis" uuid="test_27MAY"><br />      <ComponentStream component="PartOccurrence" name="partSet" componentId="partOccur"><br />        <Events><br />          <ComponentDataTable dataItemId="partSet" timestamp="2020-10-28T19:45:43.070010Z" sequence="95" count="2"><br />            <Entry key="part1"><br />              <Cell key="actualStartTime">2009-06-15T00:00:00.000000</Cell><br />              <Cell key="partId">part1</Cell><br />              <Cell key="partName">SomeName</Cell><br />              <Cell key="uniqueID">abc-123</Cell><br />            </Entry><br />            <Entry key="part2"><br />              <Cell key="actualStartTime">2009-06-15T00:00:00.007925</Cell><br />              <Cell key="partId">part2</Cell><br />              <Cell key="partName">AnotherName</Cell><br />              <Cell key="uniqueID">def-123</Cell><br />            </Entry><br />          </ComponentDataTable><br />        </Events><br />      </ComponentStream><br />    </DeviceStream><br />  </Streams><br /></MTConnectStreams><br />~~~~<br />{: caption="XML Streams Response Example for PartOccurrence and ComponentData"}<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605547467172_656422_264">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PartOccurrenceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605547467172_656422_264";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Part)}} that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp.&#10;
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

		/// <inheritdoc />
		public string Name => "PartOccurrence";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1622456766067_72580_282
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.PartClass);

		/// <inheritdoc />
		public PartOccurrenceClassProperties Properties { get; } = new PartOccurrenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class PartOccurrenceClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.PartClass.PartClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
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
			public ObservesPartIdProperty ObservesPartId { get; } = new ObservesPartIdProperty();
			public sealed class ObservesPartIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218372_674466_1974</item>
				/// <item>Type: PartIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartIdClass);
				
				/// <inheritdoc />
				public string Name => "observesPartId";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
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
			/// <summary>
			/// <inheritdoc cref="ObservesPartUniqueIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartUniqueId</remarks>
			/// </summary>
			public ObservesPartUniqueIdProperty ObservesPartUniqueId { get; } = new ObservesPartUniqueIdProperty();
			public sealed class ObservesPartUniqueIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549240508_290295_764</item>
				/// <item>Type: PartUniqueIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartUniqueIdClass);
				
				/// <inheritdoc />
				public string Name => "observesPartUniqueId";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
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
			/// <summary>
			/// <inheritdoc cref="ObservesPartGroupIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartGroupId</remarks>
			/// </summary>
			public ObservesPartGroupIdProperty ObservesPartGroupId { get; } = new ObservesPartGroupIdProperty();
			public sealed class ObservesPartGroupIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605548793581_13403_454</item>
				/// <item>Type: PartGroupIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartGroupIdClass);
				
				/// <inheritdoc />
				public string Name => "observesPartGroupId";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
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
			/// <summary>
			/// <inheritdoc cref="ObservesPartKindIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartKindId</remarks>
			/// </summary>
			public ObservesPartKindIdProperty ObservesPartKindId { get; } = new ObservesPartKindIdProperty();
			public sealed class ObservesPartKindIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549230052_910367_748</item>
				/// <item>Type: PartKindIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartKindIdClass);
				
				/// <inheritdoc />
				public string Name => "observesPartKindId";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
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
			/// <summary>
			/// <inheritdoc cref="ObservesPartCountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartCount</remarks>
			/// </summary>
			public ObservesPartCountProperty ObservesPartCount { get; } = new ObservesPartCountProperty();
			public sealed class ObservesPartCountProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218363_437912_1953</item>
				/// <item>Type: PartCountClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartCountClass);
				
				/// <inheritdoc />
				public string Name => "observesPartCount";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
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
			/// <summary>
			/// <inheritdoc cref="ObservesPartStatusProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartStatus</remarks>
			/// </summary>
			public ObservesPartStatusProperty ObservesPartStatus { get; } = new ObservesPartStatusProperty();
			public sealed class ObservesPartStatusProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549230538_92395_756</item>
				/// <item>Type: PartStatusClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartStatusClass);
				
				/// <inheritdoc />
				public string Name => "observesPartStatus";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
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
			/// <summary>
			/// <inheritdoc cref="ObservesProcessOccurrenceIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProcessOccurrenceId</remarks>
			/// </summary>
			public ObservesProcessOccurrenceIdProperty ObservesProcessOccurrenceId { get; } = new ObservesProcessOccurrenceIdProperty();
			public sealed class ObservesProcessOccurrenceIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549692001_598671_1420</item>
				/// <item>Type: ProcessOccurrenceIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProcessOccurrenceIdClass);
				
				/// <inheritdoc />
				public string Name => "observesProcessOccurrenceId";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
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
			/// <summary>
			/// <inheritdoc cref="ObservesProcessTimeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProcessTime</remarks>
			/// </summary>
			public ObservesProcessTimeProperty ObservesProcessTime { get; } = new ObservesProcessTimeProperty();
			public sealed class ObservesProcessTimeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218411_953996_2079</item>
				/// <item>Type: ProcessTimeClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProcessTimeClass);
				
				/// <inheritdoc />
				public string Name => "observesProcessTime";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
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
			/// <summary>
			/// <inheritdoc cref="ObservesUserProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesUser</remarks>
			/// </summary>
			public ObservesUserProperty ObservesUser { get; } = new ObservesUserProperty();
			public sealed class ObservesUserProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218462_589955_2238</item>
				/// <item>Type: UserClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.UserClass);
				
				/// <inheritdoc />
				public string Name => "observesUser";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
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