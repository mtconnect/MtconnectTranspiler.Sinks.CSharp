#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1635253160701_352708_1245">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class AdditionalObservationTermsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1635253160701_352708_1245";
		
		/// <inheritdoc />
		public string Name => "Additional Observation Terms";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ObservedMeasurementClass,
			ObservedConditionClass,
			ObservableEventClass,
			ObservableSampleClass,
			ObservedStateClass,
			ObservedNormalClass,
			ObservableConditionClass,
			ObservedEventClass,
			ObservableMeasurementClass,
			ObservableStateClass,
			ObservedFaultClass,
			ObservedWarningClass,
			EventClass,
			SampleClass,
			ConditionClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.ObservedMeasurementClass _ObservedMeasurementClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservedMeasurementClass" path="/summary" />
	/// </summary>
	public Package.ObservedMeasurementClass ObservedMeasurementClass => _ObservedMeasurementClass ?? (_ObservedMeasurementClass = new Package.ObservedMeasurementClass());

	private Package.ObservedConditionClass _ObservedConditionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservedConditionClass" path="/summary" />
	/// </summary>
	public Package.ObservedConditionClass ObservedConditionClass => _ObservedConditionClass ?? (_ObservedConditionClass = new Package.ObservedConditionClass());

	private Package.ObservableEventClass _ObservableEventClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservableEventClass" path="/summary" />
	/// </summary>
	public Package.ObservableEventClass ObservableEventClass => _ObservableEventClass ?? (_ObservableEventClass = new Package.ObservableEventClass());

	private Package.ObservableSampleClass _ObservableSampleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservableSampleClass" path="/summary" />
	/// </summary>
	public Package.ObservableSampleClass ObservableSampleClass => _ObservableSampleClass ?? (_ObservableSampleClass = new Package.ObservableSampleClass());

	private Package.ObservedStateClass _ObservedStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservedStateClass" path="/summary" />
	/// </summary>
	public Package.ObservedStateClass ObservedStateClass => _ObservedStateClass ?? (_ObservedStateClass = new Package.ObservedStateClass());

	private Package.ObservedNormalClass _ObservedNormalClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservedNormalClass" path="/summary" />
	/// </summary>
	public Package.ObservedNormalClass ObservedNormalClass => _ObservedNormalClass ?? (_ObservedNormalClass = new Package.ObservedNormalClass());

	private Package.ObservableConditionClass _ObservableConditionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservableConditionClass" path="/summary" />
	/// </summary>
	public Package.ObservableConditionClass ObservableConditionClass => _ObservableConditionClass ?? (_ObservableConditionClass = new Package.ObservableConditionClass());

	private Package.ObservedEventClass _ObservedEventClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservedEventClass" path="/summary" />
	/// </summary>
	public Package.ObservedEventClass ObservedEventClass => _ObservedEventClass ?? (_ObservedEventClass = new Package.ObservedEventClass());

	private Package.ObservableMeasurementClass _ObservableMeasurementClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservableMeasurementClass" path="/summary" />
	/// </summary>
	public Package.ObservableMeasurementClass ObservableMeasurementClass => _ObservableMeasurementClass ?? (_ObservableMeasurementClass = new Package.ObservableMeasurementClass());

	private Package.ObservableStateClass _ObservableStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservableStateClass" path="/summary" />
	/// </summary>
	public Package.ObservableStateClass ObservableStateClass => _ObservableStateClass ?? (_ObservableStateClass = new Package.ObservableStateClass());

	private Package.ObservedFaultClass _ObservedFaultClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservedFaultClass" path="/summary" />
	/// </summary>
	public Package.ObservedFaultClass ObservedFaultClass => _ObservedFaultClass ?? (_ObservedFaultClass = new Package.ObservedFaultClass());

	private Package.ObservedWarningClass _ObservedWarningClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservedWarningClass" path="/summary" />
	/// </summary>
	public Package.ObservedWarningClass ObservedWarningClass => _ObservedWarningClass ?? (_ObservedWarningClass = new Package.ObservedWarningClass());

	private Package.EventClass _EventClass;
	/// <summary>
	/// <inheritdoc cref="Package.EventClass" path="/summary" />
	/// </summary>
	public Package.EventClass EventClass => _EventClass ?? (_EventClass = new Package.EventClass());

	private Package.SampleClass _SampleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SampleClass" path="/summary" />
	/// </summary>
	public Package.SampleClass SampleClass => _SampleClass ?? (_SampleClass = new Package.SampleClass());

	private Package.ConditionClass _ConditionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionClass" path="/summary" />
	/// </summary>
	public Package.ConditionClass ConditionClass => _ConditionClass ?? (_ConditionClass = new Package.ConditionClass());

	#endregion

	#region Enums
	#endregion
	}
}