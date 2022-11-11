using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if !NET6_0_OR_GREATER
using RuntimeHelpers = SKSL.Core.NetStandard.System.Runtime.CompilerServices.RuntimeHelpers;
#endif

#nullable enable
#pragma warning disable CS0660, CS0661

namespace SKSL;

/// <inheritdoc cref="Double3"/>
[StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
public unsafe partial struct Double3
#if NET6_0_OR_GREATER
    : ISpanFormattable
#endif
{
    /// <summary>
    /// A private buffer to which the undefined properties will point to.
    /// </summary>
    private static readonly void* UndefinedData = (void*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Double3), sizeof(Double4));

    [FieldOffset(0)]
    private double h;

    [FieldOffset(8)]
    private double j;

    [FieldOffset(16)]
    private double k;

    /// <summary>
    /// Gets a reference to a specific component in the current <see cref="Double3"/> instance.
    /// </summary>
    /// <param name="i">The index of the component to access.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref double this[int i] => ref *(double*)UndefinedData;

    /// <summary>
    /// Gets a <see cref="Double3"/> value with all components set to 0.
    /// </summary>
    public static Double3 Zero => 0;

    /// <summary>
    /// Gets a <see cref="Double3"/> value with all components set to 1.
    /// </summary>
    public static Double3 One => 1;

    /// <summary>
    /// Gets a <see cref="Double3"/> value with the <see cref="X"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double3 UnitX => new(1, 0, 0);

    /// <summary>
    /// Gets a <see cref="Double3"/> value with the <see cref="Y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double3 UnitY => new(0, 1, 0);

    /// <summary>
    /// Gets a <see cref="Double3"/> value with the <see cref="Z"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double3 UnitZ => new(0, 0, 1);

    /// <summary>
    /// Gets a <see cref="Double3"/> value with the <see cref="x"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double3 Unitx => new(1, 0, 0);

    /// <summary>
    /// Gets a <see cref="Double3"/> value with the <see cref="y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double3 Unity => new(0, 1, 0);

    /// <summary>
    /// Gets a <see cref="Double3"/> value with the <see cref="z"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double3 Unitz => new(0, 0, 1);

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>X</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double X => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>Y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double Y => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>Z</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double Z => ref this.k;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 XX => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 XY => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 XZ => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 YX => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 YY => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 YZ => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 ZX => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 ZY => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 ZZ => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 XXX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 XXY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 XXZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 XYX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 XYY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 XYZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 XZX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 XZY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 XZZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 YXX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 YXY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 YXZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 YYX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 YYY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 YYZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 YZX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 YZY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 YZZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ZXX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ZXY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ZXZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ZYX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ZYY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ZYZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ZZX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ZZY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ZZZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>R</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double R => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>G</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double G => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>B</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double B => ref this.k;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 RR => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 RG => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 RB => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 GR => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 GG => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 GB => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 BR => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 BG => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 BB => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 RRR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 RRG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 RRB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 RGR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 RGG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 RGB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 RBR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 RBG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 RBB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 GRR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 GRG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 GRB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 GGR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 GGG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 GGB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 GBR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 GBG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 GBB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 BRR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 BRG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 BRB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 BGR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 BGG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 BGB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 BBR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 BBG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 BBB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>x</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double x => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double y => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>z</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double z => ref this.k;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 xx => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 xy => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 xz => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 yx => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 yy => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 yz => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 zx => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 zy => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 zz => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 xxx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 xxy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 xxz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 xyx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 xyy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 xyz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 xzx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 xzy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 xzz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 yxx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 yxy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 yxz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 yyx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 yyy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 yyz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 yzx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 yzy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 yzz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 zxx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 zxy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 zxz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 zyx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 zyy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 zyz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 zzx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 zzy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 zzz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>r</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double r => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>g</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double g => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="double"/> value representing the <c>b</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double b => ref this.k;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 rr => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 rg => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 rb => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 gr => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 gg => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 gb => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 br => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 bg => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 bb => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 rrr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 rrg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 rrb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 rgr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 rgg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 rgb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 rbr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 rbg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 rbb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 grr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 grg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 grb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ggr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ggg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ggb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 gbr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 gbg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 gbb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 brr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 brg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 brb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 bgr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 bgg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 bgb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 bbr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 bbg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 bbb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrgr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrgg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrgb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rggr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rggg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rggb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbgr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbgg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbgb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grgr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grgg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grgb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gggr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gggg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gggb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbgr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbgg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbgb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brgr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brgg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brgb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bggr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bggg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bggb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbgr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbgg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbgb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbbb => ref *(Double4*)UndefinedData;

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
    /// Negates a <see cref="Double3"/> value.
    /// </summary>
    /// <param name="hjk">The <see cref="Double3"/> value to negate.</param>
    /// <returns>The negated value of <paramref name="hjk"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double3 operator -(Double3 hjk) => default;

    /// <summary>
    /// Sums two <see cref="Double3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to sum.</param>
    /// <param name="right">The second <see cref="Double3"/> value to sum.</param>
    /// <returns>The result of adding <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double3 operator +(Double3 left, Double3 right) => default;

    /// <summary>
    /// Divides two <see cref="Double3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to divide.</param>
    /// <param name="right">The second <see cref="Double3"/> value to divide.</param>
    /// <returns>The result of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double3 operator /(Double3 left, Double3 right) => default;

    /// <summary>
    /// Calculates the remainder of the division between two <see cref="Double3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to divide.</param>
    /// <param name="right">The second <see cref="Double3"/> value to divide.</param>
    /// <returns>The remainder of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double3 operator %(Double3 left, Double3 right) => default;

    /// <summary>
    /// Multiplies two <see cref="Double3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to multiply.</param>
    /// <param name="right">The second <see cref="Double3"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double3 operator *(Double3 left, Double3 right) => default;

    /// <summary>
    /// Subtracts two <see cref="Double3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to subtract.</param>
    /// <param name="right">The second <see cref="Double3"/> value to subtract.</param>
    /// <returns>The result of subtracting <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double3 operator -(Double3 left, Double3 right) => default;

    /// <summary>
    /// Compares two <see cref="Double3"/> values to see if the first is greater than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator >(Double3 left, Double3 right) => default;

    /// <summary>
    /// Compares two <see cref="Double3"/> values to see if the first is greater than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator >=(Double3 left, Double3 right) => default;

    /// <summary>
    /// Compares two <see cref="Double3"/> values to see if the first is lower than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator <(Double3 left, Double3 right) => default;

    /// <summary>
    /// Compares two <see cref="Double3"/> values to see if the first is lower than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator <=(Double3 left, Double3 right) => default;

    /// <summary>
    /// Compares two <see cref="Double3"/> values to see if they are equal.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator ==(Double3 left, Double3 right) => default;

    /// <summary>
    /// Compares two <see cref="Double3"/> values to see if they are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="Double3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator !=(Double3 left, Double3 right) => default;
}
