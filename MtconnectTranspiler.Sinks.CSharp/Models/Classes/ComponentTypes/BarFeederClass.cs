#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="Loader">Loader</see> that delivers bar stock to a piece of equipment.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381973_701090_42210">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class BarFeederClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381973_701090_42210";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Loader)}} that delivers bar stock to a piece of equipment.&#10;
";

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
		public new BarFeederClassProperties Properties { get; } = new BarFeederClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="BarFeederClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.LoaderClass.LoaderClassProperties" />.
		/// </summary>
		public class BarFeederClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.LoaderClass.LoaderClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}