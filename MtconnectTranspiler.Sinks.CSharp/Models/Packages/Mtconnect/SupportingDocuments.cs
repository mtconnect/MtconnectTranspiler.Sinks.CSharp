using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.SupportingDocuments;

namespace Mtconnect
{
	/// <summary>
	﻿/// Assets Appendix<br/>{{newpage()}}<br /><br />## XML Schema Diagrams<br /><br />See XML schemas for the MTConnect standard here: <see href="https://schemas.mtconnect.org/">https://schemas.mtconnect.org/</see>.<br /><br />### Assets Schema Diagrams<br /><br />See <c>Asset</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>Description</c> element in <c>MTConnectAssets</c> schema.<br /><br />### CuttingTool Schema Diagrams<br /><br />See <c>CuttingTool</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>CuttingToolDefinition</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>CuttingToolArchetypeReference</c> element in <c>MTConnectAssets</c> schema.<br /><br />### CuttingToolLifeCycle Schema Diagrams<br /><br />See <c>CuttingToolLifeCycle</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>CutterStatus</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>Location</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>Measurement</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>ProcessFeedRate</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>ProcessSpindleSpeed</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>ReconditionCount</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>ToolLife</c> element in <c>MTConnectAssets</c> schema.<br /><br />### CuttingItem Schema Diagrams<br /><br />See <c>CuttingItems</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>CuttingItem</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>ItemLife</c> element in <c>MTConnectAssets</c> schema.<br /><br />### ISO 13399 Diagrams<br /><br />#### Measurement Diagrams<br /><br />![Cutting Tool Measurement 3](figures/Cutting%20Tool%20Measurement%203.png "Cutting Tool Measurement 3"){: width="0.8"}<br /><br />![Cutting Tool Measurement 4](figures/Cutting%20Tool%20Measurement%204.png "Cutting Tool Measurement 4"){: width="0.8"}<br /><br />![Cutting Tool Measurement 5](figures/Cutting%20Tool%20Measurement%205.png "Cutting Tool Measurement 5"){: width="0.8"}<br /><br />![Cutting Tool Measurement 6](figures/Cutting%20Tool%20Measurement%206.png "Cutting Tool Measurement 6"){: width="0.8"}<br /><br />![Cutting Tool Measurement 7](figures/Cutting%20Tool%20Measurement%207.png "Cutting Tool Measurement 7"){: width="0.8"}<br /><br />![Cutting Tool Measurement 8](figures/Cutting%20Tool%20Measurement%208.png "Cutting Tool Measurement 8"){: width="0.8"}<br /><br />### Cutting Tool Examples<br /><br />#### Shell Mill<br /><br />![Shell Mill Side View](figures/Shell%20Mill%20Side%20View.png "Shell Mill Side View"){: width="0.8"}<br /><br />![Indexable Insert Measurements](figures/Indexable%20Insert%20Measurements.png "Indexable Insert Measurements"){: width="0.8"}<br /><br />~~~~xml<br /><?xml version="1.0" encoding="UTF-8"?><br /><MTConnectAssets <br />xmlns:m="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" <br />xsi:schemaLocation="urn:mtconnect.org:MTConnectAssets:1.2<br />http://mtconnect.org/schemas/MTConnectAssets\_1.2.xsd"><br />  <Header creationTime="2011-05-11T13:55:22" <br />  assetBufferSize="1024" sender="localhost"<br />  assetCount="2" version="1.2" instanceId="1234"/><br />  <Assets><br />  <CuttingTool serialNumber="1" toolId="KSSP300R4SD43L240" <br />  timestamp="2011-05-11T13:55:22" assetId="KSSP300R4SD43L240.1" <br />  manufacturers="KMT,Parlec"><br />    <CuttingToolLifeCycle><br />    <CutterStatus><Status>NEW</Status></CutterStatus><br />    <ProcessSpindleSpeed maximum="13300" <br />    nominal="605">10000</ProcessSpindleSpeed><br />    <ProcessFeedRate<br />    nominal="9.22">9.22</ProcessSpindleSpeed><br />    <ConnectionCodeMachineSide>CV50<br />    </ConnectionCodeMachineSide><br />    <Measurements><br />      <BodyDiameterMax code="BDX">73.25<br />      </BodyDiameterMax><br />      <OverallToolLength nominal="222.25" <br />        minimum="221.996" maximum="222.504" <br />        code="OAL">222.25</OverallToolLength><br />      <UsableLengthMax code="LUX" nominal="82.55">82.55<br />      </UsableLengthMax><br />      <CuttingDiameterMax code="DC" nominal="76.2" <br />        maximum="76.213" minimum="76.187">76.2<br />      </CuttingDiameterMax><br />      <BodyLengthMax code="LF" nominal="120.65" <br />        maximum="120.904" minimum="120.404">120.65<br />      </BodyLengthMax><br />      <DepthOfCutMax code="APMX" <br />      nominal="60.96">60.95</DepthOfCutMax><br />      <FlangeDiameterMax code="DF" <br />        nominal="98.425">98.425</FlangeDiameterMax><br />    </Measurements><br />    <CuttingItems count="24"><br />      <CuttingItem indices="1-24" itemId="SDET43PDER8GB" <br />        manufacturers="KMT" grade="KC725M"><br />        <Measurements><br />          <CuttingEdgeLength code="L" nominal="12.7" <br />            minimum="12.675" maximum="12.725">12.7<br />          </CuttingEdgeLength><br />        <WiperEdgeLength code="BS" nominal=<br />          "2.56">2.56</WiperEdgeLength><br />        <IncribedCircleDiameter code="IC"<br />          nominal="12.7">12.7<br />        </IncribedCircleDiameter><br />        <CornerRadius code="RE" nominal="0.8"><br />          0.8</CornerRadius><br />      </Measurements><br />      </CuttingItem><br />    </CuttingItems><br />    </CuttingToolLifeCycle><br />    </CuttingTool><br />  </Assets><br /></MTConnectAssets><br />~~~~<br />{: caption="Example for Indexable Insert Measurements"}<br /><br />{{pagebreak()}}<br /><br />#### Step Drill<br /><br />![Step Mill Side View](figures/Step%20Mill%20Side%20View.png "Step Mill Side View"){: width="0.8"}<br /><br />~~~~xml<br /><?xml version="1.0" encoding="UTF-8"?><br /><MTConnectAssets xmlns:m="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" <br />xsi:schemaLocation="urn:mtconnect.org:MTConnectAssets:1.2 <br />http://mtconnect.org/schemas/MTConnectAssets\_1.2.xsd"><br />  <Header creationTime="2011-05-<br />  11T13:55:22" assetBufferSize="1024" <br />  sender="localhost" assetCount="2" version="1.2" instanceId="1234"/><br />  <Assets><br />    <CuttingTool serialNumber="1 " toolId="B732A08500HP" <br />    timestamp="2011-05-11T13:55:22" assetId="B732A08500HP " <br />    manufacturers="KMT,Parlec"><br />      <Description><br />        Step Drill - KMT, B732A08500HP Grade KC7315<br />        Adapter - Parlec, C50-M12SF300-6<br />      </Description><br />      <CuttingToolLifeCycle><br />        <CutterStatus><Status>NEW</Status></CutterStatus><br />        <ProcessSpindleSpeed nominal="5893">5893</ProcessSpindleSpeed><br />        <ProcessFeedRate nominal="2.5">2.5</ProcessFeedRate><br />        <ConnectionCodeMachineSide>CV50 Taper</ConnectionCodeMachineSide><br />        <Measurements><br />          <BodyDiameterMax code="BDX">31.8</BodyDiameterMax><br />          <BodyLengthMax code="LBX" nominal="120.825" maximum="126.325" <br />          minimum="115.325">120.825</BodyLengthMax><br />          <ProtrudingLength code="LPR" nominal="155.75" maximum="161.25" <br />          minimum="150.26">155.75</ProtrudingLength><br />          <FlangeDiameterMax code="DF" <br />          nominal="98.425">98.425</FlangeDiameterMax><br />          <OverallToolLength nominal="257.35" minimum="251.85" <br />          maximum="262.85" code="OAL">257.35</OverallToolLength><br />        </Measurements><br />        <CuttingItems count="2"><br />          <CuttingItem indices="1" manufacturers="KMT" grade="KC7315">><br />            <Measurements><br />              <CuttingDiameter code="DC1" nominal="8.5" maximum="8.521" <br />              minimum="8.506">8.5135</CuttingDiameter><br />              <StepIncludedAngle code="STA1" nominal="90" maximum="91" <br />              minimum="89">90</StepIncludedAngle><br />              <FunctionalLength code="LF1" nominal="154.286" <br />              minimum="148.786" <br />              maximum="159.786">154.286</FunctionalLength><br />              <StepDiameterLength code="SDL1" <br />              nominal="9">9</StepDiameterLength><br />              <PointAngle code="SIG" nominal="135" minimum="133" <br />              maximum="137">135</PointAngle><br />            </Measurements><br />          </CuttingItem><br />          <CuttingItem indices="2" manufacturers="KMT" grade="KC7315">><br />            <Measurements><br />              <CuttingDiameter code="DC2" nominal="12" maximum="12.011" <br />              minimum="12">12</CuttingDiameter><br />              <FunctionalLength code="LF2" nominal="122.493" <br />              maximum="127.993" <br />              minimum="116.993">122.493</FunctionalLength><br />              <StepDiameterLength code="SDL2" <br />              nominal="9">9</StepDiameterLength><br />            </Measurements><br />          </CuttingItem><br />        </CuttingItems><br />      </CuttingToolLifeCycle><br />    </CuttingTool><br />  </Assets><br /></MTConnectAssets><br />~~~~<br />{: caption="Example for Step Mill Side View"}<br /><br />{{pagebreak()}}<br /><br />#### Shell Mill with Individual Loci<br /><br />![Shell Mill with Explicate Loci](figures/Shell%20Mill%20with%20Explicate%20Loci.png "Shell Mill with Explicate Loci"){: width="0.8"}<br /><br />~~~~xml<br /><?xml version="1.0" encoding="UTF-8"?><br /><MTConnectAssets xmlns:m="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" <br />xsi:schemaLocation="urn:mtconnect.org:MTConnectAssets:1.2 <br />http://mtconnect.org/schemas/MTConnectAssets\_1.2.xsd"><br />  <Header creationTime="2011-05-11T13:55:22" assetBufferSize="1024" <br />  sender="localhost" assetCount="2" version="1.2" instanceId="1234"/><br />  <Assets><br />    <CuttingTool serialNumber="1" toolId="KSSP300R4SD43L240" <br />    timestamp="2011-05-11T13:55:22" assetId="KSSP300R4SD43L240.1" <br />    manufacturers="KMT,Parlec"><br />      <Description>Keyway: 55 degrees</Description><br />      <CuttingToolLifeCycle><br />        <CutterStatus><Status>NEW</Status></CutterStatus><br />        <Measurements><br />          <UsableLengthMax code="LUX" <br />          nominal="82.55">82.55</UsableLengthMax><br />          <CuttingDiameterMax code="DC" nominal="76.2" maximum="76.213" <br />          minimum="76.187">76.2</CuttingDiameterMax><br />          <DepthOfCutMax code="APMX" nominal="60.96">60.95</DepthOfCutMax><br />        </Measurements><br />        <CuttingItems count="24"><br />          <CuttingItem indices="1" itemId="SDET43PDER8GB" <br />          manufacturers="KMT"><br />            <Locus>FLUTE: 1, ROW: 1</Locus><br />            <Measurements><br />             <DriveAngle code="DRVA" nominal="55">55</DriveAngle><br />           </Measurements><br />          </CuttingItem><br />          <CuttingItem indices="2-24" itemId="SDET43PDER8GB" <br />          manufacturers="KMT"><br />            <Locus>FLUTE: 2-4, ROW: 1; FLUTE: 1-4, ROW 2-6</Locus><br />          </CuttingItem><br />        </CuttingItems><br />      </CuttingToolLifeCycle><br />    </CuttingTool><br />  </Assets><br /></MTConnectAssets><br />~~~~<br />{: caption="Example for Shell Mill with Explicate Loci"}<br /><br />{{pagebreak()}}<br /><br />#### Drill with Individual Loci<br /><br />![Step Drill with Explicate Loci](figures/Step%20Drill%20with%20Explicate%20Loci.png "Step Drill with Explicate Loci"){: width="0.8"}<br /><br />~~~~xml<br /><?xml version="1.0" encoding="UTF-8"?><br /><MTConnectAssets xmlns:m="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" <br />xsi:schemaLocation="urn:mtconnect.org:MTConnectAssets:1.2 <br />http://mtconnect.org/schemas/MTConnectAssets\_1.2.xsd"><br />  <Header creationTime="2011-05-11T13:55:22" assetBufferSize="1024" <br />  sender="localhost" assetCount="2" version="1.2" instanceId="1234"/><br />  <Assets><br />    <CuttingTool serialNumber="1" toolId="KSEM0781LD" <br />    timestamp="2011-05-11T13:55:22" assetId="KSEM0781LD.1" manufacturers="KMT"><br />      <CuttingToolLifeCycle><br />        <CutterStatus><Status>NEW</Status></CutterStatus><br />        <ConnectionCodeMachineSide>HSK63A</ConnectionCodeMachineSide><br />        <Measurements><br />          <BodyDiameterMax code="BDX">52.75</BodyDiameterMax><br />          <OverallToolLength nominal="172.29" <br />          code="OAL">172.29</OverallToolLength><br />          <UsableLengthMax code="LUX" nominal="49">49</UsableLengthMax><br />          <FlangeDiameterMax code="DF" <br />          nominal="62.94">62.94</FlangeDiameterMax><br />        </Measurements><br />        <CuttingItems count="3"><br />          <CuttingItem indices="1" itemId="KSEM0781LD" manufacturers="KMT" <br />          grade="KC7015"><br />            <Locus>FLUTE: 1, ROW: 1</Locus><br />            <Measurements><br />         <FunctionalLength code="LF1" nominal="154.42">154.42</FunctionalLength><br />         <CuttingDiameter code="DC1" nominal="19.844">19.844</CuttingDiameter><br />         <PointAngle code="SIG" nominal="140">140</PointAngle><br />         <ToolCuttingEdgeAngle code="KAPR1" nominal="45">45</ToolCuttingEdgeAngle><br />         <StepDiameterLength code="SLD1" nominal="39.8">39.8</StepDiameterLength><br />            </Measurements><br />          </CuttingItem><br />          <CuttingItem indices="2-3" itemId="TPMT-21.52-FP" <br />          manufacturers="KMT" grade="KCM15"><br />            <Locus>FLUTE: 1-2, ROW: 2</Locus><br />            <Measurements><br />         <FunctionalLength code="LF2" nominal="112.9">119.2</FunctionalLength><br />         <CuttingDiameter code="DC2" nominal="31">31</CuttingDiameter><br />            </Measurements><br />          </CuttingItem><br />        </CuttingItems><br />      </CuttingToolLifeCycle><br />    </CuttingTool><br />  </Assets><br /></MTConnectAssets><br />~~~~<br />{: caption="Example for Step Drill with Explicate Loci"}<br /><br />{{pagebreak()}}<br /><br />#### Shell Mill with Different Inserts on First Row<br /><br />![Shell Mill with Different Inserts on First Row](figures/Shell%20Mill%20with%20Different%20Inserts%20on%20First%20Row.png "Shell Mill with Different Inserts on First Row"){: width="0.8"}<br /><br />~~~~xml<br /><?xml version="1.0" encoding="UTF-8"?><br /><MTConnectAssets xmlns:m="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" <br />xsi:schemaLocation="urn:mtconnect.org:MTConnectAssets:1.2 <br />http://mtconnect.org/schemas/MTConnectAssets\_1.2.xsd"><br />  <Header creationTime="2011-05-11T13:55:22" assetBufferSize="1024" <br />  sender="localhost" assetCount="2" version="1.2" instanceId="1234"/><br />  <Assets><br />    <CuttingTool serialNumber="1" toolId="XXX" timestamp="2011-05-11T13:55:22" <br />    assetId="XXX.1" manufacturers="KMT"><br />      <CuttingToolLifeCycle><br />        <CutterStatus><Status>NEW</Status></CutterStatus><br />        <Measurements><br />          <DepthOfCutMax code="APMX" nominal="47.8">47.8</DepthOfCutMax><br />          <CuttingDiameterMax code="DC" <br />          nominal="50.8">50.8</CuttingDiameterMax><br />          <UsableLengthMax code="LUX" <br />          nominal="78.74">78.74</UsableLengthMax><br />        </Measurements><br />        <CuttingItems count="9"><br />          <CuttingItem indices="1-3" itemId="EDPT180564PDER-LD" <br />          manufacturers="KMT"><br />            <Locus>FLUTE: 1-3, ROW: 1</Locus><br />            <Measurements><br />              <CornerRadius code="RE" nominal="6.25">6.35</CornerRadius><br />            </Measurements><br />          </CuttingItem><br />          <CuttingItem indices="4-9" itemId="EDPT180508PDER-LD" <br />          manufacturers="KMT"><br />            <Locus>FLANGE: 1-4, ROW: 2-3</Locus><br />          </CuttingItem><br />        </CuttingItems><br />      </CuttingToolLifeCycle><br />    </CuttingTool><br />  </Assets><br /></MTConnectAssets><br />~~~~<br />{: caption="Example for Shell Mill with Different Inserts on First Row"}<br /><br />### File Schema Diagrams<br /><br />See <c>File</c> element in <c>MTConnectAssets</c> schema.<br /><br />### RawMaterial Schema Diagrams<br /><br />See <c>RawMaterial</c> element in <c>MTConnectAssets</c> schema.<br /><br />### QIFDocumentWrapper Schema Diagrams<br /><br />See <c>QIFDocumentWrapper</c> element in <c>MTConnectAssets</c> schema.<br/><br/><br />Assets Introduction<br/># Purpose of This Document<br /><br />This document, <see cref="Asset Information Model">Asset Information Model</see> of the MTConnect Standard, details information that is common to all types of <i>Asset</i>s.  Part 4.0 of the MTConnect Standard provide semantic models for entities that are used in the manufacturing process, but are not considered to be a piece of equipment.  These entities are defined as <i>Asset</i>s.  These <i>asset</i>s may be removed from a piece of equipment without detriment to the function of the equipment and can be associated with other pieces of equipment during their lifecycle.  The data associated with these <i>asset</i>s may be retrieved from multiple sources that are each responsible for providing their knowledge of the <i>asset</i>.<br /><br /># Terminology and Conventions<br /><br />Refer to <see cref="Fundamentals">Fundamentals</see> for a dictionary of terms, reserved language, and document conventions used in the MTConnect Standard.<br /><br />{{printglossary[title=General Terms, type=general]()}}<br />{{printglossary[title=Information Model Terms, type=informationmodel]()}}<br />{{printglossary[title=Protocol Terms, type=protocol]()}}<br />{{printglossary[title=HTTP Terms, type=http]()}}<br />{{printglossary[title=XML Terms, type=xml]()}}<br />{{printglossary[title=MTConnect Terms, type=conceptmodel]()}}<br /><br />{{printacronyms()}}<br /><br />{{printbibliography[title=MTConnect References,keyword=MTC]()}}<br /><br />{{printbibliography[title=Other References,notkeyword=MTC]()}}<br /><br />{{glsaddall()}}<br/><br/><br />Devices Introduction<br/># Purpose of This Document<br /><br />This document, <see cref="Device Information Model">Device Information Model</see> of the MTConnect Standard, establishes the rules and terminology to be used by designers to describe the function and operation of a piece of equipment and to define the data that is provided by an <i>agent</i> from the equipment.  The <i>Device Information Model</i>  also defines the structure for the <i>response document</i> that is returned from an <i>agent</i> in response to a <i>probe request</i>. <br /><br />In the MTConnect Standard, equipment represents any tangible property that is used in the operations of a manufacturing facility.  Examples of equipment are machine tools, ovens, sensor units, workstations, software applications, and bar feeders. <br /><br />> Note: See <see cref="Observation Information Model">Observation Information Model</see> of the MTConnect Standard for details on the <i>response document</i> that are returned from an <i>agent</i> in response to a <i>sample request</i> or <i>current request</i>.<br /><br /># Terminology and Conventions<br /><br />Refer to <see cref="Fundamentals">Fundamentals</see> for a dictionary of terms, reserved language, and document conventions used in the MTConnect Standard.<br /><br />{{printglossary[title=General Terms, type=general]()}}<br />{{printglossary[title=Information Model Terms, type=informationmodel]()}}<br />{{printglossary[title=Protocol Terms, type=protocol]()}}<br />{{printglossary[title=HTTP Terms, type=http]()}}<br />{{printglossary[title=XML Terms, type=xml]()}}<br />{{printglossary[title=MTConnect Terms, type=conceptmodel]()}}<br /><br />{{printacronyms()}}<br /><br />{{printbibliography[title=MTConnect References,keyword=MTC]()}}<br /><br />{{printbibliography[title=Other References,notkeyword=MTC]()}}<br /><br />{{glsaddall()}}<br/><br/><br />Devices Appendix<br/>{{newpage()}} <br /><br />## XML Schema Diagrams<br /><br />See XML schemas for the MTConnect standard here: <see href="https://schemas.mtconnect.org/">https://schemas.mtconnect.org/</see>.<br /><br />### Components Schema Diagrams<br /><br />See <c>Components</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Description</c> element in <c>MTConnectDevices</c> schema.<br /><br />### DataItems Schema Diagrams<br /><br />See <c>DataItems</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Source</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Constraints</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Filter</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Definition</c> element in <c>MTConnectDevices</c> schema.<br /><br />### References Schema Diagrams<br /><br />See <c>References</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>ComponentRef</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>DataItemRef</c> element in <c>MTConnectDevices</c> schema.<br /><br />### Configuration Schema Diagrams<br /><br />See <c>Configuration</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>CoordinateSystem</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Motion</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Relationships</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>ComponentRelationship</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>DeviceRelationship</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>SensorConfiguration</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>SolidModel</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Specifications</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>ProcessSpecification</c> element in <c>MTConnectDevices</c> schema.<br /><br />## XML Examples<br /><br />### Device Entity Hierarchy Example<br /><br />~~~~xml<br /><Devices><br />  <Device id="d1" name="M12346" uuid="M80104K162N"><br />    <Components><br />    <Axes id="a" name="base"><br />    <Components><br />      <Linear id="x" name="X"/><br />      <Linear id="y" name="Y"/><br />      <Linear id="z" name="Z"/><br />      <Rotary id="ar" name="B"/><br />      <Linear id="w" name="Z3" nativeName="W"/><br />      <Rotary id="c" name="C"/><br />    </Components><br />    </Axes><br />    <Controller id="cont" name="controller"><br />    <Components><br />      <Path id="path1" name="path"/><br />    </Components><br />    </Controller><br />    <Door id="door1" name="door"/><br />    <Systems id="systems" name="systems"><br />    <Components><br />      <WorkEnvelope id="we1" name="workenv"><br />      <Compositions><br />        <Composition type="WORKPIECE" id="wp"/><br />        <Composition type="TABLE" id="tbl"/><br />      </Compositions><br />      </WorkEnvelope><br />      <Electric id="elec" name="electric"/><br />      <Hydraulic id="hydraulic" name="hydraulic"/><br />      <Coolant id="coolant" name="coolant"/><br />      <Pneumatic id="pneumatic" name="pneumatic"/><br />      <Lubrication id="lubrication" name="lubrication"/><br />    </Components><br />    </Systems><br />    <Auxiliaries id="Aux" name="auxiliaries"><br />    <Components><br />      <Environmental id="room" name="environmental"/><br />    </Components><br />    </Auxiliaries><br />    <Resources id="resources" name="resources"><br />    <Components><br />      <Personnel id="personnel" name="personnel"/><br />      <Materials id="materials" name="materials"><br />      <Components><br />        <Stock id="procstock" name="stock"/><br />      </Components><br />      <Materials/><br />    </Components> <br />    </Resources><br />    </Components><br />  </Device><br /></Devices><br />~~~~<br />{: caption="Device Entity Hierarchy Example"}<br /><br />### Component Example<br /><br />~~~~xml<br /><Devices><br />  <Device id="d1" name="M12346" uuid="M80104K162N"><br />    <Description manufacturer="Example_Corporation" <br />      serialNumber="272237"> Mill w/SMooth-G<br />    </Description><br />  <DataItems><br />    <DataItem category="EVENT" id="avail" name="avail" type="AVAILABILITY"/><br />    <DataItem category="EVENT" id="d1_asset_chg" name="asset_chg" type="ASSET_CHANGED"/><br />    <DataItem category="EVENT" id="d1_asset_rem" name="asset_rem" type="ASSET_REMOVED"/><br />  </DataItems><br />    <Components><br />    <Controller id="cont" name="controller"><br />      <DataItems><br />      <DataItem category="EVENT" id="estop" name="estop" type="EMERGENCY_STOP"/><br />      <DataItem category="CONDITION" id="logic_cond" type="LOGIC_PROGRAM"/><br />      <DataItem category="CONDITION" id="cont_system" type="SYSTEM"/><br />      <DataItem category="SAMPLE" id="cut_time" type="ACCUMULATED_TIME" units="SECOND"/><br />    </DataItems><br />    <Components><br />      <Path id="path1" name="path"><br />        <DataItems><br />        <DataItem category="EVENT" id="execution" name="execution" type="EXECUTION"/><br />        <DataItem category="SAMPLE" id="cspeed" subType="ACTUAL" type="CUTTING_SPEED" units="MILLIMETER/SECOND"/><br />        <DataItem category="CONDITION" id="path_system" type="SYSTEM"/><br />        <DataItem category="EVENT" id="cvars" representation="DATA_SET" type="VARIABLE"/><br />        <DataItem category="EVENT" id="woffset" representation="TABLE" type="WORK_OFFSET"/><br />      </DataItems><br />      </Path><br />    </Components><br />    </Controller><br />  </Components><br />  </Device><br /></Devices><br />~~~~<br />{: caption="Component Example"}<br /><br />### Component with Compositions Example<br /><br />In <i>XML</i>, <c>Composition</c> types are represented differently than <c>Component</c> types. For <c>Component</c> types, the element name is Pascal Case of the <c>Component</c> type name. Whereas, the element name for all <c>Composition</c>types is <c>Composition</c> and the type is defined by the <c>type</c> attribute of the element (see example below).<br /><br />~~~~xml<br /><WorkEnvelope id="we1" name="workenv"><br />  <DataItems><br />    <DataItem category="CONDITION" id="hardware1" name="hardware1" type="HARDWARE"/><br />  </DataItems><br />  <Compositions><br />  <Composition type="WORKPIECE" id="wp"/><br />  <Composition type="TABLE" id="tbl"/><br />  </Compositions><br /></WorkEnvelope><br />~~~~<br />{: caption="Component with Compositions Example"}<br /><br />### CoordinateSystem Example<br /><br />~~~~xml<br /><Devices><br />  <Device id="d1" name="M12346" uuid="M80104K162N"><br />    <Description manufacturer="Example_Corporation" <br />      serialNumber="272237"> Mill w/SMooth-G<br />    </Description><br />    <DataItems><br />      <DataItem id="avail" type="AVAILABILITY" category="EVENT"/><br />      <DataItem category="EVENT" id="d1_asset_chg" name="asset_chg" type="ASSET_CHANGED"/><br />      <DataItem category="EVENT" id="d1_asset_rem" name="asset_rem" type="ASSET_REMOVED"/><br />    </DataItems><br />    <Configuration><br />      <CoordinateSystems><br />        <CoordinateSystem id="base" type="BASE"><br />          <Origin>0 0 0</Origin><br />        </CoordinateSystem><br />        <CoordinateSystem id="machcoord" type="MACHINE" parentIdRef="base"><br />          <Transformation><br />            <Translation>210 275 1430</Translation><br />            <Rotation>0 0 0</Rotation><br />          </Transformation><br />        </CoordinateSystem><br />        <CoordinateSystem id="workcoord" type="OBJECT" parentIdRef="machcoord"><br />          <Transformation><br />            <Translation>0 0 0</Translation><br />            <Rotation>0 0 0</Rotation><br />          </Transformation><br />        </CoordinateSystem><br />      </CoordinateSystems><br />    </Configuration><br />  </Device><br /></Devices><br />~~~~<br />{: caption="CoordinateSystem Example"}<br /><br />### Motion Example<br /><br />~~~~xml<br /><Devices><br />  <Device id="d1" name="M12346" uuid="M80104K162N"><br />    <Description manufacturer="Example_Corporation" <br />      serialNumber="272237"> Mill w/SMooth-G<br />    </Description><br />    <DataItems><br />      <DataItem id="avail" type="AVAILABILITY" category="EVENT"/><br />      <DataItem category="EVENT" id="d1_asset_chg" name="asset_chg" type="ASSET_CHANGED"/><br />      <DataItem category="EVENT" id="d1_asset_rem" name="asset_rem" type="ASSET_REMOVED"/><br />    </DataItems><br />    <Configuration><br />      <CoordinateSystems><br />        <CoordinateSystem id="base" type="BASE"><br />          <Origin>0 0 0</Origin><br />        </CoordinateSystem><br />        <CoordinateSystem id="machcoord" type="MACHINE" parentIdRef="base"><br />          <Transformation><br />            <Translation>210 275 1430</Translation><br />            <Rotation>0 0 0</Rotation><br />          </Transformation><br />        </CoordinateSystem><br />        <CoordinateSystem id="workcoord" type="OBJECT" parentIdRef="machcoord"><br />          <Transformation><br />            <Translation>0 0 0</Translation><br />            <Rotation>0 0 0</Rotation><br />          </Transformation><br />        </CoordinateSystem><br />      </CoordinateSystems><br />    </Configuration><br />    <Components><br />      <Axes id="a" name="base"><br />        <Components><br />          <Linear id="x" name="X"><br />            <Configuration><br />              <Motion id="xmotion" coordinateSystemIdRef="machcoord" type="PRISMATIC" actuation="DIRECT"><br />                <Transformation><br />                  <Translaton>300 915 590</Translaton><br />                  <Rotation>0 0 0</Rotation><br />                </Transformation><br />                <Axis>1.0 0 0</Axis><br />              </Motion><br />            </Configuration><br />          </Linear><br />          <DataItems><br />            <DataItem id="xtravel" type="SYSTEM" category="CONDITION"><br />          </DataItems><br />        </Components><br />      </Axes><br />    </Components><br />  </Device><br /></Devices><br />~~~~<br />{: caption="Motion Example"}<br /><br />### Relationship Example<br /><br />~~~~xml<br /><Components><br />  <Axes id="a" name="base"><br />    <Components><br />      <Linear id="x" name="X"><br />        <Configuration>        <br />          <Relationships><br />            <ComponentRelationship id="xpar" type="PARENT" idRef="we1"/><br />          </Relationships><br />        </Configuration><br />      </Linear><br />      <DataItems><br />        <DataItem id="xtravel" type="SYSTEM" category="CONDITION"><br />      </DataItems><br />    </Components><br />  </Axes><br />  <Systems id="systems" name="systems"><br />    <Components><br />      <WorkEnvelope id="we1" name="workenv"><br />        <Compositions><br />          <Composition type="WORKPIECE" id="wp"/><br />          <Composition type="TABLE" id="tbl"/><br />        </Compositions><br />        <DataItems><br />          <DataItem id="we1cond" type="SYSTEM" category="CONDITION"><br />        </DataItems><br />      </WorkEnvelope><br />    </Components><br />  </Systems><br /></Components><br />~~~~<br />{: caption="Relationship Example"}<br />      <br />### SolidModel Example<br /><br />~~~~xml<br /><Devices><br />  <Device id="d1" name="M12346" uuid="M80104K162N"><br />    <Description manufacturer="Example_Corporation" <br />      serialNumber="272237"> Mill w/SMooth-G<br />    </Description><br />    <DataItems><br />      <DataItem id="avail" type="AVAILABILITY" category="EVENT"/><br />      <DataItem category="EVENT" id="d1_asset_chg" name="asset_chg" type="ASSET_CHANGED"/><br />      <DataItem category="EVENT" id="d1_asset_rem" name="asset_rem" type="ASSET_REMOVED"/><br />    </DataItems><br />    <Configuration><br />      <CoordinateSystems><br />        <CoordinateSystem id="base" type="BASE"><br />          <Origin>0 0 0</Origin><br />        </CoordinateSystem><br />        <CoordinateSystem id="machcoord" type="MACHINE" parentIdRef="base"><br />          <Transformation><br />            <Translation>210 275 1430</Translation><br />            <Rotation>0 0 0</Rotation><br />          </Transformation><br />        </CoordinateSystem><br />        <CoordinateSystem id="workcoord" type="OBJECT" parentIdRef="machcoord"><br />          <Transformation><br />            <Translation>0 0 0</Translation><br />            <Rotation>0 0 0</Rotation><br />          </Transformation><br />        </CoordinateSystem><br />      </CoordinateSystems><br />    </Configuration><br />    <Components><br />      <Structures id="struct"><br />        <Configuration><br />          <SolidModel id="model" mediaType="OBJ" href="/objs/mazak.obj" coordinateSystemIdRef="base"><br />            <Transformation><br />              <Translation>0 860 0</Translation><br />              <Rotation>-90 0 0</Rotation><br />            </Transformation><br />            <Scale>0.001 0.001 0.001</Scale><br />          </SolidModel><br />        </Configuration><br />        <Components><br />          <Structure id="xaxis" name="X_AXIS"><br />            <Configuration><br />              <SolidModel id="x_model" mediaType="OBJ" itemRef="xaxis" solidModelIdRef="model" coordinateSystemIdRef="base"/><br />            </Configuration><br />            <DataItems><br />              <DataItem type="SYSTEM" category="CONDITION" id="struct_cond"/><br />            </DataItems><br />          </Structure><br />        </Components><br />      </Structures><br />    </Components><br />  </Device><br /></Devices><br />~~~~<br />{: caption="SolidModel Example"}<br /><br />### Specification Example<br /><br />~~~~xml<br /><Components><br />  <Axes id="a" name="base"><br />    <Components><br />      <Linear id="x" name="X"><br />        <Configuration><br />          <Specifications><br />            <Specification id="spec001" type="LENGTH" units="MILLIMETER"><br />              <Nominal>650</Nominal><br />            </Specification><br />            <Specification id="spec002" type="LINEAR_FORCE" units="NEWTON"><br />              <Maximum>5200</Maximum><br />              <Minimum>0</Minimum><br />            </Specification><br />          </Specifications><br />        </Configuration><br />        <DataItems><br />          <DataItem id="xtravel" type="SYSTEM" category="CONDITION"><br />        </DataItems><br />      </Linear><br />    </Components><br />  </Axes><br /></Components><br />~~~~<br />{: caption="Specification Example"}<br /><br />### Example of sensing element provided as data item associated with a Component<br /><br />~~~~xml<br /><Components><br />  <Axes id="a" name="base"<br />    <Components><br />      <Rotary id="c" name="C"><br />        <DataItems><br />          <DataItem type="TEMPERATURE" id="servotemp4"<br />            category="SAMPLE" nativeUnits="CELSIUS"<br />            compositionId="Bmotor" units="CELSIUS"/><br />          </DataItems><br />      </Rotary><br />    </Components><br />  </Axes><br /></Components><br />~~~~<br />{: caption="Example of sensing element provided as data item associated with a Component"}<br /><br />### Example of Sensor for rotary axis<br /><br />~~~~xml<br /><Components><br />  <Axes id="a" name="base"<br />    <Components><br />      <Rotary id="ar" name="B"><br />        <Components><br />          <Sensor id="spdlm" name="Spindlemonitor"><br />            <DataItems><br />              <DataItem type="DISPLACEMENT" id="cvib"<br />                category="SAMPLE" name="Svib" <br />                units="MILLIMETER"/><br />            </DataItems><br />          </Sensor ><br />        <Components><br />      </Rotary><br />    </Components><br />  </Axes><br /></Components><br />~~~~<br />{: caption="Example of Sensor for rotary axis"}<br /><br />### Example of sensor unit with sensing element<br /><br />~~~~xml<br /><Axes id="a" name="base"<br />  <Components><br />  <Sensor id="sens1" name="Sensorunit"><br />    <DataItems><br />    <DataItem type="TEMPERATURE" id="sentemp"<br />      category="SAMPLE" name="Sensortemp" <br />      units="CELSIUS"/> <br />    </DataItems><br />  </Sensor ><br />  <Linear id="x" name="X"><br />    <DataItems><br />    <DataItem type="DISPLACEMENT" id="xvib"<br />      category="SAMPLE" name="xvib" <br />      units="MILLIMETER"><br />      <Source componentId="sens1"/><br />    </DataItem><br />    </DataItems><br />  </Rotary><br />  <Linear id="y" name="Y"><br />    <DataItems><br />    <DataItem type="DISPLACEMENT" id="yvib" <br />      category="SAMPLE" name="yvib" <br />      units="MILLIMETER"><br />      <Source componentId="sens1"/><br />    </DataItem><br />    </DataItems><br />  </Linear><br />  <Components><br /></Axes><br />~~~~<br />{: caption="Example of sensor unit with sensing element"}<br /><br />### Example of configuration data for Sensor<br /><br />~~~~xml<br /><Sensor id="sensor" name="sensor"><br />  <Configuration><br />    <SensorConfiguration><br />      <FirmwareVersion>2.02</FirmwareVersion><br />      <CalibrationDate>2010-05-16</CalibrationDate><br />      <NextCalibrationDate>2010-05-16</NextCalibrationDate><br />      <CalibrationInitials>WS</CalibrationInitials><br />      <Channels><br />        <Channel number="1" name="A/D:1"><br />          <Description>A/D With Thermister</Description><br />        </Channel><br />      </Channels><br />    </SensorConfiguration><br />  </Configuration><br />  <DataItems><br />    <DataItem category="CONDITION" id="sensorc" <br />      name="sensorc" type="SYSTEM" /><br />    <DataItem category="SAMPLE" id="senv" name="sensorc"<br />      type="VOLTAGE_DC" units="VOLT" subType="ACTUAL" /><br />  </DataItems><br /></Sensor><br />~~~~<br />{: caption="Example of configuration data for Sensor"}  <br/><br/><br />Observations Introduction<br/># Purpose of This Document<br /><br />This document, <see cref="Observation Information Model">Observation Information Model</see> of the MTConnect Standard, establishes the rules and terminology that describes the information returned by an <i>MTConnect Agent</i> from a piece of equipment.  The <i>Observation Information Model}} also defines, in {{package(Observation Information Model</i>, the structure for the <i>response document</i>s that are returned from an <i>agent</i> in response to a <i>sample request</i> or <i>current request</i>.  <br /><br /><see cref="Observation Information Model">Observation Information Model</see> is not a stand-alone document.   This document is used in conjunction with <see cref="Fundamentals">Fundamentals</see>  which defines the fundamentals of the operation of the MTConnect Standard and <see cref="Device Information Model">Device Information Model</see> that defines the semantic model representing the information that may be returned from a piece of equipment.<br /><br />> Note: <see cref="Interface Interaction Model">Interface Interaction Model</see> provides details on extensions to the <i>Observation Information Model</i> required to describe the interactions between pieces of equipment.<br /><br />In the MTConnect Standard, equipment represents any tangible property that is used in the operation of a manufacturing facility.  Examples of equipment are machine tools, ovens, sensor units, workstations, software applications, and bar feeders.<br /><br /># Terminology and Conventions<br /><br />Refer to <see cref="Fundamentals">Fundamentals</see> for a dictionary of terms, reserved language, and document conventions used in the MTConnect Standard.<br /><br />{{printglossary[title=General Terms, type=general]()}}<br />{{printglossary[title=Information Model Terms, type=informationmodel]()}}<br />{{printglossary[title=Protocol Terms, type=protocol]()}}<br />{{printglossary[title=HTTP Terms, type=http]()}}<br />{{printglossary[title=XML Terms, type=xml]()}}<br />{{printglossary[title=MTConnect Terms, type=conceptmodel]()}}<br /><br />{{printacronyms()}}<br /><br />{{printbibliography[title=MTConnect References,keyword=MTC]()}}<br /><br />{{printbibliography[title=Other References,notkeyword=MTC]()}}<br /><br />{{glsaddall()}}<br/><br/><br />Observations Appendix<br/>{{newpage()}} <br /><br />## XML Schema Diagrams<br /><br />### Observations Schema Diagrams<br /><br />See <c>Streams</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>DeviceStream</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>ComponentStream</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>Sample</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>Event</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>Condition</c> element in <c>MTConnectStreams</c> schema.<br /><br />### Representation Schema Diagrams<br /><br />See <c>AbsTimeSeries</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>PartCountDiscrete</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>VariableDataSet</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>Entry</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>WorkOffsetTable</c> element in <c>MTConnectStreams</c> schema.<br /><br />## XML Examples<br /><br />### DeviceStream Example<br /><br />~~~~xml<br /><Streams><br />  <DeviceStream name="M12346" uuid="M8010W4194N"><br />    <ComponentStream component="Device" name="M12346" componentId="d1"><br />      <Events><br />        <Availability dataItemId="avail" sequence="156" timestamp="2021-10-01T14:26:38.668505Z">AVAILABLE</Availability><br />        <AssetChanged assetType="CuttingTool" dataItemId="d1_asset_chg" sequence="75570" timestamp="2021-10-07T05:08:53.870206Z">M8010W4194N1.120</AssetChanged><br />        <AssetRemoved assetType="CuttingTool" dataItemId="d1_asset_rem" sequence="140" timestamp="2021-10-01T11:40:08.101461Z">UNAVAILABLE</AssetRemoved><br />      </Events><br />    </ComponentStream><br />    <ComponentStream component="Controller" name="controller" componentId="cont"><br />      <Events><br />        <EmergencyStop dataItemId="estop" sequence="159" timestamp="2021-10-01T14:26:38.66869Z">ARMED</EmergencyStop><br />      </Events><br />      <Samples><br />        <AccumulatedTime dataItemId="cut_time" sequence="75437" timestamp="2021-10-07T05:08:28.221704Z">1763070.0</AccumulatedTime><br />      </Samples><br />      <Condition><br />        <Unavailable dataItemId="cont_system" sequence="72" timestamp="2021-10-11T21:04:03.251999Z" type="SYSTEM"/><br />        <Warning dataItemId="cont_system" nativecode="313" nativeSeverity="50" sequence="75573" timestamp="2021-10-07T05:08:58.518317Z" type="LOGIC_PROGRAM">PALLET ARM DOWN RS. MALF.</Warning><br />      </Condition><br />    </ComponentStream><br />    <ComponentStream component="Path" name="path" componentId="path1"><br />      <Events><br />        <Execution dataItemId="execution" name="execution" sequence="222623" timestamp="2021-10-12T06:04:32.761198Z">INTERRUPTED</Execution><br />        <VariableDataSet count="2" dataItemId="cvars" sequence="126513" timestamp="2021-10-12T03:57:31.106559Z"><br />          <Entry key="100">66.3314</Entry><br />          <Entry key="101">167.2</Entry><br />        </VariableDataSet><br />        <WorkOffsetTable count="2" dataItemId="woffset" sequence="222101" timestamp="2021-10-12T06:04:11.990531Z"><br />          <Entry key="G53.1"><br />            <Cell key="X">1</Cell><br />            <Cell key="Y">2</Cell><br />            <Cell key="Z">3</Cell><br />          </Entry><br />          <Entry key="G53.2"><br />            <Cell key="X">4</Cell><br />            <Cell key="Y">5</Cell><br />            <Cell key="Z">6</Cell><br />          </Entry><br />        </WorkOffsetTable><br />      </Events><br />      <Samples><br />        <CuttingSpeed dataItemId="cspeed" sequence="112" timestamp="2021-10-07T05:08:28.221704Z" subType="ACTUAL">UNAVAILABLE</CuttingSpeed><br />      </Samples><br />      <Condition><br />        <Normal dataItemId="path_system" sequence="153" timestamp="2021-10-11T21:04:03.262845Z" type="SYSTEM"/><br />      </Condition><br />    </ComponentStream><br />  </DeviceStream><br /></Streams><br />~~~~<br />{: caption="DeviceStream Example"}<br /><br />### Observations made for DataItem Example<br /><br />~~~~xml<br /><Components><br />  <Controller id="cont" name="controller"><br />      <DataItems><br />      <DataItem category="EVENT" id="estop" name="estop" type="EMERGENCY_STOP"/><br />    </DataItems><br />  </Controller><br /></Components><br />~~~~<br />{: caption="MTConnectDevices Response Document"}<br /><br />~~~~xml<br /><ComponentStream component="Controller" name="controller" componentId="cont"><br />  <Events><br />    <EmergencyStop dataItemId="estop" sequence="159" timestamp="2021-10-01T14:26:38.66869Z">ARMED</EmergencyStop><br />  </Events><br /></ComponentStream><br />~~~~<br />{: caption="MTConnectStreams Response Document"}<br /><br />### Sample Example<br /><br />~~~~xml<br /><Samples><br />  <AccumulatedTime dataItemId="cut_time" sequence="75437" timestamp="2021-10-07T05:08:28.221704Z">1763070.0</AccumulatedTime><br />  <CuttingSpeed dataItemId="cspeed" sequence="112" timestamp="2021-10-07T05:08:28.221704Z" subType="ACTUAL">UNAVAILABLE</CuttingSpeed><br /></Samples><br />~~~~<br />{: caption="Sample Example"}<br /><br />### Event Example<br /><br />~~~~xml<br /><Events><br />  <Availability dataItemId="avail" sequence="156" timestamp="2021-10-01T14:26:38.668505Z">AVAILABLE</Availability><br />  <AssetRemoved assetType="CuttingTool" dataItemId="d1_asset_rem" sequence="140" timestamp="2021-10-01T11:40:08.101461Z">UNAVAILABLE</AssetRemoved><br /></Events><br />~~~~<br />{: caption="Event Example"}<br /><br />### Condition Example<br /><br /><see cref="Condition">Condition</see> types are represented differently in <i>XML</i> when compared to <see cref="Sample">Sample</see> and <see cref="Event">Event</see> types. The element name is the <i>condition state</i> of the <see cref="Condition">Condition</see> type in Pascal Case. The name of the <see cref="Condition">Condition</see> type is represented by the attribute <c>type</c>.<br /><br />If the <i>condition state</i> is unavailable then the element name is represented by <c>Unavailable</c>.<br /><br />~~~~xml<br /><Condition><br />  <Unavailable dataItemId="cont_system" sequence="72" timestamp="2021-10-11T21:04:03.251999Z" type="SYSTEM"/><br />  <Normal dataItemId="path_system" sequence="153" timestamp="2021-10-11T21:04:03.262845Z" type="SYSTEM"/><br />  <Warning dataItemId="cont_system" nativecode="313" nativeSeverity="50" sequence="75573" timestamp="2021-10-07T05:08:58.518317Z" type="LOGIC_PROGRAM">PALLET ARM DOWN RS. MALF.</Warning><br /></Condition><br />~~~~<br />{: caption="Condition Example"}<br /><br />### DataSet Example<br /><br />~~~~xml<br /><Events><br />  <VariableDataSet count="2" dataItemId="cvars" sequence="126513" timestamp="2021-10-12T03:57:31.106559Z"><br />    <Entry key="100">66.3314</Entry><br />    <Entry key="101">167.2</Entry><br />  </VariableDataSet><br /></Events><br />~~~~<br />{: caption="DataSet Example"}<br /><br />### Table Example<br /><br />~~~~xml<br /><Events><br />  <WorkOffsetTable count="2" dataItemId="woffset" sequence="222101" timestamp="2021-10-12T06:04:11.990531Z"><br />    <Entry key="G53.1"><br />      <Cell key="X">1</Cell><br />      <Cell key="Y">2</Cell><br />      <Cell key="Z">3</Cell><br />    </Entry><br />    <Entry key="G53.2"><br />      <Cell key="X">4</Cell><br />      <Cell key="Y">5</Cell><br />      <Cell key="Z">6</Cell><br />    </Entry><br />  </WorkOffsetTable><br /></Events><br />~~~~<br />{: caption="Table Example"}<br/><br/><br />Interfaces Introduction<br/># Purpose of This Document<br /><br />This document, <see cref="Interface Interaction Model">Interface Interaction Model</see> of the MTConnect Standard, defines a structured data model used to organize information required to coordinate inter-operations between pieces of equipment.  <br /><br />This data model is based on an <i>interaction model</i> that defines the exchange of information between pieces of equipment and is organized in the MTConnect Standard by <see cref="Interfaces">Interfaces</see>.   <br /><br /><see cref="Interfaces">Interfaces</see> is modeled as an extension to the <i>Device Information Model</i> and <i>Observation Information Model</i>.  <see cref="Interfaces">Interfaces</see> leverages similar rules and terminology as those used to describe a component in the <i>Device Information Model</i>.  <see cref="Interfaces">Interfaces</see> also uses similar methods for reporting data to those used in the <i>MTConnectStreams Response Document</i>.  <br /><br />As defined in <see cref="Device Information Model">Device Information Model</see>, <see cref="Interfaces">Interfaces</see> <i>organize</i>s the <see cref="Interface">Interface</see> types (see {{figure(Interfaces in Entity Hierarchy)}}).  Each individual <see cref="Interface">Interface</see> contains data associated with the corresponding <i>interface</i>.<br /><br />> Note: See <see cref="Device Information Model">Device Information Model</see> and <see cref="Observation Information Model">Observation Information Model</see> of the MTConnect Standard for information on how <see cref="Interfaces">Interfaces</see> is structured in the <i>response document</i>s which are returned from an <i>agent</i> in response to a <i>probe request</i>, <i>sample request</i>, or <i>current request</i>.<br /><br /># Terminology and Conventions<br /><br />Refer to <see cref="Fundamentals">Fundamentals</see> for a dictionary of terms, reserved language, and document conventions used in the MTConnect Standard.<br /><br />{{printglossary[title=General Terms, type=general]()}}<br />{{printglossary[title=Information Model Terms, type=informationmodel]()}}<br />{{printglossary[title=Protocol Terms, type=protocol]()}}<br />{{printglossary[title=HTTP Terms, type=http]()}}<br />{{printglossary[title=XML Terms, type=xml]()}}<br />{{printglossary[title=MTConnect Terms, type=conceptmodel]()}}<br /><br />{{printacronyms()}}<br /><br />{{printbibliography[title=MTConnect References,keyword=MTC]()}}<br /><br />{{printbibliography[title=Other References,notkeyword=MTC]()}}<br /><br />{{glsaddall()}}<br/><br/><br />Fundamentals Appendix<br/>{{newpage()}} <br /><br />## Fundamentals of Using XML to Encode Response Documents<br /><br />The MTConnect Standard specifies the structures and constructs that are used to encode <i>response document</i>s.  When these <i>response document</i>s are encoded using XML, there are additional rules defined by the XML standard that apply for creating an XML compliant document.  An implementer should refer to the W3C website for additional information on XML documentation and implementation details - http://www.w3.org/XML.<br /><br />The following provides specific terms and guidelines referenced in the MTConnect Standard for forming <i>response document</i>s with XML:  <br /><br /><br />* <c>tag</c>:  A <c>tag</c> is an XML construct that forms the foundation for an XML expression.  It defines the scope (beginning and end) of an XML expression.  The main types of tags are: <br /><br />* <c>start-tag</c>:  Designates the beginning on an XML element; e.g., <<i>element name</i>> <br /><br />* <c>end-tag</c>:  Designates the end on an XML element; e.g., </<i>element name</i>>. <br /><br /><br />> Note: If an element has no <i>child element</i>s or <i>CDATA</i>, the <c>end-tag</c> may be shortened to />.<br /><br /><br />* <c>Element</c>:  An element is an XML statement that is the primary building block for a document encoded using XML.  An element begins with a <c>start-tag</c> and ends with a matching <c>end-tag</c>.  The characters between the <c>start-tag</c> and the <c>end-tag</c> are the element's content.  The content may contain attributes, <i>CDATA</i>, and/or other elements.  If the content contains additional elements, these elements are called <i>child element</i>s.<br /><br />An example would be:  <<i>element name</i>>Content of the Element</<i>element name</i>>.<br /><br />* <i>child element</i>:  An XML element that is contained within a higher-level <i>parent element</i>.  A <i>child element</i> is also known as a sub-element.  XML allows an unlimited hierarchy of <i>parent element</i>-<i>child element</i> relationships that establishes the structure that defines how the various pieces of information in the document relate to each other.  A <i>parent element</i> may have multiple associated <i>child element</i>s.<br /><br />* <i>element name</i>:  A descriptive identifier contained in both the <c>start-tag</c> and <c>end-tag</c> that provides the name of an XML element.<br /><br />* <c>Attribute</c>:  A construct consisting of a name–value pair that provides additional information about that XML element.  The format for an attribute is `name="value"; where the value for the attribute is enclosed in a set of quotation (“) marks.  An XML attribute <b>MUST</b> only have a single value and each attribute can appear at most once in each element.  Also, each attribute <b>MUST</b> be defined in a <i>schema</i> to either be required or optional.   <br /><br />* An example of attributes for an XML element is {{lst(example-of-attributes-for-an-element)}}:<br /><br />~~~~xml<br /><DataItem category="SAMPLE" id="S1load"<br />  nativeUnits="PERCENT"  type="LOAD"<br />  units="PERCENT"/><br />~~~~<br />{: caption="Example of attributes for an element"}<br /><br />In this example, <see cref="DataItem">DataItem</see> is the <i>element name</i>.  <c>category</c>, <c>id</c>, <c>nativeUnits</c>, <c>type</c>, and <c>units</c> are the names of the attributes.  “<c>SAMPLE</c>", “<c>S1load</c>", “<c>PERCENT</c>", “<c>LOAD</c>", and “<c>PERCENT</c>" are the values for each of the respective attributes.<br /><br /><i> <i>CDATA</i>:  <i>CDATA</i> is an XML term representing </i>Character Data<i>. </i>Character Data* contains a value(s) or text that is associated with an XML element.  <i>CDATA</i> can be restricted to certain formats, patterns, or words.  <br /><br />An example of <i>CDATA</i> associated with an XML element would be {{lst(example-of-cdata-associated-with-element)}}:<br /><br />~~~~xml<br /><Message id="M1">This is some text</Message><br />~~~~<br />{: caption="Example of cdata associated with element"}<br /><br />In this example, <c>Message</c> is the <i>element name</i> and <c>This is some text</c> is the <i>CDATA</i>.<br /><br />* <i>namespace</i>:  An XML <i>namespace</i> defines a unique vocabulary for named elements and attributes in an XML document.  An XML document may contain content that is associated with multiple <i>namespace</i>s.  Each <i>namespace</i> has its own unique identifier. <br /><br />Elements and attributes are associated with a specific <i>namespace</i> by placing a prefix on the name of the element or attribute that associates that name to a specific <i>namespace</i>; e.g., <c>x:MyTarget</c> associates the element name <c>MyTarget</c> with the <i>namespace</i> designated by <c>x:</c> (the prefix).<br /><br /><i>namespace</i>s are used to avoid naming conflicts within an XML document.  The naming convention used for elements and attributes may be associated with either the default <i>namespace</i> specified in the header of an XML document or they may be associated with one or more alternate <i>namespace</i>s.  All elements or attributes associated with a <i>namespace</i> that is not the default <i>namespace</i>, must include a prefix (e.g., x:) as part of the name of the element or attribute to associate it with the proper <i>namespace</i>.  See <see cref="Schema and Namespace Declaration Information">Schema and Namespace Declaration Information</see> for details on the structure for XML headers.<br /><br />The names of the elements and attributes declared in a <i>namespace</i> may be identified with a different prefix than the prefix that signifies that specific <i>namespace</i>.  These prefixes are called <i>namespace</i> aliases.  As an example, MTConnect Standard specific <i>namespace</i>s are designated as <c>m:</c> and the names of the elements and attributes defined in that <i>namespace</i> have an alias prefix of <c>mt:</c> which designates these names as MTConnect Standard specific vocabulary; e.g., <c>mt:MTConnectDevices</c>. <br /><br /><br />XML documents are encoded with a hierarchy of elements.  In general, XML elements may contain <i>child element</i>s, <i>CDATA</i>, or both.  However, in the MTConnect Standard, an element <b>MUST NOT</b> contain mixed content; meaning it cannot contain both <i>child element</i>s and <i>CDATA</i>. <br /><br />The <i>semantic data model</i> defined for each <i>response document</i> specifies the elements and <i>child element</i>s that may appear in a document.  The <i>semantic data model</i> also defines the number of times each element and <i>child element</i> may appear in the document.<br /><br />{{lst(example-of-hierarchy-of-xml-elements)}} demonstrates the hierarchy of XML elements and <i>child element</i>s used to form an XML document:<br /><br />~~~~xml<br /><Root Level>    (Parent Element)<br />  <First Level>  (Child Element to Root Level and <br />  Parent Element to Second Level)<br />    <Second Level>  (Child Element to First Level<br />    and Parent Element to Third Level)<br />      <Third Level name="N1"></Third Level>  <br />      (Child Element to Second Level)<br />      <Third Level name="N2"></Third Level>  <br />      (Child Element to Second Level)<br />      <Third Level name="N3"></Third Level>  <br />      (Child Element to Second Level)<br />    </Second Level>   (end-tag for Second Level)<br />  </First Level>   (end-tag for First Level)<br /></Root Level>   (end-tag for Root Level)<br />~~~~<br />{: caption="Example of hierarchy of XML elements"}<br /><br /><br />In the {{lst(example-of-hierarchy-of-xml-elements)}}, <i>Root Level</i> and <i>First Level</i> have one <i>child element</i> (sub-elements) each and Second Level has three <i>child element</i>s; each called <i>Third Level</i>.  Each <i>Third Level</i> element has a different name attribute.  Each level in the structure is an element and each lower level element is a <i>child element</i>.<br /><br />{{newpage()}}<br /><br />## Schema and Namespace Declaration Information<br /><br />There are four pseudo-attributes typically included in the header of a <i>response document</i> that declare the <i>schema</i> and <i>namespace</i> for the document.  Each of these pseudo-attributes provides specific information for a client software application to properly interpret the content of the <i>response document</i>.<br /><br />The pseudo-attributes include:<br /><br />* <c>xmlns:xsi</c> – The <c>xsi</c> portion of this attribute name stands for <i>XML Schema</i> instance.  An <i>XML Schema</i> instance provides information that may be used by a software application to interpret XML specific information within a document.  See the W3C website for more details on <c>xmlns:xsi</c>.<br /><br />* <c>xmlns</c> – Declares the default <i>namespace</i> associated with the content of the <i>response document</i>.  The default <i>namespace</i> is considered to apply to all elements and attributes whenever the name of the element or attribute does not contain a prefix identifying an alternate <i>namespace</i>.<br /><br />The value of this attribute is an URN identifying the name of the file that defines the details of the <i>namespace</i> content.  This URN provides a unique identify for the <i>namespace</i>.<br /><br />* <c>xmlns:m</c> – Declares the MTConnect specific <i>namespace</i> associated with the content of the <i>response document</i>.  There may be multiple <i>namespace</i>s declared for an XML document.  Each may be associated to the default <i>namespace</i> or it may be totally independent.  The <c>:m</c> designates that this is a specific MTConnect <i>namespace</i> which is directly associated with the default <i>namespace</i>.<br /><br /> <br />> Note:	See <see cref="Extensibility">Extensibility</see> for details regarding extended <i>namespace</i>s.<br /><br /><br />The value associated with this attribute is an URN identifying the name of the file that defines the details of the <i>namespace</i> content.<br /><br />* <c>xsi:schemaLocation</c> -  Declares the name for the <i>schema</i> associated with the <i>response document</i> and the location of the file that contains the details of the <i>schema</i> for that document.<br /><br />The value associated with this attribute has two parts:<br /><br />  * A URN identifying the name of the specific <i>XML Schema</i> instance associated with the <i>response document</i>.<br /><br />  * The path to the location where the file describing the specific <i>XML Schema</i> instance is located.  If the file is located in the same root directory where the <i>agent</i> is installed, then the local path MAY be declared.  Otherwise, a fully qualified URL must be declared to identify the location of the file.<br /><br /><br />> Note:	In the format of the value associated with <c>xsi:schemaLocation</c>, the URN and the path to the <i>schema</i> file <b>MUST</b> be separated by a “space”.<br /><br /><br />In {{lst(example-of-schema-and-namespace-declaration)}}, the first line is the XML declaration.  The second line is a <i>root element</i> called <c>MTConnectDevices</c>.  The remaining four lines are the pseudo-attributes of <c>MTCconnectDevices</c> that declare the XML <i>schema</i> and <i>namespace</i> associated with an <i>MTConnectDevices Response Document</i>.<br /><br />~~~~xml<br /><?xml version="1.0" encoding="UTF-8"?><br />  <MTConnectDevices<br />   xmlns:xsi=http://www.w3.org/2001/XMLSchema-instance<br />   xmlns="urn:mtconnect.org:MTConnectDevices:1.3"<br />   xmlns:m="urn:mtconnect.org:MTConnectDevices:1.3"<br />   xsi:schemaLocation="urn:mtconnect.org:<br />    MTConnectDevices:1.3 /schemas/MTConnectDevices\_1.3.xsd"><br />~~~~<br />{: caption="Example of schema and namespace declaration"}<br /><br />The format for the values provided for each of the pseudo-attributes <b>MUST</b> reference the <i>semantic data model</i> (e.g., <c>MTConnectDevices</c>, <c>MTConnectStreams</c>, <c>MTConnectAssets</c>, or <c>MTConnectError</c>) and the version (i.e.; <c>1.1</c>, <c>1.2</c>, <c>1.3</c>, etc.) of the MTConnect Standard that depict the <i>schema</i> and <i>namespace</i>(s) associated with a specific <i>response document</i>.<br /><br />When an implementer chooses to extend an MTConnect <i>data model</i> by adding custom data types or additional <i>structural element</i>s, the <i>schema</i> and <i>namespace</i> for that <i>data model</i> should be updated to reflect the additional content.  When this is done, the <i>namespace</i> and <i>schema</i> information in the header should be updated to reflect the URI for the extended <i>namespace</i> and <i>schema</i>. <br /><br />{{newpage()}}<br /><br />## Extensibility<br /><br />MTConnect is an extensible standard, which means that implementers <b>MAY</b> extend the <i>data model</i>s defined in the various sections of the MTConnect Standard to include information required for a specific implementation.  When these <i>data model</i>s are encoded using XML, the methods for extending these <i>data model</i>s are defined by the rules established for extending any XML schema (see the W3C website for more details on extending XML data models).<br /><br />The following are typical extensions that <b>MAY</b> be considered in the MTConnect <i>data model</i>s:<br /><br />* Additional <c>type</c> and <c>subtype</c> values for <i>DataItem</i>s.<br /><br />* Additional <i>structural element</i>s as containers.<br /><br />* Additional <see cref="Composition">Composition</see> elements.<br /><br />* New <see cref="Asset">Asset</see> types that are sub-typed from the abstract <see cref="Asset">Asset</see> type.<br /><br />* <i>child element</i>s that may be added to specific XML elements contained within the <i>MTConnect Information Model</i>s.  These extended elements <b>MUST</b> be identified in a separate <i>namespace</i>.<br /><br /><br />When extending an MTConnect <i>data model</i>, there are some basic rules restricting changes to the MTConnect <i>data model</i>s.<br /><br />When extending an MTConnect <i>data model</i>, an implementer:<br /><br />* <b>MUST NOT</b> add new value for category for <i>DataItem</i>s,<br /><br />* <b>MUST NOT</b> add new <i>root element</i>s,<br /><br />* <b>SHOULD NOT</b> add new <i>top level</i> <i>Component</i>s, and<br /><br />* <b>MUST NOT</b> add any new attributes or include any sub-elements to <see cref="Composition">Composition</see>.<br /><br />> Note:  Throughout the documents additional information is provided where extensibility may be acceptable or unacceptable to maintain compliance with the MTConnect Standard.<br /><br />When a <i>schema</i> representing a <i>data model</i> is extended, the <i>schema</i> and <i>namespace</i> declaration at the beginning of the corresponding <i>response document</i> <b>MUST</b> be updated to reflect the new <i>schema</i> and <i>namespace</i> so that a client software application can properly validate the <i>response document</i>.<br /><br />An XML example of a <i>schema</i> and <i>namespace</i> declaration, including an extended <i>schema</i> and <i>namespace</i>, is shown in {{lst(example-of-extended-schema-and-namespace-in-declaration)}}:<br /><br />~~~~xml<br /><?xml version="1.0" encoding="UTF-8"?><br />  <MTConnectDevices<br />   xmlns:xsi=http://www.w3.org/2001/XMLSchema-instance<br />   xmlns="urn:mtconnect.org:MTConnectDevices:1.3"<br />   xmlns:m="urn:mtconnect.org:MTConnectDevices:1.3"<br />   xmlns:x="urn:MyLocation:MyFile:MyVersion"<br />   xsi:schemaLocation="urn:MyLocation:MyFile:MyVersion<br />     /schemas/MyFileName.xsd" /><br />~~~~<br />{: caption="Example of extended schema and namespace in declaration"}<br /><br />In this example:<br /><br />* <c>xmlns:x</c> is added in Line 6 to identify the <i>XML Schema</i> instance for the extended <i>schema</i>.   <i>element name</i>s identified with an "<c>x</c>" prefix are associated with this specific <i>XML Schema</i> instance.<br /><br />> Note: The "<c>x</c>" prefix <b>MAY</b> be replaced with any prefix that the implementer chooses for identifying the extended <i>schema</i> and <i>namespace</i>.<br /><br />* <c>xsi:schemaLocation</c> is modified in Line 7 to associate the <i>namespace</i> URN with the URL specifying the location of <i>schema</i> file.<br /><br />* <c>MyLocation</c>, <c>MyFile</c>, <c>MyVersion</c>, and <c>MyFileName</c> in Lines 6 and 7 <b>MUST</b> be replaced by the actual name, version, and location of the extended <i>schema</i>.<br /><br />When an extended <i>schema</i> is implemented, each <i>structural element</i>, <i>DataItem</i>, and <i>asset</i> defined in the extended <i>schema</i> <b>MUST</b> be identified in each respective <i>response document</i> by adding a prefix to the XML <i>element name</i> associated with that <i>structural element</i>, <i>DataItem</i>, or <i>asset</i>.  The prefix identifies the <i>schema</i> and <i>namespace</i> where that XML Element is defined. <br /><br/><br/><br />Fundamentals Introduction<br/># Overview of MTConnect<br /><br />MTConnect is a data and information exchange standard that is based on a <i>data dictionary</i> of terms describing information associated with manufacturing operations.  The standard also defines a series of <i>semantic data model</i> that provide a clear and unambiguous representation of how that information relates to a manufacturing operation.  The MTConnect Standard has been designed to enhance the data acquisition capabilities from equipment in manufacturing facilities, to expand the use of data driven decision making in manufacturing operations, and to enable software applications and manufacturing equipment to move toward a plug-and-play environment to reduce the cost of integration of manufacturing software systems.<br /><br />The MTConnect standard supports two primary communications methods - <i>request and response</i> and <i>publish and subscribe</i> type of communications.  The <i>request and response</i> communications structure is used throughout this document to describe the functionality provided by MTConnect.  See <see cref="Streaming Data">Streaming Data</see> for details describing the functionality of the <i>publish and subscribe</i> communications structure available from an <i>agent</i>. <br /><br />Although the MTConnect Standard has been defined to specifically meet the requirements of the manufacturing industry, it can also be readily applied to other application areas as well.<br /><br />The MTConnect Standard is an open, royalty free standard – meaning that it is available for anyone to download, implement, and utilize in software systems at no cost to the implementer.<br /><br />The <i>semantic data model</i>s defined in the MTConnect Standard provide the information required to fully characterize data with both a clear and unambiguous meaning and a mechanism to directly relate that data to the manufacturing operation where the data originated.  Without a <i>semantic data model</i>, client software applications must apply an additional layer of logic to raw data to convey this same level of meaning and relationship to manufacturing operations.  The approach provided in the MTConnect Standard for modeling and organizing data allows software applications to easily interpret data from a wide variety of data sources which reduces the complexity and effort to develop applications.<br /><br />The data and information from a broad range of manufacturing equipment and systems are addressed by the MTConnect Standard.  Where the <i>data dictionary</i> and <i>semantic data model</i>s are insufficient to define some information within an implementation, an implementer may extend the <i>data dictionary</i> and <i>semantic data model</i> to address their specific requirements.  See <see cref="Extensibility">Extensibility</see> for guidelines related to extensibility of the MTConnect Standard.<br /><br />To assist in implementation, the MTConnect Standard is built upon the most prevalent standards in the manufacturing and software industries.  This maximizes the number of software tools available for implementation and provides the highest level of interoperability with other standards, software applications, and equipment used throughout manufacturing operations.  <br /><br />Current MTConnect implementations are based on HTTP as a transport protocol and XML as a language for encoding each of the <i>semantic data model</i>s into electronic documents.  All software examples provided in the various MTConnect Standard documents are based on these two core technologies.  <br /><br />The base functionality defined in the MTConnect Standard is the <i>data dictionary</i> describing manufacturing information and the <i>semantic data model</i>.  The transport protocol and the programming language used to represent or transfer the information provided by the <i>semantic data model</i>s are not restricted in the standard to HTTP and XML.  Therefore, other protocols and programming languages may be used to represent the semantic models and/or transport the information provided by these data models between an <i>agent</i> (server) and a client software application as may be required by a specific implementation.<br /><br />> Note: The term "document" is used with different meanings in the MTConnect Standard:<br /><br />* Meaning 1:  The MTConnect Standard itself is comprised of multiple documents each addressing different aspects of the Standard.  Each document is referred to as a Part of the Standard.<br /><br />* Meaning 2:  In an MTConnect implementation, the electronic documents that are published from a data source and stored by an <i>agent</i>.     <br /><br />* Meaning 3:  In an MTConnect implementation, the electronic documents generated by an <i>agent</i> for transmission to a client software application. <br /><br />The following will be used throughout the MTConnect Standard to distinguish between these different meanings for the term "document":<br /><br />* MTConnect Document(s) or Document(s) shall be used to refer to printed or electronic document(s) that represent a Part(s) of the MTConnect Standard.  <br /><br />* All reference to electronic documents that are received from a data source and stored in an <i>agent</i> shall be referred to as <i>document</i>(s) and are typically provided with a prefix identifier; e.g. asset document.<br /><br />* All references to electronic documents generated by an <i>agent</i> and sent to a client software application shall be referred to as a <i>response document</i>.  <br /><br />When used with no additional descriptor, the form "document" shall be used to refer to any printed or electronic document.<br /><br />Manufacturing software systems implemented utilizing MTConnect can be represented by a very simple structure as shown in {{figure(Basic MTConnect Implementation Structure)}}.<br /><br />![Basic MTConnect Implementation Structure](figures/basic-mtconnect-implementation-structure.png "Basic MTConnect Implementation Structure"){: width="0.8"}<br /><br />The three basic modules that comprise a software system implemented using MTConnect are:<br /><br />* Equipment:  Any data source.  In the MTConnect Standard, equipment is defined as any tangible property that is used to equip the operations of a manufacturing facility.  Examples of equipment are machine tools, ovens, sensor units, workstations, software applications, and bar feeders.<br /><br />* Agent:  Software that collects data published from one or more piece(s) of equipment, organizes that data in a structured manner, and responds to requests for data from client software systems by providing a structured response in the form of a <i>response document</i> that is constructed using the <i>semantic data model</i>s defined in the Standard. <br /><br />    > Note: The <i>agent</i> may be fully integrated into the piece of equipment or the <i>agent</i> may be independent of the piece of equipment.  Implementation of an <i>agent</i> is the responsibility of the supplier of the piece of equipment and/or the implementer of the <i>agent</i>.<br />    <br />* Client Software Application:  Software that requests data from <i>agent</i>s and processes that data in support of manufacturing operations. <br /><br />Based on {{figure(Basic MTConnect Implementation Structure)}}, it is important to understand that the MTConnect Standard only addresses the following functionality and behavior of an <i>agent</i>:<br /><br />* the method used by a client software application to request information from an <i>agent</i>.<br /><br />* the response that an <i>agent</i> provides to a client software application.<br /><br />* a <i>data dictionary</i> used to provide consistency in understanding the meaning of data reported by a data source.<br /><br />* the description of the <i>semantic data model</i>s used to structure <i>response document</i>s provided by an <i>agent</i> to a client software application.<br /><br />These functions are the primary building blocks that define the base functional structure of the MTConnect Standard.<br /><br />There are a wide variety of data sources (equipment) and data consumption systems (client software systems) used in manufacturing operations.  There are also many different uses for the data associated with a manufacturing operation.  No single approach to implementing a data communication system can address all data exchange and data management functions typically required in the data driven manufacturing environment.  MTConnect has been uniquely designed to address this diversity of data types and data usages by providing different <i>semantic data model</i>s for different data application requirements:<br /><br />* Data Collection: The most common use of data in manufacturing is the collection of data associated with the production of products and the operation of equipment that produces those products.  The MTConnect Standard provides comprehensive <i>semantic data model</i>s that represent data collected from manufacturing operations.  These <i>semantic data model</i>s are detailed in <see cref="Device Information Model">Device Information Model</see> and <see cref="Observation Information Model">Observation Information Model</see> of the MTConnect Standard.<br /><br />* Inter-operations Between Pieces of Equipment:  The MTConnect Standard provides an <i>interaction model</i> that structures the information required to allow multiple pieces of equipment to coordinate actions required to implement manufacturing activities.  This <i>interaction model</i> is an implementation of a <i>request and response</i>  messaging structure.  This <i>interaction model</i> is called <see cref="Interfaces">Interfaces</see> which is detailed in <see cref="Interface Interaction Model">Interface Interaction Model</see> of the MTConnect Standard.<br /><br />* Shared Data:  Certain information used in a manufacturing operation is commonly shared amongst multiple pieces of equipment and/or software applications.  This information is not typically "owned" by any one manufacturing resource.  The MTConnect Standard represents this information through a series of <i>semantic data model</i>s – each describing different types of information used in the manufacturing environment.  Each type of information is called an <i>Asset</i>. <i>Asset</i>s are detailed in <see cref="Asset Information Model">Asset Information Model</see>, and its sub-Parts, of the MTConnect Standard.<br /><br /># Purpose of This Document<br /><br />This document, <see cref="Fundamentals">Fundamentals</see> of the MTConnect  Standard, addresses two major topics relating to the MTConnect Standard.  The first sections of the document define the organization of the documents used to describe the MTConnect Standard; including the terms and terminology used throughout the Standard.  The balance of the document defines the following:<br /><br />* Operational concepts describing how an <i>agent</i> should organize and structure data that has been collected from a data source.<br /><br />* Definition and structure of the <i>response document</i>s supplied by an <i>agent</i>.<br /><br />* The protocol used by a client software application to communicate with an <i>agent</i>.<br /><br /><br /># Terminology and Conventions<br /><br />This section provides a dictionary of terms, reserved language, and document conventions used in the MTConnect Standard.<br /><br />{{printglossary[title=General Terms, type=general]()}}<br />{{printglossary[title=Information Model Terms, type=informationmodel]()}}<br />{{printglossary[title=Protocol Terms, type=protocol]()}}<br />{{printglossary[title=HTTP Terms, type=http]()}}<br />{{printglossary[title=XML Terms, type=xml]()}}<br />{{printglossary[title=MTConnect Terms, type=conceptmodel]()}}<br /><br />{{printacronyms()}}<br /><br />{{printbibliography[title=MTConnect References,keyword=MTC]()}}<br /><br />{{printbibliography[title=Other References,notkeyword=MTC]()}}<br /><br />{{glsaddall()}}<br /><br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1589301330036_553673_25">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class SupportingDocumentsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1589301330036_553673_25";
		
		/// <inheritdoc />
		public string Name => "Supporting Documents";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;Assets Appendix&#10;&#10;&#10;&#10;{{newpage()}}

## XML Schema Diagrams

See XML schemas for the MTConnect standard here: {{url(https://schemas.mtconnect.org/)}}.

### Assets Schema Diagrams

See `Asset` element in `MTConnectAssets` schema.

See `Description` element in `MTConnectAssets` schema.

### CuttingTool Schema Diagrams

See `CuttingTool` element in `MTConnectAssets` schema.

See `CuttingToolDefinition` element in `MTConnectAssets` schema.

See `CuttingToolArchetypeReference` element in `MTConnectAssets` schema.

### CuttingToolLifeCycle Schema Diagrams

See `CuttingToolLifeCycle` element in `MTConnectAssets` schema.

See `CutterStatus` element in `MTConnectAssets` schema.

See `Location` element in `MTConnectAssets` schema.

See `Measurement` element in `MTConnectAssets` schema.

See `ProcessFeedRate` element in `MTConnectAssets` schema.

See `ProcessSpindleSpeed` element in `MTConnectAssets` schema.

See `ReconditionCount` element in `MTConnectAssets` schema.

See `ToolLife` element in `MTConnectAssets` schema.

### CuttingItem Schema Diagrams

See `CuttingItems` element in `MTConnectAssets` schema.

See `CuttingItem` element in `MTConnectAssets` schema.

See `ItemLife` element in `MTConnectAssets` schema.

### ISO 13399 Diagrams

#### Measurement Diagrams

![Cutting Tool Measurement 3](figures/Cutting%20Tool%20Measurement%203.png ""Cutting Tool Measurement 3""){: width=""0.8""}

![Cutting Tool Measurement 4](figures/Cutting%20Tool%20Measurement%204.png ""Cutting Tool Measurement 4""){: width=""0.8""}

![Cutting Tool Measurement 5](figures/Cutting%20Tool%20Measurement%205.png ""Cutting Tool Measurement 5""){: width=""0.8""}

![Cutting Tool Measurement 6](figures/Cutting%20Tool%20Measurement%206.png ""Cutting Tool Measurement 6""){: width=""0.8""}

![Cutting Tool Measurement 7](figures/Cutting%20Tool%20Measurement%207.png ""Cutting Tool Measurement 7""){: width=""0.8""}

![Cutting Tool Measurement 8](figures/Cutting%20Tool%20Measurement%208.png ""Cutting Tool Measurement 8""){: width=""0.8""}

### Cutting Tool Examples

#### Shell Mill

![Shell Mill Side View](figures/Shell%20Mill%20Side%20View.png ""Shell Mill Side View""){: width=""0.8""}

![Indexable Insert Measurements](figures/Indexable%20Insert%20Measurements.png ""Indexable Insert Measurements""){: width=""0.8""}

~~~~xml
<?xml version=""1.0"" encoding=""UTF-8""?>
<MTConnectAssets 
xmlns:m=""urn:mtconnect.org:MTConnectAssets:1.2"" 
xmlns=""urn:mtconnect.org:MTConnectAssets:1.2"" 
xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" 
xsi:schemaLocation=""urn:mtconnect.org:MTConnectAssets:1.2
http://mtconnect.org/schemas/MTConnectAssets\\_1.2.xsd"">
  <Header creationTime=""2011-05-11T13:55:22"" 
  assetBufferSize=""1024"" sender=""localhost""
  assetCount=""2"" version=""1.2"" instanceId=""1234""/>
  <Assets>
  <CuttingTool serialNumber=""1"" toolId=""KSSP300R4SD43L240"" 
  timestamp=""2011-05-11T13:55:22"" assetId=""KSSP300R4SD43L240.1"" 
  manufacturers=""KMT,Parlec"">
    <CuttingToolLifeCycle>
    <CutterStatus><Status>NEW</Status></CutterStatus>
    <ProcessSpindleSpeed maximum=""13300"" 
    nominal=""605"">10000</ProcessSpindleSpeed>
    <ProcessFeedRate
    nominal=""9.22"">9.22</ProcessSpindleSpeed>
    <ConnectionCodeMachineSide>CV50
    </ConnectionCodeMachineSide>
    <Measurements>
      <BodyDiameterMax code=""BDX"">73.25
      </BodyDiameterMax>
      <OverallToolLength nominal=""222.25"" 
        minimum=""221.996"" maximum=""222.504"" 
        code=""OAL"">222.25</OverallToolLength>
      <UsableLengthMax code=""LUX"" nominal=""82.55"">82.55
      </UsableLengthMax>
      <CuttingDiameterMax code=""DC"" nominal=""76.2"" 
        maximum=""76.213"" minimum=""76.187"">76.2
      </CuttingDiameterMax>
      <BodyLengthMax code=""LF"" nominal=""120.65"" 
        maximum=""120.904"" minimum=""120.404"">120.65
      </BodyLengthMax>
      <DepthOfCutMax code=""APMX"" 
      nominal=""60.96"">60.95</DepthOfCutMax>
      <FlangeDiameterMax code=""DF"" 
        nominal=""98.425"">98.425</FlangeDiameterMax>
    </Measurements>
    <CuttingItems count=""24"">
      <CuttingItem indices=""1-24"" itemId=""SDET43PDER8GB"" 
        manufacturers=""KMT"" grade=""KC725M"">
        <Measurements>
          <CuttingEdgeLength code=""L"" nominal=""12.7"" 
            minimum=""12.675"" maximum=""12.725"">12.7
          </CuttingEdgeLength>
        <WiperEdgeLength code=""BS"" nominal=
          ""2.56"">2.56</WiperEdgeLength>
        <IncribedCircleDiameter code=""IC""
          nominal=""12.7"">12.7
        </IncribedCircleDiameter>
        <CornerRadius code=""RE"" nominal=""0.8"">
          0.8</CornerRadius>
      </Measurements>
      </CuttingItem>
    </CuttingItems>
    </CuttingToolLifeCycle>
    </CuttingTool>
  </Assets>
</MTConnectAssets>
~~~~
{: caption=""Example for Indexable Insert Measurements""}

{{pagebreak()}}

#### Step Drill

![Step Mill Side View](figures/Step%20Mill%20Side%20View.png ""Step Mill Side View""){: width=""0.8""}

~~~~xml
<?xml version=""1.0"" encoding=""UTF-8""?>
<MTConnectAssets xmlns:m=""urn:mtconnect.org:MTConnectAssets:1.2"" 
xmlns=""urn:mtconnect.org:MTConnectAssets:1.2"" 
xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" 
xsi:schemaLocation=""urn:mtconnect.org:MTConnectAssets:1.2 
http://mtconnect.org/schemas/MTConnectAssets\\_1.2.xsd"">
  <Header creationTime=""2011-05-
  11T13:55:22"" assetBufferSize=""1024"" 
  sender=""localhost"" assetCount=""2"" version=""1.2"" instanceId=""1234""/>
  <Assets>
    <CuttingTool serialNumber=""1 "" toolId=""B732A08500HP"" 
    timestamp=""2011-05-11T13:55:22"" assetId=""B732A08500HP "" 
    manufacturers=""KMT,Parlec"">
      <Description>
        Step Drill - KMT, B732A08500HP Grade KC7315
        Adapter - Parlec, C50-M12SF300-6
      </Description>
      <CuttingToolLifeCycle>
        <CutterStatus><Status>NEW</Status></CutterStatus>
        <ProcessSpindleSpeed nominal=""5893"">5893</ProcessSpindleSpeed>
        <ProcessFeedRate nominal=""2.5"">2.5</ProcessFeedRate>
        <ConnectionCodeMachineSide>CV50 Taper</ConnectionCodeMachineSide>
        <Measurements>
          <BodyDiameterMax code=""BDX"">31.8</BodyDiameterMax>
          <BodyLengthMax code=""LBX"" nominal=""120.825"" maximum=""126.325"" 
          minimum=""115.325"">120.825</BodyLengthMax>
          <ProtrudingLength code=""LPR"" nominal=""155.75"" maximum=""161.25"" 
          minimum=""150.26"">155.75</ProtrudingLength>
          <FlangeDiameterMax code=""DF"" 
          nominal=""98.425"">98.425</FlangeDiameterMax>
          <OverallToolLength nominal=""257.35"" minimum=""251.85"" 
          maximum=""262.85"" code=""OAL"">257.35</OverallToolLength>
        </Measurements>
        <CuttingItems count=""2"">
          <CuttingItem indices=""1"" manufacturers=""KMT"" grade=""KC7315"">>
            <Measurements>
              <CuttingDiameter code=""DC1"" nominal=""8.5"" maximum=""8.521"" 
              minimum=""8.506"">8.5135</CuttingDiameter>
              <StepIncludedAngle code=""STA1"" nominal=""90"" maximum=""91"" 
              minimum=""89"">90</StepIncludedAngle>
              <FunctionalLength code=""LF1"" nominal=""154.286"" 
              minimum=""148.786"" 
              maximum=""159.786"">154.286</FunctionalLength>
              <StepDiameterLength code=""SDL1"" 
              nominal=""9"">9</StepDiameterLength>
              <PointAngle code=""SIG"" nominal=""135"" minimum=""133"" 
              maximum=""137"">135</PointAngle>
            </Measurements>
          </CuttingItem>
          <CuttingItem indices=""2"" manufacturers=""KMT"" grade=""KC7315"">>
            <Measurements>
              <CuttingDiameter code=""DC2"" nominal=""12"" maximum=""12.011"" 
              minimum=""12"">12</CuttingDiameter>
              <FunctionalLength code=""LF2"" nominal=""122.493"" 
              maximum=""127.993"" 
              minimum=""116.993"">122.493</FunctionalLength>
              <StepDiameterLength code=""SDL2"" 
              nominal=""9"">9</StepDiameterLength>
            </Measurements>
          </CuttingItem>
        </CuttingItems>
      </CuttingToolLifeCycle>
    </CuttingTool>
  </Assets>
</MTConnectAssets>
~~~~
{: caption=""Example for Step Mill Side View""}

{{pagebreak()}}

#### Shell Mill with Individual Loci

![Shell Mill with Explicate Loci](figures/Shell%20Mill%20with%20Explicate%20Loci.png ""Shell Mill with Explicate Loci""){: width=""0.8""}

~~~~xml
<?xml version=""1.0"" encoding=""UTF-8""?>
<MTConnectAssets xmlns:m=""urn:mtconnect.org:MTConnectAssets:1.2"" 
xmlns=""urn:mtconnect.org:MTConnectAssets:1.2"" 
xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" 
xsi:schemaLocation=""urn:mtconnect.org:MTConnectAssets:1.2 
http://mtconnect.org/schemas/MTConnectAssets\\_1.2.xsd"">
  <Header creationTime=""2011-05-11T13:55:22"" assetBufferSize=""1024"" 
  sender=""localhost"" assetCount=""2"" version=""1.2"" instanceId=""1234""/>
  <Assets>
    <CuttingTool serialNumber=""1"" toolId=""KSSP300R4SD43L240"" 
    timestamp=""2011-05-11T13:55:22"" assetId=""KSSP300R4SD43L240.1"" 
    manufacturers=""KMT,Parlec"">
      <Description>Keyway: 55 degrees</Description>
      <CuttingToolLifeCycle>
        <CutterStatus><Status>NEW</Status></CutterStatus>
        <Measurements>
          <UsableLengthMax code=""LUX"" 
          nominal=""82.55"">82.55</UsableLengthMax>
          <CuttingDiameterMax code=""DC"" nominal=""76.2"" maximum=""76.213"" 
          minimum=""76.187"">76.2</CuttingDiameterMax>
          <DepthOfCutMax code=""APMX"" nominal=""60.96"">60.95</DepthOfCutMax>
        </Measurements>
        <CuttingItems count=""24"">
          <CuttingItem indices=""1"" itemId=""SDET43PDER8GB"" 
          manufacturers=""KMT"">
            <Locus>FLUTE: 1, ROW: 1</Locus>
            <Measurements>
             <DriveAngle code=""DRVA"" nominal=""55"">55</DriveAngle>
           </Measurements>
          </CuttingItem>
          <CuttingItem indices=""2-24"" itemId=""SDET43PDER8GB"" 
          manufacturers=""KMT"">
            <Locus>FLUTE: 2-4, ROW: 1; FLUTE: 1-4, ROW 2-6</Locus>
          </CuttingItem>
        </CuttingItems>
      </CuttingToolLifeCycle>
    </CuttingTool>
  </Assets>
</MTConnectAssets>
~~~~
{: caption=""Example for Shell Mill with Explicate Loci""}

{{pagebreak()}}

#### Drill with Individual Loci

![Step Drill with Explicate Loci](figures/Step%20Drill%20with%20Explicate%20Loci.png ""Step Drill with Explicate Loci""){: width=""0.8""}

~~~~xml
<?xml version=""1.0"" encoding=""UTF-8""?>
<MTConnectAssets xmlns:m=""urn:mtconnect.org:MTConnectAssets:1.2"" 
xmlns=""urn:mtconnect.org:MTConnectAssets:1.2"" 
xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" 
xsi:schemaLocation=""urn:mtconnect.org:MTConnectAssets:1.2 
http://mtconnect.org/schemas/MTConnectAssets\\_1.2.xsd"">
  <Header creationTime=""2011-05-11T13:55:22"" assetBufferSize=""1024"" 
  sender=""localhost"" assetCount=""2"" version=""1.2"" instanceId=""1234""/>
  <Assets>
    <CuttingTool serialNumber=""1"" toolId=""KSEM0781LD"" 
    timestamp=""2011-05-11T13:55:22"" assetId=""KSEM0781LD.1"" manufacturers=""KMT"">
      <CuttingToolLifeCycle>
        <CutterStatus><Status>NEW</Status></CutterStatus>
        <ConnectionCodeMachineSide>HSK63A</ConnectionCodeMachineSide>
        <Measurements>
          <BodyDiameterMax code=""BDX"">52.75</BodyDiameterMax>
          <OverallToolLength nominal=""172.29"" 
          code=""OAL"">172.29</OverallToolLength>
          <UsableLengthMax code=""LUX"" nominal=""49"">49</UsableLengthMax>
          <FlangeDiameterMax code=""DF"" 
          nominal=""62.94"">62.94</FlangeDiameterMax>
        </Measurements>
        <CuttingItems count=""3"">
          <CuttingItem indices=""1"" itemId=""KSEM0781LD"" manufacturers=""KMT"" 
          grade=""KC7015"">
            <Locus>FLUTE: 1, ROW: 1</Locus>
            <Measurements>
         <FunctionalLength code=""LF1"" nominal=""154.42"">154.42</FunctionalLength>
         <CuttingDiameter code=""DC1"" nominal=""19.844"">19.844</CuttingDiameter>
         <PointAngle code=""SIG"" nominal=""140"">140</PointAngle>
         <ToolCuttingEdgeAngle code=""KAPR1"" nominal=""45"">45</ToolCuttingEdgeAngle>
         <StepDiameterLength code=""SLD1"" nominal=""39.8"">39.8</StepDiameterLength>
            </Measurements>
          </CuttingItem>
          <CuttingItem indices=""2-3"" itemId=""TPMT-21.52-FP"" 
          manufacturers=""KMT"" grade=""KCM15"">
            <Locus>FLUTE: 1-2, ROW: 2</Locus>
            <Measurements>
         <FunctionalLength code=""LF2"" nominal=""112.9"">119.2</FunctionalLength>
         <CuttingDiameter code=""DC2"" nominal=""31"">31</CuttingDiameter>
            </Measurements>
          </CuttingItem>
        </CuttingItems>
      </CuttingToolLifeCycle>
    </CuttingTool>
  </Assets>
</MTConnectAssets>
~~~~
{: caption=""Example for Step Drill with Explicate Loci""}

{{pagebreak()}}

#### Shell Mill with Different Inserts on First Row

![Shell Mill with Different Inserts on First Row](figures/Shell%20Mill%20with%20Different%20Inserts%20on%20First%20Row.png ""Shell Mill with Different Inserts on First Row""){: width=""0.8""}

~~~~xml
<?xml version=""1.0"" encoding=""UTF-8""?>
<MTConnectAssets xmlns:m=""urn:mtconnect.org:MTConnectAssets:1.2"" 
xmlns=""urn:mtconnect.org:MTConnectAssets:1.2"" 
xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" 
xsi:schemaLocation=""urn:mtconnect.org:MTConnectAssets:1.2 
http://mtconnect.org/schemas/MTConnectAssets\\_1.2.xsd"">
  <Header creationTime=""2011-05-11T13:55:22"" assetBufferSize=""1024"" 
  sender=""localhost"" assetCount=""2"" version=""1.2"" instanceId=""1234""/>
  <Assets>
    <CuttingTool serialNumber=""1"" toolId=""XXX"" timestamp=""2011-05-11T13:55:22"" 
    assetId=""XXX.1"" manufacturers=""KMT"">
      <CuttingToolLifeCycle>
        <CutterStatus><Status>NEW</Status></CutterStatus>
        <Measurements>
          <DepthOfCutMax code=""APMX"" nominal=""47.8"">47.8</DepthOfCutMax>
          <CuttingDiameterMax code=""DC"" 
          nominal=""50.8"">50.8</CuttingDiameterMax>
          <UsableLengthMax code=""LUX"" 
          nominal=""78.74"">78.74</UsableLengthMax>
        </Measurements>
        <CuttingItems count=""9"">
          <CuttingItem indices=""1-3"" itemId=""EDPT180564PDER-LD"" 
          manufacturers=""KMT"">
            <Locus>FLUTE: 1-3, ROW: 1</Locus>
            <Measurements>
              <CornerRadius code=""RE"" nominal=""6.25"">6.35</CornerRadius>
            </Measurements>
          </CuttingItem>
          <CuttingItem indices=""4-9"" itemId=""EDPT180508PDER-LD"" 
          manufacturers=""KMT"">
            <Locus>FLANGE: 1-4, ROW: 2-3</Locus>
          </CuttingItem>
        </CuttingItems>
      </CuttingToolLifeCycle>
    </CuttingTool>
  </Assets>
</MTConnectAssets>
~~~~
{: caption=""Example for Shell Mill with Different Inserts on First Row""}

### File Schema Diagrams

See `File` element in `MTConnectAssets` schema.

### RawMaterial Schema Diagrams

See `RawMaterial` element in `MTConnectAssets` schema.

### QIFDocumentWrapper Schema Diagrams

See `QIFDocumentWrapper` element in `MTConnectAssets` schema.&#10;
&#10;&#10;&#10;Assets Introduction&#10;&#10;&#10;&#10;# Purpose of This Document

This document, {{package(Asset Information Model)}} of the MTConnect Standard, details information that is common to all types of {{termplural(Asset)}}.  Part 4.0 of the MTConnect Standard provide semantic models for entities that are used in the manufacturing process, but are not considered to be a piece of equipment.  These entities are defined as {{termplural(Asset)}}.  These {{termplural(asset)}} may be removed from a piece of equipment without detriment to the function of the equipment and can be associated with other pieces of equipment during their lifecycle.  The data associated with these {{termplural(asset)}} may be retrieved from multiple sources that are each responsible for providing their knowledge of the {{term(asset)}}.

# Terminology and Conventions

Refer to {{package(Fundamentals)}} for a dictionary of terms, reserved language, and document conventions used in the MTConnect Standard.

{{printglossary[title=General Terms, type=general]()}}
{{printglossary[title=Information Model Terms, type=informationmodel]()}}
{{printglossary[title=Protocol Terms, type=protocol]()}}
{{printglossary[title=HTTP Terms, type=http]()}}
{{printglossary[title=XML Terms, type=xml]()}}
{{printglossary[title=MTConnect Terms, type=conceptmodel]()}}

{{printacronyms()}}

{{printbibliography[title=MTConnect References,keyword=MTC]()}}

{{printbibliography[title=Other References,notkeyword=MTC]()}}

{{glsaddall()}}&#10;
&#10;&#10;&#10;Devices Introduction&#10;&#10;&#10;&#10;# Purpose of This Document

This document, {{package(Device Information Model)}} of the MTConnect Standard, establishes the rules and terminology to be used by designers to describe the function and operation of a piece of equipment and to define the data that is provided by an {{term(agent)}} from the equipment.  The {{term(Device Information Model)}}  also defines the structure for the {{term(response document)}} that is returned from an {{term(agent)}} in response to a {{term(probe request)}}. 

In the MTConnect Standard, equipment represents any tangible property that is used in the operations of a manufacturing facility.  Examples of equipment are machine tools, ovens, sensor units, workstations, software applications, and bar feeders. 

> Note: See {{package(Observation Information Model)}} of the MTConnect Standard for details on the {{term(response document)}} that are returned from an {{term(agent)}} in response to a {{term(sample request)}} or {{term(current request)}}.

# Terminology and Conventions

Refer to {{package(Fundamentals)}} for a dictionary of terms, reserved language, and document conventions used in the MTConnect Standard.

{{printglossary[title=General Terms, type=general]()}}
{{printglossary[title=Information Model Terms, type=informationmodel]()}}
{{printglossary[title=Protocol Terms, type=protocol]()}}
{{printglossary[title=HTTP Terms, type=http]()}}
{{printglossary[title=XML Terms, type=xml]()}}
{{printglossary[title=MTConnect Terms, type=conceptmodel]()}}

{{printacronyms()}}

{{printbibliography[title=MTConnect References,keyword=MTC]()}}

{{printbibliography[title=Other References,notkeyword=MTC]()}}

{{glsaddall()}}&#10;
&#10;&#10;&#10;Devices Appendix&#10;&#10;&#10;&#10;{{newpage()}} 

## XML Schema Diagrams

See XML schemas for the MTConnect standard here: {{url(https://schemas.mtconnect.org/)}}.

### Components Schema Diagrams

See `Components` element in `MTConnectDevices` schema.

See `Description` element in `MTConnectDevices` schema.

### DataItems Schema Diagrams

See `DataItems` element in `MTConnectDevices` schema.

See `Source` element in `MTConnectDevices` schema.

See `Constraints` element in `MTConnectDevices` schema.

See `Filter` element in `MTConnectDevices` schema.

See `Definition` element in `MTConnectDevices` schema.

### References Schema Diagrams

See `References` element in `MTConnectDevices` schema.

See `ComponentRef` element in `MTConnectDevices` schema.

See `DataItemRef` element in `MTConnectDevices` schema.

### Configuration Schema Diagrams

See `Configuration` element in `MTConnectDevices` schema.

See `CoordinateSystem` element in `MTConnectDevices` schema.

See `Motion` element in `MTConnectDevices` schema.

See `Relationships` element in `MTConnectDevices` schema.

See `ComponentRelationship` element in `MTConnectDevices` schema.

See `DeviceRelationship` element in `MTConnectDevices` schema.

See `SensorConfiguration` element in `MTConnectDevices` schema.

See `SolidModel` element in `MTConnectDevices` schema.

See `Specifications` element in `MTConnectDevices` schema.

See `ProcessSpecification` element in `MTConnectDevices` schema.

## XML Examples

### Device Entity Hierarchy Example

~~~~xml
<Devices>
  <Device id=""d1"" name=""M12346"" uuid=""M80104K162N"">
    <Components>
    <Axes id=""a"" name=""base"">
    <Components>
      <Linear id=""x"" name=""X""/>
      <Linear id=""y"" name=""Y""/>
      <Linear id=""z"" name=""Z""/>
      <Rotary id=""ar"" name=""B""/>
      <Linear id=""w"" name=""Z3"" nativeName=""W""/>
      <Rotary id=""c"" name=""C""/>
    </Components>
    </Axes>
    <Controller id=""cont"" name=""controller"">
    <Components>
      <Path id=""path1"" name=""path""/>
    </Components>
    </Controller>
    <Door id=""door1"" name=""door""/>
    <Systems id=""systems"" name=""systems"">
    <Components>
      <WorkEnvelope id=""we1"" name=""workenv"">
      <Compositions>
        <Composition type=""WORKPIECE"" id=""wp""/>
        <Composition type=""TABLE"" id=""tbl""/>
      </Compositions>
      </WorkEnvelope>
      <Electric id=""elec"" name=""electric""/>
      <Hydraulic id=""hydraulic"" name=""hydraulic""/>
      <Coolant id=""coolant"" name=""coolant""/>
      <Pneumatic id=""pneumatic"" name=""pneumatic""/>
      <Lubrication id=""lubrication"" name=""lubrication""/>
    </Components>
    </Systems>
    <Auxiliaries id=""Aux"" name=""auxiliaries"">
    <Components>
      <Environmental id=""room"" name=""environmental""/>
    </Components>
    </Auxiliaries>
    <Resources id=""resources"" name=""resources"">
    <Components>
      <Personnel id=""personnel"" name=""personnel""/>
      <Materials id=""materials"" name=""materials"">
      <Components>
        <Stock id=""procstock"" name=""stock""/>
      </Components>
      <Materials/>
    </Components> 
    </Resources>
    </Components>
  </Device>
</Devices>
~~~~
{: caption=""Device Entity Hierarchy Example""}

### Component Example

~~~~xml
<Devices>
  <Device id=""d1"" name=""M12346"" uuid=""M80104K162N"">
    <Description manufacturer=""Example_Corporation"" 
      serialNumber=""272237""> Mill w/SMooth-G
    </Description>
  <DataItems>
    <DataItem category=""EVENT"" id=""avail"" name=""avail"" type=""AVAILABILITY""/>
    <DataItem category=""EVENT"" id=""d1_asset_chg"" name=""asset_chg"" type=""ASSET_CHANGED""/>
    <DataItem category=""EVENT"" id=""d1_asset_rem"" name=""asset_rem"" type=""ASSET_REMOVED""/>
  </DataItems>
    <Components>
    <Controller id=""cont"" name=""controller"">
      <DataItems>
      <DataItem category=""EVENT"" id=""estop"" name=""estop"" type=""EMERGENCY_STOP""/>
      <DataItem category=""CONDITION"" id=""logic_cond"" type=""LOGIC_PROGRAM""/>
      <DataItem category=""CONDITION"" id=""cont_system"" type=""SYSTEM""/>
      <DataItem category=""SAMPLE"" id=""cut_time"" type=""ACCUMULATED_TIME"" units=""SECOND""/>
    </DataItems>
    <Components>
      <Path id=""path1"" name=""path"">
        <DataItems>
        <DataItem category=""EVENT"" id=""execution"" name=""execution"" type=""EXECUTION""/>
        <DataItem category=""SAMPLE"" id=""cspeed"" subType=""ACTUAL"" type=""CUTTING_SPEED"" units=""MILLIMETER/SECOND""/>
        <DataItem category=""CONDITION"" id=""path_system"" type=""SYSTEM""/>
        <DataItem category=""EVENT"" id=""cvars"" representation=""DATA_SET"" type=""VARIABLE""/>
        <DataItem category=""EVENT"" id=""woffset"" representation=""TABLE"" type=""WORK_OFFSET""/>
      </DataItems>
      </Path>
    </Components>
    </Controller>
  </Components>
  </Device>
</Devices>
~~~~
{: caption=""Component Example""}

### Component with Compositions Example

In {{term(XML)}}, `Composition` types are represented differently than `Component` types. For `Component` types, the element name is Pascal Case of the `Component` type name. Whereas, the element name for all `Composition`types is `Composition` and the type is defined by the `type` attribute of the element (see example below).

~~~~xml
<WorkEnvelope id=""we1"" name=""workenv"">
  <DataItems>
    <DataItem category=""CONDITION"" id=""hardware1"" name=""hardware1"" type=""HARDWARE""/>
  </DataItems>
  <Compositions>
  <Composition type=""WORKPIECE"" id=""wp""/>
  <Composition type=""TABLE"" id=""tbl""/>
  </Compositions>
</WorkEnvelope>
~~~~
{: caption=""Component with Compositions Example""}

### CoordinateSystem Example

~~~~xml
<Devices>
  <Device id=""d1"" name=""M12346"" uuid=""M80104K162N"">
    <Description manufacturer=""Example_Corporation"" 
      serialNumber=""272237""> Mill w/SMooth-G
    </Description>
    <DataItems>
      <DataItem id=""avail"" type=""AVAILABILITY"" category=""EVENT""/>
      <DataItem category=""EVENT"" id=""d1_asset_chg"" name=""asset_chg"" type=""ASSET_CHANGED""/>
      <DataItem category=""EVENT"" id=""d1_asset_rem"" name=""asset_rem"" type=""ASSET_REMOVED""/>
    </DataItems>
    <Configuration>
      <CoordinateSystems>
        <CoordinateSystem id=""base"" type=""BASE"">
          <Origin>0 0 0</Origin>
        </CoordinateSystem>
        <CoordinateSystem id=""machcoord"" type=""MACHINE"" parentIdRef=""base"">
          <Transformation>
            <Translation>210 275 1430</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
        <CoordinateSystem id=""workcoord"" type=""OBJECT"" parentIdRef=""machcoord"">
          <Transformation>
            <Translation>0 0 0</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
      </CoordinateSystems>
    </Configuration>
  </Device>
</Devices>
~~~~
{: caption=""CoordinateSystem Example""}

### Motion Example

~~~~xml
<Devices>
  <Device id=""d1"" name=""M12346"" uuid=""M80104K162N"">
    <Description manufacturer=""Example_Corporation"" 
      serialNumber=""272237""> Mill w/SMooth-G
    </Description>
    <DataItems>
      <DataItem id=""avail"" type=""AVAILABILITY"" category=""EVENT""/>
      <DataItem category=""EVENT"" id=""d1_asset_chg"" name=""asset_chg"" type=""ASSET_CHANGED""/>
      <DataItem category=""EVENT"" id=""d1_asset_rem"" name=""asset_rem"" type=""ASSET_REMOVED""/>
    </DataItems>
    <Configuration>
      <CoordinateSystems>
        <CoordinateSystem id=""base"" type=""BASE"">
          <Origin>0 0 0</Origin>
        </CoordinateSystem>
        <CoordinateSystem id=""machcoord"" type=""MACHINE"" parentIdRef=""base"">
          <Transformation>
            <Translation>210 275 1430</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
        <CoordinateSystem id=""workcoord"" type=""OBJECT"" parentIdRef=""machcoord"">
          <Transformation>
            <Translation>0 0 0</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
      </CoordinateSystems>
    </Configuration>
    <Components>
      <Axes id=""a"" name=""base"">
        <Components>
          <Linear id=""x"" name=""X"">
            <Configuration>
              <Motion id=""xmotion"" coordinateSystemIdRef=""machcoord"" type=""PRISMATIC"" actuation=""DIRECT"">
                <Transformation>
                  <Translaton>300 915 590</Translaton>
                  <Rotation>0 0 0</Rotation>
                </Transformation>
                <Axis>1.0 0 0</Axis>
              </Motion>
            </Configuration>
          </Linear>
          <DataItems>
            <DataItem id=""xtravel"" type=""SYSTEM"" category=""CONDITION"">
          </DataItems>
        </Components>
      </Axes>
    </Components>
  </Device>
</Devices>
~~~~
{: caption=""Motion Example""}

### Relationship Example

~~~~xml
<Components>
  <Axes id=""a"" name=""base"">
    <Components>
      <Linear id=""x"" name=""X"">
        <Configuration>        
          <Relationships>
            <ComponentRelationship id=""xpar"" type=""PARENT"" idRef=""we1""/>
          </Relationships>
        </Configuration>
      </Linear>
      <DataItems>
        <DataItem id=""xtravel"" type=""SYSTEM"" category=""CONDITION"">
      </DataItems>
    </Components>
  </Axes>
  <Systems id=""systems"" name=""systems"">
    <Components>
      <WorkEnvelope id=""we1"" name=""workenv"">
        <Compositions>
          <Composition type=""WORKPIECE"" id=""wp""/>
          <Composition type=""TABLE"" id=""tbl""/>
        </Compositions>
        <DataItems>
          <DataItem id=""we1cond"" type=""SYSTEM"" category=""CONDITION"">
        </DataItems>
      </WorkEnvelope>
    </Components>
  </Systems>
</Components>
~~~~
{: caption=""Relationship Example""}
      
### SolidModel Example

~~~~xml
<Devices>
  <Device id=""d1"" name=""M12346"" uuid=""M80104K162N"">
    <Description manufacturer=""Example_Corporation"" 
      serialNumber=""272237""> Mill w/SMooth-G
    </Description>
    <DataItems>
      <DataItem id=""avail"" type=""AVAILABILITY"" category=""EVENT""/>
      <DataItem category=""EVENT"" id=""d1_asset_chg"" name=""asset_chg"" type=""ASSET_CHANGED""/>
      <DataItem category=""EVENT"" id=""d1_asset_rem"" name=""asset_rem"" type=""ASSET_REMOVED""/>
    </DataItems>
    <Configuration>
      <CoordinateSystems>
        <CoordinateSystem id=""base"" type=""BASE"">
          <Origin>0 0 0</Origin>
        </CoordinateSystem>
        <CoordinateSystem id=""machcoord"" type=""MACHINE"" parentIdRef=""base"">
          <Transformation>
            <Translation>210 275 1430</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
        <CoordinateSystem id=""workcoord"" type=""OBJECT"" parentIdRef=""machcoord"">
          <Transformation>
            <Translation>0 0 0</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
      </CoordinateSystems>
    </Configuration>
    <Components>
      <Structures id=""struct"">
        <Configuration>
          <SolidModel id=""model"" mediaType=""OBJ"" href=""/objs/mazak.obj"" coordinateSystemIdRef=""base"">
            <Transformation>
              <Translation>0 860 0</Translation>
              <Rotation>-90 0 0</Rotation>
            </Transformation>
            <Scale>0.001 0.001 0.001</Scale>
          </SolidModel>
        </Configuration>
        <Components>
          <Structure id=""xaxis"" name=""X_AXIS"">
            <Configuration>
              <SolidModel id=""x_model"" mediaType=""OBJ"" itemRef=""xaxis"" solidModelIdRef=""model"" coordinateSystemIdRef=""base""/>
            </Configuration>
            <DataItems>
              <DataItem type=""SYSTEM"" category=""CONDITION"" id=""struct_cond""/>
            </DataItems>
          </Structure>
        </Components>
      </Structures>
    </Components>
  </Device>
</Devices>
~~~~
{: caption=""SolidModel Example""}

### Specification Example

~~~~xml
<Components>
  <Axes id=""a"" name=""base"">
    <Components>
      <Linear id=""x"" name=""X"">
        <Configuration>
          <Specifications>
            <Specification id=""spec001"" type=""LENGTH"" units=""MILLIMETER"">
              <Nominal>650</Nominal>
            </Specification>
            <Specification id=""spec002"" type=""LINEAR_FORCE"" units=""NEWTON"">
              <Maximum>5200</Maximum>
              <Minimum>0</Minimum>
            </Specification>
          </Specifications>
        </Configuration>
        <DataItems>
          <DataItem id=""xtravel"" type=""SYSTEM"" category=""CONDITION"">
        </DataItems>
      </Linear>
    </Components>
  </Axes>
</Components>
~~~~
{: caption=""Specification Example""}

### Example of sensing element provided as data item associated with a Component

~~~~xml
<Components>
  <Axes id=""a"" name=""base""
    <Components>
      <Rotary id=""c"" name=""C"">
        <DataItems>
          <DataItem type=""TEMPERATURE"" id=""servotemp4""
            category=""SAMPLE"" nativeUnits=""CELSIUS""
            compositionId=""Bmotor"" units=""CELSIUS""/>
          </DataItems>
      </Rotary>
    </Components>
  </Axes>
</Components>
~~~~
{: caption=""Example of sensing element provided as data item associated with a Component""}

### Example of Sensor for rotary axis

~~~~xml
<Components>
  <Axes id=""a"" name=""base""
    <Components>
      <Rotary id=""ar"" name=""B"">
        <Components>
          <Sensor id=""spdlm"" name=""Spindlemonitor"">
            <DataItems>
              <DataItem type=""DISPLACEMENT"" id=""cvib""
                category=""SAMPLE"" name=""Svib"" 
                units=""MILLIMETER""/>
            </DataItems>
          </Sensor >
        <Components>
      </Rotary>
    </Components>
  </Axes>
</Components>
~~~~
{: caption=""Example of Sensor for rotary axis""}

### Example of sensor unit with sensing element

~~~~xml
<Axes id=""a"" name=""base""
  <Components>
  <Sensor id=""sens1"" name=""Sensorunit"">
    <DataItems>
    <DataItem type=""TEMPERATURE"" id=""sentemp""
      category=""SAMPLE"" name=""Sensortemp"" 
      units=""CELSIUS""/> 
    </DataItems>
  </Sensor >
  <Linear id=""x"" name=""X"">
    <DataItems>
    <DataItem type=""DISPLACEMENT"" id=""xvib""
      category=""SAMPLE"" name=""xvib"" 
      units=""MILLIMETER"">
      <Source componentId=""sens1""/>
    </DataItem>
    </DataItems>
  </Rotary>
  <Linear id=""y"" name=""Y"">
    <DataItems>
    <DataItem type=""DISPLACEMENT"" id=""yvib"" 
      category=""SAMPLE"" name=""yvib"" 
      units=""MILLIMETER"">
      <Source componentId=""sens1""/>
    </DataItem>
    </DataItems>
  </Linear>
  <Components>
</Axes>
~~~~
{: caption=""Example of sensor unit with sensing element""}

### Example of configuration data for Sensor

~~~~xml
<Sensor id=""sensor"" name=""sensor"">
  <Configuration>
    <SensorConfiguration>
      <FirmwareVersion>2.02</FirmwareVersion>
      <CalibrationDate>2010-05-16</CalibrationDate>
      <NextCalibrationDate>2010-05-16</NextCalibrationDate>
      <CalibrationInitials>WS</CalibrationInitials>
      <Channels>
        <Channel number=""1"" name=""A/D:1"">
          <Description>A/D With Thermister</Description>
        </Channel>
      </Channels>
    </SensorConfiguration>
  </Configuration>
  <DataItems>
    <DataItem category=""CONDITION"" id=""sensorc"" 
      name=""sensorc"" type=""SYSTEM"" />
    <DataItem category=""SAMPLE"" id=""senv"" name=""sensorc""
      type=""VOLTAGE_DC"" units=""VOLT"" subType=""ACTUAL"" />
  </DataItems>
</Sensor>
~~~~
{: caption=""Example of configuration data for Sensor""}  &#10;
&#10;&#10;&#10;Observations Introduction&#10;&#10;&#10;&#10;# Purpose of This Document

This document, {{package(Observation Information Model)}} of the MTConnect Standard, establishes the rules and terminology that describes the information returned by an {{term(MTConnect Agent)}} from a piece of equipment.  The {{term(Observation Information Model}} also defines, in {{package(Observation Information Model)}}, the structure for the {{termplural(response document)}} that are returned from an {{term(agent)}} in response to a {{term(sample request)}} or {{term(current request)}}.  

{{package(Observation Information Model)}} is not a stand-alone document.   This document is used in conjunction with {{package(Fundamentals)}}  which defines the fundamentals of the operation of the MTConnect Standard and {{package(Device Information Model)}} that defines the semantic model representing the information that may be returned from a piece of equipment.

> Note: {{package(Interface Interaction Model)}} provides details on extensions to the {{term(Observation Information Model)}} required to describe the interactions between pieces of equipment.

In the MTConnect Standard, equipment represents any tangible property that is used in the operation of a manufacturing facility.  Examples of equipment are machine tools, ovens, sensor units, workstations, software applications, and bar feeders.

# Terminology and Conventions

Refer to {{package(Fundamentals)}} for a dictionary of terms, reserved language, and document conventions used in the MTConnect Standard.

{{printglossary[title=General Terms, type=general]()}}
{{printglossary[title=Information Model Terms, type=informationmodel]()}}
{{printglossary[title=Protocol Terms, type=protocol]()}}
{{printglossary[title=HTTP Terms, type=http]()}}
{{printglossary[title=XML Terms, type=xml]()}}
{{printglossary[title=MTConnect Terms, type=conceptmodel]()}}

{{printacronyms()}}

{{printbibliography[title=MTConnect References,keyword=MTC]()}}

{{printbibliography[title=Other References,notkeyword=MTC]()}}

{{glsaddall()}}&#10;
&#10;&#10;&#10;Observations Appendix&#10;&#10;&#10;&#10;{{newpage()}} 

## XML Schema Diagrams

### Observations Schema Diagrams

See `Streams` element in `MTConnectStreams` schema.

See `DeviceStream` element in `MTConnectStreams` schema.

See `ComponentStream` element in `MTConnectStreams` schema.

See `Sample` element in `MTConnectStreams` schema.

See `Event` element in `MTConnectStreams` schema.

See `Condition` element in `MTConnectStreams` schema.

### Representation Schema Diagrams

See `AbsTimeSeries` element in `MTConnectStreams` schema.

See `PartCountDiscrete` element in `MTConnectStreams` schema.

See `VariableDataSet` element in `MTConnectStreams` schema.

See `Entry` element in `MTConnectStreams` schema.

See `WorkOffsetTable` element in `MTConnectStreams` schema.

## XML Examples

### DeviceStream Example

~~~~xml
<Streams>
  <DeviceStream name=""M12346"" uuid=""M8010W4194N"">
    <ComponentStream component=""Device"" name=""M12346"" componentId=""d1"">
      <Events>
        <Availability dataItemId=""avail"" sequence=""156"" timestamp=""2021-10-01T14:26:38.668505Z"">AVAILABLE</Availability>
        <AssetChanged assetType=""CuttingTool"" dataItemId=""d1_asset_chg"" sequence=""75570"" timestamp=""2021-10-07T05:08:53.870206Z"">M8010W4194N1.120</AssetChanged>
        <AssetRemoved assetType=""CuttingTool"" dataItemId=""d1_asset_rem"" sequence=""140"" timestamp=""2021-10-01T11:40:08.101461Z"">UNAVAILABLE</AssetRemoved>
      </Events>
    </ComponentStream>
    <ComponentStream component=""Controller"" name=""controller"" componentId=""cont"">
      <Events>
        <EmergencyStop dataItemId=""estop"" sequence=""159"" timestamp=""2021-10-01T14:26:38.66869Z"">ARMED</EmergencyStop>
      </Events>
      <Samples>
        <AccumulatedTime dataItemId=""cut_time"" sequence=""75437"" timestamp=""2021-10-07T05:08:28.221704Z"">1763070.0</AccumulatedTime>
      </Samples>
      <Condition>
        <Unavailable dataItemId=""cont_system"" sequence=""72"" timestamp=""2021-10-11T21:04:03.251999Z"" type=""SYSTEM""/>
        <Warning dataItemId=""cont_system"" nativecode=""313"" nativeSeverity=""50"" sequence=""75573"" timestamp=""2021-10-07T05:08:58.518317Z"" type=""LOGIC_PROGRAM"">PALLET ARM DOWN RS. MALF.</Warning>
      </Condition>
    </ComponentStream>
    <ComponentStream component=""Path"" name=""path"" componentId=""path1"">
      <Events>
        <Execution dataItemId=""execution"" name=""execution"" sequence=""222623"" timestamp=""2021-10-12T06:04:32.761198Z"">INTERRUPTED</Execution>
        <VariableDataSet count=""2"" dataItemId=""cvars"" sequence=""126513"" timestamp=""2021-10-12T03:57:31.106559Z"">
          <Entry key=""100"">66.3314</Entry>
          <Entry key=""101"">167.2</Entry>
        </VariableDataSet>
        <WorkOffsetTable count=""2"" dataItemId=""woffset"" sequence=""222101"" timestamp=""2021-10-12T06:04:11.990531Z"">
          <Entry key=""G53.1"">
            <Cell key=""X"">1</Cell>
            <Cell key=""Y"">2</Cell>
            <Cell key=""Z"">3</Cell>
          </Entry>
          <Entry key=""G53.2"">
            <Cell key=""X"">4</Cell>
            <Cell key=""Y"">5</Cell>
            <Cell key=""Z"">6</Cell>
          </Entry>
        </WorkOffsetTable>
      </Events>
      <Samples>
        <CuttingSpeed dataItemId=""cspeed"" sequence=""112"" timestamp=""2021-10-07T05:08:28.221704Z"" subType=""ACTUAL"">UNAVAILABLE</CuttingSpeed>
      </Samples>
      <Condition>
        <Normal dataItemId=""path_system"" sequence=""153"" timestamp=""2021-10-11T21:04:03.262845Z"" type=""SYSTEM""/>
      </Condition>
    </ComponentStream>
  </DeviceStream>
</Streams>
~~~~
{: caption=""DeviceStream Example""}

### Observations made for DataItem Example

~~~~xml
<Components>
  <Controller id=""cont"" name=""controller"">
      <DataItems>
      <DataItem category=""EVENT"" id=""estop"" name=""estop"" type=""EMERGENCY_STOP""/>
    </DataItems>
  </Controller>
</Components>
~~~~
{: caption=""MTConnectDevices Response Document""}

~~~~xml
<ComponentStream component=""Controller"" name=""controller"" componentId=""cont"">
  <Events>
    <EmergencyStop dataItemId=""estop"" sequence=""159"" timestamp=""2021-10-01T14:26:38.66869Z"">ARMED</EmergencyStop>
  </Events>
</ComponentStream>
~~~~
{: caption=""MTConnectStreams Response Document""}

### Sample Example

~~~~xml
<Samples>
  <AccumulatedTime dataItemId=""cut_time"" sequence=""75437"" timestamp=""2021-10-07T05:08:28.221704Z"">1763070.0</AccumulatedTime>
  <CuttingSpeed dataItemId=""cspeed"" sequence=""112"" timestamp=""2021-10-07T05:08:28.221704Z"" subType=""ACTUAL"">UNAVAILABLE</CuttingSpeed>
</Samples>
~~~~
{: caption=""Sample Example""}

### Event Example

~~~~xml
<Events>
  <Availability dataItemId=""avail"" sequence=""156"" timestamp=""2021-10-01T14:26:38.668505Z"">AVAILABLE</Availability>
  <AssetRemoved assetType=""CuttingTool"" dataItemId=""d1_asset_rem"" sequence=""140"" timestamp=""2021-10-01T11:40:08.101461Z"">UNAVAILABLE</AssetRemoved>
</Events>
~~~~
{: caption=""Event Example""}

### Condition Example

{{block(Condition)}} types are represented differently in {{term(XML)}} when compared to {{block(Sample)}} and {{block(Event)}} types. The element name is the {{term(condition state)}} of the {{block(Condition)}} type in Pascal Case. The name of the {{block(Condition)}} type is represented by the attribute `type`.

If the {{term(condition state)}} is unavailable then the element name is represented by `Unavailable`.

~~~~xml
<Condition>
  <Unavailable dataItemId=""cont_system"" sequence=""72"" timestamp=""2021-10-11T21:04:03.251999Z"" type=""SYSTEM""/>
  <Normal dataItemId=""path_system"" sequence=""153"" timestamp=""2021-10-11T21:04:03.262845Z"" type=""SYSTEM""/>
  <Warning dataItemId=""cont_system"" nativecode=""313"" nativeSeverity=""50"" sequence=""75573"" timestamp=""2021-10-07T05:08:58.518317Z"" type=""LOGIC_PROGRAM"">PALLET ARM DOWN RS. MALF.</Warning>
</Condition>
~~~~
{: caption=""Condition Example""}

### DataSet Example

~~~~xml
<Events>
  <VariableDataSet count=""2"" dataItemId=""cvars"" sequence=""126513"" timestamp=""2021-10-12T03:57:31.106559Z"">
    <Entry key=""100"">66.3314</Entry>
    <Entry key=""101"">167.2</Entry>
  </VariableDataSet>
</Events>
~~~~
{: caption=""DataSet Example""}

### Table Example

~~~~xml
<Events>
  <WorkOffsetTable count=""2"" dataItemId=""woffset"" sequence=""222101"" timestamp=""2021-10-12T06:04:11.990531Z"">
    <Entry key=""G53.1"">
      <Cell key=""X"">1</Cell>
      <Cell key=""Y"">2</Cell>
      <Cell key=""Z"">3</Cell>
    </Entry>
    <Entry key=""G53.2"">
      <Cell key=""X"">4</Cell>
      <Cell key=""Y"">5</Cell>
      <Cell key=""Z"">6</Cell>
    </Entry>
  </WorkOffsetTable>
</Events>
~~~~
{: caption=""Table Example""}&#10;
&#10;&#10;&#10;Interfaces Introduction&#10;&#10;&#10;&#10;# Purpose of This Document

This document, {{package(Interface Interaction Model)}} of the MTConnect Standard, defines a structured data model used to organize information required to coordinate inter-operations between pieces of equipment.  

This data model is based on an {{term(interaction model)}} that defines the exchange of information between pieces of equipment and is organized in the MTConnect Standard by {{block(Interfaces)}}.   

{{block(Interfaces)}} is modeled as an extension to the {{term(Device Information Model)}} and {{term(Observation Information Model)}}.  {{block(Interfaces)}} leverages similar rules and terminology as those used to describe a component in the {{term(Device Information Model)}}.  {{block(Interfaces)}} also uses similar methods for reporting data to those used in the {{term(MTConnectStreams Response Document)}}.  

As defined in {{package(Device Information Model)}}, {{block(Interfaces)}} {{termplural(organize)}} the {{block(Interface)}} types (see {{figure(Interfaces in Entity Hierarchy)}}).  Each individual {{block(Interface)}} contains data associated with the corresponding {{term(interface)}}.

> Note: See {{package(Device Information Model)}} and {{package(Observation Information Model)}} of the MTConnect Standard for information on how {{block(Interfaces)}} is structured in the {{termplural(response document)}} which are returned from an {{term(agent)}} in response to a {{term(probe request)}}, {{term(sample request)}}, or {{term(current request)}}.

# Terminology and Conventions

Refer to {{package(Fundamentals)}} for a dictionary of terms, reserved language, and document conventions used in the MTConnect Standard.

{{printglossary[title=General Terms, type=general]()}}
{{printglossary[title=Information Model Terms, type=informationmodel]()}}
{{printglossary[title=Protocol Terms, type=protocol]()}}
{{printglossary[title=HTTP Terms, type=http]()}}
{{printglossary[title=XML Terms, type=xml]()}}
{{printglossary[title=MTConnect Terms, type=conceptmodel]()}}

{{printacronyms()}}

{{printbibliography[title=MTConnect References,keyword=MTC]()}}

{{printbibliography[title=Other References,notkeyword=MTC]()}}

{{glsaddall()}}&#10;
&#10;&#10;&#10;Fundamentals Appendix&#10;&#10;&#10;&#10;{{newpage()}} 

## Fundamentals of Using XML to Encode Response Documents

The MTConnect Standard specifies the structures and constructs that are used to encode {{termplural(response document)}}.  When these {{termplural(response document)}} are encoded using XML, there are additional rules defined by the XML standard that apply for creating an XML compliant document.  An implementer should refer to the W3C website for additional information on XML documentation and implementation details - http://www.w3.org/XML.

The following provides specific terms and guidelines referenced in the MTConnect Standard for forming {{termplural(response document)}} with XML:  


* `tag`:  A `tag` is an XML construct that forms the foundation for an XML expression.  It defines the scope (beginning and end) of an XML expression.  The main types of tags are: 

* `start-tag`:  Designates the beginning on an XML element; e.g., <{{term(element name)}}> 

* `end-tag`:  Designates the end on an XML element; e.g., </{{term(element name)}}>. 


> Note: If an element has no {{termplural(child element)}} or {{term(CDATA)}}, the `end-tag` may be shortened to />.


* `Element`:  An element is an XML statement that is the primary building block for a document encoded using XML.  An element begins with a `start-tag` and ends with a matching `end-tag`.  The characters between the `start-tag` and the `end-tag` are the element's content.  The content may contain attributes, {{term(CDATA)}}, and/or other elements.  If the content contains additional elements, these elements are called {{termplural(child element)}}.

An example would be:  <{{term(element name)}}>Content of the Element</{{term(element name)}}>.

* {{term(child element)}}:  An XML element that is contained within a higher-level {{term(parent element)}}.  A {{term(child element)}} is also known as a sub-element.  XML allows an unlimited hierarchy of {{term(parent element)}}-{{term(child element)}} relationships that establishes the structure that defines how the various pieces of information in the document relate to each other.  A {{term(parent element)}} may have multiple associated {{termplural(child element)}}.

* {{term(element name)}}:  A descriptive identifier contained in both the `start-tag` and `end-tag` that provides the name of an XML element.

* `Attribute`:  A construct consisting of a name–value pair that provides additional information about that XML element.  The format for an attribute is `name=""value""; where the value for the attribute is enclosed in a set of quotation (“) marks.  An XML attribute **MUST** only have a single value and each attribute can appear at most once in each element.  Also, each attribute **MUST** be defined in a {{term(schema)}} to either be required or optional.   

* An example of attributes for an XML element is {{lst(example-of-attributes-for-an-element)}}:

~~~~xml
<DataItem category=""SAMPLE"" id=""S1load""
  nativeUnits=""PERCENT""  type=""LOAD""
  units=""PERCENT""/>
~~~~
{: caption=""Example of attributes for an element""}

In this example, {{block(DataItem)}} is the {{term(element name)}}.  `category`, `id`, `nativeUnits`, `type`, and `units` are the names of the attributes.  “`SAMPLE`"", “`S1load`"", “`PERCENT`"", “`LOAD`"", and “`PERCENT`"" are the values for each of the respective attributes.

* {{term(CDATA)}}:  {{term(CDATA)}} is an XML term representing *Character Data*. *Character Data* contains a value(s) or text that is associated with an XML element.  {{term(CDATA)}} can be restricted to certain formats, patterns, or words.  

An example of {{term(CDATA)}} associated with an XML element would be {{lst(example-of-cdata-associated-with-element)}}:

~~~~xml
<Message id=""M1"">This is some text</Message>
~~~~
{: caption=""Example of cdata associated with element""}

In this example, `Message` is the {{term(element name)}} and `This is some text` is the {{term(CDATA)}}.

* {{term(namespace)}}:  An XML {{term(namespace)}} defines a unique vocabulary for named elements and attributes in an XML document.  An XML document may contain content that is associated with multiple {{termplural(namespace)}}.  Each {{term(namespace)}} has its own unique identifier. 

Elements and attributes are associated with a specific {{term(namespace)}} by placing a prefix on the name of the element or attribute that associates that name to a specific {{term(namespace)}}; e.g., `x:MyTarget` associates the element name `MyTarget` with the {{term(namespace)}} designated by `x:` (the prefix).

{{termplural(namespace)}} are used to avoid naming conflicts within an XML document.  The naming convention used for elements and attributes may be associated with either the default {{term(namespace)}} specified in the header of an XML document or they may be associated with one or more alternate {{termplural(namespace)}}.  All elements or attributes associated with a {{term(namespace)}} that is not the default {{term(namespace)}}, must include a prefix (e.g., x:) as part of the name of the element or attribute to associate it with the proper {{term(namespace)}}.  See {{sect(Schema and Namespace Declaration Information)}} for details on the structure for XML headers.

The names of the elements and attributes declared in a {{term(namespace)}} may be identified with a different prefix than the prefix that signifies that specific {{term(namespace)}}.  These prefixes are called {{term(namespace)}} aliases.  As an example, MTConnect Standard specific {{termplural(namespace)}} are designated as `m:` and the names of the elements and attributes defined in that {{term(namespace)}} have an alias prefix of `mt:` which designates these names as MTConnect Standard specific vocabulary; e.g., `mt:MTConnectDevices`. 


XML documents are encoded with a hierarchy of elements.  In general, XML elements may contain {{termplural(child element)}}, {{term(CDATA)}}, or both.  However, in the MTConnect Standard, an element **MUST NOT** contain mixed content; meaning it cannot contain both {{termplural(child element)}} and {{term(CDATA)}}. 

The {{term(semantic data model)}} defined for each {{term(response document)}} specifies the elements and {{termplural(child element)}} that may appear in a document.  The {{term(semantic data model)}} also defines the number of times each element and {{term(child element)}} may appear in the document.

{{lst(example-of-hierarchy-of-xml-elements)}} demonstrates the hierarchy of XML elements and {{termplural(child element)}} used to form an XML document:

~~~~xml
<Root Level>    (Parent Element)
  <First Level>  (Child Element to Root Level and 
  Parent Element to Second Level)
    <Second Level>  (Child Element to First Level
    and Parent Element to Third Level)
      <Third Level name=""N1""></Third Level>  
      (Child Element to Second Level)
      <Third Level name=""N2""></Third Level>  
      (Child Element to Second Level)
      <Third Level name=""N3""></Third Level>  
      (Child Element to Second Level)
    </Second Level>   (end-tag for Second Level)
  </First Level>   (end-tag for First Level)
</Root Level>   (end-tag for Root Level)
~~~~
{: caption=""Example of hierarchy of XML elements""}


In the {{lst(example-of-hierarchy-of-xml-elements)}}, *Root Level* and *First Level* have one {{term(child element)}} (sub-elements) each and Second Level has three {{termplural(child element)}}; each called *Third Level*.  Each *Third Level* element has a different name attribute.  Each level in the structure is an element and each lower level element is a {{term(child element)}}.

{{newpage()}}

## Schema and Namespace Declaration Information

There are four pseudo-attributes typically included in the header of a {{term(response document)}} that declare the {{term(schema)}} and {{term(namespace)}} for the document.  Each of these pseudo-attributes provides specific information for a client software application to properly interpret the content of the {{term(response document)}}.

The pseudo-attributes include:

* `xmlns:xsi` – The `xsi` portion of this attribute name stands for {{term(XML Schema)}} instance.  An {{term(XML Schema)}} instance provides information that may be used by a software application to interpret XML specific information within a document.  See the W3C website for more details on `xmlns:xsi`.

* `xmlns` – Declares the default {{term(namespace)}} associated with the content of the {{term(response document)}}.  The default {{term(namespace)}} is considered to apply to all elements and attributes whenever the name of the element or attribute does not contain a prefix identifying an alternate {{term(namespace)}}.

The value of this attribute is an URN identifying the name of the file that defines the details of the {{term(namespace)}} content.  This URN provides a unique identify for the {{term(namespace)}}.

* `xmlns:m` – Declares the MTConnect specific {{term(namespace)}} associated with the content of the {{term(response document)}}.  There may be multiple {{termplural(namespace)}} declared for an XML document.  Each may be associated to the default {{term(namespace)}} or it may be totally independent.  The `:m` designates that this is a specific MTConnect {{term(namespace)}} which is directly associated with the default {{term(namespace)}}.

 
> Note:	See {{sect(Extensibility)}} for details regarding extended {{termplural(namespace)}}.


The value associated with this attribute is an URN identifying the name of the file that defines the details of the {{term(namespace)}} content.

* `xsi:schemaLocation` -  Declares the name for the {{term(schema)}} associated with the {{term(response document)}} and the location of the file that contains the details of the {{term(schema)}} for that document.

The value associated with this attribute has two parts:

  * A URN identifying the name of the specific {{term(XML Schema)}} instance associated with the {{term(response document)}}.

  * The path to the location where the file describing the specific {{term(XML Schema)}} instance is located.  If the file is located in the same root directory where the {{term(agent)}} is installed, then the local path MAY be declared.  Otherwise, a fully qualified URL must be declared to identify the location of the file.


> Note:	In the format of the value associated with `xsi:schemaLocation`, the URN and the path to the {{term(schema)}} file **MUST** be separated by a “space”.


In {{lst(example-of-schema-and-namespace-declaration)}}, the first line is the XML declaration.  The second line is a {{term(root element)}} called `MTConnectDevices`.  The remaining four lines are the pseudo-attributes of `MTCconnectDevices` that declare the XML {{term(schema)}} and {{term(namespace)}} associated with an {{term(MTConnectDevices Response Document)}}.

~~~~xml
<?xml version=""1.0"" encoding=""UTF-8""?>
  <MTConnectDevices
   xmlns:xsi=http://www.w3.org/2001/XMLSchema-instance
   xmlns=""urn:mtconnect.org:MTConnectDevices:1.3""
   xmlns:m=""urn:mtconnect.org:MTConnectDevices:1.3""
   xsi:schemaLocation=""urn:mtconnect.org:
    MTConnectDevices:1.3 /schemas/MTConnectDevices\\_1.3.xsd"">
~~~~
{: caption=""Example of schema and namespace declaration""}

The format for the values provided for each of the pseudo-attributes **MUST** reference the {{term(semantic data model)}} (e.g., `MTConnectDevices`, `MTConnectStreams`, `MTConnectAssets`, or `MTConnectError`) and the version (i.e.; `1.1`, `1.2`, `1.3`, etc.) of the MTConnect Standard that depict the {{term(schema)}} and {{term(namespace)}}(s) associated with a specific {{term(response document)}}.

When an implementer chooses to extend an MTConnect {{term(data model)}} by adding custom data types or additional {{termplural(structural element)}}, the {{term(schema)}} and {{term(namespace)}} for that {{term(data model)}} should be updated to reflect the additional content.  When this is done, the {{term(namespace)}} and {{term(schema)}} information in the header should be updated to reflect the URI for the extended {{term(namespace)}} and {{term(schema)}}. 

{{newpage()}}

## Extensibility

MTConnect is an extensible standard, which means that implementers **MAY** extend the {{termplural(data model)}} defined in the various sections of the MTConnect Standard to include information required for a specific implementation.  When these {{termplural(data model)}} are encoded using XML, the methods for extending these {{termplural(data model)}} are defined by the rules established for extending any XML schema (see the W3C website for more details on extending XML data models).

The following are typical extensions that **MAY** be considered in the MTConnect {{termplural(data model)}}:

* Additional `type` and `subtype` values for {{termplural(DataItem)}}.

* Additional {{termplural(structural element)}} as containers.

* Additional {{block(Composition)}} elements.

* New {{block(Asset)}} types that are sub-typed from the abstract {{block(Asset)}} type.

* {{termplural(child element)}} that may be added to specific XML elements contained within the {{termplural(MTConnect Information Model)}}.  These extended elements **MUST** be identified in a separate {{term(namespace)}}.


When extending an MTConnect {{term(data model)}}, there are some basic rules restricting changes to the MTConnect {{termplural(data model)}}.

When extending an MTConnect {{term(data model)}}, an implementer:

* **MUST NOT** add new value for category for {{termplural(DataItem)}},

* **MUST NOT** add new {{termplural(root element)}},

* **SHOULD NOT** add new {{term(top level)}} {{termplural(Component)}}, and

* **MUST NOT** add any new attributes or include any sub-elements to {{block(Composition)}}.

> Note:  Throughout the documents additional information is provided where extensibility may be acceptable or unacceptable to maintain compliance with the MTConnect Standard.

When a {{term(schema)}} representing a {{term(data model)}} is extended, the {{term(schema)}} and {{term(namespace)}} declaration at the beginning of the corresponding {{term(response document)}} **MUST** be updated to reflect the new {{term(schema)}} and {{term(namespace)}} so that a client software application can properly validate the {{term(response document)}}.

An XML example of a {{term(schema)}} and {{term(namespace)}} declaration, including an extended {{term(schema)}} and {{term(namespace)}}, is shown in {{lst(example-of-extended-schema-and-namespace-in-declaration)}}:

~~~~xml
<?xml version=""1.0"" encoding=""UTF-8""?>
  <MTConnectDevices
   xmlns:xsi=http://www.w3.org/2001/XMLSchema-instance
   xmlns=""urn:mtconnect.org:MTConnectDevices:1.3""
   xmlns:m=""urn:mtconnect.org:MTConnectDevices:1.3""
   xmlns:x=""urn:MyLocation:MyFile:MyVersion""
   xsi:schemaLocation=""urn:MyLocation:MyFile:MyVersion
     /schemas/MyFileName.xsd"" />
~~~~
{: caption=""Example of extended schema and namespace in declaration""}

In this example:

* `xmlns:x` is added in Line 6 to identify the {{term(XML Schema)}} instance for the extended {{term(schema)}}.   {{termplural(element name)}} identified with an ""`x`"" prefix are associated with this specific {{term(XML Schema)}} instance.

> Note: The ""`x`"" prefix **MAY** be replaced with any prefix that the implementer chooses for identifying the extended {{term(schema)}} and {{term(namespace)}}.

* `xsi:schemaLocation` is modified in Line 7 to associate the {{term(namespace)}} URN with the URL specifying the location of {{term(schema)}} file.

* `MyLocation`, `MyFile`, `MyVersion`, and `MyFileName` in Lines 6 and 7 **MUST** be replaced by the actual name, version, and location of the extended {{term(schema)}}.

When an extended {{term(schema)}} is implemented, each {{term(structural element)}}, {{term(DataItem)}}, and {{term(asset)}} defined in the extended {{term(schema)}} **MUST** be identified in each respective {{term(response document)}} by adding a prefix to the XML {{term(element name)}} associated with that {{term(structural element)}}, {{term(DataItem)}}, or {{term(asset)}}.  The prefix identifies the {{term(schema)}} and {{term(namespace)}} where that XML Element is defined. 
&#10;
&#10;&#10;&#10;Fundamentals Introduction&#10;&#10;&#10;&#10;# Overview of MTConnect

MTConnect is a data and information exchange standard that is based on a {{term(data dictionary)}} of terms describing information associated with manufacturing operations.  The standard also defines a series of {{term(semantic data model)}} that provide a clear and unambiguous representation of how that information relates to a manufacturing operation.  The MTConnect Standard has been designed to enhance the data acquisition capabilities from equipment in manufacturing facilities, to expand the use of data driven decision making in manufacturing operations, and to enable software applications and manufacturing equipment to move toward a plug-and-play environment to reduce the cost of integration of manufacturing software systems.

The MTConnect standard supports two primary communications methods - {{term(request and response)}} and {{term(publish and subscribe)}} type of communications.  The {{term(request and response)}} communications structure is used throughout this document to describe the functionality provided by MTConnect.  See {{sect(Streaming Data)}} for details describing the functionality of the {{term(publish and subscribe)}} communications structure available from an {{term(agent)}}. 

Although the MTConnect Standard has been defined to specifically meet the requirements of the manufacturing industry, it can also be readily applied to other application areas as well.

The MTConnect Standard is an open, royalty free standard – meaning that it is available for anyone to download, implement, and utilize in software systems at no cost to the implementer.

The {{termplural(semantic data model)}} defined in the MTConnect Standard provide the information required to fully characterize data with both a clear and unambiguous meaning and a mechanism to directly relate that data to the manufacturing operation where the data originated.  Without a {{term(semantic data model)}}, client software applications must apply an additional layer of logic to raw data to convey this same level of meaning and relationship to manufacturing operations.  The approach provided in the MTConnect Standard for modeling and organizing data allows software applications to easily interpret data from a wide variety of data sources which reduces the complexity and effort to develop applications.

The data and information from a broad range of manufacturing equipment and systems are addressed by the MTConnect Standard.  Where the {{term(data dictionary)}} and {{termplural(semantic data model)}} are insufficient to define some information within an implementation, an implementer may extend the {{term(data dictionary)}} and {{term(semantic data model)}} to address their specific requirements.  See {{sect(Extensibility)}} for guidelines related to extensibility of the MTConnect Standard.

To assist in implementation, the MTConnect Standard is built upon the most prevalent standards in the manufacturing and software industries.  This maximizes the number of software tools available for implementation and provides the highest level of interoperability with other standards, software applications, and equipment used throughout manufacturing operations.  

Current MTConnect implementations are based on HTTP as a transport protocol and XML as a language for encoding each of the {{termplural(semantic data model)}} into electronic documents.  All software examples provided in the various MTConnect Standard documents are based on these two core technologies.  

The base functionality defined in the MTConnect Standard is the {{term(data dictionary)}} describing manufacturing information and the {{term(semantic data model)}}.  The transport protocol and the programming language used to represent or transfer the information provided by the {{termplural(semantic data model)}} are not restricted in the standard to HTTP and XML.  Therefore, other protocols and programming languages may be used to represent the semantic models and/or transport the information provided by these data models between an {{term(agent)}} (server) and a client software application as may be required by a specific implementation.

> Note: The term ""document"" is used with different meanings in the MTConnect Standard:

* Meaning 1:  The MTConnect Standard itself is comprised of multiple documents each addressing different aspects of the Standard.  Each document is referred to as a Part of the Standard.

* Meaning 2:  In an MTConnect implementation, the electronic documents that are published from a data source and stored by an {{term(agent)}}.     

* Meaning 3:  In an MTConnect implementation, the electronic documents generated by an {{term(agent)}} for transmission to a client software application. 

The following will be used throughout the MTConnect Standard to distinguish between these different meanings for the term ""document"":

* MTConnect Document(s) or Document(s) shall be used to refer to printed or electronic document(s) that represent a Part(s) of the MTConnect Standard.  

* All reference to electronic documents that are received from a data source and stored in an {{term(agent)}} shall be referred to as {{term(document)}}(s) and are typically provided with a prefix identifier; e.g. asset document.

* All references to electronic documents generated by an {{term(agent)}} and sent to a client software application shall be referred to as a {{term(response document)}}.  

When used with no additional descriptor, the form ""document"" shall be used to refer to any printed or electronic document.

Manufacturing software systems implemented utilizing MTConnect can be represented by a very simple structure as shown in {{figure(Basic MTConnect Implementation Structure)}}.

![Basic MTConnect Implementation Structure](figures/basic-mtconnect-implementation-structure.png ""Basic MTConnect Implementation Structure""){: width=""0.8""}

The three basic modules that comprise a software system implemented using MTConnect are:

* Equipment:  Any data source.  In the MTConnect Standard, equipment is defined as any tangible property that is used to equip the operations of a manufacturing facility.  Examples of equipment are machine tools, ovens, sensor units, workstations, software applications, and bar feeders.

* Agent:  Software that collects data published from one or more piece(s) of equipment, organizes that data in a structured manner, and responds to requests for data from client software systems by providing a structured response in the form of a {{term(response document)}} that is constructed using the {{termplural(semantic data model)}} defined in the Standard. 

    > Note: The {{term(agent)}} may be fully integrated into the piece of equipment or the {{term(agent)}} may be independent of the piece of equipment.  Implementation of an {{term(agent)}} is the responsibility of the supplier of the piece of equipment and/or the implementer of the {{term(agent)}}.
    
* Client Software Application:  Software that requests data from {{termplural(agent)}} and processes that data in support of manufacturing operations. 

Based on {{figure(Basic MTConnect Implementation Structure)}}, it is important to understand that the MTConnect Standard only addresses the following functionality and behavior of an {{term(agent)}}:

* the method used by a client software application to request information from an {{term(agent)}}.

* the response that an {{term(agent)}} provides to a client software application.

* a {{term(data dictionary)}} used to provide consistency in understanding the meaning of data reported by a data source.

* the description of the {{termplural(semantic data model)}} used to structure {{termplural(response document)}} provided by an {{term(agent)}} to a client software application.

These functions are the primary building blocks that define the base functional structure of the MTConnect Standard.

There are a wide variety of data sources (equipment) and data consumption systems (client software systems) used in manufacturing operations.  There are also many different uses for the data associated with a manufacturing operation.  No single approach to implementing a data communication system can address all data exchange and data management functions typically required in the data driven manufacturing environment.  MTConnect has been uniquely designed to address this diversity of data types and data usages by providing different {{termplural(semantic data model)}} for different data application requirements:

* Data Collection: The most common use of data in manufacturing is the collection of data associated with the production of products and the operation of equipment that produces those products.  The MTConnect Standard provides comprehensive {{termplural(semantic data model)}} that represent data collected from manufacturing operations.  These {{termplural(semantic data model)}} are detailed in {{package(Device Information Model)}} and {{package(Observation Information Model)}} of the MTConnect Standard.

* Inter-operations Between Pieces of Equipment:  The MTConnect Standard provides an {{term(interaction model)}} that structures the information required to allow multiple pieces of equipment to coordinate actions required to implement manufacturing activities.  This {{term(interaction model)}} is an implementation of a {{term(request and response)}}  messaging structure.  This {{term(interaction model)}} is called {{block(Interfaces)}} which is detailed in {{package(Interface Interaction Model)}} of the MTConnect Standard.

* Shared Data:  Certain information used in a manufacturing operation is commonly shared amongst multiple pieces of equipment and/or software applications.  This information is not typically ""owned"" by any one manufacturing resource.  The MTConnect Standard represents this information through a series of {{termplural(semantic data model)}} – each describing different types of information used in the manufacturing environment.  Each type of information is called an {{term(Asset)}}. {{termplural(Asset)}} are detailed in {{package(Asset Information Model)}}, and its sub-Parts, of the MTConnect Standard.

# Purpose of This Document

This document, {{package(Fundamentals)}} of the MTConnect  Standard, addresses two major topics relating to the MTConnect Standard.  The first sections of the document define the organization of the documents used to describe the MTConnect Standard; including the terms and terminology used throughout the Standard.  The balance of the document defines the following:

* Operational concepts describing how an {{term(agent)}} should organize and structure data that has been collected from a data source.

* Definition and structure of the {{termplural(response document)}} supplied by an {{term(agent)}}.

* The protocol used by a client software application to communicate with an {{term(agent)}}.


# Terminology and Conventions

This section provides a dictionary of terms, reserved language, and document conventions used in the MTConnect Standard.

{{printglossary[title=General Terms, type=general]()}}
{{printglossary[title=Information Model Terms, type=informationmodel]()}}
{{printglossary[title=Protocol Terms, type=protocol]()}}
{{printglossary[title=HTTP Terms, type=http]()}}
{{printglossary[title=XML Terms, type=xml]()}}
{{printglossary[title=MTConnect Terms, type=conceptmodel]()}}

{{printacronyms()}}

{{printbibliography[title=MTConnect References,keyword=MTC]()}}

{{printbibliography[title=Other References,notkeyword=MTC]()}}

{{glsaddall()}}
&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			CommonDocumentsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.CommonDocumentsPackage _CommonDocumentsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CommonDocumentsPackage" path="/summary" />
	/// </summary>
	public Package.CommonDocumentsPackage CommonDocumentsPackage => _CommonDocumentsPackage ?? (_CommonDocumentsPackage = new Package.CommonDocumentsPackage());

	#endregion

	#region Classes
	#endregion
	}
}