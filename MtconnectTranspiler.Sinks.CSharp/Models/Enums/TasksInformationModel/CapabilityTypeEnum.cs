#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="CapabilityTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622723044206_884589_3064";
		/// <summary>Constant value for <see cref="CapabilityTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622723044206_884589_3064";
		/// <summary>Constant value for <see cref="CapabilityTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "CapabilityTypeEnum";
		/// <summary>Constant value for <see cref="CapabilityTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="CapabilityTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="CapabilityTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(CapabilityTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
			/// <summary>Constant value for <see cref="REACHValue.Name" /></summary>
			public const string NAME = "REACH";
			/// <summary>Constant value for <see cref="REACHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="REACHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="REACHValue.Summary" /></summary>
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
		private LOADValue _LOAD;
		/// <inheritdoc cref="LOADValue" path="/summary" />
		public LOADValue LOAD => _LOAD ?? (_LOAD = new LOADValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		
		public sealed class LOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOADValue.Name" /></summary>
			public const string NAME = "LOAD";
			/// <summary>Constant value for <see cref="LOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="LOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOADValue.Summary" /></summary>
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
		private CAPACITYValue _CAPACITY;
		/// <inheritdoc cref="CAPACITYValue" path="/summary" />
		public CAPACITYValue CAPACITY => _CAPACITY ?? (_CAPACITY = new CAPACITYValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		
		public sealed class CAPACITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CAPACITYValue.Name" /></summary>
			public const string NAME = "CAPACITY";
			/// <summary>Constant value for <see cref="CAPACITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="CAPACITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CAPACITYValue.Summary" /></summary>
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
		private VOLUMEValue _VOLUME;
		/// <inheritdoc cref="VOLUMEValue" path="/summary" />
		public VOLUMEValue VOLUME => _VOLUME ?? (_VOLUME = new VOLUMEValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		
		public sealed class VOLUMEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VOLUMEValue.Name" /></summary>
			public const string NAME = "VOLUME";
			/// <summary>Constant value for <see cref="VOLUMEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="VOLUMEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VOLUMEValue.Summary" /></summary>
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
		private ROTARY_VELOCITYValue _ROTARY_VELOCITY;
		/// <inheritdoc cref="ROTARY_VELOCITYValue" path="/summary" />
		public ROTARY_VELOCITYValue ROTARY_VELOCITY => _ROTARY_VELOCITY ?? (_ROTARY_VELOCITY = new ROTARY_VELOCITYValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		
		public sealed class ROTARY_VELOCITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ROTARY_VELOCITYValue.Name" /></summary>
			public const string NAME = "ROTARY_VELOCITY";
			/// <summary>Constant value for <see cref="ROTARY_VELOCITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="ROTARY_VELOCITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ROTARY_VELOCITYValue.Summary" /></summary>
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
		private TOLERANCEValue _TOLERANCE;
		/// <inheritdoc cref="TOLERANCEValue" path="/summary" />
		public TOLERANCEValue TOLERANCE => _TOLERANCE ?? (_TOLERANCE = new TOLERANCEValue());

		/// <summary>﻿
		/// Value for CapabilityTypeEnum.<br/>
		/// <br/>See also <seealso cref="CapabilityTypeEnum">CapabilityTypeEnum</seealso>
		/// </summary>
		
		public sealed class TOLERANCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOLERANCEValue.Name" /></summary>
			public const string NAME = "TOLERANCE";
			/// <summary>Constant value for <see cref="TOLERANCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="TOLERANCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOLERANCEValue.Summary" /></summary>
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