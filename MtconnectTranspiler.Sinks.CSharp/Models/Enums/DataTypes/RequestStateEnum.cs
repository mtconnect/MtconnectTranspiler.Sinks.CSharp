using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1623845125853_44708_2341">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum RequestStateEnum
	{
		/// <summary>
		/// <i>requester</i> is not ready to make a <i>request</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		NOT_READY,
		/// <summary>
		/// <i>requester</i> is prepared to make a <i>request</i>, but no <i>request</i> for service is required.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		READY,
		/// <summary>
		/// <i>requester</i> has initiated a <i>request</i> for a service and the service has not yet been completed by the <i>responder</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>
		/// <i>requester</i> has detected a failure condition.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		FAIL,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1623845125853_44708_2341">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class RequestStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "RequestStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
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
		/// <summary>
		/// <i>requester</i> is not ready to make a <i>request</i>.
		/// </summary>
		public NOT_READYValue NOT_READY => _NOT_READY ?? (_NOT_READY = new NOT_READYValue());

		/// <summary>
		/// <i>requester</i> is not ready to make a <i>request</i>.
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
			public string Summary => @"/// <i>requester</i> is not ready to make a <i>request</i>.";
		}
		private READYValue _READY;
		/// <summary>
		/// <i>requester</i> is prepared to make a <i>request</i>, but no <i>request</i> for service is required.
		/// </summary>
		public READYValue READY => _READY ?? (_READY = new READYValue());

		/// <summary>
		/// <i>requester</i> is prepared to make a <i>request</i>, but no <i>request</i> for service is required.
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
			public string Summary => @"/// <i>requester</i> is prepared to make a <i>request</i>, but no <i>request</i> for service is required.";
		}
		private ACTIVEValue _ACTIVE;
		/// <summary>
		/// <i>requester</i> has initiated a <i>request</i> for a service and the service has not yet been completed by the <i>responder</i>.
		/// </summary>
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>
		/// <i>requester</i> has initiated a <i>request</i> for a service and the service has not yet been completed by the <i>responder</i>.
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
			public string Summary => @"/// <i>requester</i> has initiated a <i>request</i> for a service and the service has not yet been completed by the <i>responder</i>.";
		}
		private FAILValue _FAIL;
		/// <summary>
		/// <i>requester</i> has detected a failure condition.
		/// </summary>
		public FAILValue FAIL => _FAIL ?? (_FAIL = new FAILValue());

		/// <summary>
		/// <i>requester</i> has detected a failure condition.
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
			public string Summary => @"/// <i>requester</i> has detected a failure condition.";
		}
	}
}