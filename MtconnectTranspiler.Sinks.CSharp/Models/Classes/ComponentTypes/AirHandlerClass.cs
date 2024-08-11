using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// system that circulates air or regulates airflow without altering temperature or humidity.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1696069278270_26061_1220">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AirHandlerClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1696069278270_26061_1220";
		
		/// <inheritdoc />
		public string Summary => @"/// system that circulates air or regulates airflow without altering temperature or humidity.";

		/// <inheritdoc />
		public string Name => "AirHandler";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572382020_336298_42297
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass);

		/// <inheritdoc />
		public AirHandlerClassProperties Properties { get; } = new AirHandlerClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class AirHandlerClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass.SystemClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}