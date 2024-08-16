using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Files;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>
	﻿/// This section provides semantic information for the <see cref="File">File</see> model.<br /><br />![Files](figures/Files.png "Files"){: width="0.8"}<br /><br />> Note: See <see cref="File Schema Diagrams">File Schema Diagrams</see> for XML schema.<br /><br/><br />Files Asset Information Model<br/>Manufacturing processes require various documents, programs, setup sheets, and digital media available at the device for a given process. The <see cref="File">File</see> and <see cref="FileArchetype">FileArchetype</see> <see cref="Asset">Asset</see>s provide a mechanism to communicate specific "Files" that are relevant to a process where the media is located on a server and represented by a Universal Resource Locator (URL).<br /><br />The <see cref="FileArchetype">FileArchetype</see> contains metadata common to all <see cref="File">File</see> <see cref="Asset">Asset</see>s for a certain purpose. The <see cref="File">File</see> <see cref="Asset">Asset</see> references the file specific to a given device or set of devices. The <see cref="File">File</see> <see cref="Asset">Asset</see> does not hold the contents of the file, it contains a reference to the location (URL) used to access the information. The metadata associated with the <see cref="File">File</see> provides semantic information about the representation (mime-type) and the application associated with the <see cref="File">File</see>. The application of the file is an extensible controlled vocabulary with common manufacturing uses provided.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1589825226627_349226_496">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class FilesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1589825226627_349226_496";
		
		/// <inheritdoc />
		public string Name => "Files";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(File)}} model.

![Files](figures/Files.png ""Files""){: width=""0.8""}

> Note: See {{sect(File Schema Diagrams)}} for XML schema.
&#10;
&#10;&#10;&#10;Files Asset Information Model&#10;&#10;&#10;&#10;Manufacturing processes require various documents, programs, setup sheets, and digital media available at the device for a given process. The {{block(File)}} and {{block(FileArchetype)}} {{block(Asset)}}s provide a mechanism to communicate specific ""Files"" that are relevant to a process where the media is located on a server and represented by a Universal Resource Locator (URL).

The {{block(FileArchetype)}} contains metadata common to all {{block(File)}} {{block(Asset)}}s for a certain purpose. The {{block(File)}} {{block(Asset)}} references the file specific to a given device or set of devices. The {{block(File)}} {{block(Asset)}} does not hold the contents of the file, it contains a reference to the location (URL) used to access the information. The metadata associated with the {{block(File)}} provides semantic information about the representation (mime-type) and the application associated with the {{block(File)}}. The application of the file is an extensible controlled vocabulary with common manufacturing uses provided.&#10;
";

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