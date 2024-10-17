#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>﻿<see cref="FilterEnum.MINIMUM_DELTA">FilterEnum.MINIMUM_DELTA</see><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1644604760483_617184_91">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MinimumDeltaFilterGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="MinimumDeltaFilterGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_4_45f01b9_1644604760483_617184_91";
		/// <summary>Constant value for <see cref="MinimumDeltaFilterGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1644604760483_617184_91";
		/// <summary>Constant value for <see cref="MinimumDeltaFilterGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{def(FilterEnum::MINIMUM_DELTA)}}&#10;
";
		/// <summary>Constant value for <see cref="MinimumDeltaFilterGeneralization.Name" /></summary>
		public const string NAME = "MinimumDeltaFilter";
		/// <summary>Constant value for <see cref="MinimumDeltaFilterGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MinimumDeltaFilterGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MinimumDeltaFilterGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="MinimumDeltaFilterGeneralization.DeprecatedVersion" /></summary>
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
		/// <remarks>
		/// Original Type: EAID_8A5219C3_747D_4904_A58A_A312D13DAEE9
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.FilterClass);

		/// <inheritdoc />
		public new MinimumDeltaFilterGeneralizationProperties Properties { get; } = new MinimumDeltaFilterGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MinimumDeltaFilterGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.FilterClass.FilterClassProperties" />.
		/// </summary>
		public class MinimumDeltaFilterGeneralizationProperties : Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.FilterClass.FilterClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Type,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public new TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TypeProperty.Name" /></summary>
				public const string NAME = "type";
				/// <summary>Constant value for <see cref="TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.3";
				/// <summary>Constant value for <see cref="TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "MINIMUM_DELTA";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: FilterEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.FilterEnumMetaClass);
				
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
			}
		};

	}
}