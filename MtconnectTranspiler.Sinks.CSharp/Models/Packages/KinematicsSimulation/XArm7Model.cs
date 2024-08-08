using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model;
// using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class XArm7ModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1582232381130_844490_124";
		
		/// <inheritdoc />
		public string Name => "XArm7Model";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
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
		#region Packages
	#endregion

	#region Classes
	private Package.OriginPropertyClass _OriginPropertyClass;
	/// <summary>
	/// <inheritdoc cref="Package.OriginPropertyClass" path="/summary" />
	/// </summary>
	public Package.OriginPropertyClass OriginPropertyClass => _OriginPropertyClass ?? (_OriginPropertyClass = new Package.OriginPropertyClass());

	private Package.ParentCoordinatesClass _ParentCoordinatesClass;
	/// <summary>
	/// <inheritdoc cref="Package.ParentCoordinatesClass" path="/summary" />
	/// </summary>
	public Package.ParentCoordinatesClass ParentCoordinatesClass => _ParentCoordinatesClass ?? (_ParentCoordinatesClass = new Package.ParentCoordinatesClass());

	private Package.OriginPositionGeneralization _OriginPositionGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.OriginPositionGeneralization" path="/summary" />
	/// </summary>
	public Package.OriginPositionGeneralization OriginPositionGeneralization => _OriginPositionGeneralization ?? (_OriginPositionGeneralization = new Package.OriginPositionGeneralization());

	private Package.RotationVectorGeneralization _RotationVectorGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.RotationVectorGeneralization" path="/summary" />
	/// </summary>
	public Package.RotationVectorGeneralization RotationVectorGeneralization => _RotationVectorGeneralization ?? (_RotationVectorGeneralization = new Package.RotationVectorGeneralization());

	private Package.TranslationVectorGeneralization _TranslationVectorGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.TranslationVectorGeneralization" path="/summary" />
	/// </summary>
	public Package.TranslationVectorGeneralization TranslationVectorGeneralization => _TranslationVectorGeneralization ?? (_TranslationVectorGeneralization = new Package.TranslationVectorGeneralization());

	private Package.PositionClass _PositionClass;
	/// <summary>
	/// <inheritdoc cref="Package.PositionClass" path="/summary" />
	/// </summary>
	public Package.PositionClass PositionClass => _PositionClass ?? (_PositionClass = new Package.PositionClass());

	private Package.VectorClass _VectorClass;
	/// <summary>
	/// <inheritdoc cref="Package.VectorClass" path="/summary" />
	/// </summary>
	public Package.VectorClass VectorClass => _VectorClass ?? (_VectorClass = new Package.VectorClass());

	private Package.TransformationClass _TransformationClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransformationClass" path="/summary" />
	/// </summary>
	public Package.TransformationClass TransformationClass => _TransformationClass ?? (_TransformationClass = new Package.TransformationClass());

	private Package.AngleClass _AngleClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngleClass" path="/summary" />
	/// </summary>
	public Package.AngleClass AngleClass => _AngleClass ?? (_AngleClass = new Package.AngleClass());

	private Package.AxisClass _AxisClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisClass" path="/summary" />
	/// </summary>
	public Package.AxisClass AxisClass => _AxisClass ?? (_AxisClass = new Package.AxisClass());

	#endregion
	}
}