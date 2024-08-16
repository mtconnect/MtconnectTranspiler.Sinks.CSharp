using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622719977582_803160_1892">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum TaskTypeEnum
	{
		/// <summary>
		﻿
		/// </summary>
		MOVE_MATERIAL,
		/// <summary>
		﻿
		/// </summary>
		MATERIAL_UNLOAD,
		/// <summary>
		﻿
		/// </summary>
		TOOL_CHANGE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622719977582_803160_1892">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class TaskTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "TaskTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
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
		public MOVE_MATERIALValue MOVE_MATERIAL => _MOVE_MATERIAL ?? (_MOVE_MATERIAL = new MOVE_MATERIALValue());

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
		public MATERIAL_UNLOADValue MATERIAL_UNLOAD => _MATERIAL_UNLOAD ?? (_MATERIAL_UNLOAD = new MATERIAL_UNLOADValue());

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
		public TOOL_CHANGEValue TOOL_CHANGE => _TOOL_CHANGE ?? (_TOOL_CHANGE = new TOOL_CHANGEValue());

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