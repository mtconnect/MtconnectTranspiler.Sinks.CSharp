#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>﻿<i>observation</i>s published by a piece of equipment defined by the <i>equipment metadata</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375187_272252_2094">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class StreamingDataClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375187_272252_2094";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{termplural(observation)}} published by a piece of equipment defined by the {{term(equipment metadata)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "streaming data";
		
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
		public StreamingDataClassProperties Properties { get; } = new StreamingDataClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="StreamingDataClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.PublishAndSubscribeClass.PublishAndSubscribeClassProperties" />.
		/// </summary>
		public class StreamingDataClassProperties : Mtconnect.Glossary.ProtocolTerms.PublishAndSubscribeClass.PublishAndSubscribeClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}