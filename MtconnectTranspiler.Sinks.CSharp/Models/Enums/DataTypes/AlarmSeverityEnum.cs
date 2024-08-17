#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968830721_843713_164">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum AlarmSeverityEnum
	{
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		CRITICAL,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		ERROR,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		WARNING,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		INFORMATION,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968830721_843713_164">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AlarmSeverityEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "AlarmSeverityEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(AlarmSeverityEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "1.1";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CRITICAL,
		ERROR,
		WARNING,
		INFORMATION,
		};

		private CRITICALValue _CRITICAL;
		/// <inheritdoc cref="CRITICALValue" path="/summary" />
		public CRITICALValue CRITICAL => _CRITICAL ?? (_CRITICAL = new CRITICALValue());

		/// <summary>﻿
		/// Value for AlarmSeverityEnum.<br/>
		/// <br/>See also <seealso cref="AlarmSeverityEnum">AlarmSeverityEnum</seealso>
		/// </summary>
		public sealed class CRITICALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CRITICAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private ERRORValue _ERROR;
		/// <inheritdoc cref="ERRORValue" path="/summary" />
		public ERRORValue ERROR => _ERROR ?? (_ERROR = new ERRORValue());

		/// <summary>﻿
		/// Value for AlarmSeverityEnum.<br/>
		/// <br/>See also <seealso cref="AlarmSeverityEnum">AlarmSeverityEnum</seealso>
		/// </summary>
		public sealed class ERRORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ERROR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private WARNINGValue _WARNING;
		/// <inheritdoc cref="WARNINGValue" path="/summary" />
		public WARNINGValue WARNING => _WARNING ?? (_WARNING = new WARNINGValue());

		/// <summary>﻿
		/// Value for AlarmSeverityEnum.<br/>
		/// <br/>See also <seealso cref="AlarmSeverityEnum">AlarmSeverityEnum</seealso>
		/// </summary>
		public sealed class WARNINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WARNING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private INFORMATIONValue _INFORMATION;
		/// <inheritdoc cref="INFORMATIONValue" path="/summary" />
		public INFORMATIONValue INFORMATION => _INFORMATION ?? (_INFORMATION = new INFORMATIONValue());

		/// <summary>﻿
		/// Value for AlarmSeverityEnum.<br/>
		/// <br/>See also <seealso cref="AlarmSeverityEnum">AlarmSeverityEnum</seealso>
		/// </summary>
		public sealed class INFORMATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INFORMATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
	}
}