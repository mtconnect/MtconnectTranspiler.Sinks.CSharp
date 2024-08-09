using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.SolidModel;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>
	/// This section provides semantic information for the <see cref="SolidModel">SolidModel</see> entity.  ![SolidModel](figures/SolidModel.png "SolidModel"){: width="0.8"}  > Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.  ![SolidModel Example](figures/SolidModel%20Example.png "SolidModel Example"){: width="0.8"}  > Note: See {{lst(solidmodel-example)}} for the <i>XML</i> representation of the same example.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1587596036608_721900_298">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class SolidModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1587596036608_721900_298";
		
		/// <inheritdoc />
		public string Name => "SolidModel";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""SolidModel"">SolidModel</see> entity.  ![SolidModel](figures/SolidModel.png ""SolidModel""){: width=""0.8""}  > Note: See <see cref=""Configuration Schema Diagrams"">Configuration Schema Diagrams</see> for XML schema.  ![SolidModel Example](figures/SolidModel%20Example.png ""SolidModel Example""){: width=""0.8""}  > Note: See {{lst(solidmodel-example)}} for the <i>XML</i> representation of the same example.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			SolidModelClass,
			ScaleClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.SolidModelClass _SolidModelClass;
	/// <summary>
	/// <inheritdoc cref="Package.SolidModelClass" path="/summary" />
	/// </summary>
	public Package.SolidModelClass SolidModelClass => _SolidModelClass ?? (_SolidModelClass = new Package.SolidModelClass());

	private Package.ScaleClass _ScaleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ScaleClass" path="/summary" />
	/// </summary>
	public Package.ScaleClass ScaleClass => _ScaleClass ?? (_ScaleClass = new Package.ScaleClass());

	#endregion
	}
}