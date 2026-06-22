# MtconnectTranspiler.Sinks.CSharp

`MtconnectTranspiler.Sinks.CSharp` provides a generated C# view of the MTConnect SysML model plus helper APIs for navigating model metadata. It is useful when an application needs to inspect the MTConnect model from C# code, such as discovering packages, classes, enumerations, properties, model-browser links, normative versions, and observation type definitions.

The generated model is rooted at `Mtconnect.MtconnectModel`.

## Install

```bash
dotnet add package MtconnectTranspiler.Sinks.CSharp
```

## Model Browser Structure

The static, lazy-loaded nested structure in `Models/MtconnectModel.cs` mirrors the package/class hierarchy shown in the MTConnect model browser:

[https://model.mtconnect.org/](https://model.mtconnect.org/)

For example, a browser path such as:

```text
MTConnect
  Device Information Model
    Components
      Component Types
        Linear
```

is represented in C# as:

```csharp
using Mtconnect;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

IClass linear = MtconnectModel
    .DeviceInformationModelPackage
    .ComponentsPackage
    .ComponentTypesPackage
    .LinearClass;

Console.WriteLine(linear.Name);
Console.WriteLine(linear.HelpUrl);
Console.WriteLine(linear.Summary);
```

Each generated package exposes direct properties for child packages, classes, and enums, plus collection properties:

```csharp
IPackage deviceModel = MtconnectModel.DeviceInformationModelPackage;

foreach (IPackage package in deviceModel.Packages)
{
    Console.WriteLine(package.Name);
}

foreach (IClass modelClass in deviceModel.Classes)
{
    Console.WriteLine($"{modelClass.Name}: {modelClass.HelpUrl}");
}
```

The direct properties are lazy-loaded. Accessing one node, such as `LinearClass`, creates that metadata object on demand. Enumerating `Packages`, `Classes`, or `Enums` accesses the generated properties in that collection.

## Reading Class Metadata

Generated classes implement `IClass`, which includes model browser links, SysML reference IDs, summaries, normative version metadata, generalization, properties, and rules.

```csharp
using Mtconnect;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

IClass dataItem = MtconnectModel
    .DeviceInformationModelPackage
    .DataItemsPackage
    .DataItemClass;

Console.WriteLine(dataItem.ReferenceId);
Console.WriteLine(dataItem.HelpUrl);
Console.WriteLine(dataItem.NormativeVersion);

foreach (IProperty property in dataItem.Properties.Properties)
{
    Console.WriteLine($"{property.Name}: {property.Type.Name}");
}
```

## Reading Enum Metadata

Generated enums implement `IEnum`. The metadata object describes the SysML enumeration and exposes the generated enum value metadata through `Values`.

```csharp
using Mtconnect;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

IEnum category = MtconnectModel
    .DataTypesPackage
    .CategoryEnum;

foreach (IEnumInstance value in category.Values)
{
    Console.WriteLine($"{value.Name}: {value.Summary}");
}
```

## Observation Type Helpers

`NavigationExtensions` includes helper methods for working with MTConnect observation types.

```csharp
using System.Collections.Generic;
using Mtconnect.DataTypes;
using MtconnectTranspiler.Sinks.CSharp;

IEnumerable<ObservationType> sampleTypes =
    NavigationExtensions.GetObservationTypes(CategoryEnum.SAMPLE);

foreach (ObservationType sample in sampleTypes)
{
    Console.WriteLine($"{sample.Name} introduced in {sample.Introduced}");

    foreach (var subType in sample.SubTypes)
    {
        Console.WriteLine($"  {subType.Name}");
    }
}
```

To get condition, event, and sample observation types in one sequence:

```csharp
using System.Collections.Generic;
using MtconnectTranspiler.Sinks.CSharp;

IEnumerable<ObservationType> observations =
    NavigationExtensions.GetObservationTypes();
```

## Common Navigation Pattern

Use direct properties when you already know the browser path, and use the collection properties when you want to discover children dynamically.

```csharp
using System.Collections.Generic;
using System.Linq;
using Mtconnect;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

static IEnumerable<IClass> WalkClasses(IPackage package)
{
    foreach (IClass modelClass in package.Classes)
    {
        yield return modelClass;
    }

    foreach (IPackage child in package.Packages)
    {
        foreach (IClass modelClass in WalkClasses(child))
        {
            yield return modelClass;
        }
    }
}

IClass availability = WalkClasses(MtconnectModel.ObservationInformationModelPackage)
    .FirstOrDefault(modelClass => modelClass.Name == "Availability");

Console.WriteLine(availability?.HelpUrl);
```

## Notes

- The model metadata is generated from the MTConnect SysML model; it is not an XML document builder.
- `HelpUrl` values point back to the corresponding model browser pages where available.
- The generated package/class/enum property names are sanitized C# names derived from the SysML names, usually with `Package`, `Class`, or `Enum` suffixes.
