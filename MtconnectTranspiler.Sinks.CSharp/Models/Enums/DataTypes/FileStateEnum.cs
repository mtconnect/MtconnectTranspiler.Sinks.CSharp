using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605276722719_257725_310">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum FileStateEnum
	{
		/// <summary>
		/// used for processes other than production or otherwise defined.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		EXPERIMENTAL,
		/// <summary>
		/// used for production processes. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PRODUCTION,
		/// <summary>
		/// content is modified from <c>PRODUCTION</c> or <c>EXPERIMENTAL</c>. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		REVISION,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605276722719_257725_310">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class FileStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "FileStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(FileStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.7";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		EXPERIMENTAL,
		PRODUCTION,
		REVISION,
		};

		private EXPERIMENTALValue _EXPERIMENTAL;
		/// <summary>
		/// used for processes other than production or otherwise defined.
		/// </summary>
		public EXPERIMENTALValue EXPERIMENTAL => _EXPERIMENTAL ?? (_EXPERIMENTAL = new EXPERIMENTALValue());

		/// <summary>
		/// used for processes other than production or otherwise defined.
		/// </summary>
		public sealed class EXPERIMENTALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXPERIMENTAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// used for processes other than production or otherwise defined.";
		}
		private PRODUCTIONValue _PRODUCTION;
		/// <summary>
		/// used for production processes. 
		/// </summary>
		public PRODUCTIONValue PRODUCTION => _PRODUCTION ?? (_PRODUCTION = new PRODUCTIONValue());

		/// <summary>
		/// used for production processes. 
		/// </summary>
		public sealed class PRODUCTIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRODUCTION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// used for production processes. ";
		}
		private REVISIONValue _REVISION;
		/// <summary>
		/// content is modified from <c>PRODUCTION</c> or <c>EXPERIMENTAL</c>. 
		/// </summary>
		public REVISIONValue REVISION => _REVISION ?? (_REVISION = new REVISIONValue());

		/// <summary>
		/// content is modified from <c>PRODUCTION</c> or <c>EXPERIMENTAL</c>. 
		/// </summary>
		public sealed class REVISIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REVISION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// content is modified from <c>PRODUCTION</c> or <c>EXPERIMENTAL</c>. ";
		}
	}
}