using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.InformationModel;

namespace Mtconnect.AgentArchitecture
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class InformationModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1585536614231_659745_2656";
		
		/// <inheritdoc />
		public string Name => "InformationModel";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
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
		#region Packages
	#endregion

	#region Classes
	private Package.ObservationClass _ObservationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationClass" path="/summary" />
	/// </summary>
	public Package.ObservationClass ObservationClass => _ObservationClass ?? (_ObservationClass = new Package.ObservationClass());

	private Package.SampleClass _SampleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SampleClass" path="/summary" />
	/// </summary>
	public Package.SampleClass SampleClass => _SampleClass ?? (_SampleClass = new Package.SampleClass());

	private Package.EventClass _EventClass;
	/// <summary>
	/// <inheritdoc cref="Package.EventClass" path="/summary" />
	/// </summary>
	public Package.EventClass EventClass => _EventClass ?? (_EventClass = new Package.EventClass());

	private Package.ContitionClass _ContitionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ContitionClass" path="/summary" />
	/// </summary>
	public Package.ContitionClass ContitionClass => _ContitionClass ?? (_ContitionClass = new Package.ContitionClass());

	private Package.DataSetClass _DataSetClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataSetClass" path="/summary" />
	/// </summary>
	public Package.DataSetClass DataSetClass => _DataSetClass ?? (_DataSetClass = new Package.DataSetClass());

	private Package.ObservationValueClass _ObservationValueClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationValueClass" path="/summary" />
	/// </summary>
	public Package.ObservationValueClass ObservationValueClass => _ObservationValueClass ?? (_ObservationValueClass = new Package.ObservationValueClass());

	private Package.TextValueClass _TextValueClass;
	/// <summary>
	/// <inheritdoc cref="Package.TextValueClass" path="/summary" />
	/// </summary>
	public Package.TextValueClass TextValueClass => _TextValueClass ?? (_TextValueClass = new Package.TextValueClass());

	private Package.NumericValueClass _NumericValueClass;
	/// <summary>
	/// <inheritdoc cref="Package.NumericValueClass" path="/summary" />
	/// </summary>
	public Package.NumericValueClass NumericValueClass => _NumericValueClass ?? (_NumericValueClass = new Package.NumericValueClass());

	private Package.ControlledVocabularyValueClass _ControlledVocabularyValueClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControlledVocabularyValueClass" path="/summary" />
	/// </summary>
	public Package.ControlledVocabularyValueClass ControlledVocabularyValueClass => _ControlledVocabularyValueClass ?? (_ControlledVocabularyValueClass = new Package.ControlledVocabularyValueClass());

	private Package.ConditionValueClass _ConditionValueClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionValueClass" path="/summary" />
	/// </summary>
	public Package.ConditionValueClass ConditionValueClass => _ConditionValueClass ?? (_ConditionValueClass = new Package.ConditionValueClass());

	private Package.TableClass _TableClass;
	/// <summary>
	/// <inheritdoc cref="Package.TableClass" path="/summary" />
	/// </summary>
	public Package.TableClass TableClass => _TableClass ?? (_TableClass = new Package.TableClass());

	private Package.TimeSeriesClass _TimeSeriesClass;
	/// <summary>
	/// <inheritdoc cref="Package.TimeSeriesClass" path="/summary" />
	/// </summary>
	public Package.TimeSeriesClass TimeSeriesClass => _TimeSeriesClass ?? (_TimeSeriesClass = new Package.TimeSeriesClass());

	private Package.ComponentClass _ComponentClass;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentClass" path="/summary" />
	/// </summary>
	public Package.ComponentClass ComponentClass => _ComponentClass ?? (_ComponentClass = new Package.ComponentClass());

	private Package.DataItemClass _DataItemClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemClass" path="/summary" />
	/// </summary>
	public Package.DataItemClass DataItemClass => _DataItemClass ?? (_DataItemClass = new Package.DataItemClass());

	private Package.DeviceClass _DeviceClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceClass" path="/summary" />
	/// </summary>
	public Package.DeviceClass DeviceClass => _DeviceClass ?? (_DeviceClass = new Package.DeviceClass());

	private Package.ConfigurationClass _ConfigurationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConfigurationClass" path="/summary" />
	/// </summary>
	public Package.ConfigurationClass ConfigurationClass => _ConfigurationClass ?? (_ConfigurationClass = new Package.ConfigurationClass());

	private Package.ReferenceClass _ReferenceClass;
	/// <summary>
	/// <inheritdoc cref="Package.ReferenceClass" path="/summary" />
	/// </summary>
	public Package.ReferenceClass ReferenceClass => _ReferenceClass ?? (_ReferenceClass = new Package.ReferenceClass());

	#endregion
	}
}