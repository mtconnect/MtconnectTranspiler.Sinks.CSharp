using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825603246_243967_772">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ApplicationCategoryEnum
	{
		/// <summary>
		﻿/// files regarding the fully assembled product.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ASSEMBLY,
		/// <summary>
		﻿/// device related files.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DEVICE,
		/// <summary>
		﻿/// files relating to the handling of material.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		HANDLING,
		/// <summary>
		﻿/// files relating to equipment maintenance.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		MAINTENANCE,
		/// <summary>
		﻿/// files relating to a part.<br /><br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART,
		/// <summary>
		﻿/// files related to the manufacturing process.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PROCESS,
		/// <summary>
		﻿/// files related to the quality inspection.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		INSPECTION,
		/// <summary>
		﻿/// files related to the setup of a process.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		SETUP,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825603246_243967_772">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ApplicationCategoryEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ApplicationCategoryEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ApplicationCategoryEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.7";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		/// <summary>
		﻿/// files regarding the fully assembled product.<br/><br />

		/// </summary>
		public ASSEMBLYValue ASSEMBLY => _ASSEMBLY ?? (_ASSEMBLY = new ASSEMBLYValue());

		/// <summary>
		﻿/// files regarding the fully assembled product.<br/><br />

		/// </summary>
		public sealed class ASSEMBLYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ASSEMBLY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;files regarding the fully assembled product.&#10;
";
		}
		private DEVICEValue _DEVICE;
		/// <summary>
		﻿/// device related files.<br/><br />

		/// </summary>
		public DEVICEValue DEVICE => _DEVICE ?? (_DEVICE = new DEVICEValue());

		/// <summary>
		﻿/// device related files.<br/><br />

		/// </summary>
		public sealed class DEVICEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEVICE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;device related files.&#10;
";
		}
		private HANDLINGValue _HANDLING;
		/// <summary>
		﻿/// files relating to the handling of material.<br/><br />

		/// </summary>
		public HANDLINGValue HANDLING => _HANDLING ?? (_HANDLING = new HANDLINGValue());

		/// <summary>
		﻿/// files relating to the handling of material.<br/><br />

		/// </summary>
		public sealed class HANDLINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HANDLING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;files relating to the handling of material.&#10;
";
		}
		private MAINTENANCEValue _MAINTENANCE;
		/// <summary>
		﻿/// files relating to equipment maintenance.<br/><br />

		/// </summary>
		public MAINTENANCEValue MAINTENANCE => _MAINTENANCE ?? (_MAINTENANCE = new MAINTENANCEValue());

		/// <summary>
		﻿/// files relating to equipment maintenance.<br/><br />

		/// </summary>
		public sealed class MAINTENANCEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MAINTENANCE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;files relating to equipment maintenance.&#10;
";
		}
		private PARTValue _PART;
		/// <summary>
		﻿/// files relating to a part.<br /><br/><br />

		/// </summary>
		public PARTValue PART => _PART ?? (_PART = new PARTValue());

		/// <summary>
		﻿/// files relating to a part.<br /><br/><br />

		/// </summary>
		public sealed class PARTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;files relating to a part.&#10;
";
		}
		private PROCESSValue _PROCESS;
		/// <summary>
		﻿/// files related to the manufacturing process.<br/><br />

		/// </summary>
		public PROCESSValue PROCESS => _PROCESS ?? (_PROCESS = new PROCESSValue());

		/// <summary>
		﻿/// files related to the manufacturing process.<br/><br />

		/// </summary>
		public sealed class PROCESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;files related to the manufacturing process.&#10;
";
		}
		private INSPECTIONValue _INSPECTION;
		/// <summary>
		﻿/// files related to the quality inspection.<br/><br />

		/// </summary>
		public INSPECTIONValue INSPECTION => _INSPECTION ?? (_INSPECTION = new INSPECTIONValue());

		/// <summary>
		﻿/// files related to the quality inspection.<br/><br />

		/// </summary>
		public sealed class INSPECTIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INSPECTION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;files related to the quality inspection.&#10;
";
		}
		private SETUPValue _SETUP;
		/// <summary>
		﻿/// files related to the setup of a process.<br/><br />

		/// </summary>
		public SETUPValue SETUP => _SETUP ?? (_SETUP = new SETUPValue());

		/// <summary>
		﻿/// files related to the setup of a process.<br/><br />

		/// </summary>
		public sealed class SETUPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SETUP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;files related to the setup of a process.&#10;
";
		}
	}
}