using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// <see cref="SensorAttachment::result" /> <b>MUST</b> be of a <see cref="Table">Table</see>, <see cref="DataSet">DataSet</see> or <see cref="Value">Value</see> <see cref="Representation">Representation</see> type.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SensorAttachmentResultClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1620207520256_148935_1073";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""SensorAttachment::result"" /> <b>MUST</b> be of a <see cref=""Table"">Table</see>, <see cref=""DataSet"">DataSet</see> or <see cref=""Value"">Value</see> <see cref=""Representation"">Representation</see> type.";

		/// <inheritdoc />
		public string Name => "SensorAttachmentResultClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579566531114_503405_25727";

		/// <inheritdoc />
		public SensorAttachmentResultClassProperties Properties { get; } = new SensorAttachmentResultClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class SensorAttachmentResultClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				SensorId,
			};
			/// <summary>
			/// <inheritdoc cref="SensorIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SensorId</remarks>
			/// </summary>
			public SensorIdProperty SensorId { get; } = new SensorIdProperty();
			/// <summary>
			/// identity of a sensor used to observe some measurement of an item.
			/// </summary>
			public sealed class SensorIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "SensorId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""SensorAttachment::result"" /> <b>MUST</b> be of a <see cref=""Table"">Table</see>, <see cref=""DataSet"">DataSet</see> or <see cref=""Value"">Value</see> <see cref=""Representation"">Representation</see> type.";

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