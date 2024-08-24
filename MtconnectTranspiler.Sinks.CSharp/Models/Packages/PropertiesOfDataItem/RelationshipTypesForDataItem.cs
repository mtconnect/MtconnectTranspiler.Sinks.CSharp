#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>﻿This section provides semantic information for the types of <see cref="AbstractDataItemRelationship">AbstractDataItemRelationship</see> that can be defined for a <see cref="DataItem">DataItem</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1605645450472_400925_2872">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class RelationshipTypesForDataItemPackage : IPackage
	{
		/// <summary>Constant value for <see cref="RelationshipTypesForDataItemPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605645450472_400925_2872";
		/// <summary>Constant value for <see cref="RelationshipTypesForDataItemPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1605645450472_400925_2872";
		/// <summary>Constant value for <see cref="RelationshipTypesForDataItemPackage.Name" /></summary>
		public const string NAME = "Relationship Types for DataItem";
		/// <summary>Constant value for <see cref="RelationshipTypesForDataItemPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the types of {{block(AbstractDataItemRelationship)}} that can be defined for a {{block(DataItem)}}.&#10;
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
			SpecificationRelationshipClass,
			DataItemRelationshipClass,
			AbstractDataItemRelationshipClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.SpecificationRelationshipClass _SpecificationRelationshipClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpecificationRelationshipClass" path="/summary" />
	/// </summary>
	public Package.SpecificationRelationshipClass SpecificationRelationshipClass => _SpecificationRelationshipClass ?? (_SpecificationRelationshipClass = new Package.SpecificationRelationshipClass());

	private Package.DataItemRelationshipClass _DataItemRelationshipClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemRelationshipClass" path="/summary" />
	/// </summary>
	public Package.DataItemRelationshipClass DataItemRelationshipClass => _DataItemRelationshipClass ?? (_DataItemRelationshipClass = new Package.DataItemRelationshipClass());

	private Package.AbstractDataItemRelationshipClass _AbstractDataItemRelationshipClass;
	/// <summary>
	/// <inheritdoc cref="Package.AbstractDataItemRelationshipClass" path="/summary" />
	/// </summary>
	public Package.AbstractDataItemRelationshipClass AbstractDataItemRelationshipClass => _AbstractDataItemRelationshipClass ?? (_AbstractDataItemRelationshipClass = new Package.AbstractDataItemRelationshipClass());

	#endregion

	#region Enums
	#endregion
	}
}