#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417656_729564_2870">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum AvailabilityEnum
	{
		/// <summary>﻿data source is active and capable of providing data.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		AVAILABLE,
		/// <summary>﻿data source is either inactive or not capable of providing data.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		UNAVAILABLE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417656_729564_2870">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AvailabilityEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="AvailabilityEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378417656_729564_2870";
		/// <summary>Constant value for <see cref="AvailabilityEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417656_729564_2870";
		/// <summary>Constant value for <see cref="AvailabilityEnumMetaClass.Name" /></summary>
		public const string NAME = "AvailabilityEnum";
		/// <summary>Constant value for <see cref="AvailabilityEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="AvailabilityEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="AvailabilityEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(AvailabilityEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		AVAILABLE,
		UNAVAILABLE,
		};

		private AVAILABLEValue _AVAILABLE;
		/// <inheritdoc cref="AVAILABLEValue" path="/summary" />
		public AVAILABLEValue AVAILABLE => _AVAILABLE ?? (_AVAILABLE = new AVAILABLEValue());

		/// <summary>﻿data source is active and capable of providing data.<br /><br /><br />
		/// Value for AvailabilityEnum.<br/>
		/// <br/>See also <seealso cref="AvailabilityEnum">AvailabilityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class AVAILABLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AVAILABLEValue.Name" /></summary>
			public const string NAME = "AVAILABLE";
			/// <summary>Constant value for <see cref="AVAILABLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="AVAILABLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AVAILABLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;data source is active and capable of providing data.&#10;
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
		private UNAVAILABLEValue _UNAVAILABLE;
		/// <inheritdoc cref="UNAVAILABLEValue" path="/summary" />
		public UNAVAILABLEValue UNAVAILABLE => _UNAVAILABLE ?? (_UNAVAILABLE = new UNAVAILABLEValue());

		/// <summary>﻿data source is either inactive or not capable of providing data.<br /><br /><br />
		/// Value for AvailabilityEnum.<br/>
		/// <br/>See also <seealso cref="AvailabilityEnum">AvailabilityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNAVAILABLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNAVAILABLEValue.Name" /></summary>
			public const string NAME = "UNAVAILABLE";
			/// <summary>Constant value for <see cref="UNAVAILABLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="UNAVAILABLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNAVAILABLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;data source is either inactive or not capable of providing data.&#10;
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