using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1623845159692_780642_2366">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ResponseStateEnum
	{
		/// <summary>
		/// <i>responder</i> is not ready to perform a service.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		NOT_READY,
		/// <summary>
		/// <i>responder</i> is prepared to react to a <i>request</i>, but no <i>request</i> for service has been detected.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		READY,
		/// <summary>
		/// <i>responder</i> has detected and accepted a <i>request</i> for a service and is in the process of performing the service, but the service has not yet been completed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>
		/// <i>responder</i> has completed the actions required to perform the service.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		COMPLETE,
		/// <summary>
		/// <i>responder</i> has detected a failure condition.
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
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
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
		/// <i>responder</i> is not ready to perform a service.
		/// </summary>
		public NOT_READYValue NOT_READY => _NOT_READY ?? (_NOT_READY = new NOT_READYValue());

		/// <summary>
		/// <i>responder</i> is not ready to perform a service.
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
			public string Summary => @"/// <i>responder</i> is not ready to perform a service.";
		}
		private READYValue _READY;
		/// <summary>
		/// <i>responder</i> is prepared to react to a <i>request</i>, but no <i>request</i> for service has been detected.
		/// </summary>
		public READYValue READY => _READY ?? (_READY = new READYValue());

		/// <summary>
		/// <i>responder</i> is prepared to react to a <i>request</i>, but no <i>request</i> for service has been detected.
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
			public string Summary => @"/// <i>responder</i> is prepared to react to a <i>request</i>, but no <i>request</i> for service has been detected.";
		}
		private ACTIVEValue _ACTIVE;
		/// <summary>
		/// <i>responder</i> has detected and accepted a <i>request</i> for a service and is in the process of performing the service, but the service has not yet been completed.
		/// </summary>
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>
		/// <i>responder</i> has detected and accepted a <i>request</i> for a service and is in the process of performing the service, but the service has not yet been completed.
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
			public string Summary => @"/// <i>responder</i> has detected and accepted a <i>request</i> for a service and is in the process of performing the service, but the service has not yet been completed.";
		}
		private COMPLETEValue _COMPLETE;
		/// <summary>
		/// <i>responder</i> has completed the actions required to perform the service.
		/// </summary>
		public COMPLETEValue COMPLETE => _COMPLETE ?? (_COMPLETE = new COMPLETEValue());

		/// <summary>
		/// <i>responder</i> has completed the actions required to perform the service.
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
			public string Summary => @"/// <i>responder</i> has completed the actions required to perform the service.";
		}
		private FAILValue _FAIL;
		/// <summary>
		/// <i>responder</i> has detected a failure condition.
		/// </summary>
		public FAILValue FAIL => _FAIL ?? (_FAIL = new FAILValue());

		/// <summary>
		/// <i>responder</i> has detected a failure condition.
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
			public string Summary => @"/// <i>responder</i> has detected a failure condition.";
		}
	}
}