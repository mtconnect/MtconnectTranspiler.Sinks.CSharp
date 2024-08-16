using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581143980612_724749_76">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum WaitStateEnum
	{
		/// <summary>
		﻿/// execution is waiting while the equipment is powering up and is not currently available to begin producing parts or products.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		POWERING_UP,
		/// <summary>
		﻿/// execution is waiting while the equipment is powering down but has not fully reached a stopped state.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		POWERING_DOWN,
		/// <summary>
		﻿/// execution is waiting while one or more discrete workpieces are being loaded.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PART_LOAD,
		/// <summary>
		﻿/// execution is waiting while one or more discrete workpieces are being unloaded.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PART_UNLOAD,
		/// <summary>
		﻿/// execution is waiting while a tool or tooling is being loaded.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		TOOL_LOAD,
		/// <summary>
		﻿/// execution is waiting while a tool or tooling is being unloaded.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		TOOL_UNLOAD,
		/// <summary>
		﻿/// execution is waiting while material is being loaded.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MATERIAL_LOAD,
		/// <summary>
		﻿/// execution is waiting while material is being unloaded.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MATERIAL_UNLOAD,
		/// <summary>
		﻿/// execution is waiting while another process is completed before the execution can resume.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		SECONDARY_PROCESS,
		/// <summary>
		﻿/// execution is waiting while the equipment is pausing but the piece of equipment has not yet reached a fully paused state.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PAUSING,
		/// <summary>
		﻿/// execution is waiting while the equipment is resuming the production cycle but has not yet resumed execution.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		RESUMING,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581143980612_724749_76">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class WaitStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "WaitStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(WaitStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.5";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		POWERING_UP,
		POWERING_DOWN,
		PART_LOAD,
		PART_UNLOAD,
		TOOL_LOAD,
		TOOL_UNLOAD,
		MATERIAL_LOAD,
		MATERIAL_UNLOAD,
		SECONDARY_PROCESS,
		PAUSING,
		RESUMING,
		};

		private POWERING_UPValue _POWERING_UP;
		/// <summary>
		﻿/// execution is waiting while the equipment is powering up and is not currently available to begin producing parts or products.<br/><br />

		/// </summary>
		public POWERING_UPValue POWERING_UP => _POWERING_UP ?? (_POWERING_UP = new POWERING_UPValue());

		/// <summary>
		﻿/// execution is waiting while the equipment is powering up and is not currently available to begin producing parts or products.<br/><br />

		/// </summary>
		public sealed class POWERING_UPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POWERING_UP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while the equipment is powering up and is not currently available to begin producing parts or products.&#10;
";
		}
		private POWERING_DOWNValue _POWERING_DOWN;
		/// <summary>
		﻿/// execution is waiting while the equipment is powering down but has not fully reached a stopped state.<br/><br />

		/// </summary>
		public POWERING_DOWNValue POWERING_DOWN => _POWERING_DOWN ?? (_POWERING_DOWN = new POWERING_DOWNValue());

		/// <summary>
		﻿/// execution is waiting while the equipment is powering down but has not fully reached a stopped state.<br/><br />

		/// </summary>
		public sealed class POWERING_DOWNValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POWERING_DOWN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while the equipment is powering down but has not fully reached a stopped state.&#10;
";
		}
		private PART_LOADValue _PART_LOAD;
		/// <summary>
		﻿/// execution is waiting while one or more discrete workpieces are being loaded.<br/><br />

		/// </summary>
		public PART_LOADValue PART_LOAD => _PART_LOAD ?? (_PART_LOAD = new PART_LOADValue());

		/// <summary>
		﻿/// execution is waiting while one or more discrete workpieces are being loaded.<br/><br />

		/// </summary>
		public sealed class PART_LOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_LOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while one or more discrete workpieces are being loaded.&#10;
";
		}
		private PART_UNLOADValue _PART_UNLOAD;
		/// <summary>
		﻿/// execution is waiting while one or more discrete workpieces are being unloaded.<br/><br />

		/// </summary>
		public PART_UNLOADValue PART_UNLOAD => _PART_UNLOAD ?? (_PART_UNLOAD = new PART_UNLOADValue());

		/// <summary>
		﻿/// execution is waiting while one or more discrete workpieces are being unloaded.<br/><br />

		/// </summary>
		public sealed class PART_UNLOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_UNLOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while one or more discrete workpieces are being unloaded.&#10;
";
		}
		private TOOL_LOADValue _TOOL_LOAD;
		/// <summary>
		﻿/// execution is waiting while a tool or tooling is being loaded.<br/><br />

		/// </summary>
		public TOOL_LOADValue TOOL_LOAD => _TOOL_LOAD ?? (_TOOL_LOAD = new TOOL_LOADValue());

		/// <summary>
		﻿/// execution is waiting while a tool or tooling is being loaded.<br/><br />

		/// </summary>
		public sealed class TOOL_LOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL_LOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while a tool or tooling is being loaded.&#10;
";
		}
		private TOOL_UNLOADValue _TOOL_UNLOAD;
		/// <summary>
		﻿/// execution is waiting while a tool or tooling is being unloaded.<br/><br />

		/// </summary>
		public TOOL_UNLOADValue TOOL_UNLOAD => _TOOL_UNLOAD ?? (_TOOL_UNLOAD = new TOOL_UNLOADValue());

		/// <summary>
		﻿/// execution is waiting while a tool or tooling is being unloaded.<br/><br />

		/// </summary>
		public sealed class TOOL_UNLOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL_UNLOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while a tool or tooling is being unloaded.&#10;
";
		}
		private MATERIAL_LOADValue _MATERIAL_LOAD;
		/// <summary>
		﻿/// execution is waiting while material is being loaded.<br/><br />

		/// </summary>
		public MATERIAL_LOADValue MATERIAL_LOAD => _MATERIAL_LOAD ?? (_MATERIAL_LOAD = new MATERIAL_LOADValue());

		/// <summary>
		﻿/// execution is waiting while material is being loaded.<br/><br />

		/// </summary>
		public sealed class MATERIAL_LOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL_LOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while material is being loaded.&#10;
";
		}
		private MATERIAL_UNLOADValue _MATERIAL_UNLOAD;
		/// <summary>
		﻿/// execution is waiting while material is being unloaded.<br/><br />

		/// </summary>
		public MATERIAL_UNLOADValue MATERIAL_UNLOAD => _MATERIAL_UNLOAD ?? (_MATERIAL_UNLOAD = new MATERIAL_UNLOADValue());

		/// <summary>
		﻿/// execution is waiting while material is being unloaded.<br/><br />

		/// </summary>
		public sealed class MATERIAL_UNLOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL_UNLOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while material is being unloaded.&#10;
";
		}
		private SECONDARY_PROCESSValue _SECONDARY_PROCESS;
		/// <summary>
		﻿/// execution is waiting while another process is completed before the execution can resume.<br/><br />

		/// </summary>
		public SECONDARY_PROCESSValue SECONDARY_PROCESS => _SECONDARY_PROCESS ?? (_SECONDARY_PROCESS = new SECONDARY_PROCESSValue());

		/// <summary>
		﻿/// execution is waiting while another process is completed before the execution can resume.<br/><br />

		/// </summary>
		public sealed class SECONDARY_PROCESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SECONDARY_PROCESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while another process is completed before the execution can resume.&#10;
";
		}
		private PAUSINGValue _PAUSING;
		/// <summary>
		﻿/// execution is waiting while the equipment is pausing but the piece of equipment has not yet reached a fully paused state.<br/><br />

		/// </summary>
		public PAUSINGValue PAUSING => _PAUSING ?? (_PAUSING = new PAUSINGValue());

		/// <summary>
		﻿/// execution is waiting while the equipment is pausing but the piece of equipment has not yet reached a fully paused state.<br/><br />

		/// </summary>
		public sealed class PAUSINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PAUSING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while the equipment is pausing but the piece of equipment has not yet reached a fully paused state.&#10;
";
		}
		private RESUMINGValue _RESUMING;
		/// <summary>
		﻿/// execution is waiting while the equipment is resuming the production cycle but has not yet resumed execution.<br/><br />

		/// </summary>
		public RESUMINGValue RESUMING => _RESUMING ?? (_RESUMING = new RESUMINGValue());

		/// <summary>
		﻿/// execution is waiting while the equipment is resuming the production cycle but has not yet resumed execution.<br/><br />

		/// </summary>
		public sealed class RESUMINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RESUMING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execution is waiting while the equipment is resuming the production cycle but has not yet resumed execution.&#10;
";
		}
	}
}