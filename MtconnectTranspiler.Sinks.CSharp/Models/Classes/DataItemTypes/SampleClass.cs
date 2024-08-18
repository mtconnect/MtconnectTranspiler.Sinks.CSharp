#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.DataItems.DataItemTypes
{
	/// <summary>﻿abstract <see cref="DataItem">DataItem</see> that is continuously changing or analog data value.<br /><br /><br /><br />Description<br /><br />This data can be measured at any point-in-time and will always produce a result.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_B0781166_9F74_4844_B40C_CA32663868F2">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SampleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_B0781166_9F74_4844_B40C_CA32663868F2";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;abstract {{block(DataItem)}} that is continuously changing or analog data value.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;This data can be measured at any point-in-time and will always produce a result.&#10;
";

		/// <inheritdoc />
		public string Name => "Sample";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.DataItems.DataItemClass);

		/// <inheritdoc />
		public new SampleClassProperties Properties { get; } = new SampleClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="SampleClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.DataItems.DataItemClass.DataItemClassProperties" />.
		/// </summary>
		public class SampleClassProperties : Mtconnect.DeviceInformationModel.DataItems.DataItemClass.DataItemClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				Category,
				Type,
				Units,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="CategoryProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Category</remarks>
			/// </summary>
			public new CategoryProperty Category { get; } = new CategoryProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class CategoryProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579277872728_249968_3735</item>
				/// <item>Type: CategoryEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CategoryEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "category";
				
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
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public new TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580398370126_672808_12777</item>
				/// <item>Type: SampleEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.SampleEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "type";
				
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
			/// <summary>
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public new UnitsProperty Units { get; } = new UnitsProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class UnitsProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A</item>
				/// <item>Type: UnitEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "units";
				
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