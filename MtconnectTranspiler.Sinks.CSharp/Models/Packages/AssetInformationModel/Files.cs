using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Files;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="File">File</see> model.  ![Files](figures/Files.png "Files"){: width="0.8"}  > Note: See <see cref="File Schema Diagrams">File Schema Diagrams</see> for XML schema. /// Files Asset Information Model
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class FilesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1589825226627_349226_496";
		
		/// <inheritdoc />
		public string Name => "Files";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""File"">File</see> model.  ![Files](figures/Files.png ""Files""){: width=""0.8""}  > Note: See <see cref=""File Schema Diagrams"">File Schema Diagrams</see> for XML schema. /// Files Asset Information Model";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			AbstractFileClass,
			FileClass,
			FileArchetypeClass,
			FilePropertyClass,
			FileCommentClass,
			FileLocationClass,
			DestinationClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.AbstractFileClass _AbstractFileClass;
	/// <summary>
	/// <inheritdoc cref="Package.AbstractFileClass" path="/summary" />
	/// </summary>
	public Package.AbstractFileClass AbstractFileClass => _AbstractFileClass ?? (_AbstractFileClass = new Package.AbstractFileClass());

	private Package.FileClass _FileClass;
	/// <summary>
	/// <inheritdoc cref="Package.FileClass" path="/summary" />
	/// </summary>
	public Package.FileClass FileClass => _FileClass ?? (_FileClass = new Package.FileClass());

	private Package.FileArchetypeClass _FileArchetypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.FileArchetypeClass" path="/summary" />
	/// </summary>
	public Package.FileArchetypeClass FileArchetypeClass => _FileArchetypeClass ?? (_FileArchetypeClass = new Package.FileArchetypeClass());

	private Package.FilePropertyClass _FilePropertyClass;
	/// <summary>
	/// <inheritdoc cref="Package.FilePropertyClass" path="/summary" />
	/// </summary>
	public Package.FilePropertyClass FilePropertyClass => _FilePropertyClass ?? (_FilePropertyClass = new Package.FilePropertyClass());

	private Package.FileCommentClass _FileCommentClass;
	/// <summary>
	/// <inheritdoc cref="Package.FileCommentClass" path="/summary" />
	/// </summary>
	public Package.FileCommentClass FileCommentClass => _FileCommentClass ?? (_FileCommentClass = new Package.FileCommentClass());

	private Package.FileLocationClass _FileLocationClass;
	/// <summary>
	/// <inheritdoc cref="Package.FileLocationClass" path="/summary" />
	/// </summary>
	public Package.FileLocationClass FileLocationClass => _FileLocationClass ?? (_FileLocationClass = new Package.FileLocationClass());

	private Package.DestinationClass _DestinationClass;
	/// <summary>
	/// <inheritdoc cref="Package.DestinationClass" path="/summary" />
	/// </summary>
	public Package.DestinationClass DestinationClass => _DestinationClass ?? (_DestinationClass = new Package.DestinationClass());

	#endregion
	}
}