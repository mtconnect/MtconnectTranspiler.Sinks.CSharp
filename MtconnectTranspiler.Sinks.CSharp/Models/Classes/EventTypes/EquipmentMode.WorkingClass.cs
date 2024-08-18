#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>﻿indication that a piece of equipment is performing any activity, the equipment is active and performing a function under load or not.<br /><br />Example: For traditional machine tools, this includes when the piece of equipment is <c>LOADED</c>, making rapid moves, executing a tool change, etc.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580378218294_549129_1791">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EquipmentModeWorkingClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218294_549129_1791";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;indication that a piece of equipment is performing any activity, the equipment is active and performing a function under load or not.

Example: For traditional machine tools, this includes when the piece of equipment is `LOADED`, making rapid moves, executing a tool change, etc.&#10;
";

		/// <inheritdoc />
		public string Name => "EquipmentMode.Working";
		
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
		/// Original Type: _19_0_3_45f01b9_1580378218291_180049_1785
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.EquipmentModeClass);

		/// <inheritdoc />
		public new EquipmentModeWorkingClassProperties Properties { get; } = new EquipmentModeWorkingClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="EquipmentModeWorkingClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.EquipmentModeClass.EquipmentModeClassProperties" />.
		/// </summary>
		public class EquipmentModeWorkingClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.EquipmentModeClass.EquipmentModeClassProperties
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