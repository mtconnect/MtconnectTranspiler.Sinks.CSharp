#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>﻿method for an <i>agent</i> to provide a continuous stream of information in response to a single <i>request</i> from a <i>client</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375154_395455_1977">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DataStreamingClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375154_395455_1977";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;method for an {{term(agent)}} to provide a continuous stream of information in response to a single {{term(request)}} from a {{term(client)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "data streaming";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375187_272252_2094
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.StreamingDataClass);

		/// <inheritdoc />
		public new DataStreamingClassProperties Properties { get; } = new DataStreamingClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DataStreamingClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.StreamingDataClass.StreamingDataClassProperties" />.
		/// </summary>
		public class DataStreamingClassProperties : Mtconnect.Glossary.ProtocolTerms.StreamingDataClass.StreamingDataClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}