using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel;
// using Mtconnect;

namespace Mtconnect
{
	/// <summary>
	/// The <i>Observation Information Model</i> provides a representation of the data reported by a piece of equipment used for a manufacturing process, or used for any other purpose.  Additional descriptive information associated with the reported data is defined by the <see cref="MTConnectDevices">MTConnectDevices</see> entity, which is described in <see cref="Device Information Model">Device Information Model</see>.  Information defined in the <i>Observation Information Model</i> allows a software application to (1) determine the <i>Observation</i>s for <i>DataItem</i>s returned from a piece of equipment and (2) interpret the data associated with those <i>Observation</i>s with the same meaning, value, and context that it had at its original source.  To do this, the software application issues one of two HTTP requests to an <i>agent</i> associated with a piece of equipment.  They are:  * <c>sample</c>:  Returns a designated number of time stamped <i>Observation</i>s from an <i>agent</i> associated with a piece of equipment; subject to any HTTP filtering associated with the request.  See <see cref="Agent">Agent</see> in <see cref="Fundamentals">Fundamentals</see> for details on the <c>sample</c> HTTP request.  * <c>current</c>:  Returns a snapshot of either the most recent values or the values at a given sequence number for all <i>Observation</i>s associated with a piece of equipment from an <i>agent</i>; subject to any HTTP filtering associated with the request.  See <see cref="Agent">Agent</see> in <see cref="Fundamentals">Fundamentals</see> for details on the <c>current</c> HTTP request.   An <i>agent</i> responds to either the <c>sample</c> or <c>current</c> HTTP request with an <i>MTConnectStreams Response Document</i>.  This document contains information describing <i>Observation</i>s reported by an <i>agent</i> associated with a piece of equipment.   A client software application may correlate the information provided in the <i>MTConnectStreams Response Document</i> with the physical and logical structure for that piece of equipment defined in the <see cref="MTConnectDevices">MTConnectDevices</see> entity to form a clear and unambiguous understanding of the information provided.  (See details on the structure for a piece of equipment described in <see cref="Device Information Model">Device Information Model</see>).  <see cref="Streams">Streams</see> for an <see cref="MTConnectStreams">MTConnectStreams</see> entity contains a <see cref="DeviceStream">DeviceStream</see> entity for each piece of equipment represented in the document.  Each <see cref="DeviceStream">DeviceStream</see> is comprised of two primary types of entities – <i>Component</i>s and <i>Observation</i>s.  The contents of the <see cref="DeviceStream">DeviceStream</see> container are described in detail in this document, <see cref="Observation Information Model">Observation Information Model</see> of the MTConnect Standard.  <i>Component</i>s are defined for both the <see cref="MTConnectDevices">MTConnectDevices</see> and the <see cref="MTConnectStreams">MTConnectStreams</see> entities.  These <i>Component</i>s are used to provide a logical organization of the information provided in each entity.    * For an <see cref="MTConnectDevices">MTConnectDevices</see> entity: <i>Component</i>s organize information that represents the physical and logical parts and sub-parts of a piece of equipment.  (See <see cref="Component">Component</see> in <see cref="Device Information Model">Device Information Model</see> for more details on <i>Component</i>s used in the <see cref="MTConnectDevices">MTConnectDevices</see> entity).    * For an <see cref="MTConnectStreams">MTConnectStreams</see> entity: <i>Component</i>s provide the structure to organize the data returned from a piece of equipment and establishes the proper context for that data.  The <i>Component</i>s specifically defined for <see cref="MTConnectStreams">MTConnectStreams</see> are <see cref="DeviceStream">DeviceStream</see> (see <see cref="DeviceStream">DeviceStream</see>) and <see cref="ComponentStream">ComponentStream</see> (see <see cref="ComponentStream">ComponentStream</see>).     <see cref="DeviceStream">DeviceStream</see> and <see cref="ComponentStream">ComponentStream</see> entities have a direct correlation to each of the <i>Component</i> defined in the <see cref="MTConnectDevices">MTConnectDevices</see> entity.  Within each <see cref="ComponentStream">ComponentStream</see> entity in the <see cref="MTConnectStreams">MTConnectStreams</see> entity, <i>Observation</i>s are modeled as <see cref="Observation">Observation</see> entities. The three types of <see cref="Observation">Observation</see> entity are <see cref="Sample">Sample</see>, <see cref="Event">Event</see>, and <see cref="Condition">Condition</see>.  (See <see cref="Observation Types">Observation Types</see> for more information on these entities.) /// Observations Appendix
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class ObservationInformationModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566288489_320279_24855";
		
		/// <inheritdoc />
		public string Name => "ObservationInformationModel";

		/// <inheritdoc />
		public string Summary => @"/// The <i>Observation Information Model</i> provides a representation of the data reported by a piece of equipment used for a manufacturing process, or used for any other purpose.  Additional descriptive information associated with the reported data is defined by the <see cref=""MTConnectDevices"">MTConnectDevices</see> entity, which is described in <see cref=""Device Information Model"">Device Information Model</see>.  Information defined in the <i>Observation Information Model</i> allows a software application to (1) determine the <i>Observation</i>s for <i>DataItem</i>s returned from a piece of equipment and (2) interpret the data associated with those <i>Observation</i>s with the same meaning, value, and context that it had at its original source.  To do this, the software application issues one of two HTTP requests to an <i>agent</i> associated with a piece of equipment.  They are:  * <c>sample</c>:  Returns a designated number of time stamped <i>Observation</i>s from an <i>agent</i> associated with a piece of equipment; subject to any HTTP filtering associated with the request.  See <see cref=""Agent"">Agent</see> in <see cref=""Fundamentals"">Fundamentals</see> for details on the <c>sample</c> HTTP request.  * <c>current</c>:  Returns a snapshot of either the most recent values or the values at a given sequence number for all <i>Observation</i>s associated with a piece of equipment from an <i>agent</i>; subject to any HTTP filtering associated with the request.  See <see cref=""Agent"">Agent</see> in <see cref=""Fundamentals"">Fundamentals</see> for details on the <c>current</c> HTTP request.   An <i>agent</i> responds to either the <c>sample</c> or <c>current</c> HTTP request with an <i>MTConnectStreams Response Document</i>.  This document contains information describing <i>Observation</i>s reported by an <i>agent</i> associated with a piece of equipment.   A client software application may correlate the information provided in the <i>MTConnectStreams Response Document</i> with the physical and logical structure for that piece of equipment defined in the <see cref=""MTConnectDevices"">MTConnectDevices</see> entity to form a clear and unambiguous understanding of the information provided.  (See details on the structure for a piece of equipment described in <see cref=""Device Information Model"">Device Information Model</see>).  <see cref=""Streams"">Streams</see> for an <see cref=""MTConnectStreams"">MTConnectStreams</see> entity contains a <see cref=""DeviceStream"">DeviceStream</see> entity for each piece of equipment represented in the document.  Each <see cref=""DeviceStream"">DeviceStream</see> is comprised of two primary types of entities – <i>Component</i>s and <i>Observation</i>s.  The contents of the <see cref=""DeviceStream"">DeviceStream</see> container are described in detail in this document, <see cref=""Observation Information Model"">Observation Information Model</see> of the MTConnect Standard.  <i>Component</i>s are defined for both the <see cref=""MTConnectDevices"">MTConnectDevices</see> and the <see cref=""MTConnectStreams"">MTConnectStreams</see> entities.  These <i>Component</i>s are used to provide a logical organization of the information provided in each entity.    * For an <see cref=""MTConnectDevices"">MTConnectDevices</see> entity: <i>Component</i>s organize information that represents the physical and logical parts and sub-parts of a piece of equipment.  (See <see cref=""Component"">Component</see> in <see cref=""Device Information Model"">Device Information Model</see> for more details on <i>Component</i>s used in the <see cref=""MTConnectDevices"">MTConnectDevices</see> entity).    * For an <see cref=""MTConnectStreams"">MTConnectStreams</see> entity: <i>Component</i>s provide the structure to organize the data returned from a piece of equipment and establishes the proper context for that data.  The <i>Component</i>s specifically defined for <see cref=""MTConnectStreams"">MTConnectStreams</see> are <see cref=""DeviceStream"">DeviceStream</see> (see <see cref=""DeviceStream"">DeviceStream</see>) and <see cref=""ComponentStream"">ComponentStream</see> (see <see cref=""ComponentStream"">ComponentStream</see>).     <see cref=""DeviceStream"">DeviceStream</see> and <see cref=""ComponentStream"">ComponentStream</see> entities have a direct correlation to each of the <i>Component</i> defined in the <see cref=""MTConnectDevices"">MTConnectDevices</see> entity.  Within each <see cref=""ComponentStream"">ComponentStream</see> entity in the <see cref=""MTConnectStreams"">MTConnectStreams</see> entity, <i>Observation</i>s are modeled as <see cref=""Observation"">Observation</see> entities. The three types of <see cref=""Observation"">Observation</see> entity are <see cref=""Sample"">Sample</see>, <see cref=""Event"">Event</see>, and <see cref=""Condition"">Condition</see>.  (See <see cref=""Observation Types"">Observation Types</see> for more information on these entities.) /// Observations Appendix";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			RepresentationsPackage,
			ObservationTypesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			DeviceStreamClass,
			ComponentStreamClass,
			ObservationGeneralization,
			SampleClass,
			EventClass,
			ConditionClass,
		};
		#region Packages
	private Package.RepresentationsPackage _RepresentationsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RepresentationsPackage" path="/summary" />
	/// </summary>
	public Package.RepresentationsPackage RepresentationsPackage => _RepresentationsPackage ?? (_RepresentationsPackage = new Package.RepresentationsPackage());

	private Package.ObservationTypesPackage _ObservationTypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationTypesPackage" path="/summary" />
	/// </summary>
	public Package.ObservationTypesPackage ObservationTypesPackage => _ObservationTypesPackage ?? (_ObservationTypesPackage = new Package.ObservationTypesPackage());

	#endregion

	#region Classes
	private Package.DeviceStreamClass _DeviceStreamClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceStreamClass" path="/summary" />
	/// </summary>
	public Package.DeviceStreamClass DeviceStreamClass => _DeviceStreamClass ?? (_DeviceStreamClass = new Package.DeviceStreamClass());

	private Package.ComponentStreamClass _ComponentStreamClass;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentStreamClass" path="/summary" />
	/// </summary>
	public Package.ComponentStreamClass ComponentStreamClass => _ComponentStreamClass ?? (_ComponentStreamClass = new Package.ComponentStreamClass());

	private Package.ObservationGeneralization _ObservationGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationGeneralization" path="/summary" />
	/// </summary>
	public Package.ObservationGeneralization ObservationGeneralization => _ObservationGeneralization ?? (_ObservationGeneralization = new Package.ObservationGeneralization());

	private Package.SampleClass _SampleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SampleClass" path="/summary" />
	/// </summary>
	public Package.SampleClass SampleClass => _SampleClass ?? (_SampleClass = new Package.SampleClass());

	private Package.EventClass _EventClass;
	/// <summary>
	/// <inheritdoc cref="Package.EventClass" path="/summary" />
	/// </summary>
	public Package.EventClass EventClass => _EventClass ?? (_EventClass = new Package.EventClass());

	private Package.ConditionClass _ConditionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionClass" path="/summary" />
	/// </summary>
	public Package.ConditionClass ConditionClass => _ConditionClass ?? (_ConditionClass = new Package.ConditionClass());

	#endregion
	}
}