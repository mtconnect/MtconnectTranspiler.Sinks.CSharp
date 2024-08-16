using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="Auxiliary">Auxiliary</see> that manages, positions, stores, and delivers tooling within a piece of equipment.<br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382021_741508_42300">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ToolingDeliveryClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382021_741508_42300";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Auxiliary)}} that manages, positions, stores, and delivers tooling within a piece of equipment.
&#10;
";

		/// <inheritdoc />
		public string Name => "ToolingDelivery";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572381970_785259_42204
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.AuxiliaryClass);

		/// <inheritdoc />
		public ToolingDeliveryClassProperties Properties { get; } = new ToolingDeliveryClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ToolingDeliveryClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.AuxiliaryClass.AuxiliaryClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}