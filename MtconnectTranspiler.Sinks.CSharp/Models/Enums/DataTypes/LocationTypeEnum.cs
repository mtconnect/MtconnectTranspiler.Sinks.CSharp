#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_0167FC5F_C61F_4bc7_A1B3_C724FE8865BA">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum LocationTypeEnum
	{
		/// <summary>
		/// number of the pot in the tool handling system.
		/// </summary>
		POT,
		/// <summary>
		/// tool location in a horizontal turning machine.
		/// </summary>
		STATION,
		/// <summary>
		/// location with regard to a tool crib.
		/// </summary>
		CRIB,
		/// <summary>
		/// location associated with a <i>spindle</i>.
		/// </summary>
		SPINDLE,
		/// <summary>
		/// location for a tool awaiting transfer from a tool magazine to spindle or a turret.
		/// </summary>
		TRANSFER_POT,
		/// <summary>
		/// location for a tool removed from a <i>spindle</i> or turret and awaiting return to a tool magazine. 
		/// </summary>
		RETURN_POT,
		/// <summary>
		/// location for a tool awaiting transfer to a tool magazine or turret from outside of the piece of equipment.
		/// </summary>
		STAGING_POT,
		/// <summary>
		/// location for a tool removed from a tool magazine or turret awaiting transfer to a location outside of the piece of equipment. 
		/// </summary>
		REMOVAL_POT,
		/// <summary>
		/// location for a tool that is no longer usable and is awaiting removal from a tool magazine or turret.
		/// </summary>
		EXPIRED_POT,
		/// <summary>
		/// location associated with an end effector.
		/// </summary>
		END_EFFECTOR,
	}
}