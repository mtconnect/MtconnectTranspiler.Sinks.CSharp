using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.Files
{
	/// <summary>
	/// <see cref="AbstractFile">AbstractFile</see> type that provides information common to all versions of a file. 
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1589825369611_93186_622">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class FileArchetypeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1589825369611_93186_622";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information common to all versions of a file. ";

		/// <inheritdoc />
		public string Name => "FileArchetype";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1589825445428_505818_673
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.Files.AbstractFileClass);

		/// <inheritdoc />
		public FileArchetypeClassProperties Properties { get; } = new FileArchetypeClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class FileArchetypeClassProperties : Mtconnect.AssetInformationModel.Files.AbstractFileClass.AbstractFileClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}