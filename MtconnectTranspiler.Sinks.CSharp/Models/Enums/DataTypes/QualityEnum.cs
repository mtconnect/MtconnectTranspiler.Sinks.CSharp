#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1727719587498_658467_22924">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum QualityEnum
	{
		/// <summary>﻿<i>observation</i> is valid against the MTConnect Standard.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
		/// </list>
		/// </remarks>

		VALID,
		/// <summary>﻿<i>observation</i> cannot be validated.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
		/// </list>
		/// </remarks>

		UNVERIFIABLE,
		/// <summary>﻿<i>observation</i> is not valid against the MTConnect Standard according to the validation capabilities of the <i>MTConnect Agent</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
		/// </list>
		/// </remarks>

		INVALID,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1727719587498_658467_22924">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class QualityEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="QualityEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727719587498_658467_22924";
		/// <summary>Constant value for <see cref="QualityEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___2024x_68e0225_1727719587498_658467_22924";
		/// <summary>Constant value for <see cref="QualityEnumMetaClass.Name" /></summary>
		public const string NAME = "QualityEnum";
		/// <summary>Constant value for <see cref="QualityEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.5";
		/// <summary>Constant value for <see cref="QualityEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="QualityEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(QualityEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		VALID,
		UNVERIFIABLE,
		INVALID,
		};

		private VALIDValue _VALID;
		/// <inheritdoc cref="VALIDValue" path="/summary" />
		public VALIDValue VALID => _VALID ?? (_VALID = new VALIDValue());

		/// <summary>﻿<i>observation</i> is valid against the MTConnect Standard.<br /><br /><br />
		/// Value for QualityEnum.<br/>
		/// <br/>See also <seealso cref="QualityEnum">QualityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class VALIDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VALIDValue.Name" /></summary>
			public const string NAME = "VALID";
			/// <summary>Constant value for <see cref="VALIDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.5";
			/// <summary>Constant value for <see cref="VALIDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VALIDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} is valid against the MTConnect Standard.&#10;
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
		private UNVERIFIABLEValue _UNVERIFIABLE;
		/// <inheritdoc cref="UNVERIFIABLEValue" path="/summary" />
		public UNVERIFIABLEValue UNVERIFIABLE => _UNVERIFIABLE ?? (_UNVERIFIABLE = new UNVERIFIABLEValue());

		/// <summary>﻿<i>observation</i> cannot be validated.<br /><br /><br />
		/// Value for QualityEnum.<br/>
		/// <br/>See also <seealso cref="QualityEnum">QualityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNVERIFIABLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNVERIFIABLEValue.Name" /></summary>
			public const string NAME = "UNVERIFIABLE";
			/// <summary>Constant value for <see cref="UNVERIFIABLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.5";
			/// <summary>Constant value for <see cref="UNVERIFIABLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNVERIFIABLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} cannot be validated.&#10;
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
		private INVALIDValue _INVALID;
		/// <inheritdoc cref="INVALIDValue" path="/summary" />
		public INVALIDValue INVALID => _INVALID ?? (_INVALID = new INVALIDValue());

		/// <summary>﻿<i>observation</i> is not valid against the MTConnect Standard according to the validation capabilities of the <i>MTConnect Agent</i>.<br /><br /><br />
		/// Value for QualityEnum.<br/>
		/// <br/>See also <seealso cref="QualityEnum">QualityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class INVALIDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INVALIDValue.Name" /></summary>
			public const string NAME = "INVALID";
			/// <summary>Constant value for <see cref="INVALIDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.5";
			/// <summary>Constant value for <see cref="INVALIDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INVALIDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} is not valid against the MTConnect Standard according to the validation capabilities of the {{term(MTConnect Agent)}}.&#10;
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