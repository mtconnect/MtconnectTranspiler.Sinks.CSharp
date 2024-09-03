#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model;

namespace Mtconnect.WIP_DeviceExamples.KinematicsSimulation
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1582232381130_844490_124">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class XArm7ModelPackage : IPackage
	{
		/// <summary>Constant value for <see cref="XArm7ModelPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1582232381130_844490_124";
		/// <summary>Constant value for <see cref="XArm7ModelPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_91b028d_1582232381130_844490_124";
		/// <summary>Constant value for <see cref="XArm7ModelPackage.Name" /></summary>
		public const string NAME = "XArm7Model";
		/// <summary>Constant value for <see cref="XArm7ModelPackage.Summary" /></summary>
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
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}