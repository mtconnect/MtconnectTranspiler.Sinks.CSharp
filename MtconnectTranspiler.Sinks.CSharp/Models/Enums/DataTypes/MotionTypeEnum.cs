#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_4BA8528B_F152_49aa_BEFD_2574649F9F1A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum MotionTypeEnum
	{
		/// <summary>﻿sliding linear motion along an axis with a fixed range of motion.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		PRISMATIC,
		/// <summary>﻿revolves around an axis with a continuous range of motion.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		CONTINUOUS,
		/// <summary>﻿rotates around an axis with a fixed range of motion.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		REVOLUTE,
		/// <summary>﻿axis does not move.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		FIXED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_4BA8528B_F152_49aa_BEFD_2574649F9F1A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MotionTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="MotionTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_4BA8528B_F152_49aa_BEFD_2574649F9F1A";
		/// <summary>Constant value for <see cref="MotionTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_4BA8528B_F152_49aa_BEFD_2574649F9F1A";
		/// <summary>Constant value for <see cref="MotionTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "MotionTypeEnum";
		/// <summary>Constant value for <see cref="MotionTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="MotionTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="MotionTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(MotionTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		PRISMATIC,
		CONTINUOUS,
		REVOLUTE,
		FIXED,
		};

		private PRISMATICValue _PRISMATIC;
		/// <inheritdoc cref="PRISMATICValue" path="/summary" />
		public PRISMATICValue PRISMATIC => _PRISMATIC ?? (_PRISMATIC = new PRISMATICValue());

		/// <summary>﻿sliding linear motion along an axis with a fixed range of motion.<br /><br /><br />
		/// Value for MotionTypeEnum.<br/>
		/// <br/>See also <seealso cref="MotionTypeEnum">MotionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class PRISMATICValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PRISMATICValue.Name" /></summary>
			public const string NAME = "PRISMATIC";
			/// <summary>Constant value for <see cref="PRISMATICValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PRISMATICValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PRISMATICValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;sliding linear motion along an axis with a fixed range of motion.&#10;
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
		private CONTINUOUSValue _CONTINUOUS;
		/// <inheritdoc cref="CONTINUOUSValue" path="/summary" />
		public CONTINUOUSValue CONTINUOUS => _CONTINUOUS ?? (_CONTINUOUS = new CONTINUOUSValue());

		/// <summary>﻿revolves around an axis with a continuous range of motion.<br /><br /><br />
		/// Value for MotionTypeEnum.<br/>
		/// <br/>See also <seealso cref="MotionTypeEnum">MotionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONTINUOUSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONTINUOUSValue.Name" /></summary>
			public const string NAME = "CONTINUOUS";
			/// <summary>Constant value for <see cref="CONTINUOUSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="CONTINUOUSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONTINUOUSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;revolves around an axis with a continuous range of motion.&#10;
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
		private REVOLUTEValue _REVOLUTE;
		/// <inheritdoc cref="REVOLUTEValue" path="/summary" />
		public REVOLUTEValue REVOLUTE => _REVOLUTE ?? (_REVOLUTE = new REVOLUTEValue());

		/// <summary>﻿rotates around an axis with a fixed range of motion.<br /><br /><br />
		/// Value for MotionTypeEnum.<br/>
		/// <br/>See also <seealso cref="MotionTypeEnum">MotionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class REVOLUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="REVOLUTEValue.Name" /></summary>
			public const string NAME = "REVOLUTE";
			/// <summary>Constant value for <see cref="REVOLUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="REVOLUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="REVOLUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rotates around an axis with a fixed range of motion.&#10;
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
		private FIXEDValue _FIXED;
		/// <inheritdoc cref="FIXEDValue" path="/summary" />
		public FIXEDValue FIXED => _FIXED ?? (_FIXED = new FIXEDValue());

		/// <summary>﻿axis does not move.<br /><br /><br />
		/// Value for MotionTypeEnum.<br/>
		/// <br/>See also <seealso cref="MotionTypeEnum">MotionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class FIXEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FIXEDValue.Name" /></summary>
			public const string NAME = "FIXED";
			/// <summary>Constant value for <see cref="FIXEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="FIXEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FIXEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;axis does not move.&#10;
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