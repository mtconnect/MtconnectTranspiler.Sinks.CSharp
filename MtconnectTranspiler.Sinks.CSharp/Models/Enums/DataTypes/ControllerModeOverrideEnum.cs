#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417661_25421_2875">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ControllerModeOverrideEnum
	{
		/// <summary>﻿<see cref="ControllerModeOverride">ControllerModeOverride</see> is in the <c>ON</c> state and the mode override is active.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ON,
		/// <summary>﻿<see cref="ControllerModeOverride">ControllerModeOverride</see> is in the <c>OFF</c> state and the mode override is inactive.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OFF,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417661_25421_2875">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ControllerModeOverrideEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ControllerModeOverrideEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(ControllerModeOverrideEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ON,
		OFF,
		};

		private ONValue _ON;
		/// <inheritdoc cref="ONValue" path="/summary" />
		public ONValue ON => _ON ?? (_ON = new ONValue());

		/// <summary>﻿<see cref="ControllerModeOverride">ControllerModeOverride</see> is in the <c>ON</c> state and the mode override is active.<br /><br /><br />
		/// Value for ControllerModeOverrideEnum.<br/>
		/// <br/>See also <seealso cref="ControllerModeOverrideEnum">ControllerModeOverrideEnum</seealso>
		/// </summary>
		public sealed class ONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ON";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(ControllerModeOverride)}} is in the `ON` state and the mode override is active.&#10;
";
		}
		private OFFValue _OFF;
		/// <inheritdoc cref="OFFValue" path="/summary" />
		public OFFValue OFF => _OFF ?? (_OFF = new OFFValue());

		/// <summary>﻿<see cref="ControllerModeOverride">ControllerModeOverride</see> is in the <c>OFF</c> state and the mode override is inactive.<br /><br /><br />
		/// Value for ControllerModeOverrideEnum.<br/>
		/// <br/>See also <seealso cref="ControllerModeOverrideEnum">ControllerModeOverrideEnum</seealso>
		/// </summary>
		public sealed class OFFValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OFF";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(ControllerModeOverride)}} is in the `OFF` state and the mode override is inactive.&#10;
";
		}
	}
}