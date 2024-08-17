#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640702052373_905765_57">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum PartCountTypeEnum
	{
		/// <summary>﻿count is of individual items.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		EACH,
		/// <summary>﻿pre-specified group of items.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		BATCH,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640702052373_905765_57">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PartCountTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "PartCountTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(PartCountTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		EACH,
		BATCH,
		};

		private EACHValue _EACH;
		/// <inheritdoc cref="EACHValue" path="/summary" />
		public EACHValue EACH => _EACH ?? (_EACH = new EACHValue());

		/// <summary>﻿count is of individual items.<br /><br /><br />
		/// Value for PartCountTypeEnum.<br/>
		/// <br/>See also <seealso cref="PartCountTypeEnum">PartCountTypeEnum</seealso>
		/// </summary>
		public sealed class EACHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EACH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;count is of individual items.&#10;
";
		}
		private BATCHValue _BATCH;
		/// <inheritdoc cref="BATCHValue" path="/summary" />
		public BATCHValue BATCH => _BATCH ?? (_BATCH = new BATCHValue());

		/// <summary>﻿pre-specified group of items.<br /><br /><br />
		/// Value for PartCountTypeEnum.<br/>
		/// <br/>See also <seealso cref="PartCountTypeEnum">PartCountTypeEnum</seealso>
		/// </summary>
		public sealed class BATCHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BATCH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;pre-specified group of items.&#10;
";
		}
	}
}