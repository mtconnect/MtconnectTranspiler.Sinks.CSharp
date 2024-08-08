using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// extends a reference metamodel (such as <i>UML</i>) by allowing to adapt or customize the metamodel with constructs that are specific to a particular domain, platform, or a software development method. 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProfileClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1630403640706_509877_41";
		
		/// <inheritdoc />
		public string Summary => @"/// extends a reference metamodel (such as <i>UML</i>) by allowing to adapt or customize the metamodel with constructs that are specific to a particular domain, platform, or a software development method. ";

		/// <inheritdoc />
		public string Name => "ProfileClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		public IPropertyList Properties => null;

	}
}