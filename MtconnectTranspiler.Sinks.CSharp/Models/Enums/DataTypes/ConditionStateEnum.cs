#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1633610276495_636137_441">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ConditionStateEnum
	{
		/// <summary>﻿<i>condition state</i> that indicates operation within specified limits.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		NORMAL,
		/// <summary>﻿<i>condition state</i> that requires concern and supervision and may become hazardous if no action is taken.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		WARNING,
		/// <summary>﻿<i>condition state</i> that requires intervention to continue operation to function properly.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		FAULT,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1633610276495_636137_441">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ConditionStateEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ConditionStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1633610276495_636137_441";
		/// <summary>Constant value for <see cref="ConditionStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1633610276495_636137_441";
		/// <summary>Constant value for <see cref="ConditionStateEnumMetaClass.Name" /></summary>
		public const string NAME = "ConditionStateEnum";
		/// <summary>Constant value for <see cref="ConditionStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="ConditionStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ConditionStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ConditionStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		Normal,
		Warning,
		Fault,
		};

		private NormalValue _Normal;
		/// <inheritdoc cref="NormalValue" path="/summary" />
		public NormalValue Normal => _Normal ?? (_Normal = new NormalValue());

		/// <summary>﻿<i>condition state</i> that indicates operation within specified limits.<br /><br /><br />
		/// Value for ConditionStateEnum.<br/>
		/// <br/>See also <seealso cref="ConditionStateEnum">ConditionStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class NormalValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NormalValue.Name" /></summary>
			public const string NAME = "Normal";
			/// <summary>Constant value for <see cref="NormalValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="NormalValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NormalValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(condition state)}} that indicates operation within specified limits.&#10;
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
		private WarningValue _Warning;
		/// <inheritdoc cref="WarningValue" path="/summary" />
		public WarningValue Warning => _Warning ?? (_Warning = new WarningValue());

		/// <summary>﻿<i>condition state</i> that requires concern and supervision and may become hazardous if no action is taken.<br /><br /><br />
		/// Value for ConditionStateEnum.<br/>
		/// <br/>See also <seealso cref="ConditionStateEnum">ConditionStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class WarningValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WarningValue.Name" /></summary>
			public const string NAME = "Warning";
			/// <summary>Constant value for <see cref="WarningValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="WarningValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WarningValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(condition state)}} that requires concern and supervision and may become hazardous if no action is taken.&#10;
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
		private FaultValue _Fault;
		/// <inheritdoc cref="FaultValue" path="/summary" />
		public FaultValue Fault => _Fault ?? (_Fault = new FaultValue());

		/// <summary>﻿<i>condition state</i> that requires intervention to continue operation to function properly.<br /><br /><br />
		/// Value for ConditionStateEnum.<br/>
		/// <br/>See also <seealso cref="ConditionStateEnum">ConditionStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class FaultValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FaultValue.Name" /></summary>
			public const string NAME = "Fault";
			/// <summary>Constant value for <see cref="FaultValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="FaultValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FaultValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(condition state)}} that requires intervention to continue operation to function properly.&#10;
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