using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AgentArchitecture
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DataSourceServiceGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1587353600211_165608_1139";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "DataSourceService";
		
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
		/// Original Type: _19_0_3_45f01b9_1587352697171_916488_715
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AgentArchitecture.ServiceClass);

		/// <inheritdoc />
		public DataSourceServiceGeneralizationProperties Properties { get; } = new DataSourceServiceGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class DataSourceServiceGeneralizationProperties : Mtconnect.AgentArchitecture.ServiceClass.ServiceClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}