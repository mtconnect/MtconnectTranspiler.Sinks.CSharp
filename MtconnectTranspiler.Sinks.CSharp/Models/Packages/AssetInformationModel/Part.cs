#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Part;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="Part">Part</see> model.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_68e0225_1758716677150_270977_16">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public class PartPackage : IPackage
	{
		/// <summary>Constant value for <see cref="PartPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1758716677150_270977_16";
		/// <summary>Constant value for <see cref="PartPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_68e0225_1758716677150_270977_16";
		/// <summary>Constant value for <see cref="PartPackage.Name" /></summary>
		public const string NAME = "Part";
		/// <summary>Constant value for <see cref="PartPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(Part)}} model.&#10;
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
			IdentifierClass,
			GroupIdentifierGeneralization,
			PartArchetypeClass,
			CustomerClass,
			PartClass,
			UniqueIdentifierGeneralization,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.IdentifierClass _IdentifierClass;
	/// <summary>
	/// <inheritdoc cref="Package.IdentifierClass" path="/summary" />
	/// </summary>
	public Package.IdentifierClass IdentifierClass => _IdentifierClass ?? (_IdentifierClass = new Package.IdentifierClass());

	private Package.GroupIdentifierGeneralization _GroupIdentifierGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.GroupIdentifierGeneralization" path="/summary" />
	/// </summary>
	public Package.GroupIdentifierGeneralization GroupIdentifierGeneralization => _GroupIdentifierGeneralization ?? (_GroupIdentifierGeneralization = new Package.GroupIdentifierGeneralization());

	private Package.PartArchetypeClass _PartArchetypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartArchetypeClass" path="/summary" />
	/// </summary>
	public Package.PartArchetypeClass PartArchetypeClass => _PartArchetypeClass ?? (_PartArchetypeClass = new Package.PartArchetypeClass());

	private Package.CustomerClass _CustomerClass;
	/// <summary>
	/// <inheritdoc cref="Package.CustomerClass" path="/summary" />
	/// </summary>
	public Package.CustomerClass CustomerClass => _CustomerClass ?? (_CustomerClass = new Package.CustomerClass());

	private Package.PartClass _PartClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartClass" path="/summary" />
	/// </summary>
	public Package.PartClass PartClass => _PartClass ?? (_PartClass = new Package.PartClass());

	private Package.UniqueIdentifierGeneralization _UniqueIdentifierGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.UniqueIdentifierGeneralization" path="/summary" />
	/// </summary>
	public Package.UniqueIdentifierGeneralization UniqueIdentifierGeneralization => _UniqueIdentifierGeneralization ?? (_UniqueIdentifierGeneralization = new Package.UniqueIdentifierGeneralization());

	#endregion

	#region Enums
	#endregion
	}
}
