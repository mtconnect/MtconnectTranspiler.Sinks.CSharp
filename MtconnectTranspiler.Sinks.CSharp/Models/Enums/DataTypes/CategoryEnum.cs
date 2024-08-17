#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579277872728_249968_3735">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CategoryEnum
	{
		/// <summary>﻿continuously variable or analog data value. <br /><br />A continuous value can be measured at any point-in-time and will always produce a result.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		SAMPLE,
		/// <summary>﻿discrete piece of information from the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		EVENT,
		/// <summary>﻿information about the health of a piece of equipment and its ability to function.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		CONDITION,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579277872728_249968_3735">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CategoryEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CategoryEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CategoryEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		SAMPLE,
		EVENT,
		CONDITION,
		};

		private SAMPLEValue _SAMPLE;
		/// <inheritdoc cref="SAMPLEValue" path="/summary" />
		public SAMPLEValue SAMPLE => _SAMPLE ?? (_SAMPLE = new SAMPLEValue());

		/// <summary>﻿continuously variable or analog data value. <br /><br />A continuous value can be measured at any point-in-time and will always produce a result.<br /><br /><br />
		/// Value for CategoryEnum.<br/>
		/// <br/>See also <seealso cref="CategoryEnum">CategoryEnum</seealso>
		/// </summary>
		public sealed class SAMPLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SAMPLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;continuously variable or analog data value. 

A continuous value can be measured at any point-in-time and will always produce a result.&#10;
";
		}
		private EVENTValue _EVENT;
		/// <inheritdoc cref="EVENTValue" path="/summary" />
		public EVENTValue EVENT => _EVENT ?? (_EVENT = new EVENTValue());

		/// <summary>﻿discrete piece of information from the piece of equipment.<br /><br /><br />
		/// Value for CategoryEnum.<br/>
		/// <br/>See also <seealso cref="CategoryEnum">CategoryEnum</seealso>
		/// </summary>
		public sealed class EVENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EVENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;discrete piece of information from the piece of equipment.&#10;
";
		}
		private CONDITIONValue _CONDITION;
		/// <inheritdoc cref="CONDITIONValue" path="/summary" />
		public CONDITIONValue CONDITION => _CONDITION ?? (_CONDITION = new CONDITIONValue());

		/// <summary>﻿information about the health of a piece of equipment and its ability to function.<br /><br /><br />
		/// Value for CategoryEnum.<br/>
		/// <br/>See also <seealso cref="CategoryEnum">CategoryEnum</seealso>
		/// </summary>
		public sealed class CONDITIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONDITION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;information about the health of a piece of equipment and its ability to function.&#10;
";
		}
	}
}