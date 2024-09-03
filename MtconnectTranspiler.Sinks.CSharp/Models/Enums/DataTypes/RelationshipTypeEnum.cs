#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_17E78CC7_671B_40bb_91A0_1F7CC06799BF">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum RelationshipTypeEnum
	{
		/// <summary>﻿functions as a parent in the relationship with the associated element.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		PARENT,
		/// <summary>﻿functions as a child in the relationship with the associated element.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		CHILD,
		/// <summary>﻿functions as a peer which provides equal functionality and capabilities in the relationship with the associated element.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		PEER,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_17E78CC7_671B_40bb_91A0_1F7CC06799BF">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RelationshipTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="RelationshipTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_17E78CC7_671B_40bb_91A0_1F7CC06799BF";
		/// <summary>Constant value for <see cref="RelationshipTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_17E78CC7_671B_40bb_91A0_1F7CC06799BF";
		/// <summary>Constant value for <see cref="RelationshipTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "RelationshipTypeEnum";
		/// <summary>Constant value for <see cref="RelationshipTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.5";
		/// <summary>Constant value for <see cref="RelationshipTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="RelationshipTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(RelationshipTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		PARENT,
		CHILD,
		PEER,
		};

		private PARENTValue _PARENT;
		/// <inheritdoc cref="PARENTValue" path="/summary" />
		public PARENTValue PARENT => _PARENT ?? (_PARENT = new PARENTValue());

		/// <summary>﻿functions as a parent in the relationship with the associated element.<br /><br /><br />
		/// Value for RelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="RelationshipTypeEnum">RelationshipTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class PARENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PARENTValue.Name" /></summary>
			public const string NAME = "PARENT";
			/// <summary>Constant value for <see cref="PARENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PARENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PARENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;functions as a parent in the relationship with the associated element.&#10;
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
		private CHILDValue _CHILD;
		/// <inheritdoc cref="CHILDValue" path="/summary" />
		public CHILDValue CHILD => _CHILD ?? (_CHILD = new CHILDValue());

		/// <summary>﻿functions as a child in the relationship with the associated element.<br /><br /><br />
		/// Value for RelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="RelationshipTypeEnum">RelationshipTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHILDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHILDValue.Name" /></summary>
			public const string NAME = "CHILD";
			/// <summary>Constant value for <see cref="CHILDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="CHILDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHILDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;functions as a child in the relationship with the associated element.&#10;
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
		private PEERValue _PEER;
		/// <inheritdoc cref="PEERValue" path="/summary" />
		public PEERValue PEER => _PEER ?? (_PEER = new PEERValue());

		/// <summary>﻿functions as a peer which provides equal functionality and capabilities in the relationship with the associated element.<br /><br /><br />
		/// Value for RelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="RelationshipTypeEnum">RelationshipTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class PEERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PEERValue.Name" /></summary>
			public const string NAME = "PEER";
			/// <summary>Constant value for <see cref="PEERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PEERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PEERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;functions as a peer which provides equal functionality and capabilities in the relationship with the associated element.&#10;
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