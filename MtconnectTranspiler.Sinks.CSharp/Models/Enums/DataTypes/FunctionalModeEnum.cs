using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417665_982246_2879">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum FunctionalModeEnum
	{
		/// <summary>
		﻿/// <see cref="Component">Component</see> is currently producing product, ready to produce product, or its current intended use is to be producing product.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PRODUCTION,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product. <br /><br />It is being prepared or modified to begin production of product.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		SETUP,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.<br /><br />Typically, it has completed the production of a product and is being modified or returned to a neutral state such that it may then be prepared to begin production of a different product.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		TEARDOWN,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.<br /><br />It is currently being repaired, waiting to be repaired, or has not yet been returned to a normal production status after maintenance has been performed.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		MAINTENANCE,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is being used to prove-out a new process, testing of equipment or processes, or any other active use that does not result in the production of product.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROCESS_DEVELOPMENT,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417665_982246_2879">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FunctionalModeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "FunctionalModeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(FunctionalModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.3";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		PRODUCTION,
		SETUP,
		TEARDOWN,
		MAINTENANCE,
		PROCESS_DEVELOPMENT,
		};

		private PRODUCTIONValue _PRODUCTION;
		/// <summary>
		﻿/// <see cref="Component">Component</see> is currently producing product, ready to produce product, or its current intended use is to be producing product.<br/><br />

		/// </summary>
		public PRODUCTIONValue PRODUCTION => _PRODUCTION ?? (_PRODUCTION = new PRODUCTIONValue());

		/// <summary>
		﻿/// <see cref="Component">Component</see> is currently producing product, ready to produce product, or its current intended use is to be producing product.<br/><br />

		/// </summary>
		public sealed class PRODUCTIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRODUCTION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} is currently producing product, ready to produce product, or its current intended use is to be producing product.&#10;
";
		}
		private SETUPValue _SETUP;
		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product. <br /><br />It is being prepared or modified to begin production of product.<br/><br />

		/// </summary>
		public SETUPValue SETUP => _SETUP ?? (_SETUP = new SETUPValue());

		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product. <br /><br />It is being prepared or modified to begin production of product.<br/><br />

		/// </summary>
		public sealed class SETUPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SETUP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} is not currently producing product. 

It is being prepared or modified to begin production of product.&#10;
";
		}
		private TEARDOWNValue _TEARDOWN;
		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.<br /><br />Typically, it has completed the production of a product and is being modified or returned to a neutral state such that it may then be prepared to begin production of a different product.<br/><br />

		/// </summary>
		public TEARDOWNValue TEARDOWN => _TEARDOWN ?? (_TEARDOWN = new TEARDOWNValue());

		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.<br /><br />Typically, it has completed the production of a product and is being modified or returned to a neutral state such that it may then be prepared to begin production of a different product.<br/><br />

		/// </summary>
		public sealed class TEARDOWNValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TEARDOWN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} is not currently producing product.

Typically, it has completed the production of a product and is being modified or returned to a neutral state such that it may then be prepared to begin production of a different product.&#10;
";
		}
		private MAINTENANCEValue _MAINTENANCE;
		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.<br /><br />It is currently being repaired, waiting to be repaired, or has not yet been returned to a normal production status after maintenance has been performed.<br/><br />

		/// </summary>
		public MAINTENANCEValue MAINTENANCE => _MAINTENANCE ?? (_MAINTENANCE = new MAINTENANCEValue());

		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.<br /><br />It is currently being repaired, waiting to be repaired, or has not yet been returned to a normal production status after maintenance has been performed.<br/><br />

		/// </summary>
		public sealed class MAINTENANCEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MAINTENANCE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} is not currently producing product.

It is currently being repaired, waiting to be repaired, or has not yet been returned to a normal production status after maintenance has been performed.&#10;
";
		}
		private PROCESS_DEVELOPMENTValue _PROCESS_DEVELOPMENT;
		/// <summary>
		﻿/// <see cref="Component">Component</see> is being used to prove-out a new process, testing of equipment or processes, or any other active use that does not result in the production of product.<br/><br />

		/// </summary>
		public PROCESS_DEVELOPMENTValue PROCESS_DEVELOPMENT => _PROCESS_DEVELOPMENT ?? (_PROCESS_DEVELOPMENT = new PROCESS_DEVELOPMENTValue());

		/// <summary>
		﻿/// <see cref="Component">Component</see> is being used to prove-out a new process, testing of equipment or processes, or any other active use that does not result in the production of product.<br/><br />

		/// </summary>
		public sealed class PROCESS_DEVELOPMENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS_DEVELOPMENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} is being used to prove-out a new process, testing of equipment or processes, or any other active use that does not result in the production of product.&#10;
";
		}
	}
}