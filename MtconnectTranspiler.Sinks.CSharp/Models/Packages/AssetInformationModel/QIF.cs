using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.QIF;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="QIFDocumentWrapper">QIFDocumentWrapper</see> model.  ![QIFDocumentWrapper](figures/QIFDocumentWrapper.png "QIFDocumentWrapper"){: width="0.8"}  > Note: See <see cref="QIFDocumentWrapper Schema Diagrams">QIFDocumentWrapper Schema Diagrams</see> for XML schema./// QIF Asset Information Model
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1622119427718_488449_1678">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class QIFPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622119427718_488449_1678";
		
		/// <inheritdoc />
		public string Name => "QIF";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""QIFDocumentWrapper"">QIFDocumentWrapper</see> model.  ![QIFDocumentWrapper](figures/QIFDocumentWrapper.png ""QIFDocumentWrapper""){: width=""0.8""}  > Note: See <see cref=""QIFDocumentWrapper Schema Diagrams"">QIFDocumentWrapper Schema Diagrams</see> for XML schema./// QIF Asset Information Model";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			QIFDocumentClass,
			QIFDocumentWrapperClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.QIFDocumentClass _QIFDocumentClass;
	/// <summary>
	/// <inheritdoc cref="Package.QIFDocumentClass" path="/summary" />
	/// </summary>
	public Package.QIFDocumentClass QIFDocumentClass => _QIFDocumentClass ?? (_QIFDocumentClass = new Package.QIFDocumentClass());

	private Package.QIFDocumentWrapperClass _QIFDocumentWrapperClass;
	/// <summary>
	/// <inheritdoc cref="Package.QIFDocumentWrapperClass" path="/summary" />
	/// </summary>
	public Package.QIFDocumentWrapperClass QIFDocumentWrapperClass => _QIFDocumentWrapperClass ?? (_QIFDocumentWrapperClass = new Package.QIFDocumentWrapperClass());

	#endregion
	}
}