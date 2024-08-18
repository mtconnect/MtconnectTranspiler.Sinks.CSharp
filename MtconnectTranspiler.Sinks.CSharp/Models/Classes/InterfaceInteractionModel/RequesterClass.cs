#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.InterfaceInteractionModel
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622805783807_480004_607">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RequesterClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622805783807_480004_607";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "Requester";
		
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
		public new RequesterClassProperties Properties { get; } = new RequesterClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="RequesterClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.InterfaceInteractionModel.InterfaceClass.InterfaceClassProperties" />.
		/// </summary>
		public class RequesterClassProperties : Mtconnect.InterfaceInteractionModel.InterfaceClass.InterfaceClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}