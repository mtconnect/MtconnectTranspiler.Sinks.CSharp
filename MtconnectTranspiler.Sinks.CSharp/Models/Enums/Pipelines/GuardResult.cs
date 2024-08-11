using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AgentArchitecture.Pipelines
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_4_45f01b9_1674413987997_312842_3519">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum GuardResult
	{
		/// <summary>
		/// </summary>
		CONTINUE,
		/// <summary>
		/// </summary>
		SKIP,
		/// <summary>
		/// </summary>
		RUN,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_4_45f01b9_1674413987997_312842_3519">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class GuardResultMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "GuardResult";
		
		/// <inheritdoc />
		public Type DataType => null;
		
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
		public CONTINUEValue CONTINUE => _CONTINUE ?? (_CONTINUE = new CONTINUEValue());

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
		public SKIPValue SKIP => _SKIP ?? (_SKIP = new SKIPValue());

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
		public RUNValue RUN => _RUN ?? (_RUN = new RUNValue());

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