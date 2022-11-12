using System;
namespace SKSL;

/// <summary>
/// An attribute that indicates that a target shader type should get an automatic constructor for all fields.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public sealed class ShaderMethodAttribute : Attribute
{

}