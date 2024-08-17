#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640604423161_7561_376">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum MaintenanceListDirectionEnum
	{
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		UP,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		DOWN,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640604423161_7561_376">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MaintenanceListDirectionEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "MaintenanceListDirectionEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(MaintenanceListDirectionEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		UP,
		DOWN,
		};

		private UPValue _UP;
		/// <inheritdoc cref="UPValue" path="/summary" />
		public UPValue UP => _UP ?? (_UP = new UPValue());

		/// <summary>﻿
		/// Value for MaintenanceListDirectionEnum.<br/>
		/// <br/>See also <seealso cref="MaintenanceListDirectionEnum">MaintenanceListDirectionEnum</seealso>
		/// </summary>
		public sealed class UPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private DOWNValue _DOWN;
		/// <inheritdoc cref="DOWNValue" path="/summary" />
		public DOWNValue DOWN => _DOWN ?? (_DOWN = new DOWNValue());

		/// <summary>﻿
		/// Value for MaintenanceListDirectionEnum.<br/>
		/// <br/>See also <seealso cref="MaintenanceListDirectionEnum">MaintenanceListDirectionEnum</seealso>
		/// </summary>
		public sealed class DOWNValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DOWN";
			
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