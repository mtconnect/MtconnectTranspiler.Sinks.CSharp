
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model;

using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class XArm7ModelPackage {


	private Package.OriginPropertyClass _OriginProperty;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OriginPropertyClass OriginProperty => _OriginProperty ?? (_OriginProperty = new Package.OriginPropertyClass());

	private Package.ParentCoordinatesClass _ParentCoordinates;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ParentCoordinatesClass ParentCoordinates => _ParentCoordinates ?? (_ParentCoordinates = new Package.ParentCoordinatesClass());

	private Package.OriginPositionClass _OriginPosition;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OriginPositionClass OriginPosition => _OriginPosition ?? (_OriginPosition = new Package.OriginPositionClass());

	private Package.RotationVectorClass _RotationVector;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.RotationVectorClass RotationVector => _RotationVector ?? (_RotationVector = new Package.RotationVectorClass());

	private Package.TranslationVectorClass _TranslationVector;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TranslationVectorClass TranslationVector => _TranslationVector ?? (_TranslationVector = new Package.TranslationVectorClass());

	private Package.PositionClass _Position;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PositionClass Position => _Position ?? (_Position = new Package.PositionClass());

	private Package.VectorClass _Vector;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.VectorClass Vector => _Vector ?? (_Vector = new Package.VectorClass());

	private Package.TransformationClass _Transformation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransformationClass Transformation => _Transformation ?? (_Transformation = new Package.TransformationClass());

	private Package.AngleClass _Angle;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AngleClass Angle => _Angle ?? (_Angle = new Package.AngleClass());

	private Package.AxisClass _Axis;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AxisClass Axis => _Axis ?? (_Axis = new Package.AxisClass());
	}
}