using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.ImageFiles;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>
	/// This section provides semantic information for the <see cref="ImageFile">ImageFile</see> entity.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1677586007782_145120_733">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class ImageFilesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1677586007782_145120_733";
		
		/// <inheritdoc />
		public string Name => "ImageFiles";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""ImageFile"">ImageFile</see> entity.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ImageFileClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.ImageFileClass _ImageFileClass;
	/// <summary>
	/// <inheritdoc cref="Package.ImageFileClass" path="/summary" />
	/// </summary>
	public Package.ImageFileClass ImageFileClass => _ImageFileClass ?? (_ImageFileClass = new Package.ImageFileClass());

	#endregion
	}
}