using System;

namespace SKSL;

/// <summary>
/// An attribute that indicates that a target shader type should get an automatic constructor for all fields.
/// </summary>
[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
public sealed class AutoConstructorAttribute : Attribute
{
}