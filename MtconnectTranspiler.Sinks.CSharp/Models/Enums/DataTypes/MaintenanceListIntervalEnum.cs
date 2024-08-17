#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640604472459_23562_405">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum MaintenanceListIntervalEnum
	{
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		ABSOLUTE,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		INCREMENTAL,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640604472459_23562_405">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MaintenanceListIntervalEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "MaintenanceListIntervalEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(MaintenanceListIntervalEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ABSOLUTE,
		INCREMENTAL,
		};

		private ABSOLUTEValue _ABSOLUTE;
		/// <inheritdoc cref="ABSOLUTEValue" path="/summary" />
		public ABSOLUTEValue ABSOLUTE => _ABSOLUTE ?? (_ABSOLUTE = new ABSOLUTEValue());

		/// <summary>﻿
		/// Value for MaintenanceListIntervalEnum.<br/>
		/// <br/>See also <seealso cref="MaintenanceListIntervalEnum">MaintenanceListIntervalEnum</seealso>
		/// </summary>
		public sealed class ABSOLUTEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ABSOLUTE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private INCREMENTALValue _INCREMENTAL;
		/// <inheritdoc cref="INCREMENTALValue" path="/summary" />
		public INCREMENTALValue INCREMENTAL => _INCREMENTAL ?? (_INCREMENTAL = new INCREMENTALValue());

		/// <summary>﻿
		/// Value for MaintenanceListIntervalEnum.<br/>
		/// <br/>See also <seealso cref="MaintenanceListIntervalEnum">MaintenanceListIntervalEnum</seealso>
		/// </summary>
		public sealed class INCREMENTALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INCREMENTAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
	}
}