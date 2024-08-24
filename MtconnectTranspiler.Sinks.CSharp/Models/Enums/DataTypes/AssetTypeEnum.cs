#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612349180903_336283_32">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum AssetTypeEnum
	{
		/// <summary>﻿<see cref="CuttingTool">CuttingTool</see> <see cref="Asset">Asset</see> type.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		CUTTINGTOOL,
		/// <summary>﻿<see cref="File">File</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		FILE,
		/// <summary>﻿<see cref="QIFDocumentWrapper">QIFDocumentWrapper</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		QIFDOCUMENTWRAPPER,
		/// <summary>﻿<see cref="RawMaterial">RawMaterial</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		RAWMATERIAL,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		CUTTINGTOOLARCHETYPE,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		FILEARCHETYPE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612349180903_336283_32">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AssetTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="AssetTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1612349180903_336283_32";
		/// <summary>Constant value for <see cref="AssetTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612349180903_336283_32";
		/// <summary>Constant value for <see cref="AssetTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "AssetTypeEnum";
		/// <summary>Constant value for <see cref="AssetTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="AssetTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "2.1";
		/// <summary>Constant value for <see cref="AssetTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(AssetTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CuttingTool,
		File,
		QIFDocumentWrapper,
		RawMaterial,
		CuttingToolArchetype,
		FileArchetype,
		};

		private CuttingToolValue _CuttingTool;
		/// <inheritdoc cref="CuttingToolValue" path="/summary" />
		public CuttingToolValue CuttingTool => _CuttingTool ?? (_CuttingTool = new CuttingToolValue());

		/// <summary>﻿<see cref="CuttingTool">CuttingTool</see> <see cref="Asset">Asset</see> type.<br /><br /><br />
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		public sealed class CuttingToolValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CuttingToolValue.Name" /></summary>
			public const string NAME = "CuttingTool";
			/// <summary>Constant value for <see cref="CuttingToolValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="CuttingToolValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CuttingToolValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(CuttingTool)}} {{block(Asset)}} type.&#10;
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
		private FileValue _File;
		/// <inheritdoc cref="FileValue" path="/summary" />
		public FileValue File => _File ?? (_File = new FileValue());

		/// <summary>﻿<see cref="File">File</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		public sealed class FileValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FileValue.Name" /></summary>
			public const string NAME = "File";
			/// <summary>Constant value for <see cref="FileValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="FileValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FileValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(File)}} {{block(Asset)}} type. &#10;
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
		private QIFDocumentWrapperValue _QIFDocumentWrapper;
		/// <inheritdoc cref="QIFDocumentWrapperValue" path="/summary" />
		public QIFDocumentWrapperValue QIFDocumentWrapper => _QIFDocumentWrapper ?? (_QIFDocumentWrapper = new QIFDocumentWrapperValue());

		/// <summary>﻿<see cref="QIFDocumentWrapper">QIFDocumentWrapper</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		public sealed class QIFDocumentWrapperValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="QIFDocumentWrapperValue.Name" /></summary>
			public const string NAME = "QIFDocumentWrapper";
			/// <summary>Constant value for <see cref="QIFDocumentWrapperValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="QIFDocumentWrapperValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="QIFDocumentWrapperValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(QIFDocumentWrapper)}} {{block(Asset)}} type. &#10;
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
		private RawMaterialValue _RawMaterial;
		/// <inheritdoc cref="RawMaterialValue" path="/summary" />
		public RawMaterialValue RawMaterial => _RawMaterial ?? (_RawMaterial = new RawMaterialValue());

		/// <summary>﻿<see cref="RawMaterial">RawMaterial</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		public sealed class RawMaterialValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RawMaterialValue.Name" /></summary>
			public const string NAME = "RawMaterial";
			/// <summary>Constant value for <see cref="RawMaterialValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="RawMaterialValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RawMaterialValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(RawMaterial)}} {{block(Asset)}} type. &#10;
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
		private CuttingToolArchetypeValue _CuttingToolArchetype;
		/// <inheritdoc cref="CuttingToolArchetypeValue" path="/summary" />
		public CuttingToolArchetypeValue CuttingToolArchetype => _CuttingToolArchetype ?? (_CuttingToolArchetype = new CuttingToolArchetypeValue());

		/// <summary>﻿
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		public sealed class CuttingToolArchetypeValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CuttingToolArchetypeValue.Name" /></summary>
			public const string NAME = "CuttingToolArchetype";
			/// <summary>Constant value for <see cref="CuttingToolArchetypeValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="CuttingToolArchetypeValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CuttingToolArchetypeValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private FileArchetypeValue _FileArchetype;
		/// <inheritdoc cref="FileArchetypeValue" path="/summary" />
		public FileArchetypeValue FileArchetype => _FileArchetype ?? (_FileArchetype = new FileArchetypeValue());

		/// <summary>﻿
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v2.1 according to https://model.mtconnect.org/#_Version_2.1")]

		public sealed class FileArchetypeValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FileArchetypeValue.Name" /></summary>
			public const string NAME = "FileArchetype";
			/// <summary>Constant value for <see cref="FileArchetypeValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="FileArchetypeValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FileArchetypeValue.Summary" /></summary>
			public const string SUMMARY = @"";

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