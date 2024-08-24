#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825603246_243967_772">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ApplicationCategoryEnum
	{
		/// <summary>﻿files regarding the fully assembled product.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		ASSEMBLY,
		/// <summary>﻿device related files.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		DEVICE,
		/// <summary>﻿files relating to the handling of material.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		HANDLING,
		/// <summary>﻿files relating to equipment maintenance.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		MAINTENANCE,
		/// <summary>﻿files relating to a part.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		PART,
		/// <summary>﻿files related to the manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		PROCESS,
		/// <summary>﻿files related to the quality inspection.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		INSPECTION,
		/// <summary>﻿files related to the setup of a process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		SETUP,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825603246_243967_772">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ApplicationCategoryEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ApplicationCategoryEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1589825603246_243967_772";
		/// <summary>Constant value for <see cref="ApplicationCategoryEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825603246_243967_772";
		/// <summary>Constant value for <see cref="ApplicationCategoryEnumMetaClass.Name" /></summary>
		public const string NAME = "ApplicationCategoryEnum";
		/// <summary>Constant value for <see cref="ApplicationCategoryEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="ApplicationCategoryEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ApplicationCategoryEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ApplicationCategoryEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ASSEMBLY,
		DEVICE,
		HANDLING,
		MAINTENANCE,
		PART,
		PROCESS,
		INSPECTION,
		SETUP,
		};

		private ASSEMBLYValue _ASSEMBLY;
		/// <inheritdoc cref="ASSEMBLYValue" path="/summary" />
		public ASSEMBLYValue ASSEMBLY => _ASSEMBLY ?? (_ASSEMBLY = new ASSEMBLYValue());

		/// <summary>﻿files regarding the fully assembled product.<br /><br /><br />
		/// Value for ApplicationCategoryEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationCategoryEnum">ApplicationCategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class ASSEMBLYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ASSEMBLYValue.Name" /></summary>
			public const string NAME = "ASSEMBLY";
			/// <summary>Constant value for <see cref="ASSEMBLYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ASSEMBLYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ASSEMBLYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;files regarding the fully assembled product.&#10;
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
		private DEVICEValue _DEVICE;
		/// <inheritdoc cref="DEVICEValue" path="/summary" />
		public DEVICEValue DEVICE => _DEVICE ?? (_DEVICE = new DEVICEValue());

		/// <summary>﻿device related files.<br /><br /><br />
		/// Value for ApplicationCategoryEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationCategoryEnum">ApplicationCategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEVICEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEVICEValue.Name" /></summary>
			public const string NAME = "DEVICE";
			/// <summary>Constant value for <see cref="DEVICEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="DEVICEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEVICEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;device related files.&#10;
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
		private HANDLINGValue _HANDLING;
		/// <inheritdoc cref="HANDLINGValue" path="/summary" />
		public HANDLINGValue HANDLING => _HANDLING ?? (_HANDLING = new HANDLINGValue());

		/// <summary>﻿files relating to the handling of material.<br /><br /><br />
		/// Value for ApplicationCategoryEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationCategoryEnum">ApplicationCategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class HANDLINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="HANDLINGValue.Name" /></summary>
			public const string NAME = "HANDLING";
			/// <summary>Constant value for <see cref="HANDLINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="HANDLINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="HANDLINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;files relating to the handling of material.&#10;
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
		private MAINTENANCEValue _MAINTENANCE;
		/// <inheritdoc cref="MAINTENANCEValue" path="/summary" />
		public MAINTENANCEValue MAINTENANCE => _MAINTENANCE ?? (_MAINTENANCE = new MAINTENANCEValue());

		/// <summary>﻿files relating to equipment maintenance.<br /><br /><br />
		/// Value for ApplicationCategoryEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationCategoryEnum">ApplicationCategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class MAINTENANCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MAINTENANCEValue.Name" /></summary>
			public const string NAME = "MAINTENANCE";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;files relating to equipment maintenance.&#10;
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

		/// <summary>﻿files relating to a part.<br /><br /><br /><br />
		/// Value for ApplicationCategoryEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationCategoryEnum">ApplicationCategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class PARTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PARTValue.Name" /></summary>
			public const string NAME = "PART";
			/// <summary>Constant value for <see cref="PARTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PARTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PARTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;files relating to a part.&#10;
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
		private PROCESSValue _PROCESS;
		/// <inheritdoc cref="PROCESSValue" path="/summary" />
		public PROCESSValue PROCESS => _PROCESS ?? (_PROCESS = new PROCESSValue());

		/// <summary>﻿files related to the manufacturing process.<br /><br /><br />
		/// Value for ApplicationCategoryEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationCategoryEnum">ApplicationCategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESSValue.Name" /></summary>
			public const string NAME = "PROCESS";
			/// <summary>Constant value for <see cref="PROCESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PROCESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;files related to the manufacturing process.&#10;
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
		private INSPECTIONValue _INSPECTION;
		/// <inheritdoc cref="INSPECTIONValue" path="/summary" />
		public INSPECTIONValue INSPECTION => _INSPECTION ?? (_INSPECTION = new INSPECTIONValue());

		/// <summary>﻿files related to the quality inspection.<br /><br /><br />
		/// Value for ApplicationCategoryEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationCategoryEnum">ApplicationCategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class INSPECTIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INSPECTIONValue.Name" /></summary>
			public const string NAME = "INSPECTION";
			/// <summary>Constant value for <see cref="INSPECTIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="INSPECTIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INSPECTIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;files related to the quality inspection.&#10;
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
		private SETUPValue _SETUP;
		/// <inheritdoc cref="SETUPValue" path="/summary" />
		public SETUPValue SETUP => _SETUP ?? (_SETUP = new SETUPValue());

		/// <summary>﻿files related to the setup of a process.<br /><br /><br />
		/// Value for ApplicationCategoryEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationCategoryEnum">ApplicationCategoryEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class SETUPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SETUPValue.Name" /></summary>
			public const string NAME = "SETUP";
			/// <summary>Constant value for <see cref="SETUPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="SETUPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SETUPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;files related to the setup of a process.&#10;
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