#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="NetworkWirelessEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1643979384902_745208_1916";
		/// <summary>Constant value for <see cref="NetworkWirelessEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643979384902_745208_1916";
		/// <summary>Constant value for <see cref="NetworkWirelessEnumMetaClass.Name" /></summary>
		public const string NAME = "NetworkWirelessEnum";
		/// <summary>Constant value for <see cref="NetworkWirelessEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.6";
		/// <summary>Constant value for <see cref="NetworkWirelessEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="NetworkWirelessEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(NetworkWirelessEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class YESValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="YESValue.Name" /></summary>
			public const string NAME = "YES";
			/// <summary>Constant value for <see cref="YESValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="YESValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="YESValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;&#10;
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
		private NOValue _NO;
		/// <inheritdoc cref="NOValue" path="/summary" />
		public NOValue NO => _NO ?? (_NO = new NOValue());

		/// <summary>﻿<br /><br /><br />
		/// Value for NetworkWirelessEnum.<br/>
		/// <br/>See also <seealso cref="NetworkWirelessEnum">NetworkWirelessEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class NOValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NOValue.Name" /></summary>
			public const string NAME = "NO";
			/// <summary>Constant value for <see cref="NOValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="NOValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NOValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;&#10;
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