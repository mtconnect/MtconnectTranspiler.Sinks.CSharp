#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753036369_787594_4254">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum DirectionRotaryEnum
	{
		/// <summary>﻿clockwise rotation using the right-hand rule.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		CLOCKWISE,
		/// <summary>﻿counter-clockwise rotation using the right-hand rule.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		COUNTER_CLOCKWISE,
		/// <summary>﻿no direction.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		NONE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753036369_787594_4254">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DirectionRotaryEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="DirectionRotaryEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1587753036369_787594_4254";
		/// <summary>Constant value for <see cref="DirectionRotaryEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753036369_787594_4254";
		/// <summary>Constant value for <see cref="DirectionRotaryEnumMetaClass.Name" /></summary>
		public const string NAME = "DirectionRotaryEnum";
		/// <summary>Constant value for <see cref="DirectionRotaryEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.4";
		/// <summary>Constant value for <see cref="DirectionRotaryEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="DirectionRotaryEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(DirectionRotaryEnum);

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
		NONE,
		};

		private CLOCKWISEValue _CLOCKWISE;
		/// <inheritdoc cref="CLOCKWISEValue" path="/summary" />
		public CLOCKWISEValue CLOCKWISE => _CLOCKWISE ?? (_CLOCKWISE = new CLOCKWISEValue());

		/// <summary>﻿clockwise rotation using the right-hand rule.<br /><br /><br />
		/// Value for DirectionRotaryEnum.<br/>
		/// <br/>See also <seealso cref="DirectionRotaryEnum">DirectionRotaryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class CLOCKWISEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOCKWISEValue.Name" /></summary>
			public const string NAME = "CLOCKWISE";
			/// <summary>Constant value for <see cref="CLOCKWISEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="CLOCKWISEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
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
		/// Value for DirectionRotaryEnum.<br/>
		/// <br/>See also <seealso cref="DirectionRotaryEnum">DirectionRotaryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class COUNTER_CLOCKWISEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COUNTER_CLOCKWISEValue.Name" /></summary>
			public const string NAME = "COUNTER_CLOCKWISE";
			/// <summary>Constant value for <see cref="COUNTER_CLOCKWISEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="COUNTER_CLOCKWISEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
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
		private NONEValue _NONE;
		/// <inheritdoc cref="NONEValue" path="/summary" />
		public NONEValue NONE => _NONE ?? (_NONE = new NONEValue());

		/// <summary>﻿no direction.<br /><br /><br />
		/// Value for DirectionRotaryEnum.<br/>
		/// <br/>See also <seealso cref="DirectionRotaryEnum">DirectionRotaryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class NONEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NONEValue.Name" /></summary>
			public const string NAME = "NONE";
			/// <summary>Constant value for <see cref="NONEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="NONEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NONEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;no direction.&#10;
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