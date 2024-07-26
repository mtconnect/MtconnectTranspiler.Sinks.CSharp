
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CoordinateSystemsPackage {


	private Package.CoordinateSystemClass _CoordinateSystem;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CoordinateSystemClass CoordinateSystem => _CoordinateSystem ?? (_CoordinateSystem = new Package.CoordinateSystemClass());

	private Package.OriginClass _Origin;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OriginClass Origin => _Origin ?? (_Origin = new Package.OriginClass());

	private Package.TransformationClass _Transformation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransformationClass Transformation => _Transformation ?? (_Transformation = new Package.TransformationClass());

	private Package.RotationClass _Rotation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.RotationClass Rotation => _Rotation ?? (_Rotation = new Package.RotationClass());

	private Package.TranslationClass _Translation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TranslationClass Translation => _Translation ?? (_Translation = new Package.TranslationClass());
	}
}