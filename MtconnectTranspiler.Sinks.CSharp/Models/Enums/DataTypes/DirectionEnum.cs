#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643977882360_173549_1229">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum DirectionEnum
	{
		/// <summary>﻿clockwise rotation using the right-hand rule.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]

		CLOCKWISE,
		/// <summary>﻿counter-clockwise rotation using the right-hand rule.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]

		COUNTER_CLOCKWISE,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]

		POSITIVE,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]

		NEGATIVE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643977882360_173549_1229">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DirectionEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="DirectionEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1643977882360_173549_1229";
		/// <summary>Constant value for <see cref="DirectionEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643977882360_173549_1229";
		/// <summary>Constant value for <see cref="DirectionEnumMetaClass.Name" /></summary>
		public const string NAME = "DirectionEnum";
		/// <summary>Constant value for <see cref="DirectionEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="DirectionEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "1.4";
		/// <summary>Constant value for <see cref="DirectionEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(DirectionEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CLOCKWISE,
		COUNTER_CLOCKWISE,
		POSITIVE,
		NEGATIVE,
		};

		private CLOCKWISEValue _CLOCKWISE;
		/// <inheritdoc cref="CLOCKWISEValue" path="/summary" />
		public CLOCKWISEValue CLOCKWISE => _CLOCKWISE ?? (_CLOCKWISE = new CLOCKWISEValue());

		/// <summary>﻿clockwise rotation using the right-hand rule.<br /><br /><br />
		/// Value for DirectionEnum.<br/>
		/// <br/>See also <seealso cref="DirectionEnum">DirectionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]

		public sealed class CLOCKWISEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOCKWISEValue.Name" /></summary>
			public const string NAME = "CLOCKWISE";
			/// <summary>Constant value for <see cref="CLOCKWISEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="CLOCKWISEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.4";
			/// <summary>Constant value for <see cref="CLOCKWISEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;clockwise rotation using the right-hand rule.&#10;
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
		private COUNTER_CLOCKWISEValue _COUNTER_CLOCKWISE;
		/// <inheritdoc cref="COUNTER_CLOCKWISEValue" path="/summary" />
		public COUNTER_CLOCKWISEValue COUNTER_CLOCKWISE => _COUNTER_CLOCKWISE ?? (_COUNTER_CLOCKWISE = new COUNTER_CLOCKWISEValue());

		/// <summary>﻿counter-clockwise rotation using the right-hand rule.<br /><br /><br />
		/// Value for DirectionEnum.<br/>
		/// <br/>See also <seealso cref="DirectionEnum">DirectionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]

		public sealed class COUNTER_CLOCKWISEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COUNTER_CLOCKWISEValue.Name" /></summary>
			public const string NAME = "COUNTER_CLOCKWISE";
			/// <summary>Constant value for <see cref="COUNTER_CLOCKWISEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="COUNTER_CLOCKWISEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.4";
			/// <summary>Constant value for <see cref="COUNTER_CLOCKWISEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;counter-clockwise rotation using the right-hand rule.&#10;
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
		private POSITIVEValue _POSITIVE;
		/// <inheritdoc cref="POSITIVEValue" path="/summary" />
		public POSITIVEValue POSITIVE => _POSITIVE ?? (_POSITIVE = new POSITIVEValue());

		/// <summary>﻿
		/// Value for DirectionEnum.<br/>
		/// <br/>See also <seealso cref="DirectionEnum">DirectionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]

		public sealed class POSITIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POSITIVEValue.Name" /></summary>
			public const string NAME = "POSITIVE";
			/// <summary>Constant value for <see cref="POSITIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="POSITIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.4";
			/// <summary>Constant value for <see cref="POSITIVEValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private NEGATIVEValue _NEGATIVE;
		/// <inheritdoc cref="NEGATIVEValue" path="/summary" />
		public NEGATIVEValue NEGATIVE => _NEGATIVE ?? (_NEGATIVE = new NEGATIVEValue());

		/// <summary>﻿
		/// Value for DirectionEnum.<br/>
		/// <br/>See also <seealso cref="DirectionEnum">DirectionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]

		public sealed class NEGATIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NEGATIVEValue.Name" /></summary>
			public const string NAME = "NEGATIVE";
			/// <summary>Constant value for <see cref="NEGATIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="NEGATIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.4";
			/// <summary>Constant value for <see cref="NEGATIVEValue.Summary" /></summary>
			public const string SUMMARY = @"";

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