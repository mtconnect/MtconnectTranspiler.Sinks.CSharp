using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="Structure">Structure</see> that provides a connection between <see cref="Component">Component</see> entities.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1587597430378_591532_1084">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class LinkClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1587597430378_591532_1084";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Structure)}} that provides a connection between {{block(Component)}} entities.&#10;
";

		/// <inheritdoc />
		public string Name => "Link";
		
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
		/// Original Type: _19_0_3_45f01b9_1587597358521_716746_1028
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.StructureClass);

		/// <inheritdoc />
		public LinkClassProperties Properties { get; } = new LinkClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class LinkClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.StructureClass.StructureClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}