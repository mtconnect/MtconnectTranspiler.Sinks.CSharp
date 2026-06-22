#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744802647776_12571_23869">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public enum ScopeTypeEnum
	{
		/// <summary>﻿scope or context is directly upon the source itself.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		ENTITY,
		/// <summary>﻿scope or context is upon a value property of the source.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		VALUE_PROPERTY,
		/// <summary>﻿scope or context is upon a part or a child of the source.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		PART,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744802647776_12571_23869">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class ScopeTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ScopeTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744802647776_12571_23869";
		/// <summary>Constant value for <see cref="ScopeTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744802647776_12571_23869";
		/// <summary>Constant value for <see cref="ScopeTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "ScopeTypeEnum";
		/// <summary>Constant value for <see cref="ScopeTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="ScopeTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ScopeTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ScopeTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ENTITY,
		VALUE_PROPERTY,
		PART,
		};

		private ENTITYValue _ENTITY;
		/// <inheritdoc cref="ENTITYValue" path="/summary" />
		public ENTITYValue ENTITY => _ENTITY ?? (_ENTITY = new ENTITYValue());

		/// <summary>﻿scope or context is directly upon the source itself.<br /><br /><br />
		/// Value for ScopeTypeEnum.<br/>
		/// <br/>See also <seealso cref="ScopeTypeEnum">ScopeTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class ENTITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ENTITYValue.Name" /></summary>
			public const string NAME = "ENTITY";
			/// <summary>Constant value for <see cref="ENTITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="ENTITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ENTITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scope or context is directly upon the source itself.&#10;
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
		private VALUE_PROPERTYValue _VALUE_PROPERTY;
		/// <inheritdoc cref="VALUE_PROPERTYValue" path="/summary" />
		public VALUE_PROPERTYValue VALUE_PROPERTY => _VALUE_PROPERTY ?? (_VALUE_PROPERTY = new VALUE_PROPERTYValue());

		/// <summary>﻿scope or context is upon a value property of the source.<br /><br /><br />
		/// Value for ScopeTypeEnum.<br/>
		/// <br/>See also <seealso cref="ScopeTypeEnum">ScopeTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class VALUE_PROPERTYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VALUE_PROPERTYValue.Name" /></summary>
			public const string NAME = "VALUE_PROPERTY";
			/// <summary>Constant value for <see cref="VALUE_PROPERTYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="VALUE_PROPERTYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VALUE_PROPERTYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scope or context is upon a value property of the source.&#10;
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
		private PARTValue _PART;
		/// <inheritdoc cref="PARTValue" path="/summary" />
		public PARTValue PART => _PART ?? (_PART = new PARTValue());

		/// <summary>﻿scope or context is upon a part or a child of the source.<br /><br /><br />
		/// Value for ScopeTypeEnum.<br/>
		/// <br/>See also <seealso cref="ScopeTypeEnum">ScopeTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class PARTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PARTValue.Name" /></summary>
			public const string NAME = "PART";
			/// <summary>Constant value for <see cref="PARTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="PARTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PARTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scope or context is upon a part or a child of the source.&#10;
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
