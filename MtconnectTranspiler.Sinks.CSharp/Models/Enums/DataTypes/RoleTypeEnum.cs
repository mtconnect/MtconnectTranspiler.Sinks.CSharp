#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579301039819_63145_6975">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum RoleTypeEnum
	{
		/// <summary>﻿associated element performs the functions of a <see cref="System">System</see> for this element.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		SYSTEM,
		/// <summary>﻿associated element performs the functions as an <c>Auxiliary</c> for this element.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		AUXILIARY,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579301039819_63145_6975">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RoleTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "RoleTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(RoleTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.5";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		SYSTEM,
		AUXILIARY,
		};

		private SYSTEMValue _SYSTEM;
		/// <inheritdoc cref="SYSTEMValue" path="/summary" />
		public SYSTEMValue SYSTEM => _SYSTEM ?? (_SYSTEM = new SYSTEMValue());

		/// <summary>﻿associated element performs the functions of a <see cref="System">System</see> for this element.<br /><br /><br />
		/// Value for RoleTypeEnum.<br/>
		/// <br/>See also <seealso cref="RoleTypeEnum">RoleTypeEnum</seealso>
		/// </summary>
		public sealed class SYSTEMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SYSTEM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;associated element performs the functions of a {{block(System)}} for this element.&#10;
";
		}
		private AUXILIARYValue _AUXILIARY;
		/// <inheritdoc cref="AUXILIARYValue" path="/summary" />
		public AUXILIARYValue AUXILIARY => _AUXILIARY ?? (_AUXILIARY = new AUXILIARYValue());

		/// <summary>﻿associated element performs the functions as an <c>Auxiliary</c> for this element.<br /><br /><br />
		/// Value for RoleTypeEnum.<br/>
		/// <br/>See also <seealso cref="RoleTypeEnum">RoleTypeEnum</seealso>
		/// </summary>
		public sealed class AUXILIARYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AUXILIARY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;associated element performs the functions as an `Auxiliary` for this element.&#10;
";
		}
	}
}