using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="ToolingDelivery">ToolingDelivery</see> composed of a tool mounting mechanism that holds any number of tools. <br/><br />Description<br/>Tools are located in <see cref="Station">Station</see> entities. Tools are positioned for use in the manufacturing process by linearly positioning the <see cref="GangToolBar">GangToolBar</see>.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605551885706_266977_2498">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class GangToolBarClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605551885706_266977_2498";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(ToolingDelivery)}} composed of a tool mounting mechanism that holds any number of tools. &#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;Tools are located in {{block(Station)}} entities. Tools are positioned for use in the manufacturing process by linearly positioning the {{block(GangToolBar)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "GangToolBar";
		
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
		public GangToolBarClassProperties Properties { get; } = new GangToolBarClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class GangToolBarClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass.ToolingDeliveryClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}