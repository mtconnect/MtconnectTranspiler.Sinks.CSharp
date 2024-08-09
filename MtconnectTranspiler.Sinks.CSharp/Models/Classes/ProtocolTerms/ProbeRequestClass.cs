using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// <i>request</i> to an <i>agent</i> to produce an <i>MTConnectDevices Response Document</i> containing the <i>Device Information Model</i>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375179_316583_2064">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProbeRequestClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375179_316583_2064";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>request</i> to an <i>agent</i> to produce an <i>MTConnectDevices Response Document</i> containing the <i>Device Information Model</i>.";

		/// <inheritdoc />
		public string Name => "probe request";
		
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
		public ProbeRequestClassProperties Properties { get; } = new ProbeRequestClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ProbeRequestClassProperties : Mtconnect.Glossary.ProtocolTerms.MTConnectRequestGeneralization.MTConnectRequestGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}