#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1631701446823_952901_13">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MillW_PER_SmoothGPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1631701446823_952901_13";
		
		/// <inheritdoc />
		public string Name => "Mill w/SmoothG";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			RepresentationPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.RepresentationPackage _RepresentationPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RepresentationPackage" path="/summary" />
	/// </summary>
	public Package.RepresentationPackage RepresentationPackage => _RepresentationPackage ?? (_RepresentationPackage = new Package.RepresentationPackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}