
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AgentArchitecture.InformationModel;

using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class InformationModelPackage {


	private Package.ObservationClass _Observation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ObservationClass Observation => _Observation ?? (_Observation = new Package.ObservationClass());

	private Package.SampleClass _Sample;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SampleClass Sample => _Sample ?? (_Sample = new Package.SampleClass());

	private Package.EventClass _Event;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EventClass Event => _Event ?? (_Event = new Package.EventClass());

	private Package.ContitionClass _Contition;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ContitionClass Contition => _Contition ?? (_Contition = new Package.ContitionClass());

	private Package.DataSetClass _DataSet;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DataSetClass DataSet => _DataSet ?? (_DataSet = new Package.DataSetClass());

	private Package.ObservationValueClass _ObservationValue;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ObservationValueClass ObservationValue => _ObservationValue ?? (_ObservationValue = new Package.ObservationValueClass());

	private Package.TextValueClass _TextValue;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TextValueClass TextValue => _TextValue ?? (_TextValue = new Package.TextValueClass());

	private Package.NumericValueClass _NumericValue;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NumericValueClass NumericValue => _NumericValue ?? (_NumericValue = new Package.NumericValueClass());

	private Package.ControlledVocabularyValueClass _ControlledVocabularyValue;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControlledVocabularyValueClass ControlledVocabularyValue => _ControlledVocabularyValue ?? (_ControlledVocabularyValue = new Package.ControlledVocabularyValueClass());

	private Package.ConditionValueClass _ConditionValue;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ConditionValueClass ConditionValue => _ConditionValue ?? (_ConditionValue = new Package.ConditionValueClass());

	private Package.TableClass _Table;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TableClass Table => _Table ?? (_Table = new Package.TableClass());

	private Package.TimeSeriesClass _TimeSeries;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TimeSeriesClass TimeSeries => _TimeSeries ?? (_TimeSeries = new Package.TimeSeriesClass());

	private Package.ComponentClass _Component;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ComponentClass Component => _Component ?? (_Component = new Package.ComponentClass());

	private Package.DataItemClass _DataItem;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DataItemClass DataItem => _DataItem ?? (_DataItem = new Package.DataItemClass());

	private Package.DeviceClass _Device;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeviceClass Device => _Device ?? (_Device = new Package.DeviceClass());

	private Package.ConfigurationClass _Configuration;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ConfigurationClass Configuration => _Configuration ?? (_Configuration = new Package.ConfigurationClass());

	private Package.ReferenceClass _Reference;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ReferenceClass Reference => _Reference ?? (_Reference = new Package.ReferenceClass());
	}
}