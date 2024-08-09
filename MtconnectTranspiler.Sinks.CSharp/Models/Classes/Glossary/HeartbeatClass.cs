using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// function that indicates to a <i>client</i> that the communications connection to an <i>agent</i> is still viable during times when there is no new data available to report  often referred to as a "keep alive" message.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375160_713692_1995">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class HeartbeatClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375160_713692_1995";
		
		/// <inheritdoc />
		public string Summary => @"/// function that indicates to a <i>client</i> that the communications connection to an <i>agent</i> is still viable during times when there is no new data available to report  often referred to as a ""keep alive"" message.";

		/// <inheritdoc />
		public string Name => "heartbeat";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public HeartbeatClassProperties Properties { get; } = new HeartbeatClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class HeartbeatClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}