using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;
// using Mtconnect.InterfaceInteractionModel.DataItemTypesForInterface;

namespace Mtconnect.InterfaceInteractionModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class InterfaceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381996_964170_42252";
		
		/// <inheritdoc />
		public string Name => "InterfaceClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";

		/// <inheritdoc />
		public InterfaceClassProperties Properties { get; } = new InterfaceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class InterfaceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IsInterfaceOfPart,
				ObservesInterfaceState,
			};
			/// <remarks>Original Name: IsInterfaceOf</remarks>
			public IsInterfaceOfPartProperty IsInterfaceOfPart { get; } = new IsInterfaceOfPartProperty();
			public sealed class IsInterfaceOfPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620240839406_285612_1596</item>
				/// <item>Type: DeviceClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.DeviceClass);
				
				/// <inheritdoc />
				public string Name => "IsInterfaceOf";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "InterfacesClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesInterfaceState</remarks>
			public ObservesInterfaceStateProperty ObservesInterfaceState { get; } = new ObservesInterfaceStateProperty();
			public sealed class ObservesInterfaceStateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218325_627294_1860</item>
				/// <item>Type: InterfaceStateClass</item>
				/// <item>Namespace: Mtconnect.InterfaceInteractionModel.DataItemTypesForInterface</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.DataItemTypesForInterface.InterfaceStateClass);
				
				/// <inheritdoc />
				public string Name => "ObservesInterfaceState";
				
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

				// TODO: Add Summary
			}
		};

	}
}