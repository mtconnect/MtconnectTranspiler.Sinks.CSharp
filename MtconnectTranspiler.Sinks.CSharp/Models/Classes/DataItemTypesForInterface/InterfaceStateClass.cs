using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.InterfaceInteractionModel.DataItemTypesForInterface
{
	/// <summary>
	/// <see cref="InterfaceEventEnum::INTERFACE_STATE">InterfaceEventEnum::INTERFACE_STATE</see>  When the <see cref="InterfaceState">InterfaceState</see> is <c>DISABLED</c>, the state of all data items that are specific for the <i>interaction model</i> associated with that <see cref="Interface">Interface</see> <b>MUST</b> be set to <c>NOT_READY</c>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class InterfaceStateClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218325_627294_1860";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""InterfaceEventEnum::INTERFACE_STATE"">InterfaceEventEnum::INTERFACE_STATE</see>  When the <see cref=""InterfaceState"">InterfaceState</see> is <c>DISABLED</c>, the state of all data items that are specific for the <i>interaction model</i> associated with that <see cref=""Interface"">Interface</see> <b>MUST</b> be set to <c>NOT_READY</c>.";

		/// <inheritdoc />
		public string Name => "InterfaceStateClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579566531115_47447_25730";

		/// <inheritdoc />
		public InterfaceStateClassProperties Properties { get; } = new InterfaceStateClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class InterfaceStateClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Type,
				Result,
			};
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1646992208875_933134_35</item>
				/// <item>Type: InterfaceEventEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.InterfaceEventEnum);
				
				/// <inheritdoc />
				public string Name => "Type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""InterfaceEventEnum::INTERFACE_STATE"">InterfaceEventEnum::INTERFACE_STATE</see>  When the <see cref=""InterfaceState"">InterfaceState</see> is <c>DISABLED</c>, the state of all data items that are specific for the <i>interaction model</i> associated with that <see cref=""Interface"">Interface</see> <b>MUST</b> be set to <c>NOT_READY</c>.";

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
			/// <summary>
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public ResultProperty Result { get; } = new ResultProperty();
			public sealed class ResultProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378417666_27713_2880</item>
				/// <item>Type: InterfaceStateEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.InterfaceStateEnum);
				
				/// <inheritdoc />
				public string Name => "Result";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""InterfaceEventEnum::INTERFACE_STATE"">InterfaceEventEnum::INTERFACE_STATE</see>  When the <see cref=""InterfaceState"">InterfaceState</see> is <c>DISABLED</c>, the state of all data items that are specific for the <i>interaction model</i> associated with that <see cref=""Interface"">Interface</see> <b>MUST</b> be set to <c>NOT_READY</c>.";

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