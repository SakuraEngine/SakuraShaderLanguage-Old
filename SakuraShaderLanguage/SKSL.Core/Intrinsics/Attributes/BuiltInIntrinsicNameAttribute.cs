using System;
using System.Diagnostics;

namespace SKSL.Core.Intrinsics.Attributes;

/// <summary>
/// An attribute indicating the native member name of a given HLSL intrinsic.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
[Conditional("SOURCE_GENERATOR")]
internal sealed class BuiltInIntrinsicNameAttribute : Attribute
{
    /// <summary>
    /// Creates a new <see cref="BuiltInIntrinsicNameAttribute"/> instance with the specified parameters.
    /// </summary>
    /// <param name="name">The name of the HLSL intrinsic.</param>
    public BuiltInIntrinsicNameAttribute(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Gets the name of the HLSL intrinsic.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets whether or not matching parameters is also required to extract the name of this intrinsic.
    /// </summary>
    public bool RequiresParametersMatching { get; init; }
}