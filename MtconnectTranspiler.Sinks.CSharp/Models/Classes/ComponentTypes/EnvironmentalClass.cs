using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component">Component</see> that observes the surroundings of another <see cref="Component">Component</see>.  > Note: <see cref="Environmental">Environmental</see> <b>SHOULD</b> be organized by <see cref="Auxillaries">Auxillaries</see>, <see cref="Systems">Systems</see> or <see cref="Parts">Parts</see> depending on the relationship to the <see cref="Component">Component</see>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381990_149427_42240">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class EnvironmentalClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381990_149427_42240";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> that observes the surroundings of another <see cref=""Component"">Component</see>.  > Note: <see cref=""Environmental"">Environmental</see> <b>SHOULD</b> be organized by <see cref=""Auxillaries"">Auxillaries</see>, <see cref=""Systems"">Systems</see> or <see cref=""Parts"">Parts</see> depending on the relationship to the <see cref=""Component"">Component</see>.";

		/// <inheritdoc />
		public string Name => "Environmental";
		
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
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public EnvironmentalClassProperties Properties { get; } = new EnvironmentalClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class EnvironmentalClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}