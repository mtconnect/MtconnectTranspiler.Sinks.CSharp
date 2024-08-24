#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550781451_530503_112">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CompositionStateSwitchedEnum
	{
		/// <summary>﻿activation state of the <see cref="Composition">Composition</see> is in an <c>ON</c> condition, it is operating, or it is powered.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		ON,
		/// <summary>﻿activation state of the <see cref="Composition">Composition</see> is in an <c>OFF</c> condition, it is not operating, or it is not powered.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		OFF,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550781451_530503_112">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CompositionStateSwitchedEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="CompositionStateSwitchedEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1612550781451_530503_112";
		/// <summary>Constant value for <see cref="CompositionStateSwitchedEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550781451_530503_112";
		/// <summary>Constant value for <see cref="CompositionStateSwitchedEnumMetaClass.Name" /></summary>
		public const string NAME = "CompositionStateSwitchedEnum";
		/// <summary>Constant value for <see cref="CompositionStateSwitchedEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.4";
		/// <summary>Constant value for <see cref="CompositionStateSwitchedEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="CompositionStateSwitchedEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(CompositionStateSwitchedEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ON,
		OFF,
		};

		private ONValue _ON;
		/// <inheritdoc cref="ONValue" path="/summary" />
		public ONValue ON => _ON ?? (_ON = new ONValue());

		/// <summary>﻿activation state of the <see cref="Composition">Composition</see> is in an <c>ON</c> condition, it is operating, or it is powered.<br /><br /><br />
		/// Value for CompositionStateSwitchedEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateSwitchedEnum">CompositionStateSwitchedEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class ONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ONValue.Name" /></summary>
			public const string NAME = "ON";
			/// <summary>Constant value for <see cref="ONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="ONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;activation state of the {{block(Composition)}} is in an `ON` condition, it is operating, or it is powered.&#10;
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
		private OFFValue _OFF;
		/// <inheritdoc cref="OFFValue" path="/summary" />
		public OFFValue OFF => _OFF ?? (_OFF = new OFFValue());

		/// <summary>﻿activation state of the <see cref="Composition">Composition</see> is in an <c>OFF</c> condition, it is not operating, or it is not powered.<br /><br /><br />
		/// Value for CompositionStateSwitchedEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateSwitchedEnum">CompositionStateSwitchedEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class OFFValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OFFValue.Name" /></summary>
			public const string NAME = "OFF";
			/// <summary>Constant value for <see cref="OFFValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="OFFValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OFFValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;activation state of the {{block(Composition)}} is in an `OFF` condition, it is not operating, or it is not powered.&#10;
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