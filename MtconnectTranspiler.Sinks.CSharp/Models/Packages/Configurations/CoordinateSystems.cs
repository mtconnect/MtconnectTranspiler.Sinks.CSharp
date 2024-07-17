using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CoordinateSystemsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			CoordinateSystemClass,
			OriginClass,
			TransformationClass,
			RotationClass,
			TranslationClass,
		};

	private Package.CoordinateSystemClass _CoordinateSystemClass;
	public Package.CoordinateSystemClass CoordinateSystemClass => _CoordinateSystemClass ?? (_CoordinateSystemClass = new Package.CoordinateSystemClass());
	private Package.OriginClass _OriginClass;
	public Package.OriginClass OriginClass => _OriginClass ?? (_OriginClass = new Package.OriginClass());
	private Package.TransformationClass _TransformationClass;
	public Package.TransformationClass TransformationClass => _TransformationClass ?? (_TransformationClass = new Package.TransformationClass());
	private Package.RotationClass _RotationClass;
	public Package.RotationClass RotationClass => _RotationClass ?? (_RotationClass = new Package.RotationClass());
	private Package.TranslationClass _TranslationClass;
	public Package.TranslationClass TranslationClass => _TranslationClass ?? (_TranslationClass = new Package.TranslationClass());
	}
}