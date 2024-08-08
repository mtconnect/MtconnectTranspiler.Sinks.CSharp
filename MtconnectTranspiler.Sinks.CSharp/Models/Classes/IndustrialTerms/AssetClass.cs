using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.IndustrialTerms
{
	/// <summary>
	/// item, thing or entity that has potential or actual value to an organization. <seealso href="https://www.google.com/search?q=ISO 55000:2014&btnI=I">ISO 55000:2014</seealso>  > Note 1 to entry: Value can be tangible or intangible, financial or non-financial, and includes consideration of risks and liabilities. It can be positive or negative at different stages of the asset life.  > Note 2 to entry: Physical assets usually refer to equipment, inventory and properties owned by the organization. Physical assets are the opposite of intangible assets, which are non-physical assets such as leases, brands, digital assets, use rights, licences, intellectual property rights, reputation or agreements.  > Note 3 to entry: A grouping of assets referred to as an asset system could also be considered as an asset.  
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AssetClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580561892811_529841_16867";
		
		/// <inheritdoc />
		public string Summary => @"/// item, thing or entity that has potential or actual value to an organization. <seealso href=""https://www.google.com/search?q=ISO 55000:2014&btnI=I"">ISO 55000:2014</seealso>  > Note 1 to entry: Value can be tangible or intangible, financial or non-financial, and includes consideration of risks and liabilities. It can be positive or negative at different stages of the asset life.  > Note 2 to entry: Physical assets usually refer to equipment, inventory and properties owned by the organization. Physical assets are the opposite of intangible assets, which are non-physical assets such as leases, brands, digital assets, use rights, licences, intellectual property rights, reputation or agreements.  > Note 3 to entry: A grouping of assets referred to as an asset system could also be considered as an asset.  ";

		/// <inheritdoc />
		public string Name => "AssetClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1581733974550_623533_615";

		public IPropertyList Properties => null;

	}
}