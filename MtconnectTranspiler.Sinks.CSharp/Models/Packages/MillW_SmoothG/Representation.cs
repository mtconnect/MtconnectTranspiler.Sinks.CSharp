#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_DeviceExamples.MillW_PER_SmoothG.Representation;

namespace Mtconnect.WIP_DeviceExamples.MillW_PER_SmoothG
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1634044347705_111979_477">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class RepresentationPackage : IPackage
	{
		/// <summary>Constant value for <see cref="RepresentationPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1634044347705_111979_477";
		/// <summary>Constant value for <see cref="RepresentationPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1634044347705_111979_477";
		/// <summary>Constant value for <see cref="RepresentationPackage.Name" /></summary>
		public const string NAME = "Representation";
		/// <summary>Constant value for <see cref="RepresentationPackage.Summary" /></summary>
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
			VariableClass,
			WorkOffsetsClass,
			TemperatureClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.VariableClass _VariableClass;
	/// <summary>
	/// <inheritdoc cref="Package.VariableClass" path="/summary" />
	/// </summary>
	public Package.VariableClass VariableClass => _VariableClass ?? (_VariableClass = new Package.VariableClass());

	private Package.WorkOffsetsClass _WorkOffsetsClass;
	/// <summary>
	/// <inheritdoc cref="Package.WorkOffsetsClass" path="/summary" />
	/// </summary>
	public Package.WorkOffsetsClass WorkOffsetsClass => _WorkOffsetsClass ?? (_WorkOffsetsClass = new Package.WorkOffsetsClass());

	private Package.TemperatureClass _TemperatureClass;
	/// <summary>
	/// <inheritdoc cref="Package.TemperatureClass" path="/summary" />
	/// </summary>
	public Package.TemperatureClass TemperatureClass => _TemperatureClass ?? (_TemperatureClass = new Package.TemperatureClass());

	#endregion

	#region Enums
	#endregion
	}
}