#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417665_982246_2879">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum FunctionalModeEnum
	{
		/// <summary>﻿<see cref="Component">Component</see> is currently producing product, ready to produce product, or its current intended use is to be producing product.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		PRODUCTION,
		/// <summary>﻿<see cref="Component">Component</see> is not currently producing product. <br /><br />It is being prepared or modified to begin production of product.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		SETUP,
		/// <summary>﻿<see cref="Component">Component</see> is not currently producing product.<br /><br />Typically, it has completed the production of a product and is being modified or returned to a neutral state such that it may then be prepared to begin production of a different product.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		TEARDOWN,
		/// <summary>﻿<see cref="Component">Component</see> is not currently producing product.<br /><br />It is currently being repaired, waiting to be repaired, or has not yet been returned to a normal production status after maintenance has been performed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		MAINTENANCE,
		/// <summary>﻿<see cref="Component">Component</see> is being used to prove-out a new process, testing of equipment or processes, or any other active use that does not result in the production of product.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		PROCESS_DEVELOPMENT,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417665_982246_2879">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FunctionalModeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="FunctionalModeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378417665_982246_2879";
		/// <summary>Constant value for <see cref="FunctionalModeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417665_982246_2879";
		/// <summary>Constant value for <see cref="FunctionalModeEnumMetaClass.Name" /></summary>
		public const string NAME = "FunctionalModeEnum";
		/// <summary>Constant value for <see cref="FunctionalModeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="FunctionalModeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="FunctionalModeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(FunctionalModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		PRODUCTION,
		SETUP,
		TEARDOWN,
		MAINTENANCE,
		PROCESS_DEVELOPMENT,
		};

		private PRODUCTIONValue _PRODUCTION;
		/// <inheritdoc cref="PRODUCTIONValue" path="/summary" />
		public PRODUCTIONValue PRODUCTION => _PRODUCTION ?? (_PRODUCTION = new PRODUCTIONValue());

		/// <summary>﻿<see cref="Component">Component</see> is currently producing product, ready to produce product, or its current intended use is to be producing product.<br /><br /><br />
		/// Value for FunctionalModeEnum.<br/>
		/// <br/>See also <seealso cref="FunctionalModeEnum">FunctionalModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class PRODUCTIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PRODUCTIONValue.Name" /></summary>
			public const string NAME = "PRODUCTION";
			/// <summary>Constant value for <see cref="PRODUCTIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PRODUCTIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PRODUCTIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} is currently producing product, ready to produce product, or its current intended use is to be producing product.&#10;
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

		/// <summary>﻿<see cref="Component">Component</see> is not currently producing product. <br /><br />It is being prepared or modified to begin production of product.<br /><br /><br />
		/// Value for FunctionalModeEnum.<br/>
		/// <br/>See also <seealso cref="FunctionalModeEnum">FunctionalModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class SETUPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SETUPValue.Name" /></summary>
			public const string NAME = "SETUP";
			/// <summary>Constant value for <see cref="SETUPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="SETUPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SETUPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} is not currently producing product. 

It is being prepared or modified to begin production of product.&#10;
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
		private TEARDOWNValue _TEARDOWN;
		/// <inheritdoc cref="TEARDOWNValue" path="/summary" />
		public TEARDOWNValue TEARDOWN => _TEARDOWN ?? (_TEARDOWN = new TEARDOWNValue());

		/// <summary>﻿<see cref="Component">Component</see> is not currently producing product.<br /><br />Typically, it has completed the production of a product and is being modified or returned to a neutral state such that it may then be prepared to begin production of a different product.<br /><br /><br />
		/// Value for FunctionalModeEnum.<br/>
		/// <br/>See also <seealso cref="FunctionalModeEnum">FunctionalModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class TEARDOWNValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TEARDOWNValue.Name" /></summary>
			public const string NAME = "TEARDOWN";
			/// <summary>Constant value for <see cref="TEARDOWNValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="TEARDOWNValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TEARDOWNValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} is not currently producing product.

Typically, it has completed the production of a product and is being modified or returned to a neutral state such that it may then be prepared to begin production of a different product.&#10;
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

		/// <summary>﻿<see cref="Component">Component</see> is not currently producing product.<br /><br />It is currently being repaired, waiting to be repaired, or has not yet been returned to a normal production status after maintenance has been performed.<br /><br /><br />
		/// Value for FunctionalModeEnum.<br/>
		/// <br/>See also <seealso cref="FunctionalModeEnum">FunctionalModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class MAINTENANCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MAINTENANCEValue.Name" /></summary>
			public const string NAME = "MAINTENANCE";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} is not currently producing product.

It is currently being repaired, waiting to be repaired, or has not yet been returned to a normal production status after maintenance has been performed.&#10;
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
		private PROCESS_DEVELOPMENTValue _PROCESS_DEVELOPMENT;
		/// <inheritdoc cref="PROCESS_DEVELOPMENTValue" path="/summary" />
		public PROCESS_DEVELOPMENTValue PROCESS_DEVELOPMENT => _PROCESS_DEVELOPMENT ?? (_PROCESS_DEVELOPMENT = new PROCESS_DEVELOPMENTValue());

		/// <summary>﻿<see cref="Component">Component</see> is being used to prove-out a new process, testing of equipment or processes, or any other active use that does not result in the production of product.<br /><br /><br />
		/// Value for FunctionalModeEnum.<br/>
		/// <br/>See also <seealso cref="FunctionalModeEnum">FunctionalModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESS_DEVELOPMENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESS_DEVELOPMENTValue.Name" /></summary>
			public const string NAME = "PROCESS_DEVELOPMENT";
			/// <summary>Constant value for <see cref="PROCESS_DEVELOPMENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PROCESS_DEVELOPMENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESS_DEVELOPMENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} is being used to prove-out a new process, testing of equipment or processes, or any other active use that does not result in the production of product.&#10;
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