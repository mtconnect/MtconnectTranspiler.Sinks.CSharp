#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622723044206_884589_3064">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CapabilityTypeEnum
	{
		/// <summary>﻿
		/// </summary>
		REACH,
		/// <summary>﻿
		/// </summary>
		LOAD,
		/// <summary>﻿
		/// </summary>
		CAPACITY,
		/// <summary>﻿
		/// </summary>
		VOLUME,
		/// <summary>﻿
		/// </summary>
		ROTARY_VELOCITY,
		/// <summary>﻿
		/// </summary>
		TOLERANCE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622723044206_884589_3064">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CapabilityTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CapabilityTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CapabilityTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		REACH,
		LOAD,
		CAPACITY,
		VOLUME,
		ROTARY_VELOCITY,
		TOLERANCE,
		};

		private REACHValue _REACH;
		/// <inheritdoc cref="REACHValue" path="/summary" />
		public REACHValue REACH => _REACH ?? (_REACH = new REACHValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		public sealed class REACHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REACH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private LOADValue _LOAD;
		/// <inheritdoc cref="LOADValue" path="/summary" />
		public LOADValue LOAD => _LOAD ?? (_LOAD = new LOADValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		public sealed class LOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private CAPACITYValue _CAPACITY;
		/// <inheritdoc cref="CAPACITYValue" path="/summary" />
		public CAPACITYValue CAPACITY => _CAPACITY ?? (_CAPACITY = new CAPACITYValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		public sealed class CAPACITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CAPACITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private VOLUMEValue _VOLUME;
		/// <inheritdoc cref="VOLUMEValue" path="/summary" />
		public VOLUMEValue VOLUME => _VOLUME ?? (_VOLUME = new VOLUMEValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		public sealed class VOLUMEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VOLUME";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private ROTARY_VELOCITYValue _ROTARY_VELOCITY;
		/// <inheritdoc cref="ROTARY_VELOCITYValue" path="/summary" />
		public ROTARY_VELOCITYValue ROTARY_VELOCITY => _ROTARY_VELOCITY ?? (_ROTARY_VELOCITY = new ROTARY_VELOCITYValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		public sealed class ROTARY_VELOCITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ROTARY_VELOCITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private TOLERANCEValue _TOLERANCE;
		/// <inheritdoc cref="TOLERANCEValue" path="/summary" />
		public TOLERANCEValue TOLERANCE => _TOLERANCE ?? (_TOLERANCE = new TOLERANCEValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		public sealed class TOLERANCEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOLERANCE";
			
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