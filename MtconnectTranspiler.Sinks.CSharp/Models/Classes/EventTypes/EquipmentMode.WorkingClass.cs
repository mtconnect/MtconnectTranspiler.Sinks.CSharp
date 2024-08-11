using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// indication that a piece of equipment is performing any activity, the equipment is active and performing a function under load or not.  Example: For traditional machine tools, this includes when the piece of equipment is <c>LOADED</c>, making rapid moves, executing a tool change, etc.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580378218294_549129_1791">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class EquipmentModeWorkingClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218294_549129_1791";
		
		/// <inheritdoc />
		public string Summary => @"/// indication that a piece of equipment is performing any activity, the equipment is active and performing a function under load or not.  Example: For traditional machine tools, this includes when the piece of equipment is <c>LOADED</c>, making rapid moves, executing a tool change, etc.";

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
		public EquipmentModeWorkingClassProperties Properties { get; } = new EquipmentModeWorkingClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class EquipmentModeWorkingClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.EquipmentModeClass.EquipmentModeClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				SubType,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			public sealed class SubTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579563592155_977172_22064</item>
				/// <item>Type: DataItemSubTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnum);
				
				/// <inheritdoc />
				public string Name => "subType";
				
				/// <inheritdoc />
				public string Summary => @"/// indication that a piece of equipment is performing any activity, the equipment is active and performing a function under load or not.  Example: For traditional machine tools, this includes when the piece of equipment is <c>LOADED</c>, making rapid moves, executing a tool change, etc.";

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