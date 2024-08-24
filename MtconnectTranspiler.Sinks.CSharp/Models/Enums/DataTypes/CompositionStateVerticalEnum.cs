#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550799197_550203_137">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CompositionStateVerticalEnum
	{
		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is oriented in an upward direction to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		UP,
		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is oriented in a downward direction to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		DOWN,
		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is not oriented in an upward direction to the point of a positive confirmation and is not oriented in a downward direction to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		TRANSITIONING,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550799197_550203_137">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CompositionStateVerticalEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="CompositionStateVerticalEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1612550799197_550203_137";
		/// <summary>Constant value for <see cref="CompositionStateVerticalEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550799197_550203_137";
		/// <summary>Constant value for <see cref="CompositionStateVerticalEnumMetaClass.Name" /></summary>
		public const string NAME = "CompositionStateVerticalEnum";
		/// <summary>Constant value for <see cref="CompositionStateVerticalEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.4";
		/// <summary>Constant value for <see cref="CompositionStateVerticalEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="CompositionStateVerticalEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(CompositionStateVerticalEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		UP,
		DOWN,
		TRANSITIONING,
		};

		private UPValue _UP;
		/// <inheritdoc cref="UPValue" path="/summary" />
		public UPValue UP => _UP ?? (_UP = new UPValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is oriented in an upward direction to the point of a positive confirmation.<br /><br /><br />
		/// Value for CompositionStateVerticalEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateVerticalEnum">CompositionStateVerticalEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class UPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UPValue.Name" /></summary>
			public const string NAME = "UP";
			/// <summary>Constant value for <see cref="UPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="UPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;position of the {{block(Composition)}} element is oriented in an upward direction to the point of a positive confirmation.&#10;
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
		private DOWNValue _DOWN;
		/// <inheritdoc cref="DOWNValue" path="/summary" />
		public DOWNValue DOWN => _DOWN ?? (_DOWN = new DOWNValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is oriented in a downward direction to the point of a positive confirmation.<br /><br /><br />
		/// Value for CompositionStateVerticalEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateVerticalEnum">CompositionStateVerticalEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class DOWNValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DOWNValue.Name" /></summary>
			public const string NAME = "DOWN";
			/// <summary>Constant value for <see cref="DOWNValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="DOWNValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DOWNValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;position of the {{block(Composition)}} element is oriented in a downward direction to the point of a positive confirmation.&#10;
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
		private TRANSITIONINGValue _TRANSITIONING;
		/// <inheritdoc cref="TRANSITIONINGValue" path="/summary" />
		public TRANSITIONINGValue TRANSITIONING => _TRANSITIONING ?? (_TRANSITIONING = new TRANSITIONINGValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is not oriented in an upward direction to the point of a positive confirmation and is not oriented in a downward direction to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// Value for CompositionStateVerticalEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateVerticalEnum">CompositionStateVerticalEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class TRANSITIONINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TRANSITIONINGValue.Name" /></summary>
			public const string NAME = "TRANSITIONING";
			/// <summary>Constant value for <see cref="TRANSITIONINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="TRANSITIONINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TRANSITIONINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;position of the {{block(Composition)}} element is not oriented in an upward direction to the point of a positive confirmation and is not oriented in a downward direction to the point of a positive confirmation. 

It is in an intermediate position.&#10;
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