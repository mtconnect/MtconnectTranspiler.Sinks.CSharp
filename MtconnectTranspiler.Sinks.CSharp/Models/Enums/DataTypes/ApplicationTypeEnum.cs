using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825656758_905757_799">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ApplicationTypeEnum
	{
		/// <summary>
		/// computer aided design files or drawings. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DESIGN,
		/// <summary>
		/// generic data.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DATA,
		/// <summary>
		/// documentation regarding a category of file.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DOCUMENTATION,
		/// <summary>
		/// user instructions regarding the execution of a task. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		INSTRUCTIONS,
		/// <summary>
		/// data related to the history of a machine or process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		LOG,
		/// <summary>
		/// machine instructions to perform a process. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PRODUCTION_PROGRAM,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825656758_905757_799">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ApplicationTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ApplicationTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ApplicationTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.7";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		DESIGN,
		DATA,
		DOCUMENTATION,
		INSTRUCTIONS,
		LOG,
		PRODUCTION_PROGRAM,
		};

		private DESIGNValue _DESIGN;
		/// <summary>
		/// computer aided design files or drawings. 
		/// </summary>
		public DESIGNValue DESIGN => _DESIGN ?? (_DESIGN = new DESIGNValue());

		/// <summary>
		/// computer aided design files or drawings. 
		/// </summary>
		public sealed class DESIGNValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DESIGN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// computer aided design files or drawings. ";
		}
		private DATAValue _DATA;
		/// <summary>
		/// generic data.
		/// </summary>
		public DATAValue DATA => _DATA ?? (_DATA = new DATAValue());

		/// <summary>
		/// generic data.
		/// </summary>
		public sealed class DATAValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DATA";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// generic data.";
		}
		private DOCUMENTATIONValue _DOCUMENTATION;
		/// <summary>
		/// documentation regarding a category of file.
		/// </summary>
		public DOCUMENTATIONValue DOCUMENTATION => _DOCUMENTATION ?? (_DOCUMENTATION = new DOCUMENTATIONValue());

		/// <summary>
		/// documentation regarding a category of file.
		/// </summary>
		public sealed class DOCUMENTATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DOCUMENTATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// documentation regarding a category of file.";
		}
		private INSTRUCTIONSValue _INSTRUCTIONS;
		/// <summary>
		/// user instructions regarding the execution of a task. 
		/// </summary>
		public INSTRUCTIONSValue INSTRUCTIONS => _INSTRUCTIONS ?? (_INSTRUCTIONS = new INSTRUCTIONSValue());

		/// <summary>
		/// user instructions regarding the execution of a task. 
		/// </summary>
		public sealed class INSTRUCTIONSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INSTRUCTIONS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// user instructions regarding the execution of a task. ";
		}
		private LOGValue _LOG;
		/// <summary>
		/// data related to the history of a machine or process.
		/// </summary>
		public LOGValue LOG => _LOG ?? (_LOG = new LOGValue());

		/// <summary>
		/// data related to the history of a machine or process.
		/// </summary>
		public sealed class LOGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOG";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// data related to the history of a machine or process.";
		}
		private PRODUCTION_PROGRAMValue _PRODUCTION_PROGRAM;
		/// <summary>
		/// machine instructions to perform a process. 
		/// </summary>
		public PRODUCTION_PROGRAMValue PRODUCTION_PROGRAM => _PRODUCTION_PROGRAM ?? (_PRODUCTION_PROGRAM = new PRODUCTION_PROGRAMValue());

		/// <summary>
		/// machine instructions to perform a process. 
		/// </summary>
		public sealed class PRODUCTION_PROGRAMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRODUCTION_PROGRAM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// machine instructions to perform a process. ";
		}
	}
}