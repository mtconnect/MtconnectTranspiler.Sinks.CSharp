#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>﻿<i>request</i> for information issued from a <i>client</i> to an <i>MTConnect Agent</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375172_946031_2039">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectRequestGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375172_946031_2039";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(request)}} for information issued from a {{term(client)}} to an {{term(MTConnect Agent)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "MTConnect Request";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375181_991321_2071
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.RequestClass);

		/// <inheritdoc />
		public new MTConnectRequestGeneralizationProperties Properties { get; } = new MTConnectRequestGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectRequestGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.RequestClass.RequestClassProperties" />.
		/// </summary>
		public class MTConnectRequestGeneralizationProperties : Mtconnect.Glossary.ProtocolTerms.RequestClass.RequestClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}