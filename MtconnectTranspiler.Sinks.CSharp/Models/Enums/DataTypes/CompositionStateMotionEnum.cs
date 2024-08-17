#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550811680_794757_187">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CompositionStateMotionEnum
	{
		/// <summary>﻿position of the <see cref="Composition">Composition</see> is open to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OPEN,
		/// <summary>﻿position of the <see cref="Composition">Composition</see> is not open to the<br />point of a positive confirmation and is not closed to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		UNLATCHED,
		/// <summary>﻿position of the <see cref="Composition">Composition</see> is closed to the point of a positive confirmation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CLOSED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550811680_794757_187">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CompositionStateMotionEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CompositionStateMotionEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CompositionStateMotionEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		OPEN,
		UNLATCHED,
		CLOSED,
		};

		private OPENValue _OPEN;
		/// <inheritdoc cref="OPENValue" path="/summary" />
		public OPENValue OPEN => _OPEN ?? (_OPEN = new OPENValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> is open to the point of a positive confirmation.<br /><br /><br />
		/// Value for CompositionStateMotionEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateMotionEnum">CompositionStateMotionEnum</seealso>
		/// </summary>
		public sealed class OPENValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPEN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;position of the {{block(Composition)}} is open to the point of a positive confirmation.&#10;
";
		}
		private UNLATCHEDValue _UNLATCHED;
		/// <inheritdoc cref="UNLATCHEDValue" path="/summary" />
		public UNLATCHEDValue UNLATCHED => _UNLATCHED ?? (_UNLATCHED = new UNLATCHEDValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> is not open to the<br />point of a positive confirmation and is not closed to the point of a positive confirmation. <br /><br />It is in an intermediate position.<br /><br /><br />
		/// Value for CompositionStateMotionEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateMotionEnum">CompositionStateMotionEnum</seealso>
		/// </summary>
		public sealed class UNLATCHEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNLATCHED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;position of the {{block(Composition)}} is not open to the
point of a positive confirmation and is not closed to the point of a positive confirmation. 

It is in an intermediate position.&#10;
";
		}
		private CLOSEDValue _CLOSED;
		/// <inheritdoc cref="CLOSEDValue" path="/summary" />
		public CLOSEDValue CLOSED => _CLOSED ?? (_CLOSED = new CLOSEDValue());

		/// <summary>﻿position of the <see cref="Composition">Composition</see> is closed to the point of a positive confirmation.<br /><br /><br />
		/// Value for CompositionStateMotionEnum.<br/>
		/// <br/>See also <seealso cref="CompositionStateMotionEnum">CompositionStateMotionEnum</seealso>
		/// </summary>
		public sealed class CLOSEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOSED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;position of the {{block(Composition)}} is closed to the point of a positive confirmation.&#10;
";
		}
	}
}