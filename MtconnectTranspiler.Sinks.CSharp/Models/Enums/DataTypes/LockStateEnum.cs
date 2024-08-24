#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622457615279_962450_700">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum LockStateEnum
	{
		/// <summary>﻿mechanism is engaged and preventing the associated <see cref="Component">Component</see> from being opened or operated.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		LOCKED,
		/// <summary>﻿mechanism is disengaged and the associated <see cref="Component">Component</see> is able to be opened or operated.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		UNLOCKED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622457615279_962450_700">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class LockStateEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="LockStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622457615279_962450_700";
		/// <summary>Constant value for <see cref="LockStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622457615279_962450_700";
		/// <summary>Constant value for <see cref="LockStateEnumMetaClass.Name" /></summary>
		public const string NAME = "LockStateEnum";
		/// <summary>Constant value for <see cref="LockStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.8";
		/// <summary>Constant value for <see cref="LockStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="LockStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(LockStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		LOCKED,
		UNLOCKED,
		};

		private LOCKEDValue _LOCKED;
		/// <inheritdoc cref="LOCKEDValue" path="/summary" />
		public LOCKEDValue LOCKED => _LOCKED ?? (_LOCKED = new LOCKEDValue());

		/// <summary>﻿mechanism is engaged and preventing the associated <see cref="Component">Component</see> from being opened or operated.<br /><br /><br />
		/// Value for LockStateEnum.<br/>
		/// <br/>See also <seealso cref="LockStateEnum">LockStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOCKEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOCKEDValue.Name" /></summary>
			public const string NAME = "LOCKED";
			/// <summary>Constant value for <see cref="LOCKEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="LOCKEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOCKEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;mechanism is engaged and preventing the associated {{block(Component)}} from being opened or operated.&#10;
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
		private UNLOCKEDValue _UNLOCKED;
		/// <inheritdoc cref="UNLOCKEDValue" path="/summary" />
		public UNLOCKEDValue UNLOCKED => _UNLOCKED ?? (_UNLOCKED = new UNLOCKEDValue());

		/// <summary>﻿mechanism is disengaged and the associated <see cref="Component">Component</see> is able to be opened or operated.<br /><br /><br />
		/// Value for LockStateEnum.<br/>
		/// <br/>See also <seealso cref="LockStateEnum">LockStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNLOCKEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNLOCKEDValue.Name" /></summary>
			public const string NAME = "UNLOCKED";
			/// <summary>Constant value for <see cref="UNLOCKEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="UNLOCKEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNLOCKEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;mechanism is disengaged and the associated {{block(Component)}} is able to be opened or operated.&#10;
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