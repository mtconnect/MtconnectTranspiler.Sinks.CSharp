using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.Motion;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>
	﻿/// This section provides semantic information for the <see cref="Motion">Motion</see> entity.<br /><br />![Motion](figures/Motion.png "Motion"){: width="0.8"}<br /><br />> Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.<br /><br />![Motion Example](figures/Motion%20Example.png "Motion Example"){: width="0.8"}<br /><br />> Note: See {{lst(motion-example)}} for the <i>XML</i> representation of the same example.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1579526830201_236256_7625">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MotionPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1579526830201_236256_7625";
		
		/// <inheritdoc />
		public string Name => "Motion";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(Motion)}} entity.

![Motion](figures/Motion.png ""Motion""){: width=""0.8""}

> Note: See {{sect(Configuration Schema Diagrams)}} for XML schema.

![Motion Example](figures/Motion%20Example.png ""Motion Example""){: width=""0.8""}

> Note: See {{lst(motion-example)}} for the {{term(XML)}} representation of the same example.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MotionClass,
			AxisClass,
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
	}
}