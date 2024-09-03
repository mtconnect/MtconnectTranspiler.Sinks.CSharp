#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="ToolingDelivery">ToolingDelivery</see> composed of a tool delivery mechanism that moves tools between a <see cref="ToolMagazine">ToolMagazine</see> and a <i>spindle</i> a <see cref="Turret">Turret</see>.<br /><br /><br />Description<br /><br /><see cref="AutomaticToolChanger">AutomaticToolChanger</see> may also transfer tools between a location outside of a piece of equipment and a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605551853978_27109_2354">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AutomaticToolChangerClass : IClass
	{
		/// <summary>Constant value for <see cref="AutomaticToolChangerClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605551853978_27109_2354";
		/// <summary>Constant value for <see cref="AutomaticToolChangerClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605551853978_27109_2354";
		/// <summary>Constant value for <see cref="AutomaticToolChangerClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(ToolingDelivery)}} composed of a tool delivery mechanism that moves tools between a {{block(ToolMagazine)}} and a {{term(spindle)}} a {{block(Turret)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(AutomaticToolChanger)}} may also transfer tools between a location outside of a piece of equipment and a {{block(ToolMagazine)}} or {{block(Turret)}}.&#10;
";
		/// <summary>Constant value for <see cref="AutomaticToolChangerClass.Name" /></summary>
		public const string NAME = "AutomaticToolChanger";
		/// <summary>Constant value for <see cref="AutomaticToolChangerClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="AutomaticToolChangerClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="AutomaticToolChangerClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="AutomaticToolChangerClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572382021_741508_42300
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass);

		/// <inheritdoc />
		public new AutomaticToolChangerClassProperties Properties { get; } = new AutomaticToolChangerClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AutomaticToolChangerClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass.ToolingDeliveryClassProperties" />.
		/// </summary>
		public class AutomaticToolChangerClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass.ToolingDeliveryClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}