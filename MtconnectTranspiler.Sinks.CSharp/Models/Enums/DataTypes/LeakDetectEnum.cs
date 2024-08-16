using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1659073241126_204554_44">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum LeakDetectEnum
	{
		/// <summary>
		﻿/// leak is currently being detected.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DETECTED,
		/// <summary>
		﻿/// leak is currently not being detected.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		NOT_DETECTED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1659073241126_204554_44">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class LeakDetectEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "LeakDetectEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(LeakDetectEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		DETECTED,
		NOT_DETECTED,
		};

		private DETECTEDValue _DETECTED;
		/// <summary>
		﻿/// leak is currently being detected.<br/><br />

		/// </summary>
		public DETECTEDValue DETECTED => _DETECTED ?? (_DETECTED = new DETECTEDValue());

		/// <summary>
		﻿/// leak is currently being detected.<br/><br />

		/// </summary>
		public sealed class DETECTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DETECTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;leak is currently being detected.&#10;
";
		}
		private NOT_DETECTEDValue _NOT_DETECTED;
		/// <summary>
		﻿/// leak is currently not being detected.<br/><br />

		/// </summary>
		public NOT_DETECTEDValue NOT_DETECTED => _NOT_DETECTED ?? (_NOT_DETECTED = new NOT_DETECTEDValue());

		/// <summary>
		﻿/// leak is currently not being detected.<br/><br />

		/// </summary>
		public sealed class NOT_DETECTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NOT_DETECTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;leak is currently not being detected.&#10;
";
		}
	}
}