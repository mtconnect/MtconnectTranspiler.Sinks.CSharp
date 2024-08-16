using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643977882360_173549_1229">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum DirectionEnum
	{
		/// <summary>
		﻿/// clockwise rotation using the right-hand rule.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		CLOCKWISE,
		/// <summary>
		﻿/// counter-clockwise rotation using the right-hand rule.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		COUNTER_CLOCKWISE,
		/// <summary>
		﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		POSITIVE,
		/// <summary>
		﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		NEGATIVE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643977882360_173549_1229">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DirectionEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "DirectionEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(DirectionEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "1.4";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CLOCKWISE,
		COUNTER_CLOCKWISE,
		POSITIVE,
		NEGATIVE,
		};

		private CLOCKWISEValue _CLOCKWISE;
		/// <summary>
		﻿/// clockwise rotation using the right-hand rule.<br/><br />

		/// </summary>
		public CLOCKWISEValue CLOCKWISE => _CLOCKWISE ?? (_CLOCKWISE = new CLOCKWISEValue());

		/// <summary>
		﻿/// clockwise rotation using the right-hand rule.<br/><br />

		/// </summary>
		public sealed class CLOCKWISEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOCKWISE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.4";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;clockwise rotation using the right-hand rule.&#10;
";
		}
		private COUNTER_CLOCKWISEValue _COUNTER_CLOCKWISE;
		/// <summary>
		﻿/// counter-clockwise rotation using the right-hand rule.<br/><br />

		/// </summary>
		public COUNTER_CLOCKWISEValue COUNTER_CLOCKWISE => _COUNTER_CLOCKWISE ?? (_COUNTER_CLOCKWISE = new COUNTER_CLOCKWISEValue());

		/// <summary>
		﻿/// counter-clockwise rotation using the right-hand rule.<br/><br />

		/// </summary>
		public sealed class COUNTER_CLOCKWISEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COUNTER_CLOCKWISE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.4";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;counter-clockwise rotation using the right-hand rule.&#10;
";
		}
		private POSITIVEValue _POSITIVE;
		public POSITIVEValue POSITIVE => _POSITIVE ?? (_POSITIVE = new POSITIVEValue());

		public sealed class POSITIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POSITIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.4";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private NEGATIVEValue _NEGATIVE;
		public NEGATIVEValue NEGATIVE => _NEGATIVE ?? (_NEGATIVE = new NEGATIVEValue());

		public sealed class NEGATIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NEGATIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.4";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
	}
}