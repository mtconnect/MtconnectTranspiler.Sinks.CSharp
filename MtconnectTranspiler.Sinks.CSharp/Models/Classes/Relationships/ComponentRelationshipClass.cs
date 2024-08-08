using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.Relationships
{
	/// <summary>
	/// <see cref="ConfigurationRelationship">ConfigurationRelationship</see> that describes the association between two components within a piece of equipment that function independently but together perform a capability or service within a piece of equipment.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ComponentRelationshipClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_2D0A9D8F_2538_4f46_8B83_6B1988818511";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between two components within a piece of equipment that function independently but together perform a capability or service within a piece of equipment.";

		/// <inheritdoc />
		public string Name => "ComponentRelationshipClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.5";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_28132294_DF39_4e8e_8AE5_B79565F991A2";

		/// <inheritdoc />
		public ComponentRelationshipClassProperties Properties { get; } = new ComponentRelationshipClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ComponentRelationshipClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IdRef,
			};
			/// <summary>
			/// <inheritdoc cref="IdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IdRef</remarks>
			/// </summary>
			public IdRefProperty IdRef { get; } = new IdRefProperty();
			/// <summary>
			/// reference to the associated <see cref="Component">Component</see>.
			/// </summary>
			public sealed class IdRefProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "IdRef";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between two components within a piece of equipment that function independently but together perform a capability or service within a piece of equipment.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.5";
				
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
		};

	}
}