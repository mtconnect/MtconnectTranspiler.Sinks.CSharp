#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ReferenceAgentArchitecture;

namespace Mtconnect
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1584923209945_326350_15088">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ReferenceAgentArchitecturePackage : IPackage
	{
		/// <summary>Constant value for <see cref="ReferenceAgentArchitecturePackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1584923209945_326350_15088";
		/// <summary>Constant value for <see cref="ReferenceAgentArchitecturePackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1584923209945_326350_15088";
		/// <summary>Constant value for <see cref="ReferenceAgentArchitecturePackage.Name" /></summary>
		public const string NAME = "Reference Agent Architecture";
		/// <summary>Constant value for <see cref="ReferenceAgentArchitecturePackage.Summary" /></summary>
		public const string SUMMARY = @"";

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
			RestPackage,
			SourcePackage,
			SinkPackage,
			TransformationPackage,
			PrinterPackage,
			ParserPackage,
			InformationModelPackage,
			PipelinesPackage,
		};
		
		/// <inheritdoc />
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
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.RestPackage _RestPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RestPackage" path="/summary" />
	/// </summary>
	public Package.RestPackage RestPackage => _RestPackage ?? (_RestPackage = new Package.RestPackage());

	private Package.SourcePackage _SourcePackage;
	/// <summary>
	/// <inheritdoc cref="Package.SourcePackage" path="/summary" />
	/// </summary>
	public Package.SourcePackage SourcePackage => _SourcePackage ?? (_SourcePackage = new Package.SourcePackage());

	private Package.SinkPackage _SinkPackage;
	/// <summary>
	/// <inheritdoc cref="Package.SinkPackage" path="/summary" />
	/// </summary>
	public Package.SinkPackage SinkPackage => _SinkPackage ?? (_SinkPackage = new Package.SinkPackage());

	private Package.TransformationPackage _TransformationPackage;
	/// <summary>
	/// <inheritdoc cref="Package.TransformationPackage" path="/summary" />
	/// </summary>
	public Package.TransformationPackage TransformationPackage => _TransformationPackage ?? (_TransformationPackage = new Package.TransformationPackage());

	private Package.PrinterPackage _PrinterPackage;
	/// <summary>
	/// <inheritdoc cref="Package.PrinterPackage" path="/summary" />
	/// </summary>
	public Package.PrinterPackage PrinterPackage => _PrinterPackage ?? (_PrinterPackage = new Package.PrinterPackage());

	private Package.ParserPackage _ParserPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ParserPackage" path="/summary" />
	/// </summary>
	public Package.ParserPackage ParserPackage => _ParserPackage ?? (_ParserPackage = new Package.ParserPackage());

	private Package.InformationModelPackage _InformationModelPackage;
	/// <summary>
	/// <inheritdoc cref="Package.InformationModelPackage" path="/summary" />
	/// </summary>
	public Package.InformationModelPackage InformationModelPackage => _InformationModelPackage ?? (_InformationModelPackage = new Package.InformationModelPackage());

	private Package.PipelinesPackage _PipelinesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.PipelinesPackage" path="/summary" />
	/// </summary>
	public Package.PipelinesPackage PipelinesPackage => _PipelinesPackage ?? (_PipelinesPackage = new Package.PipelinesPackage());

	#endregion

	#region Classes
	private Package.AgentClass _AgentClass;
	/// <summary>
	/// <inheritdoc cref="Package.AgentClass" path="/summary" />
	/// </summary>
	public Package.AgentClass AgentClass => _AgentClass ?? (_AgentClass = new Package.AgentClass());

	private Package.ServiceClass _ServiceClass;
	/// <summary>
	/// <inheritdoc cref="Package.ServiceClass" path="/summary" />
	/// </summary>
	public Package.ServiceClass ServiceClass => _ServiceClass ?? (_ServiceClass = new Package.ServiceClass());

	private Package.RestSinkClass _RestSinkClass;
	/// <summary>
	/// <inheritdoc cref="Package.RestSinkClass" path="/summary" />
	/// </summary>
	public Package.RestSinkClass RestSinkClass => _RestSinkClass ?? (_RestSinkClass = new Package.RestSinkClass());

	private Package.DataSinkServiceGeneralization _DataSinkServiceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.DataSinkServiceGeneralization" path="/summary" />
	/// </summary>
	public Package.DataSinkServiceGeneralization DataSinkServiceGeneralization => _DataSinkServiceGeneralization ?? (_DataSinkServiceGeneralization = new Package.DataSinkServiceGeneralization());

	private Package.MQTTSinkClass _MQTTSinkClass;
	/// <summary>
	/// <inheritdoc cref="Package.MQTTSinkClass" path="/summary" />
	/// </summary>
	public Package.MQTTSinkClass MQTTSinkClass => _MQTTSinkClass ?? (_MQTTSinkClass = new Package.MQTTSinkClass());

	private Package.DataSourceServiceGeneralization _DataSourceServiceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.DataSourceServiceGeneralization" path="/summary" />
	/// </summary>
	public Package.DataSourceServiceGeneralization DataSourceServiceGeneralization => _DataSourceServiceGeneralization ?? (_DataSourceServiceGeneralization = new Package.DataSourceServiceGeneralization());

	private Package.RestServiceGeneralization _RestServiceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.RestServiceGeneralization" path="/summary" />
	/// </summary>
	public Package.RestServiceGeneralization RestServiceGeneralization => _RestServiceGeneralization ?? (_RestServiceGeneralization = new Package.RestServiceGeneralization());

	private Package.TransformationServiceGeneralization _TransformationServiceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.TransformationServiceGeneralization" path="/summary" />
	/// </summary>
	public Package.TransformationServiceGeneralization TransformationServiceGeneralization => _TransformationServiceGeneralization ?? (_TransformationServiceGeneralization = new Package.TransformationServiceGeneralization());

	private Package.StorageServiceGeneralization _StorageServiceGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.StorageServiceGeneralization" path="/summary" />
	/// </summary>
	public Package.StorageServiceGeneralization StorageServiceGeneralization => _StorageServiceGeneralization ?? (_StorageServiceGeneralization = new Package.StorageServiceGeneralization());

	private Package.RestSourceClass _RestSourceClass;
	/// <summary>
	/// <inheritdoc cref="Package.RestSourceClass" path="/summary" />
	/// </summary>
	public Package.RestSourceClass RestSourceClass => _RestSourceClass ?? (_RestSourceClass = new Package.RestSourceClass());

	private Package.MQTTSourceClass _MQTTSourceClass;
	/// <summary>
	/// <inheritdoc cref="Package.MQTTSourceClass" path="/summary" />
	/// </summary>
	public Package.MQTTSourceClass MQTTSourceClass => _MQTTSourceClass ?? (_MQTTSourceClass = new Package.MQTTSourceClass());

	private Package.SourceClass _SourceClass;
	/// <summary>
	/// <inheritdoc cref="Package.SourceClass" path="/summary" />
	/// </summary>
	public Package.SourceClass SourceClass => _SourceClass ?? (_SourceClass = new Package.SourceClass());

	private Package.PipelineClass _PipelineClass;
	/// <summary>
	/// <inheritdoc cref="Package.PipelineClass" path="/summary" />
	/// </summary>
	public Package.PipelineClass PipelineClass => _PipelineClass ?? (_PipelineClass = new Package.PipelineClass());

	private Package.SinkClass _SinkClass;
	/// <summary>
	/// <inheritdoc cref="Package.SinkClass" path="/summary" />
	/// </summary>
	public Package.SinkClass SinkClass => _SinkClass ?? (_SinkClass = new Package.SinkClass());

	private Package.TransformtionClass _TransformtionClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransformtionClass" path="/summary" />
	/// </summary>
	public Package.TransformtionClass TransformtionClass => _TransformtionClass ?? (_TransformtionClass = new Package.TransformtionClass());

	private Package.AssetStroageClass _AssetStroageClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetStroageClass" path="/summary" />
	/// </summary>
	public Package.AssetStroageClass AssetStroageClass => _AssetStroageClass ?? (_AssetStroageClass = new Package.AssetStroageClass());

	private Package.OPCUASinkGeneralization _OPCUASinkGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.OPCUASinkGeneralization" path="/summary" />
	/// </summary>
	public Package.OPCUASinkGeneralization OPCUASinkGeneralization => _OPCUASinkGeneralization ?? (_OPCUASinkGeneralization = new Package.OPCUASinkGeneralization());

	private Package.NCLinkClass _NCLinkClass;
	/// <summary>
	/// <inheritdoc cref="Package.NCLinkClass" path="/summary" />
	/// </summary>
	public Package.NCLinkClass NCLinkClass => _NCLinkClass ?? (_NCLinkClass = new Package.NCLinkClass());

	private Package.MQTTSinkGeneralization _MQTTSinkGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.MQTTSinkGeneralization" path="/summary" />
	/// </summary>
	public Package.MQTTSinkGeneralization MQTTSinkGeneralization => _MQTTSinkGeneralization ?? (_MQTTSinkGeneralization = new Package.MQTTSinkGeneralization());

	#endregion

	#region Enums
	#endregion
	}
}