using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1660318869483_263921_172">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum BatteryStateEnum
	{
		/// <summary>
		/// <see cref="Component">Component</see> is at it's maximum rated charge level.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		CHARGED,
		/// <summary>
		/// <see cref="Component">Component</see>'s charge is increasing.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		CHARGING,
		/// <summary>
		/// <see cref="Component">Component</see>'s charge is decreasing.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DISCHARGING,
		/// <summary>
		/// <see cref="Component">Component</see> is at it's minimum charge level.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DISCHARGED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1660318869483_263921_172">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class BatteryStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "BatteryStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(BatteryStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CHARGED,
		CHARGING,
		DISCHARGING,
		DISCHARGED,
		};

		private CHARGEDValue _CHARGED;
		/// <summary>
		/// <see cref="Component">Component</see> is at it's maximum rated charge level.
		/// </summary>
		public CHARGEDValue CHARGED => _CHARGED ?? (_CHARGED = new CHARGEDValue());

		/// <summary>
		/// <see cref="Component">Component</see> is at it's maximum rated charge level.
		/// </summary>
		public sealed class CHARGEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHARGED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Component"">Component</see> is at it's maximum rated charge level.";
		}
		private CHARGINGValue _CHARGING;
		/// <summary>
		/// <see cref="Component">Component</see>'s charge is increasing.
		/// </summary>
		public CHARGINGValue CHARGING => _CHARGING ?? (_CHARGING = new CHARGINGValue());

		/// <summary>
		/// <see cref="Component">Component</see>'s charge is increasing.
		/// </summary>
		public sealed class CHARGINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHARGING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Component"">Component</see>'s charge is increasing.";
		}
		private DISCHARGINGValue _DISCHARGING;
		/// <summary>
		/// <see cref="Component">Component</see>'s charge is decreasing.
		/// </summary>
		public DISCHARGINGValue DISCHARGING => _DISCHARGING ?? (_DISCHARGING = new DISCHARGINGValue());

		/// <summary>
		/// <see cref="Component">Component</see>'s charge is decreasing.
		/// </summary>
		public sealed class DISCHARGINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DISCHARGING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Component"">Component</see>'s charge is decreasing.";
		}
		private DISCHARGEDValue _DISCHARGED;
		/// <summary>
		/// <see cref="Component">Component</see> is at it's minimum charge level.
		/// </summary>
		public DISCHARGEDValue DISCHARGED => _DISCHARGED ?? (_DISCHARGED = new DISCHARGEDValue());

		/// <summary>
		/// <see cref="Component">Component</see> is at it's minimum charge level.
		/// </summary>
		public sealed class DISCHARGEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DISCHARGED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Component"">Component</see> is at it's minimum charge level.";
		}
	}
}