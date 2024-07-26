
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Configurations;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ConfigurationsPackage {

	private Package.CoordinateSystemsPackage _CoordinateSystemsPackage;
	public Package.CoordinateSystemsPackage CoordinateSystemsPackage => _CoordinateSystemsPackage ?? (_CoordinateSystemsPackage = new Package.CoordinateSystemsPackage());

	private Package.MotionPackage _MotionPackage;
	public Package.MotionPackage MotionPackage => _MotionPackage ?? (_MotionPackage = new Package.MotionPackage());

	private Package.SpecificationsPackage _SpecificationsPackage;
	public Package.SpecificationsPackage SpecificationsPackage => _SpecificationsPackage ?? (_SpecificationsPackage = new Package.SpecificationsPackage());

	private Package.SensorPackage _SensorPackage;
	public Package.SensorPackage SensorPackage => _SensorPackage ?? (_SensorPackage = new Package.SensorPackage());

	private Package.RelationshipsPackage _RelationshipsPackage;
	public Package.RelationshipsPackage RelationshipsPackage => _RelationshipsPackage ?? (_RelationshipsPackage = new Package.RelationshipsPackage());

	private Package.SolidModelPackage _SolidModelPackage;
	public Package.SolidModelPackage SolidModelPackage => _SolidModelPackage ?? (_SolidModelPackage = new Package.SolidModelPackage());

	private Package.ImageFilesPackage _ImageFilesPackage;
	public Package.ImageFilesPackage ImageFilesPackage => _ImageFilesPackage ?? (_ImageFilesPackage = new Package.ImageFilesPackage());

	private Package.PowerSourcePackage _PowerSourcePackage;
	public Package.PowerSourcePackage PowerSourcePackage => _PowerSourcePackage ?? (_PowerSourcePackage = new Package.PowerSourcePackage());


	private Package.ConfigurationClass _Configuration;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ConfigurationClass Configuration => _Configuration ?? (_Configuration = new Package.ConfigurationClass());
	}
}