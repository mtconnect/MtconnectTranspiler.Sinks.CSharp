#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1646992208875_933134_35">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum InterfaceEventEnum
	{
		/// <summary>
		/// operational state of an <see cref="Interface">Interface</see>.
		/// </summary>
		INTERFACE_STATE,
		/// <summary>
		/// operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.
		/// </summary>
		MATERIAL_FEED,
		/// <summary>
		/// operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.
		/// </summary>
		MATERIAL_CHANGE,
		/// <summary>
		/// operating state of the service to remove or retract material or product.
		/// </summary>
		MATERIAL_RETRACT,
		/// <summary>
		/// operating state of the service to change the part or product associated with a piece of equipment to a different part or product.
		/// </summary>
		PART_CHANGE,
		/// <summary>
		/// operating state of the service to load a piece of material or product.
		/// </summary>
		MATERIAL_LOAD,
		/// <summary>
		/// operating state of the service to unload a piece of material or product.
		/// </summary>
		MATERIAL_UNLOAD,
		/// <summary>
		/// operating state of the service to open a chuck.
		/// </summary>
		OPEN_CHUCK,
		/// <summary>
		/// operating state of the service to open a door.
		/// </summary>
		OPEN_DOOR,
		/// <summary>
		/// operating state of the service to close a chuck.
		/// </summary>
		CLOSE_CHUCK,
		/// <summary>
		/// operating state of the service to close a door.
		/// </summary>
		CLOSE_DOOR,
	}
}