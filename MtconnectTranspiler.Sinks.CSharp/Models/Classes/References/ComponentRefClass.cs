using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DeviceInformationModel.Components;

namespace Mtconnect.DeviceInformationModel.References
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ComponentRefClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581212139957_418083_223";
		
		/// <inheritdoc />
		public string Name => "ComponentRefClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_25A13743_B12C_4c6c_B1DA_8E2EFDD156EF";

		/// <inheritdoc />
		public ComponentRefClassProperties Properties { get; } = new ComponentRefClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ComponentRefClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IdRef,
			};
			/// <remarks>Original Name: IdRef</remarks>
			public IdRefProperty IdRef { get; } = new IdRefProperty();
			public sealed class IdRefProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779</item>
				/// <item>Type: ComponentGeneralization</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);
				
				/// <inheritdoc />
				public string Name => "IdRef";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.4";
				
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

				// TODO: Add Summary
			}
		};

	}
}