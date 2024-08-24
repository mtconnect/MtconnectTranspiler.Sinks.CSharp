#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="CollaboratorTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622723031886_684761_3039";
		/// <summary>Constant value for <see cref="CollaboratorTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622723031886_684761_3039";
		/// <summary>Constant value for <see cref="CollaboratorTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "CollaboratorTypeEnum";
		/// <summary>Constant value for <see cref="CollaboratorTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="CollaboratorTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="CollaboratorTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(CollaboratorTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
			/// <summary>Constant value for <see cref="ROBOTValue.Name" /></summary>
			public const string NAME = "ROBOT";
			/// <summary>Constant value for <see cref="ROBOTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="ROBOTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ROBOTValue.Summary" /></summary>
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
		private CONVEYORValue _CONVEYOR;
		/// <inheritdoc cref="CONVEYORValue" path="/summary" />
		public CONVEYORValue CONVEYOR => _CONVEYOR ?? (_CONVEYOR = new CONVEYORValue());

		/// <summary>﻿
		/// Value for CollaboratorTypeEnum.<br/>
		/// <br/>See also <seealso cref="CollaboratorTypeEnum">CollaboratorTypeEnum</seealso>
		/// </summary>
		
		public sealed class CONVEYORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONVEYORValue.Name" /></summary>
			public const string NAME = "CONVEYOR";
			/// <summary>Constant value for <see cref="CONVEYORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="CONVEYORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONVEYORValue.Summary" /></summary>
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
		private CNCValue _CNC;
		/// <inheritdoc cref="CNCValue" path="/summary" />
		public CNCValue CNC => _CNC ?? (_CNC = new CNCValue());

		/// <summary>﻿
		/// Value for CollaboratorTypeEnum.<br/>
		/// <br/>See also <seealso cref="CollaboratorTypeEnum">CollaboratorTypeEnum</seealso>
		/// </summary>
		
		public sealed class CNCValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CNCValue.Name" /></summary>
			public const string NAME = "CNC";
			/// <summary>Constant value for <see cref="CNCValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="CNCValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CNCValue.Summary" /></summary>
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
		private BUFFERValue _BUFFER;
		/// <inheritdoc cref="BUFFERValue" path="/summary" />
		public BUFFERValue BUFFER => _BUFFER ?? (_BUFFER = new BUFFERValue());

		/// <summary>﻿
		/// Value for CollaboratorTypeEnum.<br/>
		/// <br/>See also <seealso cref="CollaboratorTypeEnum">CollaboratorTypeEnum</seealso>
		/// </summary>
		
		public sealed class BUFFERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BUFFERValue.Name" /></summary>
			public const string NAME = "BUFFER";
			/// <summary>Constant value for <see cref="BUFFERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="BUFFERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BUFFERValue.Summary" /></summary>
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