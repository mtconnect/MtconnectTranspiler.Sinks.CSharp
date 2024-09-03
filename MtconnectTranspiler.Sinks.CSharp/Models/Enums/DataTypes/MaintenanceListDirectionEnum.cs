#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640604423161_7561_376">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum MaintenanceListDirectionEnum
	{
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		UP,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		DOWN,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640604423161_7561_376">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MaintenanceListDirectionEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="MaintenanceListDirectionEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1640604423161_7561_376";
		/// <summary>Constant value for <see cref="MaintenanceListDirectionEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640604423161_7561_376";
		/// <summary>Constant value for <see cref="MaintenanceListDirectionEnumMetaClass.Name" /></summary>
		public const string NAME = "MaintenanceListDirectionEnum";
		/// <summary>Constant value for <see cref="MaintenanceListDirectionEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.0";
		/// <summary>Constant value for <see cref="MaintenanceListDirectionEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="MaintenanceListDirectionEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(MaintenanceListDirectionEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		UP,
		DOWN,
		};

		private UPValue _UP;
		/// <inheritdoc cref="UPValue" path="/summary" />
		public UPValue UP => _UP ?? (_UP = new UPValue());

		/// <summary>﻿
		/// Value for MaintenanceListDirectionEnum.<br/>
		/// <br/>See also <seealso cref="MaintenanceListDirectionEnum">MaintenanceListDirectionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class UPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UPValue.Name" /></summary>
			public const string NAME = "UP";
			/// <summary>Constant value for <see cref="UPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="UPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UPValue.Summary" /></summary>
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
		private DOWNValue _DOWN;
		/// <inheritdoc cref="DOWNValue" path="/summary" />
		public DOWNValue DOWN => _DOWN ?? (_DOWN = new DOWNValue());

		/// <summary>﻿
		/// Value for MaintenanceListDirectionEnum.<br/>
		/// <br/>See also <seealso cref="MaintenanceListDirectionEnum">MaintenanceListDirectionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DOWNValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DOWNValue.Name" /></summary>
			public const string NAME = "DOWN";
			/// <summary>Constant value for <see cref="DOWNValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="DOWNValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DOWNValue.Summary" /></summary>
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