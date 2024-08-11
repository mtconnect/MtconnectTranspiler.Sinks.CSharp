using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1634824001211_966890_187">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ToolLifeEnum
	{
		/// <summary>
		/// tool life measured in minutes.   All units for minimum, maximum, and nominal <b>MUST</b> be provided in minutes.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MINUTES,
		/// <summary>
		/// tool life measured in parts.   All units for minimum, maximum, and nominal <b>MUST</b> be provided as the number of parts.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		PART_COUNT,
		/// <summary>
		/// tool life measured in tool wear.   Wear <b>MUST</b> be provided in millimeters as an offset to nominal. All units for minimum, maximum, and nominal <b>MUST</b> be given as millimeter offsets as well. The standard will only consider dimensional wear at this time.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		WEAR,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1634824001211_966890_187">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ToolLifeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ToolLifeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ToolLifeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		MINUTES,
		PART_COUNT,
		WEAR,
		};

		private MINUTESValue _MINUTES;
		/// <summary>
		/// tool life measured in minutes.   All units for minimum, maximum, and nominal <b>MUST</b> be provided in minutes.
		/// </summary>
		public MINUTESValue MINUTES => _MINUTES ?? (_MINUTES = new MINUTESValue());

		/// <summary>
		/// tool life measured in minutes.   All units for minimum, maximum, and nominal <b>MUST</b> be provided in minutes.
		/// </summary>
		public sealed class MINUTESValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MINUTES";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// tool life measured in minutes.   All units for minimum, maximum, and nominal <b>MUST</b> be provided in minutes.";
		}
		private PART_COUNTValue _PART_COUNT;
		/// <summary>
		/// tool life measured in parts.   All units for minimum, maximum, and nominal <b>MUST</b> be provided as the number of parts.
		/// </summary>
		public PART_COUNTValue PART_COUNT => _PART_COUNT ?? (_PART_COUNT = new PART_COUNTValue());

		/// <summary>
		/// tool life measured in parts.   All units for minimum, maximum, and nominal <b>MUST</b> be provided as the number of parts.
		/// </summary>
		public sealed class PART_COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// tool life measured in parts.   All units for minimum, maximum, and nominal <b>MUST</b> be provided as the number of parts.";
		}
		private WEARValue _WEAR;
		/// <summary>
		/// tool life measured in tool wear.   Wear <b>MUST</b> be provided in millimeters as an offset to nominal. All units for minimum, maximum, and nominal <b>MUST</b> be given as millimeter offsets as well. The standard will only consider dimensional wear at this time.
		/// </summary>
		public WEARValue WEAR => _WEAR ?? (_WEAR = new WEARValue());

		/// <summary>
		/// tool life measured in tool wear.   Wear <b>MUST</b> be provided in millimeters as an offset to nominal. All units for minimum, maximum, and nominal <b>MUST</b> be given as millimeter offsets as well. The standard will only consider dimensional wear at this time.
		/// </summary>
		public sealed class WEARValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WEAR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// tool life measured in tool wear.   Wear <b>MUST</b> be provided in millimeters as an offset to nominal. All units for minimum, maximum, and nominal <b>MUST</b> be given as millimeter offsets as well. The standard will only consider dimensional wear at this time.";
		}
	}
}