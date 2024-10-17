#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Pallet.Measurements;

namespace Mtconnect.AssetInformationModel.Pallet
{
	/// <summary>﻿This section lists common <see cref="Measurement">Measurement</see> types for a <see cref="PhysicalAsset">PhysicalAsset</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_68e0225_1727795912850_845735_24465">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MeasurementsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="MeasurementsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727795912850_845735_24465";
		/// <summary>Constant value for <see cref="MeasurementsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_68e0225_1727795912850_845735_24465";
		/// <summary>Constant value for <see cref="MeasurementsPackage.Name" /></summary>
		public const string NAME = "Measurements";
		/// <summary>Constant value for <see cref="MeasurementsPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section lists common {{block(Measurement)}} types for a {{block(PhysicalAsset)}}.&#10;
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
			MeasurementClass,
			WeightClass,
			HeightClass,
			WidthClass,
			LengthClass,
			SwingClass,
			LoadedWeightClass,
			LoadedHeightClass,
			LoadedWidthClass,
			LoadedLengthClass,
			LoadedSwingClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.MeasurementClass _MeasurementClass;
	/// <summary>
	/// <inheritdoc cref="Package.MeasurementClass" path="/summary" />
	/// </summary>
	public Package.MeasurementClass MeasurementClass => _MeasurementClass ?? (_MeasurementClass = new Package.MeasurementClass());

	private Package.WeightClass _WeightClass;
	/// <summary>
	/// <inheritdoc cref="Package.WeightClass" path="/summary" />
	/// </summary>
	public Package.WeightClass WeightClass => _WeightClass ?? (_WeightClass = new Package.WeightClass());

	private Package.HeightClass _HeightClass;
	/// <summary>
	/// <inheritdoc cref="Package.HeightClass" path="/summary" />
	/// </summary>
	public Package.HeightClass HeightClass => _HeightClass ?? (_HeightClass = new Package.HeightClass());

	private Package.WidthClass _WidthClass;
	/// <summary>
	/// <inheritdoc cref="Package.WidthClass" path="/summary" />
	/// </summary>
	public Package.WidthClass WidthClass => _WidthClass ?? (_WidthClass = new Package.WidthClass());

	private Package.LengthClass _LengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.LengthClass" path="/summary" />
	/// </summary>
	public Package.LengthClass LengthClass => _LengthClass ?? (_LengthClass = new Package.LengthClass());

	private Package.SwingClass _SwingClass;
	/// <summary>
	/// <inheritdoc cref="Package.SwingClass" path="/summary" />
	/// </summary>
	public Package.SwingClass SwingClass => _SwingClass ?? (_SwingClass = new Package.SwingClass());

	private Package.LoadedWeightClass _LoadedWeightClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadedWeightClass" path="/summary" />
	/// </summary>
	public Package.LoadedWeightClass LoadedWeightClass => _LoadedWeightClass ?? (_LoadedWeightClass = new Package.LoadedWeightClass());

	private Package.LoadedHeightClass _LoadedHeightClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadedHeightClass" path="/summary" />
	/// </summary>
	public Package.LoadedHeightClass LoadedHeightClass => _LoadedHeightClass ?? (_LoadedHeightClass = new Package.LoadedHeightClass());

	private Package.LoadedWidthClass _LoadedWidthClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadedWidthClass" path="/summary" />
	/// </summary>
	public Package.LoadedWidthClass LoadedWidthClass => _LoadedWidthClass ?? (_LoadedWidthClass = new Package.LoadedWidthClass());

	private Package.LoadedLengthClass _LoadedLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadedLengthClass" path="/summary" />
	/// </summary>
	public Package.LoadedLengthClass LoadedLengthClass => _LoadedLengthClass ?? (_LoadedLengthClass = new Package.LoadedLengthClass());

	private Package.LoadedSwingClass _LoadedSwingClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadedSwingClass" path="/summary" />
	/// </summary>
	public Package.LoadedSwingClass LoadedSwingClass => _LoadedSwingClass ?? (_LoadedSwingClass = new Package.LoadedSwingClass());

	#endregion

	#region Enums
	#endregion
	}
}