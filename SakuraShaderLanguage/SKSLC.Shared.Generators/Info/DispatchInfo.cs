using Microsoft.CodeAnalysis;
using SKSLC.Generators.Utils;
using System.Reflection;

namespace SKSLC.Generators;

/// <summary>
/// A model representing gathered info on a embedded thread ids.
/// </summary>
/// <param name="IsDefault">Whether the values are discarded.</param>
/// <param name="X">The thread ids value for the X axis.</param>
/// <param name="Y">The thread ids value for the Y axis.</param>
/// <param name="Z">The thread ids value for the Z axis.</param>
internal sealed record ThreadIdsInfo(bool IsDefault, int X, int Y, int Z);

/// <summary>
/// A model representing gathered info on a shader dispatch id.
/// </summary>
/// <param name="Delegates">The list of delegate field names for the shader.</param>
internal sealed record DispatchIdInfo(EquatableArray<string> Delegates);

/// <summary>
/// A model representing gathered info on a shader dispatch data.
/// </summary>
/// <param name="Type">The shader interface type.</param>
/// <param name="FieldInfos">The description on shader instance fields.</param>
/// <param name="ResourceCount">The total number of captured resources.</param>
/// <param name="Root32BitConstantCount">The size of the shader root signature, in 32 bit constants.</param>
internal sealed record DispatchDataInfo(
    ShaderType Type,
    EquatableArray<FieldInfo> FieldInfos,
    int ResourceCount,
    int Root32BitConstantCount);

/// <summary>
/// A model containing info on shader dispatch metadata.
/// </summary>
/// <param name="Root32BitConstantCount">The size of the shader root signature, in 32 bit constants.</param>
/// <param name="IsSamplerUsed">Whether or not the static sampler is used.</param>
internal sealed record DispatchMetadataInfo(int Root32BitConstantCount, bool IsSamplerUsed/*, EquatableArray<ResourceDescriptor> ResourceDescriptors*/);