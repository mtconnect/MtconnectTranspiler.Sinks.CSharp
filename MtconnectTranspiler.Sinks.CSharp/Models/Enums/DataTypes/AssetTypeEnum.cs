#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// </list>
		/// </remarks>
		CUTTINGTOOL,
		/// <summary>﻿<see cref="File">File</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		FILE,
		/// <summary>﻿<see cref="QIFDocumentWrapper">QIFDocumentWrapper</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		QIFDOCUMENTWRAPPER,
		/// <summary>﻿<see cref="RawMaterial">RawMaterial</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		RAWMATERIAL,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CUTTINGTOOLARCHETYPE,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		FILEARCHETYPE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612349180903_336283_32">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AssetTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "AssetTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(AssetTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "2.1";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class CuttingToolValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CuttingTool";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(CuttingTool)}} {{block(Asset)}} type.&#10;
";
		}
		private FileValue _File;
		/// <inheritdoc cref="FileValue" path="/summary" />
		public FileValue File => _File ?? (_File = new FileValue());

		/// <summary>﻿<see cref="File">File</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		public sealed class FileValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "File";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(File)}} {{block(Asset)}} type. &#10;
";
		}
		private QIFDocumentWrapperValue _QIFDocumentWrapper;
		/// <inheritdoc cref="QIFDocumentWrapperValue" path="/summary" />
		public QIFDocumentWrapperValue QIFDocumentWrapper => _QIFDocumentWrapper ?? (_QIFDocumentWrapper = new QIFDocumentWrapperValue());

		/// <summary>﻿<see cref="QIFDocumentWrapper">QIFDocumentWrapper</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		public sealed class QIFDocumentWrapperValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "QIFDocumentWrapper";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(QIFDocumentWrapper)}} {{block(Asset)}} type. &#10;
";
		}
		private RawMaterialValue _RawMaterial;
		/// <inheritdoc cref="RawMaterialValue" path="/summary" />
		public RawMaterialValue RawMaterial => _RawMaterial ?? (_RawMaterial = new RawMaterialValue());

		/// <summary>﻿<see cref="RawMaterial">RawMaterial</see> <see cref="Asset">Asset</see> type. <br /><br /><br />
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		public sealed class RawMaterialValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RawMaterial";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(RawMaterial)}} {{block(Asset)}} type. &#10;
";
		}
		private CuttingToolArchetypeValue _CuttingToolArchetype;
		/// <inheritdoc cref="CuttingToolArchetypeValue" path="/summary" />
		public CuttingToolArchetypeValue CuttingToolArchetype => _CuttingToolArchetype ?? (_CuttingToolArchetype = new CuttingToolArchetypeValue());

		/// <summary>﻿
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		public sealed class CuttingToolArchetypeValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CuttingToolArchetype";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private FileArchetypeValue _FileArchetype;
		/// <inheritdoc cref="FileArchetypeValue" path="/summary" />
		public FileArchetypeValue FileArchetype => _FileArchetype ?? (_FileArchetype = new FileArchetypeValue());

		/// <summary>﻿
		/// Value for AssetTypeEnum.<br/>
		/// <br/>See also <seealso cref="AssetTypeEnum">AssetTypeEnum</seealso>
		/// </summary>
		public sealed class FileArchetypeValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FileArchetype";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
	}
}