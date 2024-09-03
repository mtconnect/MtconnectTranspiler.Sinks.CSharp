#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Compositions;

namespace Mtconnect.DeviceInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="Composition">Composition</see> entity.<br /><br />See {{figure(Components)}} for the <see cref="Composition">Composition</see> model diagram.<br /><br />![Component with Compositions Example](figures/Component%20with%20Compositions%20Example.png "Component with Compositions Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(component-with-compositions-example)}} for the <i>XML</i> representation of the same example.<br /><br /><br />Compositions Model<br /><br /><see cref="Composition">Composition</see> entities are used to describe the lowest level physical building blocks of a piece of equipment contained within a <see cref="Component">Component</see>. By referencing a specific <see cref="Composition">Composition</see> entity, further clarification and meaning to data associated with a specific <see cref="Component">Component</see> can be achieved.<br /><br />Both <see cref="Component">Component</see> and <see cref="Composition">Composition</see> entities are <i>lower level</i> entities representing the sub-parts of the parent <see cref="Component">Component</see>.  However, there are distinct differences between <see cref="Component">Component</see> and <see cref="Composition">Composition</see> type entities.<br /><br /><see cref="Component">Component</see> entities may be further defined with <i>lower level</i> <see cref="Component">Component</see> entities and may have associated <i>DataItem</i>s.<br /><br /><see cref="Composition">Composition</see> entities represent the lowest level physical part of a piece of equipment.  They <b>MUST NOT</b> be further defined with <i>lower level</i> <see cref="Component">Component</see> entities and they <b>MUST NOT</b> have <i>DataItem</i>s directly associated with them.   They do provide additional information that can be used to enhance the specificity of <i>DataItem</i>s associated with the parent <see cref="Component">Component</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_3D92D585_AB2B_4fe0_8B49_2F22359705CA">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class CompositionsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="CompositionsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAPK_3D92D585_AB2B_4fe0_8B49_2F22359705CA";
		/// <summary>Constant value for <see cref="CompositionsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package__EAPK_3D92D585_AB2B_4fe0_8B49_2F22359705CA";
		/// <summary>Constant value for <see cref="CompositionsPackage.Name" /></summary>
		public const string NAME = "Compositions";
		/// <summary>Constant value for <see cref="CompositionsPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(Composition)}} entity.

See {{figure(Components)}} for the {{block(Composition)}} model diagram.

![Component with Compositions Example](figures/Component%20with%20Compositions%20Example.png ""Component with Compositions Example""){: width=""0.8""}

> Note: See {{lst(component-with-compositions-example)}} for the {{term(XML)}} representation of the same example.&#10;
&#10;&#10;&#10;Compositions Model&#10;&#10;&#10;&#10;{{block(Composition)}} entities are used to describe the lowest level physical building blocks of a piece of equipment contained within a {{block(Component)}}. By referencing a specific {{block(Composition)}} entity, further clarification and meaning to data associated with a specific {{block(Component)}} can be achieved.

Both {{block(Component)}} and {{block(Composition)}} entities are {{term(lower level)}} entities representing the sub-parts of the parent {{block(Component)}}.  However, there are distinct differences between {{block(Component)}} and {{block(Composition)}} type entities.

{{block(Component)}} entities may be further defined with {{term(lower level)}} {{block(Component)}} entities and may have associated {{termplural(DataItem)}}.

{{block(Composition)}} entities represent the lowest level physical part of a piece of equipment.  They **MUST NOT** be further defined with {{term(lower level)}} {{block(Component)}} entities and they **MUST NOT** have {{termplural(DataItem)}} directly associated with them.   They do provide additional information that can be used to enhance the specificity of {{termplural(DataItem)}} associated with the parent {{block(Component)}}.&#10;
";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			CompositionClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.CompositionClass _CompositionClass;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionClass" path="/summary" />
	/// </summary>
	public Package.CompositionClass CompositionClass => _CompositionClass ?? (_CompositionClass = new Package.CompositionClass());

	#endregion

	#region Enums
	#endregion
	}
}