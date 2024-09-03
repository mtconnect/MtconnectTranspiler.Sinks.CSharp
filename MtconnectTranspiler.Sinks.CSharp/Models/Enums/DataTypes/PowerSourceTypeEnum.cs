#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1696871537426_335818_3541">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum PowerSourceTypeEnum
	{
		/// <summary>﻿main or principle.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>

		PRIMARY,
		/// <summary>﻿alternate or not primary.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>

		SECONDARY,
		/// <summary>﻿held near at hand and ready for use and is uninterruptible.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>

		STANDBY,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1696871537426_335818_3541">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PowerSourceTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="PowerSourceTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1696871537426_335818_3541";
		/// <summary>Constant value for <see cref="PowerSourceTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1696871537426_335818_3541";
		/// <summary>Constant value for <see cref="PowerSourceTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "PowerSourceTypeEnum";
		/// <summary>Constant value for <see cref="PowerSourceTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.3";
		/// <summary>Constant value for <see cref="PowerSourceTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="PowerSourceTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(PowerSourceTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		PRIMARY,
		SECONDARY,
		STANDBY,
		};

		private PRIMARYValue _PRIMARY;
		/// <inheritdoc cref="PRIMARYValue" path="/summary" />
		public PRIMARYValue PRIMARY => _PRIMARY ?? (_PRIMARY = new PRIMARYValue());

		/// <summary>﻿main or principle.<br /><br /><br />
		/// Value for PowerSourceTypeEnum.<br/>
		/// <br/>See also <seealso cref="PowerSourceTypeEnum">PowerSourceTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class PRIMARYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PRIMARYValue.Name" /></summary>
			public const string NAME = "PRIMARY";
			/// <summary>Constant value for <see cref="PRIMARYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="PRIMARYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PRIMARYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;main or principle.&#10;
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
		private SECONDARYValue _SECONDARY;
		/// <inheritdoc cref="SECONDARYValue" path="/summary" />
		public SECONDARYValue SECONDARY => _SECONDARY ?? (_SECONDARY = new SECONDARYValue());

		/// <summary>﻿alternate or not primary.<br /><br /><br />
		/// Value for PowerSourceTypeEnum.<br/>
		/// <br/>See also <seealso cref="PowerSourceTypeEnum">PowerSourceTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class SECONDARYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SECONDARYValue.Name" /></summary>
			public const string NAME = "SECONDARY";
			/// <summary>Constant value for <see cref="SECONDARYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="SECONDARYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SECONDARYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;alternate or not primary.&#10;
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
		private STANDBYValue _STANDBY;
		/// <inheritdoc cref="STANDBYValue" path="/summary" />
		public STANDBYValue STANDBY => _STANDBY ?? (_STANDBY = new STANDBYValue());

		/// <summary>﻿held near at hand and ready for use and is uninterruptible.<br /><br /><br />
		/// Value for PowerSourceTypeEnum.<br/>
		/// <br/>See also <seealso cref="PowerSourceTypeEnum">PowerSourceTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class STANDBYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STANDBYValue.Name" /></summary>
			public const string NAME = "STANDBY";
			/// <summary>Constant value for <see cref="STANDBYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="STANDBYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STANDBYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;held near at hand and ready for use and is uninterruptible.&#10;
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