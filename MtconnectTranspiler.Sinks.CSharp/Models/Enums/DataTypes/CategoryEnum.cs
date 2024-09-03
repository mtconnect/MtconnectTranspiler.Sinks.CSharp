#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579277872728_249968_3735">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CategoryEnum
	{
		/// <summary>﻿continuously variable or analog data value. <br /><br />A continuous value can be measured at any point-in-time and will always produce a result.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SAMPLE,
		/// <summary>﻿discrete piece of information from the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		EVENT,
		/// <summary>﻿information about the health of a piece of equipment and its ability to function.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONDITION,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579277872728_249968_3735">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CategoryEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="CategoryEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1579277872728_249968_3735";
		/// <summary>Constant value for <see cref="CategoryEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579277872728_249968_3735";
		/// <summary>Constant value for <see cref="CategoryEnumMetaClass.Name" /></summary>
		public const string NAME = "CategoryEnum";
		/// <summary>Constant value for <see cref="CategoryEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="CategoryEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="CategoryEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(CategoryEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		SAMPLE,
		EVENT,
		CONDITION,
		};

		private SAMPLEValue _SAMPLE;
		/// <inheritdoc cref="SAMPLEValue" path="/summary" />
		public SAMPLEValue SAMPLE => _SAMPLE ?? (_SAMPLE = new SAMPLEValue());

		/// <summary>﻿continuously variable or analog data value. <br /><br />A continuous value can be measured at any point-in-time and will always produce a result.<br /><br /><br />
		/// Value for CategoryEnum.<br/>
		/// <br/>See also <seealso cref="CategoryEnum">CategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SAMPLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SAMPLEValue.Name" /></summary>
			public const string NAME = "SAMPLE";
			/// <summary>Constant value for <see cref="SAMPLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="SAMPLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SAMPLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;continuously variable or analog data value. 

A continuous value can be measured at any point-in-time and will always produce a result.&#10;
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
		private EVENTValue _EVENT;
		/// <inheritdoc cref="EVENTValue" path="/summary" />
		public EVENTValue EVENT => _EVENT ?? (_EVENT = new EVENTValue());

		/// <summary>﻿discrete piece of information from the piece of equipment.<br /><br /><br />
		/// Value for CategoryEnum.<br/>
		/// <br/>See also <seealso cref="CategoryEnum">CategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class EVENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EVENTValue.Name" /></summary>
			public const string NAME = "EVENT";
			/// <summary>Constant value for <see cref="EVENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="EVENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EVENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;discrete piece of information from the piece of equipment.&#10;
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
		private CONDITIONValue _CONDITION;
		/// <inheritdoc cref="CONDITIONValue" path="/summary" />
		public CONDITIONValue CONDITION => _CONDITION ?? (_CONDITION = new CONDITIONValue());

		/// <summary>﻿information about the health of a piece of equipment and its ability to function.<br /><br /><br />
		/// Value for CategoryEnum.<br/>
		/// <br/>See also <seealso cref="CategoryEnum">CategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONDITIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONDITIONValue.Name" /></summary>
			public const string NAME = "CONDITION";
			/// <summary>Constant value for <see cref="CONDITIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="CONDITIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONDITIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;information about the health of a piece of equipment and its ability to function.&#10;
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