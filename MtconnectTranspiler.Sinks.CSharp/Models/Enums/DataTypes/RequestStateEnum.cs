#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1623845125853_44708_2341">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum RequestStateEnum
	{
		/// <summary>﻿<i>requester</i> is not ready to make a <i>request</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		NOT_READY,
		/// <summary>﻿<i>requester</i> is prepared to make a <i>request</i>, but no <i>request</i> for service is required.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		READY,
		/// <summary>﻿<i>requester</i> has initiated a <i>request</i> for a service and the service has not yet been completed by the <i>responder</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>﻿<i>requester</i> has detected a failure condition.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		FAIL,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1623845125853_44708_2341">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RequestStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "RequestStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(RequestStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.3";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		NOT_READY,
		READY,
		ACTIVE,
		FAIL,
		};

		private NOT_READYValue _NOT_READY;
		/// <inheritdoc cref="NOT_READYValue" path="/summary" />
		public NOT_READYValue NOT_READY => _NOT_READY ?? (_NOT_READY = new NOT_READYValue());

		/// <summary>﻿<i>requester</i> is not ready to make a <i>request</i>.<br /><br /><br />
		/// Value for RequestStateEnum.<br/>
		/// <br/>See also <seealso cref="RequestStateEnum">RequestStateEnum</seealso>
		/// </summary>
		public sealed class NOT_READYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NOT_READY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(requester)}} is not ready to make a {{term(request)}}.&#10;
";
		}
		private READYValue _READY;
		/// <inheritdoc cref="READYValue" path="/summary" />
		public READYValue READY => _READY ?? (_READY = new READYValue());

		/// <summary>﻿<i>requester</i> is prepared to make a <i>request</i>, but no <i>request</i> for service is required.<br /><br /><br />
		/// Value for RequestStateEnum.<br/>
		/// <br/>See also <seealso cref="RequestStateEnum">RequestStateEnum</seealso>
		/// </summary>
		public sealed class READYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "READY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(requester)}} is prepared to make a {{term(request)}}, but no {{term(request)}} for service is required.&#10;
";
		}
		private ACTIVEValue _ACTIVE;
		/// <inheritdoc cref="ACTIVEValue" path="/summary" />
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>﻿<i>requester</i> has initiated a <i>request</i> for a service and the service has not yet been completed by the <i>responder</i>.<br /><br /><br />
		/// Value for RequestStateEnum.<br/>
		/// <br/>See also <seealso cref="RequestStateEnum">RequestStateEnum</seealso>
		/// </summary>
		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(requester)}} has initiated a {{term(request)}} for a service and the service has not yet been completed by the {{term(responder)}}.&#10;
";
		}
		private FAILValue _FAIL;
		/// <inheritdoc cref="FAILValue" path="/summary" />
		public FAILValue FAIL => _FAIL ?? (_FAIL = new FAILValue());

		/// <summary>﻿<i>requester</i> has detected a failure condition.<br /><br /><br />
		/// Value for RequestStateEnum.<br/>
		/// <br/>See also <seealso cref="RequestStateEnum">RequestStateEnum</seealso>
		/// </summary>
		public sealed class FAILValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FAIL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(requester)}} has detected a failure condition.&#10;
";
		}
	}
}