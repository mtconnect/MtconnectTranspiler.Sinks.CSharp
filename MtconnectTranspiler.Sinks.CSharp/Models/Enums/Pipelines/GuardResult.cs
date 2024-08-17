#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AgentArchitecture.Pipelines
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
		/// <inheritdoc />
		public string Name => "GuardResult";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(GuardResult);

		/// <inheritdoc />
		public string NormativeVersion => "";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
			/// <inheritdoc />
			public string Name => "CONTINUE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
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
			/// <inheritdoc />
			public string Name => "SKIP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
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
			/// <inheritdoc />
			public string Name => "RUN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
	}
}