using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AgentArchitecture.Source
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MQTTDataSourceGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1584929379292_433586_18837";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "MQTTDataSource";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_4_45f01b9_1645213778421_161707_289
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AgentArchitecture.SourceClass);

		/// <inheritdoc />
		public MQTTDataSourceGeneralizationProperties Properties { get; } = new MQTTDataSourceGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class MQTTDataSourceGeneralizationProperties : Mtconnect.AgentArchitecture.SourceClass.SourceClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}