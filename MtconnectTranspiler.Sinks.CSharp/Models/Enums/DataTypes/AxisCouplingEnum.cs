#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417657_726565_2871">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum AxisCouplingEnum
	{
		/// <summary>﻿axes are physically connected to each other and operate as a single unit.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		TANDEM,
		/// <summary>﻿axes are not physically connected to each other but are operating together in lockstep.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		SYNCHRONOUS,
		/// <summary>﻿axis is the master of the <see cref="CoupledAxes">CoupledAxes</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		MASTER,
		/// <summary>﻿axis is a slave to the <see cref="CoupledAxes">CoupledAxes</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		SLAVE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417657_726565_2871">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AxisCouplingEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="AxisCouplingEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378417657_726565_2871";
		/// <summary>Constant value for <see cref="AxisCouplingEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417657_726565_2871";
		/// <summary>Constant value for <see cref="AxisCouplingEnumMetaClass.Name" /></summary>
		public const string NAME = "AxisCouplingEnum";
		/// <summary>Constant value for <see cref="AxisCouplingEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="AxisCouplingEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="AxisCouplingEnumMetaClass.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(AxisCouplingEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		TANDEM,
		SYNCHRONOUS,
		MASTER,
		SLAVE,
		};

		private TANDEMValue _TANDEM;
		/// <inheritdoc cref="TANDEMValue" path="/summary" />
		public TANDEMValue TANDEM => _TANDEM ?? (_TANDEM = new TANDEMValue());

		/// <summary>﻿axes are physically connected to each other and operate as a single unit.<br /><br /><br />
		/// Value for AxisCouplingEnum.<br/>
		/// <br/>See also <seealso cref="AxisCouplingEnum">AxisCouplingEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class TANDEMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TANDEMValue.Name" /></summary>
			public const string NAME = "TANDEM";
			/// <summary>Constant value for <see cref="TANDEMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="TANDEMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TANDEMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;axes are physically connected to each other and operate as a single unit.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SYNCHRONOUSValue _SYNCHRONOUS;
		/// <inheritdoc cref="SYNCHRONOUSValue" path="/summary" />
		public SYNCHRONOUSValue SYNCHRONOUS => _SYNCHRONOUS ?? (_SYNCHRONOUS = new SYNCHRONOUSValue());

		/// <summary>﻿axes are not physically connected to each other but are operating together in lockstep.<br /><br /><br />
		/// Value for AxisCouplingEnum.<br/>
		/// <br/>See also <seealso cref="AxisCouplingEnum">AxisCouplingEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class SYNCHRONOUSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SYNCHRONOUSValue.Name" /></summary>
			public const string NAME = "SYNCHRONOUS";
			/// <summary>Constant value for <see cref="SYNCHRONOUSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="SYNCHRONOUSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SYNCHRONOUSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;axes are not physically connected to each other but are operating together in lockstep.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MASTERValue _MASTER;
		/// <inheritdoc cref="MASTERValue" path="/summary" />
		public MASTERValue MASTER => _MASTER ?? (_MASTER = new MASTERValue());

		/// <summary>﻿axis is the master of the <see cref="CoupledAxes">CoupledAxes</see>.<br /><br /><br />
		/// Value for AxisCouplingEnum.<br/>
		/// <br/>See also <seealso cref="AxisCouplingEnum">AxisCouplingEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class MASTERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MASTERValue.Name" /></summary>
			public const string NAME = "MASTER";
			/// <summary>Constant value for <see cref="MASTERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="MASTERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MASTERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;axis is the master of the {{block(CoupledAxes)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SLAVEValue _SLAVE;
		/// <inheritdoc cref="SLAVEValue" path="/summary" />
		public SLAVEValue SLAVE => _SLAVE ?? (_SLAVE = new SLAVEValue());

		/// <summary>﻿axis is a slave to the <see cref="CoupledAxes">CoupledAxes</see>.<br /><br /><br />
		/// Value for AxisCouplingEnum.<br/>
		/// <br/>See also <seealso cref="AxisCouplingEnum">AxisCouplingEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class SLAVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SLAVEValue.Name" /></summary>
			public const string NAME = "SLAVE";
			/// <summary>Constant value for <see cref="SLAVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="SLAVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SLAVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;axis is a slave to the {{block(CoupledAxes)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
	}
}