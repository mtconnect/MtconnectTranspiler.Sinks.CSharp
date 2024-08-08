using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Imports;

namespace Mtconnect
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class ImportsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1642674055604_161919_102";
		
		/// <inheritdoc />
		public string Name => "Imports";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			CSVImportsPackage,
			UnitImportsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.CSVImportsPackage _CSVImportsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CSVImportsPackage" path="/summary" />
	/// </summary>
	public Package.CSVImportsPackage CSVImportsPackage => _CSVImportsPackage ?? (_CSVImportsPackage = new Package.CSVImportsPackage());

	private Package.UnitImportsPackage _UnitImportsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.UnitImportsPackage" path="/summary" />
	/// </summary>
	public Package.UnitImportsPackage UnitImportsPackage => _UnitImportsPackage ?? (_UnitImportsPackage = new Package.UnitImportsPackage());

	#endregion

	#region Classes
	#endregion
	}
}