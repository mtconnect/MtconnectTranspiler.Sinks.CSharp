using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.Motion;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>
	/// This section provides semantic information for the <see cref="Motion">Motion</see> entity.  ![Motion](figures/Motion.png "Motion"){: width="0.8"}  > Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.  ![Motion Example](figures/Motion%20Example.png "Motion Example"){: width="0.8"}  > Note: See {{lst(motion-example)}} for the <i>XML</i> representation of the same example.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class MotionPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1579526830201_236256_7625";
		
		/// <inheritdoc />
		public string Name => "Motion";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""Motion"">Motion</see> entity.  ![Motion](figures/Motion.png ""Motion""){: width=""0.8""}  > Note: See <see cref=""Configuration Schema Diagrams"">Configuration Schema Diagrams</see> for XML schema.  ![Motion Example](figures/Motion%20Example.png ""Motion Example""){: width=""0.8""}  > Note: See {{lst(motion-example)}} for the <i>XML</i> representation of the same example.";

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