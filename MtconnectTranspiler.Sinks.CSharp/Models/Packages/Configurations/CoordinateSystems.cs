#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>﻿This section provides semantic information for the <see cref="CoordinateSystem">CoordinateSystem</see> entity.<br /><br />![CoordinateSystem](figures/CoordinateSystem.png "CoordinateSystem"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.<br /><br />![CoordinateSystem Example](figures/CoordinateSystem%20Example.png "CoordinateSystem Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(coordinatesystem-example)}} for the <i>XML</i> representation of the same example.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579100640484_17380_16262">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public class CoordinateSystemsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="CoordinateSystemsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579100640484_17380_16262";
		/// <summary>Constant value for <see cref="CoordinateSystemsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579100640484_17380_16262";
		/// <summary>Constant value for <see cref="CoordinateSystemsPackage.Name" /></summary>
		public const string NAME = "CoordinateSystems";
		/// <summary>Constant value for <see cref="CoordinateSystemsPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(CoordinateSystem)}} entity.

![CoordinateSystem](figures/CoordinateSystem.png ""CoordinateSystem""){: width=""0.8""}

> Note: See {{sect(Configuration Schema Diagrams)}} for XML schema.

![CoordinateSystem Example](figures/CoordinateSystem%20Example.png ""CoordinateSystem Example""){: width=""0.8""}

> Note: See {{lst(coordinatesystem-example)}} for the {{term(XML)}} representation of the same example.&#10;
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
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			CoordinateSystemClass,
			OriginClass,
			TransformationClass,
			AbstractRotationClass,
			AbstractTranslationClass,
			AbstractOriginClass,
			OriginDataSetGeneralization,
			TranslationClass,
			TranslationDataSetGeneralization,
			RotationDataSetGeneralization,
			RotationClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	private Package.AbstractRotationClass _AbstractRotationClass;
	/// <summary>
	/// <inheritdoc cref="Package.AbstractRotationClass" path="/summary" />
	/// </summary>
	public Package.AbstractRotationClass AbstractRotationClass => _AbstractRotationClass ?? (_AbstractRotationClass = new Package.AbstractRotationClass());

	private Package.AbstractTranslationClass _AbstractTranslationClass;
	/// <summary>
	/// <inheritdoc cref="Package.AbstractTranslationClass" path="/summary" />
	/// </summary>
	public Package.AbstractTranslationClass AbstractTranslationClass => _AbstractTranslationClass ?? (_AbstractTranslationClass = new Package.AbstractTranslationClass());

	private Package.AbstractOriginClass _AbstractOriginClass;
	/// <summary>
	/// <inheritdoc cref="Package.AbstractOriginClass" path="/summary" />
	/// </summary>
	public Package.AbstractOriginClass AbstractOriginClass => _AbstractOriginClass ?? (_AbstractOriginClass = new Package.AbstractOriginClass());

	private Package.OriginDataSetGeneralization _OriginDataSetGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.OriginDataSetGeneralization" path="/summary" />
	/// </summary>
	public Package.OriginDataSetGeneralization OriginDataSetGeneralization => _OriginDataSetGeneralization ?? (_OriginDataSetGeneralization = new Package.OriginDataSetGeneralization());

	private Package.TranslationClass _TranslationClass;
	/// <summary>
	/// <inheritdoc cref="Package.TranslationClass" path="/summary" />
	/// </summary>
	public Package.TranslationClass TranslationClass => _TranslationClass ?? (_TranslationClass = new Package.TranslationClass());

	private Package.TranslationDataSetGeneralization _TranslationDataSetGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.TranslationDataSetGeneralization" path="/summary" />
	/// </summary>
	public Package.TranslationDataSetGeneralization TranslationDataSetGeneralization => _TranslationDataSetGeneralization ?? (_TranslationDataSetGeneralization = new Package.TranslationDataSetGeneralization());

	private Package.RotationDataSetGeneralization _RotationDataSetGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.RotationDataSetGeneralization" path="/summary" />
	/// </summary>
	public Package.RotationDataSetGeneralization RotationDataSetGeneralization => _RotationDataSetGeneralization ?? (_RotationDataSetGeneralization = new Package.RotationDataSetGeneralization());

	private Package.RotationClass _RotationClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotationClass" path="/summary" />
	/// </summary>
	public Package.RotationClass RotationClass => _RotationClass ?? (_RotationClass = new Package.RotationClass());

	#endregion

	#region Enums
	#endregion
	}
}