#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
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
		/// <inheritdoc />
		public string Name => "DirectionLinearEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(DirectionLinearEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class POSITIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POSITIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;linear position is increasing.&#10;
";
		}
		private NEGATIVEValue _NEGATIVE;
		/// <inheritdoc cref="NEGATIVEValue" path="/summary" />
		public NEGATIVEValue NEGATIVE => _NEGATIVE ?? (_NEGATIVE = new NEGATIVEValue());

		/// <summary>﻿linear position is decreasing.<br /><br /><br />
		/// Value for DirectionLinearEnum.<br/>
		/// <br/>See also <seealso cref="DirectionLinearEnum">DirectionLinearEnum</seealso>
		/// </summary>
		public sealed class NEGATIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NEGATIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;linear position is decreasing.&#10;
";
		}
		private NONEValue _NONE;
		/// <inheritdoc cref="NONEValue" path="/summary" />
		public NONEValue NONE => _NONE ?? (_NONE = new NONEValue());

		/// <summary>﻿no direction.<br /><br /><br />
		/// Value for DirectionLinearEnum.<br/>
		/// <br/>See also <seealso cref="DirectionLinearEnum">DirectionLinearEnum</seealso>
		/// </summary>
		public sealed class NONEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NONE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;no direction.&#10;
";
		}
	}
}