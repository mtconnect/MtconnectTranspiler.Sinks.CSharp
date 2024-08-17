#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <inheritdoc />
		public string Name => "TaskTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(TaskTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
			/// <inheritdoc />
			public string Name => "MOVE_MATERIAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
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
			/// <inheritdoc />
			public string Name => "MATERIAL_UNLOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
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
			/// <inheritdoc />
			public string Name => "TOOL_CHANGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
	}
}