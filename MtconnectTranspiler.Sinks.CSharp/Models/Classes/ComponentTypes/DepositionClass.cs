#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="Auxiliary">Auxiliary</see> that manages the addition of material or state change of material being performed in an additive manufacturing process.<br /><br /><br />Description<br /><br />For example, this could describe the portion of a piece of equipment that manages a material extrusion process or a vat polymerization process.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381981_362854_42222">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DepositionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381981_362854_42222";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Auxiliary)}} that manages the addition of material or state change of material being performed in an additive manufacturing process.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;For example, this could describe the portion of a piece of equipment that manages a material extrusion process or a vat polymerization process.&#10;
";

		/// <inheritdoc />
		public string Name => "Deposition";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.5";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572381970_785259_42204
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.AuxiliaryClass);

		/// <inheritdoc />
		public DepositionClassProperties Properties { get; } = new DepositionClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DepositionClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.AuxiliaryClass.AuxiliaryClassProperties" />.
		/// </summary>
		public class DepositionClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.AuxiliaryClass.AuxiliaryClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}