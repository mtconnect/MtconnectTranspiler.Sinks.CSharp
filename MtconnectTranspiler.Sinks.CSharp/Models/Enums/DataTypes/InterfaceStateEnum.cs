#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417666_27713_2880">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum InterfaceStateEnum
	{
		/// <summary>﻿<see cref="Interface">Interface</see> is currently operational and performing as expected.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ENABLED,
		/// <summary>﻿<see cref="Interface">Interface</see> is currently not operational.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		DISABLED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417666_27713_2880">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class InterfaceStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "InterfaceStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(InterfaceStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.3";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ENABLED,
		DISABLED,
		};

		private ENABLEDValue _ENABLED;
		/// <inheritdoc cref="ENABLEDValue" path="/summary" />
		public ENABLEDValue ENABLED => _ENABLED ?? (_ENABLED = new ENABLEDValue());

		/// <summary>﻿<see cref="Interface">Interface</see> is currently operational and performing as expected.<br /><br /><br />
		/// Value for InterfaceStateEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceStateEnum">InterfaceStateEnum</seealso>
		/// </summary>
		public sealed class ENABLEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ENABLED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Interface)}} is currently operational and performing as expected.&#10;
";
		}
		private DISABLEDValue _DISABLED;
		/// <inheritdoc cref="DISABLEDValue" path="/summary" />
		public DISABLEDValue DISABLED => _DISABLED ?? (_DISABLED = new DISABLEDValue());

		/// <summary>﻿<see cref="Interface">Interface</see> is currently not operational.<br /><br /><br />
		/// Value for InterfaceStateEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceStateEnum">InterfaceStateEnum</seealso>
		/// </summary>
		public sealed class DISABLEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DISABLED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Interface)}} is currently not operational.&#10;
";
		}
	}
}