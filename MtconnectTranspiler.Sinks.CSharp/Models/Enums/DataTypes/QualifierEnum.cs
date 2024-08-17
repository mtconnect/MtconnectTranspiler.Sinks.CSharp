#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579566531117_877396_25735">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum QualifierEnum
	{
		/// <summary>﻿measured value is greater than the expected value for a process variable.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		HIGH,
		/// <summary>﻿measured value is less than the expected value for a process variable.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		LOW,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579566531117_877396_25735">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class QualifierEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "QualifierEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(QualifierEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		HIGH,
		LOW,
		};

		private HIGHValue _HIGH;
		/// <inheritdoc cref="HIGHValue" path="/summary" />
		public HIGHValue HIGH => _HIGH ?? (_HIGH = new HIGHValue());

		/// <summary>﻿measured value is greater than the expected value for a process variable.<br /><br /><br />
		/// Value for QualifierEnum.<br/>
		/// <br/>See also <seealso cref="QualifierEnum">QualifierEnum</seealso>
		/// </summary>
		public sealed class HIGHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HIGH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;measured value is greater than the expected value for a process variable.&#10;
";
		}
		private LOWValue _LOW;
		/// <inheritdoc cref="LOWValue" path="/summary" />
		public LOWValue LOW => _LOW ?? (_LOW = new LOWValue());

		/// <summary>﻿measured value is less than the expected value for a process variable.<br /><br /><br />
		/// Value for QualifierEnum.<br/>
		/// <br/>See also <seealso cref="QualifierEnum">QualifierEnum</seealso>
		/// </summary>
		public sealed class LOWValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOW";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;measured value is less than the expected value for a process variable.&#10;
";
		}
	}
}