using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.Files
{
	/// <summary>
	﻿/// <i>URL</i> reference to the file location. <br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605277122154_664309_406">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FileLocationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605277122154_664309_406";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(URL)}} reference to the file location. &#10;
";

		/// <inheritdoc />
		public string Name => "FileLocation";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public FileLocationClassProperties Properties { get; } = new FileLocationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class FileLocationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Href,
				Xlink_Type,
			};
			/// <summary>
			/// <inheritdoc cref="HrefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Href</remarks>
			/// </summary>
			public HrefProperty Href { get; } = new HrefProperty();
			/// <summary>
			﻿/// <i>URL</i> reference to the file.<br /><br /><c>href</c> is of type <c>xlink:href</c> from the W3C XLink specification.<br /><br/><br />

			/// </summary>
			public sealed class HrefProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579298271303_312832_6966</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "href";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(URL)}} reference to the file.

`href` is of type `xlink:href` from the W3C XLink specification.&#10;
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
			/// <inheritdoc cref="Xlink_TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Xlink:Type</remarks>
			/// </summary>
			public Xlink_TypeProperty Xlink_Type { get; } = new Xlink_TypeProperty();
			/// <summary>
			﻿/// type of href for the xlink href type. <br /><br /><b>MUST</b> be <c>locator</c> referring to a <i>URL</i><br />.<br/><br />

			/// </summary>
			public sealed class Xlink_TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579298283941_424312_6968</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "xlink:type";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;type of href for the xlink href type. 

**MUST** be `locator` referring to a {{term(URL)}}.&#10;
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
		};

	}
}