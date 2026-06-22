#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Process.Target;

namespace Mtconnect.AssetInformationModel.Process
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_68e0225_1759816962513_799082_2496">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public class TargetPackage : IPackage
	{
		/// <summary>Constant value for <see cref="TargetPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1759816962513_799082_2496";
		/// <summary>Constant value for <see cref="TargetPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_68e0225_1759816962513_799082_2496";
		/// <summary>Constant value for <see cref="TargetPackage.Name" /></summary>
		public const string NAME = "Target";
		/// <summary>Constant value for <see cref="TargetPackage.Summary" /></summary>
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
			TargetClass,
			TargetRefClass,
			TargetDeviceClass,
			TargetGroupClass,
			TargetRequirementTableClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.TargetClass _TargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.TargetClass" path="/summary" />
	/// </summary>
	public Package.TargetClass TargetClass => _TargetClass ?? (_TargetClass = new Package.TargetClass());

	private Package.TargetRefClass _TargetRefClass;
	/// <summary>
	/// <inheritdoc cref="Package.TargetRefClass" path="/summary" />
	/// </summary>
	public Package.TargetRefClass TargetRefClass => _TargetRefClass ?? (_TargetRefClass = new Package.TargetRefClass());

	private Package.TargetDeviceClass _TargetDeviceClass;
	/// <summary>
	/// <inheritdoc cref="Package.TargetDeviceClass" path="/summary" />
	/// </summary>
	public Package.TargetDeviceClass TargetDeviceClass => _TargetDeviceClass ?? (_TargetDeviceClass = new Package.TargetDeviceClass());

	private Package.TargetGroupClass _TargetGroupClass;
	/// <summary>
	/// <inheritdoc cref="Package.TargetGroupClass" path="/summary" />
	/// </summary>
	public Package.TargetGroupClass TargetGroupClass => _TargetGroupClass ?? (_TargetGroupClass = new Package.TargetGroupClass());

	private Package.TargetRequirementTableClass _TargetRequirementTableClass;
	/// <summary>
	/// <inheritdoc cref="Package.TargetRequirementTableClass" path="/summary" />
	/// </summary>
	public Package.TargetRequirementTableClass TargetRequirementTableClass => _TargetRequirementTableClass ?? (_TargetRequirementTableClass = new Package.TargetRequirementTableClass());

	#endregion

	#region Enums
	#endregion
	}
}
