#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1582919522403_926879_1581">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum CodeEnum
	{
		/// <summary>
		/// largest diameter of the body of a tool item.
		/// </summary>
		BDX,
		/// <summary>
		/// distance measured along the X axis from that point of the item closest to the workpiece, including the cutting item for a tool item but excluding a protruding locking mechanism for an adaptive item, to either the front of the flange on a flanged body or the beginning of the connection interface feature on the machine side for cylindrical or prismatic shanks.
		/// </summary>
		LBX,
		/// <summary>
		/// maximum engagement of the cutting edge or edges with the workpiece measured perpendicular to the feed motion.
		/// </summary>
		APMX,
		/// <summary>
		/// maximum diameter of a circle on which the defined point Pk of each of the master inserts is located on a tool item. The normal of the machined peripheral surface points towards the axis of the cutting tool.
		/// </summary>
		DC,
		/// <summary>
		/// dimension between two parallel tangents on the outside edge of a flange.
		/// </summary>
		DF,
		/// <summary>
		/// largest length dimension of the cutting tool including the master insert where applicable.
		/// </summary>
		OAL,
		/// <summary>
		/// dimension of the diameter of a cylindrical portion of a tool item or an adaptive item that can participate in a connection.
		/// </summary>
		DMM,
		/// <summary>
		/// dimension of the height of the shank.
		/// </summary>
		H,
		/// <summary>
		/// dimension of the length of the shank.
		/// </summary>
		LS,
		/// <summary>
		/// maximum length of a cutting tool that can be used in a particular cutting operation including the non-cutting portions of the tool.
		/// </summary>
		LUX,
		/// <summary>
		/// dimension from the yz-plane to the furthest point of the tool item or adaptive item measured in the -X direction.
		/// </summary>
		LPR,
		/// <summary>
		/// total weight of the cutting tool in grams.   The force exerted by the mass of the cutting tool.
		/// </summary>
		WT,
		/// <summary>
		/// distance from the gauge plane or from the end of the shank to the furthest point on the tool, if a gauge plane does not exist, to the cutting reference point determined by the main function of the tool.   The <see cref="CuttingTool">CuttingTool</see> functional length will be the length of the entire tool, not a single cutting item. Each <see cref="CuttingItem">CuttingItem</see> can have an independent <see cref="FunctionalLength">FunctionalLength</see> represented in its measurements. 
		/// </summary>
		LF,
		/// <summary>
		/// theoretical sharp point of the cutting tool from which the major functional dimensions are taken.
		/// </summary>
		CRP,
		/// <summary>
		/// theoretical length of the cutting edge of a cutting item over sharp corners.
		/// </summary>
		L,
		/// <summary>
		/// angle between the driving mechanism locator on a tool item and the main cutting edge.
		/// </summary>
		DRVA,
		/// <summary>
		/// distance between the cutting reference point and the rear backing surface of a turning tool or the axis of a boring bar.
		/// </summary>
		WF,
		/// <summary>
		/// diameter of a circle to which all edges of a equilateral and round regular insert are tangential.
		/// </summary>
		IC,
		/// <summary>
		/// angle between the major cutting edge and the same cutting edge rotated by 180 degrees about the tool axis.
		/// </summary>
		SIG,
		/// <summary>
		/// angle between the tool cutting edge plane and the tool feed plane measured in a plane parallel the xy-plane.
		/// </summary>
		KAPR,
		/// <summary>
		/// angle between the tool cutting edge plane and a plane perpendicular to the tool feed plane measured in a plane parallel the xy-plane.
		/// </summary>
		PSIR,
		/// <summary>
		/// angle of the tool with respect to the workpiece for a given process.   The value is application specific.
		/// </summary>
		N_PER_A,
		/// <summary>
		/// measure of the length of a wiper edge of a cutting item.
		/// </summary>
		BS,
		/// <summary>
		/// length of a portion of a stepped tool that is related to a corresponding cutting diameter measured from the cutting reference point of that cutting diameter to the point on the next cutting edge at which the diameter starts to change.
		/// </summary>
		SDLX,
		/// <summary>
		/// angle between a major edge on a step of a stepped tool and the same cutting edge rotated 180 degrees about its tool axis.
		/// </summary>
		STAX,
		/// <summary>
		/// diameter of a circle on which the defined point Pk located on this cutting tool.  The normal of the machined peripheral surface points towards the axis of the cutting tool.
		/// </summary>
		DCX,
		/// <summary>
		/// distance from the basal plane of the tool item to the cutting point.
		/// </summary>
		HF,
		/// <summary>
		/// nominal radius of a rounded corner measured in the X Y-plane.
		/// </summary>
		RE,
		/// <summary>
		/// distance from the gauge plane or from the end of the shank of the cutting tool, if a gauge plane does not exist, to the cutting reference point determined by the main function of the tool.   This measurement will be with reference to the cutting tool and <b>MUST NOT</b> exist without a cutting tool.
		/// </summary>
		LFX,
		/// <summary>
		/// flat length of a chamfer.
		/// </summary>
		BCH,
		/// <summary>
		/// width of the chamfer.
		/// </summary>
		CHW,
		/// <summary>
		/// insert width when an inscribed circle diameter is not practical.
		/// </summary>
		W1,
	}
}