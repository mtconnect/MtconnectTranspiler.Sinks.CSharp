#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605643327599_586044_593">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum OriginatorEnum
	{
		/// <summary>﻿manufacturer of a piece of equipment or <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		MANUFACTURER,
		/// <summary>﻿owner or implementer of a piece of equipment or <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		USER,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605643327599_586044_593">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class OriginatorEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="OriginatorEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605643327599_586044_593";
		/// <summary>Constant value for <see cref="OriginatorEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605643327599_586044_593";
		/// <summary>Constant value for <see cref="OriginatorEnumMetaClass.Name" /></summary>
		public const string NAME = "OriginatorEnum";
		/// <summary>Constant value for <see cref="OriginatorEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="OriginatorEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="OriginatorEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(OriginatorEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		MANUFACTURER,
		USER,
		};

		private MANUFACTURERValue _MANUFACTURER;
		/// <inheritdoc cref="MANUFACTURERValue" path="/summary" />
		public MANUFACTURERValue MANUFACTURER => _MANUFACTURER ?? (_MANUFACTURER = new MANUFACTURERValue());

		/// <summary>﻿manufacturer of a piece of equipment or <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for OriginatorEnum.<br/>
		/// <br/>See also <seealso cref="OriginatorEnum">OriginatorEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class MANUFACTURERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MANUFACTURERValue.Name" /></summary>
			public const string NAME = "MANUFACTURER";
			/// <summary>Constant value for <see cref="MANUFACTURERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="MANUFACTURERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MANUFACTURERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;manufacturer of a piece of equipment or {{block(Component)}}.&#10;
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
		private USERValue _USER;
		/// <inheritdoc cref="USERValue" path="/summary" />
		public USERValue USER => _USER ?? (_USER = new USERValue());

		/// <summary>﻿owner or implementer of a piece of equipment or <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for OriginatorEnum.<br/>
		/// <br/>See also <seealso cref="OriginatorEnum">OriginatorEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class USERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="USERValue.Name" /></summary>
			public const string NAME = "USER";
			/// <summary>Constant value for <see cref="USERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="USERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="USERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;owner or implementer of a piece of equipment or {{block(Component)}}.&#10;
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