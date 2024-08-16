using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417659_742691_2873">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ChuckStateEnum
	{
		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is open to the point of a positive confirmation.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		OPEN,
		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is closed to the point of a positive confirmation.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		CLOSED,
		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		UNLATCHED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417659_742691_2873">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ChuckStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ChuckStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ChuckStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.3";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		OPEN,
		CLOSED,
		UNLATCHED,
		};

		private OPENValue _OPEN;
		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is open to the point of a positive confirmation.<br/><br />

		/// </summary>
		public OPENValue OPEN => _OPEN ?? (_OPEN = new OPENValue());

		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is open to the point of a positive confirmation.<br/><br />

		/// </summary>
		public sealed class OPENValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPEN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Chuck)}} is open to the point of a positive confirmation.&#10;
";
		}
		private CLOSEDValue _CLOSED;
		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is closed to the point of a positive confirmation.<br/><br />

		/// </summary>
		public CLOSEDValue CLOSED => _CLOSED ?? (_CLOSED = new CLOSEDValue());

		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is closed to the point of a positive confirmation.<br/><br />

		/// </summary>
		public sealed class CLOSEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOSED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Chuck)}} is closed to the point of a positive confirmation.&#10;
";
		}
		private UNLATCHEDValue _UNLATCHED;
		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br/><br />

		/// </summary>
		public UNLATCHEDValue UNLATCHED => _UNLATCHED ?? (_UNLATCHED = new UNLATCHEDValue());

		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br/><br />

		/// </summary>
		public sealed class UNLATCHEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNLATCHED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Chuck)}} is not closed to the point of a positive confirmation and not open to the point of a positive confirmation. 

It is in an intermediate position.&#10;
";
		}
	}
}