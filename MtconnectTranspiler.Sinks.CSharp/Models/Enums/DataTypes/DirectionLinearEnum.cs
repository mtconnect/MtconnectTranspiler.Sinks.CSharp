#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753011315_305832_4223">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum DirectionLinearEnum
	{
		/// <summary>﻿linear position is increasing.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		POSITIVE,
		/// <summary>﻿linear position is decreasing.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		NEGATIVE,
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
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753011315_305832_4223">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DirectionLinearEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="DirectionLinearEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1587753011315_305832_4223";
		/// <summary>Constant value for <see cref="DirectionLinearEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753011315_305832_4223";
		/// <summary>Constant value for <see cref="DirectionLinearEnumMetaClass.Name" /></summary>
		public const string NAME = "DirectionLinearEnum";
		/// <summary>Constant value for <see cref="DirectionLinearEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.4";
		/// <summary>Constant value for <see cref="DirectionLinearEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="DirectionLinearEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(DirectionLinearEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		POSITIVE,
		NEGATIVE,
		NONE,
		};

		private POSITIVEValue _POSITIVE;
		/// <inheritdoc cref="POSITIVEValue" path="/summary" />
		public POSITIVEValue POSITIVE => _POSITIVE ?? (_POSITIVE = new POSITIVEValue());

		/// <summary>﻿linear position is increasing.<br /><br /><br />
		/// Value for DirectionLinearEnum.<br/>
		/// <br/>See also <seealso cref="DirectionLinearEnum">DirectionLinearEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class POSITIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POSITIVEValue.Name" /></summary>
			public const string NAME = "POSITIVE";
			/// <summary>Constant value for <see cref="POSITIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="POSITIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POSITIVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;linear position is increasing.&#10;
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
		private NEGATIVEValue _NEGATIVE;
		/// <inheritdoc cref="NEGATIVEValue" path="/summary" />
		public NEGATIVEValue NEGATIVE => _NEGATIVE ?? (_NEGATIVE = new NEGATIVEValue());

		/// <summary>﻿linear position is decreasing.<br /><br /><br />
		/// Value for DirectionLinearEnum.<br/>
		/// <br/>See also <seealso cref="DirectionLinearEnum">DirectionLinearEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class NEGATIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NEGATIVEValue.Name" /></summary>
			public const string NAME = "NEGATIVE";
			/// <summary>Constant value for <see cref="NEGATIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="NEGATIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NEGATIVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;linear position is decreasing.&#10;
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
		/// Value for DirectionLinearEnum.<br/>
		/// <br/>See also <seealso cref="DirectionLinearEnum">DirectionLinearEnum</seealso>
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