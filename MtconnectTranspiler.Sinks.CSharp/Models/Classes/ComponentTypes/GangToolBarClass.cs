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
	/// <summary>﻿<see cref="ToolingDelivery">ToolingDelivery</see> composed of a tool mounting mechanism that holds any number of tools. <br /><br /><br />Description<br /><br />Tools are located in <see cref="Station">Station</see> entities. Tools are positioned for use in the manufacturing process by linearly positioning the <see cref="GangToolBar">GangToolBar</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605551885706_266977_2498">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class GangToolBarClass : IClass
	{
		/// <summary>Constant value for <see cref="GangToolBarClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605551885706_266977_2498";
		/// <summary>Constant value for <see cref="GangToolBarClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605551885706_266977_2498";
		/// <summary>Constant value for <see cref="GangToolBarClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(ToolingDelivery)}} composed of a tool mounting mechanism that holds any number of tools. &#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;Tools are located in {{block(Station)}} entities. Tools are positioned for use in the manufacturing process by linearly positioning the {{block(GangToolBar)}}.&#10;
";
		/// <summary>Constant value for <see cref="GangToolBarClass.Name" /></summary>
		public const string NAME = "GangToolBar";
		/// <summary>Constant value for <see cref="GangToolBarClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="GangToolBarClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="GangToolBarClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="GangToolBarClass.DeprecatedVersion" /></summary>
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
		public new GangToolBarClassProperties Properties { get; } = new GangToolBarClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="GangToolBarClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass.ToolingDeliveryClassProperties" />.
		/// </summary>
		public class GangToolBarClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass.ToolingDeliveryClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}