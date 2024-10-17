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
	/// <summary>﻿weight of the <see cref="PhysicalAsset">PhysicalAsset</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1727795939487_321518_24545">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class WeightClass : IClass
	{
		/// <summary>Constant value for <see cref="WeightClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727795939487_321518_24545";
		/// <summary>Constant value for <see cref="WeightClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1727795939487_321518_24545";
		/// <summary>Constant value for <see cref="WeightClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;weight of the {{block(PhysicalAsset)}}.&#10;
";
		/// <summary>Constant value for <see cref="WeightClass.Name" /></summary>
		public const string NAME = "Weight";
		/// <summary>Constant value for <see cref="WeightClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="WeightClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="WeightClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.5";
		/// <summary>Constant value for <see cref="WeightClass.DeprecatedVersion" /></summary>
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
		public new WeightClassProperties Properties { get; } = new WeightClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="WeightClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.Pallet.Measurements.MeasurementClass.MeasurementClassProperties" />.
		/// </summary>
		public class WeightClassProperties : Mtconnect.AssetInformationModel.Pallet.Measurements.MeasurementClass.MeasurementClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}