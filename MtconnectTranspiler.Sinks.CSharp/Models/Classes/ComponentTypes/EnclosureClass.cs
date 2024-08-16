using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="System">System</see> composed of a structure that is used to contain or isolate a piece of equipment or area.<br/><br />Description<br/><see cref="Enclosure">Enclosure</see> may provide information regarding access to the internal components of a piece of equipment or the conditions within the enclosure. For example, <see cref="Door">Door</see> may be defined as a <i>lower level</i> <see cref="Component">Component</see> or <see cref="Composition">Composition</see> entity of the <see cref="Enclosure">Enclosure</see>.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381987_89386_42234">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EnclosureClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381987_89386_42234";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(System)}} composed of a structure that is used to contain or isolate a piece of equipment or area.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(Enclosure)}} may provide information regarding access to the internal components of a piece of equipment or the conditions within the enclosure. For example, {{block(Door)}} may be defined as a {{term(lower level)}} {{block(Component)}} or {{block(Composition)}} entity of the {{block(Enclosure)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Enclosure";
		
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
		/// Original Type: _19_0_3_45f01b9_1579572382020_336298_42297
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass);

		/// <inheritdoc />
		public EnclosureClassProperties Properties { get; } = new EnclosureClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class EnclosureClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass.SystemClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}