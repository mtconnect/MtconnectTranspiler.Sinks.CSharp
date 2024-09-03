#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ReferenceAgentArchitecture.Pipelines
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_4_45f01b9_1674413987997_312842_3519">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum GuardResult
	{
		/// <summary>﻿
		/// </summary>
		
		CONTINUE,
		/// <summary>﻿
		/// </summary>
		
		SKIP,
		/// <summary>﻿
		/// </summary>
		
		RUN,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_4_45f01b9_1674413987997_312842_3519">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class GuardResultMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="GuardResultMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_4_45f01b9_1674413987997_312842_3519";
		/// <summary>Constant value for <see cref="GuardResultMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_4_45f01b9_1674413987997_312842_3519";
		/// <summary>Constant value for <see cref="GuardResultMetaClass.Name" /></summary>
		public const string NAME = "GuardResult";
		/// <summary>Constant value for <see cref="GuardResultMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="GuardResultMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="GuardResultMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(GuardResult);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CONTINUE,
		SKIP,
		RUN,
		};

		private CONTINUEValue _CONTINUE;
		/// <inheritdoc cref="CONTINUEValue" path="/summary" />
		public CONTINUEValue CONTINUE => _CONTINUE ?? (_CONTINUE = new CONTINUEValue());

		/// <summary>﻿
		/// Value for GuardResult.<br/>
		/// <br/>See also <seealso cref="GuardResult">GuardResult</seealso>
		/// </summary>
		
		public sealed class CONTINUEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONTINUEValue.Name" /></summary>
			public const string NAME = "CONTINUE";
			/// <summary>Constant value for <see cref="CONTINUEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="CONTINUEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONTINUEValue.Summary" /></summary>
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
		private SKIPValue _SKIP;
		/// <inheritdoc cref="SKIPValue" path="/summary" />
		public SKIPValue SKIP => _SKIP ?? (_SKIP = new SKIPValue());

		/// <summary>﻿
		/// Value for GuardResult.<br/>
		/// <br/>See also <seealso cref="GuardResult">GuardResult</seealso>
		/// </summary>
		
		public sealed class SKIPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SKIPValue.Name" /></summary>
			public const string NAME = "SKIP";
			/// <summary>Constant value for <see cref="SKIPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="SKIPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SKIPValue.Summary" /></summary>
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
		private RUNValue _RUN;
		/// <inheritdoc cref="RUNValue" path="/summary" />
		public RUNValue RUN => _RUN ?? (_RUN = new RUNValue());

		/// <summary>﻿
		/// Value for GuardResult.<br/>
		/// <br/>See also <seealso cref="GuardResult">GuardResult</seealso>
		/// </summary>
		
		public sealed class RUNValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RUNValue.Name" /></summary>
			public const string NAME = "RUN";
			/// <summary>Constant value for <see cref="RUNValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="RUNValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RUNValue.Summary" /></summary>
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