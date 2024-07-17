using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel;
// using Mtconnect;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class DeviceInformationModelPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			ComponentsPackage,
			CompositionsPackage,
			DataItemsPackage,
			ReferencesPackage,
			ConfigurationsPackage,
		};

		public IClass[] Classes => new IClass[] {
			DeviceClass,
		};
	private Package.ComponentsPackage _ComponentsPackage;
	public Package.ComponentsPackage ComponentsPackage => _ComponentsPackage ?? (_ComponentsPackage = new Package.ComponentsPackage());
	private Package.CompositionsPackage _CompositionsPackage;
	public Package.CompositionsPackage CompositionsPackage => _CompositionsPackage ?? (_CompositionsPackage = new Package.CompositionsPackage());
	private Package.DataItemsPackage _DataItemsPackage;
	public Package.DataItemsPackage DataItemsPackage => _DataItemsPackage ?? (_DataItemsPackage = new Package.DataItemsPackage());
	private Package.ReferencesPackage _ReferencesPackage;
	public Package.ReferencesPackage ReferencesPackage => _ReferencesPackage ?? (_ReferencesPackage = new Package.ReferencesPackage());
	private Package.ConfigurationsPackage _ConfigurationsPackage;
	public Package.ConfigurationsPackage ConfigurationsPackage => _ConfigurationsPackage ?? (_ConfigurationsPackage = new Package.ConfigurationsPackage());

	private Package.DeviceClass _DeviceClass;
	public Package.DeviceClass DeviceClass => _DeviceClass ?? (_DeviceClass = new Package.DeviceClass());
	}
}