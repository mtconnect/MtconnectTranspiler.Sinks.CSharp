using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1623845159692_780642_2366">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ResponseStateEnum
	{
		/// <summary>
		﻿/// <i>responder</i> is not ready to perform a service.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		NOT_READY,
		/// <summary>
		﻿/// <i>responder</i> is prepared to react to a <i>request</i>, but no <i>request</i> for service has been detected.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		READY,
		/// <summary>
		﻿/// <i>responder</i> has detected and accepted a <i>request</i> for a service and is in the process of performing the service, but the service has not yet<br />been completed.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>
		﻿/// <i>responder</i> has completed the actions required to perform the service.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		COMPLETE,
		/// <summary>
		﻿/// <i>responder</i> has detected a failure condition.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		FAIL,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1623845159692_780642_2366">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ResponseStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ResponseStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ResponseStateEnum);

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
		COMPLETE,
		FAIL,
		};

		private NOT_READYValue _NOT_READY;
		/// <summary>
		﻿/// <i>responder</i> is not ready to perform a service.<br/><br />

		/// </summary>
		public NOT_READYValue NOT_READY => _NOT_READY ?? (_NOT_READY = new NOT_READYValue());

		/// <summary>
		﻿/// <i>responder</i> is not ready to perform a service.<br/><br />

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
			public string Summary => @"&#10;&#10;&#10;{{term(responder)}} is not ready to perform a service.&#10;
";
		}
		private READYValue _READY;
		/// <summary>
		﻿/// <i>responder</i> is prepared to react to a <i>request</i>, but no <i>request</i> for service has been detected.<br/><br />

		/// </summary>
		public READYValue READY => _READY ?? (_READY = new READYValue());

		/// <summary>
		﻿/// <i>responder</i> is prepared to react to a <i>request</i>, but no <i>request</i> for service has been detected.<br/><br />

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
			public string Summary => @"&#10;&#10;&#10;{{term(responder)}} is prepared to react to a {{term(request)}}, but no {{term(request)}} for service has been detected.&#10;
";
		}
		private ACTIVEValue _ACTIVE;
		/// <summary>
		﻿/// <i>responder</i> has detected and accepted a <i>request</i> for a service and is in the process of performing the service, but the service has not yet<br />been completed.<br/><br />

		/// </summary>
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>
		﻿/// <i>responder</i> has detected and accepted a <i>request</i> for a service and is in the process of performing the service, but the service has not yet<br />been completed.<br/><br />

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
			public string Summary => @"&#10;&#10;&#10;{{term(responder)}} has detected and accepted a {{term(request)}} for a service and is in the process of performing the service, but the service has not yet
been completed.&#10;
";
		}
		private COMPLETEValue _COMPLETE;
		/// <summary>
		﻿/// <i>responder</i> has completed the actions required to perform the service.<br/><br />

		/// </summary>
		public COMPLETEValue COMPLETE => _COMPLETE ?? (_COMPLETE = new COMPLETEValue());

		/// <summary>
		﻿/// <i>responder</i> has completed the actions required to perform the service.<br/><br />

		/// </summary>
		public sealed class COMPLETEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMPLETE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(responder)}} has completed the actions required to perform the service.&#10;
";
		}
		private FAILValue _FAIL;
		/// <summary>
		﻿/// <i>responder</i> has detected a failure condition.<br/><br />

		/// </summary>
		public FAILValue FAIL => _FAIL ?? (_FAIL = new FAILValue());

		/// <summary>
		﻿/// <i>responder</i> has detected a failure condition.<br/><br />

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
			public string Summary => @"&#10;&#10;&#10;{{term(responder)}} has detected a failure condition.&#10;
";
		}
	}
}