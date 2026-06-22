[![Publish NuGet Package](https://github.com/mtconnect/MtconnectTranspiler.Sinks.CSharp/actions/workflows/main.yml/badge.svg)](https://github.com/mtconnect/MtconnectTranspiler.Sinks.CSharp/actions/workflows/main.yml)

# MtconnectTranspiler.Sinks.CSharp

This repository contains the C# sink for the [MtconnectTranspiler](https://github.com/mtconnect/MtconnectTranspiler). Its purpose is to translate the MTConnect SysML object-oriented model into generated C# metadata that can be used by applications, tools, and documentation workflows.

The generated package exposes the MTConnect model as a static, lazy-loaded C# hierarchy rooted at `Mtconnect.MtconnectModel`. That hierarchy mirrors the packages, classes, and enumerations shown in the MTConnect model browser at [model.mtconnect.org](https://model.mtconnect.org/), while also exposing C# interfaces for inspecting model metadata such as `ReferenceId`, `HelpUrl`, `Summary`, properties, enum values, generalizations, and normative version information.

## Projects

- `MtconnectTranspiler.Sinks.CSharp` contains the NuGet package, generated model metadata, navigation interfaces, and helper APIs.
- `MtconnectTranspiler.Sinks.CSharp.Example` contains an example transpiler project and Scriban templates used to generate C# output from the MTConnect model.

## Usage

For installation instructions, model navigation examples, observation type helpers, and examples showing how the generated `MtconnectModel.cs` structure maps to the MTConnect model browser, see the project documentation:

[MtconnectTranspiler.Sinks.CSharp/README.md](MtconnectTranspiler.Sinks.CSharp/README.md)
