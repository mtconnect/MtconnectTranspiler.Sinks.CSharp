#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_0167FC5F_C61F_4bc7_A1B3_C724FE8865BA">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum LocationTypeEnum
	{
		/// <summary>﻿number of the pot in the tool handling system.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		POT,
		/// <summary>﻿tool location in a horizontal turning machine.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		STATION,
		/// <summary>﻿location with regard to a tool crib.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CRIB,
		/// <summary>﻿location associated with a <i>spindle</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		SPINDLE,
		/// <summary>﻿location for a tool awaiting transfer from a tool magazine to spindle or a turret.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		TRANSFER_POT,
		/// <summary>﻿location for a tool removed from a <i>spindle</i> or turret and awaiting return to a tool magazine.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		RETURN_POT,
		/// <summary>﻿location for a tool awaiting transfer to a tool magazine or turret from outside of the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		STAGING_POT,
		/// <summary>﻿location for a tool removed from a tool magazine or turret awaiting transfer to a location outside of the piece of equipment.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		REMOVAL_POT,
		/// <summary>﻿location for a tool that is no longer usable and is awaiting removal from a tool magazine or turret.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		EXPIRED_POT,
		/// <summary>﻿location associated with an end effector.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		END_EFFECTOR,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_0167FC5F_C61F_4bc7_A1B3_C724FE8865BA">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class LocationTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "LocationTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(LocationTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		POT,
		STATION,
		CRIB,
		SPINDLE,
		TRANSFER_POT,
		RETURN_POT,
		STAGING_POT,
		REMOVAL_POT,
		EXPIRED_POT,
		END_EFFECTOR,
		};

		private POTValue _POT;
		/// <inheritdoc cref="POTValue" path="/summary" />
		public POTValue POT => _POT ?? (_POT = new POTValue());

		/// <summary>﻿number of the pot in the tool handling system.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		public sealed class POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;number of the pot in the tool handling system.&#10;
";
		}
		private STATIONValue _STATION;
		/// <inheritdoc cref="STATIONValue" path="/summary" />
		public STATIONValue STATION => _STATION ?? (_STATION = new STATIONValue());

		/// <summary>﻿tool location in a horizontal turning machine.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		public sealed class STATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool location in a horizontal turning machine.&#10;
";
		}
		private CRIBValue _CRIB;
		/// <inheritdoc cref="CRIBValue" path="/summary" />
		public CRIBValue CRIB => _CRIB ?? (_CRIB = new CRIBValue());

		/// <summary>﻿location with regard to a tool crib.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		public sealed class CRIBValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CRIB";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;location with regard to a tool crib.&#10;
";
		}
		private SPINDLEValue _SPINDLE;
		/// <inheritdoc cref="SPINDLEValue" path="/summary" />
		public SPINDLEValue SPINDLE => _SPINDLE ?? (_SPINDLE = new SPINDLEValue());

		/// <summary>﻿location associated with a <i>spindle</i>.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		public sealed class SPINDLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SPINDLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;location associated with a {{term(spindle)}}.&#10;
";
		}
		private TRANSFER_POTValue _TRANSFER_POT;
		/// <inheritdoc cref="TRANSFER_POTValue" path="/summary" />
		public TRANSFER_POTValue TRANSFER_POT => _TRANSFER_POT ?? (_TRANSFER_POT = new TRANSFER_POTValue());

		/// <summary>﻿location for a tool awaiting transfer from a tool magazine to spindle or a turret.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		public sealed class TRANSFER_POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRANSFER_POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;location for a tool awaiting transfer from a tool magazine to spindle or a turret.&#10;
";
		}
		private RETURN_POTValue _RETURN_POT;
		/// <inheritdoc cref="RETURN_POTValue" path="/summary" />
		public RETURN_POTValue RETURN_POT => _RETURN_POT ?? (_RETURN_POT = new RETURN_POTValue());

		/// <summary>﻿location for a tool removed from a <i>spindle</i> or turret and awaiting return to a tool magazine.<br /><br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		public sealed class RETURN_POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RETURN_POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;location for a tool removed from a {{term(spindle)}} or turret and awaiting return to a tool magazine.&#10;
";
		}
		private STAGING_POTValue _STAGING_POT;
		/// <inheritdoc cref="STAGING_POTValue" path="/summary" />
		public STAGING_POTValue STAGING_POT => _STAGING_POT ?? (_STAGING_POT = new STAGING_POTValue());

		/// <summary>﻿location for a tool awaiting transfer to a tool magazine or turret from outside of the piece of equipment.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		public sealed class STAGING_POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STAGING_POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;location for a tool awaiting transfer to a tool magazine or turret from outside of the piece of equipment.&#10;
";
		}
		private REMOVAL_POTValue _REMOVAL_POT;
		/// <inheritdoc cref="REMOVAL_POTValue" path="/summary" />
		public REMOVAL_POTValue REMOVAL_POT => _REMOVAL_POT ?? (_REMOVAL_POT = new REMOVAL_POTValue());

		/// <summary>﻿location for a tool removed from a tool magazine or turret awaiting transfer to a location outside of the piece of equipment.<br /><br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		public sealed class REMOVAL_POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REMOVAL_POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;location for a tool removed from a tool magazine or turret awaiting transfer to a location outside of the piece of equipment.&#10;
";
		}
		private EXPIRED_POTValue _EXPIRED_POT;
		/// <inheritdoc cref="EXPIRED_POTValue" path="/summary" />
		public EXPIRED_POTValue EXPIRED_POT => _EXPIRED_POT ?? (_EXPIRED_POT = new EXPIRED_POTValue());

		/// <summary>﻿location for a tool that is no longer usable and is awaiting removal from a tool magazine or turret.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		public sealed class EXPIRED_POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXPIRED_POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;location for a tool that is no longer usable and is awaiting removal from a tool magazine or turret.&#10;
";
		}
		private END_EFFECTORValue _END_EFFECTOR;
		/// <inheritdoc cref="END_EFFECTORValue" path="/summary" />
		public END_EFFECTORValue END_EFFECTOR => _END_EFFECTOR ?? (_END_EFFECTOR = new END_EFFECTORValue());

		/// <summary>﻿location associated with an end effector.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		public sealed class END_EFFECTORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "END_EFFECTOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;location associated with an end effector.&#10;
";
		}
	}
}