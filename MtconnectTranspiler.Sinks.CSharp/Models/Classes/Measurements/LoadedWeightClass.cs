#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.Pallet.Measurements
{
	/// <summary>﻿loaded weight of the <see cref="PhysicalAsset">PhysicalAsset</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1727795966065_979190_24720">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class LoadedWeightClass : IClass
	{
		/// <summary>Constant value for <see cref="LoadedWeightClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727795966065_979190_24720";
		/// <summary>Constant value for <see cref="LoadedWeightClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1727795966065_979190_24720";
		/// <summary>Constant value for <see cref="LoadedWeightClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;loaded weight of the {{block(PhysicalAsset)}}.&#10;
";
		/// <summary>Constant value for <see cref="LoadedWeightClass.Name" /></summary>
		public const string NAME = "LoadedWeight";
		/// <summary>Constant value for <see cref="LoadedWeightClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="LoadedWeightClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="LoadedWeightClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.5";
		/// <summary>Constant value for <see cref="LoadedWeightClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _2024x_68e0225_1727793846441_986747_23754
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.Pallet.Measurements.MeasurementClass);

		/// <inheritdoc />
		public new LoadedWeightClassProperties Properties { get; } = new LoadedWeightClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="LoadedWeightClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.Pallet.Measurements.MeasurementClass.MeasurementClassProperties" />.
		/// </summary>
		public class LoadedWeightClassProperties : Mtconnect.AssetInformationModel.Pallet.Measurements.MeasurementClass.MeasurementClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}