#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1760879617156_719350_3894">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public enum BindingStateEnum
	{
		/// <summary>﻿default state when the collaborator is yet to bind to a task<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
		/// </list>
		/// </remarks>

		INACTIVE,
		/// <summary>﻿state when a collaborator is ready and expresses interest in all tasks that require its capability<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
		/// </list>
		/// </remarks>

		PREPARING,
		/// <summary>﻿state when a collaborator has successfully bound itself to a task<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
		/// </list>
		/// </remarks>

		COMMITTED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1760879617156_719350_3894">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class BindingStateEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="BindingStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1760879617156_719350_3894";
		/// <summary>Constant value for <see cref="BindingStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___2024x_68e0225_1760879617156_719350_3894";
		/// <summary>Constant value for <see cref="BindingStateEnumMetaClass.Name" /></summary>
		public const string NAME = "BindingStateEnum";
		/// <summary>Constant value for <see cref="BindingStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.7";
		/// <summary>Constant value for <see cref="BindingStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="BindingStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(BindingStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		INACTIVE,
		PREPARING,
		COMMITTED,
		};

		private INACTIVEValue _INACTIVE;
		/// <inheritdoc cref="INACTIVEValue" path="/summary" />
		public INACTIVEValue INACTIVE => _INACTIVE ?? (_INACTIVE = new INACTIVEValue());

		/// <summary>﻿default state when the collaborator is yet to bind to a task<br /><br /><br />
		/// Value for BindingStateEnum.<br/>
		/// <br/>See also <seealso cref="BindingStateEnum">BindingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class INACTIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INACTIVEValue.Name" /></summary>
			public const string NAME = "INACTIVE";
			/// <summary>Constant value for <see cref="INACTIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.7";
			/// <summary>Constant value for <see cref="INACTIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INACTIVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;default state when the collaborator is yet to bind to a task&#10;
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
		private PREPARINGValue _PREPARING;
		/// <inheritdoc cref="PREPARINGValue" path="/summary" />
		public PREPARINGValue PREPARING => _PREPARING ?? (_PREPARING = new PREPARINGValue());

		/// <summary>﻿state when a collaborator is ready and expresses interest in all tasks that require its capability<br /><br /><br />
		/// Value for BindingStateEnum.<br/>
		/// <br/>See also <seealso cref="BindingStateEnum">BindingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class PREPARINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PREPARINGValue.Name" /></summary>
			public const string NAME = "PREPARING";
			/// <summary>Constant value for <see cref="PREPARINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.7";
			/// <summary>Constant value for <see cref="PREPARINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PREPARINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state when a collaborator is ready and expresses interest in all tasks that require its capability&#10;
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
		private COMMITTEDValue _COMMITTED;
		/// <inheritdoc cref="COMMITTEDValue" path="/summary" />
		public COMMITTEDValue COMMITTED => _COMMITTED ?? (_COMMITTED = new COMMITTEDValue());

		/// <summary>﻿state when a collaborator has successfully bound itself to a task<br /><br /><br />
		/// Value for BindingStateEnum.<br/>
		/// <br/>See also <seealso cref="BindingStateEnum">BindingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class COMMITTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMMITTEDValue.Name" /></summary>
			public const string NAME = "COMMITTED";
			/// <summary>Constant value for <see cref="COMMITTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.7";
			/// <summary>Constant value for <see cref="COMMITTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMMITTEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state when a collaborator has successfully bound itself to a task&#10;
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