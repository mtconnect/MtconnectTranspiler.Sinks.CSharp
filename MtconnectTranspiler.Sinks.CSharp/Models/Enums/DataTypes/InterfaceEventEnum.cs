#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1646992208875_933134_35">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum InterfaceEventEnum
	{
		/// <summary>﻿operational state of an <see cref="Interface">Interface</see>.<br /><br /><br />
		/// </summary>
		
		INTERFACE_STATE,
		/// <summary>﻿operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.<br /><br /><br />
		/// </summary>
		
		MATERIAL_FEED,
		/// <summary>﻿operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.<br /><br /><br />
		/// </summary>
		
		MATERIAL_CHANGE,
		/// <summary>﻿operating state of the service to remove or retract material or product.<br /><br /><br />
		/// </summary>
		
		MATERIAL_RETRACT,
		/// <summary>﻿operating state of the service to change the part or product associated with a piece of equipment to a different part or product.<br /><br /><br />
		/// </summary>
		
		PART_CHANGE,
		/// <summary>﻿operating state of the service to load a piece of material or product.<br /><br /><br />
		/// </summary>
		
		MATERIAL_LOAD,
		/// <summary>﻿operating state of the service to unload a piece of material or product.<br /><br /><br />
		/// </summary>
		
		MATERIAL_UNLOAD,
		/// <summary>﻿operating state of the service to open a chuck.<br /><br /><br />
		/// </summary>
		
		OPEN_CHUCK,
		/// <summary>﻿operating state of the service to open a door.<br /><br /><br />
		/// </summary>
		
		OPEN_DOOR,
		/// <summary>﻿operating state of the service to close a chuck.<br /><br /><br />
		/// </summary>
		
		CLOSE_CHUCK,
		/// <summary>﻿operating state of the service to close a door.<br /><br /><br />
		/// </summary>
		
		CLOSE_DOOR,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1646992208875_933134_35">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class InterfaceEventEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="InterfaceEventEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1646992208875_933134_35";
		/// <summary>Constant value for <see cref="InterfaceEventEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1646992208875_933134_35";
		/// <summary>Constant value for <see cref="InterfaceEventEnumMetaClass.Name" /></summary>
		public const string NAME = "InterfaceEventEnum";
		/// <summary>Constant value for <see cref="InterfaceEventEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="InterfaceEventEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="InterfaceEventEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(InterfaceEventEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		INTERFACE_STATE,
		MATERIAL_FEED,
		MATERIAL_CHANGE,
		MATERIAL_RETRACT,
		PART_CHANGE,
		MATERIAL_LOAD,
		MATERIAL_UNLOAD,
		OPEN_CHUCK,
		OPEN_DOOR,
		CLOSE_CHUCK,
		CLOSE_DOOR,
		};

		private INTERFACE_STATEValue _INTERFACE_STATE;
		/// <inheritdoc cref="INTERFACE_STATEValue" path="/summary" />
		public INTERFACE_STATEValue INTERFACE_STATE => _INTERFACE_STATE ?? (_INTERFACE_STATE = new INTERFACE_STATEValue());

		/// <summary>﻿operational state of an <see cref="Interface">Interface</see>.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class INTERFACE_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INTERFACE_STATEValue.Name" /></summary>
			public const string NAME = "INTERFACE_STATE";
			/// <summary>Constant value for <see cref="INTERFACE_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="INTERFACE_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INTERFACE_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operational state of an {{block(Interface)}}.&#10;
";

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
		private MATERIAL_FEEDValue _MATERIAL_FEED;
		/// <inheritdoc cref="MATERIAL_FEEDValue" path="/summary" />
		public MATERIAL_FEEDValue MATERIAL_FEED => _MATERIAL_FEED ?? (_MATERIAL_FEED = new MATERIAL_FEEDValue());

		/// <summary>﻿operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class MATERIAL_FEEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_FEEDValue.Name" /></summary>
			public const string NAME = "MATERIAL_FEED";
			/// <summary>Constant value for <see cref="MATERIAL_FEEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MATERIAL_FEEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_FEEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.&#10;
";

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
		private MATERIAL_CHANGEValue _MATERIAL_CHANGE;
		/// <inheritdoc cref="MATERIAL_CHANGEValue" path="/summary" />
		public MATERIAL_CHANGEValue MATERIAL_CHANGE => _MATERIAL_CHANGE ?? (_MATERIAL_CHANGE = new MATERIAL_CHANGEValue());

		/// <summary>﻿operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class MATERIAL_CHANGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_CHANGEValue.Name" /></summary>
			public const string NAME = "MATERIAL_CHANGE";
			/// <summary>Constant value for <see cref="MATERIAL_CHANGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MATERIAL_CHANGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_CHANGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.&#10;
";

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
		private MATERIAL_RETRACTValue _MATERIAL_RETRACT;
		/// <inheritdoc cref="MATERIAL_RETRACTValue" path="/summary" />
		public MATERIAL_RETRACTValue MATERIAL_RETRACT => _MATERIAL_RETRACT ?? (_MATERIAL_RETRACT = new MATERIAL_RETRACTValue());

		/// <summary>﻿operating state of the service to remove or retract material or product.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class MATERIAL_RETRACTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_RETRACTValue.Name" /></summary>
			public const string NAME = "MATERIAL_RETRACT";
			/// <summary>Constant value for <see cref="MATERIAL_RETRACTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MATERIAL_RETRACTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_RETRACTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to remove or retract material or product.&#10;
";

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
		private PART_CHANGEValue _PART_CHANGE;
		/// <inheritdoc cref="PART_CHANGEValue" path="/summary" />
		public PART_CHANGEValue PART_CHANGE => _PART_CHANGE ?? (_PART_CHANGE = new PART_CHANGEValue());

		/// <summary>﻿operating state of the service to change the part or product associated with a piece of equipment to a different part or product.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class PART_CHANGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_CHANGEValue.Name" /></summary>
			public const string NAME = "PART_CHANGE";
			/// <summary>Constant value for <see cref="PART_CHANGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PART_CHANGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_CHANGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to change the part or product associated with a piece of equipment to a different part or product.&#10;
";

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
		private MATERIAL_LOADValue _MATERIAL_LOAD;
		/// <inheritdoc cref="MATERIAL_LOADValue" path="/summary" />
		public MATERIAL_LOADValue MATERIAL_LOAD => _MATERIAL_LOAD ?? (_MATERIAL_LOAD = new MATERIAL_LOADValue());

		/// <summary>﻿operating state of the service to load a piece of material or product.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class MATERIAL_LOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.Name" /></summary>
			public const string NAME = "MATERIAL_LOAD";
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to load a piece of material or product.&#10;
";

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

		/// <summary>﻿operating state of the service to unload a piece of material or product.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class MATERIAL_UNLOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.Name" /></summary>
			public const string NAME = "MATERIAL_UNLOAD";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to unload a piece of material or product.&#10;
";

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
		private OPEN_CHUCKValue _OPEN_CHUCK;
		/// <inheritdoc cref="OPEN_CHUCKValue" path="/summary" />
		public OPEN_CHUCKValue OPEN_CHUCK => _OPEN_CHUCK ?? (_OPEN_CHUCK = new OPEN_CHUCKValue());

		/// <summary>﻿operating state of the service to open a chuck.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class OPEN_CHUCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPEN_CHUCKValue.Name" /></summary>
			public const string NAME = "OPEN_CHUCK";
			/// <summary>Constant value for <see cref="OPEN_CHUCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="OPEN_CHUCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPEN_CHUCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to open a chuck.&#10;
";

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
		private OPEN_DOORValue _OPEN_DOOR;
		/// <inheritdoc cref="OPEN_DOORValue" path="/summary" />
		public OPEN_DOORValue OPEN_DOOR => _OPEN_DOOR ?? (_OPEN_DOOR = new OPEN_DOORValue());

		/// <summary>﻿operating state of the service to open a door.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class OPEN_DOORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPEN_DOORValue.Name" /></summary>
			public const string NAME = "OPEN_DOOR";
			/// <summary>Constant value for <see cref="OPEN_DOORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="OPEN_DOORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPEN_DOORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to open a door.&#10;
";

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
		private CLOSE_CHUCKValue _CLOSE_CHUCK;
		/// <inheritdoc cref="CLOSE_CHUCKValue" path="/summary" />
		public CLOSE_CHUCKValue CLOSE_CHUCK => _CLOSE_CHUCK ?? (_CLOSE_CHUCK = new CLOSE_CHUCKValue());

		/// <summary>﻿operating state of the service to close a chuck.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class CLOSE_CHUCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOSE_CHUCKValue.Name" /></summary>
			public const string NAME = "CLOSE_CHUCK";
			/// <summary>Constant value for <see cref="CLOSE_CHUCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="CLOSE_CHUCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CLOSE_CHUCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to close a chuck.&#10;
";

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
		private CLOSE_DOORValue _CLOSE_DOOR;
		/// <inheritdoc cref="CLOSE_DOORValue" path="/summary" />
		public CLOSE_DOORValue CLOSE_DOOR => _CLOSE_DOOR ?? (_CLOSE_DOOR = new CLOSE_DOORValue());

		/// <summary>﻿operating state of the service to close a door.<br /><br /><br />
		/// Value for InterfaceEventEnum.<br/>
		/// <br/>See also <seealso cref="InterfaceEventEnum">InterfaceEventEnum</seealso>
		/// </summary>
		
		public sealed class CLOSE_DOORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOSE_DOORValue.Name" /></summary>
			public const string NAME = "CLOSE_DOOR";
			/// <summary>Constant value for <see cref="CLOSE_DOORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="CLOSE_DOORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CLOSE_DOORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to close a door.&#10;
";

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