#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605550283222_680737_1925">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ProcessStateEnum
	{
		/// <summary>﻿device is preparing to execute the process occurrence.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		INITIALIZING,
		/// <summary>﻿process occurrence is ready to be executed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		READY,
		/// <summary>﻿process occurrence is actively executing.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>﻿process occurrence is now finished.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		COMPLETE,
		/// <summary>﻿process occurrence has been stopped and may be resumed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		INTERRUPTED,
		/// <summary>﻿process occurrence has come to a premature end and cannot be resumed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		ABORTED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605550283222_680737_1925">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ProcessStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ProcessStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(ProcessStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.8";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		INITIALIZING,
		READY,
		ACTIVE,
		COMPLETE,
		INTERRUPTED,
		ABORTED,
		};

		private INITIALIZINGValue _INITIALIZING;
		/// <inheritdoc cref="INITIALIZINGValue" path="/summary" />
		public INITIALIZINGValue INITIALIZING => _INITIALIZING ?? (_INITIALIZING = new INITIALIZINGValue());

		/// <summary>﻿device is preparing to execute the process occurrence.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		public sealed class INITIALIZINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INITIALIZING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;device is preparing to execute the process occurrence.&#10;
";
		}
		private READYValue _READY;
		/// <inheritdoc cref="READYValue" path="/summary" />
		public READYValue READY => _READY ?? (_READY = new READYValue());

		/// <summary>﻿process occurrence is ready to be executed.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		public sealed class READYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "READY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;process occurrence is ready to be executed.&#10;
";
		}
		private ACTIVEValue _ACTIVE;
		/// <inheritdoc cref="ACTIVEValue" path="/summary" />
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>﻿process occurrence is actively executing.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;process occurrence is actively executing.&#10;
";
		}
		private COMPLETEValue _COMPLETE;
		/// <inheritdoc cref="COMPLETEValue" path="/summary" />
		public COMPLETEValue COMPLETE => _COMPLETE ?? (_COMPLETE = new COMPLETEValue());

		/// <summary>﻿process occurrence is now finished.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		public sealed class COMPLETEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMPLETE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;process occurrence is now finished.&#10;
";
		}
		private INTERRUPTEDValue _INTERRUPTED;
		/// <inheritdoc cref="INTERRUPTEDValue" path="/summary" />
		public INTERRUPTEDValue INTERRUPTED => _INTERRUPTED ?? (_INTERRUPTED = new INTERRUPTEDValue());

		/// <summary>﻿process occurrence has been stopped and may be resumed.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		public sealed class INTERRUPTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INTERRUPTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;process occurrence has been stopped and may be resumed.&#10;
";
		}
		private ABORTEDValue _ABORTED;
		/// <inheritdoc cref="ABORTEDValue" path="/summary" />
		public ABORTEDValue ABORTED => _ABORTED ?? (_ABORTED = new ABORTEDValue());

		/// <summary>﻿process occurrence has come to a premature end and cannot be resumed.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		public sealed class ABORTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ABORTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;process occurrence has come to a premature end and cannot be resumed.&#10;
";
		}
	}
}