using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// <i>application</i> that sends <i>request</i> for information to an <i>agent</i>.  > Note: Examples include software applications or a function that implements the <i>request</i> portion of an <i>interface</i> <i>interaction model</i>.  
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375146_487077_1962">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ClientClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375146_487077_1962";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>application</i> that sends <i>request</i> for information to an <i>agent</i>.  > Note: Examples include software applications or a function that implements the <i>request</i> portion of an <i>interface</i> <i>interaction model</i>.  ";

		/// <inheritdoc />
		public string Name => "client";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1623664375141_18140_1949
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ApplicationClass);

		/// <inheritdoc />
		public ClientClassProperties Properties { get; } = new ClientClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ClientClassProperties : Mtconnect.Glossary.ApplicationClass.ApplicationClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}