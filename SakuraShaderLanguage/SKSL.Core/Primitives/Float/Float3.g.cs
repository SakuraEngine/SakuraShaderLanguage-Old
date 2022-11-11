using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SKSL.Core.Intrinsics.Attributes;
#if !NET6_0_OR_GREATER
using RuntimeHelpers = SKSL.Core.NetStandard.System.Runtime.CompilerServices.RuntimeHelpers;
#endif

#nullable enable
#pragma warning disable CS0660, CS0661

namespace SKSL;

/// <inheritdoc cref="Float3"/>
[StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
public unsafe partial struct Float3
#if NET6_0_OR_GREATER
    : ISpanFormattable
#endif
{
    /// <summary>
    /// A private buffer to which the undefined properties will point to.
    /// </summary>
    private static readonly void* UndefinedData = (void*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Float3), sizeof(Float4));

    [FieldOffset(0)]
    private float h;

    [FieldOffset(4)]
    private float j;

    [FieldOffset(8)]
    private float k;

    /// <summary>
    /// Gets a reference to a specific component in the current <see cref="Float3"/> instance.
    /// </summary>
    /// <param name="i">The index of the component to access.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref float this[int i] => ref *(float*)UndefinedData;

    /// <summary>
    /// Gets a <see cref="Float3"/> value with all components set to 0.
    /// </summary>
    public static Float3 Zero => 0;

    /// <summary>
    /// Gets a <see cref="Float3"/> value with all components set to 1.
    /// </summary>
    public static Float3 One => 1;

    /// <summary>
    /// Gets a <see cref="Float3"/> value with the <see cref="X"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float3 UnitX => new(1, 0, 0);

    /// <summary>
    /// Gets a <see cref="Float3"/> value with the <see cref="Y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float3 UnitY => new(0, 1, 0);

    /// <summary>
    /// Gets a <see cref="Float3"/> value with the <see cref="Z"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float3 UnitZ => new(0, 0, 1);

    /// <summary>
    /// Gets a <see cref="Float3"/> value with the <see cref="x"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float3 Unitx => new(1, 0, 0);

    /// <summary>
    /// Gets a <see cref="Float3"/> value with the <see cref="y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float3 Unity => new(0, 1, 0);

    /// <summary>
    /// Gets a <see cref="Float3"/> value with the <see cref="z"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float3 Unitz => new(0, 0, 1);

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>X</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float X => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>Y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float Y => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>Z</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float Z => ref this.k;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 XX => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 XY => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 XZ => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 YX => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 YY => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 YZ => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 ZX => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 ZY => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 ZZ => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 XXX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 XXY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 XXZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 XYX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 XYY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 XYZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 XZX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 XZY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 XZZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 YXX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 YXY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 YXZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 YYX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 YYY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 YYZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 YZX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 YZY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 YZZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ZXX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ZXY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ZXZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ZYX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ZYY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ZYZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ZZX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ZZY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ZZZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>R</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float R => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>G</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float G => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>B</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float B => ref this.k;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 RR => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 RG => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 RB => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 GR => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 GG => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 GB => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 BR => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 BG => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 BB => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 RRR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 RRG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 RRB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 RGR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 RGG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 RGB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 RBR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 RBG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 RBB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 GRR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 GRG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 GRB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 GGR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 GGG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 GGB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 GBR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 GBG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 GBB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 BRR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 BRG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 BRB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 BGR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 BGG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 BGB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 BBR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 BBG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 BBB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>x</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float x => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float y => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>z</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float z => ref this.k;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 xx => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 xy => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 xz => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 yx => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 yy => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 yz => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 zx => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 zy => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 zz => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 xxx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 xxy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 xxz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 xyx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 xyy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 xyz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 xzx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 xzy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 xzz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 yxx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 yxy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 yxz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 yyx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 yyy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 yyz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 yzx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 yzy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 yzz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 zxx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 zxy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 zxz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 zyx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 zyy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 zyz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 zzx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 zzy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 zzz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>r</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float r => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>g</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float g => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="float"/> value representing the <c>b</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float b => ref this.k;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 rr => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 rg => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 rb => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 gr => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 gg => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 gb => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 br => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 bg => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 bb => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 rrr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 rrg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 rrb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 rgr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 rgg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 rgb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 rbr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 rbg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 rbb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 grr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 grg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 grb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ggr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ggg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ggb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 gbr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 gbg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 gbb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 brr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 brg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 brb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 bgr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 bgg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 bgb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 bbr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 bbg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 bbb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrgr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrgg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrgb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rggr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rggg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rggb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbgr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbgg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbgb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grgr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grgg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grgb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gggr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gggg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gggb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbgr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbgg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbgb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brgr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brgg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brgb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bggr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bggg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bggb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbgr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbgg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbgb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbbb => ref *(Float4*)UndefinedData;

#if !SOURCE_GENERATOR

    /// <inheritdoc/>
    public override readonly string ToString()
    {
        string separator = NumberFormatInfo.CurrentInfo.NumberGroupSeparator;

#if NET6_0_OR_GREATER
        return string.Create(null, stackalloc char[64], $"<{this.h}{separator} {this.j}{separator} {this.k}>");
#else
        return $"<{this.h}{separator} {this.j}{separator} {this.k}>";
#endif
    }

    /// <inheritdoc/>
    public readonly string ToString(string? format, IFormatProvider? formatProvider)
    {
        string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

        return FormatInterpolatedStringHandler.Create(
            format,
            formatProvider,
            stackalloc char[64],
            $"<{this.h}{separator} {this.j}{separator} {this.k}>");
    }

    /// <inheritdoc/>
    public readonly bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        string separator = NumberFormatInfo.GetInstance(provider).NumberGroupSeparator;

        return TryWriteFormatInterpolatedStringHandler.TryWrite(
            destination,
            format,
            provider,
            $"<{this.h}{separator} {this.j}{separator} {this.k}>",
            out charsWritten);
    }

#endif

    /// <summary>
    /// Negates a <see cref="Float3"/> value.
    /// </summary>
    /// <param name="hjk">The <see cref="Float3"/> value to negate.</param>
    /// <returns>The negated value of <paramref name="hjk"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float3 operator -(Float3 hjk) => default;

    /// <summary>
    /// Sums two <see cref="Float3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to sum.</param>
    /// <param name="right">The second <see cref="Float3"/> value to sum.</param>
    /// <returns>The result of adding <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float3 operator +(Float3 left, Float3 right) => default;

    /// <summary>
    /// Divides two <see cref="Float3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to divide.</param>
    /// <param name="right">The second <see cref="Float3"/> value to divide.</param>
    /// <returns>The result of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float3 operator /(Float3 left, Float3 right) => default;

    /// <summary>
    /// Calculates the remainder of the division between two <see cref="Float3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to divide.</param>
    /// <param name="right">The second <see cref="Float3"/> value to divide.</param>
    /// <returns>The remainder of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float3 operator %(Float3 left, Float3 right) => default;

    /// <summary>
    /// Multiplies two <see cref="Float3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to multiply.</param>
    /// <param name="right">The second <see cref="Float3"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float3 operator *(Float3 left, Float3 right) => default;

    /// <summary>
    /// Multiplies a pair of <see cref="Float3"/> and <see cref="float"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Float3"/> value to multiply.</param>
    /// <param name="right">The <see cref="float"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float3 operator *(Float3 left, float right) => default;

    /// <summary>
    /// Multiplies a pair of <see cref="float"/> and <see cref="Float3"/> values.
    /// </summary>
    /// <param name="left">The <see cref="float"/> value to multiply.</param>
    /// <param name="right">The <see cref="Float3"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float3 operator *(float left, Float3 right) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Float3 input value.</param>
    /// <param name="y">The second Float3x1 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Float3, Float3x1)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static float operator *(Float3 x, Float3x1 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Float3 input value.</param>
    /// <param name="y">The second Float3x2 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Float3, Float3x2)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Float2 operator *(Float3 x, Float3x2 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Float3 input value.</param>
    /// <param name="y">The second Float3x3 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Float3, Float3x3)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Float3 operator *(Float3 x, Float3x3 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Float3 input value.</param>
    /// <param name="y">The second Float3x4 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Float3, Float3x4)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Float4 operator *(Float3 x, Float3x4 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Float3x3 input value.</param>
    /// <param name="y">The second Float3 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Float3x3, Float3)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Float3 operator *(Float3x3 x, Float3 y) => default;

    /// <summary>
    /// Subtracts two <see cref="Float3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to subtract.</param>
    /// <param name="right">The second <see cref="Float3"/> value to subtract.</param>
    /// <returns>The result of subtracting <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float3 operator -(Float3 left, Float3 right) => default;

    /// <summary>
    /// Compares two <see cref="Float3"/> values to see if the first is greater than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator >(Float3 left, Float3 right) => default;

    /// <summary>
    /// Compares two <see cref="Float3"/> values to see if the first is greater than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator >=(Float3 left, Float3 right) => default;

    /// <summary>
    /// Compares two <see cref="Float3"/> values to see if the first is lower than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator <(Float3 left, Float3 right) => default;

    /// <summary>
    /// Compares two <see cref="Float3"/> values to see if the first is lower than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator <=(Float3 left, Float3 right) => default;

    /// <summary>
    /// Compares two <see cref="Float3"/> values to see if they are equal.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator ==(Float3 left, Float3 right) => default;

    /// <summary>
    /// Compares two <see cref="Float3"/> values to see if they are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="Float3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator !=(Float3 left, Float3 right) => default;
}
