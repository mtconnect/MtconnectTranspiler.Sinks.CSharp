#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel;

namespace Mtconnect
{
	/// <summary>﻿The MTConnect Standard supports a simple distributed storage mechanism that allows applications and equipment to share and exchange complex information models in a similar way to a distributed data store.  The <i>Asset Information Model</i> associates each <see cref="MTConnectAssets">MTConnectAssets</see> entity with a unique identifier and allows for some predefined mechanisms to find, create, request, update, and delete these electronic documents in a way that provides for consistency across multiple pieces of equipment.<br /><br />The protocol provides a limited mechanism of accessing <i>Asset</i>s using the following properties: <see cref="Asset.assetId">assetId in Asset</see>, <i>asset</i> type (element name of <i>asset</i> root), and the piece of equipment associated with the <i>asset</i>.  These access strategies will provide the following services and answer the following questions: What <i>asset</i>s are from a particular piece of equipment?  What are the <i>asset</i>s of a particular type? What <i>asset</i> is stored for a given <see cref="Asset.assetId">assetId in Asset</see>?<br /><br />Although these mechanisms are provided, an <i>agent</i> should not be considered a data store or a system of reference.  The <i>agent</i> is providing an ephemeral storage capability that will temporarily manage the data for applications wishing to communicate and manage data as needed by the various processes.  An application cannot rely on an <i>agent</i> for long term persistence or durability since the <i>agent</i> is only required to temporarily store the <i>asset</i> data and may require another system to provide the source data upon initialization.  An <i>agent</i> is always providing the best-known equipment centric view of the data given the limitations of that piece of equipment.<br /><br />The MTConnect Standard has two data item types to support change notification when an <i>Asset</i> is added, updated or removed. <see cref="AssetChanged">AssetChanged</see> states the <see cref="Asset.assetId">assetId in Asset</see> of the <i>Asset</i> that has been added or updated. <see cref="AssetRemoved">AssetRemoved</see> states the <see cref="Asset.assetId">assetId in Asset</see> of the <i>Asset</i> that has been removed. See <see cref="Observation Information Model">Observation Information Model</see> for more details.<br /><br /><br />Assets Appendix<br /><br />{{newpage()}}<br /><br />## XML Schema Diagrams<br /><br />See XML schemas for the MTConnect standard here: <see href="https://schemas.mtconnect.org/">https://schemas.mtconnect.org/</see>.<br /><br />### Assets Schema Diagrams<br /><br />See <c>Asset</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>Description</c> element in <c>MTConnectAssets</c> schema.<br /><br />### CuttingTool Schema Diagrams<br /><br />See <c>CuttingTool</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>CuttingToolDefinition</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>CuttingToolArchetypeReference</c> element in <c>MTConnectAssets</c> schema.<br /><br />### CuttingToolLifeCycle Schema Diagrams<br /><br />See <c>CuttingToolLifeCycle</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>CutterStatus</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>Location</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>Measurement</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>ProcessFeedRate</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>ProcessSpindleSpeed</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>ReconditionCount</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>ToolLife</c> element in <c>MTConnectAssets</c> schema.<br /><br />### CuttingItem Schema Diagrams<br /><br />See <c>CuttingItems</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>CuttingItem</c> element in <c>MTConnectAssets</c> schema.<br /><br />See <c>ItemLife</c> element in <c>MTConnectAssets</c> schema.<br /><br />### ISO 13399 Diagrams<br /><br />#### Measurement Diagrams<br /><br />![Cutting Tool Measurement 3](figures/Cutting%20Tool%20Measurement%203.png "Cutting Tool Measurement 3"){: width="0.8"}<br /><br />![Cutting Tool Measurement 4](figures/Cutting%20Tool%20Measurement%204.png "Cutting Tool Measurement 4"){: width="0.8"}<br /><br />![Cutting Tool Measurement 5](figures/Cutting%20Tool%20Measurement%205.png "Cutting Tool Measurement 5"){: width="0.8"}<br /><br />![Cutting Tool Measurement 6](figures/Cutting%20Tool%20Measurement%206.png "Cutting Tool Measurement 6"){: width="0.8"}<br /><br />![Cutting Tool Measurement 7](figures/Cutting%20Tool%20Measurement%207.png "Cutting Tool Measurement 7"){: width="0.8"}<br /><br />![Cutting Tool Measurement 8](figures/Cutting%20Tool%20Measurement%208.png "Cutting Tool Measurement 8"){: width="0.8"}<br /><br />### Cutting Tool Examples<br /><br />#### Shell Mill<br /><br />![Shell Mill Side View](figures/Shell%20Mill%20Side%20View.png "Shell Mill Side View"){: width="0.8"}<br /><br />![Indexable Insert Measurements](figures/Indexable%20Insert%20Measurements.png "Indexable Insert Measurements"){: width="0.8"}<br /><br />~~~~xml<br />&lt;?xml version="1.0" encoding="UTF-8"?&gt;<br />&lt;MTConnectAssets <br />xmlns:m="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" <br />xsi:schemaLocation="urn:mtconnect.org:MTConnectAssets:1.2<br />http://mtconnect.org/schemas/MTConnectAssets\_1.2.xsd"&gt;<br />  &lt;Header creationTime="2011-05-11T13:55:22" <br />  assetBufferSize="1024" sender="localhost"<br />  assetCount="2" version="1.2" instanceId="1234"/&gt;<br />  &lt;Assets&gt;<br />  &lt;CuttingTool serialNumber="1" toolId="KSSP300R4SD43L240" <br />  timestamp="2011-05-11T13:55:22" assetId="KSSP300R4SD43L240.1" <br />  manufacturers="KMT,Parlec"&gt;<br />    &lt;CuttingToolLifeCycle&gt;<br />    &lt;CutterStatus&gt;&lt;Status&gt;NEW&lt;/Status&gt;&lt;/CutterStatus&gt;<br />    &lt;ProcessSpindleSpeed maximum="13300" <br />    nominal="605"&gt;10000&lt;/ProcessSpindleSpeed&gt;<br />    &lt;ProcessFeedRate<br />    nominal="9.22"&gt;9.22&lt;/ProcessSpindleSpeed&gt;<br />    &lt;ConnectionCodeMachineSide&gt;CV50<br />    &lt;/ConnectionCodeMachineSide&gt;<br />    &lt;Measurements&gt;<br />      &lt;BodyDiameterMax code="BDX"&gt;73.25<br />      &lt;/BodyDiameterMax&gt;<br />      &lt;OverallToolLength nominal="222.25" <br />        minimum="221.996" maximum="222.504" <br />        code="OAL"&gt;222.25&lt;/OverallToolLength&gt;<br />      &lt;UsableLengthMax code="LUX" nominal="82.55"&gt;82.55<br />      &lt;/UsableLengthMax&gt;<br />      &lt;CuttingDiameterMax code="DC" nominal="76.2" <br />        maximum="76.213" minimum="76.187"&gt;76.2<br />      &lt;/CuttingDiameterMax&gt;<br />      &lt;BodyLengthMax code="LF" nominal="120.65" <br />        maximum="120.904" minimum="120.404"&gt;120.65<br />      &lt;/BodyLengthMax&gt;<br />      &lt;DepthOfCutMax code="APMX" <br />      nominal="60.96"&gt;60.95&lt;/DepthOfCutMax&gt;<br />      &lt;FlangeDiameterMax code="DF" <br />        nominal="98.425"&gt;98.425&lt;/FlangeDiameterMax&gt;<br />    &lt;/Measurements&gt;<br />    &lt;CuttingItems count="24"&gt;<br />      &lt;CuttingItem indices="1-24" itemId="SDET43PDER8GB" <br />        manufacturers="KMT" grade="KC725M"&gt;<br />        &lt;Measurements&gt;<br />          &lt;CuttingEdgeLength code="L" nominal="12.7" <br />            minimum="12.675" maximum="12.725"&gt;12.7<br />          &lt;/CuttingEdgeLength&gt;<br />        &lt;WiperEdgeLength code="BS" nominal=<br />          "2.56"&gt;2.56&lt;/WiperEdgeLength&gt;<br />        &lt;IncribedCircleDiameter code="IC"<br />          nominal="12.7"&gt;12.7<br />        &lt;/IncribedCircleDiameter&gt;<br />        &lt;CornerRadius code="RE" nominal="0.8"&gt;<br />          0.8&lt;/CornerRadius&gt;<br />      &lt;/Measurements&gt;<br />      &lt;/CuttingItem&gt;<br />    &lt;/CuttingItems&gt;<br />    &lt;/CuttingToolLifeCycle&gt;<br />    &lt;/CuttingTool&gt;<br />  &lt;/Assets&gt;<br />&lt;/MTConnectAssets&gt;<br />~~~~<br />{: caption="Example for Indexable Insert Measurements"}<br /><br />{{pagebreak()}}<br /><br />#### Step Drill<br /><br />![Step Mill Side View](figures/Step%20Mill%20Side%20View.png "Step Mill Side View"){: width="0.8"}<br /><br />~~~~xml<br />&lt;?xml version="1.0" encoding="UTF-8"?&gt;<br />&lt;MTConnectAssets xmlns:m="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" <br />xsi:schemaLocation="urn:mtconnect.org:MTConnectAssets:1.2 <br />http://mtconnect.org/schemas/MTConnectAssets\_1.2.xsd"&gt;<br />  &lt;Header creationTime="2011-05-<br />  11T13:55:22" assetBufferSize="1024" <br />  sender="localhost" assetCount="2" version="1.2" instanceId="1234"/&gt;<br />  &lt;Assets&gt;<br />    &lt;CuttingTool serialNumber="1 " toolId="B732A08500HP" <br />    timestamp="2011-05-11T13:55:22" assetId="B732A08500HP " <br />    manufacturers="KMT,Parlec"&gt;<br />      &lt;Description&gt;<br />        Step Drill - KMT, B732A08500HP Grade KC7315<br />        Adapter - Parlec, C50-M12SF300-6<br />      &lt;/Description&gt;<br />      &lt;CuttingToolLifeCycle&gt;<br />        &lt;CutterStatus&gt;&lt;Status&gt;NEW&lt;/Status&gt;&lt;/CutterStatus&gt;<br />        &lt;ProcessSpindleSpeed nominal="5893"&gt;5893&lt;/ProcessSpindleSpeed&gt;<br />        &lt;ProcessFeedRate nominal="2.5"&gt;2.5&lt;/ProcessFeedRate&gt;<br />        &lt;ConnectionCodeMachineSide&gt;CV50 Taper&lt;/ConnectionCodeMachineSide&gt;<br />        &lt;Measurements&gt;<br />          &lt;BodyDiameterMax code="BDX"&gt;31.8&lt;/BodyDiameterMax&gt;<br />          &lt;BodyLengthMax code="LBX" nominal="120.825" maximum="126.325" <br />          minimum="115.325"&gt;120.825&lt;/BodyLengthMax&gt;<br />          &lt;ProtrudingLength code="LPR" nominal="155.75" maximum="161.25" <br />          minimum="150.26"&gt;155.75&lt;/ProtrudingLength&gt;<br />          &lt;FlangeDiameterMax code="DF" <br />          nominal="98.425"&gt;98.425&lt;/FlangeDiameterMax&gt;<br />          &lt;OverallToolLength nominal="257.35" minimum="251.85" <br />          maximum="262.85" code="OAL"&gt;257.35&lt;/OverallToolLength&gt;<br />        &lt;/Measurements&gt;<br />        &lt;CuttingItems count="2"&gt;<br />          &lt;CuttingItem indices="1" manufacturers="KMT" grade="KC7315"&gt;&gt;<br />            &lt;Measurements&gt;<br />              &lt;CuttingDiameter code="DC1" nominal="8.5" maximum="8.521" <br />              minimum="8.506"&gt;8.5135&lt;/CuttingDiameter&gt;<br />              &lt;StepIncludedAngle code="STA1" nominal="90" maximum="91" <br />              minimum="89"&gt;90&lt;/StepIncludedAngle&gt;<br />              &lt;FunctionalLength code="LF1" nominal="154.286" <br />              minimum="148.786" <br />              maximum="159.786"&gt;154.286&lt;/FunctionalLength&gt;<br />              &lt;StepDiameterLength code="SDL1" <br />              nominal="9"&gt;9&lt;/StepDiameterLength&gt;<br />              &lt;PointAngle code="SIG" nominal="135" minimum="133" <br />              maximum="137"&gt;135&lt;/PointAngle&gt;<br />            &lt;/Measurements&gt;<br />          &lt;/CuttingItem&gt;<br />          &lt;CuttingItem indices="2" manufacturers="KMT" grade="KC7315"&gt;&gt;<br />            &lt;Measurements&gt;<br />              &lt;CuttingDiameter code="DC2" nominal="12" maximum="12.011" <br />              minimum="12"&gt;12&lt;/CuttingDiameter&gt;<br />              &lt;FunctionalLength code="LF2" nominal="122.493" <br />              maximum="127.993" <br />              minimum="116.993"&gt;122.493&lt;/FunctionalLength&gt;<br />              &lt;StepDiameterLength code="SDL2" <br />              nominal="9"&gt;9&lt;/StepDiameterLength&gt;<br />            &lt;/Measurements&gt;<br />          &lt;/CuttingItem&gt;<br />        &lt;/CuttingItems&gt;<br />      &lt;/CuttingToolLifeCycle&gt;<br />    &lt;/CuttingTool&gt;<br />  &lt;/Assets&gt;<br />&lt;/MTConnectAssets&gt;<br />~~~~<br />{: caption="Example for Step Mill Side View"}<br /><br />{{pagebreak()}}<br /><br />#### Shell Mill with Individual Loci<br /><br />![Shell Mill with Explicate Loci](figures/Shell%20Mill%20with%20Explicate%20Loci.png "Shell Mill with Explicate Loci"){: width="0.8"}<br /><br />~~~~xml<br />&lt;?xml version="1.0" encoding="UTF-8"?&gt;<br />&lt;MTConnectAssets xmlns:m="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" <br />xsi:schemaLocation="urn:mtconnect.org:MTConnectAssets:1.2 <br />http://mtconnect.org/schemas/MTConnectAssets\_1.2.xsd"&gt;<br />  &lt;Header creationTime="2011-05-11T13:55:22" assetBufferSize="1024" <br />  sender="localhost" assetCount="2" version="1.2" instanceId="1234"/&gt;<br />  &lt;Assets&gt;<br />    &lt;CuttingTool serialNumber="1" toolId="KSSP300R4SD43L240" <br />    timestamp="2011-05-11T13:55:22" assetId="KSSP300R4SD43L240.1" <br />    manufacturers="KMT,Parlec"&gt;<br />      &lt;Description&gt;Keyway: 55 degrees&lt;/Description&gt;<br />      &lt;CuttingToolLifeCycle&gt;<br />        &lt;CutterStatus&gt;&lt;Status&gt;NEW&lt;/Status&gt;&lt;/CutterStatus&gt;<br />        &lt;Measurements&gt;<br />          &lt;UsableLengthMax code="LUX" <br />          nominal="82.55"&gt;82.55&lt;/UsableLengthMax&gt;<br />          &lt;CuttingDiameterMax code="DC" nominal="76.2" maximum="76.213" <br />          minimum="76.187"&gt;76.2&lt;/CuttingDiameterMax&gt;<br />          &lt;DepthOfCutMax code="APMX" nominal="60.96"&gt;60.95&lt;/DepthOfCutMax&gt;<br />        &lt;/Measurements&gt;<br />        &lt;CuttingItems count="24"&gt;<br />          &lt;CuttingItem indices="1" itemId="SDET43PDER8GB" <br />          manufacturers="KMT"&gt;<br />            &lt;Locus&gt;FLUTE: 1, ROW: 1&lt;/Locus&gt;<br />            &lt;Measurements&gt;<br />             &lt;DriveAngle code="DRVA" nominal="55"&gt;55&lt;/DriveAngle&gt;<br />           &lt;/Measurements&gt;<br />          &lt;/CuttingItem&gt;<br />          &lt;CuttingItem indices="2-24" itemId="SDET43PDER8GB" <br />          manufacturers="KMT"&gt;<br />            &lt;Locus&gt;FLUTE: 2-4, ROW: 1; FLUTE: 1-4, ROW 2-6&lt;/Locus&gt;<br />          &lt;/CuttingItem&gt;<br />        &lt;/CuttingItems&gt;<br />      &lt;/CuttingToolLifeCycle&gt;<br />    &lt;/CuttingTool&gt;<br />  &lt;/Assets&gt;<br />&lt;/MTConnectAssets&gt;<br />~~~~<br />{: caption="Example for Shell Mill with Explicate Loci"}<br /><br />{{pagebreak()}}<br /><br />#### Drill with Individual Loci<br /><br />![Step Drill with Explicate Loci](figures/Step%20Drill%20with%20Explicate%20Loci.png "Step Drill with Explicate Loci"){: width="0.8"}<br /><br />~~~~xml<br />&lt;?xml version="1.0" encoding="UTF-8"?&gt;<br />&lt;MTConnectAssets xmlns:m="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" <br />xsi:schemaLocation="urn:mtconnect.org:MTConnectAssets:1.2 <br />http://mtconnect.org/schemas/MTConnectAssets\_1.2.xsd"&gt;<br />  &lt;Header creationTime="2011-05-11T13:55:22" assetBufferSize="1024" <br />  sender="localhost" assetCount="2" version="1.2" instanceId="1234"/&gt;<br />  &lt;Assets&gt;<br />    &lt;CuttingTool serialNumber="1" toolId="KSEM0781LD" <br />    timestamp="2011-05-11T13:55:22" assetId="KSEM0781LD.1" manufacturers="KMT"&gt;<br />      &lt;CuttingToolLifeCycle&gt;<br />        &lt;CutterStatus&gt;&lt;Status&gt;NEW&lt;/Status&gt;&lt;/CutterStatus&gt;<br />        &lt;ConnectionCodeMachineSide&gt;HSK63A&lt;/ConnectionCodeMachineSide&gt;<br />        &lt;Measurements&gt;<br />          &lt;BodyDiameterMax code="BDX"&gt;52.75&lt;/BodyDiameterMax&gt;<br />          &lt;OverallToolLength nominal="172.29" <br />          code="OAL"&gt;172.29&lt;/OverallToolLength&gt;<br />          &lt;UsableLengthMax code="LUX" nominal="49"&gt;49&lt;/UsableLengthMax&gt;<br />          &lt;FlangeDiameterMax code="DF" <br />          nominal="62.94"&gt;62.94&lt;/FlangeDiameterMax&gt;<br />        &lt;/Measurements&gt;<br />        &lt;CuttingItems count="3"&gt;<br />          &lt;CuttingItem indices="1" itemId="KSEM0781LD" manufacturers="KMT" <br />          grade="KC7015"&gt;<br />            &lt;Locus&gt;FLUTE: 1, ROW: 1&lt;/Locus&gt;<br />            &lt;Measurements&gt;<br />         &lt;FunctionalLength code="LF1" nominal="154.42"&gt;154.42&lt;/FunctionalLength&gt;<br />         &lt;CuttingDiameter code="DC1" nominal="19.844"&gt;19.844&lt;/CuttingDiameter&gt;<br />         &lt;PointAngle code="SIG" nominal="140"&gt;140&lt;/PointAngle&gt;<br />         &lt;ToolCuttingEdgeAngle code="KAPR1" nominal="45"&gt;45&lt;/ToolCuttingEdgeAngle&gt;<br />         &lt;StepDiameterLength code="SLD1" nominal="39.8"&gt;39.8&lt;/StepDiameterLength&gt;<br />            &lt;/Measurements&gt;<br />          &lt;/CuttingItem&gt;<br />          &lt;CuttingItem indices="2-3" itemId="TPMT-21.52-FP" <br />          manufacturers="KMT" grade="KCM15"&gt;<br />            &lt;Locus&gt;FLUTE: 1-2, ROW: 2&lt;/Locus&gt;<br />            &lt;Measurements&gt;<br />         &lt;FunctionalLength code="LF2" nominal="112.9"&gt;119.2&lt;/FunctionalLength&gt;<br />         &lt;CuttingDiameter code="DC2" nominal="31"&gt;31&lt;/CuttingDiameter&gt;<br />            &lt;/Measurements&gt;<br />          &lt;/CuttingItem&gt;<br />        &lt;/CuttingItems&gt;<br />      &lt;/CuttingToolLifeCycle&gt;<br />    &lt;/CuttingTool&gt;<br />  &lt;/Assets&gt;<br />&lt;/MTConnectAssets&gt;<br />~~~~<br />{: caption="Example for Step Drill with Explicate Loci"}<br /><br />{{pagebreak()}}<br /><br />#### Shell Mill with Different Inserts on First Row<br /><br />![Shell Mill with Different Inserts on First Row](figures/Shell%20Mill%20with%20Different%20Inserts%20on%20First%20Row.png "Shell Mill with Different Inserts on First Row"){: width="0.8"}<br /><br />~~~~xml<br />&lt;?xml version="1.0" encoding="UTF-8"?&gt;<br />&lt;MTConnectAssets xmlns:m="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns="urn:mtconnect.org:MTConnectAssets:1.2" <br />xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" <br />xsi:schemaLocation="urn:mtconnect.org:MTConnectAssets:1.2 <br />http://mtconnect.org/schemas/MTConnectAssets\_1.2.xsd"&gt;<br />  &lt;Header creationTime="2011-05-11T13:55:22" assetBufferSize="1024" <br />  sender="localhost" assetCount="2" version="1.2" instanceId="1234"/&gt;<br />  &lt;Assets&gt;<br />    &lt;CuttingTool serialNumber="1" toolId="XXX" timestamp="2011-05-11T13:55:22" <br />    assetId="XXX.1" manufacturers="KMT"&gt;<br />      &lt;CuttingToolLifeCycle&gt;<br />        &lt;CutterStatus&gt;&lt;Status&gt;NEW&lt;/Status&gt;&lt;/CutterStatus&gt;<br />        &lt;Measurements&gt;<br />          &lt;DepthOfCutMax code="APMX" nominal="47.8"&gt;47.8&lt;/DepthOfCutMax&gt;<br />          &lt;CuttingDiameterMax code="DC" <br />          nominal="50.8"&gt;50.8&lt;/CuttingDiameterMax&gt;<br />          &lt;UsableLengthMax code="LUX" <br />          nominal="78.74"&gt;78.74&lt;/UsableLengthMax&gt;<br />        &lt;/Measurements&gt;<br />        &lt;CuttingItems count="9"&gt;<br />          &lt;CuttingItem indices="1-3" itemId="EDPT180564PDER-LD" <br />          manufacturers="KMT"&gt;<br />            &lt;Locus&gt;FLUTE: 1-3, ROW: 1&lt;/Locus&gt;<br />            &lt;Measurements&gt;<br />              &lt;CornerRadius code="RE" nominal="6.25"&gt;6.35&lt;/CornerRadius&gt;<br />            &lt;/Measurements&gt;<br />          &lt;/CuttingItem&gt;<br />          &lt;CuttingItem indices="4-9" itemId="EDPT180508PDER-LD" <br />          manufacturers="KMT"&gt;<br />            &lt;Locus&gt;FLANGE: 1-4, ROW: 2-3&lt;/Locus&gt;<br />          &lt;/CuttingItem&gt;<br />        &lt;/CuttingItems&gt;<br />      &lt;/CuttingToolLifeCycle&gt;<br />    &lt;/CuttingTool&gt;<br />  &lt;/Assets&gt;<br />&lt;/MTConnectAssets&gt;<br />~~~~<br />{: caption="Example for Shell Mill with Different Inserts on First Row"}<br /><br />### File Schema Diagrams<br /><br />See <c>File</c> element in <c>MTConnectAssets</c> schema.<br /><br />### RawMaterial Schema Diagrams<br /><br />See <c>RawMaterial</c> element in <c>MTConnectAssets</c> schema.<br /><br />### QIFDocumentWrapper Schema Diagrams<br /><br />See <c>QIFDocumentWrapper</c> element in <c>MTConnectAssets</c> schema.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_029C7254_810A_45f2_8400_D4E69ED8DF85">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class AssetInformationModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_029C7254_810A_45f2_8400_D4E69ED8DF85";
		
		/// <inheritdoc />
		public string Name => "Asset Information Model";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;The MTConnect Standard supports a simple distributed storage mechanism that allows applications and equipment to share and exchange complex information models in a similar way to a distributed data store.  The {{term(Asset Information Model)}} associates each {{block(MTConnectAssets)}} entity with a unique identifier and allows for some predefined mechanisms to find, create, request, update, and delete these electronic documents in a way that provides for consistency across multiple pieces of equipment.

The protocol provides a limited mechanism of accessing {{termplural(Asset)}} using the following properties: {{property(Asset::assetId)}}, {{term(asset)}} type (element name of {{term(asset)}} root), and the piece of equipment associated with the {{term(asset)}}.  These access strategies will provide the following services and answer the following questions: What {{termplural(asset)}} are from a particular piece of equipment?  What are the {{termplural(asset)}} of a particular type? What {{term(asset)}} is stored for a given {{property(Asset::assetId)}}?

Although these mechanisms are provided, an {{term(agent)}} should not be considered a data store or a system of reference.  The {{term(agent)}} is providing an ephemeral storage capability that will temporarily manage the data for applications wishing to communicate and manage data as needed by the various processes.  An application cannot rely on an {{term(agent)}} for long term persistence or durability since the {{term(agent)}} is only required to temporarily store the {{term(asset)}} data and may require another system to provide the source data upon initialization.  An {{term(agent)}} is always providing the best-known equipment centric view of the data given the limitations of that piece of equipment.

The MTConnect Standard has two data item types to support change notification when an {{term(Asset)}} is added, updated or removed. {{block(AssetChanged)}} states the {{property(Asset::assetId)}} of the {{term(Asset)}} that has been added or updated. {{block(AssetRemoved)}} states the {{property(Asset::assetId)}} of the {{term(Asset)}} that has been removed. See {{package(Observation Information Model)}} for more details.&#10;
&#10;&#10;&#10;Assets Appendix&#10;&#10;&#10;&#10;{{newpage()}}

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
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			CuttingToolPackage,
			FilesPackage,
			RawMaterialPackage,
			QIFPackage,
			ComponentConfigurationParametersPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			AssetClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.CuttingToolPackage _CuttingToolPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingToolPackage" path="/summary" />
	/// </summary>
	public Package.CuttingToolPackage CuttingToolPackage => _CuttingToolPackage ?? (_CuttingToolPackage = new Package.CuttingToolPackage());

	private Package.FilesPackage _FilesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.FilesPackage" path="/summary" />
	/// </summary>
	public Package.FilesPackage FilesPackage => _FilesPackage ?? (_FilesPackage = new Package.FilesPackage());

	private Package.RawMaterialPackage _RawMaterialPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RawMaterialPackage" path="/summary" />
	/// </summary>
	public Package.RawMaterialPackage RawMaterialPackage => _RawMaterialPackage ?? (_RawMaterialPackage = new Package.RawMaterialPackage());

	private Package.QIFPackage _QIFPackage;
	/// <summary>
	/// <inheritdoc cref="Package.QIFPackage" path="/summary" />
	/// </summary>
	public Package.QIFPackage QIFPackage => _QIFPackage ?? (_QIFPackage = new Package.QIFPackage());

	private Package.ComponentConfigurationParametersPackage _ComponentConfigurationParametersPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentConfigurationParametersPackage" path="/summary" />
	/// </summary>
	public Package.ComponentConfigurationParametersPackage ComponentConfigurationParametersPackage => _ComponentConfigurationParametersPackage ?? (_ComponentConfigurationParametersPackage = new Package.ComponentConfigurationParametersPackage());

	#endregion

	#region Classes
	private Package.AssetClass _AssetClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetClass" path="/summary" />
	/// </summary>
	public Package.AssetClass AssetClass => _AssetClass ?? (_AssetClass = new Package.AssetClass());

	#endregion

	#region Enums
	#endregion
	}
}