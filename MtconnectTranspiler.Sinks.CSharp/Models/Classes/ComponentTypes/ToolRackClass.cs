#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="ToolingDelivery">ToolingDelivery</see> composed of a linear or matrixed tool storage mechanism that holds any number of tools.<br /><br /><br />Description<br /><br />Tools are located in <see cref="Station">Station</see> entities.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605551899241_174607_2546">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ToolRackClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605551899241_174607_2546";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(ToolingDelivery)}} composed of a linear or matrixed tool storage mechanism that holds any number of tools.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;Tools are located in {{block(Station)}} entities.&#10;
";

		/// <inheritdoc />
		public string Name => "ToolRack";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572382021_741508_42300
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass);

		/// <inheritdoc />
		public new ToolRackClassProperties Properties { get; } = new ToolRackClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ToolRackClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass.ToolingDeliveryClassProperties" />.
		/// </summary>
		public class ToolRackClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass.ToolingDeliveryClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}