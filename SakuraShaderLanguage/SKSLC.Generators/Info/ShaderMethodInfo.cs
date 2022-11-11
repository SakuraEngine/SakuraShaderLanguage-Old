﻿using SKSLC.Generators.Utils;

namespace SKSLC.Generators;

/// <summary>
/// A model for extracted info on a processed HLSL method.
/// </summary>
/// <param name="MetadataName">The metadata name for the method.</param>
/// <param name="EntryPoint">The meethod entry point.</param>
/// <param name="DefinedTypes">The discovered declared types.</param>
/// <param name="DefinedConstants">The discovered defined constants.</param>
/// <param name="DependentMethods">The dependent captured methods.</param>
internal sealed record ShaderMethodSourceInfo(
    string MetadataName,
    string EntryPoint,
    EquatableArray<(string Name, string Definition)> DefinedTypes,
    EquatableArray<(string Name, string Value)> DefinedConstants,
    EquatableArray<(string Signature, string Definition)> DependentMethods);


/// <summary>
/// A model representing all necessary info for a full generation pass for a shader method.
/// </summary>
/// <param name="HlslMethodSource">The processed HLSL source for the shader method.</param>
/// <param name="Diagnostcs">The discovered diagnostics, if any.</param>
internal sealed record ShaderMethodInfo(ShaderMethodSourceInfo HlslMethodSource, EquatableArray<DiagnosticInfo> Diagnostcs);