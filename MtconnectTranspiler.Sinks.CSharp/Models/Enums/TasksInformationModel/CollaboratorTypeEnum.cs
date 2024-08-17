#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622723031886_684761_3039">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CollaboratorTypeEnum
	{
		/// <summary>﻿
		/// </summary>
		ROBOT,
		/// <summary>﻿
		/// </summary>
		CONVEYOR,
		/// <summary>﻿
		/// </summary>
		CNC,
		/// <summary>﻿
		/// </summary>
		BUFFER,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622723031886_684761_3039">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CollaboratorTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CollaboratorTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="ROBOTValue" path="/summary" />
		public ROBOTValue ROBOT => _ROBOT ?? (_ROBOT = new ROBOTValue());

		/// <summary>﻿
		/// Value for CollaboratorTypeEnum.<br/>
		/// <br/>See also <seealso cref="CollaboratorTypeEnum">CollaboratorTypeEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="CONVEYORValue" path="/summary" />
		public CONVEYORValue CONVEYOR => _CONVEYOR ?? (_CONVEYOR = new CONVEYORValue());

		/// <summary>﻿
		/// Value for CollaboratorTypeEnum.<br/>
		/// <br/>See also <seealso cref="CollaboratorTypeEnum">CollaboratorTypeEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="CNCValue" path="/summary" />
		public CNCValue CNC => _CNC ?? (_CNC = new CNCValue());

		/// <summary>﻿
		/// Value for CollaboratorTypeEnum.<br/>
		/// <br/>See also <seealso cref="CollaboratorTypeEnum">CollaboratorTypeEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="BUFFERValue" path="/summary" />
		public BUFFERValue BUFFER => _BUFFER ?? (_BUFFER = new BUFFERValue());

		/// <summary>﻿
		/// Value for CollaboratorTypeEnum.<br/>
		/// <br/>See also <seealso cref="CollaboratorTypeEnum">CollaboratorTypeEnum</seealso>
		/// </summary>
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