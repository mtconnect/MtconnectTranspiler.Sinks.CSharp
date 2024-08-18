#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>﻿relating to momentary activation of a function or a movement.<br /><br /><b>DEPRECATION WARNING</b>: May be deprecated in the future.<br /><br /><br />Description<br /><br />When the <c>JOG</c> subtype of <c>AxisFeedrateOverride</c> is applied, the resulting commanded feedrate for the axis is limited to the value of the original <c>JOG</c> subtype of the <c>AxisFeedrate</c> multiplied by the value of the <c>JOG</c> subtype of<br /><c>AxisFeedrateOverride</c>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580378218199_242402_1584">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AxisFeedrateOverrideJogClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218199_242402_1584";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;relating to momentary activation of a function or a movement.

**DEPRECATION WARNING**: May be deprecated in the future.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;When the `JOG` subtype of `AxisFeedrateOverride` is applied, the resulting commanded feedrate for the axis is limited to the value of the original `JOG` subtype of the `AxisFeedrate` multiplied by the value of the `JOG` subtype of
`AxisFeedrateOverride`.&#10;
";

		/// <inheritdoc />
		public string Name => "AxisFeedrateOverride.Jog";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1580378218198_335017_1581
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.AxisFeedrateOverrideClass);

		/// <inheritdoc />
		public new AxisFeedrateOverrideJogClassProperties Properties { get; } = new AxisFeedrateOverrideJogClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AxisFeedrateOverrideJogClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.AxisFeedrateOverrideClass.AxisFeedrateOverrideClassProperties" />.
		/// </summary>
		public class AxisFeedrateOverrideJogClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.AxisFeedrateOverrideClass.AxisFeedrateOverrideClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				SubType,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public new SubTypeProperty SubType { get; } = new SubTypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class SubTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579563592155_977172_22064</item>
				/// <item>Type: DataItemSubTypeEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "subType";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}