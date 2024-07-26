
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AssetInformationModel.Files;

using Mtconnect;

namespace Mtconnect.AssetInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class FilesPackage {


	private Package.AbstractFileClass _AbstractFile;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AbstractFileClass AbstractFile => _AbstractFile ?? (_AbstractFile = new Package.AbstractFileClass());

	private Package.FileClass _File;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FileClass File => _File ?? (_File = new Package.FileClass());

	private Package.FileArchetypeClass _FileArchetype;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FileArchetypeClass FileArchetype => _FileArchetype ?? (_FileArchetype = new Package.FileArchetypeClass());

	private Package.FilePropertyClass _FileProperty;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FilePropertyClass FileProperty => _FileProperty ?? (_FileProperty = new Package.FilePropertyClass());

	private Package.FileCommentClass _FileComment;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FileCommentClass FileComment => _FileComment ?? (_FileComment = new Package.FileCommentClass());

	private Package.FileLocationClass _FileLocation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FileLocationClass FileLocation => _FileLocation ?? (_FileLocation = new Package.FileLocationClass());

	private Package.DestinationClass _Destination;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DestinationClass Destination => _Destination ?? (_Destination = new Package.DestinationClass());
	}
}