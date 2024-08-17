#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_6B22B6F6_7073_4fa7_961B_B05AD4C7EF81">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v2.0 according to https://model.mtconnect.org/#_Version_2.0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CoordinateSystemEnum
	{
		/// <summary>﻿unchangeable coordinate system that has machine zero as its origin.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.0 according to https://model.mtconnect.org/#_Version_2.0")]
		MACHINE,
		/// <summary>﻿coordinate system that represents the working area for a particular workpiece whose origin is shifted within the <c>MACHINE</c> coordinate system.<br /><br />If the <c>WORK</c> coordinates are not currently defined in the piece of equipment, the <c>MACHINE</c> coordinates will be used.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.0 according to https://model.mtconnect.org/#_Version_2.0")]
		WORK,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_6B22B6F6_7073_4fa7_961B_B05AD4C7EF81">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CoordinateSystemEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CoordinateSystemEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CoordinateSystemEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "2.0";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		MACHINE,
		WORK,
		};

		private MACHINEValue _MACHINE;
		/// <inheritdoc cref="MACHINEValue" path="/summary" />
		public MACHINEValue MACHINE => _MACHINE ?? (_MACHINE = new MACHINEValue());

		/// <summary>﻿unchangeable coordinate system that has machine zero as its origin.<br /><br /><br />
		/// Value for CoordinateSystemEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemEnum">CoordinateSystemEnum</seealso>
		/// </summary>
		public sealed class MACHINEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MACHINE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "2.0";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;unchangeable coordinate system that has machine zero as its origin.&#10;
";
		}
		private WORKValue _WORK;
		/// <inheritdoc cref="WORKValue" path="/summary" />
		public WORKValue WORK => _WORK ?? (_WORK = new WORKValue());

		/// <summary>﻿coordinate system that represents the working area for a particular workpiece whose origin is shifted within the <c>MACHINE</c> coordinate system.<br /><br />If the <c>WORK</c> coordinates are not currently defined in the piece of equipment, the <c>MACHINE</c> coordinates will be used.<br /><br /><br />
		/// Value for CoordinateSystemEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemEnum">CoordinateSystemEnum</seealso>
		/// </summary>
		public sealed class WORKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WORK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "2.0";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;coordinate system that represents the working area for a particular workpiece whose origin is shifted within the `MACHINE` coordinate system.

If the `WORK` coordinates are not currently defined in the piece of equipment, the `MACHINE` coordinates will be used.&#10;
";
		}
	}
}