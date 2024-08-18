#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>﻿optional piece of hardware or software that transforms information provided by a piece of equipment into a form that can be received by an <i>agent</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375138_661037_1946">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AdapterClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375138_661037_1946";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;optional piece of hardware or software that transforms information provided by a piece of equipment into a form that can be received by an {{term(agent)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "adapter";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375141_18140_1949
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ApplicationClass);

		/// <inheritdoc />
		public new AdapterClassProperties Properties { get; } = new AdapterClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AdapterClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ApplicationClass.ApplicationClassProperties" />.
		/// </summary>
		public class AdapterClassProperties : Mtconnect.Glossary.ApplicationClass.ApplicationClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}