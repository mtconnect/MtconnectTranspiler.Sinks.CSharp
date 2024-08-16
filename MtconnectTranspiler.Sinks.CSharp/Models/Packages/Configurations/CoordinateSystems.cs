using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>
	﻿/// This section provides semantic information for the <see cref="CoordinateSystem">CoordinateSystem</see> entity.<br /><br />![CoordinateSystem](figures/CoordinateSystem.png "CoordinateSystem"){: width="0.8"}<br /><br />> Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.<br /><br />![CoordinateSystem Example](figures/CoordinateSystem%20Example.png "CoordinateSystem Example"){: width="0.8"}<br /><br />> Note: See {{lst(coordinatesystem-example)}} for the <i>XML</i> representation of the same example.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579100640484_17380_16262">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class CoordinateSystemsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579100640484_17380_16262";
		
		/// <inheritdoc />
		public string Name => "CoordinateSystems";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(CoordinateSystem)}} entity.

![CoordinateSystem](figures/CoordinateSystem.png ""CoordinateSystem""){: width=""0.8""}

> Note: See {{sect(Configuration Schema Diagrams)}} for XML schema.

![CoordinateSystem Example](figures/CoordinateSystem%20Example.png ""CoordinateSystem Example""){: width=""0.8""}

> Note: See {{lst(coordinatesystem-example)}} for the {{term(XML)}} representation of the same example.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			CoordinateSystemClass,
			OriginClass,
			TransformationClass,
			RotationClass,
			TranslationClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.CoordinateSystemClass _CoordinateSystemClass;
	/// <summary>
	/// <inheritdoc cref="Package.CoordinateSystemClass" path="/summary" />
	/// </summary>
	public Package.CoordinateSystemClass CoordinateSystemClass => _CoordinateSystemClass ?? (_CoordinateSystemClass = new Package.CoordinateSystemClass());

	private Package.OriginClass _OriginClass;
	/// <summary>
	/// <inheritdoc cref="Package.OriginClass" path="/summary" />
	/// </summary>
	public Package.OriginClass OriginClass => _OriginClass ?? (_OriginClass = new Package.OriginClass());

	private Package.TransformationClass _TransformationClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransformationClass" path="/summary" />
	/// </summary>
	public Package.TransformationClass TransformationClass => _TransformationClass ?? (_TransformationClass = new Package.TransformationClass());

	private Package.RotationClass _RotationClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotationClass" path="/summary" />
	/// </summary>
	public Package.RotationClass RotationClass => _RotationClass ?? (_RotationClass = new Package.RotationClass());

	private Package.TranslationClass _TranslationClass;
	/// <summary>
	/// <inheritdoc cref="Package.TranslationClass" path="/summary" />
	/// </summary>
	public Package.TranslationClass TranslationClass => _TranslationClass ?? (_TranslationClass = new Package.TranslationClass());

	#endregion
	}
}