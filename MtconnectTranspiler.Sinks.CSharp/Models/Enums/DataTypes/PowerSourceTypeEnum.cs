using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1696871537426_335818_3541">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum PowerSourceTypeEnum
	{
		/// <summary>
		/// main or most important location of a piece of bar stock.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		PRIMARY,
		/// <summary>
		/// alternate or not primary.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		SECONDARY,
		/// <summary>
		/// uninterruptible or generator power supply.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		STANDBY,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1696871537426_335818_3541">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PowerSourceTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "PowerSourceTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(PowerSourceTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.3";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		PRIMARY,
		SECONDARY,
		STANDBY,
		};

		private PRIMARYValue _PRIMARY;
		/// <summary>
		/// main or most important location of a piece of bar stock.
		/// </summary>
		public PRIMARYValue PRIMARY => _PRIMARY ?? (_PRIMARY = new PRIMARYValue());

		/// <summary>
		/// main or most important location of a piece of bar stock.
		/// </summary>
		public sealed class PRIMARYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRIMARY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// main or most important location of a piece of bar stock.";
		}
		private SECONDARYValue _SECONDARY;
		/// <summary>
		/// alternate or not primary.
		/// </summary>
		public SECONDARYValue SECONDARY => _SECONDARY ?? (_SECONDARY = new SECONDARYValue());

		/// <summary>
		/// alternate or not primary.
		/// </summary>
		public sealed class SECONDARYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SECONDARY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// alternate or not primary.";
		}
		private STANDBYValue _STANDBY;
		/// <summary>
		/// uninterruptible or generator power supply.
		/// </summary>
		public STANDBYValue STANDBY => _STANDBY ?? (_STANDBY = new STANDBYValue());

		/// <summary>
		/// uninterruptible or generator power supply.
		/// </summary>
		public sealed class STANDBYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STANDBY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// uninterruptible or generator power supply.";
		}
	}
}