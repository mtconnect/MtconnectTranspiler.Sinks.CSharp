using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.Relationships;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RelationshipsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			ConfigurationRelationshipClass,
			ComponentRelationshipClass,
			DeviceRelationshipClass,
			AssetRelationshipClass,
		};

	private Package.ConfigurationRelationshipClass _ConfigurationRelationshipClass;
	public Package.ConfigurationRelationshipClass ConfigurationRelationshipClass => _ConfigurationRelationshipClass ?? (_ConfigurationRelationshipClass = new Package.ConfigurationRelationshipClass());
	private Package.ComponentRelationshipClass _ComponentRelationshipClass;
	public Package.ComponentRelationshipClass ComponentRelationshipClass => _ComponentRelationshipClass ?? (_ComponentRelationshipClass = new Package.ComponentRelationshipClass());
	private Package.DeviceRelationshipClass _DeviceRelationshipClass;
	public Package.DeviceRelationshipClass DeviceRelationshipClass => _DeviceRelationshipClass ?? (_DeviceRelationshipClass = new Package.DeviceRelationshipClass());
	private Package.AssetRelationshipClass _AssetRelationshipClass;
	public Package.AssetRelationshipClass AssetRelationshipClass => _AssetRelationshipClass ?? (_AssetRelationshipClass = new Package.AssetRelationshipClass());
	}
}