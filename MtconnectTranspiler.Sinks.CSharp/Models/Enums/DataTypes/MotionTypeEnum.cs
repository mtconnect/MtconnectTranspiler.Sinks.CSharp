using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_4BA8528B_F152_49aa_BEFD_2574649F9F1A">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum MotionTypeEnum
	{
		/// <summary>
		/// sliding linear motion along an axis with a fixed range of motion.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PRISMATIC,
		/// <summary>
		/// revolves around an axis with a continuous range of motion.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		CONTINUOUS,
		/// <summary>
		/// rotates around an axis with a fixed range of motion.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		REVOLUTE,
		/// <summary>
		/// axis does not move.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		FIXED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_4BA8528B_F152_49aa_BEFD_2574649F9F1A">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MotionTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "MotionTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(MotionTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.7";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		PRISMATIC,
		CONTINUOUS,
		REVOLUTE,
		FIXED,
		};

		private PRISMATICValue _PRISMATIC;
		/// <summary>
		/// sliding linear motion along an axis with a fixed range of motion.
		/// </summary>
		public PRISMATICValue PRISMATIC => _PRISMATIC ?? (_PRISMATIC = new PRISMATICValue());

		/// <summary>
		/// sliding linear motion along an axis with a fixed range of motion.
		/// </summary>
		public sealed class PRISMATICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRISMATIC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// sliding linear motion along an axis with a fixed range of motion.";
		}
		private CONTINUOUSValue _CONTINUOUS;
		/// <summary>
		/// revolves around an axis with a continuous range of motion.
		/// </summary>
		public CONTINUOUSValue CONTINUOUS => _CONTINUOUS ?? (_CONTINUOUS = new CONTINUOUSValue());

		/// <summary>
		/// revolves around an axis with a continuous range of motion.
		/// </summary>
		public sealed class CONTINUOUSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONTINUOUS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// revolves around an axis with a continuous range of motion.";
		}
		private REVOLUTEValue _REVOLUTE;
		/// <summary>
		/// rotates around an axis with a fixed range of motion.
		/// </summary>
		public REVOLUTEValue REVOLUTE => _REVOLUTE ?? (_REVOLUTE = new REVOLUTEValue());

		/// <summary>
		/// rotates around an axis with a fixed range of motion.
		/// </summary>
		public sealed class REVOLUTEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REVOLUTE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// rotates around an axis with a fixed range of motion.";
		}
		private FIXEDValue _FIXED;
		/// <summary>
		/// axis does not move.
		/// </summary>
		public FIXEDValue FIXED => _FIXED ?? (_FIXED = new FIXEDValue());

		/// <summary>
		/// axis does not move.
		/// </summary>
		public sealed class FIXEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FIXED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// axis does not move.";
		}
	}
}