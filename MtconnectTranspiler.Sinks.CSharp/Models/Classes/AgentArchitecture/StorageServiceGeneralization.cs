using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AgentArchitecture
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class StorageServiceGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1587355456959_219426_1981";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "StorageService";
		
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
		public StorageServiceGeneralizationProperties Properties { get; } = new StorageServiceGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class StorageServiceGeneralizationProperties : Mtconnect.AgentArchitecture.ServiceClass.ServiceClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}