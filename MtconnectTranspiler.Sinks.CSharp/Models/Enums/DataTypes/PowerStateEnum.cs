#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632489430362_282150_112">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum PowerStateEnum
	{
		/// <summary>﻿source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is present and active.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		ON,
		/// <summary>﻿source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is not present or is disconnected.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		OFF,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632489430362_282150_112">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PowerStateEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="PowerStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1632489430362_282150_112";
		/// <summary>Constant value for <see cref="PowerStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632489430362_282150_112";
		/// <summary>Constant value for <see cref="PowerStateEnumMetaClass.Name" /></summary>
		public const string NAME = "PowerStateEnum";
		/// <summary>Constant value for <see cref="PowerStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="PowerStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="PowerStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(PowerStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ON,
		OFF,
		};

		private ONValue _ON;
		/// <inheritdoc cref="ONValue" path="/summary" />
		public ONValue ON => _ON ?? (_ON = new ONValue());

		/// <summary>﻿source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is present and active.<br /><br /><br />
		/// Value for PowerStateEnum.<br/>
		/// <br/>See also <seealso cref="PowerStateEnum">PowerStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class ONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ONValue.Name" /></summary>
			public const string NAME = "ON";
			/// <summary>Constant value for <see cref="ONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="ONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is present and active.&#10;
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
		private OFFValue _OFF;
		/// <inheritdoc cref="OFFValue" path="/summary" />
		public OFFValue OFF => _OFF ?? (_OFF = new OFFValue());

		/// <summary>﻿source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is not present or is disconnected.<br /><br /><br />
		/// Value for PowerStateEnum.<br/>
		/// <br/>See also <seealso cref="PowerStateEnum">PowerStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class OFFValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OFFValue.Name" /></summary>
			public const string NAME = "OFF";
			/// <summary>Constant value for <see cref="OFFValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="OFFValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OFFValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is not present or is disconnected.&#10;
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