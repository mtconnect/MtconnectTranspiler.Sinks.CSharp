using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632486691907_586773_73">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum AxisInterlockEnum
	{
		/// <summary>
		﻿/// axis lockout function is activated, power has been removed from the axis, and the axis is allowed to move freely.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>
		﻿/// axis lockout function has not been activated, the axis may be powered, and the axis is capable of being controlled by another component.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		INACTIVE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632486691907_586773_73">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AxisInterlockEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "AxisInterlockEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(AxisInterlockEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.3";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ACTIVE,
		INACTIVE,
		};

		private ACTIVEValue _ACTIVE;
		/// <summary>
		﻿/// axis lockout function is activated, power has been removed from the axis, and the axis is allowed to move freely.<br/><br />

		/// </summary>
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>
		﻿/// axis lockout function is activated, power has been removed from the axis, and the axis is allowed to move freely.<br/><br />

		/// </summary>
		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;axis lockout function is activated, power has been removed from the axis, and the axis is allowed to move freely.&#10;
";
		}
		private INACTIVEValue _INACTIVE;
		/// <summary>
		﻿/// axis lockout function has not been activated, the axis may be powered, and the axis is capable of being controlled by another component.<br/><br />

		/// </summary>
		public INACTIVEValue INACTIVE => _INACTIVE ?? (_INACTIVE = new INACTIVEValue());

		/// <summary>
		﻿/// axis lockout function has not been activated, the axis may be powered, and the axis is capable of being controlled by another component.<br/><br />

		/// </summary>
		public sealed class INACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;axis lockout function has not been activated, the axis may be powered, and the axis is capable of being controlled by another component.&#10;
";
		}
	}
}