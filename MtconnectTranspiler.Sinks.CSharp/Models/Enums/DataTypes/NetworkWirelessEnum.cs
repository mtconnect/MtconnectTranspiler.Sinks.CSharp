#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643979384902_745208_1916">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum NetworkWirelessEnum
	{
		/// <summary>﻿<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		YES,
		/// <summary>﻿<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		NO,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643979384902_745208_1916">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class NetworkWirelessEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "NetworkWirelessEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(NetworkWirelessEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.6";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		YES,
		NO,
		};

		private YESValue _YES;
		/// <inheritdoc cref="YESValue" path="/summary" />
		public YESValue YES => _YES ?? (_YES = new YESValue());

		/// <summary>﻿<br /><br /><br />
		/// Value for NetworkWirelessEnum.<br/>
		/// <br/>See also <seealso cref="NetworkWirelessEnum">NetworkWirelessEnum</seealso>
		/// </summary>
		public sealed class YESValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "YES";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;&#10;
";
		}
		private NOValue _NO;
		/// <inheritdoc cref="NOValue" path="/summary" />
		public NOValue NO => _NO ?? (_NO = new NOValue());

		/// <summary>﻿<br /><br /><br />
		/// Value for NetworkWirelessEnum.<br/>
		/// <br/>See also <seealso cref="NetworkWirelessEnum">NetworkWirelessEnum</seealso>
		/// </summary>
		public sealed class NOValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NO";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;&#10;
";
		}
	}
}