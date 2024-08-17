#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605645712659_8263_2990">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum DataItemRelationshipTypeEnum
	{
		/// <summary>﻿reference to a <see cref="DataItem">DataItem</see> that associates the values with an external entity.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ATTACHMENT,
		/// <summary>﻿referenced <see cref="DataItem">DataItem</see> provides the <c>id</c> of the effective Coordinate System.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		COORDINATE_SYSTEM,
		/// <summary>﻿referenced <see cref="DataItem">DataItem</see> provides process limits.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		LIMIT,
		/// <summary>﻿referenced <see cref="DataItem">DataItem</see> provides the observed values.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		OBSERVATION,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605645712659_8263_2990">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DataItemRelationshipTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "DataItemRelationshipTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(DataItemRelationshipTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.7";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ATTACHMENT,
		COORDINATE_SYSTEM,
		LIMIT,
		OBSERVATION,
		};

		private ATTACHMENTValue _ATTACHMENT;
		/// <inheritdoc cref="ATTACHMENTValue" path="/summary" />
		public ATTACHMENTValue ATTACHMENT => _ATTACHMENT ?? (_ATTACHMENT = new ATTACHMENTValue());

		/// <summary>﻿reference to a <see cref="DataItem">DataItem</see> that associates the values with an external entity.<br /><br /><br /><br />
		/// Value for DataItemRelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemRelationshipTypeEnum">DataItemRelationshipTypeEnum</seealso>
		/// </summary>
		public sealed class ATTACHMENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ATTACHMENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;reference to a {{block(DataItem)}} that associates the values with an external entity.&#10;
";
		}
		private COORDINATE_SYSTEMValue _COORDINATE_SYSTEM;
		/// <inheritdoc cref="COORDINATE_SYSTEMValue" path="/summary" />
		public COORDINATE_SYSTEMValue COORDINATE_SYSTEM => _COORDINATE_SYSTEM ?? (_COORDINATE_SYSTEM = new COORDINATE_SYSTEMValue());

		/// <summary>﻿referenced <see cref="DataItem">DataItem</see> provides the <c>id</c> of the effective Coordinate System.<br /><br /><br /><br />
		/// Value for DataItemRelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemRelationshipTypeEnum">DataItemRelationshipTypeEnum</seealso>
		/// </summary>
		public sealed class COORDINATE_SYSTEMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COORDINATE_SYSTEM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;referenced {{block(DataItem)}} provides the `id` of the effective Coordinate System.&#10;
";
		}
		private LIMITValue _LIMIT;
		/// <inheritdoc cref="LIMITValue" path="/summary" />
		public LIMITValue LIMIT => _LIMIT ?? (_LIMIT = new LIMITValue());

		/// <summary>﻿referenced <see cref="DataItem">DataItem</see> provides process limits.<br /><br /><br /><br />
		/// Value for DataItemRelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemRelationshipTypeEnum">DataItemRelationshipTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;referenced {{block(DataItem)}} provides process limits.&#10;
";
		}
		private OBSERVATIONValue _OBSERVATION;
		/// <inheritdoc cref="OBSERVATIONValue" path="/summary" />
		public OBSERVATIONValue OBSERVATION => _OBSERVATION ?? (_OBSERVATION = new OBSERVATIONValue());

		/// <summary>﻿referenced <see cref="DataItem">DataItem</see> provides the observed values.<br /><br /><br /><br />
		/// Value for DataItemRelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemRelationshipTypeEnum">DataItemRelationshipTypeEnum</seealso>
		/// </summary>
		public sealed class OBSERVATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OBSERVATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;referenced {{block(DataItem)}} provides the observed values.&#10;
";
		}
	}
}