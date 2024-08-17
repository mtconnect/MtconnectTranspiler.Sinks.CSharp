#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.Relationships;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>﻿This section provides semantic information for the <see cref="ConfigurationRelationship">ConfigurationRelationship</see> entity.<br /><br />![Relationships](figures/Relationships.png "Relationships"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.<br /><br />![Relationship Example](figures/Relationship%20Example.png "Relationship Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(relationship-example)}} for the <i>XML</i> representation of the same example.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_A055F7A8_3D2C_4a01_8D09_072F34E65044">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class RelationshipsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_A055F7A8_3D2C_4a01_8D09_072F34E65044";
		
		/// <inheritdoc />
		public string Name => "Relationships";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(ConfigurationRelationship)}} entity.

![Relationships](figures/Relationships.png ""Relationships""){: width=""0.8""}

> Note: See {{sect(Configuration Schema Diagrams)}} for XML schema.

![Relationship Example](figures/Relationship%20Example.png ""Relationship Example""){: width=""0.8""}

> Note: See {{lst(relationship-example)}} for the {{term(XML)}} representation of the same example.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ConfigurationRelationshipClass,
			ComponentRelationshipClass,
			DeviceRelationshipClass,
			AssetRelationshipClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.ConfigurationRelationshipClass _ConfigurationRelationshipClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConfigurationRelationshipClass" path="/summary" />
	/// </summary>
	public Package.ConfigurationRelationshipClass ConfigurationRelationshipClass => _ConfigurationRelationshipClass ?? (_ConfigurationRelationshipClass = new Package.ConfigurationRelationshipClass());

	private Package.ComponentRelationshipClass _ComponentRelationshipClass;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentRelationshipClass" path="/summary" />
	/// </summary>
	public Package.ComponentRelationshipClass ComponentRelationshipClass => _ComponentRelationshipClass ?? (_ComponentRelationshipClass = new Package.ComponentRelationshipClass());

	private Package.DeviceRelationshipClass _DeviceRelationshipClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceRelationshipClass" path="/summary" />
	/// </summary>
	public Package.DeviceRelationshipClass DeviceRelationshipClass => _DeviceRelationshipClass ?? (_DeviceRelationshipClass = new Package.DeviceRelationshipClass());

	private Package.AssetRelationshipClass _AssetRelationshipClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetRelationshipClass" path="/summary" />
	/// </summary>
	public Package.AssetRelationshipClass AssetRelationshipClass => _AssetRelationshipClass ?? (_AssetRelationshipClass = new Package.AssetRelationshipClass());

	#endregion

	#region Enums
	#endregion
	}
}