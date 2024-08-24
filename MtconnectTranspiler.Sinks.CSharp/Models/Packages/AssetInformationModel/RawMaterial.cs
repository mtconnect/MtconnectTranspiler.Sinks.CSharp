#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.RawMaterial;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="RawMaterial">RawMaterial</see> model.<br /><br />![RawMaterial](figures/RawMaterial.png "RawMaterial"){: width="0.5"}<br /><br />&gt; Note: See <see cref="RawMaterial Schema Diagrams">RawMaterial Schema Diagrams</see> for XML schema.<br /><br /><br />Raw Material Asset Information Model<br /><br />Raw material represents the source of material for immediate use and sources of material that may or may not be used during the manufacturing process.<br /><br />The <see cref="RawMaterial">RawMaterial</see> <see cref="Asset">Asset</see> holds the references to the content stored in the actual <see cref="RawMaterial">RawMaterial</see> container or derived about the <see cref="RawMaterial">RawMaterial</see> by the system during operation.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1618829862497_960144_123">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class RawMaterialPackage : IPackage
	{
		/// <summary>Constant value for <see cref="RawMaterialPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1618829862497_960144_123";
		/// <summary>Constant value for <see cref="RawMaterialPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1618829862497_960144_123";
		/// <summary>Constant value for <see cref="RawMaterialPackage.Name" /></summary>
		public const string NAME = "Raw Material";
		/// <summary>Constant value for <see cref="RawMaterialPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(RawMaterial)}} model.

![RawMaterial](figures/RawMaterial.png ""RawMaterial""){: width=""0.5""}

> Note: See {{sect(RawMaterial Schema Diagrams)}} for XML schema.&#10;
&#10;&#10;&#10;Raw Material Asset Information Model&#10;&#10;&#10;&#10;Raw material represents the source of material for immediate use and sources of material that may or may not be used during the manufacturing process.

The {{block(RawMaterial)}} {{block(Asset)}} holds the references to the content stored in the actual {{block(RawMaterial)}} container or derived about the {{block(RawMaterial)}} by the system during operation.&#10;
";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			RawMaterialClass,
			MaterialClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.RawMaterialClass _RawMaterialClass;
	/// <summary>
	/// <inheritdoc cref="Package.RawMaterialClass" path="/summary" />
	/// </summary>
	public Package.RawMaterialClass RawMaterialClass => _RawMaterialClass ?? (_RawMaterialClass = new Package.RawMaterialClass());

	private Package.MaterialClass _MaterialClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialClass" path="/summary" />
	/// </summary>
	public Package.MaterialClass MaterialClass => _MaterialClass ?? (_MaterialClass = new Package.MaterialClass());

	#endregion

	#region Enums
	#endregion
	}
}