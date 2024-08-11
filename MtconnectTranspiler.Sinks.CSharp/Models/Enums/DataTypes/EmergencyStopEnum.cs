using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417662_889824_2876">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum EmergencyStopEnum
	{
		/// <summary>
		/// emergency stop circuit is complete and the piece of equipment, component, or composition is allowed to operate. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		ARMED,
		/// <summary>
		/// operation of the piece of equipment, component, or composition is inhibited.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		TRIGGERED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417662_889824_2876">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class EmergencyStopEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "EmergencyStopEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(EmergencyStopEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ARMED,
		TRIGGERED,
		};

		private ARMEDValue _ARMED;
		/// <summary>
		/// emergency stop circuit is complete and the piece of equipment, component, or composition is allowed to operate. 
		/// </summary>
		public ARMEDValue ARMED => _ARMED ?? (_ARMED = new ARMEDValue());

		/// <summary>
		/// emergency stop circuit is complete and the piece of equipment, component, or composition is allowed to operate. 
		/// </summary>
		public sealed class ARMEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ARMED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// emergency stop circuit is complete and the piece of equipment, component, or composition is allowed to operate. ";
		}
		private TRIGGEREDValue _TRIGGERED;
		/// <summary>
		/// operation of the piece of equipment, component, or composition is inhibited.
		/// </summary>
		public TRIGGEREDValue TRIGGERED => _TRIGGERED ?? (_TRIGGERED = new TRIGGEREDValue());

		/// <summary>
		/// operation of the piece of equipment, component, or composition is inhibited.
		/// </summary>
		public sealed class TRIGGEREDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRIGGERED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// operation of the piece of equipment, component, or composition is inhibited.";
		}
	}
}