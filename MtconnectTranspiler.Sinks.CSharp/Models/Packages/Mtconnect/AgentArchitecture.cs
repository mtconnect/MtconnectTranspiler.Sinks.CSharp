using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture;
// using Mtconnect;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class AgentArchitecturePackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			RestPackage,
			SourcePackage,
			SinkPackage,
			TransformationPackage,
			PrinterPackage,
			ParserPackage,
			InformationModelPackage,
			PipelinesPackage,
		};

		public IClass[] Classes => new IClass[] {
			AgentClass,
			ServiceClass,
			RestSinkClass,
			DataSinkServiceGeneralization,
			MQTTSinkClass,
			DataSourceServiceGeneralization,
			RestServiceGeneralization,
			TransformationServiceGeneralization,
			StorageServiceGeneralization,
			RestSourceClass,
			MQTTSourceClass,
			SourceClass,
			PipelineClass,
			SinkClass,
			TransformtionClass,
			AssetStroageClass,
			OPCUASinkGeneralization,
			NCLinkClass,
			MQTTSinkGeneralization,
		};
	private Package.RestPackage _RestPackage;
	public Package.RestPackage RestPackage => _RestPackage ?? (_RestPackage = new Package.RestPackage());
	private Package.SourcePackage _SourcePackage;
	public Package.SourcePackage SourcePackage => _SourcePackage ?? (_SourcePackage = new Package.SourcePackage());
	private Package.SinkPackage _SinkPackage;
	public Package.SinkPackage SinkPackage => _SinkPackage ?? (_SinkPackage = new Package.SinkPackage());
	private Package.TransformationPackage _TransformationPackage;
	public Package.TransformationPackage TransformationPackage => _TransformationPackage ?? (_TransformationPackage = new Package.TransformationPackage());
	private Package.PrinterPackage _PrinterPackage;
	public Package.PrinterPackage PrinterPackage => _PrinterPackage ?? (_PrinterPackage = new Package.PrinterPackage());
	private Package.ParserPackage _ParserPackage;
	public Package.ParserPackage ParserPackage => _ParserPackage ?? (_ParserPackage = new Package.ParserPackage());
	private Package.InformationModelPackage _InformationModelPackage;
	public Package.InformationModelPackage InformationModelPackage => _InformationModelPackage ?? (_InformationModelPackage = new Package.InformationModelPackage());
	private Package.PipelinesPackage _PipelinesPackage;
	public Package.PipelinesPackage PipelinesPackage => _PipelinesPackage ?? (_PipelinesPackage = new Package.PipelinesPackage());

	private Package.AgentClass _AgentClass;
	public Package.AgentClass AgentClass => _AgentClass ?? (_AgentClass = new Package.AgentClass());
	private Package.ServiceClass _ServiceClass;
	public Package.ServiceClass ServiceClass => _ServiceClass ?? (_ServiceClass = new Package.ServiceClass());
	private Package.RestSinkClass _RestSinkClass;
	public Package.RestSinkClass RestSinkClass => _RestSinkClass ?? (_RestSinkClass = new Package.RestSinkClass());
	private Package.DataSinkServiceGeneralization _DataSinkServiceGeneralization;
	public Package.DataSinkServiceGeneralization DataSinkServiceGeneralization => _DataSinkServiceGeneralization ?? (_DataSinkServiceGeneralization = new Package.DataSinkServiceGeneralization());
	private Package.MQTTSinkClass _MQTTSinkClass;
	public Package.MQTTSinkClass MQTTSinkClass => _MQTTSinkClass ?? (_MQTTSinkClass = new Package.MQTTSinkClass());
	private Package.DataSourceServiceGeneralization _DataSourceServiceGeneralization;
	public Package.DataSourceServiceGeneralization DataSourceServiceGeneralization => _DataSourceServiceGeneralization ?? (_DataSourceServiceGeneralization = new Package.DataSourceServiceGeneralization());
	private Package.RestServiceGeneralization _RestServiceGeneralization;
	public Package.RestServiceGeneralization RestServiceGeneralization => _RestServiceGeneralization ?? (_RestServiceGeneralization = new Package.RestServiceGeneralization());
	private Package.TransformationServiceGeneralization _TransformationServiceGeneralization;
	public Package.TransformationServiceGeneralization TransformationServiceGeneralization => _TransformationServiceGeneralization ?? (_TransformationServiceGeneralization = new Package.TransformationServiceGeneralization());
	private Package.StorageServiceGeneralization _StorageServiceGeneralization;
	public Package.StorageServiceGeneralization StorageServiceGeneralization => _StorageServiceGeneralization ?? (_StorageServiceGeneralization = new Package.StorageServiceGeneralization());
	private Package.RestSourceClass _RestSourceClass;
	public Package.RestSourceClass RestSourceClass => _RestSourceClass ?? (_RestSourceClass = new Package.RestSourceClass());
	private Package.MQTTSourceClass _MQTTSourceClass;
	public Package.MQTTSourceClass MQTTSourceClass => _MQTTSourceClass ?? (_MQTTSourceClass = new Package.MQTTSourceClass());
	private Package.SourceClass _SourceClass;
	public Package.SourceClass SourceClass => _SourceClass ?? (_SourceClass = new Package.SourceClass());
	private Package.PipelineClass _PipelineClass;
	public Package.PipelineClass PipelineClass => _PipelineClass ?? (_PipelineClass = new Package.PipelineClass());
	private Package.SinkClass _SinkClass;
	public Package.SinkClass SinkClass => _SinkClass ?? (_SinkClass = new Package.SinkClass());
	private Package.TransformtionClass _TransformtionClass;
	public Package.TransformtionClass TransformtionClass => _TransformtionClass ?? (_TransformtionClass = new Package.TransformtionClass());
	private Package.AssetStroageClass _AssetStroageClass;
	public Package.AssetStroageClass AssetStroageClass => _AssetStroageClass ?? (_AssetStroageClass = new Package.AssetStroageClass());
	private Package.OPCUASinkGeneralization _OPCUASinkGeneralization;
	public Package.OPCUASinkGeneralization OPCUASinkGeneralization => _OPCUASinkGeneralization ?? (_OPCUASinkGeneralization = new Package.OPCUASinkGeneralization());
	private Package.NCLinkClass _NCLinkClass;
	public Package.NCLinkClass NCLinkClass => _NCLinkClass ?? (_NCLinkClass = new Package.NCLinkClass());
	private Package.MQTTSinkGeneralization _MQTTSinkGeneralization;
	public Package.MQTTSinkGeneralization MQTTSinkGeneralization => _MQTTSinkGeneralization ?? (_MQTTSinkGeneralization = new Package.MQTTSinkGeneralization());
	}
}