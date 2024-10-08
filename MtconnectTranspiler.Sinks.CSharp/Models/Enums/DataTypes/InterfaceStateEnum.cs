#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="InterfaceStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378417666_27713_2880";
		/// <summary>Constant value for <see cref="InterfaceStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417666_27713_2880";
		/// <summary>Constant value for <see cref="InterfaceStateEnumMetaClass.Name" /></summary>
		public const string NAME = "InterfaceStateEnum";
		/// <summary>Constant value for <see cref="InterfaceStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="InterfaceStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="InterfaceStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(InterfaceStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class ENABLEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ENABLEDValue.Name" /></summary>
			public const string NAME = "ENABLED";
			/// <summary>Constant value for <see cref="ENABLEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="ENABLEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ENABLEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Interface)}} is currently operational and performing as expected.&#10;
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
		private DISABLEDValue _DISABLED;
		/// <inheritdoc cref="DISABLEDValue" path="/summary" />
		public DISABLEDValue DISABLED => _DISABLED ?? (_DISABLED = new DISABLEDValue());

		/// <summary>﻿<see cref="Interface">Interface</see> is currently not operational.<br /><br /><br />
		/// Value for InterfaceStateEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceStateEnum">InterfaceStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class DISABLEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DISABLEDValue.Name" /></summary>
			public const string NAME = "DISABLED";
			/// <summary>Constant value for <see cref="DISABLEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="DISABLEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DISABLEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Interface)}} is currently not operational.&#10;
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