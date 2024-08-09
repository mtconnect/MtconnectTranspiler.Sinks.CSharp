using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Loader">Loader</see> that delivers bar stock to a piece of equipment.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381973_701090_42210">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class BarFeederClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381973_701090_42210";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Loader"">Loader</see> that delivers bar stock to a piece of equipment.";

		/// <inheritdoc />
		public string Name => "BarFeeder";
		
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
		/// Original Type: _19_0_3_45f01b9_1579572381999_206845_42258
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.LoaderClass);

		/// <inheritdoc />
		public BarFeederClassProperties Properties { get; } = new BarFeederClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class BarFeederClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.LoaderClass.LoaderClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}