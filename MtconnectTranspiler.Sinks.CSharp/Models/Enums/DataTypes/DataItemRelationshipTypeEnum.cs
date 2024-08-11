using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605645712659_8263_2990">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum DataItemRelationshipTypeEnum
	{
		/// <summary>
		/// reference to a <see cref="DataItem">DataItem</see> that associates the values with an external entity. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ATTACHMENT,
		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides the <c>id</c> of the effective Coordinate System. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		COORDINATE_SYSTEM,
		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides process limits. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		LIMIT,
		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides the observed values. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		OBSERVATION,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605645712659_8263_2990">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DataItemRelationshipTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "DataItemRelationshipTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
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
		/// <summary>
		/// reference to a <see cref="DataItem">DataItem</see> that associates the values with an external entity. 
		/// </summary>
		public ATTACHMENTValue ATTACHMENT => _ATTACHMENT ?? (_ATTACHMENT = new ATTACHMENTValue());

		/// <summary>
		/// reference to a <see cref="DataItem">DataItem</see> that associates the values with an external entity. 
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
			public string Summary => @"/// reference to a <see cref=""DataItem"">DataItem</see> that associates the values with an external entity. ";
		}
		private COORDINATE_SYSTEMValue _COORDINATE_SYSTEM;
		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides the <c>id</c> of the effective Coordinate System. 
		/// </summary>
		public COORDINATE_SYSTEMValue COORDINATE_SYSTEM => _COORDINATE_SYSTEM ?? (_COORDINATE_SYSTEM = new COORDINATE_SYSTEMValue());

		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides the <c>id</c> of the effective Coordinate System. 
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
			public string Summary => @"/// referenced <see cref=""DataItem"">DataItem</see> provides the <c>id</c> of the effective Coordinate System. ";
		}
		private LIMITValue _LIMIT;
		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides process limits. 
		/// </summary>
		public LIMITValue LIMIT => _LIMIT ?? (_LIMIT = new LIMITValue());

		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides process limits. 
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
			public string Summary => @"/// referenced <see cref=""DataItem"">DataItem</see> provides process limits. ";
		}
		private OBSERVATIONValue _OBSERVATION;
		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides the observed values. 
		/// </summary>
		public OBSERVATIONValue OBSERVATION => _OBSERVATION ?? (_OBSERVATION = new OBSERVATIONValue());

		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides the observed values. 
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
			public string Summary => @"/// referenced <see cref=""DataItem"">DataItem</see> provides the observed values. ";
		}
	}
}