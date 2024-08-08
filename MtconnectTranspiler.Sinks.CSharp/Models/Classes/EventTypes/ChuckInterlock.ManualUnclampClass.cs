using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.  When <see cref="ChuckInterlockManualUnclamp">ChuckInterlockManualUnclamp</see> is <c>ACTIVE</c>, it is expected that a chuck cannot be unclamped until <see cref="ChuckInterlockManualUnclamp">ChuckInterlockManualUnclamp</see> is set to <c>INACTIVE</c>. 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ChuckInterlockManualUnclampClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218214_457994_1614";
		
		/// <inheritdoc />
		public string Summary => @"/// indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.  When <see cref=""ChuckInterlockManualUnclamp"">ChuckInterlockManualUnclamp</see> is <c>ACTIVE</c>, it is expected that a chuck cannot be unclamped until <see cref=""ChuckInterlockManualUnclamp"">ChuckInterlockManualUnclamp</see> is set to <c>INACTIVE</c>. ";

		/// <inheritdoc />
		public string Name => "ChuckInterlock.ManualUnclampClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1580378218212_381005_1611";

		/// <inheritdoc />
		public ChuckInterlockManualUnclampClassProperties Properties { get; } = new ChuckInterlockManualUnclampClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ChuckInterlockManualUnclampClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				SubType,
			};
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
				public string Name => "SubType";
				
				/// <inheritdoc />
				public string Summary => @"/// indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.  When <see cref=""ChuckInterlockManualUnclamp"">ChuckInterlockManualUnclamp</see> is <c>ACTIVE</c>, it is expected that a chuck cannot be unclamped until <see cref=""ChuckInterlockManualUnclamp"">ChuckInterlockManualUnclamp</see> is set to <c>INACTIVE</c>. ";

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