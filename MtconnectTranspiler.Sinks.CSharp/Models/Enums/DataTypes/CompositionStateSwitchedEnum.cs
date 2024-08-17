#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550781451_530503_112">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CompositionStateSwitchedEnum
	{
		/// <summary>﻿activation state of the <see cref="Composition">Composition</see> is in an <c>ON</c> condition, it is operating, or it is powered.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ON,
		/// <summary>﻿activation state of the <see cref="Composition">Composition</see> is in an <c>OFF</c> condition, it is not operating, or it is not powered.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OFF,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550781451_530503_112">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CompositionStateSwitchedEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CompositionStateSwitchedEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CompositionStateSwitchedEnum);

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
		/// <inheritdoc cref="ONValue" path="/summary" />
		public ONValue ON => _ON ?? (_ON = new ONValue());

		/// <summary>﻿activation state of the <see cref="Composition">Composition</see> is in an <c>ON</c> condition, it is operating, or it is powered.<br /><br /><br />
		/// Value for CompositionStateSwitchedEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateSwitchedEnum">CompositionStateSwitchedEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;activation state of the {{block(Composition)}} is in an `ON` condition, it is operating, or it is powered.&#10;
";
		}
		private OFFValue _OFF;
		/// <inheritdoc cref="OFFValue" path="/summary" />
		public OFFValue OFF => _OFF ?? (_OFF = new OFFValue());

		/// <summary>﻿activation state of the <see cref="Composition">Composition</see> is in an <c>OFF</c> condition, it is not operating, or it is not powered.<br /><br /><br />
		/// Value for CompositionStateSwitchedEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateSwitchedEnum">CompositionStateSwitchedEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;activation state of the {{block(Composition)}} is in an `OFF` condition, it is not operating, or it is not powered.&#10;
";
		}
	}
}