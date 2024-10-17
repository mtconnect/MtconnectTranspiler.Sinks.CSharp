#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes
{
	/// <summary>﻿<see cref="SampleEnum.FILL_HEIGHT">SampleEnum.FILL_HEIGHT</see> that is <see cref="DataItemSubTypeEnum.TARGET">DataItemSubTypeEnum.TARGET</see><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1727727492981_273533_24209">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FillHeightTargetClass : IClass
	{
		/// <summary>Constant value for <see cref="FillHeightTargetClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727727492981_273533_24209";
		/// <summary>Constant value for <see cref="FillHeightTargetClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1727727492981_273533_24209";
		/// <summary>Constant value for <see cref="FillHeightTargetClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{def(SampleEnum::FILL_HEIGHT)}} that is {{def(DataItemSubTypeEnum::TARGET)}}&#10;
";
		/// <summary>Constant value for <see cref="FillHeightTargetClass.Name" /></summary>
		public const string NAME = "FillHeight.Target";
		/// <summary>Constant value for <see cref="FillHeightTargetClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="FillHeightTargetClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="FillHeightTargetClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.5";
		/// <summary>Constant value for <see cref="FillHeightTargetClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _2024x_68e0225_1727727492980_335553_24207
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.FillHeightClass);

		/// <inheritdoc />
		public new FillHeightTargetClassProperties Properties { get; } = new FillHeightTargetClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="FillHeightTargetClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.FillHeightClass.FillHeightClassProperties" />.
		/// </summary>
		public class FillHeightTargetClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.FillHeightClass.FillHeightClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				SubType,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public new SubTypeProperty SubType { get; } = new SubTypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class SubTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SubTypeProperty.Name" /></summary>
				public const string NAME = "subType";
				/// <summary>Constant value for <see cref="SubTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="SubTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SubTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="SubTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="SubTypeProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "TARGET";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DataItemSubTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnumMetaClass);
				
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