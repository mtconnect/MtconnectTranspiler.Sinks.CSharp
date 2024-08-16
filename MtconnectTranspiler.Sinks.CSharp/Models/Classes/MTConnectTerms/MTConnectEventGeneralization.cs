using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>
	﻿/// <i>observation</i> of either a state or discrete value of the <i>Component</i>. <br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375172_390471_2036">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectEventGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375172_390471_2036";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of either a state or discrete value of the {{term(Component)}}. &#10;
";

		/// <inheritdoc />
		public string Name => "MTConnect Event";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375159_408729_1991
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms.EventClass);

		/// <inheritdoc />
		public MTConnectEventGeneralizationProperties Properties { get; } = new MTConnectEventGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class MTConnectEventGeneralizationProperties : Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms.EventClass.EventClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}