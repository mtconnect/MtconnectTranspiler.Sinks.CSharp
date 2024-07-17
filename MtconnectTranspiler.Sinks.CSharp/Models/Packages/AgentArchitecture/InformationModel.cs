using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.InformationModel;
// using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class InformationModelPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			ObservationClass,
			SampleClass,
			EventClass,
			ContitionClass,
			DataSetClass,
			ObservationValueClass,
			TextValueClass,
			NumericValueClass,
			ControlledVocabularyValueClass,
			ConditionValueClass,
			TableClass,
			TimeSeriesClass,
			ComponentClass,
			DataItemClass,
			DeviceClass,
			ConfigurationClass,
			ReferenceClass,
		};

	private Package.ObservationClass _ObservationClass;
	public Package.ObservationClass ObservationClass => _ObservationClass ?? (_ObservationClass = new Package.ObservationClass());
	private Package.SampleClass _SampleClass;
	public Package.SampleClass SampleClass => _SampleClass ?? (_SampleClass = new Package.SampleClass());
	private Package.EventClass _EventClass;
	public Package.EventClass EventClass => _EventClass ?? (_EventClass = new Package.EventClass());
	private Package.ContitionClass _ContitionClass;
	public Package.ContitionClass ContitionClass => _ContitionClass ?? (_ContitionClass = new Package.ContitionClass());
	private Package.DataSetClass _DataSetClass;
	public Package.DataSetClass DataSetClass => _DataSetClass ?? (_DataSetClass = new Package.DataSetClass());
	private Package.ObservationValueClass _ObservationValueClass;
	public Package.ObservationValueClass ObservationValueClass => _ObservationValueClass ?? (_ObservationValueClass = new Package.ObservationValueClass());
	private Package.TextValueClass _TextValueClass;
	public Package.TextValueClass TextValueClass => _TextValueClass ?? (_TextValueClass = new Package.TextValueClass());
	private Package.NumericValueClass _NumericValueClass;
	public Package.NumericValueClass NumericValueClass => _NumericValueClass ?? (_NumericValueClass = new Package.NumericValueClass());
	private Package.ControlledVocabularyValueClass _ControlledVocabularyValueClass;
	public Package.ControlledVocabularyValueClass ControlledVocabularyValueClass => _ControlledVocabularyValueClass ?? (_ControlledVocabularyValueClass = new Package.ControlledVocabularyValueClass());
	private Package.ConditionValueClass _ConditionValueClass;
	public Package.ConditionValueClass ConditionValueClass => _ConditionValueClass ?? (_ConditionValueClass = new Package.ConditionValueClass());
	private Package.TableClass _TableClass;
	public Package.TableClass TableClass => _TableClass ?? (_TableClass = new Package.TableClass());
	private Package.TimeSeriesClass _TimeSeriesClass;
	public Package.TimeSeriesClass TimeSeriesClass => _TimeSeriesClass ?? (_TimeSeriesClass = new Package.TimeSeriesClass());
	private Package.ComponentClass _ComponentClass;
	public Package.ComponentClass ComponentClass => _ComponentClass ?? (_ComponentClass = new Package.ComponentClass());
	private Package.DataItemClass _DataItemClass;
	public Package.DataItemClass DataItemClass => _DataItemClass ?? (_DataItemClass = new Package.DataItemClass());
	private Package.DeviceClass _DeviceClass;
	public Package.DeviceClass DeviceClass => _DeviceClass ?? (_DeviceClass = new Package.DeviceClass());
	private Package.ConfigurationClass _ConfigurationClass;
	public Package.ConfigurationClass ConfigurationClass => _ConfigurationClass ?? (_ConfigurationClass = new Package.ConfigurationClass());
	private Package.ReferenceClass _ReferenceClass;
	public Package.ReferenceClass ReferenceClass => _ReferenceClass ?? (_ReferenceClass = new Package.ReferenceClass());
	}
}