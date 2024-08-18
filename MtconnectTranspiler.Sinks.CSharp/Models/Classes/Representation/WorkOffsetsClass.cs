#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG.Representation
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1634045367649_547336_746">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class WorkOffsetsClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1634045367649_547336_746";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "WorkOffsets";
		
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
		/// Original Type: _19_0_3_45f01b9_1579566531115_47447_25730
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.EventClass);

		/// <inheritdoc />
		public new WorkOffsetsClassProperties Properties { get; } = new WorkOffsetsClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="WorkOffsetsClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.EventClass.EventClassProperties" />.
		/// </summary>
		public class WorkOffsetsClassProperties : Mtconnect.ObservationInformationModel.EventClass.EventClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				Count,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="CountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Count</remarks>
			/// </summary>
			public new CountProperty Count { get; } = new CountProperty();
			
			/// <summary>﻿number of <see cref="Entry">Entry</see> elements for the <see cref="Observation">Observation</see>.<br /><br /><br />
			/// </summary>
			public new sealed class CountProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272271512_537408_674</item>
				/// <item>Type: Int32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => "count";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;number of {{block(Entry)}} elements for the {{block(Observation)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
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