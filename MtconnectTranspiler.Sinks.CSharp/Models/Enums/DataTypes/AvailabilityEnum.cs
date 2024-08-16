using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417656_729564_2870">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum AvailabilityEnum
	{
		/// <summary>
		﻿/// data source is active and capable of providing data.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		AVAILABLE,
		/// <summary>
		﻿/// data source is either inactive or not capable of providing data.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		UNAVAILABLE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417656_729564_2870">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AvailabilityEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "AvailabilityEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(AvailabilityEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		AVAILABLE,
		UNAVAILABLE,
		};

		private AVAILABLEValue _AVAILABLE;
		/// <summary>
		﻿/// data source is active and capable of providing data.<br/><br />

		/// </summary>
		public AVAILABLEValue AVAILABLE => _AVAILABLE ?? (_AVAILABLE = new AVAILABLEValue());

		/// <summary>
		﻿/// data source is active and capable of providing data.<br/><br />

		/// </summary>
		public sealed class AVAILABLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AVAILABLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;data source is active and capable of providing data.&#10;
";
		}
		private UNAVAILABLEValue _UNAVAILABLE;
		/// <summary>
		﻿/// data source is either inactive or not capable of providing data.<br/><br />

		/// </summary>
		public UNAVAILABLEValue UNAVAILABLE => _UNAVAILABLE ?? (_UNAVAILABLE = new UNAVAILABLEValue());

		/// <summary>
		﻿/// data source is either inactive or not capable of providing data.<br/><br />

		/// </summary>
		public sealed class UNAVAILABLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNAVAILABLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;data source is either inactive or not capable of providing data.&#10;
";
		}
	}
}