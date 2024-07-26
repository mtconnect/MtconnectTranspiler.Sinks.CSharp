
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Configurations.Relationships;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RelationshipsPackage {


	private Package.ConfigurationRelationshipClass _ConfigurationRelationship;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ConfigurationRelationshipClass ConfigurationRelationship => _ConfigurationRelationship ?? (_ConfigurationRelationship = new Package.ConfigurationRelationshipClass());

	private Package.ComponentRelationshipClass _ComponentRelationship;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ComponentRelationshipClass ComponentRelationship => _ComponentRelationship ?? (_ComponentRelationship = new Package.ComponentRelationshipClass());

	private Package.DeviceRelationshipClass _DeviceRelationship;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeviceRelationshipClass DeviceRelationship => _DeviceRelationship ?? (_DeviceRelationship = new Package.DeviceRelationshipClass());

	private Package.AssetRelationshipClass _AssetRelationship;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AssetRelationshipClass AssetRelationship => _AssetRelationship ?? (_AssetRelationship = new Package.AssetRelationshipClass());
	}
}