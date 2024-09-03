#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.Motion;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>﻿This section provides semantic information for the <see cref="Motion">Motion</see> entity.<br /><br />![Motion](figures/Motion.png "Motion"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.<br /><br />![Motion Example](figures/Motion%20Example.png "Motion Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(motion-example)}} for the <i>XML</i> representation of the same example.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1579526830201_236256_7625">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MotionPackage : IPackage
	{
		/// <summary>Constant value for <see cref="MotionPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1579526830201_236256_7625";
		/// <summary>Constant value for <see cref="MotionPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_91b028d_1579526830201_236256_7625";
		/// <summary>Constant value for <see cref="MotionPackage.Name" /></summary>
		public const string NAME = "Motion";
		/// <summary>Constant value for <see cref="MotionPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(Motion)}} entity.

![Motion](figures/Motion.png ""Motion""){: width=""0.8""}

> Note: See {{sect(Configuration Schema Diagrams)}} for XML schema.

![Motion Example](figures/Motion%20Example.png ""Motion Example""){: width=""0.8""}

> Note: See {{lst(motion-example)}} for the {{term(XML)}} representation of the same example.&#10;
";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MotionClass,
			AxisClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.MotionClass _MotionClass;
	/// <summary>
	/// <inheritdoc cref="Package.MotionClass" path="/summary" />
	/// </summary>
	public Package.MotionClass MotionClass => _MotionClass ?? (_MotionClass = new Package.MotionClass());

	private Package.AxisClass _AxisClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisClass" path="/summary" />
	/// </summary>
	public Package.AxisClass AxisClass => _AxisClass ?? (_AxisClass = new Package.AxisClass());

	#endregion

	#region Enums
	#endregion
	}
}