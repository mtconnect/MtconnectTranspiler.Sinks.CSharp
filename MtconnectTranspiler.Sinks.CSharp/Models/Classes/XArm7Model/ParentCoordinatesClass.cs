#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_91b028d_1582232446904_854073_202">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ParentCoordinatesClass : IClass
	{
		/// <summary>Constant value for <see cref="ParentCoordinatesClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1582232446904_854073_202";
		/// <summary>Constant value for <see cref="ParentCoordinatesClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_91b028d_1582232446904_854073_202";
		/// <summary>Constant value for <see cref="ParentCoordinatesClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="ParentCoordinatesClass.Name" /></summary>
		public const string NAME = "ParentCoordinates";
		/// <summary>Constant value for <see cref="ParentCoordinatesClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ParentCoordinatesClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ParentCoordinatesClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="ParentCoordinatesClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_91b028d_1582232689807_149219_388
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.PositionClass);

		/// <inheritdoc />
		public new ParentCoordinatesClassProperties Properties { get; } = new ParentCoordinatesClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ParentCoordinatesClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.PositionClass.PositionClassProperties" />.
		/// </summary>
		public class ParentCoordinatesClassProperties : Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.PositionClass.PositionClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}