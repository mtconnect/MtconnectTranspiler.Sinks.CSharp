using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="Component">Component</see> composed of a mechanical mechanism or closure that can cover a physical access portal into a piece of equipment allowing or restricting access to other parts of the equipment.<br/><br />Description<br/>The closure can be opened or closed to allow or restrict access to other parts of the equipment.<br /><br /><see cref="Door">Door</see> <b>MUST</b> have <see cref="DoorState">DoorState</see> data item to indicate if the door is <c>OPEN</c>, <c>CLOSED</c>, or <c>UNLATCHED</c>. A <see cref="Component">Component</see> <b>MAY</b> contain multiple <see cref="Door">Door</see> entities.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381984_481596_42228">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DoorClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381984_481596_42228";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Component)}} composed of a mechanical mechanism or closure that can cover a physical access portal into a piece of equipment allowing or restricting access to other parts of the equipment.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;The closure can be opened or closed to allow or restrict access to other parts of the equipment.

{{block(Door)}} **MUST** have {{block(DoorState)}} data item to indicate if the door is `OPEN`, `CLOSED`, or `UNLATCHED`. A {{block(Component)}} **MAY** contain multiple {{block(Door)}} entities.&#10;
";

		/// <inheritdoc />
		public string Name => "Door";
		
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
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public DoorClassProperties Properties { get; } = new DoorClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DoorClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesDoorState,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ObservesDoorStateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesDoorState</remarks>
			/// </summary>
			public ObservesDoorStateProperty ObservesDoorState { get; } = new ObservesDoorStateProperty();
			public sealed class ObservesDoorStateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218284_523548_1767</item>
				/// <item>Type: DoorStateClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.DoorStateClass);
				
				/// <inheritdoc />
				public string Name => "observesDoorState";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}