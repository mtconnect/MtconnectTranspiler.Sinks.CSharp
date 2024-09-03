#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640702052373_905765_57">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum PartCountTypeEnum
	{
		/// <summary>﻿count is of individual items.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		EACH,
		/// <summary>﻿pre-specified group of items.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		BATCH,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640702052373_905765_57">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PartCountTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="PartCountTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1640702052373_905765_57";
		/// <summary>Constant value for <see cref="PartCountTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640702052373_905765_57";
		/// <summary>Constant value for <see cref="PartCountTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "PartCountTypeEnum";
		/// <summary>Constant value for <see cref="PartCountTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.0";
		/// <summary>Constant value for <see cref="PartCountTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="PartCountTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(PartCountTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		EACH,
		BATCH,
		};

		private EACHValue _EACH;
		/// <inheritdoc cref="EACHValue" path="/summary" />
		public EACHValue EACH => _EACH ?? (_EACH = new EACHValue());

		/// <summary>﻿count is of individual items.<br /><br /><br />
		/// Value for PartCountTypeEnum.<br/>
		/// <br/>See also <seealso cref="PartCountTypeEnum">PartCountTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class EACHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EACHValue.Name" /></summary>
			public const string NAME = "EACH";
			/// <summary>Constant value for <see cref="EACHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="EACHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EACHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;count is of individual items.&#10;
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
		private BATCHValue _BATCH;
		/// <inheritdoc cref="BATCHValue" path="/summary" />
		public BATCHValue BATCH => _BATCH ?? (_BATCH = new BATCHValue());

		/// <summary>﻿pre-specified group of items.<br /><br /><br />
		/// Value for PartCountTypeEnum.<br/>
		/// <br/>See also <seealso cref="PartCountTypeEnum">PartCountTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BATCHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BATCHValue.Name" /></summary>
			public const string NAME = "BATCH";
			/// <summary>Constant value for <see cref="BATCHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="BATCHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BATCHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;pre-specified group of items.&#10;
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