#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640604472459_23562_405">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum MaintenanceListIntervalEnum
	{
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		ABSOLUTE,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		INCREMENTAL,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640604472459_23562_405">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MaintenanceListIntervalEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="MaintenanceListIntervalEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1640604472459_23562_405";
		/// <summary>Constant value for <see cref="MaintenanceListIntervalEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640604472459_23562_405";
		/// <summary>Constant value for <see cref="MaintenanceListIntervalEnumMetaClass.Name" /></summary>
		public const string NAME = "MaintenanceListIntervalEnum";
		/// <summary>Constant value for <see cref="MaintenanceListIntervalEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.0";
		/// <summary>Constant value for <see cref="MaintenanceListIntervalEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="MaintenanceListIntervalEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(MaintenanceListIntervalEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ABSOLUTE,
		INCREMENTAL,
		};

		private ABSOLUTEValue _ABSOLUTE;
		/// <inheritdoc cref="ABSOLUTEValue" path="/summary" />
		public ABSOLUTEValue ABSOLUTE => _ABSOLUTE ?? (_ABSOLUTE = new ABSOLUTEValue());

		/// <summary>﻿
		/// Value for MaintenanceListIntervalEnum.<br/>
		/// <br/>See also <seealso cref="MaintenanceListIntervalEnum">MaintenanceListIntervalEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ABSOLUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ABSOLUTEValue.Name" /></summary>
			public const string NAME = "ABSOLUTE";
			/// <summary>Constant value for <see cref="ABSOLUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="ABSOLUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ABSOLUTEValue.Summary" /></summary>
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
		private INCREMENTALValue _INCREMENTAL;
		/// <inheritdoc cref="INCREMENTALValue" path="/summary" />
		public INCREMENTALValue INCREMENTAL => _INCREMENTAL ?? (_INCREMENTAL = new INCREMENTALValue());

		/// <summary>﻿
		/// Value for MaintenanceListIntervalEnum.<br/>
		/// <br/>See also <seealso cref="MaintenanceListIntervalEnum">MaintenanceListIntervalEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class INCREMENTALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INCREMENTALValue.Name" /></summary>
			public const string NAME = "INCREMENTAL";
			/// <summary>Constant value for <see cref="INCREMENTALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="INCREMENTALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INCREMENTALValue.Summary" /></summary>
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