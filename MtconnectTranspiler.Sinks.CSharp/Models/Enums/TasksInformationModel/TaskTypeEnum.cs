#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622719977582_803160_1892">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum TaskTypeEnum
	{
		/// <summary>﻿
		/// </summary>
		
		MOVE_MATERIAL,
		/// <summary>﻿
		/// </summary>
		
		MATERIAL_UNLOAD,
		/// <summary>﻿
		/// </summary>
		
		TOOL_CHANGE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622719977582_803160_1892">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class TaskTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="TaskTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622719977582_803160_1892";
		/// <summary>Constant value for <see cref="TaskTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622719977582_803160_1892";
		/// <summary>Constant value for <see cref="TaskTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "TaskTypeEnum";
		/// <summary>Constant value for <see cref="TaskTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="TaskTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="TaskTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(TaskTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		MOVE_MATERIAL,
		MATERIAL_UNLOAD,
		TOOL_CHANGE,
		};

		private MOVE_MATERIALValue _MOVE_MATERIAL;
		/// <inheritdoc cref="MOVE_MATERIALValue" path="/summary" />
		public MOVE_MATERIALValue MOVE_MATERIAL => _MOVE_MATERIAL ?? (_MOVE_MATERIAL = new MOVE_MATERIALValue());

		/// <summary>﻿
		/// Value for TaskTypeEnum.<br/>
		/// <br/>See also <seealso cref="TaskTypeEnum">TaskTypeEnum</seealso>
		/// </summary>
		
		public sealed class MOVE_MATERIALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MOVE_MATERIALValue.Name" /></summary>
			public const string NAME = "MOVE_MATERIAL";
			/// <summary>Constant value for <see cref="MOVE_MATERIALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="MOVE_MATERIALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MOVE_MATERIALValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private MATERIAL_UNLOADValue _MATERIAL_UNLOAD;
		/// <inheritdoc cref="MATERIAL_UNLOADValue" path="/summary" />
		public MATERIAL_UNLOADValue MATERIAL_UNLOAD => _MATERIAL_UNLOAD ?? (_MATERIAL_UNLOAD = new MATERIAL_UNLOADValue());

		/// <summary>﻿
		/// Value for TaskTypeEnum.<br/>
		/// <br/>See also <seealso cref="TaskTypeEnum">TaskTypeEnum</seealso>
		/// </summary>
		
		public sealed class MATERIAL_UNLOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.Name" /></summary>
			public const string NAME = "MATERIAL_UNLOAD";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private TOOL_CHANGEValue _TOOL_CHANGE;
		/// <inheritdoc cref="TOOL_CHANGEValue" path="/summary" />
		public TOOL_CHANGEValue TOOL_CHANGE => _TOOL_CHANGE ?? (_TOOL_CHANGE = new TOOL_CHANGEValue());

		/// <summary>﻿
		/// Value for TaskTypeEnum.<br/>
		/// <br/>See also <seealso cref="TaskTypeEnum">TaskTypeEnum</seealso>
		/// </summary>
		
		public sealed class TOOL_CHANGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_CHANGEValue.Name" /></summary>
			public const string NAME = "TOOL_CHANGE";
			/// <summary>Constant value for <see cref="TOOL_CHANGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_CHANGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_CHANGEValue.Summary" /></summary>
			public const string SUMMARY = @"";

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