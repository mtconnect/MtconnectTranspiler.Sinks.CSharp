#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations;

namespace Mtconnect.DeviceInformationModel
{
	/// <summary>﻿{{figure(Configuration)}} shows the abstract <see cref="Configuration">Configuration</see> and its types.<br /><br />![Configuration](figures/Configuration.png "Configuration"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.<br /><br /><br />Configurations Model<br /><br />This section provides semantic information for the <see cref="Configuration">Configuration</see> entity that is used to model technical information about a <see cref="Component">Component</see>. <br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1579526876433_244855_7626">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ConfigurationsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="ConfigurationsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1579526876433_244855_7626";
		/// <summary>Constant value for <see cref="ConfigurationsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_91b028d_1579526876433_244855_7626";
		/// <summary>Constant value for <see cref="ConfigurationsPackage.Name" /></summary>
		public const string NAME = "Configurations";
		/// <summary>Constant value for <see cref="ConfigurationsPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{figure(Configuration)}} shows the abstract {{block(Configuration)}} and its types.

![Configuration](figures/Configuration.png ""Configuration""){: width=""0.8""}

> Note: See {{sect(Configuration Schema Diagrams)}} for XML schema.&#10;
&#10;&#10;&#10;Configurations Model&#10;&#10;&#10;&#10;This section provides semantic information for the {{block(Configuration)}} entity that is used to model technical information about a {{block(Component)}}. &#10;
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
			CoordinateSystemsPackage,
			MotionPackage,
			SpecificationsPackage,
			SensorPackage,
			RelationshipsPackage,
			SolidModelPackage,
			ImageFilesPackage,
			PowerSourcesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ConfigurationClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.CoordinateSystemsPackage _CoordinateSystemsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CoordinateSystemsPackage" path="/summary" />
	/// </summary>
	public Package.CoordinateSystemsPackage CoordinateSystemsPackage => _CoordinateSystemsPackage ?? (_CoordinateSystemsPackage = new Package.CoordinateSystemsPackage());

	private Package.MotionPackage _MotionPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MotionPackage" path="/summary" />
	/// </summary>
	public Package.MotionPackage MotionPackage => _MotionPackage ?? (_MotionPackage = new Package.MotionPackage());

	private Package.SpecificationsPackage _SpecificationsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.SpecificationsPackage" path="/summary" />
	/// </summary>
	public Package.SpecificationsPackage SpecificationsPackage => _SpecificationsPackage ?? (_SpecificationsPackage = new Package.SpecificationsPackage());

	private Package.SensorPackage _SensorPackage;
	/// <summary>
	/// <inheritdoc cref="Package.SensorPackage" path="/summary" />
	/// </summary>
	public Package.SensorPackage SensorPackage => _SensorPackage ?? (_SensorPackage = new Package.SensorPackage());

	private Package.RelationshipsPackage _RelationshipsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RelationshipsPackage" path="/summary" />
	/// </summary>
	public Package.RelationshipsPackage RelationshipsPackage => _RelationshipsPackage ?? (_RelationshipsPackage = new Package.RelationshipsPackage());

	private Package.SolidModelPackage _SolidModelPackage;
	/// <summary>
	/// <inheritdoc cref="Package.SolidModelPackage" path="/summary" />
	/// </summary>
	public Package.SolidModelPackage SolidModelPackage => _SolidModelPackage ?? (_SolidModelPackage = new Package.SolidModelPackage());

	private Package.ImageFilesPackage _ImageFilesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ImageFilesPackage" path="/summary" />
	/// </summary>
	public Package.ImageFilesPackage ImageFilesPackage => _ImageFilesPackage ?? (_ImageFilesPackage = new Package.ImageFilesPackage());

	private Package.PowerSourcesPackage _PowerSourcesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.PowerSourcesPackage" path="/summary" />
	/// </summary>
	public Package.PowerSourcesPackage PowerSourcesPackage => _PowerSourcesPackage ?? (_PowerSourcesPackage = new Package.PowerSourcesPackage());

	#endregion

	#region Classes
	private Package.ConfigurationClass _ConfigurationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConfigurationClass" path="/summary" />
	/// </summary>
	public Package.ConfigurationClass ConfigurationClass => _ConfigurationClass ?? (_ConfigurationClass = new Package.ConfigurationClass());

	#endregion

	#region Enums
	#endregion
	}
}