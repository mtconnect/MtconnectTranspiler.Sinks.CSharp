using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="ToolingDelivery">ToolingDelivery</see> composed of a tool mounting mechanism that holds any number of tools./// Description
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605551876111_523604_2450">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class TurretClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605551876111_523604_2450";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""ToolingDelivery"">ToolingDelivery</see> composed of a tool mounting mechanism that holds any number of tools./// Description";

		/// <inheritdoc />
		public string Name => "Turret";
		
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
		public TurretClassProperties Properties { get; } = new TurretClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class TurretClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.ToolingDeliveryClass.ToolingDeliveryClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}