
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.ObservationInformationModel.Representations;

using Mtconnect;

namespace Mtconnect.ObservationInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RepresentationsPackage {


	private Package.RepresentationClass _Representation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.RepresentationClass Representation => _Representation ?? (_Representation = new Package.RepresentationClass());

	private Package.ValueClass _Value;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ValueClass Value => _Value ?? (_Value = new Package.ValueClass());

	private Package.TimeSeriesClass _TimeSeries;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TimeSeriesClass TimeSeries => _TimeSeries ?? (_TimeSeries = new Package.TimeSeriesClass());

	private Package.DiscreteClass _Discrete;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DiscreteClass Discrete => _Discrete ?? (_Discrete = new Package.DiscreteClass());

	private Package.DataSetClass _DataSet;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DataSetClass DataSet => _DataSet ?? (_DataSet = new Package.DataSetClass());

	private Package.EntryClass _Entry;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EntryClass Entry => _Entry ?? (_Entry = new Package.EntryClass());

	private Package.TableClass _Table;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TableClass Table => _Table ?? (_Table = new Package.TableClass());

	private Package.TableEntryClass _TableEntry;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TableEntryClass TableEntry => _TableEntry ?? (_TableEntry = new Package.TableEntryClass());

	private Package.CellClass _Cell;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CellClass Cell => _Cell ?? (_Cell = new Package.CellClass());
	}
}