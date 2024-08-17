#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <inheritdoc />
		public string Name => "CriticalityTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CriticalityTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.5";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class CRITICALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CRITICAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;services or functions provided by the associated element is required for the operation of this element.&#10;
";
		}
		private NONCRITICALValue _NONCRITICAL;
		/// <inheritdoc cref="NONCRITICALValue" path="/summary" />
		public NONCRITICALValue NONCRITICAL => _NONCRITICAL ?? (_NONCRITICAL = new NONCRITICALValue());

		/// <summary>﻿services or functions provided by the associated element is not required for the operation of this element.<br /><br /><br />
		/// Value for CriticalityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CriticalityTypeEnum">CriticalityTypeEnum</seealso>
		/// </summary>
		public sealed class NONCRITICALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NONCRITICAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;services or functions provided by the associated element is not required for the operation of this element.&#10;
";
		}
	}
}