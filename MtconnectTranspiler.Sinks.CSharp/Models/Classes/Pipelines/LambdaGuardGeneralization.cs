using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AgentArchitecture.Pipelines
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class LambdaGuardGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1674414517415_840067_3791";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "LambdaGuard";
		
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
		/// Original Type: _19_0_4_45f01b9_1674414211400_186233_3570
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AgentArchitecture.Pipelines.GuardClass);

		/// <inheritdoc />
		public LambdaGuardGeneralizationProperties Properties { get; } = new LambdaGuardGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class LambdaGuardGeneralizationProperties : Mtconnect.AgentArchitecture.Pipelines.GuardClass.GuardClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Lambda,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="LambdaProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Lambda</remarks>
			/// </summary>
			public LambdaProperty Lambda { get; } = new LambdaProperty();
			public sealed class LambdaProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_4_45f01b9_1674414564913_988496_3836</item>
				/// <item>Type: Object</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(object);
				
				/// <inheritdoc />
				public string Name => "lambda";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}