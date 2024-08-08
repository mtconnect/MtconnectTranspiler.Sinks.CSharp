using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel;
// using Mtconnect;

namespace Mtconnect
{
	/// <summary>
	/// The <i>Device Information Model</i> provides a representation of the physical and logical configuration for a piece of equipment used for a manufacturing process or for any other purpose.  It also provides the definition of data that may be reported by that equipment.   Using information defined in the <i>Device Information Model</i>, a software application can determine the configuration and reporting capabilities of a piece of equipment.  To do this, the software application issues a <i>probe request</i> (defined in <see cref="Fundamentals">Fundamentals</see>) to an <i>agent</i> associated with a piece of equipment. An <i>agent</i> responds to the <i>probe request</i> with an <i>MTConnectDevices Response Document</i> that contains information describing both the physical and logical structure of the piece of equipment and a detailed description of each <i>Observation</i> that can be reported by the <i>agent</i> associated with the piece of equipment. This information allows the client software application to interpret the document and to extract the data with the same meaning, value, and context that it had at its original source.    The <i>MTConnectDevices Response Document</i> is comprised of two sections: <see cref="Header">Header</see> and <see cref="Devices">Devices</see>.  The <see cref="Header">Header</see> section contains protocol related information as defined in <see cref="Fundamentals">Fundamentals</see>.  The <see cref="Devices">Devices</see> section of the <i>MTConnectDevices Response Document</i> contains a <see cref="Device">Device</see> entity for each piece of equipment described in the document.  Each <see cref="Device">Device</see> is comprised of two primary types of entities - <i>Component</i>s and <i>DataItem</i>s.    <i>Component</i>s organize information that represents the physical and logical parts and sub-parts of a piece of equipment (See <see cref="Components">Components</see> for more details).    <i>DataItem</i>s describe data that can be reported by a piece of equipment.  In the <i>Device Information Model</i>, <i>DataItem</i>s are defined as <see cref="DataItem">DataItem</see> entities (See <see cref="DataItem Types">DataItem Types</see>).  The <i>Component</i>s and <i>DataItem</i>s in the <i>MTConnectDevices Response Document</i> provide information representing the physical and logical structure for a piece of equipment and the types of data that the piece of equipment can report relative to that structure.   The <i>MTConnectDevices Response Document</i> does not contain values for the data types reported by the piece of equipment.  The <i>MTConnectStreams Response Document</i> defined in <see cref="Observation Information Model">Observation Information Model</see> provides the data values that are reported by the piece of equipment.  > Note:  The MTConnect Standard also defines the information model for <i>asset</i>s.  An <i>asset</i> is something that is used in the manufacturing process, but is not permanently associated with a single piece of equipment, can be removed from the piece of equipment without compromising its function, and can be associated with other pieces of equipment during its lifecycle.  See <see cref="Asset Information Model">Asset Information Model</see> for more details on <i>asset</i>s. /// Devices Appendix
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class DeviceInformationModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1642672857507_756619_19";
		
		/// <inheritdoc />
		public string Name => "DeviceInformationModel";

		/// <inheritdoc />
		public string Summary => @"/// The <i>Device Information Model</i> provides a representation of the physical and logical configuration for a piece of equipment used for a manufacturing process or for any other purpose.  It also provides the definition of data that may be reported by that equipment.   Using information defined in the <i>Device Information Model</i>, a software application can determine the configuration and reporting capabilities of a piece of equipment.  To do this, the software application issues a <i>probe request</i> (defined in <see cref=""Fundamentals"">Fundamentals</see>) to an <i>agent</i> associated with a piece of equipment. An <i>agent</i> responds to the <i>probe request</i> with an <i>MTConnectDevices Response Document</i> that contains information describing both the physical and logical structure of the piece of equipment and a detailed description of each <i>Observation</i> that can be reported by the <i>agent</i> associated with the piece of equipment. This information allows the client software application to interpret the document and to extract the data with the same meaning, value, and context that it had at its original source.    The <i>MTConnectDevices Response Document</i> is comprised of two sections: <see cref=""Header"">Header</see> and <see cref=""Devices"">Devices</see>.  The <see cref=""Header"">Header</see> section contains protocol related information as defined in <see cref=""Fundamentals"">Fundamentals</see>.  The <see cref=""Devices"">Devices</see> section of the <i>MTConnectDevices Response Document</i> contains a <see cref=""Device"">Device</see> entity for each piece of equipment described in the document.  Each <see cref=""Device"">Device</see> is comprised of two primary types of entities - <i>Component</i>s and <i>DataItem</i>s.    <i>Component</i>s organize information that represents the physical and logical parts and sub-parts of a piece of equipment (See <see cref=""Components"">Components</see> for more details).    <i>DataItem</i>s describe data that can be reported by a piece of equipment.  In the <i>Device Information Model</i>, <i>DataItem</i>s are defined as <see cref=""DataItem"">DataItem</see> entities (See <see cref=""DataItem Types"">DataItem Types</see>).  The <i>Component</i>s and <i>DataItem</i>s in the <i>MTConnectDevices Response Document</i> provide information representing the physical and logical structure for a piece of equipment and the types of data that the piece of equipment can report relative to that structure.   The <i>MTConnectDevices Response Document</i> does not contain values for the data types reported by the piece of equipment.  The <i>MTConnectStreams Response Document</i> defined in <see cref=""Observation Information Model"">Observation Information Model</see> provides the data values that are reported by the piece of equipment.  > Note:  The MTConnect Standard also defines the information model for <i>asset</i>s.  An <i>asset</i> is something that is used in the manufacturing process, but is not permanently associated with a single piece of equipment, can be removed from the piece of equipment without compromising its function, and can be associated with other pieces of equipment during its lifecycle.  See <see cref=""Asset Information Model"">Asset Information Model</see> for more details on <i>asset</i>s. /// Devices Appendix";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			ComponentsPackage,
			CompositionsPackage,
			DataItemsPackage,
			ReferencesPackage,
			ConfigurationsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			DeviceClass,
		};
		#region Packages
	private Package.ComponentsPackage _ComponentsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentsPackage" path="/summary" />
	/// </summary>
	public Package.ComponentsPackage ComponentsPackage => _ComponentsPackage ?? (_ComponentsPackage = new Package.ComponentsPackage());

	private Package.CompositionsPackage _CompositionsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionsPackage" path="/summary" />
	/// </summary>
	public Package.CompositionsPackage CompositionsPackage => _CompositionsPackage ?? (_CompositionsPackage = new Package.CompositionsPackage());

	private Package.DataItemsPackage _DataItemsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemsPackage" path="/summary" />
	/// </summary>
	public Package.DataItemsPackage DataItemsPackage => _DataItemsPackage ?? (_DataItemsPackage = new Package.DataItemsPackage());

	private Package.ReferencesPackage _ReferencesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ReferencesPackage" path="/summary" />
	/// </summary>
	public Package.ReferencesPackage ReferencesPackage => _ReferencesPackage ?? (_ReferencesPackage = new Package.ReferencesPackage());

	private Package.ConfigurationsPackage _ConfigurationsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ConfigurationsPackage" path="/summary" />
	/// </summary>
	public Package.ConfigurationsPackage ConfigurationsPackage => _ConfigurationsPackage ?? (_ConfigurationsPackage = new Package.ConfigurationsPackage());

	#endregion

	#region Classes
	private Package.DeviceClass _DeviceClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceClass" path="/summary" />
	/// </summary>
	public Package.DeviceClass DeviceClass => _DeviceClass ?? (_DeviceClass = new Package.DeviceClass());

	#endregion
	}
}