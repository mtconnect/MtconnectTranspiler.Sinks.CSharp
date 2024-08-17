#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550799197_550203_137">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CompositionStateVerticalEnum
	{
		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is oriented in an upward direction to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		UP,
		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is oriented in a downward direction to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		DOWN,
		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is not oriented in an upward direction to the point of a positive confirmation and is not oriented in a downward direction to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		TRANSITIONING,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550799197_550203_137">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CompositionStateVerticalEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CompositionStateVerticalEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CompositionStateVerticalEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		UP,
		DOWN,
		TRANSITIONING,
		};

		private UPValue _UP;
		/// <inheritdoc cref="UPValue" path="/summary" />
		public UPValue UP => _UP ?? (_UP = new UPValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is oriented in an upward direction to the point of a positive confirmation.<br /><br /><br />
		/// Value for CompositionStateVerticalEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateVerticalEnum">CompositionStateVerticalEnum</seealso>
		/// </summary>
		public sealed class UPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;position of the {{block(Composition)}} element is oriented in an upward direction to the point of a positive confirmation.&#10;
";
		}
		private DOWNValue _DOWN;
		/// <inheritdoc cref="DOWNValue" path="/summary" />
		public DOWNValue DOWN => _DOWN ?? (_DOWN = new DOWNValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is oriented in a downward direction to the point of a positive confirmation.<br /><br /><br />
		/// Value for CompositionStateVerticalEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateVerticalEnum">CompositionStateVerticalEnum</seealso>
		/// </summary>
		public sealed class DOWNValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DOWN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;position of the {{block(Composition)}} element is oriented in a downward direction to the point of a positive confirmation.&#10;
";
		}
		private TRANSITIONINGValue _TRANSITIONING;
		/// <inheritdoc cref="TRANSITIONINGValue" path="/summary" />
		public TRANSITIONINGValue TRANSITIONING => _TRANSITIONING ?? (_TRANSITIONING = new TRANSITIONINGValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> element is not oriented in an upward direction to the point of a positive confirmation and is not oriented in a downward direction to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// Value for CompositionStateVerticalEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateVerticalEnum">CompositionStateVerticalEnum</seealso>
		/// </summary>
		public sealed class TRANSITIONINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRANSITIONING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;position of the {{block(Composition)}} element is not oriented in an upward direction to the point of a positive confirmation and is not oriented in a downward direction to the point of a positive confirmation. 

It is in an intermediate position.&#10;
";
		}
	}
}