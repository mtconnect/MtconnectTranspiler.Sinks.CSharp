using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>
	/// <i>agent</i> for the <i>MTConnect Information Model</i>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375170_484237_2032">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MTConnectAgentGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375170_484237_2032";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>agent</i> for the <i>MTConnect Information Model</i>.";

		/// <inheritdoc />
		public string Name => "MTConnect Agent";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375139_475436_1947
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.AgentClass);

		/// <inheritdoc />
		public MTConnectAgentGeneralizationProperties Properties { get; } = new MTConnectAgentGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class MTConnectAgentGeneralizationProperties : Mtconnect.Glossary.AgentClass.AgentClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}