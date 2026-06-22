#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingItem
{
	/// <summary>﻿<see cref="CuttingItems">CuttingItems</see> groups one or more <see cref="CuttingItem">CuttingItem</see> entities. See <see cref="CuttingItem">CuttingItem</see> and <see cref="Cutting Item">Cutting Item</see> for more detail.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_657167D1_2EA5_4095_88EC_49E69674A734">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class CuttingItemsClass : IClass
	{
		/// <summary>Constant value for <see cref="CuttingItemsClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_657167D1_2EA5_4095_88EC_49E69674A734";
		/// <summary>Constant value for <see cref="CuttingItemsClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_657167D1_2EA5_4095_88EC_49E69674A734";
		/// <summary>Constant value for <see cref="CuttingItemsClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(CuttingItems)}} groups one or more {{block(CuttingItem)}} entities. See {{sect(CuttingItem)}} and {{package(Cutting Item)}} for more detail.&#10;
";
		/// <summary>Constant value for <see cref="CuttingItemsClass.Name" /></summary>
		public const string NAME = "CuttingItems";
		/// <summary>Constant value for <see cref="CuttingItemsClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="CuttingItemsClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="CuttingItemsClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="CuttingItemsClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new CuttingItemsClassProperties Properties { get; } = new CuttingItemsClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CuttingItemsClass" />.
		/// </summary>
		public class CuttingItemsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Count,
			};
			/// <summary>
			/// <inheritdoc cref="CountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Count</remarks>
			/// </summary>
			public CountProperty Count { get; } = new CountProperty();
			
			/// <summary>﻿number of <see cref="CuttingItem">CuttingItem</see> organized by <see cref="CuttingItems">CuttingItems</see>.<br /><br /><br />
			/// </summary>
			public sealed class CountProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CountProperty.Name" /></summary>
				public const string NAME = "count";
				/// <summary>Constant value for <see cref="CountProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;number of {{block(CuttingItem)}} organized by {{block(CuttingItems)}}.&#10;
";
				/// <summary>Constant value for <see cref="CountProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CountProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CountProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="CountProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CountProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CountProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x;MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="CountProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CountProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="CountProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Int32 </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="CuttingItemsClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
