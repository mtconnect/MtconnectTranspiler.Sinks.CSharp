using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.InterfaceInteractionModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ResponderClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622805797294_995075_652";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "Responder";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572381996_964170_42252
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.InterfaceInteractionModel.InterfaceClass);

		/// <inheritdoc />
		public ResponderClassProperties Properties { get; } = new ResponderClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ResponderClassProperties : Mtconnect.InterfaceInteractionModel.InterfaceClass.InterfaceClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}