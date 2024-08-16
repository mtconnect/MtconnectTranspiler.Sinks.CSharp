using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	﻿/// specific applications <b>MAY</b> reference one or more locations on a piece of bar stock as the indication for the <see cref="EndOfBar">EndOfBar</see>. <br /><br />The main or most important location <b>MUST</b> be designated as the <see cref="PRIMARY">PRIMARY</see> indication for the <see cref="EndOfBar">EndOfBar</see>.<br /><br />If no <see cref="subType">subType</see> is specified, <see cref="PRIMARY">PRIMARY</see> <b>MUST</b> be the default <see cref="EndOfBar">EndOfBar</see> indication.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580378218289_100730_1779">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EndOfBarPrimaryClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218289_100730_1779";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;specific applications **MAY** reference one or more locations on a piece of bar stock as the indication for the {{block(EndOfBar)}}. 

The main or most important location **MUST** be designated as the {{block(PRIMARY)}} indication for the {{block(EndOfBar)}}.

If no {{block(subType)}} is specified, {{block(PRIMARY)}} **MUST** be the default {{block(EndOfBar)}} indication.&#10;
";

		/// <inheritdoc />
		public string Name => "EndOfBar.Primary";
		
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
		/// Original Type: _19_0_3_45f01b9_1580378218288_775940_1776
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.EndOfBarClass);

		/// <inheritdoc />
		public EndOfBarPrimaryClassProperties Properties { get; } = new EndOfBarPrimaryClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class EndOfBarPrimaryClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.EndOfBarClass.EndOfBarClassProperties
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