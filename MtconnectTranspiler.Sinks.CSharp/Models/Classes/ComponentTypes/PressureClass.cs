#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="System">System</see> that delivers compressed gas or fluid and controls the pressure and rate of pressure change to a desired target set-point.<br /><br /><br />Description<br /><br />&gt; Note: For example, Delivery Method can be a Compressed Air or N2 tank that is piped via an inlet valve to the chamber.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605117029255_781563_1842">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PressureClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605117029255_781563_1842";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(System)}} that delivers compressed gas or fluid and controls the pressure and rate of pressure change to a desired target set-point.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;> Note: For example, Delivery Method can be a Compressed Air or N2 tank that is piped via an inlet valve to the chamber.&#10;
";

		/// <inheritdoc />
		public string Name => "Pressure";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572382020_336298_42297
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass);

		/// <inheritdoc />
		public new PressureClassProperties Properties { get; } = new PressureClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="PressureClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass.SystemClassProperties" />.
		/// </summary>
		public class PressureClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass.SystemClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}