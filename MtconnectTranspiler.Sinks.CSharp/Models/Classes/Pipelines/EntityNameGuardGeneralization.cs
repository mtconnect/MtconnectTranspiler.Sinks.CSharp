#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AgentArchitecture.Pipelines
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1674414438419_20936_3728">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EntityNameGuardGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1674414438419_20936_3728";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "EntityNameGuard";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_4_45f01b9_1674414211400_186233_3570
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AgentArchitecture.Pipelines.GuardClass);

		/// <inheritdoc />
		public new EntityNameGuardGeneralizationProperties Properties { get; } = new EntityNameGuardGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="EntityNameGuardGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AgentArchitecture.Pipelines.GuardClass.GuardClassProperties" />.
		/// </summary>
		public class EntityNameGuardGeneralizationProperties : Mtconnect.AgentArchitecture.Pipelines.GuardClass.GuardClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				Name,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public new NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class NameProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "name";
				
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