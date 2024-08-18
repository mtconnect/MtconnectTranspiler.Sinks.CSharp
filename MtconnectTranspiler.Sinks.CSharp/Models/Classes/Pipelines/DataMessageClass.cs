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
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1674411368052_853509_3280">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DataMessageClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1674411368052_853509_3280";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "DataMessage";
		
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
		/// Original Type: _19_0_4_45f01b9_1674410939127_88235_2773
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AgentArchitecture.Pipelines.PipelineMessageClass);

		/// <inheritdoc />
		public new DataMessageClassProperties Properties { get; } = new DataMessageClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DataMessageClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AgentArchitecture.Pipelines.PipelineMessageClass.PipelineMessageClassProperties" />.
		/// </summary>
		public class DataMessageClassProperties : Mtconnect.AgentArchitecture.Pipelines.PipelineMessageClass.PipelineMessageClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}