using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632489429268_660861_104">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum EquipmentModeEnum
	{
		/// <summary>
		﻿/// equipment is functioning in the mode designated by the <c>subType</c>.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ON,
		/// <summary>
		﻿/// equipment is not functioning in the mode designated by the <c>subType</c>.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OFF,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632489429268_660861_104">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EquipmentModeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "EquipmentModeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(EquipmentModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ON,
		OFF,
		};

		private ONValue _ON;
		/// <summary>
		﻿/// equipment is functioning in the mode designated by the <c>subType</c>.<br/><br />

		/// </summary>
		public ONValue ON => _ON ?? (_ON = new ONValue());

		/// <summary>
		﻿/// equipment is functioning in the mode designated by the <c>subType</c>.<br/><br />

		/// </summary>
		public sealed class ONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ON";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;equipment is functioning in the mode designated by the `subType`.&#10;
";
		}
		private OFFValue _OFF;
		/// <summary>
		﻿/// equipment is not functioning in the mode designated by the <c>subType</c>.<br/><br />

		/// </summary>
		public OFFValue OFF => _OFF ?? (_OFF = new OFFValue());

		/// <summary>
		﻿/// equipment is not functioning in the mode designated by the <c>subType</c>.<br/><br />

		/// </summary>
		public sealed class OFFValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OFF";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;equipment is not functioning in the mode designated by the `subType`.&#10;
";
		}
	}
}