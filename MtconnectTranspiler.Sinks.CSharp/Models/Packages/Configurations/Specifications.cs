using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.Specifications;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>
	﻿/// This section provides semantic information for the <see cref="Specification">Specification</see> entity.<br /><br />![Specifications](figures/Specifications.png "Specifications"){: width="0.8"}<br /><br />> Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.<br /><br />![Specification Example](figures/Specification%20Example.png "Specification Example"){: width="0.8"}<br /><br />> Note: See {{lst(specification-example)}} for the <i>XML</i> representation of the same example.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1579301667133_392891_7355">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class SpecificationsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1579301667133_392891_7355";
		
		/// <inheritdoc />
		public string Name => "Specifications";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(Specification)}} entity.

![Specifications](figures/Specifications.png ""Specifications""){: width=""0.8""}

> Note: See {{sect(Configuration Schema Diagrams)}} for XML schema.

![Specification Example](figures/Specification%20Example.png ""Specification Example""){: width=""0.8""}

> Note: See {{lst(specification-example)}} for the {{term(XML)}} representation of the same example.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			SpecificationClass,
			ProcessSpecificationGeneralization,
			ControlLimitsClass,
			AlarmLimitsClass,
			SpecificationLimitsClass,
			UpperWarningClass,
			UpperLimitClass,
			MaximumClass,
			LowerLimitClass,
			LowerWarningClass,
			MinimumClass,
			NominalClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.SpecificationClass _SpecificationClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpecificationClass" path="/summary" />
	/// </summary>
	public Package.SpecificationClass SpecificationClass => _SpecificationClass ?? (_SpecificationClass = new Package.SpecificationClass());

	private Package.ProcessSpecificationGeneralization _ProcessSpecificationGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessSpecificationGeneralization" path="/summary" />
	/// </summary>
	public Package.ProcessSpecificationGeneralization ProcessSpecificationGeneralization => _ProcessSpecificationGeneralization ?? (_ProcessSpecificationGeneralization = new Package.ProcessSpecificationGeneralization());

	private Package.ControlLimitsClass _ControlLimitsClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControlLimitsClass" path="/summary" />
	/// </summary>
	public Package.ControlLimitsClass ControlLimitsClass => _ControlLimitsClass ?? (_ControlLimitsClass = new Package.ControlLimitsClass());

	private Package.AlarmLimitsClass _AlarmLimitsClass;
	/// <summary>
	/// <inheritdoc cref="Package.AlarmLimitsClass" path="/summary" />
	/// </summary>
	public Package.AlarmLimitsClass AlarmLimitsClass => _AlarmLimitsClass ?? (_AlarmLimitsClass = new Package.AlarmLimitsClass());

	private Package.SpecificationLimitsClass _SpecificationLimitsClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpecificationLimitsClass" path="/summary" />
	/// </summary>
	public Package.SpecificationLimitsClass SpecificationLimitsClass => _SpecificationLimitsClass ?? (_SpecificationLimitsClass = new Package.SpecificationLimitsClass());

	private Package.UpperWarningClass _UpperWarningClass;
	/// <summary>
	/// <inheritdoc cref="Package.UpperWarningClass" path="/summary" />
	/// </summary>
	public Package.UpperWarningClass UpperWarningClass => _UpperWarningClass ?? (_UpperWarningClass = new Package.UpperWarningClass());

	private Package.UpperLimitClass _UpperLimitClass;
	/// <summary>
	/// <inheritdoc cref="Package.UpperLimitClass" path="/summary" />
	/// </summary>
	public Package.UpperLimitClass UpperLimitClass => _UpperLimitClass ?? (_UpperLimitClass = new Package.UpperLimitClass());

	private Package.MaximumClass _MaximumClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaximumClass" path="/summary" />
	/// </summary>
	public Package.MaximumClass MaximumClass => _MaximumClass ?? (_MaximumClass = new Package.MaximumClass());

	private Package.LowerLimitClass _LowerLimitClass;
	/// <summary>
	/// <inheritdoc cref="Package.LowerLimitClass" path="/summary" />
	/// </summary>
	public Package.LowerLimitClass LowerLimitClass => _LowerLimitClass ?? (_LowerLimitClass = new Package.LowerLimitClass());

	private Package.LowerWarningClass _LowerWarningClass;
	/// <summary>
	/// <inheritdoc cref="Package.LowerWarningClass" path="/summary" />
	/// </summary>
	public Package.LowerWarningClass LowerWarningClass => _LowerWarningClass ?? (_LowerWarningClass = new Package.LowerWarningClass());

	private Package.MinimumClass _MinimumClass;
	/// <summary>
	/// <inheritdoc cref="Package.MinimumClass" path="/summary" />
	/// </summary>
	public Package.MinimumClass MinimumClass => _MinimumClass ?? (_MinimumClass = new Package.MinimumClass());

	private Package.NominalClass _NominalClass;
	/// <summary>
	/// <inheritdoc cref="Package.NominalClass" path="/summary" />
	/// </summary>
	public Package.NominalClass NominalClass => _NominalClass ?? (_NominalClass = new Package.NominalClass());

	#endregion
	}
}