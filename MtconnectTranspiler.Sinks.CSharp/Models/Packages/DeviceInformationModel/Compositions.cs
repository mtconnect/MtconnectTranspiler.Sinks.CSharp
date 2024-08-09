using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Compositions;

namespace Mtconnect.DeviceInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="Composition">Composition</see> entity.  See {{figure(Components)}} for the <see cref="Composition">Composition</see> model diagram.  ![Component with Compositions Example](figures/Component%20with%20Compositions%20Example.png "Component with Compositions Example"){: width="0.8"}  > Note: See {{lst(component-with-compositions-example)}} for the <i>XML</i> representation of the same example./// Compositions Model
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_3D92D585_AB2B_4fe0_8B49_2F22359705CA">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class CompositionsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_3D92D585_AB2B_4fe0_8B49_2F22359705CA";
		
		/// <inheritdoc />
		public string Name => "Compositions";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""Composition"">Composition</see> entity.  See {{figure(Components)}} for the <see cref=""Composition"">Composition</see> model diagram.  ![Component with Compositions Example](figures/Component%20with%20Compositions%20Example.png ""Component with Compositions Example""){: width=""0.8""}  > Note: See {{lst(component-with-compositions-example)}} for the <i>XML</i> representation of the same example./// Compositions Model";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			CompositionClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.CompositionClass _CompositionClass;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionClass" path="/summary" />
	/// </summary>
	public Package.CompositionClass CompositionClass => _CompositionClass ?? (_CompositionClass = new Package.CompositionClass());

	#endregion
	}
}