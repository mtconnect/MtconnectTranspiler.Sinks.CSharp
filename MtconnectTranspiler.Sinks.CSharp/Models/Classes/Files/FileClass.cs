using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;
// using Mtconnect.AssetInformationModel.Files;

namespace Mtconnect.AssetInformationModel.Files
{
	/// <summary>
	/// <see cref="AbstractFile">AbstractFile</see> type that provides information about the <see cref="File">File</see> instance and its <i>URL</i>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class FileClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1589825359572_789274_577";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information about the <see cref=""File"">File</see> instance and its <i>URL</i>.";

		/// <inheritdoc />
		public string Name => "FileClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1589825445428_505818_673";

		/// <inheritdoc />
		public FileClassProperties Properties { get; } = new FileClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class FileClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Size,
				VersionId,
				State,
				Signature,
				PublicKey,
				CreationTime,
				ModificationTime,
				HasLocationPart,
				HasDestinationPart,
			};
			/// <summary>
			/// <inheritdoc cref="SizeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Size</remarks>
			/// </summary>
			public SizeProperty Size { get; } = new SizeProperty();
			/// <summary>
			/// size of the file in bytes.
			/// </summary>
			public sealed class SizeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272271512_537408_674</item>
				/// <item>Type: Int32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => "Size";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information about the <see cref=""File"">File</see> instance and its <i>URL</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="VersionIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: VersionId</remarks>
			/// </summary>
			public VersionIdProperty VersionId { get; } = new VersionIdProperty();
			/// <summary>
			/// version identifier of the file. 
			/// </summary>
			public sealed class VersionIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "VersionId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information about the <see cref=""File"">File</see> instance and its <i>URL</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="StateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: State</remarks>
			/// </summary>
			public StateProperty State { get; } = new StateProperty();
			/// <summary>
			/// state of the file. 
			/// </summary>
			public sealed class StateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605276722719_257725_310</item>
				/// <item>Type: FileStateEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.FileStateEnum);
				
				/// <inheritdoc />
				public string Name => "State";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information about the <see cref=""File"">File</see> instance and its <i>URL</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="SignatureProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Signature</remarks>
			/// </summary>
			public SignatureProperty Signature { get; } = new SignatureProperty();
			/// <summary>
			/// secure hash of the file.
			/// </summary>
			public sealed class SignatureProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1636367810937_283958_42</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "Signature";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information about the <see cref=""File"">File</see> instance and its <i>URL</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="PublicKeyProperty" path="/summary" /><br/>
			/// <remarks>Original Name: PublicKey</remarks>
			/// </summary>
			public PublicKeyProperty PublicKey { get; } = new PublicKeyProperty();
			/// <summary>
			/// public key used to verify the signature.
			/// </summary>
			public sealed class PublicKeyProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1636367810937_283958_42</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "PublicKey";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information about the <see cref=""File"">File</see> instance and its <i>URL</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="CreationTimeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CreationTime</remarks>
			/// </summary>
			public CreationTimeProperty CreationTime { get; } = new CreationTimeProperty();
			/// <summary>
			/// time the file was created.
			/// </summary>
			public sealed class CreationTimeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "CreationTime";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information about the <see cref=""File"">File</see> instance and its <i>URL</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="ModificationTimeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ModificationTime</remarks>
			/// </summary>
			public ModificationTimeProperty ModificationTime { get; } = new ModificationTimeProperty();
			/// <summary>
			/// time the file was modified.
			/// </summary>
			public sealed class ModificationTimeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "ModificationTime";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information about the <see cref=""File"">File</see> instance and its <i>URL</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasLocationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasLocation</remarks>
			/// </summary>
			public HasLocationPartProperty HasLocationPart { get; } = new HasLocationPartProperty();
			public sealed class HasLocationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605277122154_664309_406</item>
				/// <item>Type: FileLocationClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.Files</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Files.FileLocationClass);
				
				/// <inheritdoc />
				public string Name => "HasLocation";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information about the <see cref=""File"">File</see> instance and its <i>URL</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "FileLocation";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasDestinationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDestination</remarks>
			/// </summary>
			public HasDestinationPartProperty HasDestinationPart { get; } = new HasDestinationPartProperty();
			public sealed class HasDestinationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605277188545_673734_476</item>
				/// <item>Type: DestinationClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.Files</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Files.DestinationClass);
				
				/// <inheritdoc />
				public string Name => "HasDestination";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractFile"">AbstractFile</see> type that provides information about the <see cref=""File"">File</see> instance and its <i>URL</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Destinations";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}