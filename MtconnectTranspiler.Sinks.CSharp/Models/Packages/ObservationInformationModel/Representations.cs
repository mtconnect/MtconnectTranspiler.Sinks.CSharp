using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.Representations;
// using Mtconnect;

namespace Mtconnect.ObservationInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RepresentationsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

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

	private Package.RepresentationClass _RepresentationClass;
	public Package.RepresentationClass RepresentationClass => _RepresentationClass ?? (_RepresentationClass = new Package.RepresentationClass());
	private Package.ValueClass _ValueClass;
	public Package.ValueClass ValueClass => _ValueClass ?? (_ValueClass = new Package.ValueClass());
	private Package.TimeSeriesClass _TimeSeriesClass;
	public Package.TimeSeriesClass TimeSeriesClass => _TimeSeriesClass ?? (_TimeSeriesClass = new Package.TimeSeriesClass());
	private Package.DiscreteClass _DiscreteClass;
	public Package.DiscreteClass DiscreteClass => _DiscreteClass ?? (_DiscreteClass = new Package.DiscreteClass());
	private Package.DataSetClass _DataSetClass;
	public Package.DataSetClass DataSetClass => _DataSetClass ?? (_DataSetClass = new Package.DataSetClass());
	private Package.EntryClass _EntryClass;
	public Package.EntryClass EntryClass => _EntryClass ?? (_EntryClass = new Package.EntryClass());
	private Package.TableClass _TableClass;
	public Package.TableClass TableClass => _TableClass ?? (_TableClass = new Package.TableClass());
	private Package.TableEntryClass _TableEntryClass;
	public Package.TableEntryClass TableEntryClass => _TableEntryClass ?? (_TableEntryClass = new Package.TableEntryClass());
	private Package.CellClass _CellClass;
	public Package.CellClass CellClass => _CellClass ?? (_CellClass = new Package.CellClass());
	}
}