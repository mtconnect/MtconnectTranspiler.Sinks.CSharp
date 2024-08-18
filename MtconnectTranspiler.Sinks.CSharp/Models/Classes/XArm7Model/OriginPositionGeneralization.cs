#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_91b028d_1582232449455_399436_247">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class OriginPositionGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1582232449455_399436_247";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "OriginPosition";
		
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
		/// Original Type: _19_0_3_91b028d_1582232689807_149219_388
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.PositionClass);

		/// <inheritdoc />
		public new OriginPositionGeneralizationProperties Properties { get; } = new OriginPositionGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="OriginPositionGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.PositionClass.PositionClassProperties" />.
		/// </summary>
		public class OriginPositionGeneralizationProperties : Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.PositionClass.PositionClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}