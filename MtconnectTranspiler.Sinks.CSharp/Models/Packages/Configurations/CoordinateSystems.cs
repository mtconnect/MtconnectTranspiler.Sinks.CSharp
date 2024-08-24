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
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
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
			RotationClass,
			TranslationClass,
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

	#region Enums
	#endregion
	}
}