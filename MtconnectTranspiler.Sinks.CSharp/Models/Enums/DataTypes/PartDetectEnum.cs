#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581206093299_877100_76">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum PartDetectEnum
	{
		/// <summary>﻿part or work piece is detected or is present.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PRESENT,
		/// <summary>﻿part or work piece is not detected or is not present.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		NOT_PRESENT,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581206093299_877100_76">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PartDetectEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "PartDetectEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(PartDetectEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.5";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		PRESENT,
		NOT_PRESENT,
		};

		private PRESENTValue _PRESENT;
		/// <inheritdoc cref="PRESENTValue" path="/summary" />
		public PRESENTValue PRESENT => _PRESENT ?? (_PRESENT = new PRESENTValue());

		/// <summary>﻿part or work piece is detected or is present.<br /><br /><br />
		/// Value for PartDetectEnum.<br/>
		/// <br/>See also <seealso cref="PartDetectEnum">PartDetectEnum</seealso>
		/// </summary>
		public sealed class PRESENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRESENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;part or work piece is detected or is present.&#10;
";
		}
		private NOT_PRESENTValue _NOT_PRESENT;
		/// <inheritdoc cref="NOT_PRESENTValue" path="/summary" />
		public NOT_PRESENTValue NOT_PRESENT => _NOT_PRESENT ?? (_NOT_PRESENT = new NOT_PRESENTValue());

		/// <summary>﻿part or work piece is not detected or is not present.<br /><br /><br />
		/// Value for PartDetectEnum.<br/>
		/// <br/>See also <seealso cref="PartDetectEnum">PartDetectEnum</seealso>
		/// </summary>
		public sealed class NOT_PRESENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NOT_PRESENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;part or work piece is not detected or is not present.&#10;
";
		}
	}
}