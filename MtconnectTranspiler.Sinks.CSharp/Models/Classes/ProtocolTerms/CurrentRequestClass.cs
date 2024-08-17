#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>﻿<i>request</i> to an <i>agent</i> to produce an <i>MTConnectStreams Response Document</i> containing the <i>Observation Information Model</i> for a snapshot of the latest <i>observation</i>s at the moment of the <i>request</i> or at a given <i>sequence number</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375151_897599_1970">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CurrentRequestClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375151_897599_1970";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(request)}} to an {{term(agent)}} to produce an {{term(MTConnectStreams Response Document)}} containing the {{term(Observation Information Model)}} for a snapshot of the latest {{termplural(observation)}} at the moment of the {{term(request)}} or at a given {{term(sequence number)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "current request";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375172_946031_2039
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.MTConnectRequestGeneralization);

		/// <inheritdoc />
		public CurrentRequestClassProperties Properties { get; } = new CurrentRequestClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CurrentRequestClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.MTConnectRequestGeneralization.MTConnectRequestGeneralizationProperties" />.
		/// </summary>
		public class CurrentRequestClassProperties : Mtconnect.Glossary.ProtocolTerms.MTConnectRequestGeneralization.MTConnectRequestGeneralizationProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}