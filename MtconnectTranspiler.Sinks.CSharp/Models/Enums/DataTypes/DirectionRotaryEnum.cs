#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
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
		/// <inheritdoc />
		public string Name => "DirectionRotaryEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(DirectionRotaryEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class CLOCKWISEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOCKWISE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;clockwise rotation using the right-hand rule.&#10;
";
		}
		private COUNTER_CLOCKWISEValue _COUNTER_CLOCKWISE;
		/// <inheritdoc cref="COUNTER_CLOCKWISEValue" path="/summary" />
		public COUNTER_CLOCKWISEValue COUNTER_CLOCKWISE => _COUNTER_CLOCKWISE ?? (_COUNTER_CLOCKWISE = new COUNTER_CLOCKWISEValue());

		/// <summary>﻿counter-clockwise rotation using the right-hand rule.<br /><br /><br />
		/// Value for DirectionRotaryEnum.<br/>
		/// <br/>See also <seealso cref="DirectionRotaryEnum">DirectionRotaryEnum</seealso>
		/// </summary>
		public sealed class COUNTER_CLOCKWISEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COUNTER_CLOCKWISE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;counter-clockwise rotation using the right-hand rule.&#10;
";
		}
		private NONEValue _NONE;
		/// <inheritdoc cref="NONEValue" path="/summary" />
		public NONEValue NONE => _NONE ?? (_NONE = new NONEValue());

		/// <summary>﻿no direction.<br /><br /><br />
		/// Value for DirectionRotaryEnum.<br/>
		/// <br/>See also <seealso cref="DirectionRotaryEnum">DirectionRotaryEnum</seealso>
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