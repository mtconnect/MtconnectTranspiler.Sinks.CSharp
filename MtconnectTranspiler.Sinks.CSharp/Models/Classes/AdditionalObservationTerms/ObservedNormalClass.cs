#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581814918288_154411_5552">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ObservedNormalClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581814918288_154411_5552";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "Observed Normal";
		
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
		/// Original Type: _19_0_3_45f01b9_1581814683848_300422_5123
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms.ObservedConditionClass);

		/// <inheritdoc />
		public new ObservedNormalClassProperties Properties { get; } = new ObservedNormalClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ObservedNormalClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms.ObservedConditionClass.ObservedConditionClassProperties" />.
		/// </summary>
		public class ObservedNormalClassProperties : Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms.ObservedConditionClass.ObservedConditionClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}