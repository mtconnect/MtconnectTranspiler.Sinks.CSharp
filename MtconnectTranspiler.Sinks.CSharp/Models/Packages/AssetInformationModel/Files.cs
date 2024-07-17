using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Files;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class FilesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			AbstractFileClass,
			FileClass,
			FileArchetypeClass,
			FilePropertyClass,
			FileCommentClass,
			FileLocationClass,
			DestinationClass,
		};

	private Package.AbstractFileClass _AbstractFileClass;
	public Package.AbstractFileClass AbstractFileClass => _AbstractFileClass ?? (_AbstractFileClass = new Package.AbstractFileClass());
	private Package.FileClass _FileClass;
	public Package.FileClass FileClass => _FileClass ?? (_FileClass = new Package.FileClass());
	private Package.FileArchetypeClass _FileArchetypeClass;
	public Package.FileArchetypeClass FileArchetypeClass => _FileArchetypeClass ?? (_FileArchetypeClass = new Package.FileArchetypeClass());
	private Package.FilePropertyClass _FilePropertyClass;
	public Package.FilePropertyClass FilePropertyClass => _FilePropertyClass ?? (_FilePropertyClass = new Package.FilePropertyClass());
	private Package.FileCommentClass _FileCommentClass;
	public Package.FileCommentClass FileCommentClass => _FileCommentClass ?? (_FileCommentClass = new Package.FileCommentClass());
	private Package.FileLocationClass _FileLocationClass;
	public Package.FileLocationClass FileLocationClass => _FileLocationClass ?? (_FileLocationClass = new Package.FileLocationClass());
	private Package.DestinationClass _DestinationClass;
	public Package.DestinationClass DestinationClass => _DestinationClass ?? (_DestinationClass = new Package.DestinationClass());
	}
}