#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825656758_905757_799">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ApplicationTypeEnum
	{
		/// <summary>﻿computer aided design files or drawings.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DESIGN,
		/// <summary>﻿generic data.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DATA,
		/// <summary>﻿documentation regarding a category of file.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DOCUMENTATION,
		/// <summary>﻿user instructions regarding the execution of a task.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		INSTRUCTIONS,
		/// <summary>﻿data related to the history of a machine or process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		LOG,
		/// <summary>﻿machine instructions to perform a process.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PRODUCTION_PROGRAM,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825656758_905757_799">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ApplicationTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ApplicationTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="DESIGNValue" path="/summary" />
		public DESIGNValue DESIGN => _DESIGN ?? (_DESIGN = new DESIGNValue());

		/// <summary>﻿computer aided design files or drawings.<br /><br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;computer aided design files or drawings.&#10;
";
		}
		private DATAValue _DATA;
		/// <inheritdoc cref="DATAValue" path="/summary" />
		public DATAValue DATA => _DATA ?? (_DATA = new DATAValue());

		/// <summary>﻿generic data.<br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;generic data.&#10;
";
		}
		private DOCUMENTATIONValue _DOCUMENTATION;
		/// <inheritdoc cref="DOCUMENTATIONValue" path="/summary" />
		public DOCUMENTATIONValue DOCUMENTATION => _DOCUMENTATION ?? (_DOCUMENTATION = new DOCUMENTATIONValue());

		/// <summary>﻿documentation regarding a category of file.<br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;documentation regarding a category of file.&#10;
";
		}
		private INSTRUCTIONSValue _INSTRUCTIONS;
		/// <inheritdoc cref="INSTRUCTIONSValue" path="/summary" />
		public INSTRUCTIONSValue INSTRUCTIONS => _INSTRUCTIONS ?? (_INSTRUCTIONS = new INSTRUCTIONSValue());

		/// <summary>﻿user instructions regarding the execution of a task.<br /><br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;user instructions regarding the execution of a task.&#10;
";
		}
		private LOGValue _LOG;
		/// <inheritdoc cref="LOGValue" path="/summary" />
		public LOGValue LOG => _LOG ?? (_LOG = new LOGValue());

		/// <summary>﻿data related to the history of a machine or process.<br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;data related to the history of a machine or process.&#10;
";
		}
		private PRODUCTION_PROGRAMValue _PRODUCTION_PROGRAM;
		/// <inheritdoc cref="PRODUCTION_PROGRAMValue" path="/summary" />
		public PRODUCTION_PROGRAMValue PRODUCTION_PROGRAM => _PRODUCTION_PROGRAM ?? (_PRODUCTION_PROGRAM = new PRODUCTION_PROGRAMValue());

		/// <summary>﻿machine instructions to perform a process.<br /><br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;machine instructions to perform a process.&#10;
";
		}
	}
}