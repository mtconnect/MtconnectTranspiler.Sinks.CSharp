#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605646000929_248969_3052">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum SpecificationRelationshipTypeEnum
	{
		/// <summary>﻿referenced <see cref="Specification">Specification</see> provides process limits.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		LIMIT,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605646000929_248969_3052">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SpecificationRelationshipTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "SpecificationRelationshipTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(SpecificationRelationshipTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.7";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		LIMIT,
		};

		private LIMITValue _LIMIT;
		/// <inheritdoc cref="LIMITValue" path="/summary" />
		public LIMITValue LIMIT => _LIMIT ?? (_LIMIT = new LIMITValue());

		/// <summary>﻿referenced <see cref="Specification">Specification</see> provides process limits.<br /><br /><br /><br />
		/// Value for SpecificationRelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="SpecificationRelationshipTypeEnum">SpecificationRelationshipTypeEnum</seealso>
		/// </summary>
		public sealed class LIMITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LIMIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;referenced {{block(Specification)}} provides process limits.&#10;
";
		}
	}
}