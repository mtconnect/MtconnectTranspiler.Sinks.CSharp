#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>﻿<i>agent</i> for the <i>MTConnect Information Model</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375170_484237_2032">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectAgentGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375170_484237_2032";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(agent)}} for the {{term(MTConnect Information Model)}}.&#10;
";

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
		public new MTConnectAgentGeneralizationProperties Properties { get; } = new MTConnectAgentGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectAgentGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.AgentClass.AgentClassProperties" />.
		/// </summary>
		public class MTConnectAgentGeneralizationProperties : Mtconnect.Glossary.AgentClass.AgentClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}