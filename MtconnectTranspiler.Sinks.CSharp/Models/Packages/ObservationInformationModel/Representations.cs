using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.Representations;
// using Mtconnect;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="Representation">Representation</see> model.  ![Representation](figures/Representation.png "Representation"){: width="0.8"}  > Note: See <see cref="Representation Schema Diagrams">Representation Schema Diagrams</see> for XML schema.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class RepresentationsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1583339330789_426055_14911";
		
		/// <inheritdoc />
		public string Name => "Representations";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""Representation"">Representation</see> model.  ![Representation](figures/Representation.png ""Representation""){: width=""0.8""}  > Note: See <see cref=""Representation Schema Diagrams"">Representation Schema Diagrams</see> for XML schema.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			RepresentationClass,
			ValueClass,
			TimeSeriesClass,
			DiscreteClass,
			DataSetClass,
			EntryClass,
			TableClass,
			TableEntryClass,
			CellClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.RepresentationClass _RepresentationClass;
	/// <summary>
	/// <inheritdoc cref="Package.RepresentationClass" path="/summary" />
	/// </summary>
	public Package.RepresentationClass RepresentationClass => _RepresentationClass ?? (_RepresentationClass = new Package.RepresentationClass());

	private Package.ValueClass _ValueClass;
	/// <summary>
	/// <inheritdoc cref="Package.ValueClass" path="/summary" />
	/// </summary>
	public Package.ValueClass ValueClass => _ValueClass ?? (_ValueClass = new Package.ValueClass());

	private Package.TimeSeriesClass _TimeSeriesClass;
	/// <summary>
	/// <inheritdoc cref="Package.TimeSeriesClass" path="/summary" />
	/// </summary>
	public Package.TimeSeriesClass TimeSeriesClass => _TimeSeriesClass ?? (_TimeSeriesClass = new Package.TimeSeriesClass());

	private Package.DiscreteClass _DiscreteClass;
	/// <summary>
	/// <inheritdoc cref="Package.DiscreteClass" path="/summary" />
	/// </summary>
	public Package.DiscreteClass DiscreteClass => _DiscreteClass ?? (_DiscreteClass = new Package.DiscreteClass());

	private Package.DataSetClass _DataSetClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataSetClass" path="/summary" />
	/// </summary>
	public Package.DataSetClass DataSetClass => _DataSetClass ?? (_DataSetClass = new Package.DataSetClass());

	private Package.EntryClass _EntryClass;
	/// <summary>
	/// <inheritdoc cref="Package.EntryClass" path="/summary" />
	/// </summary>
	public Package.EntryClass EntryClass => _EntryClass ?? (_EntryClass = new Package.EntryClass());

	private Package.TableClass _TableClass;
	/// <summary>
	/// <inheritdoc cref="Package.TableClass" path="/summary" />
	/// </summary>
	public Package.TableClass TableClass => _TableClass ?? (_TableClass = new Package.TableClass());

	private Package.TableEntryClass _TableEntryClass;
	/// <summary>
	/// <inheritdoc cref="Package.TableEntryClass" path="/summary" />
	/// </summary>
	public Package.TableEntryClass TableEntryClass => _TableEntryClass ?? (_TableEntryClass = new Package.TableEntryClass());

	private Package.CellClass _CellClass;
	/// <summary>
	/// <inheritdoc cref="Package.CellClass" path="/summary" />
	/// </summary>
	public Package.CellClass CellClass => _CellClass ?? (_CellClass = new Package.CellClass());

	#endregion
	}
}