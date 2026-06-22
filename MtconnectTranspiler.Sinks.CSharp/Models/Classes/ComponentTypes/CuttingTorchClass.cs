#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="Auxiliary">Auxiliary</see> that employs a concentrated flame to both sever materials through cutting and fuse them together in joining processes.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1744800465544_90322_23856">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class CuttingTorchClass : IClass
	{
		/// <summary>Constant value for <see cref="CuttingTorchClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744800465544_90322_23856";
		/// <summary>Constant value for <see cref="CuttingTorchClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1744800465544_90322_23856";
		/// <summary>Constant value for <see cref="CuttingTorchClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Auxiliary)}} that employs a concentrated flame to both sever materials through cutting and fuse them together in joining processes.&#10;
";
		/// <summary>Constant value for <see cref="CuttingTorchClass.Name" /></summary>
		public const string NAME = "CuttingTorch";
		/// <summary>Constant value for <see cref="CuttingTorchClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="CuttingTorchClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="CuttingTorchClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="CuttingTorchClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1579572381970_785259_42204
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.AuxiliaryClass);

		/// <inheritdoc />
		public new CuttingTorchClassProperties Properties { get; } = new CuttingTorchClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CuttingTorchClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.AuxiliaryClass.AuxiliaryClassProperties" />.
		/// </summary>
		public class CuttingTorchClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.AuxiliaryClass.AuxiliaryClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="CuttingTorchClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
