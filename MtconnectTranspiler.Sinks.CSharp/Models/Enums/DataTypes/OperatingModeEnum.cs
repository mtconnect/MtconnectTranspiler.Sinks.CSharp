using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1637936591972_920420_100">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum OperatingModeEnum
	{
		/// <summary>
		/// automatically execute instructions from a recipe or program.  > Note: Setpoint comes from a recipe.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		AUTOMATIC,
		/// <summary>
		/// execute instructions from an external agent or person.  > Note 1 to entry: Valve or switch is manipulated by an agent/person.  > Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		MANUAL,
		/// <summary>
		/// executes a single instruction from a recipe or program.  > Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.  > Note 2 to entry: Still goes through the PID control system.  > Note 3 to entry: Manual fixed entry from a recipe.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		SEMI_AUTOMATIC,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1637936591972_920420_100">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class OperatingModeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "OperatingModeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(OperatingModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		AUTOMATIC,
		MANUAL,
		SEMI_AUTOMATIC,
		};

		private AUTOMATICValue _AUTOMATIC;
		/// <summary>
		/// automatically execute instructions from a recipe or program.  > Note: Setpoint comes from a recipe.
		/// </summary>
		public AUTOMATICValue AUTOMATIC => _AUTOMATIC ?? (_AUTOMATIC = new AUTOMATICValue());

		/// <summary>
		/// automatically execute instructions from a recipe or program.  > Note: Setpoint comes from a recipe.
		/// </summary>
		public sealed class AUTOMATICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AUTOMATIC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// automatically execute instructions from a recipe or program.  > Note: Setpoint comes from a recipe.";
		}
		private MANUALValue _MANUAL;
		/// <summary>
		/// execute instructions from an external agent or person.  > Note 1 to entry: Valve or switch is manipulated by an agent/person.  > Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.
		/// </summary>
		public MANUALValue MANUAL => _MANUAL ?? (_MANUAL = new MANUALValue());

		/// <summary>
		/// execute instructions from an external agent or person.  > Note 1 to entry: Valve or switch is manipulated by an agent/person.  > Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.
		/// </summary>
		public sealed class MANUALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MANUAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// execute instructions from an external agent or person.  > Note 1 to entry: Valve or switch is manipulated by an agent/person.  > Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.";
		}
		private SEMI_AUTOMATICValue _SEMI_AUTOMATIC;
		/// <summary>
		/// executes a single instruction from a recipe or program.  > Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.  > Note 2 to entry: Still goes through the PID control system.  > Note 3 to entry: Manual fixed entry from a recipe.
		/// </summary>
		public SEMI_AUTOMATICValue SEMI_AUTOMATIC => _SEMI_AUTOMATIC ?? (_SEMI_AUTOMATIC = new SEMI_AUTOMATICValue());

		/// <summary>
		/// executes a single instruction from a recipe or program.  > Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.  > Note 2 to entry: Still goes through the PID control system.  > Note 3 to entry: Manual fixed entry from a recipe.
		/// </summary>
		public sealed class SEMI_AUTOMATICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SEMI_AUTOMATIC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// executes a single instruction from a recipe or program.  > Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.  > Note 2 to entry: Still goes through the PID control system.  > Note 3 to entry: Manual fixed entry from a recipe.";
		}
	}
}