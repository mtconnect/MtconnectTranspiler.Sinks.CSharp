#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="BatteryStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1660318869483_263921_172";
		/// <summary>Constant value for <see cref="BatteryStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1660318869483_263921_172";
		/// <summary>Constant value for <see cref="BatteryStateEnumMetaClass.Name" /></summary>
		public const string NAME = "BatteryStateEnum";
		/// <summary>Constant value for <see cref="BatteryStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.1";
		/// <summary>Constant value for <see cref="BatteryStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="BatteryStateEnumMetaClass.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(BatteryStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHARGEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHARGEDValue.Name" /></summary>
			public const string NAME = "CHARGED";
			/// <summary>Constant value for <see cref="CHARGEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="CHARGEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHARGEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} is at it's maximum rated charge level.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CHARGINGValue _CHARGING;
		/// <inheritdoc cref="CHARGINGValue" path="/summary" />
		public CHARGINGValue CHARGING => _CHARGING ?? (_CHARGING = new CHARGINGValue());

		/// <summary>﻿<see cref="Component">Component</see>'s charge is increasing.<br /><br /><br />
		/// Value for BatteryStateEnum.<br/>
		/// <br/>See also <seealso cref="BatteryStateEnum">BatteryStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHARGINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHARGINGValue.Name" /></summary>
			public const string NAME = "CHARGING";
			/// <summary>Constant value for <see cref="CHARGINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="CHARGINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHARGINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}}'s charge is increasing.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DISCHARGINGValue _DISCHARGING;
		/// <inheritdoc cref="DISCHARGINGValue" path="/summary" />
		public DISCHARGINGValue DISCHARGING => _DISCHARGING ?? (_DISCHARGING = new DISCHARGINGValue());

		/// <summary>﻿<see cref="Component">Component</see>'s charge is decreasing.<br /><br /><br />
		/// Value for BatteryStateEnum.<br/>
		/// <br/>See also <seealso cref="BatteryStateEnum">BatteryStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class DISCHARGINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DISCHARGINGValue.Name" /></summary>
			public const string NAME = "DISCHARGING";
			/// <summary>Constant value for <see cref="DISCHARGINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="DISCHARGINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DISCHARGINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}}'s charge is decreasing.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DISCHARGEDValue _DISCHARGED;
		/// <inheritdoc cref="DISCHARGEDValue" path="/summary" />
		public DISCHARGEDValue DISCHARGED => _DISCHARGED ?? (_DISCHARGED = new DISCHARGEDValue());

		/// <summary>﻿<see cref="Component">Component</see> is at it's minimum charge level.<br /><br /><br />
		/// Value for BatteryStateEnum.<br/>
		/// <br/>See also <seealso cref="BatteryStateEnum">BatteryStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class DISCHARGEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DISCHARGEDValue.Name" /></summary>
			public const string NAME = "DISCHARGED";
			/// <summary>Constant value for <see cref="DISCHARGEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="DISCHARGEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DISCHARGEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} is at it's minimum charge level.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
	}
}