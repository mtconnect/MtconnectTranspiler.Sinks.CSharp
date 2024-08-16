using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// abstract <see cref="Component">Component</see> composed of a motion system that provides linear or rotational motion for a piece of equipment.<br/><br />Description<br/>In robotics, the term <i>Axis</i> is synonymous with <i>Joint</i>. A <i>Joint</i> is the connection between two parts of the structure that move in relation to each other.<br /><br /><see cref="Linear">Linear</see> and <see cref="Rotary">Rotary</see> components <b>MUST</b> have <see cref="Component.name">name in Component</see> that <b>MUST</b> follow the conventions described below. Use the <see cref="Component.nativeName">nativeName in Component</see> for the manufacturer's name of the axis if it differs from the assigned <see cref="Component.name">name in Component</see>.<br /><br />MTConnect has two high-level classes for automation equipment as follows: (1) Equipment that controls cartesian coordinate axes and (2) Equipment that controls articulated axes. There are ambiguous cases where some machines exhibit both characteristics; when this occurs, the primary control system's configuration determines the classification.<br /><br />Examples of cartesian coordinate equipment are CNC Machine Tools, Coordinate measurement machines, as specified in ISO 841, and 3D Printers. Examples of articulated automation equipment are Robotic systems as specified in ISO 8373.<br /><br />The following sections define the designation of names for the axes and additional guidance when selecting the correct scheme to use for a given piece of equipment.<br /><br />#### Cartesian Coordinate Naming Conventions<br /><br />A Three-Dimensional Cartesian Coordinate control system organizes its axes orthogonally relative to a machine coordinate system where the manufacturer of the equipment specifies the origin. <br /><br /><see cref="Axes">Axes</see> <see cref="Component.name">name in Component</see> <b>SHOULD</b> comply with ISO 841, if possible.<br /><br />##### Linear Motion<br /><br />A piece of equipment <b>MUST</b> represent prismatic motion using a <see cref="Linear">Linear</see> axis and assign its <see cref="Component.name">name in Component</see> using the designations <c>X</c>, <c>Y</c>, and <c>Z</c>. A <see cref="Linear">Linear</see> axis <see cref="Component.name">name in Component</see> <b>MUST</b> append a monotonically increasing suffix when there are more than one parallel axes; for example, <c>X2</c>, <c>X3</c>, and <c>X4</c>. <br /><br />##### Rotary Motion<br /><br />MTConnect <b>MUST</b> assign the <see cref="Component.name">name in Component</see> to <see cref="Rotary">Rotary</see> axes exhibiting rotary motion using <c>A</c>, <c>B</c>, and <c>C</c>. A <see cref="Rotary">Rotary</see> axis <see cref="Component.name">name in Component</see> <b>MUST</b> append a monotonically increasing suffix when more than one <see cref="Rotary">Rotary</see> axis rotates around the same <see cref="Linear">Linear</see> axis; for example, <c>A2</c>, <c>A3</c>, and <c>A4</c>. <br /><br />#### Articulated Machine Control Systems<br /><br />An articulated control system's axes represent the connecting linkages between two adjacent rigid members of an assembly. The <see cref="Linear">Linear</see> axis represents prismatic motion, and the <see cref="Rotary">Rotary</see> axis represents the rotational motion of the two related members. The control organizes the axes in a kinematic chain from the mounting surface (base) to the end-effector or tooling.<br /><br />#### Articulated Machine Axis Names<br /><br />The axes of articulated machines represent forward kinematic relationships between mechanical linkages. Each axis is a connection between linkages, also referred to as joints, and <b>MUST</b> be named using a <c>J</c> followed by a monotonically increasing number; for example, <c>J1</c>, <c>J2</c>, <c>J3</c>.  The numbering starts at the base axis connected or closest to the mounting surface, <c>J1</c>, incrementing to the mechanical interface, <c>Jn</c>, where <c>n</c> is the number of the last axis. The chain forms a parent-child relationship with the parent being the axis closest to the base.<br /><br />A machine having an axis with more than one child <b>MUST</b> number each branch using its numeric designation followed by a branch number and a monotonically increasing number. For example, if <c>J2</c> has two children, the first child branch <b>MUST</b> be named <c>J2.1.1</c> and the second child branch <c>J2.2.1</c>. A child of the first branch <b>MUST</b> be named <c>J2.1.2</c>, incrementing to <c>J2.1.n</c>, where <c>J2.1.n</c> is the number of the last axis in that branch.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381972_553005_42207">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AxisClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381972_553005_42207";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;abstract {{block(Component)}} composed of a motion system that provides linear or rotational motion for a piece of equipment.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;In robotics, the term *Axis* is synonymous with *Joint*. A *Joint* is the connection between two parts of the structure that move in relation to each other.

{{block(Linear)}} and {{block(Rotary)}} components **MUST** have {{property(Component::name)}} that **MUST** follow the conventions described below. Use the {{property(Component::nativeName)}} for the manufacturer's name of the axis if it differs from the assigned {{property(Component::name)}}.

MTConnect has two high-level classes for automation equipment as follows: (1) Equipment that controls cartesian coordinate axes and (2) Equipment that controls articulated axes. There are ambiguous cases where some machines exhibit both characteristics; when this occurs, the primary control system's configuration determines the classification.

Examples of cartesian coordinate equipment are CNC Machine Tools, Coordinate measurement machines, as specified in ISO 841, and 3D Printers. Examples of articulated automation equipment are Robotic systems as specified in ISO 8373.

The following sections define the designation of names for the axes and additional guidance when selecting the correct scheme to use for a given piece of equipment.

#### Cartesian Coordinate Naming Conventions

A Three-Dimensional Cartesian Coordinate control system organizes its axes orthogonally relative to a machine coordinate system where the manufacturer of the equipment specifies the origin. 

{{block(Axes)}} {{property(Component::name)}} **SHOULD** comply with ISO 841, if possible.

##### Linear Motion

A piece of equipment **MUST** represent prismatic motion using a {{block(Linear)}} axis and assign its {{property(Component::name)}} using the designations `X`, `Y`, and `Z`. A {{block(Linear)}} axis {{property(Component::name)}} **MUST** append a monotonically increasing suffix when there are more than one parallel axes; for example, `X2`, `X3`, and `X4`. 

##### Rotary Motion

MTConnect **MUST** assign the {{property(Component::name)}} to {{block(Rotary)}} axes exhibiting rotary motion using `A`, `B`, and `C`. A {{block(Rotary)}} axis {{property(Component::name)}} **MUST** append a monotonically increasing suffix when more than one {{block(Rotary)}} axis rotates around the same {{block(Linear)}} axis; for example, `A2`, `A3`, and `A4`. 

#### Articulated Machine Control Systems

An articulated control system's axes represent the connecting linkages between two adjacent rigid members of an assembly. The {{block(Linear)}} axis represents prismatic motion, and the {{block(Rotary)}} axis represents the rotational motion of the two related members. The control organizes the axes in a kinematic chain from the mounting surface (base) to the end-effector or tooling.

#### Articulated Machine Axis Names

The axes of articulated machines represent forward kinematic relationships between mechanical linkages. Each axis is a connection between linkages, also referred to as joints, and **MUST** be named using a `J` followed by a monotonically increasing number; for example, `J1`, `J2`, `J3`.  The numbering starts at the base axis connected or closest to the mounting surface, `J1`, incrementing to the mechanical interface, `Jn`, where `n` is the number of the last axis. The chain forms a parent-child relationship with the parent being the axis closest to the base.

A machine having an axis with more than one child **MUST** number each branch using its numeric designation followed by a branch number and a monotonically increasing number. For example, if `J2` has two children, the first child branch **MUST** be named `J2.1.1` and the second child branch `J2.2.1`. A child of the first branch **MUST** be named `J2.1.2`, incrementing to `J2.1.n`, where `J2.1.n` is the number of the last axis in that branch.&#10;
";

		/// <inheritdoc />
		public string Name => "Axis";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public AxisClassProperties Properties { get; } = new AxisClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class AxisClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IsAxisOfPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="IsAxisOfPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsAxisOf</remarks>
			/// </summary>
			public IsAxisOfPartProperty IsAxisOfPart { get; } = new IsAxisOfPartProperty();
			public sealed class IsAxisOfPartProperty : IProperty
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
				public string Name => "isAxisOf";
				
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
				public string Association => "AxesClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}