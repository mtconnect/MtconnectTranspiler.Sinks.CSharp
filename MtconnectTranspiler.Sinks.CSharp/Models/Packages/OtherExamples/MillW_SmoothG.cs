using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class MillW_PER_SmoothGPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1631701446823_952901_13";
		
		/// <inheritdoc />
		public string Name => "MillW/SmoothG";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			RepresentationPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
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
	}
}