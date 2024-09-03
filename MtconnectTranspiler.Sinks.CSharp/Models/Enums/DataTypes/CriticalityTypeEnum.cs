#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_9E68B125_F907_4cd0_9198_CC77ADBB8C75">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CriticalityTypeEnum
	{
		/// <summary>﻿services or functions provided by the associated element is required for the operation of this element.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		CRITICAL,
		/// <summary>﻿services or functions provided by the associated element is not required for the operation of this element.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		NONCRITICAL,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_9E68B125_F907_4cd0_9198_CC77ADBB8C75">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CriticalityTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="CriticalityTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_9E68B125_F907_4cd0_9198_CC77ADBB8C75";
		/// <summary>Constant value for <see cref="CriticalityTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_9E68B125_F907_4cd0_9198_CC77ADBB8C75";
		/// <summary>Constant value for <see cref="CriticalityTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "CriticalityTypeEnum";
		/// <summary>Constant value for <see cref="CriticalityTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.5";
		/// <summary>Constant value for <see cref="CriticalityTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="CriticalityTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(CriticalityTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CRITICAL,
		NONCRITICAL,
		};

		private CRITICALValue _CRITICAL;
		/// <inheritdoc cref="CRITICALValue" path="/summary" />
		public CRITICALValue CRITICAL => _CRITICAL ?? (_CRITICAL = new CRITICALValue());

		/// <summary>﻿services or functions provided by the associated element is required for the operation of this element.<br /><br /><br />
		/// Value for CriticalityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CriticalityTypeEnum">CriticalityTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class CRITICALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CRITICALValue.Name" /></summary>
			public const string NAME = "CRITICAL";
			/// <summary>Constant value for <see cref="CRITICALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="CRITICALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CRITICALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;services or functions provided by the associated element is required for the operation of this element.&#10;
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
		private NONCRITICALValue _NONCRITICAL;
		/// <inheritdoc cref="NONCRITICALValue" path="/summary" />
		public NONCRITICALValue NONCRITICAL => _NONCRITICAL ?? (_NONCRITICAL = new NONCRITICALValue());

		/// <summary>﻿services or functions provided by the associated element is not required for the operation of this element.<br /><br /><br />
		/// Value for CriticalityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CriticalityTypeEnum">CriticalityTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class NONCRITICALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NONCRITICALValue.Name" /></summary>
			public const string NAME = "NONCRITICAL";
			/// <summary>Constant value for <see cref="NONCRITICALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="NONCRITICALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NONCRITICALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;services or functions provided by the associated element is not required for the operation of this element.&#10;
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