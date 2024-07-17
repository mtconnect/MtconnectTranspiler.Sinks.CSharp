using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model;
// using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class XArm7ModelPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			OriginPropertyClass,
			ParentCoordinatesClass,
			OriginPositionGeneralization,
			RotationVectorGeneralization,
			TranslationVectorGeneralization,
			PositionClass,
			VectorClass,
			TransformationClass,
			AngleClass,
			AxisClass,
		};

	private Package.OriginPropertyClass _OriginPropertyClass;
	public Package.OriginPropertyClass OriginPropertyClass => _OriginPropertyClass ?? (_OriginPropertyClass = new Package.OriginPropertyClass());
	private Package.ParentCoordinatesClass _ParentCoordinatesClass;
	public Package.ParentCoordinatesClass ParentCoordinatesClass => _ParentCoordinatesClass ?? (_ParentCoordinatesClass = new Package.ParentCoordinatesClass());
	private Package.OriginPositionGeneralization _OriginPositionGeneralization;
	public Package.OriginPositionGeneralization OriginPositionGeneralization => _OriginPositionGeneralization ?? (_OriginPositionGeneralization = new Package.OriginPositionGeneralization());
	private Package.RotationVectorGeneralization _RotationVectorGeneralization;
	public Package.RotationVectorGeneralization RotationVectorGeneralization => _RotationVectorGeneralization ?? (_RotationVectorGeneralization = new Package.RotationVectorGeneralization());
	private Package.TranslationVectorGeneralization _TranslationVectorGeneralization;
	public Package.TranslationVectorGeneralization TranslationVectorGeneralization => _TranslationVectorGeneralization ?? (_TranslationVectorGeneralization = new Package.TranslationVectorGeneralization());
	private Package.PositionClass _PositionClass;
	public Package.PositionClass PositionClass => _PositionClass ?? (_PositionClass = new Package.PositionClass());
	private Package.VectorClass _VectorClass;
	public Package.VectorClass VectorClass => _VectorClass ?? (_VectorClass = new Package.VectorClass());
	private Package.TransformationClass _TransformationClass;
	public Package.TransformationClass TransformationClass => _TransformationClass ?? (_TransformationClass = new Package.TransformationClass());
	private Package.AngleClass _AngleClass;
	public Package.AngleClass AngleClass => _AngleClass ?? (_AngleClass = new Package.AngleClass());
	private Package.AxisClass _AxisClass;
	public Package.AxisClass AxisClass => _AxisClass ?? (_AxisClass = new Package.AxisClass());
	}
}