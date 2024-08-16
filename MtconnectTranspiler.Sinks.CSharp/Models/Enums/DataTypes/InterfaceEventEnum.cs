using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1646992208875_933134_35">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum InterfaceEventEnum
	{
		/// <summary>
		﻿/// operational state of an <see cref="Interface">Interface</see>.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		INTERFACE_STATE,
		/// <summary>
		﻿/// operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		MATERIAL_FEED,
		/// <summary>
		﻿/// operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		MATERIAL_CHANGE,
		/// <summary>
		﻿/// operating state of the service to remove or retract material or product.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		MATERIAL_RETRACT,
		/// <summary>
		﻿/// operating state of the service to change the part or product associated with a piece of equipment to a different part or product.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PART_CHANGE,
		/// <summary>
		﻿/// operating state of the service to load a piece of material or product.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		MATERIAL_LOAD,
		/// <summary>
		﻿/// operating state of the service to unload a piece of material or product.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		MATERIAL_UNLOAD,
		/// <summary>
		﻿/// operating state of the service to open a chuck.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		OPEN_CHUCK,
		/// <summary>
		﻿/// operating state of the service to open a door.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		OPEN_DOOR,
		/// <summary>
		﻿/// operating state of the service to close a chuck.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		CLOSE_CHUCK,
		/// <summary>
		﻿/// operating state of the service to close a door.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		CLOSE_DOOR,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1646992208875_933134_35">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class InterfaceEventEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "InterfaceEventEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(InterfaceEventEnum);

		/// <inheritdoc />
		public string NormativeVersion => "";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		/// <summary>
		﻿/// operational state of an <see cref="Interface">Interface</see>.<br/><br />

		/// </summary>
		public INTERFACE_STATEValue INTERFACE_STATE => _INTERFACE_STATE ?? (_INTERFACE_STATE = new INTERFACE_STATEValue());

		/// <summary>
		﻿/// operational state of an <see cref="Interface">Interface</see>.<br/><br />

		/// </summary>
		public sealed class INTERFACE_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INTERFACE_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operational state of an {{block(Interface)}}.&#10;
";
		}
		private MATERIAL_FEEDValue _MATERIAL_FEED;
		/// <summary>
		﻿/// operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.<br/><br />

		/// </summary>
		public MATERIAL_FEEDValue MATERIAL_FEED => _MATERIAL_FEED ?? (_MATERIAL_FEED = new MATERIAL_FEEDValue());

		/// <summary>
		﻿/// operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.<br/><br />

		/// </summary>
		public sealed class MATERIAL_FEEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL_FEED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.&#10;
";
		}
		private MATERIAL_CHANGEValue _MATERIAL_CHANGE;
		/// <summary>
		﻿/// operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.<br/><br />

		/// </summary>
		public MATERIAL_CHANGEValue MATERIAL_CHANGE => _MATERIAL_CHANGE ?? (_MATERIAL_CHANGE = new MATERIAL_CHANGEValue());

		/// <summary>
		﻿/// operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.<br/><br />

		/// </summary>
		public sealed class MATERIAL_CHANGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL_CHANGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.&#10;
";
		}
		private MATERIAL_RETRACTValue _MATERIAL_RETRACT;
		/// <summary>
		﻿/// operating state of the service to remove or retract material or product.<br/><br />

		/// </summary>
		public MATERIAL_RETRACTValue MATERIAL_RETRACT => _MATERIAL_RETRACT ?? (_MATERIAL_RETRACT = new MATERIAL_RETRACTValue());

		/// <summary>
		﻿/// operating state of the service to remove or retract material or product.<br/><br />

		/// </summary>
		public sealed class MATERIAL_RETRACTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL_RETRACT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operating state of the service to remove or retract material or product.&#10;
";
		}
		private PART_CHANGEValue _PART_CHANGE;
		/// <summary>
		﻿/// operating state of the service to change the part or product associated with a piece of equipment to a different part or product.<br/><br />

		/// </summary>
		public PART_CHANGEValue PART_CHANGE => _PART_CHANGE ?? (_PART_CHANGE = new PART_CHANGEValue());

		/// <summary>
		﻿/// operating state of the service to change the part or product associated with a piece of equipment to a different part or product.<br/><br />

		/// </summary>
		public sealed class PART_CHANGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_CHANGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operating state of the service to change the part or product associated with a piece of equipment to a different part or product.&#10;
";
		}
		private MATERIAL_LOADValue _MATERIAL_LOAD;
		/// <summary>
		﻿/// operating state of the service to load a piece of material or product.<br/><br />

		/// </summary>
		public MATERIAL_LOADValue MATERIAL_LOAD => _MATERIAL_LOAD ?? (_MATERIAL_LOAD = new MATERIAL_LOADValue());

		/// <summary>
		﻿/// operating state of the service to load a piece of material or product.<br/><br />

		/// </summary>
		public sealed class MATERIAL_LOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL_LOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operating state of the service to load a piece of material or product.&#10;
";
		}
		private MATERIAL_UNLOADValue _MATERIAL_UNLOAD;
		/// <summary>
		﻿/// operating state of the service to unload a piece of material or product.<br/><br />

		/// </summary>
		public MATERIAL_UNLOADValue MATERIAL_UNLOAD => _MATERIAL_UNLOAD ?? (_MATERIAL_UNLOAD = new MATERIAL_UNLOADValue());

		/// <summary>
		﻿/// operating state of the service to unload a piece of material or product.<br/><br />

		/// </summary>
		public sealed class MATERIAL_UNLOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL_UNLOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operating state of the service to unload a piece of material or product.&#10;
";
		}
		private OPEN_CHUCKValue _OPEN_CHUCK;
		/// <summary>
		﻿/// operating state of the service to open a chuck.<br/><br />

		/// </summary>
		public OPEN_CHUCKValue OPEN_CHUCK => _OPEN_CHUCK ?? (_OPEN_CHUCK = new OPEN_CHUCKValue());

		/// <summary>
		﻿/// operating state of the service to open a chuck.<br/><br />

		/// </summary>
		public sealed class OPEN_CHUCKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPEN_CHUCK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operating state of the service to open a chuck.&#10;
";
		}
		private OPEN_DOORValue _OPEN_DOOR;
		/// <summary>
		﻿/// operating state of the service to open a door.<br/><br />

		/// </summary>
		public OPEN_DOORValue OPEN_DOOR => _OPEN_DOOR ?? (_OPEN_DOOR = new OPEN_DOORValue());

		/// <summary>
		﻿/// operating state of the service to open a door.<br/><br />

		/// </summary>
		public sealed class OPEN_DOORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPEN_DOOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operating state of the service to open a door.&#10;
";
		}
		private CLOSE_CHUCKValue _CLOSE_CHUCK;
		/// <summary>
		﻿/// operating state of the service to close a chuck.<br/><br />

		/// </summary>
		public CLOSE_CHUCKValue CLOSE_CHUCK => _CLOSE_CHUCK ?? (_CLOSE_CHUCK = new CLOSE_CHUCKValue());

		/// <summary>
		﻿/// operating state of the service to close a chuck.<br/><br />

		/// </summary>
		public sealed class CLOSE_CHUCKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOSE_CHUCK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operating state of the service to close a chuck.&#10;
";
		}
		private CLOSE_DOORValue _CLOSE_DOOR;
		/// <summary>
		﻿/// operating state of the service to close a door.<br/><br />

		/// </summary>
		public CLOSE_DOORValue CLOSE_DOOR => _CLOSE_DOOR ?? (_CLOSE_DOOR = new CLOSE_DOORValue());

		/// <summary>
		﻿/// operating state of the service to close a door.<br/><br />

		/// </summary>
		public sealed class CLOSE_DOORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOSE_DOOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;operating state of the service to close a door.&#10;
";
		}
	}
}