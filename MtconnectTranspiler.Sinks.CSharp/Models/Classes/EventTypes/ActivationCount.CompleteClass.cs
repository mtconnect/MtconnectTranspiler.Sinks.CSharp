using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// accumulation of actions, items, or activities that have been completed, independent of the outcome.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622197601184_207530_813">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ActivationCountCompleteClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622197601184_207530_813";
		
		/// <inheritdoc />
		public string Summary => @"/// accumulation of actions, items, or activities that have been completed, independent of the outcome.";

		/// <inheritdoc />
		public string Name => "ActivationCount.Complete";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.8";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1622197601180_60498_809
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ActivationCountClass);

		/// <inheritdoc />
		public ActivationCountCompleteClassProperties Properties { get; } = new ActivationCountCompleteClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ActivationCountCompleteClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ActivationCountClass.ActivationCountClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				SubType,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			public sealed class SubTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579563592155_977172_22064</item>
				/// <item>Type: DataItemSubTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnum);
				
				/// <inheritdoc />
				public string Name => "subType";
				
				/// <inheritdoc />
				public string Summary => @"/// accumulation of actions, items, or activities that have been completed, independent of the outcome.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "COMPLETE";
			}
		};

	}
}