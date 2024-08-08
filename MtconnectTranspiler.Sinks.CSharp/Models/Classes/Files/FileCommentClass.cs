using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.Files
{
	/// <summary>
	/// remark or interpretation for human interpretation associated with a <see cref="File">File</see> or <see cref="FileArchetype">FileArchetype</see>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class FileCommentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605276197212_1938_196";
		
		/// <inheritdoc />
		public string Summary => @"/// remark or interpretation for human interpretation associated with a <see cref=""File"">File</see> or <see cref=""FileArchetype"">FileArchetype</see>.";

		/// <inheritdoc />
		public string Name => "FileCommentClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public FileCommentClassProperties Properties { get; } = new FileCommentClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class FileCommentClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Timestamp,
				Value,
			};
			/// <summary>
			/// <inheritdoc cref="TimestampProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Timestamp</remarks>
			/// </summary>
			public TimestampProperty Timestamp { get; } = new TimestampProperty();
			/// <summary>
			/// time the comment was made.
			/// </summary>
			public sealed class TimestampProperty : IProperty
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
				public string Name => "Timestamp";
				
				/// <inheritdoc />
				public string Summary => @"/// remark or interpretation for human interpretation associated with a <see cref=""File"">File</see> or <see cref=""FileArchetype"">FileArchetype</see>.";

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
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			/// <summary>
			/// text of the comment about the file.
			/// </summary>
			public sealed class ValueProperty : IProperty
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
				public string Name => "Value";
				
				/// <inheritdoc />
				public string Summary => @"/// remark or interpretation for human interpretation associated with a <see cref=""File"">File</see> or <see cref=""FileArchetype"">FileArchetype</see>.";

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