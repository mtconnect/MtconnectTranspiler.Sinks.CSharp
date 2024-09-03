#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417659_742691_2873">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ChuckStateEnum
	{
		/// <summary>﻿<see cref="Chuck">Chuck</see> is open to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		OPEN,
		/// <summary>﻿<see cref="Chuck">Chuck</see> is closed to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		CLOSED,
		/// <summary>﻿<see cref="Chuck">Chuck</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		UNLATCHED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417659_742691_2873">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ChuckStateEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ChuckStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378417659_742691_2873";
		/// <summary>Constant value for <see cref="ChuckStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417659_742691_2873";
		/// <summary>Constant value for <see cref="ChuckStateEnumMetaClass.Name" /></summary>
		public const string NAME = "ChuckStateEnum";
		/// <summary>Constant value for <see cref="ChuckStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="ChuckStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ChuckStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ChuckStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		OPEN,
		CLOSED,
		UNLATCHED,
		};

		private OPENValue _OPEN;
		/// <inheritdoc cref="OPENValue" path="/summary" />
		public OPENValue OPEN => _OPEN ?? (_OPEN = new OPENValue());

		/// <summary>﻿<see cref="Chuck">Chuck</see> is open to the point of a positive confirmation.<br /><br /><br />
		/// Value for ChuckStateEnum.<br/>
		/// <br/>See also <seealso cref="ChuckStateEnum">ChuckStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPENValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPENValue.Name" /></summary>
			public const string NAME = "OPEN";
			/// <summary>Constant value for <see cref="OPENValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="OPENValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPENValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Chuck)}} is open to the point of a positive confirmation.&#10;
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
		private CLOSEDValue _CLOSED;
		/// <inheritdoc cref="CLOSEDValue" path="/summary" />
		public CLOSEDValue CLOSED => _CLOSED ?? (_CLOSED = new CLOSEDValue());

		/// <summary>﻿<see cref="Chuck">Chuck</see> is closed to the point of a positive confirmation.<br /><br /><br />
		/// Value for ChuckStateEnum.<br/>
		/// <br/>See also <seealso cref="ChuckStateEnum">ChuckStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class CLOSEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOSEDValue.Name" /></summary>
			public const string NAME = "CLOSED";
			/// <summary>Constant value for <see cref="CLOSEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="CLOSEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CLOSEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Chuck)}} is closed to the point of a positive confirmation.&#10;
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
		private UNLATCHEDValue _UNLATCHED;
		/// <inheritdoc cref="UNLATCHEDValue" path="/summary" />
		public UNLATCHEDValue UNLATCHED => _UNLATCHED ?? (_UNLATCHED = new UNLATCHEDValue());

		/// <summary>﻿<see cref="Chuck">Chuck</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// Value for ChuckStateEnum.<br/>
		/// <br/>See also <seealso cref="ChuckStateEnum">ChuckStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNLATCHEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNLATCHEDValue.Name" /></summary>
			public const string NAME = "UNLATCHED";
			/// <summary>Constant value for <see cref="UNLATCHEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="UNLATCHEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNLATCHEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Chuck)}} is not closed to the point of a positive confirmation and not open to the point of a positive confirmation. 

It is in an intermediate position.&#10;
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