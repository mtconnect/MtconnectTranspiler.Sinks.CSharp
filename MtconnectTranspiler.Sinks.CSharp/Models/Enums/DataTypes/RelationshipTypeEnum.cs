#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <inheritdoc />
		public string Name => "RelationshipTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(RelationshipTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.5";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class PARENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PARENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;functions as a parent in the relationship with the associated element.&#10;
";
		}
		private CHILDValue _CHILD;
		/// <inheritdoc cref="CHILDValue" path="/summary" />
		public CHILDValue CHILD => _CHILD ?? (_CHILD = new CHILDValue());

		/// <summary>﻿functions as a child in the relationship with the associated element.<br /><br /><br />
		/// Value for RelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="RelationshipTypeEnum">RelationshipTypeEnum</seealso>
		/// </summary>
		public sealed class CHILDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHILD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;functions as a child in the relationship with the associated element.&#10;
";
		}
		private PEERValue _PEER;
		/// <inheritdoc cref="PEERValue" path="/summary" />
		public PEERValue PEER => _PEER ?? (_PEER = new PEERValue());

		/// <summary>﻿functions as a peer which provides equal functionality and capabilities in the relationship with the associated element.<br /><br /><br />
		/// Value for RelationshipTypeEnum.<br/>
		/// <br/>See also <seealso cref="RelationshipTypeEnum">RelationshipTypeEnum</seealso>
		/// </summary>
		public sealed class PEERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PEER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;functions as a peer which provides equal functionality and capabilities in the relationship with the associated element.&#10;
";
		}
	}
}