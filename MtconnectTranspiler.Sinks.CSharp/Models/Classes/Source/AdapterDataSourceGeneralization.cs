using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AgentArchitecture.Source
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AdapterDataSourceGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1584929351481_353678_18793";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "AdapterDataSource";
		
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
		public AdapterDataSourceGeneralizationProperties Properties { get; } = new AdapterDataSourceGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class AdapterDataSourceGeneralizationProperties : Mtconnect.AgentArchitecture.SourceClass.SourceClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}