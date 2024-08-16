using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// <i>location</i> that is represented by a point in space relative to a reference.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678088345310_788620_700">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PositionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678088345310_788620_700";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(location)}} that is represented by a point in space relative to a reference.&#10;
";

		/// <inheritdoc />
		public string Name => "position";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1678088336223_911067_642
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.LocationClass);

		/// <inheritdoc />
		public PositionClassProperties Properties { get; } = new PositionClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class PositionClassProperties : Mtconnect.Glossary.LocationClass.LocationClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}