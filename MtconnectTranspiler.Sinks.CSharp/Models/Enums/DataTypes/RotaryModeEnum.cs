#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417668_463137_2883">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum RotaryModeEnum
	{
		/// <summary>﻿axis is functioning as a spindle.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		SPINDLE,
		/// <summary>﻿axis is configured to index.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		INDEX,
		/// <summary>﻿position of the axis is being interpolated.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		CONTOUR,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417668_463137_2883">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RotaryModeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="RotaryModeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378417668_463137_2883";
		/// <summary>Constant value for <see cref="RotaryModeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417668_463137_2883";
		/// <summary>Constant value for <see cref="RotaryModeEnumMetaClass.Name" /></summary>
		public const string NAME = "RotaryModeEnum";
		/// <summary>Constant value for <see cref="RotaryModeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="RotaryModeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="RotaryModeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(RotaryModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		SPINDLE,
		INDEX,
		CONTOUR,
		};

		private SPINDLEValue _SPINDLE;
		/// <inheritdoc cref="SPINDLEValue" path="/summary" />
		public SPINDLEValue SPINDLE => _SPINDLE ?? (_SPINDLE = new SPINDLEValue());

		/// <summary>﻿axis is functioning as a spindle.<br /><br /><br />
		/// Value for RotaryModeEnum.<br/>
		/// <br/>See also <seealso cref="RotaryModeEnum">RotaryModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class SPINDLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SPINDLEValue.Name" /></summary>
			public const string NAME = "SPINDLE";
			/// <summary>Constant value for <see cref="SPINDLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="SPINDLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SPINDLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;axis is functioning as a spindle.&#10;
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
		private INDEXValue _INDEX;
		/// <inheritdoc cref="INDEXValue" path="/summary" />
		public INDEXValue INDEX => _INDEX ?? (_INDEX = new INDEXValue());

		/// <summary>﻿axis is configured to index.<br /><br /><br />
		/// Value for RotaryModeEnum.<br/>
		/// <br/>See also <seealso cref="RotaryModeEnum">RotaryModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class INDEXValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INDEXValue.Name" /></summary>
			public const string NAME = "INDEX";
			/// <summary>Constant value for <see cref="INDEXValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="INDEXValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INDEXValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;axis is configured to index.&#10;
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
		private CONTOURValue _CONTOUR;
		/// <inheritdoc cref="CONTOURValue" path="/summary" />
		public CONTOURValue CONTOUR => _CONTOUR ?? (_CONTOUR = new CONTOURValue());

		/// <summary>﻿position of the axis is being interpolated.<br /><br /><br />
		/// Value for RotaryModeEnum.<br/>
		/// <br/>See also <seealso cref="RotaryModeEnum">RotaryModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONTOURValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONTOURValue.Name" /></summary>
			public const string NAME = "CONTOUR";
			/// <summary>Constant value for <see cref="CONTOURValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="CONTOURValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONTOURValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;position of the axis is being interpolated.&#10;
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