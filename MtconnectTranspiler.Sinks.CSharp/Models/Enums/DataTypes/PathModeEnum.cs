#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_174664_2881">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum PathModeEnum
	{
		/// <summary>﻿path is operating independently and without the influence of another path.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		INDEPENDENT,
		/// <summary>﻿path provides information or state values that influences the operation of other <see cref="DataItem">DataItem</see> of similar type.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		MASTER,
		/// <summary>﻿physical or logical parts which are not physically connected to each other but are operating together.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		SYNCHRONOUS,
		/// <summary>﻿axes associated with the path are mirroring the motion of the <c>MASTER</c> path.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		MIRROR,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_174664_2881">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PathModeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="PathModeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378417667_174664_2881";
		/// <summary>Constant value for <see cref="PathModeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_174664_2881";
		/// <summary>Constant value for <see cref="PathModeEnumMetaClass.Name" /></summary>
		public const string NAME = "PathModeEnum";
		/// <summary>Constant value for <see cref="PathModeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="PathModeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="PathModeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(PathModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		INDEPENDENT,
		MASTER,
		SYNCHRONOUS,
		MIRROR,
		};

		private INDEPENDENTValue _INDEPENDENT;
		/// <inheritdoc cref="INDEPENDENTValue" path="/summary" />
		public INDEPENDENTValue INDEPENDENT => _INDEPENDENT ?? (_INDEPENDENT = new INDEPENDENTValue());

		/// <summary>﻿path is operating independently and without the influence of another path.<br /><br /><br />
		/// Value for PathModeEnum.<br/>
		/// <br/>See also <seealso cref="PathModeEnum">PathModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class INDEPENDENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INDEPENDENTValue.Name" /></summary>
			public const string NAME = "INDEPENDENT";
			/// <summary>Constant value for <see cref="INDEPENDENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="INDEPENDENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INDEPENDENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;path is operating independently and without the influence of another path.&#10;
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

		/// <summary>﻿path provides information or state values that influences the operation of other <see cref="DataItem">DataItem</see> of similar type.<br /><br /><br />
		/// Value for PathModeEnum.<br/>
		/// <br/>See also <seealso cref="PathModeEnum">PathModeEnum</seealso>
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
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="MASTERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MASTERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;path provides information or state values that influences the operation of other {{block(DataItem)}} of similar type.&#10;
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

		/// <summary>﻿physical or logical parts which are not physically connected to each other but are operating together.<br /><br /><br />
		/// Value for PathModeEnum.<br/>
		/// <br/>See also <seealso cref="PathModeEnum">PathModeEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;physical or logical parts which are not physically connected to each other but are operating together.&#10;
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
		private MIRRORValue _MIRROR;
		/// <inheritdoc cref="MIRRORValue" path="/summary" />
		public MIRRORValue MIRROR => _MIRROR ?? (_MIRROR = new MIRRORValue());

		/// <summary>﻿axes associated with the path are mirroring the motion of the <c>MASTER</c> path.<br /><br /><br />
		/// Value for PathModeEnum.<br/>
		/// <br/>See also <seealso cref="PathModeEnum">PathModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class MIRRORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MIRRORValue.Name" /></summary>
			public const string NAME = "MIRROR";
			/// <summary>Constant value for <see cref="MIRRORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="MIRRORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MIRRORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;axes associated with the path are mirroring the motion of the `MASTER` path.&#10;
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