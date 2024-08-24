#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550806336_962403_162">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CompositionStateLateralEnum
	{
		/// <summary>﻿position of the <see cref="Composition">Composition</see> is oriented to the right to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		RIGHT,
		/// <summary>﻿position of the <see cref="Composition">Composition</see> is oriented to the left to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		LEFT,
		/// <summary>﻿position of the <see cref="Composition">Composition</see> is not oriented to the right to the point of a positive confirmation and is not oriented to the left to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		TRANSITIONING,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550806336_962403_162">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CompositionStateLateralEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="CompositionStateLateralEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1612550806336_962403_162";
		/// <summary>Constant value for <see cref="CompositionStateLateralEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550806336_962403_162";
		/// <summary>Constant value for <see cref="CompositionStateLateralEnumMetaClass.Name" /></summary>
		public const string NAME = "CompositionStateLateralEnum";
		/// <summary>Constant value for <see cref="CompositionStateLateralEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.4";
		/// <summary>Constant value for <see cref="CompositionStateLateralEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="CompositionStateLateralEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(CompositionStateLateralEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		RIGHT,
		LEFT,
		TRANSITIONING,
		};

		private RIGHTValue _RIGHT;
		/// <inheritdoc cref="RIGHTValue" path="/summary" />
		public RIGHTValue RIGHT => _RIGHT ?? (_RIGHT = new RIGHTValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> is oriented to the right to the point of a positive confirmation.<br /><br /><br />
		/// Value for CompositionStateLateralEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateLateralEnum">CompositionStateLateralEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class RIGHTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RIGHTValue.Name" /></summary>
			public const string NAME = "RIGHT";
			/// <summary>Constant value for <see cref="RIGHTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="RIGHTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RIGHTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;position of the {{block(Composition)}} is oriented to the right to the point of a positive confirmation.&#10;
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
		private LEFTValue _LEFT;
		/// <inheritdoc cref="LEFTValue" path="/summary" />
		public LEFTValue LEFT => _LEFT ?? (_LEFT = new LEFTValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> is oriented to the left to the point of a positive confirmation.<br /><br /><br />
		/// Value for CompositionStateLateralEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateLateralEnum">CompositionStateLateralEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class LEFTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LEFTValue.Name" /></summary>
			public const string NAME = "LEFT";
			/// <summary>Constant value for <see cref="LEFTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="LEFTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LEFTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;position of the {{block(Composition)}} is oriented to the left to the point of a positive confirmation.&#10;
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

		/// <summary>﻿position of the <see cref="Composition">Composition</see> is not oriented to the right to the point of a positive confirmation and is not oriented to the left to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// Value for CompositionStateLateralEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateLateralEnum">CompositionStateLateralEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;position of the {{block(Composition)}} is not oriented to the right to the point of a positive confirmation and is not oriented to the left to the point of a positive confirmation. 

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