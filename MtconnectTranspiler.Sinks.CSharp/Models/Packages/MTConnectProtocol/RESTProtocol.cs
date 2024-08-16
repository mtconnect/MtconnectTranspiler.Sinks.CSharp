using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.RESTProtocol;

namespace Mtconnect.Fundamentals.MTConnectProtocol
{
	/// <summary>
	﻿/// An <i>agent</i> <b>MUST</b> provide a REST API <i>API</i> supporting HTTP version 1.0 or greater.  This interface <b>MUST</b> support HTTP (RFC7230) and use URIs (RFC3986) to identify specific information requested from an <i>agent</i>. <br /><br />The REST API adheres to the architectural principles of a stateless service to retrieve information associated with pieces of equipment. Additionally, the API is read-only and does not produce any side effects on the <i>agent</i> or the equipment. In REST state management, the client is responsible for recovery in case of an error or loss of connection.<br /><br />### HTTP Request<br /><br />An <i>agent</i> <b>MUST</b> support the <c>HTTP</c> <c>GET</c> verb, all other verbs are optional. See IETF RFC 7230 for a complete description of the HTTP request structure.<br /><br />The HTTP uses Uniform Resource Identifiers (URI) as outlined in IETF RFC 3986 as the <i>request-target</i>. IETF RFC 7230 specifies the http URI scheme for the <i>request-target</i> as follows:<br /><br />1. <c>protocol</c>: The protocol used for the request. Must be <c>http</c> or <c>https</c>.<br /><br />2. <c>authority</c>: The network domain or address of the agent with an optional port.<br /><br />3. <c>path</c>: A Hierarchical Identifier following a slash (<c>/</c>) and before the optional question-mark (<c>?</c>). The <c>path</c> separates segments by a slash (<c>/</c>).<br /><br />4. <c>query</c>: The portion of the HTTP request following the question-mark (<c>?</c>). The query portion of the HTTP request is composed of key-value pairs, <c><key>=<value></c> separated by an ampersand (<c>&</c>).<br /><br />#### <c>path</c> Portion of an HTTP Request<br /><br />The <c>path</c> portion of the <i>request-target</i> has the following segments:<br /><br />* <c>device-name</c> or <c>uuid</c>: optional <c>name</c> or <c>uuid</c> of the <see cref="Device">Device</see><br />* <c>request</c>: request, must be one of the following: (also see <see cref="Operations for Agent">Operations for Agent</see>)<br />  - {{operation(REST Protocol::Agent::probe)}}<br />  - {{operation(REST Protocol::Agent::current)}}<br />  - {{operation(REST Protocol::Agent::sample)}}<br />  - {{operation(REST Protocol::Agent::asset)}}  or <c>assets</c><br />    - {{operation(REST Protocol::Agent::asset)}} request has additional optional segment <c><asset ids></c><br />  <br />If <c>name</c> or <c>uuid</c> segement are not specified in the <i>HTTP Request</i>, an <i>agent</i> <b>MUST</b> return information for all pieces of equipment. The following sections will <br /><br />Examples: <br />  <br />* <c>http://localhost:5000/my_device/probe</c><br />  <br />    The request only provides information about <c>my_device</c>.<br />  <br />* <c>http://localhost:5000/probe</c><br /><br />  The request provides information for all devices. <br /><br />The following section specifies the details for each request.<br /><br />### MTConnect REST API<br /><br />An <i>agent</i> <b>MUST</b> support <i>probe request</i>s, <i>current request</i>s, <i>sample request</i>s, and <i>asset request</i>s.<br /><br />See the operations of the <see cref="REST Protocol::Agent">REST Protocol::Agent</see> for details regarding the <i>request</i>s.<br /><br />### HTTP Errors<br /><br />When an <i>agent</i> receives an <i>HTTP Request</i> that is incorrectly formatted or is not supported by the <i>agent</i>, the <i>agent</i> <b>MUST</b> publish an <i>HTTP Error Message</i> which includes a specific status code from the tables above indicating that the <i>request</i> could not be handled by the <i>agent</i>.<br /><br />Also, if the <i>agent</i> experiences an internal error and is unable to provide the requested <i>response document</i>, it <b>MUST</b> publish an <i>HTTP Error Message</i> that includes a specific status code from the table above.<br /><br />When an <i>agent</i> encounters an error in interpreting or responding to an <i>HTTP Request</i>, the <i>agent</i> <b>MUST</b> also publish an <i>MTConnectErrors Response Document</i> that provides additional details about the error.  See <see cref="Error Information Model">Error Information Model</see> for details on the <i>MTConnectErrors Response Document</i>.  <br /><br />#### Streaming Data<br /><br />HTTP <i>data streaming</i> is a method for an <i>agent</i> to provide a continuous stream of <i>observation</i>s in response to a single <i>request</i> using a <i>publish and subscribe</i> communication pattern.<br /><br />When an <i>HTTP Request</i> includes an <c>interval</c> parameter, an <i>agent</i> <b>MUST</b> provide data with a minimum delay in milliseconds between the end of one data transmission and the beginning of the next.  A value of zero (0) for the <c>interval</c> parameter indicates that the <i>agent</i> should deliver data at the highest rate possible and is only relevant for <i>sample request</i>s .<br /><br />The format of the response <b>MUST</b> use an <c>x-multipart-replace</c> encoded message with each section separated by MIME boundaries.  Each section <b>MUST</b> contain an entire <i>MTConnectStreams Response Document</i>. <br /><br />When streaming for a <i>current request</i>, the <i>agent</i> produces an <i>MTConnectStreams Response Document</i> with the most current <i>observation</i>s every <c>interval</c> milliseconds.<br /><br />When streaming for a <i>sample request</i>, if there are no available <i>observation</i>s after the <c>interval</c> time elapsed, the <i>agent</i> <b>MUST</b> wait for either the <c>heartbeat</c> time to elapse or an <i>observation</i> arrives. If the <c>heartbeat</c> time elapses and no <i>observation</i>s arrive, then an empty <i>MTConnectStreams Response Document</i> <b>MUST</b> be sent.<br /><br />> Note: For more information on MIME, see IETF RFC 1521 and RFC 822.<br /><br />An example of the format for an <i>HTTP Request</i> that  includes an <c>interval</c> parameter is:<br /><br />~~~~<br />http://localhost:5000/sample?interval=1000<br />~~~~<br />{: caption="Example for HTTP Request with interval parameter" label="example-for-http-request-with-interval-parameter"}<br /><br />HTTP Response Header:<br /><br />~~~~<br />HTTP/1.1 200 OK<br />Connection: close<br />Date: Sat, 13 Mar 2010 08:33:37 UTC<br />Status: 200 OK<br />Content-Disposition: inline<br />X-Runtime: 144ms<br />Content-Type: multipart/x-mixed-replace;boundary=<br />a8e12eced4fb871ac096a99bf9728425<br />Transfer-Encoding: chunked<br />~~~~<br />{: caption="HTTP Response header" label="http-response-header"}<br /><br />Lines 1-9 in {{lst(http-response-header)}} represent a standard header for a MIME <c>multipart/x-mixed-replace</c> message.  The boundary is a separator for each section of the stream. Lines 7-8 indicate this is a multipart MIME message and the boundary between sections. <br /><br />With streaming protocols, the <c>Content-length</c> <b>MUST</b> be omitted and <c>Transfer-Encoding</c> <b>MUST</b> be set to <c>chunked</c> (line 9). See IETF RFC 7230 for a full description of the HTTP protocol and chunked encoding.<br /><br />~~~~<br />--a8e12eced4fb871ac096a99bf9728425<br />Content-type: text/xml<br />Content-length: 887<br /><br /><?xml version="1.0" ecoding="UTF-8"?><br /><MTConnectStreams ...>...<br />~~~~<br />{: caption="HTTP Response header 2" label="http-response-header-2" start="last"}<br /><br />Each section of the document begins with a boundary preceded by two hyphens (<c>--</c>). The <c>Content-type</c> and <c>Content-length</c> header fields <b>MUST</b> be provided for each section and <b>MUST</b> be followed by <c><CR><LF><CR><LF></c> (ASCII code for <c><CR></c> is 13 and <c><LF></c> 10) before the <i>XML</i> document. The header and the <c><CR><LF><CR><LF></c> <b>MUST NOT</b> be included in the computation of the content length.<br /><br />An <i>agent</i> MUST continue to stream results until the client closes the connection. The <i>agent</i> MUST NOT stop streaming for any reason other than the following:<br /><br />* <i>agent</i> process stops<br />* The client application stops receiving data<br /><br />##### Heartbeat<br /><br />When <i>streaming data</i> is requested from a <i>sample request</i>, an <i>agent</i> <b>MUST</b> support a <i>heartbeat</i> to indicate to a client application that the HTTP connection is still viable during times when there is no new data available to be published.  The <i>heartbeat</i> is indicated by an <i>agent</i> by sending an MTConnect <i>response document</i> with an empty <see cref="Steams">Steams</see> entity (See <see cref="Observation Information Model">Observation Information Model</see> for more details on <see cref="Streams">Streams</see>) to the client software application.<br /><br />The <i>heartbeat</i> <b>MUST</b> occur on a periodic basis given by the optional <c>heartbeat</c> query parameter and <b>MUST</b> default to 10 seconds.  An <i>agent</i> <b>MUST</b> maintain a separate <i>heartbeat</i> for each client application for which the <i>agent</i> is responding to a <i>data streaming</i> <i>request</i>.<br /><br />An <i>agent</i> <b>MUST</b> begin calculating the interval for the time-period of the <i>heartbeat</i> for each client application immediately after a <i>response document</i> is published to that specific client application.<br /><br />The <i>heartbeat</i> remains in effect for each client software application until the <i>data streaming</i> <i>request</i> is terminated by either the <i>agent</i> or the client application.<br /><br />#### References<br /><br />A <see cref="Component">Component</see> <b>MAY</b> include a set of <see cref="Reference">Reference</see> entities of the following types that <b>MAY</b> alter the content of the <i>MTConnectStreams Response Document</i>s published in response to a <i>current request</i> or a <i>sample request</i> as specified:<br /><br />* A <i>Component</i> reference (<see cref="ComponentRef">ComponentRef</see>) modifies the set of <i>Observation</i>s, limited by a path query parameter of a <i>current request</i> or <i>sample request</i>, to include the <i>Observation</i>s associated with the entity whose value for its <c>id</c> attribute matches the value provided for the <c>idRef</c> attribute of the <see cref="ComponentRef">ComponentRef</see> element. Additionally, <i>Observation</i>s defined for any <i>lower level</i> entity(s) associated with the identified entities <b>MUST</b> also be returned. The result is equivalent to appending <c>//[@id=<"idRef">]</c> to the path query parameters of the <i>current request</i> or <i>sample request</i>. See <see cref="Agent">Agent</see> for more details on path queries.<br /><br />* A <i>DataItem</i> reference (<see cref="DataItemRef">DataItemRef</see>) modifies the set of resulting <i>Observation</i>s, limited by a path query parameter of a <i>current request</i> or <i>sample request</i>, to include the <i>Observation</i>s whose value for its <c>id</c> attribute matches the value provided for the <c>idRef</c> attribute of the <see cref="DataItemRef">DataItemRef</see> element. The result is equivalent to appending <c>//[@id=<"idRef">]</c> to the path query parameters of the <i>current request</i> or <i>sample request</i>. See <see cref="Agent">Agent</see> for more details on path queries.<br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_4_45f01b9_1637706615628_274120_5004">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class RESTProtocolPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1637706615628_274120_5004";
		
		/// <inheritdoc />
		public string Name => "REST Protocol";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;An {{term(agent)}} **MUST** provide a REST API {{term(API)}} supporting HTTP version 1.0 or greater.  This interface **MUST** support HTTP (RFC7230) and use URIs (RFC3986) to identify specific information requested from an {{term(agent)}}. 

The REST API adheres to the architectural principles of a stateless service to retrieve information associated with pieces of equipment. Additionally, the API is read-only and does not produce any side effects on the {{term(agent)}} or the equipment. In REST state management, the client is responsible for recovery in case of an error or loss of connection.

### HTTP Request

An {{term(agent)}} **MUST** support the `HTTP` `GET` verb, all other verbs are optional. See IETF RFC 7230 for a complete description of the HTTP request structure.

The HTTP uses Uniform Resource Identifiers (URI) as outlined in IETF RFC 3986 as the *request-target*. IETF RFC 7230 specifies the http URI scheme for the *request-target* as follows:

1. `protocol`: The protocol used for the request. Must be `http` or `https`.

2. `authority`: The network domain or address of the agent with an optional port.

3. `path`: A Hierarchical Identifier following a slash (`/`) and before the optional question-mark (`?`). The `path` separates segments by a slash (`/`).

4. `query`: The portion of the HTTP request following the question-mark (`?`). The query portion of the HTTP request is composed of key-value pairs, `<key>=<value>` separated by an ampersand (`&`).

#### `path` Portion of an HTTP Request

The `path` portion of the *request-target* has the following segments:

* `device-name` or `uuid`: optional `name` or `uuid` of the {{block(Device)}}
* `request`: request, must be one of the following: (also see {{sect(Operations for Agent)}})
  - {{operation(REST Protocol::Agent::probe)}}
  - {{operation(REST Protocol::Agent::current)}}
  - {{operation(REST Protocol::Agent::sample)}}
  - {{operation(REST Protocol::Agent::asset)}}  or `assets`
    - {{operation(REST Protocol::Agent::asset)}} request has additional optional segment `<asset ids>`
  
If `name` or `uuid` segement are not specified in the {{term(HTTP Request)}}, an {{term(agent)}} **MUST** return information for all pieces of equipment. The following sections will 

Examples: 
  
* `http://localhost:5000/my_device/probe`
  
    The request only provides information about `my_device`.
  
* `http://localhost:5000/probe`

  The request provides information for all devices. 

The following section specifies the details for each request.

### MTConnect REST API

An {{term(agent)}} **MUST** support {{termplural(probe request)}}, {{termplural(current request)}}, {{termplural(sample request)}}, and {{termplural(asset request)}}.

See the operations of the {{block(REST Protocol::Agent)}} for details regarding the {{termplural(request)}}.

### HTTP Errors

When an {{term(agent)}} receives an {{term(HTTP Request)}} that is incorrectly formatted or is not supported by the {{term(agent)}}, the {{term(agent)}} **MUST** publish an {{term(HTTP Error Message)}} which includes a specific status code from the tables above indicating that the {{term(request)}} could not be handled by the {{term(agent)}}.

Also, if the {{term(agent)}} experiences an internal error and is unable to provide the requested {{term(response document)}}, it **MUST** publish an {{term(HTTP Error Message)}} that includes a specific status code from the table above.

When an {{term(agent)}} encounters an error in interpreting or responding to an {{term(HTTP Request)}}, the {{term(agent)}} **MUST** also publish an {{term(MTConnectErrors Response Document)}} that provides additional details about the error.  See {{sect(Error Information Model)}} for details on the {{term(MTConnectErrors Response Document)}}.  

#### Streaming Data

HTTP {{term(data streaming)}} is a method for an {{term(agent)}} to provide a continuous stream of {{termplural(observation)}} in response to a single {{term(request)}} using a {{term(publish and subscribe)}} communication pattern.

When an {{term(HTTP Request)}} includes an `interval` parameter, an {{term(agent)}} **MUST** provide data with a minimum delay in milliseconds between the end of one data transmission and the beginning of the next.  A value of zero (0) for the `interval` parameter indicates that the {{term(agent)}} should deliver data at the highest rate possible and is only relevant for {{termplural(sample request)}} .

The format of the response **MUST** use an `x-multipart-replace` encoded message with each section separated by MIME boundaries.  Each section **MUST** contain an entire {{term(MTConnectStreams Response Document)}}. 

When streaming for a {{term(current request)}}, the {{term(agent)}} produces an {{term(MTConnectStreams Response Document)}} with the most current {{termplural(observation)}} every `interval` milliseconds.

When streaming for a {{term(sample request)}}, if there are no available {{termplural(observation)}} after the `interval` time elapsed, the {{term(agent)}} **MUST** wait for either the `heartbeat` time to elapse or an {{term(observation)}} arrives. If the `heartbeat` time elapses and no {{termplural(observation)}} arrive, then an empty {{term(MTConnectStreams Response Document)}} **MUST** be sent.

> Note: For more information on MIME, see IETF RFC 1521 and RFC 822.

An example of the format for an {{term(HTTP Request)}} that  includes an `interval` parameter is:

~~~~
http://localhost:5000/sample?interval=1000
~~~~
{: caption=""Example for HTTP Request with interval parameter"" label=""example-for-http-request-with-interval-parameter""}

HTTP Response Header:

~~~~
HTTP/1.1 200 OK
Connection: close
Date: Sat, 13 Mar 2010 08:33:37 UTC
Status: 200 OK
Content-Disposition: inline
X-Runtime: 144ms
Content-Type: multipart/x-mixed-replace;boundary=
a8e12eced4fb871ac096a99bf9728425
Transfer-Encoding: chunked
~~~~
{: caption=""HTTP Response header"" label=""http-response-header""}

Lines 1-9 in {{lst(http-response-header)}} represent a standard header for a MIME `multipart/x-mixed-replace` message.  The boundary is a separator for each section of the stream. Lines 7-8 indicate this is a multipart MIME message and the boundary between sections. 

With streaming protocols, the `Content-length` **MUST** be omitted and `Transfer-Encoding` **MUST** be set to `chunked` (line 9). See IETF RFC 7230 for a full description of the HTTP protocol and chunked encoding.

~~~~
--a8e12eced4fb871ac096a99bf9728425
Content-type: text/xml
Content-length: 887

<?xml version=""1.0"" ecoding=""UTF-8""?>
<MTConnectStreams ...>...
~~~~
{: caption=""HTTP Response header 2"" label=""http-response-header-2"" start=""last""}

Each section of the document begins with a boundary preceded by two hyphens (`--`). The `Content-type` and `Content-length` header fields **MUST** be provided for each section and **MUST** be followed by `<CR><LF><CR><LF>` (ASCII code for `<CR>` is 13 and `<LF>` 10) before the {{term(XML)}} document. The header and the `<CR><LF><CR><LF>` **MUST NOT** be included in the computation of the content length.

An {{term(agent)}} MUST continue to stream results until the client closes the connection. The {{term(agent)}} MUST NOT stop streaming for any reason other than the following:

* {{term(agent)}} process stops
* The client application stops receiving data

##### Heartbeat

When {{term(streaming data)}} is requested from a {{term(sample request)}}, an {{term(agent)}} **MUST** support a {{term(heartbeat)}} to indicate to a client application that the HTTP connection is still viable during times when there is no new data available to be published.  The {{term(heartbeat)}} is indicated by an {{term(agent)}} by sending an MTConnect {{term(response document)}} with an empty {{block(Steams)}} entity (See {{package(Observation Information Model)}} for more details on {{block(Streams)}}) to the client software application.

The {{term(heartbeat)}} **MUST** occur on a periodic basis given by the optional `heartbeat` query parameter and **MUST** default to 10 seconds.  An {{term(agent)}} **MUST** maintain a separate {{term(heartbeat)}} for each client application for which the {{term(agent)}} is responding to a {{term(data streaming)}} {{term(request)}}.

An {{term(agent)}} **MUST** begin calculating the interval for the time-period of the {{term(heartbeat)}} for each client application immediately after a {{term(response document)}} is published to that specific client application.

The {{term(heartbeat)}} remains in effect for each client software application until the {{term(data streaming)}} {{term(request)}} is terminated by either the {{term(agent)}} or the client application.

#### References

A {{block(Component)}} **MAY** include a set of {{block(Reference)}} entities of the following types that **MAY** alter the content of the {{termplural(MTConnectStreams Response Document)}} published in response to a {{term(current request)}} or a {{term(sample request)}} as specified:

* A {{term(Component)}} reference ({{block(ComponentRef)}}) modifies the set of {{termplural(Observation)}}, limited by a path query parameter of a {{term(current request)}} or {{term(sample request)}}, to include the {{termplural(Observation)}} associated with the entity whose value for its `id` attribute matches the value provided for the `idRef` attribute of the {{block(ComponentRef)}} element. Additionally, {{termplural(Observation)}} defined for any {{term(lower level)}} entity(s) associated with the identified entities **MUST** also be returned. The result is equivalent to appending `//[@id=<""idRef"">]` to the path query parameters of the {{term(current request)}} or {{term(sample request)}}. See {{package(Agent)}} for more details on path queries.

* A {{term(DataItem)}} reference ({{block(DataItemRef)}}) modifies the set of resulting {{termplural(Observation)}}, limited by a path query parameter of a {{term(current request)}} or {{term(sample request)}}, to include the {{termplural(Observation)}} whose value for its `id` attribute matches the value provided for the `idRef` attribute of the {{block(DataItemRef)}} element. The result is equivalent to appending `//[@id=<""idRef"">]` to the path query parameters of the {{term(current request)}} or {{term(sample request)}}. See {{package(Agent)}} for more details on path queries.
&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			AgentClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.AgentClass _AgentClass;
	/// <summary>
	/// <inheritdoc cref="Package.AgentClass" path="/summary" />
	/// </summary>
	public Package.AgentClass AgentClass => _AgentClass ?? (_AgentClass = new Package.AgentClass());

	#endregion
	}
}