using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417660_348819_2874">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ControllerModeEnum
	{
		/// <summary>
		/// <see cref="Controller">Controller</see> is configured to automatically execute a program.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		AUTOMATIC,
		/// <summary>
		/// <see cref="Controller">Controller</see> is not executing an active program.   It is capable of receiving instructions from an external source – typically an operator. The <see cref="Controller">Controller</see> executes operations based on the instructions received from the external source.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		MANUAL,
		/// <summary>
		/// operator can enter a series of operations for the <see cref="Controller">Controller</see> to perform.  The <see cref="Controller">Controller</see> will execute this specific series of operations and then stop.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		MANUAL_DATA_INPUT,
		/// <summary>
		/// <see cref="Controller">Controller</see> is operating in a mode that restricts the active program from processing its next process step without operator intervention.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		SEMI_AUTOMATIC,
		/// <summary>
		/// <see cref="Controller">Controller</see> is currently functioning as a programming device and is not capable of executing an active program.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		EDIT,
		/// <summary>
		/// axes of the device are commanded to stop, but the spindle continues to function.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.3 according to https://model.mtconnect.org/#_Version_1.3")]
		FEED_HOLD,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417660_348819_2874">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ControllerModeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ControllerModeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ControllerModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		AUTOMATIC,
		MANUAL,
		MANUAL_DATA_INPUT,
		SEMI_AUTOMATIC,
		EDIT,
		FEED_HOLD,
		};

		private AUTOMATICValue _AUTOMATIC;
		/// <summary>
		/// <see cref="Controller">Controller</see> is configured to automatically execute a program.
		/// </summary>
		public AUTOMATICValue AUTOMATIC => _AUTOMATIC ?? (_AUTOMATIC = new AUTOMATICValue());

		/// <summary>
		/// <see cref="Controller">Controller</see> is configured to automatically execute a program.
		/// </summary>
		public sealed class AUTOMATICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AUTOMATIC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Controller"">Controller</see> is configured to automatically execute a program.";
		}
		private MANUALValue _MANUAL;
		/// <summary>
		/// <see cref="Controller">Controller</see> is not executing an active program.   It is capable of receiving instructions from an external source – typically an operator. The <see cref="Controller">Controller</see> executes operations based on the instructions received from the external source.
		/// </summary>
		public MANUALValue MANUAL => _MANUAL ?? (_MANUAL = new MANUALValue());

		/// <summary>
		/// <see cref="Controller">Controller</see> is not executing an active program.   It is capable of receiving instructions from an external source – typically an operator. The <see cref="Controller">Controller</see> executes operations based on the instructions received from the external source.
		/// </summary>
		public sealed class MANUALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MANUAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Controller"">Controller</see> is not executing an active program.   It is capable of receiving instructions from an external source – typically an operator. The <see cref=""Controller"">Controller</see> executes operations based on the instructions received from the external source.";
		}
		private MANUAL_DATA_INPUTValue _MANUAL_DATA_INPUT;
		/// <summary>
		/// operator can enter a series of operations for the <see cref="Controller">Controller</see> to perform.  The <see cref="Controller">Controller</see> will execute this specific series of operations and then stop.
		/// </summary>
		public MANUAL_DATA_INPUTValue MANUAL_DATA_INPUT => _MANUAL_DATA_INPUT ?? (_MANUAL_DATA_INPUT = new MANUAL_DATA_INPUTValue());

		/// <summary>
		/// operator can enter a series of operations for the <see cref="Controller">Controller</see> to perform.  The <see cref="Controller">Controller</see> will execute this specific series of operations and then stop.
		/// </summary>
		public sealed class MANUAL_DATA_INPUTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MANUAL_DATA_INPUT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// operator can enter a series of operations for the <see cref=""Controller"">Controller</see> to perform.  The <see cref=""Controller"">Controller</see> will execute this specific series of operations and then stop.";
		}
		private SEMI_AUTOMATICValue _SEMI_AUTOMATIC;
		/// <summary>
		/// <see cref="Controller">Controller</see> is operating in a mode that restricts the active program from processing its next process step without operator intervention.
		/// </summary>
		public SEMI_AUTOMATICValue SEMI_AUTOMATIC => _SEMI_AUTOMATIC ?? (_SEMI_AUTOMATIC = new SEMI_AUTOMATICValue());

		/// <summary>
		/// <see cref="Controller">Controller</see> is operating in a mode that restricts the active program from processing its next process step without operator intervention.
		/// </summary>
		public sealed class SEMI_AUTOMATICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SEMI_AUTOMATIC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Controller"">Controller</see> is operating in a mode that restricts the active program from processing its next process step without operator intervention.";
		}
		private EDITValue _EDIT;
		/// <summary>
		/// <see cref="Controller">Controller</see> is currently functioning as a programming device and is not capable of executing an active program.
		/// </summary>
		public EDITValue EDIT => _EDIT ?? (_EDIT = new EDITValue());

		/// <summary>
		/// <see cref="Controller">Controller</see> is currently functioning as a programming device and is not capable of executing an active program.
		/// </summary>
		public sealed class EDITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EDIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Controller"">Controller</see> is currently functioning as a programming device and is not capable of executing an active program.";
		}
		private FEED_HOLDValue _FEED_HOLD;
		/// <summary>
		/// axes of the device are commanded to stop, but the spindle continues to function.
		/// </summary>
		public FEED_HOLDValue FEED_HOLD => _FEED_HOLD ?? (_FEED_HOLD = new FEED_HOLDValue());

		/// <summary>
		/// axes of the device are commanded to stop, but the spindle continues to function.
		/// </summary>
		public sealed class FEED_HOLDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FEED_HOLD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.3";
			
			/// <inheritdoc />
			public string Summary => @"/// axes of the device are commanded to stop, but the spindle continues to function.";
		}
	}
}