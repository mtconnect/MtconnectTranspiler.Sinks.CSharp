#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605643327599_586044_593">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum OriginatorEnum
	{
		/// <summary>﻿manufacturer of a piece of equipment or <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		MANUFACTURER,
		/// <summary>﻿owner or implementer of a piece of equipment or <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		USER,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605643327599_586044_593">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class OriginatorEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "OriginatorEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(OriginatorEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.7";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		MANUFACTURER,
		USER,
		};

		private MANUFACTURERValue _MANUFACTURER;
		/// <inheritdoc cref="MANUFACTURERValue" path="/summary" />
		public MANUFACTURERValue MANUFACTURER => _MANUFACTURER ?? (_MANUFACTURER = new MANUFACTURERValue());

		/// <summary>﻿manufacturer of a piece of equipment or <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for OriginatorEnum.<br/>
		/// <br/>See also <seealso cref="OriginatorEnum">OriginatorEnum</seealso>
		/// </summary>
		public sealed class MANUFACTURERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MANUFACTURER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;manufacturer of a piece of equipment or {{block(Component)}}.&#10;
";
		}
		private USERValue _USER;
		/// <inheritdoc cref="USERValue" path="/summary" />
		public USERValue USER => _USER ?? (_USER = new USERValue());

		/// <summary>﻿owner or implementer of a piece of equipment or <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for OriginatorEnum.<br/>
		/// <br/>See also <seealso cref="OriginatorEnum">OriginatorEnum</seealso>
		/// </summary>
		public sealed class USERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "USER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;owner or implementer of a piece of equipment or {{block(Component)}}.&#10;
";
		}
	}
}