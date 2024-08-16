using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1582919522403_926879_1581">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CodeEnum
	{
		/// <summary>
		﻿/// largest diameter of the body of a tool item.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		BDX,
		/// <summary>
		﻿/// distance measured along the X axis from that point of the item closest to the workpiece, including the cutting item for a tool item but excluding a protruding locking mechanism for an adaptive item, to either the front of the flange on a flanged body or the beginning of the connection interface feature on the machine side for cylindrical or prismatic shanks.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LBX,
		/// <summary>
		﻿/// maximum engagement of the cutting edge or edges with the workpiece measured perpendicular to the feed motion.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		APMX,
		/// <summary>
		﻿/// maximum diameter of a circle on which the defined point Pk of each of the master inserts is located on a tool item. The normal of the machined peripheral surface points towards the axis of the cutting tool.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		DC,
		/// <summary>
		﻿/// dimension between two parallel tangents on the outside edge of a flange.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		DF,
		/// <summary>
		﻿/// largest length dimension of the cutting tool including the master insert where applicable.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		OAL,
		/// <summary>
		﻿/// dimension of the diameter of a cylindrical portion of a tool item or an adaptive item that can participate in a connection.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		DMM,
		/// <summary>
		﻿/// dimension of the height of the shank.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		H,
		/// <summary>
		﻿/// dimension of the length of the shank.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LS,
		/// <summary>
		﻿/// maximum length of a cutting tool that can be used in a particular cutting operation including the non-cutting portions of the tool.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LUX,
		/// <summary>
		﻿/// dimension from the yz-plane to the furthest point of the tool item or adaptive item measured in the -X direction.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LPR,
		/// <summary>
		﻿/// total weight of the cutting tool in grams. <br /><br />The force exerted by the mass of the cutting tool.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		WT,
		/// <summary>
		﻿/// distance from the gauge plane or from the end of the shank to the furthest point on the tool, if a gauge plane does not exist, to the cutting reference point determined by the main function of the tool. <br /><br />The <see cref="CuttingTool">CuttingTool</see> functional length will be the length of the entire tool, not a single cutting item. Each <see cref="CuttingItem">CuttingItem</see> can have an independent <see cref="FunctionalLength">FunctionalLength</see> represented in its measurements. <br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LF,
		/// <summary>
		﻿/// theoretical sharp point of the cutting tool from which the major functional dimensions are taken.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CRP,
		/// <summary>
		﻿/// theoretical length of the cutting edge of a cutting item over sharp corners.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		L,
		/// <summary>
		﻿/// angle between the driving mechanism locator on a tool item and the main cutting edge.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		DRVA,
		/// <summary>
		﻿/// distance between the cutting reference point and the rear backing surface of a turning tool or the axis of a boring bar.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		WF,
		/// <summary>
		﻿/// diameter of a circle to which all edges of a equilateral and round regular insert are tangential.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		IC,
		/// <summary>
		﻿/// angle between the major cutting edge and the same cutting edge rotated by 180 degrees about the tool axis.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		SIG,
		/// <summary>
		﻿/// angle between the tool cutting edge plane and the tool feed plane measured in a plane parallel the xy-plane.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		KAPR,
		/// <summary>
		﻿/// angle between the tool cutting edge plane and a plane perpendicular to the tool feed plane measured in a plane parallel the xy-plane.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		PSIR,
		/// <summary>
		﻿/// angle of the tool with respect to the workpiece for a given process. <br /><br />The value is application specific.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		N_PER_A,
		/// <summary>
		﻿/// measure of the length of a wiper edge of a cutting item.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		BS,
		/// <summary>
		﻿/// length of a portion of a stepped tool that is related to a corresponding cutting diameter measured from the cutting reference point of that cutting diameter to the point on the next cutting edge at which the diameter starts to change.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		SDLX,
		/// <summary>
		﻿/// angle between a major edge on a step of a stepped tool and the same cutting edge rotated 180 degrees about its tool axis.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		STAX,
		/// <summary>
		﻿/// diameter of a circle on which the defined point Pk located on this cutting tool.<br /><br />The normal of the machined peripheral surface points towards the axis of the cutting tool.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		DCX,
		/// <summary>
		﻿/// distance from the basal plane of the tool item to the cutting point.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		HF,
		/// <summary>
		﻿/// nominal radius of a rounded corner measured in the X Y-plane.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		RE,
		/// <summary>
		﻿/// distance from the gauge plane or from the end of the shank of the cutting tool, if a gauge plane does not exist, to the cutting reference point determined by the main function of the tool. <br /><br />This measurement will be with reference to the cutting tool and <b>MUST NOT</b> exist without a cutting tool.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LFX,
		/// <summary>
		﻿/// flat length of a chamfer.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		BCH,
		/// <summary>
		﻿/// width of the chamfer.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CHW,
		/// <summary>
		﻿/// insert width when an inscribed circle diameter is not practical.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		W1,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1582919522403_926879_1581">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CodeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CodeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(CodeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		BDX,
		LBX,
		APMX,
		DC,
		DF,
		OAL,
		DMM,
		H,
		LS,
		LUX,
		LPR,
		WT,
		LF,
		CRP,
		L,
		DRVA,
		WF,
		IC,
		SIG,
		KAPR,
		PSIR,
		N_PER_A,
		BS,
		SDLx,
		STAx,
		DCx,
		HF,
		RE,
		LFx,
		BCH,
		CHW,
		W1,
		};

		private BDXValue _BDX;
		/// <summary>
		﻿/// largest diameter of the body of a tool item.<br/><br />

		/// </summary>
		public BDXValue BDX => _BDX ?? (_BDX = new BDXValue());

		/// <summary>
		﻿/// largest diameter of the body of a tool item.<br/><br />

		/// </summary>
		public sealed class BDXValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BDX";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;largest diameter of the body of a tool item.&#10;
";
		}
		private LBXValue _LBX;
		/// <summary>
		﻿/// distance measured along the X axis from that point of the item closest to the workpiece, including the cutting item for a tool item but excluding a protruding locking mechanism for an adaptive item, to either the front of the flange on a flanged body or the beginning of the connection interface feature on the machine side for cylindrical or prismatic shanks.<br/><br />

		/// </summary>
		public LBXValue LBX => _LBX ?? (_LBX = new LBXValue());

		/// <summary>
		﻿/// distance measured along the X axis from that point of the item closest to the workpiece, including the cutting item for a tool item but excluding a protruding locking mechanism for an adaptive item, to either the front of the flange on a flanged body or the beginning of the connection interface feature on the machine side for cylindrical or prismatic shanks.<br/><br />

		/// </summary>
		public sealed class LBXValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LBX";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;distance measured along the X axis from that point of the item closest to the workpiece, including the cutting item for a tool item but excluding a protruding locking mechanism for an adaptive item, to either the front of the flange on a flanged body or the beginning of the connection interface feature on the machine side for cylindrical or prismatic shanks.&#10;
";
		}
		private APMXValue _APMX;
		/// <summary>
		﻿/// maximum engagement of the cutting edge or edges with the workpiece measured perpendicular to the feed motion.<br/><br />

		/// </summary>
		public APMXValue APMX => _APMX ?? (_APMX = new APMXValue());

		/// <summary>
		﻿/// maximum engagement of the cutting edge or edges with the workpiece measured perpendicular to the feed motion.<br/><br />

		/// </summary>
		public sealed class APMXValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "APMX";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;maximum engagement of the cutting edge or edges with the workpiece measured perpendicular to the feed motion.&#10;
";
		}
		private DCValue _DC;
		/// <summary>
		﻿/// maximum diameter of a circle on which the defined point Pk of each of the master inserts is located on a tool item. The normal of the machined peripheral surface points towards the axis of the cutting tool.<br/><br />

		/// </summary>
		public DCValue DC => _DC ?? (_DC = new DCValue());

		/// <summary>
		﻿/// maximum diameter of a circle on which the defined point Pk of each of the master inserts is located on a tool item. The normal of the machined peripheral surface points towards the axis of the cutting tool.<br/><br />

		/// </summary>
		public sealed class DCValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;maximum diameter of a circle on which the defined point Pk of each of the master inserts is located on a tool item. The normal of the machined peripheral surface points towards the axis of the cutting tool.&#10;
";
		}
		private DFValue _DF;
		/// <summary>
		﻿/// dimension between two parallel tangents on the outside edge of a flange.<br/><br />

		/// </summary>
		public DFValue DF => _DF ?? (_DF = new DFValue());

		/// <summary>
		﻿/// dimension between two parallel tangents on the outside edge of a flange.<br/><br />

		/// </summary>
		public sealed class DFValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DF";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;dimension between two parallel tangents on the outside edge of a flange.&#10;
";
		}
		private OALValue _OAL;
		/// <summary>
		﻿/// largest length dimension of the cutting tool including the master insert where applicable.<br/><br />

		/// </summary>
		public OALValue OAL => _OAL ?? (_OAL = new OALValue());

		/// <summary>
		﻿/// largest length dimension of the cutting tool including the master insert where applicable.<br/><br />

		/// </summary>
		public sealed class OALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;largest length dimension of the cutting tool including the master insert where applicable.&#10;
";
		}
		private DMMValue _DMM;
		/// <summary>
		﻿/// dimension of the diameter of a cylindrical portion of a tool item or an adaptive item that can participate in a connection.<br/><br />

		/// </summary>
		public DMMValue DMM => _DMM ?? (_DMM = new DMMValue());

		/// <summary>
		﻿/// dimension of the diameter of a cylindrical portion of a tool item or an adaptive item that can participate in a connection.<br/><br />

		/// </summary>
		public sealed class DMMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DMM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;dimension of the diameter of a cylindrical portion of a tool item or an adaptive item that can participate in a connection.&#10;
";
		}
		private HValue _H;
		/// <summary>
		﻿/// dimension of the height of the shank.<br/><br />

		/// </summary>
		public HValue H => _H ?? (_H = new HValue());

		/// <summary>
		﻿/// dimension of the height of the shank.<br/><br />

		/// </summary>
		public sealed class HValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "H";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;dimension of the height of the shank.&#10;
";
		}
		private LSValue _LS;
		/// <summary>
		﻿/// dimension of the length of the shank.<br/><br />

		/// </summary>
		public LSValue LS => _LS ?? (_LS = new LSValue());

		/// <summary>
		﻿/// dimension of the length of the shank.<br/><br />

		/// </summary>
		public sealed class LSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;dimension of the length of the shank.&#10;
";
		}
		private LUXValue _LUX;
		/// <summary>
		﻿/// maximum length of a cutting tool that can be used in a particular cutting operation including the non-cutting portions of the tool.<br/><br />

		/// </summary>
		public LUXValue LUX => _LUX ?? (_LUX = new LUXValue());

		/// <summary>
		﻿/// maximum length of a cutting tool that can be used in a particular cutting operation including the non-cutting portions of the tool.<br/><br />

		/// </summary>
		public sealed class LUXValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LUX";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;maximum length of a cutting tool that can be used in a particular cutting operation including the non-cutting portions of the tool.&#10;
";
		}
		private LPRValue _LPR;
		/// <summary>
		﻿/// dimension from the yz-plane to the furthest point of the tool item or adaptive item measured in the -X direction.<br/><br />

		/// </summary>
		public LPRValue LPR => _LPR ?? (_LPR = new LPRValue());

		/// <summary>
		﻿/// dimension from the yz-plane to the furthest point of the tool item or adaptive item measured in the -X direction.<br/><br />

		/// </summary>
		public sealed class LPRValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LPR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;dimension from the yz-plane to the furthest point of the tool item or adaptive item measured in the -X direction.&#10;
";
		}
		private WTValue _WT;
		/// <summary>
		﻿/// total weight of the cutting tool in grams. <br /><br />The force exerted by the mass of the cutting tool.<br/><br />

		/// </summary>
		public WTValue WT => _WT ?? (_WT = new WTValue());

		/// <summary>
		﻿/// total weight of the cutting tool in grams. <br /><br />The force exerted by the mass of the cutting tool.<br/><br />

		/// </summary>
		public sealed class WTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;total weight of the cutting tool in grams. 

The force exerted by the mass of the cutting tool.&#10;
";
		}
		private LFValue _LF;
		/// <summary>
		﻿/// distance from the gauge plane or from the end of the shank to the furthest point on the tool, if a gauge plane does not exist, to the cutting reference point determined by the main function of the tool. <br /><br />The <see cref="CuttingTool">CuttingTool</see> functional length will be the length of the entire tool, not a single cutting item. Each <see cref="CuttingItem">CuttingItem</see> can have an independent <see cref="FunctionalLength">FunctionalLength</see> represented in its measurements. <br/><br />

		/// </summary>
		public LFValue LF => _LF ?? (_LF = new LFValue());

		/// <summary>
		﻿/// distance from the gauge plane or from the end of the shank to the furthest point on the tool, if a gauge plane does not exist, to the cutting reference point determined by the main function of the tool. <br /><br />The <see cref="CuttingTool">CuttingTool</see> functional length will be the length of the entire tool, not a single cutting item. Each <see cref="CuttingItem">CuttingItem</see> can have an independent <see cref="FunctionalLength">FunctionalLength</see> represented in its measurements. <br/><br />

		/// </summary>
		public sealed class LFValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LF";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;distance from the gauge plane or from the end of the shank to the furthest point on the tool, if a gauge plane does not exist, to the cutting reference point determined by the main function of the tool. 

The {{block(CuttingTool)}} functional length will be the length of the entire tool, not a single cutting item. Each {{block(CuttingItem)}} can have an independent {{block(FunctionalLength)}} represented in its measurements. &#10;
";
		}
		private CRPValue _CRP;
		/// <summary>
		﻿/// theoretical sharp point of the cutting tool from which the major functional dimensions are taken.<br/><br />

		/// </summary>
		public CRPValue CRP => _CRP ?? (_CRP = new CRPValue());

		/// <summary>
		﻿/// theoretical sharp point of the cutting tool from which the major functional dimensions are taken.<br/><br />

		/// </summary>
		public sealed class CRPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CRP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;theoretical sharp point of the cutting tool from which the major functional dimensions are taken.&#10;
";
		}
		private LValue _L;
		/// <summary>
		﻿/// theoretical length of the cutting edge of a cutting item over sharp corners.<br/><br />

		/// </summary>
		public LValue L => _L ?? (_L = new LValue());

		/// <summary>
		﻿/// theoretical length of the cutting edge of a cutting item over sharp corners.<br/><br />

		/// </summary>
		public sealed class LValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "L";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;theoretical length of the cutting edge of a cutting item over sharp corners.&#10;
";
		}
		private DRVAValue _DRVA;
		/// <summary>
		﻿/// angle between the driving mechanism locator on a tool item and the main cutting edge.<br/><br />

		/// </summary>
		public DRVAValue DRVA => _DRVA ?? (_DRVA = new DRVAValue());

		/// <summary>
		﻿/// angle between the driving mechanism locator on a tool item and the main cutting edge.<br/><br />

		/// </summary>
		public sealed class DRVAValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DRVA";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;angle between the driving mechanism locator on a tool item and the main cutting edge.&#10;
";
		}
		private WFValue _WF;
		/// <summary>
		﻿/// distance between the cutting reference point and the rear backing surface of a turning tool or the axis of a boring bar.<br/><br />

		/// </summary>
		public WFValue WF => _WF ?? (_WF = new WFValue());

		/// <summary>
		﻿/// distance between the cutting reference point and the rear backing surface of a turning tool or the axis of a boring bar.<br/><br />

		/// </summary>
		public sealed class WFValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WF";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;distance between the cutting reference point and the rear backing surface of a turning tool or the axis of a boring bar.&#10;
";
		}
		private ICValue _IC;
		/// <summary>
		﻿/// diameter of a circle to which all edges of a equilateral and round regular insert are tangential.<br/><br />

		/// </summary>
		public ICValue IC => _IC ?? (_IC = new ICValue());

		/// <summary>
		﻿/// diameter of a circle to which all edges of a equilateral and round regular insert are tangential.<br/><br />

		/// </summary>
		public sealed class ICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "IC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;diameter of a circle to which all edges of a equilateral and round regular insert are tangential.&#10;
";
		}
		private SIGValue _SIG;
		/// <summary>
		﻿/// angle between the major cutting edge and the same cutting edge rotated by 180 degrees about the tool axis.<br/><br />

		/// </summary>
		public SIGValue SIG => _SIG ?? (_SIG = new SIGValue());

		/// <summary>
		﻿/// angle between the major cutting edge and the same cutting edge rotated by 180 degrees about the tool axis.<br/><br />

		/// </summary>
		public sealed class SIGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SIG";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;angle between the major cutting edge and the same cutting edge rotated by 180 degrees about the tool axis.&#10;
";
		}
		private KAPRValue _KAPR;
		/// <summary>
		﻿/// angle between the tool cutting edge plane and the tool feed plane measured in a plane parallel the xy-plane.<br/><br />

		/// </summary>
		public KAPRValue KAPR => _KAPR ?? (_KAPR = new KAPRValue());

		/// <summary>
		﻿/// angle between the tool cutting edge plane and the tool feed plane measured in a plane parallel the xy-plane.<br/><br />

		/// </summary>
		public sealed class KAPRValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "KAPR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;angle between the tool cutting edge plane and the tool feed plane measured in a plane parallel the xy-plane.&#10;
";
		}
		private PSIRValue _PSIR;
		/// <summary>
		﻿/// angle between the tool cutting edge plane and a plane perpendicular to the tool feed plane measured in a plane parallel the xy-plane.<br/><br />

		/// </summary>
		public PSIRValue PSIR => _PSIR ?? (_PSIR = new PSIRValue());

		/// <summary>
		﻿/// angle between the tool cutting edge plane and a plane perpendicular to the tool feed plane measured in a plane parallel the xy-plane.<br/><br />

		/// </summary>
		public sealed class PSIRValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PSIR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;angle between the tool cutting edge plane and a plane perpendicular to the tool feed plane measured in a plane parallel the xy-plane.&#10;
";
		}
		private N_PER_AValue _N_PER_A;
		/// <summary>
		﻿/// angle of the tool with respect to the workpiece for a given process. <br /><br />The value is application specific.<br/><br />

		/// </summary>
		public N_PER_AValue N_PER_A => _N_PER_A ?? (_N_PER_A = new N_PER_AValue());

		/// <summary>
		﻿/// angle of the tool with respect to the workpiece for a given process. <br /><br />The value is application specific.<br/><br />

		/// </summary>
		public sealed class N_PER_AValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "N/A";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;angle of the tool with respect to the workpiece for a given process. 

The value is application specific.&#10;
";
		}
		private BSValue _BS;
		/// <summary>
		﻿/// measure of the length of a wiper edge of a cutting item.<br/><br />

		/// </summary>
		public BSValue BS => _BS ?? (_BS = new BSValue());

		/// <summary>
		﻿/// measure of the length of a wiper edge of a cutting item.<br/><br />

		/// </summary>
		public sealed class BSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;measure of the length of a wiper edge of a cutting item.&#10;
";
		}
		private SDLxValue _SDLx;
		/// <summary>
		﻿/// length of a portion of a stepped tool that is related to a corresponding cutting diameter measured from the cutting reference point of that cutting diameter to the point on the next cutting edge at which the diameter starts to change.<br/><br />

		/// </summary>
		public SDLxValue SDLx => _SDLx ?? (_SDLx = new SDLxValue());

		/// <summary>
		﻿/// length of a portion of a stepped tool that is related to a corresponding cutting diameter measured from the cutting reference point of that cutting diameter to the point on the next cutting edge at which the diameter starts to change.<br/><br />

		/// </summary>
		public sealed class SDLxValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SDLx";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;length of a portion of a stepped tool that is related to a corresponding cutting diameter measured from the cutting reference point of that cutting diameter to the point on the next cutting edge at which the diameter starts to change.&#10;
";
		}
		private STAxValue _STAx;
		/// <summary>
		﻿/// angle between a major edge on a step of a stepped tool and the same cutting edge rotated 180 degrees about its tool axis.<br/><br />

		/// </summary>
		public STAxValue STAx => _STAx ?? (_STAx = new STAxValue());

		/// <summary>
		﻿/// angle between a major edge on a step of a stepped tool and the same cutting edge rotated 180 degrees about its tool axis.<br/><br />

		/// </summary>
		public sealed class STAxValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STAx";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;angle between a major edge on a step of a stepped tool and the same cutting edge rotated 180 degrees about its tool axis.&#10;
";
		}
		private DCxValue _DCx;
		/// <summary>
		﻿/// diameter of a circle on which the defined point Pk located on this cutting tool.<br /><br />The normal of the machined peripheral surface points towards the axis of the cutting tool.<br/><br />

		/// </summary>
		public DCxValue DCx => _DCx ?? (_DCx = new DCxValue());

		/// <summary>
		﻿/// diameter of a circle on which the defined point Pk located on this cutting tool.<br /><br />The normal of the machined peripheral surface points towards the axis of the cutting tool.<br/><br />

		/// </summary>
		public sealed class DCxValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DCx";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;diameter of a circle on which the defined point Pk located on this cutting tool.

The normal of the machined peripheral surface points towards the axis of the cutting tool.&#10;
";
		}
		private HFValue _HF;
		/// <summary>
		﻿/// distance from the basal plane of the tool item to the cutting point.<br/><br />

		/// </summary>
		public HFValue HF => _HF ?? (_HF = new HFValue());

		/// <summary>
		﻿/// distance from the basal plane of the tool item to the cutting point.<br/><br />

		/// </summary>
		public sealed class HFValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HF";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;distance from the basal plane of the tool item to the cutting point.&#10;
";
		}
		private REValue _RE;
		/// <summary>
		﻿/// nominal radius of a rounded corner measured in the X Y-plane.<br/><br />

		/// </summary>
		public REValue RE => _RE ?? (_RE = new REValue());

		/// <summary>
		﻿/// nominal radius of a rounded corner measured in the X Y-plane.<br/><br />

		/// </summary>
		public sealed class REValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;nominal radius of a rounded corner measured in the X Y-plane.&#10;
";
		}
		private LFxValue _LFx;
		/// <summary>
		﻿/// distance from the gauge plane or from the end of the shank of the cutting tool, if a gauge plane does not exist, to the cutting reference point determined by the main function of the tool. <br /><br />This measurement will be with reference to the cutting tool and <b>MUST NOT</b> exist without a cutting tool.<br/><br />

		/// </summary>
		public LFxValue LFx => _LFx ?? (_LFx = new LFxValue());

		/// <summary>
		﻿/// distance from the gauge plane or from the end of the shank of the cutting tool, if a gauge plane does not exist, to the cutting reference point determined by the main function of the tool. <br /><br />This measurement will be with reference to the cutting tool and <b>MUST NOT</b> exist without a cutting tool.<br/><br />

		/// </summary>
		public sealed class LFxValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LFx";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;distance from the gauge plane or from the end of the shank of the cutting tool, if a gauge plane does not exist, to the cutting reference point determined by the main function of the tool. 

This measurement will be with reference to the cutting tool and **MUST NOT** exist without a cutting tool.&#10;
";
		}
		private BCHValue _BCH;
		/// <summary>
		﻿/// flat length of a chamfer.<br/><br />

		/// </summary>
		public BCHValue BCH => _BCH ?? (_BCH = new BCHValue());

		/// <summary>
		﻿/// flat length of a chamfer.<br/><br />

		/// </summary>
		public sealed class BCHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BCH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;flat length of a chamfer.&#10;
";
		}
		private CHWValue _CHW;
		/// <summary>
		﻿/// width of the chamfer.<br/><br />

		/// </summary>
		public CHWValue CHW => _CHW ?? (_CHW = new CHWValue());

		/// <summary>
		﻿/// width of the chamfer.<br/><br />

		/// </summary>
		public sealed class CHWValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHW";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;width of the chamfer.&#10;
";
		}
		private W1Value _W1;
		/// <summary>
		﻿/// insert width when an inscribed circle diameter is not practical.<br/><br />

		/// </summary>
		public W1Value W1 => _W1 ?? (_W1 = new W1Value());

		/// <summary>
		﻿/// insert width when an inscribed circle diameter is not practical.<br/><br />

		/// </summary>
		public sealed class W1Value : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "W1";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;insert width when an inscribed circle diameter is not practical.&#10;
";
		}
	}
}