using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="ToolingDelivery">ToolingDelivery</see> composed of a tool delivery mechanism that moves tools between a <see cref="ToolMagazine">ToolMagazine</see> and a <i>spindle</i> a <see cref="Turret">Turret</see>.<br/><br />Description<br/><see cref="AutomaticToolChanger">AutomaticToolChanger</see> may also transfer tools between a location outside of a piece of equipment and a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see>.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605551853978_27109_2354">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AutomaticToolChangerClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605551853978_27109_2354";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(ToolingDelivery)}} composed of a tool delivery mechanism that moves tools between a {{block(ToolMagazine)}} and a {{term(spindle)}} a {{block(Turret)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(AutomaticToolChanger)}} may also transfer tools between a location outside of a piece of equipment and a {{block(ToolMagazine)}} or {{block(Turret)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "AutomaticToolChanger";
		
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
		public AutomaticToolChangerClassProperties Properties { get; } = new AutomaticToolChangerClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class AutomaticToolChangerClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass.ToolingDeliveryClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}