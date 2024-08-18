#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes
{
	/// <summary>﻿directive value including adjustments such as an offset or overrides.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_91b028d_1587734767823_577271_464">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class VoltageACCommandedClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1587734767823_577271_464";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;directive value including adjustments such as an offset or overrides.&#10;
";

		/// <inheritdoc />
		public string Name => "VoltageAC.Commanded";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.6";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_91b028d_1587734767819_726864_461
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.VoltageACClass);

		/// <inheritdoc />
		public new VoltageACCommandedClassProperties Properties { get; } = new VoltageACCommandedClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="VoltageACCommandedClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.VoltageACClass.VoltageACClassProperties" />.
		/// </summary>
		public class VoltageACCommandedClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.VoltageACClass.VoltageACClassProperties
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
				public string DefaultValue => "COMMANDED";
			}
		};

	}
}