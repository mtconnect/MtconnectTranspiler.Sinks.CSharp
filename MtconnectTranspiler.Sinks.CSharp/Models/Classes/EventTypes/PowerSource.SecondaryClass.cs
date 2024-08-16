using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	﻿/// <see cref="EventEnum.POWER_SOURCE">EventEnum.POWER_SOURCE</see> that is <see cref="DataItemSubTypeEnum.SECONDARY">DataItemSubTypeEnum.SECONDARY</see><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1696872166479_807394_3679">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PowerSourceSecondaryClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1696872166479_807394_3679";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{def(EventEnum::POWER_SOURCE)}} that is {{def(DataItemSubTypeEnum::SECONDARY)}}&#10;
";

		/// <inheritdoc />
		public string Name => "PowerSource.Secondary";
		
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
		public PowerSourceSecondaryClassProperties Properties { get; } = new PowerSourceSecondaryClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class PowerSourceSecondaryClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PowerSourceClass.PowerSourceClassProperties
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
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "SECONDARY";
			}
		};

	}
}