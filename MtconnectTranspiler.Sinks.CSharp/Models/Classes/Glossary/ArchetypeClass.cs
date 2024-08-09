using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// <i>archetype</i> provides the requirements, constraints, and common properties for a type of <i>Asset</i>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375141_294923_1950">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ArchetypeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375141_294923_1950";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>archetype</i> provides the requirements, constraints, and common properties for a type of <i>Asset</i>.";

		/// <inheritdoc />
		public string Name => "archetype";
		
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
		/// Original Type: _19_0_3_45f01b9_1580561892811_529841_16867
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.IndustrialTerms.AssetClass);

		/// <inheritdoc />
		public ArchetypeClassProperties Properties { get; } = new ArchetypeClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ArchetypeClassProperties : Mtconnect.Glossary.IndustrialTerms.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}