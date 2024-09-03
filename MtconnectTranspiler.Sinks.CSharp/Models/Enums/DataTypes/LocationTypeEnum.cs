#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		SPINDLE,
		/// <summary>﻿location for a tool awaiting transfer from a tool magazine to spindle or a turret.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		TRANSFER_POT,
		/// <summary>﻿location for a tool removed from a <i>spindle</i> or turret and awaiting return to a tool magazine.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		RETURN_POT,
		/// <summary>﻿location for a tool awaiting transfer to a tool magazine or turret from outside of the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		STAGING_POT,
		/// <summary>﻿location for a tool removed from a tool magazine or turret awaiting transfer to a location outside of the piece of equipment.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		REMOVAL_POT,
		/// <summary>﻿location for a tool that is no longer usable and is awaiting removal from a tool magazine or turret.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		EXPIRED_POT,
		/// <summary>﻿location associated with an end effector.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
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
		/// <summary>Constant value for <see cref="LocationTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_0167FC5F_C61F_4bc7_A1B3_C724FE8865BA";
		/// <summary>Constant value for <see cref="LocationTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_0167FC5F_C61F_4bc7_A1B3_C724FE8865BA";
		/// <summary>Constant value for <see cref="LocationTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "LocationTypeEnum";
		/// <summary>Constant value for <see cref="LocationTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="LocationTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="LocationTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(LocationTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POTValue.Name" /></summary>
			public const string NAME = "POT";
			/// <summary>Constant value for <see cref="POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;number of the pot in the tool handling system.&#10;
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
		private STATIONValue _STATION;
		/// <inheritdoc cref="STATIONValue" path="/summary" />
		public STATIONValue STATION => _STATION ?? (_STATION = new STATIONValue());

		/// <summary>﻿tool location in a horizontal turning machine.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class STATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STATIONValue.Name" /></summary>
			public const string NAME = "STATION";
			/// <summary>Constant value for <see cref="STATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="STATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool location in a horizontal turning machine.&#10;
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
		private CRIBValue _CRIB;
		/// <inheritdoc cref="CRIBValue" path="/summary" />
		public CRIBValue CRIB => _CRIB ?? (_CRIB = new CRIBValue());

		/// <summary>﻿location with regard to a tool crib.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class CRIBValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CRIBValue.Name" /></summary>
			public const string NAME = "CRIB";
			/// <summary>Constant value for <see cref="CRIBValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="CRIBValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CRIBValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;location with regard to a tool crib.&#10;
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
		private SPINDLEValue _SPINDLE;
		/// <inheritdoc cref="SPINDLEValue" path="/summary" />
		public SPINDLEValue SPINDLE => _SPINDLE ?? (_SPINDLE = new SPINDLEValue());

		/// <summary>﻿location associated with a <i>spindle</i>.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class SPINDLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SPINDLEValue.Name" /></summary>
			public const string NAME = "SPINDLE";
			/// <summary>Constant value for <see cref="SPINDLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="SPINDLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SPINDLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;location associated with a {{term(spindle)}}.&#10;
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
		private TRANSFER_POTValue _TRANSFER_POT;
		/// <inheritdoc cref="TRANSFER_POTValue" path="/summary" />
		public TRANSFER_POTValue TRANSFER_POT => _TRANSFER_POT ?? (_TRANSFER_POT = new TRANSFER_POTValue());

		/// <summary>﻿location for a tool awaiting transfer from a tool magazine to spindle or a turret.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class TRANSFER_POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TRANSFER_POTValue.Name" /></summary>
			public const string NAME = "TRANSFER_POT";
			/// <summary>Constant value for <see cref="TRANSFER_POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="TRANSFER_POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TRANSFER_POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;location for a tool awaiting transfer from a tool magazine to spindle or a turret.&#10;
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
		private RETURN_POTValue _RETURN_POT;
		/// <inheritdoc cref="RETURN_POTValue" path="/summary" />
		public RETURN_POTValue RETURN_POT => _RETURN_POT ?? (_RETURN_POT = new RETURN_POTValue());

		/// <summary>﻿location for a tool removed from a <i>spindle</i> or turret and awaiting return to a tool magazine.<br /><br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class RETURN_POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RETURN_POTValue.Name" /></summary>
			public const string NAME = "RETURN_POT";
			/// <summary>Constant value for <see cref="RETURN_POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="RETURN_POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RETURN_POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;location for a tool removed from a {{term(spindle)}} or turret and awaiting return to a tool magazine.&#10;
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
		private STAGING_POTValue _STAGING_POT;
		/// <inheritdoc cref="STAGING_POTValue" path="/summary" />
		public STAGING_POTValue STAGING_POT => _STAGING_POT ?? (_STAGING_POT = new STAGING_POTValue());

		/// <summary>﻿location for a tool awaiting transfer to a tool magazine or turret from outside of the piece of equipment.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class STAGING_POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STAGING_POTValue.Name" /></summary>
			public const string NAME = "STAGING_POT";
			/// <summary>Constant value for <see cref="STAGING_POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="STAGING_POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STAGING_POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;location for a tool awaiting transfer to a tool magazine or turret from outside of the piece of equipment.&#10;
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
		private REMOVAL_POTValue _REMOVAL_POT;
		/// <inheritdoc cref="REMOVAL_POTValue" path="/summary" />
		public REMOVAL_POTValue REMOVAL_POT => _REMOVAL_POT ?? (_REMOVAL_POT = new REMOVAL_POTValue());

		/// <summary>﻿location for a tool removed from a tool magazine or turret awaiting transfer to a location outside of the piece of equipment.<br /><br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class REMOVAL_POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="REMOVAL_POTValue.Name" /></summary>
			public const string NAME = "REMOVAL_POT";
			/// <summary>Constant value for <see cref="REMOVAL_POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="REMOVAL_POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="REMOVAL_POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;location for a tool removed from a tool magazine or turret awaiting transfer to a location outside of the piece of equipment.&#10;
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
		private EXPIRED_POTValue _EXPIRED_POT;
		/// <inheritdoc cref="EXPIRED_POTValue" path="/summary" />
		public EXPIRED_POTValue EXPIRED_POT => _EXPIRED_POT ?? (_EXPIRED_POT = new EXPIRED_POTValue());

		/// <summary>﻿location for a tool that is no longer usable and is awaiting removal from a tool magazine or turret.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class EXPIRED_POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EXPIRED_POTValue.Name" /></summary>
			public const string NAME = "EXPIRED_POT";
			/// <summary>Constant value for <see cref="EXPIRED_POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="EXPIRED_POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EXPIRED_POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;location for a tool that is no longer usable and is awaiting removal from a tool magazine or turret.&#10;
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
		private END_EFFECTORValue _END_EFFECTOR;
		/// <inheritdoc cref="END_EFFECTORValue" path="/summary" />
		public END_EFFECTORValue END_EFFECTOR => _END_EFFECTOR ?? (_END_EFFECTOR = new END_EFFECTORValue());

		/// <summary>﻿location associated with an end effector.<br /><br /><br />
		/// Value for LocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="LocationTypeEnum">LocationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class END_EFFECTORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="END_EFFECTORValue.Name" /></summary>
			public const string NAME = "END_EFFECTOR";
			/// <summary>Constant value for <see cref="END_EFFECTORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="END_EFFECTORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="END_EFFECTORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;location associated with an end effector.&#10;
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