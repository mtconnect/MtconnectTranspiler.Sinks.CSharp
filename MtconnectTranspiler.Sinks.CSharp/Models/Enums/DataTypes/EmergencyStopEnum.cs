#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417662_889824_2876">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum EmergencyStopEnum
	{
		/// <summary>﻿emergency stop circuit is complete and the piece of equipment, component, or composition is allowed to operate. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		ARMED,
		/// <summary>﻿operation of the piece of equipment, component, or composition is inhibited.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		TRIGGERED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417662_889824_2876">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EmergencyStopEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="EmergencyStopEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378417662_889824_2876";
		/// <summary>Constant value for <see cref="EmergencyStopEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417662_889824_2876";
		/// <summary>Constant value for <see cref="EmergencyStopEnumMetaClass.Name" /></summary>
		public const string NAME = "EmergencyStopEnum";
		/// <summary>Constant value for <see cref="EmergencyStopEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="EmergencyStopEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="EmergencyStopEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(EmergencyStopEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ARMED,
		TRIGGERED,
		};

		private ARMEDValue _ARMED;
		/// <inheritdoc cref="ARMEDValue" path="/summary" />
		public ARMEDValue ARMED => _ARMED ?? (_ARMED = new ARMEDValue());

		/// <summary>﻿emergency stop circuit is complete and the piece of equipment, component, or composition is allowed to operate. <br /><br /><br />
		/// Value for EmergencyStopEnum.<br/>
		/// <br/>See also <seealso cref="EmergencyStopEnum">EmergencyStopEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class ARMEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ARMEDValue.Name" /></summary>
			public const string NAME = "ARMED";
			/// <summary>Constant value for <see cref="ARMEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="ARMEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ARMEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;emergency stop circuit is complete and the piece of equipment, component, or composition is allowed to operate. &#10;
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
		private TRIGGEREDValue _TRIGGERED;
		/// <inheritdoc cref="TRIGGEREDValue" path="/summary" />
		public TRIGGEREDValue TRIGGERED => _TRIGGERED ?? (_TRIGGERED = new TRIGGEREDValue());

		/// <summary>﻿operation of the piece of equipment, component, or composition is inhibited.<br /><br /><br />
		/// Value for EmergencyStopEnum.<br/>
		/// <br/>See also <seealso cref="EmergencyStopEnum">EmergencyStopEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class TRIGGEREDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TRIGGEREDValue.Name" /></summary>
			public const string NAME = "TRIGGERED";
			/// <summary>Constant value for <see cref="TRIGGEREDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="TRIGGEREDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TRIGGEREDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operation of the piece of equipment, component, or composition is inhibited.&#10;
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