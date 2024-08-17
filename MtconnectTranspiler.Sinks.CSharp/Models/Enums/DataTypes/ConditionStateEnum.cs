#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <inheritdoc />
		public string Name => "ConditionStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(ConditionStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class NormalValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "Normal";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(condition state)}} that indicates operation within specified limits.&#10;
";
		}
		private WarningValue _Warning;
		/// <inheritdoc cref="WarningValue" path="/summary" />
		public WarningValue Warning => _Warning ?? (_Warning = new WarningValue());

		/// <summary>﻿<i>condition state</i> that requires concern and supervision and may become hazardous if no action is taken.<br /><br /><br />
		/// Value for ConditionStateEnum.<br/>
		/// <br/>See also <seealso cref="ConditionStateEnum">ConditionStateEnum</seealso>
		/// </summary>
		public sealed class WarningValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "Warning";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(condition state)}} that requires concern and supervision and may become hazardous if no action is taken.&#10;
";
		}
		private FaultValue _Fault;
		/// <inheritdoc cref="FaultValue" path="/summary" />
		public FaultValue Fault => _Fault ?? (_Fault = new FaultValue());

		/// <summary>﻿<i>condition state</i> that requires intervention to continue operation to function properly.<br /><br /><br />
		/// Value for ConditionStateEnum.<br/>
		/// <br/>See also <seealso cref="ConditionStateEnum">ConditionStateEnum</seealso>
		/// </summary>
		public sealed class FaultValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "Fault";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(condition state)}} that requires intervention to continue operation to function properly.&#10;
";
		}
	}
}