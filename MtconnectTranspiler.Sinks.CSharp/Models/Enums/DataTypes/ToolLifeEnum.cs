#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1634824001211_966890_187">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ToolLifeEnum
	{
		/// <summary>﻿tool life measured in minutes. <br /><br />All units for minimum, maximum, and nominal <b>MUST</b> be provided in minutes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MINUTES,
		/// <summary>﻿tool life measured in parts. <br /><br />All units for minimum, maximum, and nominal <b>MUST</b> be provided as the number of parts.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		PART_COUNT,
		/// <summary>﻿tool life measured in tool wear. <br /><br />Wear <b>MUST</b> be provided in millimeters as an offset to nominal. All units for minimum, maximum, and nominal <b>MUST</b> be given as millimeter offsets as<br />well. The standard will only consider dimensional wear at this time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		WEAR,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1634824001211_966890_187">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ToolLifeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ToolLifeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="MINUTESValue" path="/summary" />
		public MINUTESValue MINUTES => _MINUTES ?? (_MINUTES = new MINUTESValue());

		/// <summary>﻿tool life measured in minutes. <br /><br />All units for minimum, maximum, and nominal <b>MUST</b> be provided in minutes.<br /><br /><br />
		/// Value for ToolLifeEnum.<br/>
		/// <br/>See also <seealso cref="ToolLifeEnum">ToolLifeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;tool life measured in minutes. 

All units for minimum, maximum, and nominal **MUST** be provided in minutes.&#10;
";
		}
		private PART_COUNTValue _PART_COUNT;
		/// <inheritdoc cref="PART_COUNTValue" path="/summary" />
		public PART_COUNTValue PART_COUNT => _PART_COUNT ?? (_PART_COUNT = new PART_COUNTValue());

		/// <summary>﻿tool life measured in parts. <br /><br />All units for minimum, maximum, and nominal <b>MUST</b> be provided as the number of parts.<br /><br /><br />
		/// Value for ToolLifeEnum.<br/>
		/// <br/>See also <seealso cref="ToolLifeEnum">ToolLifeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;tool life measured in parts. 

All units for minimum, maximum, and nominal **MUST** be provided as the number of parts.&#10;
";
		}
		private WEARValue _WEAR;
		/// <inheritdoc cref="WEARValue" path="/summary" />
		public WEARValue WEAR => _WEAR ?? (_WEAR = new WEARValue());

		/// <summary>﻿tool life measured in tool wear. <br /><br />Wear <b>MUST</b> be provided in millimeters as an offset to nominal. All units for minimum, maximum, and nominal <b>MUST</b> be given as millimeter offsets as<br />well. The standard will only consider dimensional wear at this time.<br /><br /><br />
		/// Value for ToolLifeEnum.<br/>
		/// <br/>See also <seealso cref="ToolLifeEnum">ToolLifeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;tool life measured in tool wear. 

Wear **MUST** be provided in millimeters as an offset to nominal. All units for minimum, maximum, and nominal **MUST** be given as millimeter offsets as
well. The standard will only consider dimensional wear at this time.&#10;
";
		}
	}
}