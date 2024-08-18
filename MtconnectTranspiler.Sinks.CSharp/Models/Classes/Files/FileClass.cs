#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.Files
{
	/// <summary>﻿<see cref="AbstractFile">AbstractFile</see> type that provides information about the <see cref="File">File</see> instance and its <i>URL</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1589825359572_789274_577">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FileClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1589825359572_789274_577";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(AbstractFile)}} type that provides information about the {{block(File)}} instance and its {{term(URL)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "File";
		
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
		public new FileClassProperties Properties { get; } = new FileClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="FileClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.Files.AbstractFileClass.AbstractFileClassProperties" />.
		/// </summary>
		public class FileClassProperties : Mtconnect.AssetInformationModel.Files.AbstractFileClass.AbstractFileClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				Size,
				VersionId,
				State,
				Signature,
				PublicKey,
				CreationTime,
				ModificationTime,
				HasLocationPart,
				HasDestinationPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="SizeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Size</remarks>
			/// </summary>
			public new SizeProperty Size { get; } = new SizeProperty();
			
			/// <summary>﻿size of the file in bytes.<br /><br /><br />
			/// </summary>
			public new sealed class SizeProperty : IProperty
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
				public string Name => "size";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;size of the file in bytes.&#10;
";

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
			public new VersionIdProperty VersionId { get; } = new VersionIdProperty();
			
			/// <summary>﻿version identifier of the file.<br /><br /><br /><br />
			/// </summary>
			public new sealed class VersionIdProperty : IProperty
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
				public string Name => "versionId";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;version identifier of the file.&#10;
";

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
			public new StateProperty State { get; } = new StateProperty();
			
			/// <summary>﻿state of the file. <br /><br /><br />
			/// </summary>
			public new sealed class StateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605276722719_257725_310</item>
				/// <item>Type: FileStateEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.FileStateEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "state";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;state of the file. &#10;
";

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
			public new SignatureProperty Signature { get; } = new SignatureProperty();
			
			/// <summary>﻿secure hash of the file.<br /><br /><br />
			/// </summary>
			public new sealed class SignatureProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;secure hash of the file.&#10;
";

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
			public new PublicKeyProperty PublicKey { get; } = new PublicKeyProperty();
			
			/// <summary>﻿public key used to verify the signature.<br /><br /><br />
			/// </summary>
			public new sealed class PublicKeyProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;public key used to verify the signature.&#10;
";

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
			public new CreationTimeProperty CreationTime { get; } = new CreationTimeProperty();
			
			/// <summary>﻿time the file was created.<br /><br /><br />
			/// </summary>
			public new sealed class CreationTimeProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;time the file was created.&#10;
";

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
			public new ModificationTimeProperty ModificationTime { get; } = new ModificationTimeProperty();
			
			/// <summary>﻿time the file was modified.<br /><br /><br />
			/// </summary>
			public new sealed class ModificationTimeProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;time the file was modified.&#10;
";

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
			public new HasLocationPartProperty HasLocationPart { get; } = new HasLocationPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasLocationPartProperty : IProperty
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
				public string Name => "hasLocation";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			public new HasDestinationPartProperty HasDestinationPart { get; } = new HasDestinationPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasDestinationPartProperty : IProperty
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
				public string Name => "hasDestination";
				
				/// <inheritdoc />
				public string Summary => @"";

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