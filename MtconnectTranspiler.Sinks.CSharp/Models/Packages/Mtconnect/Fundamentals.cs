#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals;

namespace Mtconnect
{
	/// <summary>﻿The MTConnect Standard defines the normative information model and protocol for retrieving information from manufacturing equipment. This document specifies the <i>agent</i> behavior and protocol.<br /><br />## Agent<br /><br />The MTConnect Standard specifies the minimum functionality of the <i>agent</i>. The functionality is as follows:<br /><br />* Provides store and forward messaging middleware service.<br />* Provides key-value information storage and asset retrieval service.<br />* Implements the REST API for the MTConnect Standard (See <see cref="REST Protocol">REST Protocol</see>).<br />  * <i>Device</i> metadata.<br />  * <i>observation</i>s collected by the agent.<br />  * <i>asset</i>s collected by the agent.<br /><br />There are three types of information stored by an <i>agent</i> that <b>MAY</b> be published in a <i>response document</i>. These are as follows:<br /><br />* <i>equipment metadata</i> specified in <see cref="Device Information Model">Device Information Model</see>.<br />* <i>streaming data</i> provides the <i>observation</i>s specified in <see cref="Observation Information Model">Observation Information Model</see>.<br />* <i>Asset</i>s specified in <see cref="Asset Information Model">Asset Information Model</see>.<br /><br />### Agent Instance ID<br /><br />The <i>agent</i> <b>MUST</b> set the <c>instanceId</c> to a unique value whenever the <i>sequence number</i> in the agent is initialized to <c>1</c>.  (see <see cref="Sequence Numbers">Sequence Numbers</see> and <see cref="Persistence and Recovery">Persistence and Recovery</see> below). <br /><br />### Storage of Equipment Metadata<br /><br />An <i>agent</i> <b>MUST</b> be capable of publishing <i>equipment metadata</i> for the <i>agent</i> as specified in <see cref="Device Information Model">Device Information Model</see>.<br /><br />### Storage of Streaming Data<br /><br />The <i>agent</i> <b>MAY</b> implement a <i>buffer</i> with a fixed number of <i>observation</i>s. If the <c>bufferSize</c> is fixed, the <i>agent</i> <b>MUST</b> store <i>observation</i>s using a first-in-first-out pattern. The <i>agent</i> will remove the oldest <i>observation</i> when the <i>buffer</i> is full and a new <i>observation</i> arrives.<br /><br />![Data Storage in Buffer](figures/data-storage-in-buffer.png "data-storage-in-buffer"){: width="0.8"}<br /><br />In {{figure(first-in-first-out-buffer-management)}}, the maximum number of <i>observation</i>s that can be stored in the <i>buffer</i> of the <i>agent</i> is 8. The <c>bufferSize</c> in the header reports the maximum number of <i>observation</i>s. This example illustrates that when the <i>buffer</i> fills up, the oldest piece of data falls out the other end.<br /><br />![First In First Out Buffer Management](figures/first-in-first-out-buffer-management.png "first-in-first-out-buffer-management"){: width="0.8"}<br /><br />&gt; Note: As an implementation suggestion, the <i>buffer</i> should be sized large enough to provide a continuous stream of <i>observation</i>s. The implementer should also consider the impact of a temporary loss of communications when determining the size for the <i>buffer</i>. A larger <i>buffer</i> will allow more time to reconnect to an <i>agent</i> without losing data.<br /><br />#### Sequence Numbers<br /><br />In an <i>agent</i>, each occurrence of an <i>observation</i> in the <i>buffer</i> will be assigned a monotonically increasing unsigned 64-bit integer (<i>sequence number</i>) when it arrives. The first <i>sequence number</i> <b>MUST</b> be <c>1</c>.<br /><br />The <i>sequence number</i> for each <i>observation</i> <b>MUST</b> be unique for an instance of an <i>agent</i> identified by an <c>instanceId</c>.<br /><br />{{table(instanceid-and-sequence)}} illustrates the changing of the <c>instanceId</c> when an <i>agent</i> resets the <i>sequence number</i> to <c>1</c>.<br /><br />| <c>instanceId</c> | <c>sequence</c> | <br />|-------------:|-----------:|<br />|{{rowspan(5)}} 234556|234|<br />||235|<br />||236|<br />||237|<br />||238|<br />|{{span(2)}} Agent Stops and Restarts|<br />|{{rowspan(5)}} 234557|1|<br />||2|<br />||3|<br />||4|<br />||5|<br />{: caption="instanceId and sequence" label="instanceid-and-sequence" }<br /><br />{{figure(identifying-the-range-of-data-with-firstsequence-and-lastsequence)}} shows two additional pieces of information defined for an <i>agent</i>:<br /><br />* <c>firstSequence</c> -- the oldest <i>observation</i> in the <i>buffer</i>. The <i>agent</i> removes this <i>observation</i> when it receives the next <i>observation</i><br /><br />* <c>lastSequence</c> -- the newest <i>observation</i> in the <i>buffer</i><br /><br /><c>firstSequence</c> and <c>lastSequence</c> provide the range of values for the REST API requests.<br /><br />![Indentifying the range of data with firstSequence and lastSequence](figures/identifying-the-range-of-data-with-firstsequence-and-lastsequence.png "identifying-the-range-of-data-with-firstsequence-and-lastsequence"){: width="0.75"}<br /><br />The <i>agent</i> <b>MUST</b> begin evaluating <i>observation</i>s with <i>sample request</i>'s <c>from</c> parameter. Also, the <i>agent</i>  <b>MUST</b> include a maximum number of <i>observation</i>s given by the <c>count</c> parameter in the <i>response document</i>.<br /><br />In {{figure(identifying-the-range-of-data-with-from-and-count)}}, the request specifies the <i>observation</i>s start at <i>sequence number</i> <c>15</c> (<c>from</c>) and includes a total of three items (<c>count</c>).<br /><br />![Identifying the range of data with from and count](figures/identifying-the-range-of-data-with-from-and-count.png "identifying-the-range-of-data-with-from-and-count"){: width="0.75"}<br /><br /><c>nextSequence</c> header property has the <i>sequence number</i> of the next <i>observation</i> in the <i>buffer</i> for subsequent <i>sample request</i>s providing a contiguous set of <i>observation</i>s. In the example in {{figure(identifying-the-range-of-data-with-from-and-count)}}, the next <i>sequence number</i> (<c>nextSequence</c>) will be 18.<br /><br />As shown in {{figure(identifying-the-range-of-data-with-nextsequence-and-lastsequence)}}, the combination of <c>from</c> and <c>count</c> defined by the <i>request</i> indicates a <i>sequence number</i> for data that is beyond that which is currently in the <i>buffer</i>. In this case, <c>nextSequence</c> is set to a value of <i> lastSequence + 1 </i>.<br /><br />![Indentifying the range of data with nextSequence and lastSequence](figures/identifying-the-range-of-data-with-nextsequence-and-lastsequence.png "identifying-the-range-of-data-with-nextsequence-and-lastsequence"){: width="0.75"}<br /><br />#### Observation Buffer<br /><br />An <i>observation</i> has four pieces of information as follows:<br /><br />1. <i>sequence number</i> associated with each <i>observation</i> - <c>sequence</c>.<br />2. The <c>timestamp</c> the <i>observation</i> was made. .<br />3. A reference to the <c>dataitemid</c> from the <see cref="Device Information Model">Device Information Model</see>.<br />4. The value of the <i>observation</i>.<br /><br />{{table(data-storage-concept)}} is an example demonstrating the concept of how data may be stored in an <i>agent</i>:<br /><br />| <c>sequence</c> | <c>timestamp</c> | <c>dataItemId</c> | <c>result</c> |<br />|-----------:|------------:|-------------:|---------:|<br />|<c>101</c>|<c>2016-12-13T09:44:00.2221Z</c>|<c>AVAIL-28277</c>|<c>UNAVAILABLE</c>|<br />|<c>102</c>|<c>2016-12-13T09:54:00.3839Z</c>|<c>AVAIL-28277</c>|<c>AVAILABLE</c>|<br />|<c>103</c>|<c>2016-12-13T10:00:00.0594Z</c>|<c>POS-Y-28277</c>|<c>25.348</c>|<br />|<c>104</c>|<c>2016-12-13T10:00:00.0594Z</c>|<c>POS-Z-28277</c>|<c>13.23</c>|<br />|<c>105</c>|<c>2016-12-13T10:00:03.2839Z</c>|<c>SS-28277</c>|<c>0</c>|<br />|<c>106</c>|<c>2016-12-13T10:00:03.2839Z</c>|<c>POS-X-28277</c>|<c>11.195</c>|<br />|<c>107</c>|<c>2016-12-13T10:00:03.2839Z</c>|<c>POS-Y-28277</c>|<c>24.938</c>|<br />|<c>108</c>|<c>2016-12-13T10:01:37.8594Z</c>|<c>POS-Z-28277</c>|<c>1.143</c>|<br />|<c>109</c>|<c>2016-12-13T10:02:03.2617Z</c>|<c>SS-28277</c>|<c>1002</c>|<br />{: caption="Data Storage Concept" label="data-storage-concept" }<br /><br />#### Timestamp<br /><br /><i>observation</i>s <b>MUST</b> have a <c>timestamp</c> giving the most accurate time that the <i>observation</i> occurred.<br /><br />The timezone of the <c>timestamp</c> <b>MUST</b> be UTC (Coordinated Universal Time)  and represented using ISO 8601 format: e.g., "2010-04-01T21:22:43Z".<br /><br />Applications <b>SHOULD</b> use the <i>observation</i>'s <c>timestamp</c> for ordering as opposed to <i>sequence number</i>.<br /><br />All <i>observation</i>s occurring at the same time <b>MUST</b> have the same <c>timestamp</c>. <br /><br />#### Recording Occurrences of Streaming Data<br /><br />The <i>agent</i> <b>MUST</b> only place <i>observation</i>s in the <i>buffer</i> if the data has changed from the previous <i>observation</i> for the same <see cref="DataItem">DataItem</see>. <br /><br />The <i>agent</i> <b>MUST</b> place every <i>observation</i> in the <i>buffer</i>, without checking for changes, in the following cases:<br /><br />* The <see cref="DataItem.discrete">discrete in DataItem</see> is <c>true</c>. <br />* The <see cref="DataItem.representation">representation in DataItem</see> is <c>DISCRETE</c>.<br />* The <see cref="DataItem.representation">representation in DataItem</see> is <c>TIME_SERIES</c>.<br /><br />#### Maintaining Last Value for Data Entities<br /><br />An <i>agent</i> <b>MUST</b> retain the most recent <i>observation</i> associated with each <see cref="DataItem">DataItem</see>, even if the <i>observation</i> is no longer in the <i>buffer</i>. This function supports the <i>current request</i> functionality.<br /><br />#### Unavailability of Data<br /><br />An <i>observation</i> with the value of <c>UNAVAILABLE</c> indicates the value is indeterminate.<br /><br />The <i>agent</i> <b>MUST</b> initialize every <see cref="DataItem">DataItem</see>, unless it has a constant value (see below), with an <i>observation</i> with the value of <c>UNAVAILABLE</c>. Aditionally, whenever the data source is unreachable, every <see cref="DataItem">DataItem</see> associated with the data source must have an <i>observation</i> with the value of <c>UNAVAILABLE</c> and <c>timestamp</c> when the connection was lost. <br /><br />An <see cref="DataItem">DataItem</see> that is constrained to a constant value, as defined in <see cref="Device Information Model">Device Information Model</see>, <b>MUST</b> only have an <i>observation</i> with the constant value and <b>MUST NOT</b> be set to <c>UNAVAILABLE</c>.<br /><br />#### Persistence and Recovery<br /><br />The <i>agent</i> <b>MAY</b> have a fixed size <i>buffer</i> and the <i>buffer</i> <b>MAY</b> be ephemeral.<br /><br />If the <i>buffer</i> is recoverable, the <i>agent</i> <b>MUST NOT</b> change the <c>instanceId</c> and <b>MUST NOT</b> set the <i>sequence number</i> to <c>1</c>. The <i>sequence number</i> <b>MUST</b> be one greater than the maximum value of the recovered <i>observation</i>s. <i> max(sequence) + 1 </i><br /><br />### Storage of MTConnect Assets<br /><br />An <i>agent</i> <b>MAY</b> only retain a limited number of <see cref="Asset">Asset</see>s in the <i>asset buffer</i>. The <see cref="Asset">Asset</see>s are stored in first-in-first-out method where the oldest <see cref="Asset">Asset</see> is removed when the <i>asset buffer</i> is full and a new <see cref="Asset">Asset</see> arrives.<br /><br />{{figure(first-in-first-out-asset-buffer-management)}} illustrates the oldest <see cref="Asset">Asset</see> being removed from the <i>asset buffer</i> when a new <see cref="Asset">Asset</see> is added and the <i>asset buffer</i> is full:<br /><br />![First In First Out Asset Buffer Management](figures/first-in-first-out-asset-buffer-management.png "first-in-first-out-asset-buffer-management"){: width="0.6"}<br /><br /><see cref="Asset">Asset</see>s are indexed by <see cref="Asset.assetId">assetId in Asset</see>. In the case of <see cref="Asset">Asset</see>s, {{figure(relationship-between-assetid-and-stored-asset-documents)}} demonstrates the relationship between the key (<see cref="Asset.assetId">assetId in Asset</see>) and the stored <see cref="Asset">Asset</see>:<br /><br />![Relationship between assetId and stored Asset documents](figures/relationship-between-assetid-and-stored-asset-documents.png "relationship-between-assetid-and-stored-asset-documents"){: width="0.25"}<br /><br />&gt; Note: The key (<see cref="Asset.assetId">assetId in Asset</see>) is independent of the order of the <see cref="Asset">Asset</see> stored in the <i>asset buffer</i>.<br /><br />When the <i>agent</i> receives a new <see cref="Asset">Asset</see>, one of the following rules <b>MUST</b> apply:<br /><br />* If the <see cref="Asset">Asset</see> is not in the <i>asset buffer</i>, the <i>agent</i> <b>MUST</b> add the new <see cref="Asset">Asset</see> to the front of the <i>asset buffer</i>. If the <i>asset buffer</i> is full, the oldest <see cref="Asset">Asset</see> will be removed from the <i>asset buffer</i>.<br /><br />* If the <see cref="Asset">Asset</see> is already in the <i>asset buffer</i>, the <i>agent</i> <b>MUST</b> replace the existing <see cref="Asset">Asset</see> and move the <see cref="Asset">Asset</see> to the front of the <i>asset buffer</i>. <br /><br />The number of <see cref="Asset">Asset</see> that may be stored in an <i>agent</i> is defined by the value for <see cref="Header.assetBufferSize">assetBufferSize in Header</see>. An <see cref="Header.assetBufferSize">assetBufferSize in Header</see> of 4,294,967,296 or <i> 2^{32 } </i> <b>MUST</b> indicate unlimited storage.<br /><br />The <i>asset buffer</i> <b>MAY</b> be ephemeral and the <see cref="Asset">Asset</see> entities will be lost if the <i>agent</i> clears the <i>asset buffer</i>. They must be recovered from the data source.<br /><br /><see cref="Asset Information Model">Asset Information Model</see> provides additional information on <i>asset</i> management. <br /><br />## Response Documents<br /><br /><i>response document</i>s are electronic documents generated by an <i>agent</i> in response to a <i>request</i> for data. <br /><br />The <i>response document</i>s defined in the MTConnect Standard are:<br /><br />* <i>MTConnectDevices Response Document</i>: Describes the composition and configuration of the <i>Device</i> and the data that can be observed. See <see cref="MTConnectDevices Response Document">MTConnectDevices Response Document</see> and <see cref="Device Information Model">Device Information Model</see> for details on this information model.<br /><br />* <i>MTConnectStreams Response Document</i>: <i>Observation</i>s made at a point in time about related <i>DataItem</i>s. See <see cref="MTConnectStreams Response Document">MTConnectStreams Response Document</see> and <see cref="Observation Information Model">Observation Information Model</see> for details on this information model.<br /><br />* <i>MTConnectAssets Response Document</i>: <i>Asset</i>s  related to <i>Device</i>s. See <see cref="MTConnectAssets Response Document">MTConnectAssets Response Document</see> and <see cref="Asset Information Model">Asset Information Model</see> for details on this information model.<br /><br />* <i>MTConnectErrors Response Document</i>: Information in response to a failed request. See <see cref="MTConnectErrors Response Document">MTConnectErrors Response Document</see> for details on this information model.<br /><br />## Request/Response Information Exchange<br /><br />The transfer of information between an <i>agent</i> and a client software application is based on a <i>request and response</i> REST protocol. A client application requests specific information from an <i>agent</i> and an <i>agent</i> responds with a <i>response document</i>.<br /><br />There are four types of <i>MTConnect Request</i>s. These <i>request</i>s are as follows:<br /><br />* <i>probe request</i>: Requests information about one more more <i>Device</i>s as an <see cref="MTConnectDevices">MTConnectDevices</see> block.<br /><br />* <i>current request</i>: Requests the most recent, or snapshot at a <i>sequence number</i>, <i>observation</i>s as an <see cref="MTConnectStreams">MTConnectStreams</see> block.<br /><br />* <i>sample request</i>: Requests a series of <i>observation</i>s as an <see cref="MTConnectStreams">MTConnectStreams</see> block.<br /><br />* <i>asset request</i>: Requests a set of <i>asset</i>s as an <see cref="MTConnectAssets">MTConnectAssets</see> block.<br /><br />If an <i>agent</i> is unable to respond to the request for information or the request includes invalid information, the <i>agent</i> will publish an <i>MTConnectErrors Response Document</i>. See <see cref="MTConnectErrors">MTConnectErrors</see>.<br /><br />See <see cref="REST Protocol">REST Protocol</see> for the details on the normative requirements of the agent.<br /><br /><br />Fundamentals Appendix<br /><br />{{newpage()}} <br /><br />## Fundamentals of Using XML to Encode Response Documents<br /><br />The MTConnect Standard specifies the structures and constructs that are used to encode <i>response document</i>s.  When these <i>response document</i>s are encoded using XML, there are additional rules defined by the XML standard that apply for creating an XML compliant document.  An implementer should refer to the W3C website for additional information on XML documentation and implementation details - http://www.w3.org/XML.<br /><br />The following provides specific terms and guidelines referenced in the MTConnect Standard for forming <i>response document</i>s with XML:  <br /><br /><br />* <c>tag</c>:  A <c>tag</c> is an XML construct that forms the foundation for an XML expression.  It defines the scope (beginning and end) of an XML expression.  The main types of tags are: <br /><br />* <c>start-tag</c>:  Designates the beginning on an XML element; e.g., &lt;<i>element name</i>&gt; <br /><br />* <c>end-tag</c>:  Designates the end on an XML element; e.g., &lt;/<i>element name</i>&gt;. <br /><br /><br />&gt; Note: If an element has no <i>child element</i>s or <i>CDATA</i>, the <c>end-tag</c> may be shortened to /&gt;.<br /><br /><br />* <c>Element</c>:  An element is an XML statement that is the primary building block for a document encoded using XML.  An element begins with a <c>start-tag</c> and ends with a matching <c>end-tag</c>.  The characters between the <c>start-tag</c> and the <c>end-tag</c> are the element's content.  The content may contain attributes, <i>CDATA</i>, and/or other elements.  If the content contains additional elements, these elements are called <i>child element</i>s.<br /><br />An example would be:  &lt;<i>element name</i>&gt;Content of the Element&lt;/<i>element name</i>&gt;.<br /><br />* <i>child element</i>:  An XML element that is contained within a higher-level <i>parent element</i>.  A <i>child element</i> is also known as a sub-element.  XML allows an unlimited hierarchy of <i>parent element</i>-<i>child element</i> relationships that establishes the structure that defines how the various pieces of information in the document relate to each other.  A <i>parent element</i> may have multiple associated <i>child element</i>s.<br /><br />* <i>element name</i>:  A descriptive identifier contained in both the <c>start-tag</c> and <c>end-tag</c> that provides the name of an XML element.<br /><br />* <c>Attribute</c>:  A construct consisting of a name–value pair that provides additional information about that XML element.  The format for an attribute is `name="value"; where the value for the attribute is enclosed in a set of quotation (“) marks.  An XML attribute <b>MUST</b> only have a single value and each attribute can appear at most once in each element.  Also, each attribute <b>MUST</b> be defined in a <i>schema</i> to either be required or optional.   <br /><br />* An example of attributes for an XML element is {{lst(example-of-attributes-for-an-element)}}:<br /><br />~~~~xml<br />&lt;DataItem category="SAMPLE" id="S1load"<br />  nativeUnits="PERCENT"  type="LOAD"<br />  units="PERCENT"/&gt;<br />~~~~<br />{: caption="Example of attributes for an element"}<br /><br />In this example, <see cref="DataItem">DataItem</see> is the <i>element name</i>.  <c>category</c>, <c>id</c>, <c>nativeUnits</c>, <c>type</c>, and <c>units</c> are the names of the attributes.  “<c>SAMPLE</c>", “<c>S1load</c>", “<c>PERCENT</c>", “<c>LOAD</c>", and “<c>PERCENT</c>" are the values for each of the respective attributes.<br /><br /><i> <i>CDATA</i>:  <i>CDATA</i> is an XML term representing </i>Character Data<i>. </i>Character Data* contains a value(s) or text that is associated with an XML element.  <i>CDATA</i> can be restricted to certain formats, patterns, or words.  <br /><br />An example of <i>CDATA</i> associated with an XML element would be {{lst(example-of-cdata-associated-with-element)}}:<br /><br />~~~~xml<br />&lt;Message id="M1"&gt;This is some text&lt;/Message&gt;<br />~~~~<br />{: caption="Example of cdata associated with element"}<br /><br />In this example, <c>Message</c> is the <i>element name</i> and <c>This is some text</c> is the <i>CDATA</i>.<br /><br />* <i>namespace</i>:  An XML <i>namespace</i> defines a unique vocabulary for named elements and attributes in an XML document.  An XML document may contain content that is associated with multiple <i>namespace</i>s.  Each <i>namespace</i> has its own unique identifier. <br /><br />Elements and attributes are associated with a specific <i>namespace</i> by placing a prefix on the name of the element or attribute that associates that name to a specific <i>namespace</i>; e.g., <c>x:MyTarget</c> associates the element name <c>MyTarget</c> with the <i>namespace</i> designated by <c>x:</c> (the prefix).<br /><br /><i>namespace</i>s are used to avoid naming conflicts within an XML document.  The naming convention used for elements and attributes may be associated with either the default <i>namespace</i> specified in the header of an XML document or they may be associated with one or more alternate <i>namespace</i>s.  All elements or attributes associated with a <i>namespace</i> that is not the default <i>namespace</i>, must include a prefix (e.g., x:) as part of the name of the element or attribute to associate it with the proper <i>namespace</i>.  See <see cref="Schema and Namespace Declaration Information">Schema and Namespace Declaration Information</see> for details on the structure for XML headers.<br /><br />The names of the elements and attributes declared in a <i>namespace</i> may be identified with a different prefix than the prefix that signifies that specific <i>namespace</i>.  These prefixes are called <i>namespace</i> aliases.  As an example, MTConnect Standard specific <i>namespace</i>s are designated as <c>m:</c> and the names of the elements and attributes defined in that <i>namespace</i> have an alias prefix of <c>mt:</c> which designates these names as MTConnect Standard specific vocabulary; e.g., <c>mt:MTConnectDevices</c>. <br /><br /><br />XML documents are encoded with a hierarchy of elements.  In general, XML elements may contain <i>child element</i>s, <i>CDATA</i>, or both.  However, in the MTConnect Standard, an element <b>MUST NOT</b> contain mixed content; meaning it cannot contain both <i>child element</i>s and <i>CDATA</i>. <br /><br />The <i>semantic data model</i> defined for each <i>response document</i> specifies the elements and <i>child element</i>s that may appear in a document.  The <i>semantic data model</i> also defines the number of times each element and <i>child element</i> may appear in the document.<br /><br />{{lst(example-of-hierarchy-of-xml-elements)}} demonstrates the hierarchy of XML elements and <i>child element</i>s used to form an XML document:<br /><br />~~~~xml<br />&lt;Root Level&gt;    (Parent Element)<br />  &lt;First Level&gt;  (Child Element to Root Level and <br />  Parent Element to Second Level)<br />    &lt;Second Level&gt;  (Child Element to First Level<br />    and Parent Element to Third Level)<br />      &lt;Third Level name="N1"&gt;&lt;/Third Level&gt;  <br />      (Child Element to Second Level)<br />      &lt;Third Level name="N2"&gt;&lt;/Third Level&gt;  <br />      (Child Element to Second Level)<br />      &lt;Third Level name="N3"&gt;&lt;/Third Level&gt;  <br />      (Child Element to Second Level)<br />    &lt;/Second Level&gt;   (end-tag for Second Level)<br />  &lt;/First Level&gt;   (end-tag for First Level)<br />&lt;/Root Level&gt;   (end-tag for Root Level)<br />~~~~<br />{: caption="Example of hierarchy of XML elements"}<br /><br /><br />In the {{lst(example-of-hierarchy-of-xml-elements)}}, <i>Root Level</i> and <i>First Level</i> have one <i>child element</i> (sub-elements) each and Second Level has three <i>child element</i>s; each called <i>Third Level</i>.  Each <i>Third Level</i> element has a different name attribute.  Each level in the structure is an element and each lower level element is a <i>child element</i>.<br /><br />{{newpage()}}<br /><br />## Schema and Namespace Declaration Information<br /><br />There are four pseudo-attributes typically included in the header of a <i>response document</i> that declare the <i>schema</i> and <i>namespace</i> for the document.  Each of these pseudo-attributes provides specific information for a client software application to properly interpret the content of the <i>response document</i>.<br /><br />The pseudo-attributes include:<br /><br />* <c>xmlns:xsi</c> – The <c>xsi</c> portion of this attribute name stands for <i>XML Schema</i> instance.  An <i>XML Schema</i> instance provides information that may be used by a software application to interpret XML specific information within a document.  See the W3C website for more details on <c>xmlns:xsi</c>.<br /><br />* <c>xmlns</c> – Declares the default <i>namespace</i> associated with the content of the <i>response document</i>.  The default <i>namespace</i> is considered to apply to all elements and attributes whenever the name of the element or attribute does not contain a prefix identifying an alternate <i>namespace</i>.<br /><br />The value of this attribute is an URN identifying the name of the file that defines the details of the <i>namespace</i> content.  This URN provides a unique identify for the <i>namespace</i>.<br /><br />* <c>xmlns:m</c> – Declares the MTConnect specific <i>namespace</i> associated with the content of the <i>response document</i>.  There may be multiple <i>namespace</i>s declared for an XML document.  Each may be associated to the default <i>namespace</i> or it may be totally independent.  The <c>:m</c> designates that this is a specific MTConnect <i>namespace</i> which is directly associated with the default <i>namespace</i>.<br /><br /> <br />&gt; Note:	See <see cref="Extensibility">Extensibility</see> for details regarding extended <i>namespace</i>s.<br /><br /><br />The value associated with this attribute is an URN identifying the name of the file that defines the details of the <i>namespace</i> content.<br /><br />* <c>xsi:schemaLocation</c> -  Declares the name for the <i>schema</i> associated with the <i>response document</i> and the location of the file that contains the details of the <i>schema</i> for that document.<br /><br />The value associated with this attribute has two parts:<br /><br />  * A URN identifying the name of the specific <i>XML Schema</i> instance associated with the <i>response document</i>.<br /><br />  * The path to the location where the file describing the specific <i>XML Schema</i> instance is located.  If the file is located in the same root directory where the <i>agent</i> is installed, then the local path MAY be declared.  Otherwise, a fully qualified URL must be declared to identify the location of the file.<br /><br /><br />&gt; Note:	In the format of the value associated with <c>xsi:schemaLocation</c>, the URN and the path to the <i>schema</i> file <b>MUST</b> be separated by a “space”.<br /><br /><br />In {{lst(example-of-schema-and-namespace-declaration)}}, the first line is the XML declaration.  The second line is a <i>root element</i> called <c>MTConnectDevices</c>.  The remaining four lines are the pseudo-attributes of <c>MTCconnectDevices</c> that declare the XML <i>schema</i> and <i>namespace</i> associated with an <i>MTConnectDevices Response Document</i>.<br /><br />~~~~xml<br />&lt;?xml version="1.0" encoding="UTF-8"?&gt;<br />  &lt;MTConnectDevices<br />   xmlns:xsi=http://www.w3.org/2001/XMLSchema-instance<br />   xmlns="urn:mtconnect.org:MTConnectDevices:1.3"<br />   xmlns:m="urn:mtconnect.org:MTConnectDevices:1.3"<br />   xsi:schemaLocation="urn:mtconnect.org:<br />    MTConnectDevices:1.3 /schemas/MTConnectDevices\_1.3.xsd"&gt;<br />~~~~<br />{: caption="Example of schema and namespace declaration"}<br /><br />The format for the values provided for each of the pseudo-attributes <b>MUST</b> reference the <i>semantic data model</i> (e.g., <c>MTConnectDevices</c>, <c>MTConnectStreams</c>, <c>MTConnectAssets</c>, or <c>MTConnectError</c>) and the version (i.e.; <c>1.1</c>, <c>1.2</c>, <c>1.3</c>, etc.) of the MTConnect Standard that depict the <i>schema</i> and <i>namespace</i>(s) associated with a specific <i>response document</i>.<br /><br />When an implementer chooses to extend an MTConnect <i>data model</i> by adding custom data types or additional <i>structural element</i>s, the <i>schema</i> and <i>namespace</i> for that <i>data model</i> should be updated to reflect the additional content.  When this is done, the <i>namespace</i> and <i>schema</i> information in the header should be updated to reflect the URI for the extended <i>namespace</i> and <i>schema</i>. <br /><br />{{newpage()}}<br /><br />## Extensibility<br /><br />MTConnect is an extensible standard, which means that implementers <b>MAY</b> extend the <i>data model</i>s defined in the various sections of the MTConnect Standard to include information required for a specific implementation.  When these <i>data model</i>s are encoded using XML, the methods for extending these <i>data model</i>s are defined by the rules established for extending any XML schema (see the W3C website for more details on extending XML data models).<br /><br />The following are typical extensions that <b>MAY</b> be considered in the MTConnect <i>data model</i>s:<br /><br />* Additional <c>type</c> and <c>subtype</c> values for <i>DataItem</i>s.<br /><br />* Additional <i>structural element</i>s as containers.<br /><br />* Additional <see cref="Composition">Composition</see> elements.<br /><br />* New <see cref="Asset">Asset</see> types that are sub-typed from the abstract <see cref="Asset">Asset</see> type.<br /><br />* <i>child element</i>s that may be added to specific XML elements contained within the <i>MTConnect Information Model</i>s.  These extended elements <b>MUST</b> be identified in a separate <i>namespace</i>.<br /><br /><br />When extending an MTConnect <i>data model</i>, there are some basic rules restricting changes to the MTConnect <i>data model</i>s.<br /><br />When extending an MTConnect <i>data model</i>, an implementer:<br /><br />* <b>MUST NOT</b> add new value for category for <i>DataItem</i>s,<br /><br />* <b>MUST NOT</b> add new <i>root element</i>s,<br /><br />* <b>SHOULD NOT</b> add new <i>top level</i> <i>Component</i>s, and<br /><br />* <b>MUST NOT</b> add any new attributes or include any sub-elements to <see cref="Composition">Composition</see>.<br /><br />&gt; Note:  Throughout the documents additional information is provided where extensibility may be acceptable or unacceptable to maintain compliance with the MTConnect Standard.<br /><br />When a <i>schema</i> representing a <i>data model</i> is extended, the <i>schema</i> and <i>namespace</i> declaration at the beginning of the corresponding <i>response document</i> <b>MUST</b> be updated to reflect the new <i>schema</i> and <i>namespace</i> so that a client software application can properly validate the <i>response document</i>.<br /><br />An XML example of a <i>schema</i> and <i>namespace</i> declaration, including an extended <i>schema</i> and <i>namespace</i>, is shown in {{lst(example-of-extended-schema-and-namespace-in-declaration)}}:<br /><br />~~~~xml<br />&lt;?xml version="1.0" encoding="UTF-8"?&gt;<br />  &lt;MTConnectDevices<br />   xmlns:xsi=http://www.w3.org/2001/XMLSchema-instance<br />   xmlns="urn:mtconnect.org:MTConnectDevices:1.3"<br />   xmlns:m="urn:mtconnect.org:MTConnectDevices:1.3"<br />   xmlns:x="urn:MyLocation:MyFile:MyVersion"<br />   xsi:schemaLocation="urn:MyLocation:MyFile:MyVersion<br />     /schemas/MyFileName.xsd" /&gt;<br />~~~~<br />{: caption="Example of extended schema and namespace in declaration"}<br /><br />In this example:<br /><br />* <c>xmlns:x</c> is added in Line 6 to identify the <i>XML Schema</i> instance for the extended <i>schema</i>.   <i>element name</i>s identified with an "<c>x</c>" prefix are associated with this specific <i>XML Schema</i> instance.<br /><br />&gt; Note: The "<c>x</c>" prefix <b>MAY</b> be replaced with any prefix that the implementer chooses for identifying the extended <i>schema</i> and <i>namespace</i>.<br /><br />* <c>xsi:schemaLocation</c> is modified in Line 7 to associate the <i>namespace</i> URN with the URL specifying the location of <i>schema</i> file.<br /><br />* <c>MyLocation</c>, <c>MyFile</c>, <c>MyVersion</c>, and <c>MyFileName</c> in Lines 6 and 7 <b>MUST</b> be replaced by the actual name, version, and location of the extended <i>schema</i>.<br /><br />When an extended <i>schema</i> is implemented, each <i>structural element</i>, <i>DataItem</i>, and <i>asset</i> defined in the extended <i>schema</i> <b>MUST</b> be identified in each respective <i>response document</i> by adding a prefix to the XML <i>element name</i> associated with that <i>structural element</i>, <i>DataItem</i>, or <i>asset</i>.  The prefix identifies the <i>schema</i> and <i>namespace</i> where that XML Element is defined. <br /><br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_496E1978_22AF_4543_A020_4616FFC25649">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class FundamentalsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="FundamentalsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAPK_496E1978_22AF_4543_A020_4616FFC25649";
		/// <summary>Constant value for <see cref="FundamentalsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package__EAPK_496E1978_22AF_4543_A020_4616FFC25649";
		/// <summary>Constant value for <see cref="FundamentalsPackage.Name" /></summary>
		public const string NAME = "Fundamentals";
		/// <summary>Constant value for <see cref="FundamentalsPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;The MTConnect Standard defines the normative information model and protocol for retrieving information from manufacturing equipment. This document specifies the {{term(agent)}} behavior and protocol.

## Agent

The MTConnect Standard specifies the minimum functionality of the {{term(agent)}}. The functionality is as follows:

* Provides store and forward messaging middleware service.
* Provides key-value information storage and asset retrieval service.
* Implements the REST API for the MTConnect Standard (See {{package(REST Protocol)}}).
  * {{term(Device)}} metadata.
  * {{termplural(observation)}} collected by the agent.
  * {{termplural(asset)}} collected by the agent.

There are three types of information stored by an {{term(agent)}} that **MAY** be published in a {{term(response document)}}. These are as follows:

* {{term(equipment metadata)}} specified in {{package(Device Information Model)}}.
* {{term(streaming data)}} provides the {{termplural(observation)}} specified in {{package(Observation Information Model)}}.
* {{termplural(Asset)}} specified in {{package(Asset Information Model)}}.

### Agent Instance ID

The {{term(agent)}} **MUST** set the `instanceId` to a unique value whenever the {{term(sequence number)}} in the agent is initialized to `1`.  (see {{sect(Sequence Numbers)}} and {{sect(Persistence and Recovery)}} below). 

### Storage of Equipment Metadata

An {{term(agent)}} **MUST** be capable of publishing {{term(equipment metadata)}} for the {{term(agent)}} as specified in {{package(Device Information Model)}}.

### Storage of Streaming Data

The {{term(agent)}} **MAY** implement a {{term(buffer)}} with a fixed number of {{termplural(observation)}}. If the `bufferSize` is fixed, the {{term(agent)}} **MUST** store {{termplural(observation)}} using a first-in-first-out pattern. The {{term(agent)}} will remove the oldest {{term(observation)}} when the {{term(buffer)}} is full and a new {{term(observation)}} arrives.

![Data Storage in Buffer](figures/data-storage-in-buffer.png ""data-storage-in-buffer""){: width=""0.8""}

In {{figure(first-in-first-out-buffer-management)}}, the maximum number of {{termplural(observation)}} that can be stored in the {{term(buffer)}} of the {{term(agent)}} is 8. The `bufferSize` in the header reports the maximum number of {{termplural(observation)}}. This example illustrates that when the {{term(buffer)}} fills up, the oldest piece of data falls out the other end.

![First In First Out Buffer Management](figures/first-in-first-out-buffer-management.png ""first-in-first-out-buffer-management""){: width=""0.8""}

> Note: As an implementation suggestion, the {{term(buffer)}} should be sized large enough to provide a continuous stream of {{termplural(observation)}}. The implementer should also consider the impact of a temporary loss of communications when determining the size for the {{term(buffer)}}. A larger {{term(buffer)}} will allow more time to reconnect to an {{term(agent)}} without losing data.

#### Sequence Numbers

In an {{term(agent)}}, each occurrence of an {{term(observation)}} in the {{term(buffer)}} will be assigned a monotonically increasing unsigned 64-bit integer ({{term(sequence number)}}) when it arrives. The first {{term(sequence number)}} **MUST** be `1`.

The {{term(sequence number)}} for each {{term(observation)}} **MUST** be unique for an instance of an {{term(agent)}} identified by an `instanceId`.

{{table(instanceid-and-sequence)}} illustrates the changing of the `instanceId` when an {{term(agent)}} resets the {{term(sequence number)}} to `1`.

| `instanceId` | `sequence` | 
|-------------:|-----------:|
|{{rowspan(5)}} 234556|234|
||235|
||236|
||237|
||238|
|{{span(2)}} Agent Stops and Restarts|
|{{rowspan(5)}} 234557|1|
||2|
||3|
||4|
||5|
{: caption=""instanceId and sequence"" label=""instanceid-and-sequence"" }

{{figure(identifying-the-range-of-data-with-firstsequence-and-lastsequence)}} shows two additional pieces of information defined for an {{term(agent)}}:

* `firstSequence` -- the oldest {{term(observation)}} in the {{term(buffer)}}. The {{term(agent)}} removes this {{term(observation)}} when it receives the next {{term(observation)}}

* `lastSequence` -- the newest {{term(observation)}} in the {{term(buffer)}}

`firstSequence` and `lastSequence` provide the range of values for the REST API requests.

![Indentifying the range of data with firstSequence and lastSequence](figures/identifying-the-range-of-data-with-firstsequence-and-lastsequence.png ""identifying-the-range-of-data-with-firstsequence-and-lastsequence""){: width=""0.75""}

The {{term(agent)}} **MUST** begin evaluating {{termplural(observation)}} with {{term(sample request)}}'s `from` parameter. Also, the {{term(agent)}}  **MUST** include a maximum number of {{termplural(observation)}} given by the `count` parameter in the {{term(response document)}}.

In {{figure(identifying-the-range-of-data-with-from-and-count)}}, the request specifies the {{termplural(observation)}} start at {{term(sequence number)}} `15` (`from`) and includes a total of three items (`count`).

![Identifying the range of data with from and count](figures/identifying-the-range-of-data-with-from-and-count.png ""identifying-the-range-of-data-with-from-and-count""){: width=""0.75""}

`nextSequence` header property has the {{term(sequence number)}} of the next {{term(observation)}} in the {{term(buffer)}} for subsequent {{termplural(sample request)}} providing a contiguous set of {{termplural(observation)}}. In the example in {{figure(identifying-the-range-of-data-with-from-and-count)}}, the next {{term(sequence number)}} (`nextSequence`) will be 18.

As shown in {{figure(identifying-the-range-of-data-with-nextsequence-and-lastsequence)}}, the combination of `from` and `count` defined by the {{term(request)}} indicates a {{term(sequence number)}} for data that is beyond that which is currently in the {{term(buffer)}}. In this case, `nextSequence` is set to a value of $$ lastSequence + 1 $$.

![Indentifying the range of data with nextSequence and lastSequence](figures/identifying-the-range-of-data-with-nextsequence-and-lastsequence.png ""identifying-the-range-of-data-with-nextsequence-and-lastsequence""){: width=""0.75""}

#### Observation Buffer

An {{term(observation)}} has four pieces of information as follows:

1. {{term(sequence number)}} associated with each {{term(observation)}} - `sequence`.
2. The `timestamp` the {{term(observation)}} was made. .
3. A reference to the `dataitemid` from the {{package(Device Information Model)}}.
4. The value of the {{term(observation)}}.

{{table(data-storage-concept)}} is an example demonstrating the concept of how data may be stored in an {{term(agent)}}:

| `sequence` | `timestamp` | `dataItemId` | `result` |
|-----------:|------------:|-------------:|---------:|
|`101`|`2016-12-13T09:44:00.2221Z`|`AVAIL-28277`|`UNAVAILABLE`|
|`102`|`2016-12-13T09:54:00.3839Z`|`AVAIL-28277`|`AVAILABLE`|
|`103`|`2016-12-13T10:00:00.0594Z`|`POS-Y-28277`|`25.348`|
|`104`|`2016-12-13T10:00:00.0594Z`|`POS-Z-28277`|`13.23`|
|`105`|`2016-12-13T10:00:03.2839Z`|`SS-28277`|`0`|
|`106`|`2016-12-13T10:00:03.2839Z`|`POS-X-28277`|`11.195`|
|`107`|`2016-12-13T10:00:03.2839Z`|`POS-Y-28277`|`24.938`|
|`108`|`2016-12-13T10:01:37.8594Z`|`POS-Z-28277`|`1.143`|
|`109`|`2016-12-13T10:02:03.2617Z`|`SS-28277`|`1002`|
{: caption=""Data Storage Concept"" label=""data-storage-concept"" }

#### Timestamp

{{termplural(observation)}} **MUST** have a `timestamp` giving the most accurate time that the {{term(observation)}} occurred.

The timezone of the `timestamp` **MUST** be UTC (Coordinated Universal Time)  and represented using ISO 8601 format: e.g., ""2010-04-01T21:22:43Z"".

Applications **SHOULD** use the {{term(observation)}}'s `timestamp` for ordering as opposed to {{term(sequence number)}}.

All {{termplural(observation)}} occurring at the same time **MUST** have the same `timestamp`. 

#### Recording Occurrences of Streaming Data

The {{term(agent)}} **MUST** only place {{termplural(observation)}} in the {{term(buffer)}} if the data has changed from the previous {{term(observation)}} for the same {{block(DataItem)}}. 

The {{term(agent)}} **MUST** place every {{term(observation)}} in the {{term(buffer)}}, without checking for changes, in the following cases:

* The {{property(DataItem::discrete)}} is `true`. 
* The {{property(DataItem::representation)}} is `DISCRETE`.
* The {{property(DataItem::representation)}} is `TIME_SERIES`.

#### Maintaining Last Value for Data Entities

An {{term(agent)}} **MUST** retain the most recent {{term(observation)}} associated with each {{block(DataItem)}}, even if the {{term(observation)}} is no longer in the {{term(buffer)}}. This function supports the {{term(current request)}} functionality.

#### Unavailability of Data

An {{term(observation)}} with the value of `UNAVAILABLE` indicates the value is indeterminate.

The {{term(agent)}} **MUST** initialize every {{block(DataItem)}}, unless it has a constant value (see below), with an {{term(observation)}} with the value of `UNAVAILABLE`. Aditionally, whenever the data source is unreachable, every {{block(DataItem)}} associated with the data source must have an {{term(observation)}} with the value of `UNAVAILABLE` and `timestamp` when the connection was lost. 

An {{block(DataItem)}} that is constrained to a constant value, as defined in {{package(Device Information Model)}}, **MUST** only have an {{term(observation)}} with the constant value and **MUST NOT** be set to `UNAVAILABLE`.

#### Persistence and Recovery

The {{term(agent)}} **MAY** have a fixed size {{term(buffer)}} and the {{term(buffer)}} **MAY** be ephemeral.

If the {{term(buffer)}} is recoverable, the {{term(agent)}} **MUST NOT** change the `instanceId` and **MUST NOT** set the {{term(sequence number)}} to `1`. The {{term(sequence number)}} **MUST** be one greater than the maximum value of the recovered {{termplural(observation)}}. $$ max(sequence) + 1 $$

### Storage of MTConnect Assets

An {{term(agent)}} **MAY** only retain a limited number of {{block(Asset)}}s in the {{term(asset buffer)}}. The {{block(Asset)}}s are stored in first-in-first-out method where the oldest {{block(Asset)}} is removed when the {{term(asset buffer)}} is full and a new {{block(Asset)}} arrives.

{{figure(first-in-first-out-asset-buffer-management)}} illustrates the oldest {{block(Asset)}} being removed from the {{term(asset buffer)}} when a new {{block(Asset)}} is added and the {{term(asset buffer)}} is full:

![First In First Out Asset Buffer Management](figures/first-in-first-out-asset-buffer-management.png ""first-in-first-out-asset-buffer-management""){: width=""0.6""}

{{block(Asset)}}s are indexed by {{property(Asset::assetId)}}. In the case of {{block(Asset)}}s, {{figure(relationship-between-assetid-and-stored-asset-documents)}} demonstrates the relationship between the key ({{property(Asset::assetId)}}) and the stored {{block(Asset)}}:

![Relationship between assetId and stored Asset documents](figures/relationship-between-assetid-and-stored-asset-documents.png ""relationship-between-assetid-and-stored-asset-documents""){: width=""0.25""}

> Note: The key ({{property(Asset::assetId)}}) is independent of the order of the {{block(Asset)}} stored in the {{term(asset buffer)}}.

When the {{term(agent)}} receives a new {{block(Asset)}}, one of the following rules **MUST** apply:

* If the {{block(Asset)}} is not in the {{term(asset buffer)}}, the {{term(agent)}} **MUST** add the new {{block(Asset)}} to the front of the {{term(asset buffer)}}. If the {{term(asset buffer)}} is full, the oldest {{block(Asset)}} will be removed from the {{term(asset buffer)}}.

* If the {{block(Asset)}} is already in the {{term(asset buffer)}}, the {{term(agent)}} **MUST** replace the existing {{block(Asset)}} and move the {{block(Asset)}} to the front of the {{term(asset buffer)}}. 

The number of {{block(Asset)}} that may be stored in an {{term(agent)}} is defined by the value for {{property(Header::assetBufferSize)}}. An {{property(Header::assetBufferSize)}} of 4,294,967,296 or $$ 2^{32 } $$ **MUST** indicate unlimited storage.

The {{term(asset buffer)}} **MAY** be ephemeral and the {{block(Asset)}} entities will be lost if the {{term(agent)}} clears the {{term(asset buffer)}}. They must be recovered from the data source.

{{package(Asset Information Model)}} provides additional information on {{term(asset)}} management. 

## Response Documents

{{termplural(response document)}} are electronic documents generated by an {{term(agent)}} in response to a {{term(request)}} for data. 

The {{termplural(response document)}} defined in the MTConnect Standard are:

* {{term(MTConnectDevices Response Document)}}: Describes the composition and configuration of the {{term(Device)}} and the data that can be observed. See {{package(MTConnectDevices Response Document)}} and {{package(Device Information Model)}} for details on this information model.

* {{term(MTConnectStreams Response Document)}}: {{termplural(Observation)}} made at a point in time about related {{termplural(DataItem)}}. See {{package(MTConnectStreams Response Document)}} and {{package(Observation Information Model)}} for details on this information model.

* {{term(MTConnectAssets Response Document)}}: {{termplural(Asset)}}  related to {{termplural(Device)}}. See {{package(MTConnectAssets Response Document)}} and {{package(Asset Information Model)}} for details on this information model.

* {{term(MTConnectErrors Response Document)}}: Information in response to a failed request. See {{package(MTConnectErrors Response Document)}} for details on this information model.

## Request/Response Information Exchange

The transfer of information between an {{term(agent)}} and a client software application is based on a {{term(request and response)}} REST protocol. A client application requests specific information from an {{term(agent)}} and an {{term(agent)}} responds with a {{term(response document)}}.

There are four types of {{termplural(MTConnect Request)}}. These {{termplural(request)}} are as follows:

* {{term(probe request)}}: Requests information about one more more {{termplural(Device)}} as an {{block(MTConnectDevices)}} block.

* {{term(current request)}}: Requests the most recent, or snapshot at a {{term(sequence number)}}, {{termplural(observation)}} as an {{block(MTConnectStreams)}} block.

* {{term(sample request)}}: Requests a series of {{termplural(observation)}} as an {{block(MTConnectStreams)}} block.

* {{term(asset request)}}: Requests a set of {{termplural(asset)}} as an {{block(MTConnectAssets)}} block.

If an {{term(agent)}} is unable to respond to the request for information or the request includes invalid information, the {{term(agent)}} will publish an {{term(MTConnectErrors Response Document)}}. See {{block(MTConnectErrors)}}.

See {{package(REST Protocol)}} for the details on the normative requirements of the agent.&#10;
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
";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			MTConnectProtocolPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.MTConnectProtocolPackage _MTConnectProtocolPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectProtocolPackage" path="/summary" />
	/// </summary>
	public Package.MTConnectProtocolPackage MTConnectProtocolPackage => _MTConnectProtocolPackage ?? (_MTConnectProtocolPackage = new Package.MTConnectProtocolPackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}