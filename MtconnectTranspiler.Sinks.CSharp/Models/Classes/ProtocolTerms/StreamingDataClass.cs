using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// <i>observation</i>s published by a piece of equipment defined by the <i>equipment metadata</i>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375187_272252_2094">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class StreamingDataClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375187_272252_2094";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>observation</i>s published by a piece of equipment defined by the <i>equipment metadata</i>.";

		/// <inheritdoc />
		public string Name => "streaming data";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375180_561625_2067
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.PublishAndSubscribeClass);

		/// <inheritdoc />
		public StreamingDataClassProperties Properties { get; } = new StreamingDataClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class StreamingDataClassProperties : Mtconnect.Glossary.ProtocolTerms.PublishAndSubscribeClass.PublishAndSubscribeClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}