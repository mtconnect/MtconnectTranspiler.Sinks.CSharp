#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>﻿asynchronous communication method in which messages are exchanged between applications without knowing the identity of the sender or recipient.<br /><br />&gt; Note: In the MTConnect Standard, a communications messaging pattern that may be used to publish <i>streaming data</i> from an <i>agent</i>. <br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375180_561625_2067">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PublishAndSubscribeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375180_561625_2067";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;asynchronous communication method in which messages are exchanged between applications without knowing the identity of the sender or recipient.

> Note: In the MTConnect Standard, a communications messaging pattern that may be used to publish {{term(streaming data)}} from an {{term(agent)}}. 

&#10;
";

		/// <inheritdoc />
		public string Name => "publish and subscribe";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375180_471026_2065
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.ProtocolClass);

		/// <inheritdoc />
		public new PublishAndSubscribeClassProperties Properties { get; } = new PublishAndSubscribeClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="PublishAndSubscribeClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.ProtocolClass.ProtocolClassProperties" />.
		/// </summary>
		public class PublishAndSubscribeClassProperties : Mtconnect.Glossary.ProtocolTerms.ProtocolClass.ProtocolClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}