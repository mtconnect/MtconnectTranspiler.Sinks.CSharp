#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579301039819_63145_6975">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum RoleTypeEnum
	{
		/// <summary>﻿associated element performs the functions of a <see cref="System">System</see> for this element.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		SYSTEM,
		/// <summary>﻿associated element performs the functions as an <c>Auxiliary</c> for this element.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		AUXILIARY,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579301039819_63145_6975">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RoleTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="RoleTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1579301039819_63145_6975";
		/// <summary>Constant value for <see cref="RoleTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579301039819_63145_6975";
		/// <summary>Constant value for <see cref="RoleTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "RoleTypeEnum";
		/// <summary>Constant value for <see cref="RoleTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.5";
		/// <summary>Constant value for <see cref="RoleTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="RoleTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(RoleTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		SYSTEM,
		AUXILIARY,
		};

		private SYSTEMValue _SYSTEM;
		/// <inheritdoc cref="SYSTEMValue" path="/summary" />
		public SYSTEMValue SYSTEM => _SYSTEM ?? (_SYSTEM = new SYSTEMValue());

		/// <summary>﻿associated element performs the functions of a <see cref="System">System</see> for this element.<br /><br /><br />
		/// Value for RoleTypeEnum.<br/>
		/// <br/>See also <seealso cref="RoleTypeEnum">RoleTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class SYSTEMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SYSTEMValue.Name" /></summary>
			public const string NAME = "SYSTEM";
			/// <summary>Constant value for <see cref="SYSTEMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="SYSTEMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SYSTEMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;associated element performs the functions of a {{block(System)}} for this element.&#10;
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
		private AUXILIARYValue _AUXILIARY;
		/// <inheritdoc cref="AUXILIARYValue" path="/summary" />
		public AUXILIARYValue AUXILIARY => _AUXILIARY ?? (_AUXILIARY = new AUXILIARYValue());

		/// <summary>﻿associated element performs the functions as an <c>Auxiliary</c> for this element.<br /><br /><br />
		/// Value for RoleTypeEnum.<br/>
		/// <br/>See also <seealso cref="RoleTypeEnum">RoleTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class AUXILIARYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AUXILIARYValue.Name" /></summary>
			public const string NAME = "AUXILIARY";
			/// <summary>Constant value for <see cref="AUXILIARYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="AUXILIARYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AUXILIARYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;associated element performs the functions as an `Auxiliary` for this element.&#10;
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