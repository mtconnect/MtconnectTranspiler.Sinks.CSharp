using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// <see cref="EventEnum::POWER_SOURCE">EventEnum::POWER_SOURCE</see> that is <see cref="DataItemSubTypeEnum::PRIMARY">DataItemSubTypeEnum::PRIMARY</see>
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1696872166479_321396_3680">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PowerSourcePrimaryClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1696872166479_321396_3680";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""EventEnum::POWER_SOURCE"">EventEnum::POWER_SOURCE</see> that is <see cref=""DataItemSubTypeEnum::PRIMARY"">DataItemSubTypeEnum::PRIMARY</see>";

		/// <inheritdoc />
		public string Name => "PowerSource.Primary";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1696872166478_3528_3677
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PowerSourceClass);

		/// <inheritdoc />
		public PowerSourcePrimaryClassProperties Properties { get; } = new PowerSourcePrimaryClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class PowerSourcePrimaryClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PowerSourceClass.PowerSourceClassProperties
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
				public string Summary => @"/// <see cref=""EventEnum::POWER_SOURCE"">EventEnum::POWER_SOURCE</see> that is <see cref=""DataItemSubTypeEnum::PRIMARY"">DataItemSubTypeEnum::PRIMARY</see>";

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
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "PRIMARY";
			}
		};

	}
}