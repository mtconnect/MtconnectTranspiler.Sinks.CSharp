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
	/// <summary>﻿<see cref="SampleEnum.PATH_POSITION">SampleEnum.PATH_POSITION</see><br /><br /><br /><br /><br />Example<br /><br />~~~~xml<br />&lt;DataItem type='PATH_POSITION' id='pathposit1' units="MILLIMETER_3D"/&gt;<br />~~~~<br />{: caption="XML Device Model Example for <c>PathPosition</c> using <c>MILLIMETER_3D</c> unit"}<br /><br />~~~~xml<br />&lt;PathPosition&gt;10.0 0.0 20.0&lt;/PathPosition&gt;<br />~~~~<br />{: caption="XML Streams Response Example for <c>PathPosition</c> using <c>MILLIMETER_3D</c> unit"}<br /><br /><br />~~~~xml<br />&lt;DataItem type='PATH_POSITION' id='pathposit1' representation="DATA_SET"&gt;<br />  &lt;Definition&gt;<br />    &lt;EntryDefinition key='X' units='MILLIMETER'&gt;<br />    &lt;EntryDefinition key='Y' units='MILLIMETER'&gt;<br />    &lt;EntryDefinition key='Z' units='MILLIMETER'&gt;<br />  &lt;/Definition&gt;<br />&lt;/DataItem&gt;<br />~~~~<br />{: caption="XML Device Model Example for <c>PathPosition</c> to demonstrate multi-dimensional representation using <c>DataSet</c> representation"}<br /><br />~~~~xml<br />&lt;PathPositionDataSet id='pathposit1'&gt;<br />  &lt;Entry key='X'&gt;10.0&lt;/Entry&gt;<br />  &lt;Entry key='Z'&gt;20.0&lt;/Entry&gt;<br />&lt;/PathPositionDataSet&gt;<br />~~~~<br />{: caption="XML Streams Response Example for <c>PathPosition</c> to demonstrate multi-dimensional representation using <c>DataSet</c> representation"}<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580378218391_280410_2028">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PathPositionClass : IClass
	{
		/// <summary>Constant value for <see cref="PathPositionClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378218391_280410_2028";
		/// <summary>Constant value for <see cref="PathPositionClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580378218391_280410_2028";
		/// <summary>Constant value for <see cref="PathPositionClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{def(SampleEnum::PATH_POSITION)}}

&#10;
&#10;&#10;&#10;Example&#10;&#10;&#10;&#10;~~~~xml
<DataItem type='PATH_POSITION' id='pathposit1' units=""MILLIMETER_3D""/>
~~~~
{: caption=""XML Device Model Example for `PathPosition` using `MILLIMETER_3D` unit""}

~~~~xml
<PathPosition>10.0 0.0 20.0</PathPosition>
~~~~
{: caption=""XML Streams Response Example for `PathPosition` using `MILLIMETER_3D` unit""}


~~~~xml
<DataItem type='PATH_POSITION' id='pathposit1' representation=""DATA_SET"">
  <Definition>
    <EntryDefinition key='X' units='MILLIMETER'>
    <EntryDefinition key='Y' units='MILLIMETER'>
    <EntryDefinition key='Z' units='MILLIMETER'>
  </Definition>
</DataItem>
~~~~
{: caption=""XML Device Model Example for `PathPosition` to demonstrate multi-dimensional representation using `DataSet` representation""}

~~~~xml
<PathPositionDataSet id='pathposit1'>
  <Entry key='X'>10.0</Entry>
  <Entry key='Z'>20.0</Entry>
</PathPositionDataSet>
~~~~
{: caption=""XML Streams Response Example for `PathPosition` to demonstrate multi-dimensional representation using `DataSet` representation""}&#10;
";
		/// <summary>Constant value for <see cref="PathPositionClass.Name" /></summary>
		public const string NAME = "PathPosition";
		/// <summary>Constant value for <see cref="PathPositionClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="PathPositionClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="PathPositionClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="PathPositionClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1579566531116_175117_25733
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.SampleClass);

		/// <inheritdoc />
		public new PathPositionClassProperties Properties { get; } = new PathPositionClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="PathPositionClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.SampleClass.SampleClassProperties" />.
		/// </summary>
		public class PathPositionClassProperties : Mtconnect.ObservationInformationModel.SampleClass.SampleClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Units,
				Type,
				Result,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public new UnitsProperty Units { get; } = new UnitsProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class UnitsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UnitsProperty.Name" /></summary>
				public const string NAME = "units";
				/// <summary>Constant value for <see cref="UnitsProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="UnitsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UnitsProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="UnitsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="UnitsProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "MILLIMETER_3D";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UnitEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnumMetaClass);
				
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
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TypeProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "PATH_POSITION";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: SampleEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.SampleEnumMetaClass);
				
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
			/// <summary>
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public new ResultProperty Result { get; } = new ResultProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ResultProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ResultProperty.Name" /></summary>
				public const string NAME = "result";
				/// <summary>Constant value for <see cref="ResultProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ResultProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ResultProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ResultProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ResultProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ResultProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ResultProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ResultProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ResultProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Float[] </remarks>
				/// </summary>
				public System.Type Type => typeof(float[]);
				
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