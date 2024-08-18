#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>﻿receiving messages in a <i>publish and subscribe</i> pattern.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375188_852098_2096">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SubscribeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375188_852098_2096";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;receiving messages in a {{term(publish and subscribe)}} pattern.&#10;
";

		/// <inheritdoc />
		public string Name => "subscribe";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375180_561625_2067
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.PublishAndSubscribeClass);

		/// <inheritdoc />
		public new SubscribeClassProperties Properties { get; } = new SubscribeClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="SubscribeClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.PublishAndSubscribeClass.PublishAndSubscribeClassProperties" />.
		/// </summary>
		public class SubscribeClassProperties : Mtconnect.Glossary.ProtocolTerms.PublishAndSubscribeClass.PublishAndSubscribeClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}