using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.SupportingDocuments;

namespace Mtconnect
{
	/// <summary>
	/// Assets Appendix/// Assets Introduction/// Devices Introduction/// Devices Appendix/// Observations Introduction/// Observations Appendix/// Interfaces Introduction/// Fundamentals Appendix/// Fundamentals Introduction
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class SupportingDocumentsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1589301330036_553673_25";
		
		/// <inheritdoc />
		public string Name => "SupportingDocuments";

		/// <inheritdoc />
		public string Summary => @"/// Assets Appendix/// Assets Introduction/// Devices Introduction/// Devices Appendix/// Observations Introduction/// Observations Appendix/// Interfaces Introduction/// Fundamentals Appendix/// Fundamentals Introduction";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			CommonDocumentsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.CommonDocumentsPackage _CommonDocumentsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CommonDocumentsPackage" path="/summary" />
	/// </summary>
	public Package.CommonDocumentsPackage CommonDocumentsPackage => _CommonDocumentsPackage ?? (_CommonDocumentsPackage = new Package.CommonDocumentsPackage());

	#endregion

	#region Classes
	#endregion
	}
}