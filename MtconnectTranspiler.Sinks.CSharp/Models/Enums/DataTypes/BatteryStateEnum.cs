#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1660318869483_263921_172">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum BatteryStateEnum
	{
		/// <summary>﻿<see cref="Component">Component</see> is at it's maximum rated charge level.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		CHARGED,
		/// <summary>﻿<see cref="Component">Component</see>'s charge is increasing.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		CHARGING,
		/// <summary>﻿<see cref="Component">Component</see>'s charge is decreasing.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DISCHARGING,
		/// <summary>﻿<see cref="Component">Component</see> is at it's minimum charge level.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DISCHARGED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1660318869483_263921_172">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class BatteryStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "BatteryStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="CHARGEDValue" path="/summary" />
		public CHARGEDValue CHARGED => _CHARGED ?? (_CHARGED = new CHARGEDValue());

		/// <summary>﻿<see cref="Component">Component</see> is at it's maximum rated charge level.<br /><br /><br />
		/// Value for BatteryStateEnum.<br/>
		/// <br/>See also <seealso cref="BatteryStateEnum">BatteryStateEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} is at it's maximum rated charge level.&#10;
";
		}
		private CHARGINGValue _CHARGING;
		/// <inheritdoc cref="CHARGINGValue" path="/summary" />
		public CHARGINGValue CHARGING => _CHARGING ?? (_CHARGING = new CHARGINGValue());

		/// <summary>﻿<see cref="Component">Component</see>'s charge is increasing.<br /><br /><br />
		/// Value for BatteryStateEnum.<br/>
		/// <br/>See also <seealso cref="BatteryStateEnum">BatteryStateEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}}'s charge is increasing.&#10;
";
		}
		private DISCHARGINGValue _DISCHARGING;
		/// <inheritdoc cref="DISCHARGINGValue" path="/summary" />
		public DISCHARGINGValue DISCHARGING => _DISCHARGING ?? (_DISCHARGING = new DISCHARGINGValue());

		/// <summary>﻿<see cref="Component">Component</see>'s charge is decreasing.<br /><br /><br />
		/// Value for BatteryStateEnum.<br/>
		/// <br/>See also <seealso cref="BatteryStateEnum">BatteryStateEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}}'s charge is decreasing.&#10;
";
		}
		private DISCHARGEDValue _DISCHARGED;
		/// <inheritdoc cref="DISCHARGEDValue" path="/summary" />
		public DISCHARGEDValue DISCHARGED => _DISCHARGED ?? (_DISCHARGED = new DISCHARGEDValue());

		/// <summary>﻿<see cref="Component">Component</see> is at it's minimum charge level.<br /><br /><br />
		/// Value for BatteryStateEnum.<br/>
		/// <br/>See also <seealso cref="BatteryStateEnum">BatteryStateEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} is at it's minimum charge level.&#10;
";
		}
	}
}