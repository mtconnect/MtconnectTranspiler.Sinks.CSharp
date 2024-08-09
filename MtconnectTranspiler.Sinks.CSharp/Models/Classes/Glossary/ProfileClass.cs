using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// extends a reference metamodel (such as <i>UML</i>) by allowing to adapt or customize the metamodel with constructs that are specific to a particular domain, platform, or a software development method. 
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1630403640706_509877_41">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProfileClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1630403640706_509877_41";
		
		/// <inheritdoc />
		public string Summary => @"/// extends a reference metamodel (such as <i>UML</i>) by allowing to adapt or customize the metamodel with constructs that are specific to a particular domain, platform, or a software development method. ";

		/// <inheritdoc />
		public string Name => "profile";
		
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
		public ProfileClassProperties Properties { get; } = new ProfileClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ProfileClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}