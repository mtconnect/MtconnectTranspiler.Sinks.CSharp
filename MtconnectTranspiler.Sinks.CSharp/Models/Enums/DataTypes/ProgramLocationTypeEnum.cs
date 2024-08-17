#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643980698480_209668_2427">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ProgramLocationTypeEnum
	{
		/// <summary>﻿managed by the controller.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		LOCAL,
		/// <summary>﻿not managed by the controller.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		EXTERNAL,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643980698480_209668_2427">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ProgramLocationTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ProgramLocationTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(ProgramLocationTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.5";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		LOCAL,
		EXTERNAL,
		};

		private LOCALValue _LOCAL;
		/// <inheritdoc cref="LOCALValue" path="/summary" />
		public LOCALValue LOCAL => _LOCAL ?? (_LOCAL = new LOCALValue());

		/// <summary>﻿managed by the controller.<br /><br /><br />
		/// Value for ProgramLocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ProgramLocationTypeEnum">ProgramLocationTypeEnum</seealso>
		/// </summary>
		public sealed class LOCALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOCAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;managed by the controller.&#10;
";
		}
		private EXTERNALValue _EXTERNAL;
		/// <inheritdoc cref="EXTERNALValue" path="/summary" />
		public EXTERNALValue EXTERNAL => _EXTERNAL ?? (_EXTERNAL = new EXTERNALValue());

		/// <summary>﻿not managed by the controller.<br /><br /><br />
		/// Value for ProgramLocationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ProgramLocationTypeEnum">ProgramLocationTypeEnum</seealso>
		/// </summary>
		public sealed class EXTERNALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXTERNAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;not managed by the controller.&#10;
";
		}
	}
}