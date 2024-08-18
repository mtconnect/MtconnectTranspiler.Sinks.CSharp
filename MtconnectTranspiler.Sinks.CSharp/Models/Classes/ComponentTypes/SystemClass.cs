#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿abstract <see cref="Component">Component</see> that is permanently integrated into the piece of equipment.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382020_336298_42297">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SystemClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382020_336298_42297";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;abstract {{block(Component)}} that is permanently integrated into the piece of equipment.&#10;
";

		/// <inheritdoc />
		public string Name => "System";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public new SystemClassProperties Properties { get; } = new SystemClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="SystemClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties" />.
		/// </summary>
		public class SystemClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				IsSystemOfPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="IsSystemOfPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsSystemOf</remarks>
			/// </summary>
			public new IsSystemOfPartProperty IsSystemOfPart { get; } = new IsSystemOfPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class IsSystemOfPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620240839406_285612_1596</item>
				/// <item>Type: DeviceClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DeviceClass);
				
				/// <inheritdoc />
				public string Name => "isSystemOf";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "SystemsClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}