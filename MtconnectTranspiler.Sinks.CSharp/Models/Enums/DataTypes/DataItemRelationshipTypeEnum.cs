#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="DataItemRelationshipTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605645712659_8263_2990";
		/// <summary>Constant value for <see cref="DataItemRelationshipTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605645712659_8263_2990";
		/// <summary>Constant value for <see cref="DataItemRelationshipTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "DataItemRelationshipTypeEnum";
		/// <summary>Constant value for <see cref="DataItemRelationshipTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="DataItemRelationshipTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="DataItemRelationshipTypeEnumMetaClass.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(DataItemRelationshipTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class ATTACHMENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ATTACHMENTValue.Name" /></summary>
			public const string NAME = "ATTACHMENT";
			/// <summary>Constant value for <see cref="ATTACHMENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ATTACHMENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ATTACHMENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;reference to a {{block(DataItem)}} that associates the values with an external entity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private COORDINATE_SYSTEMValue _COORDINATE_SYSTEM;
		/// <inheritdoc cref="COORDINATE_SYSTEMValue" path="/summary" />
		public COORDINATE_SYSTEMValue COORDINATE_SYSTEM => _COORDINATE_SYSTEM ?? (_COORDINATE_SYSTEM = new COORDINATE_SYSTEMValue());

		/// <summary>﻿referenced <see cref="DataItem">DataItem</see> provides the <c>id</c> of the effective Coordinate System.<br /><br /><br /><br />
		/// Value for DataItemRelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemRelationshipTypeEnum">DataItemRelationshipTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class COORDINATE_SYSTEMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COORDINATE_SYSTEMValue.Name" /></summary>
			public const string NAME = "COORDINATE_SYSTEM";
			/// <summary>Constant value for <see cref="COORDINATE_SYSTEMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="COORDINATE_SYSTEMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COORDINATE_SYSTEMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;referenced {{block(DataItem)}} provides the `id` of the effective Coordinate System.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LIMITValue _LIMIT;
		/// <inheritdoc cref="LIMITValue" path="/summary" />
		public LIMITValue LIMIT => _LIMIT ?? (_LIMIT = new LIMITValue());

		/// <summary>﻿referenced <see cref="DataItem">DataItem</see> provides process limits.<br /><br /><br /><br />
		/// Value for DataItemRelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemRelationshipTypeEnum">DataItemRelationshipTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class LIMITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LIMITValue.Name" /></summary>
			public const string NAME = "LIMIT";
			/// <summary>Constant value for <see cref="LIMITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="LIMITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LIMITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;referenced {{block(DataItem)}} provides process limits.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private OBSERVATIONValue _OBSERVATION;
		/// <inheritdoc cref="OBSERVATIONValue" path="/summary" />
		public OBSERVATIONValue OBSERVATION => _OBSERVATION ?? (_OBSERVATION = new OBSERVATIONValue());

		/// <summary>﻿referenced <see cref="DataItem">DataItem</see> provides the observed values.<br /><br /><br /><br />
		/// Value for DataItemRelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemRelationshipTypeEnum">DataItemRelationshipTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class OBSERVATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OBSERVATIONValue.Name" /></summary>
			public const string NAME = "OBSERVATION";
			/// <summary>Constant value for <see cref="OBSERVATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="OBSERVATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OBSERVATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;referenced {{block(DataItem)}} provides the observed values.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
	}
}