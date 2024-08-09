using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.InformationModelTerms
{
	/// <summary>
	/// <i>information model</i> that describes the physical and logical configuration for a piece of equipment and the data that may be reported by that equipment. 
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375156_601971_1981">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DeviceInformationModelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375156_601971_1981";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>information model</i> that describes the physical and logical configuration for a piece of equipment and the data that may be reported by that equipment. ";

		/// <inheritdoc />
		public string Name => "Device Information Model";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375172_792733_2037
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization);

		/// <inheritdoc />
		public DeviceInformationModelClassProperties Properties { get; } = new DeviceInformationModelClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DeviceInformationModelClassProperties : Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization.MTConnectInformationModelGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}