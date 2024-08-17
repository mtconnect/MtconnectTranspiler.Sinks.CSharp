#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes
{
	/// <summary>﻿<see cref="SampleEnum.PATH_POSITION">SampleEnum.PATH_POSITION</see><br /><br /><br /><br /><br />Example<br /><br />~~~~xml<br />&lt;DataItem type='PATH_POSITION' id='pathposit1' units="MILLIMETER_3D"/&gt;<br />~~~~<br />{: caption="XML Device Model Example for <c>PathPosition</c> using <c>MILLIMETER_3D</c> unit"}<br /><br />~~~~xml<br />&lt;PathPosition&gt;10.0 0.0 20.0&lt;/PathPosition&gt;<br />~~~~<br />{: caption="XML Streams Response Example for <c>PathPosition</c> using <c>MILLIMETER_3D</c> unit"}<br /><br /><br />~~~~xml<br />&lt;DataItem type='PATH_POSITION' id='pathposit1' representation="DATA_SET"&gt;<br />  &lt;Definition&gt;<br />    &lt;EntryDefinition key='X' units='MILLIMETER'&gt;<br />    &lt;EntryDefinition key='Y' units='MILLIMETER'&gt;<br />    &lt;EntryDefinition key='Z' units='MILLIMETER'&gt;<br />  &lt;/Definition&gt;<br />&lt;/DataItem&gt;<br />~~~~<br />{: caption="XML Device Model Example for <c>PathPosition</c> to demonstrate multi-dimensional representation using <c>DataSet</c> representation"}<br /><br />~~~~xml<br />&lt;PathPositionDataSet id='pathposit1'&gt;<br />  &lt;Entry key='X'&gt;10.0&lt;/Entry&gt;<br />  &lt;Entry key='Z'&gt;20.0&lt;/Entry&gt;<br />&lt;/PathPositionDataSet&gt;<br />~~~~<br />{: caption="XML Streams Response Example for <c>PathPosition</c> to demonstrate multi-dimensional representation using <c>DataSet</c> representation"}<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580378218391_280410_2028">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PathPositionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218391_280410_2028";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{def(SampleEnum::PATH_POSITION)}}

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

		/// <inheritdoc />
		public string Name => "PathPosition";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579566531116_175117_25733
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.SampleClass);

		/// <inheritdoc />
		public PathPositionClassProperties Properties { get; } = new PathPositionClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="PathPositionClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.SampleClass.SampleClassProperties" />.
		/// </summary>
		public class PathPositionClassProperties : Mtconnect.ObservationInformationModel.SampleClass.SampleClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A</item>
				/// <item>Type: UnitEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "units";
				
				/// <inheritdoc />
				public string Summary => @"";

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
				public string DefaultValue => "MILLIMETER_3D";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580398370126_672808_12777</item>
				/// <item>Type: SampleEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.SampleEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"";

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
				public string DefaultValue => "PATH_POSITION";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1696078816660_574434_2106</item>
				/// <item>Type: Float[]</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(float[]);
				
				/// <inheritdoc />
				public string Name => "result";
				
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