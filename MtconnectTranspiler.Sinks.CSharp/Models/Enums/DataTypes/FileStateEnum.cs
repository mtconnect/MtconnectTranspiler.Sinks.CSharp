#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605276722719_257725_310">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum FileStateEnum
	{
		/// <summary>﻿used for processes other than production or otherwise defined.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		EXPERIMENTAL,
		/// <summary>﻿used for production processes.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PRODUCTION,
		/// <summary>﻿content is modified from <c>PRODUCTION</c> or <c>EXPERIMENTAL</c>.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		REVISION,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605276722719_257725_310">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FileStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "FileStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="EXPERIMENTALValue" path="/summary" />
		public EXPERIMENTALValue EXPERIMENTAL => _EXPERIMENTAL ?? (_EXPERIMENTAL = new EXPERIMENTALValue());

		/// <summary>﻿used for processes other than production or otherwise defined.<br /><br /><br />
		/// Value for FileStateEnum.<br/>
		/// <br/>See also <seealso cref="FileStateEnum">FileStateEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;used for processes other than production or otherwise defined.&#10;
";
		}
		private PRODUCTIONValue _PRODUCTION;
		/// <inheritdoc cref="PRODUCTIONValue" path="/summary" />
		public PRODUCTIONValue PRODUCTION => _PRODUCTION ?? (_PRODUCTION = new PRODUCTIONValue());

		/// <summary>﻿used for production processes.<br /><br /><br /><br />
		/// Value for FileStateEnum.<br/>
		/// <br/>See also <seealso cref="FileStateEnum">FileStateEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;used for production processes.&#10;
";
		}
		private REVISIONValue _REVISION;
		/// <inheritdoc cref="REVISIONValue" path="/summary" />
		public REVISIONValue REVISION => _REVISION ?? (_REVISION = new REVISIONValue());

		/// <summary>﻿content is modified from <c>PRODUCTION</c> or <c>EXPERIMENTAL</c>.<br /><br /><br /><br />
		/// Value for FileStateEnum.<br/>
		/// <br/>See also <seealso cref="FileStateEnum">FileStateEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;content is modified from `PRODUCTION` or `EXPERIMENTAL`.&#10;
";
		}
	}
}