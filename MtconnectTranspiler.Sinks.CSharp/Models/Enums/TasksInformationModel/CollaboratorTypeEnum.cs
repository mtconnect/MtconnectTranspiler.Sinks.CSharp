using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622723031886_684761_3039">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CollaboratorTypeEnum
	{
		/// <summary>
		﻿
		/// </summary>
		ROBOT,
		/// <summary>
		﻿
		/// </summary>
		CONVEYOR,
		/// <summary>
		﻿
		/// </summary>
		CNC,
		/// <summary>
		﻿
		/// </summary>
		BUFFER,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622723031886_684761_3039">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CollaboratorTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CollaboratorTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(CollaboratorTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ROBOT,
		CONVEYOR,
		CNC,
		BUFFER,
		};

		private ROBOTValue _ROBOT;
		public ROBOTValue ROBOT => _ROBOT ?? (_ROBOT = new ROBOTValue());

		public sealed class ROBOTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ROBOT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private CONVEYORValue _CONVEYOR;
		public CONVEYORValue CONVEYOR => _CONVEYOR ?? (_CONVEYOR = new CONVEYORValue());

		public sealed class CONVEYORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONVEYOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private CNCValue _CNC;
		public CNCValue CNC => _CNC ?? (_CNC = new CNCValue());

		public sealed class CNCValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CNC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private BUFFERValue _BUFFER;
		public BUFFERValue BUFFER => _BUFFER ?? (_BUFFER = new BUFFERValue());

		public sealed class BUFFERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BUFFER";
			
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