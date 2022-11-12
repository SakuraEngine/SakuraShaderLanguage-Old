using SKSLC.Generators.Utils;

namespace SKSLC.Generators;

/// <summary>
/// Indicates a type of shader being processed.
/// </summary>
public enum ShaderType
{
    /// <summary>
    /// A compute shader.
    /// </summary>
    ComputeShader,

    /// <summary>
    /// A pixel shader.
    /// </summary>
    PixelShader
}

/// <summary>
/// A model for extracted info on a processed HLSL shader.
/// </summary>
/// <param name="HeaderAndThreadsX">The shader generated header and <c>threadsX</c> count declaration.</param>
/// <param name="ThreadsY">The <c>threadsY</c> count declaration.</param>
/// <param name="ThreadsZ">The <c>threadsZ</c> count declaration.</param>
/// <param name="Defines">The define statements, if any.</param>
/// <param name="StaticFieldsAndDeclaredTypes">The static fields and declared types, if any.</param>
/// <param name="CapturedFieldsAndResourcesAndForwardDeclarations">The captured fields, and method forward declarations.</param>
/// <param name="CapturedMethods">The captured method implementations.</param>
/// <param name="EntryPoint">The shader entry point.</param>
/// <param name="ImplicitTextureType">The type of the implicit texture type, if any.</param>
/// <param name="IsSamplerUsed">Whether or not the static sampler is used.</param>
/// <param name="DefinedTypes">The names of declared types.</param>
/// <param name="DefinedConstants">The names of defined constants.</param>
/// <param name="MethodSignatures">The signatures for captured methods.</param>
/// <param name="Delegates">The list of delegate fields.</param>
internal sealed record ShaderEntryCodeInfo(
    string HeaderAndThreadsX,
    string ThreadsY,
    string ThreadsZ,
    string Defines,
    string StaticFieldsAndDeclaredTypes,
    string CapturedFieldsAndResourcesAndForwardDeclarations,
    string CapturedMethods,
    string EntryPoint,
    string? ImplicitTextureType,
    bool IsSamplerUsed,
    EquatableArray<string> DefinedTypes,
    EquatableArray<string> DefinedConstants,
    EquatableArray<string> MethodSignatures,
    EquatableArray<string> Delegates);

/// <summary>
/// A model representing all necessary info for a full generation pass for a shader.
/// </summary>
/// <param name="Hierarchy">The hierarchy info for the shader type.</param>
/// <param name="DispatchId">The gathered dispatch id for the shader type.</param>
/// <param name="DispatchData">The gathered shader dispatch data.</param>
/// <param name="DispatchMetadata">The gathered shader dispatch metadata.</param>
/// <param name="HlslShaderSource">The processed HLSL source for the shader.</param>
/// <param name="ThreadIds">The thread ids for the shader, if compilation is requested.</param>
/// <param name="Diagnostcs">The discovered diagnostics, if any.</param>
internal sealed record ShaderEntryInfo(
    HierarchyInfo Hierarchy,
    DispatchIdInfo DispatchId,
    DispatchDataInfo DispatchData,
    DispatchMetadataInfo DispatchMetadata,
    ShaderEntryCodeInfo HlslShaderSource,
    ThreadIdsInfo ThreadIds,
    EquatableArray<DiagnosticInfo> Diagnostcs);