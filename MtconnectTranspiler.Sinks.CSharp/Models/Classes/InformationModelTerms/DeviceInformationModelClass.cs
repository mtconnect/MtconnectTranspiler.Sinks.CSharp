using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.InformationModelTerms
{
	/// <summary>
	/// <i>information model</i> that describes the physical and logical configuration for a piece of equipment and the data that may be reported by that equipment. 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DeviceInformationModelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375156_601971_1981";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>information model</i> that describes the physical and logical configuration for a piece of equipment and the data that may be reported by that equipment. ";

		/// <inheritdoc />
		public string Name => "DeviceInformationModelClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1623664375172_792733_2037";

		public IPropertyList Properties => null;

	}
}