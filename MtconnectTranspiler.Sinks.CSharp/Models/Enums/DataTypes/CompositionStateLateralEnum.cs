#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550806336_962403_162">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CompositionStateLateralEnum
	{
		/// <summary>﻿position of the <see cref="Composition">Composition</see> is oriented to the right to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		RIGHT,
		/// <summary>﻿position of the <see cref="Composition">Composition</see> is oriented to the left to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LEFT,
		/// <summary>﻿position of the <see cref="Composition">Composition</see> is not oriented to the right to the point of a positive confirmation and is not oriented to the left to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		TRANSITIONING,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550806336_962403_162">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CompositionStateLateralEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CompositionStateLateralEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CompositionStateLateralEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		RIGHT,
		LEFT,
		TRANSITIONING,
		};

		private RIGHTValue _RIGHT;
		/// <inheritdoc cref="RIGHTValue" path="/summary" />
		public RIGHTValue RIGHT => _RIGHT ?? (_RIGHT = new RIGHTValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> is oriented to the right to the point of a positive confirmation.<br /><br /><br />
		/// Value for CompositionStateLateralEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateLateralEnum">CompositionStateLateralEnum</seealso>
		/// </summary>
		public sealed class RIGHTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RIGHT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;position of the {{block(Composition)}} is oriented to the right to the point of a positive confirmation.&#10;
";
		}
		private LEFTValue _LEFT;
		/// <inheritdoc cref="LEFTValue" path="/summary" />
		public LEFTValue LEFT => _LEFT ?? (_LEFT = new LEFTValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> is oriented to the left to the point of a positive confirmation.<br /><br /><br />
		/// Value for CompositionStateLateralEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateLateralEnum">CompositionStateLateralEnum</seealso>
		/// </summary>
		public sealed class LEFTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LEFT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;position of the {{block(Composition)}} is oriented to the left to the point of a positive confirmation.&#10;
";
		}
		private TRANSITIONINGValue _TRANSITIONING;
		/// <inheritdoc cref="TRANSITIONINGValue" path="/summary" />
		public TRANSITIONINGValue TRANSITIONING => _TRANSITIONING ?? (_TRANSITIONING = new TRANSITIONINGValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> is not oriented to the right to the point of a positive confirmation and is not oriented to the left to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// Value for CompositionStateLateralEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateLateralEnum">CompositionStateLateralEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;position of the {{block(Composition)}} is not oriented to the right to the point of a positive confirmation and is not oriented to the left to the point of a positive confirmation. 

It is in an intermediate position.&#10;
";
		}
	}
}