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

/// <inheritdoc cref="Double4"/>
[StructLayout(LayoutKind.Explicit, Size = 32, Pack = 8)]
public unsafe partial struct Double4
#if NET6_0_OR_GREATER
    : ISpanFormattable
#endif
{
    /// <summary>
    /// A private buffer to which the undefined properties will point to.
    /// </summary>
    private static readonly void* UndefinedData = (void*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Double4), sizeof(Double4));

    [FieldOffset(0)]
    private double h;

    [FieldOffset(8)]
    private double j;

    [FieldOffset(16)]
    private double k;

    [FieldOffset(24)]
    private double l;

    /// <summary>
    /// Gets a reference to a specific component in the current <see cref="Double4"/> instance.
    /// </summary>
    /// <param name="i">The index of the component to access.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref double this[int i] => ref *(double*)UndefinedData;

    /// <summary>
    /// Gets a <see cref="Double4"/> value with all components set to 0.
    /// </summary>
    public static Double4 Zero => 0;

    /// <summary>
    /// Gets a <see cref="Double4"/> value with all components set to 1.
    /// </summary>
    public static Double4 One => 1;

    /// <summary>
    /// Gets a <see cref="Double4"/> value with the <see cref="X"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double4 UnitX => new(1, 0, 0, 0);

    /// <summary>
    /// Gets a <see cref="Double4"/> value with the <see cref="Y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double4 UnitY => new(0, 1, 0, 0);

    /// <summary>
    /// Gets a <see cref="Double4"/> value with the <see cref="Z"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double4 UnitZ => new(0, 0, 1, 0);

    /// <summary>
    /// Gets a <see cref="Double4"/> value with the <see cref="W"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double4 UnitW => new(0, 0, 0, 1);

    /// <summary>
    /// Gets a <see cref="Double4"/> value with the <see cref="x"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double4 Unitx => new(1, 0, 0, 0);

    /// <summary>
    /// Gets a <see cref="Double4"/> value with the <see cref="y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double4 Unity => new(0, 1, 0, 0);

    /// <summary>
    /// Gets a <see cref="Double4"/> value with the <see cref="z"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double4 Unitz => new(0, 0, 1, 0);

    /// <summary>
    /// Gets a <see cref="Double4"/> value with the <see cref="w"/> component set to 1, and the others to 0.
    /// </summary>
    public static Double4 Unitw => new(0, 0, 0, 1);

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
    /// Gets a reference to the <see cref="double"/> value representing the <c>W</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double W => ref this.l;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 XW => ref *(Double2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 YW => ref *(Double2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 ZW => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 WX => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 WY => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 WZ => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 WW => ref *(Double2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 XXW => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 XYW => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 XZW => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 XWX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 XWY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 XWZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 XWW => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 YXW => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 YYW => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 YZW => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 YWX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 YWY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 YWZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 YWW => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ZXW => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ZYW => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ZZW => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ZWX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ZWY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ZWZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ZWW => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 WXX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 WXY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 WXZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 WXW => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 WYX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 WYY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 WYZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 WYW => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 WZX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 WZY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 WZZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 WZW => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 WWX => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 WWY => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 WWZ => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 WWW => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXXW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXYW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XXWW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYXW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYYW => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 XYZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 XYWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XYWW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZXW => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 XZYW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 XZWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XZWW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWXW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 XWYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWYW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 XWZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 XWWW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXXW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXYW => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 YXZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 YXWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YXWW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYXW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYYW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YYWW => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 YZXW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZYW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 YZWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YZWW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 YWXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWXW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWYW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 YWZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 YWWW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXXW => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ZXYW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ZXWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZXWW => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ZYXW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYYW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ZYWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZYWW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZXW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZYW => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZZWW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ZWXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWXW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ZWYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWYW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ZWWW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXXW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 WXYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXYW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 WXZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WXWW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 WYXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYXW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYYW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 WYZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WYWW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 WZXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZXW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 WZYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZYW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WZWW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWXX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWXY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWXZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWXW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWYX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWYY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWYZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWYW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWZX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWZY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWZZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWZW => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWWX => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWWY => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWWZ => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 WWWW => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="double"/> value representing the <c>A</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double A => ref this.l;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 RA => ref *(Double2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 GA => ref *(Double2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 BA => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 AR => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 AG => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 AB => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 AA => ref *(Double2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 RRA => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 RGA => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 RBA => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 RAR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 RAG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 RAB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 RAA => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 GRA => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 GGA => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 GBA => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 GAR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 GAG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 GAB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 GAA => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 BRA => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 BGA => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 BBA => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 BAR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 BAG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 BAB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 BAA => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ARR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ARG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ARB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ARA => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 AGR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 AGG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 AGB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 AGA => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ABR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ABG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ABB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ABA => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 AAR => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 AAG => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 AAB => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 AAA => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRRA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRGA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RRAA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGRA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGGA => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 RGBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 RGAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RGAA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBRA => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 RBGA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 RBAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RBAA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RARR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RARG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RARB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RARA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RAGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RAGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 RAGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RAGA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RABR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 RABG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RABB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RABA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RAAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RAAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RAAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 RAAA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRRA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRGA => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 GRBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 GRAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GRAA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGRA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGGA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GGAA => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 GBRA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBGA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 GBAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GBAA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GARR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GARG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 GARB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GARA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GAGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GAGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GAGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GAGA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 GABR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GABG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GABB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GABA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GAAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GAAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GAAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 GAAA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRRA => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 BRGA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 BRAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BRAA => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 BGRA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGGA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 BGAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BGAA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBRA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBGA => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BBAA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BARR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 BARG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BARB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BARA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 BAGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BAGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BAGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BAGA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BABR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BABG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BABB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BABA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BAAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BAAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BAAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 BAAA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARRA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ARGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARGA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ARBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ARAA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 AGRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGRA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGGA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 AGBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AGAA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABRR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ABRG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABRB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABRA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ABGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABGA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABBR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABBG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABBB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABBA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ABAA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AARR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AARG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AARB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AARA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AAGR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AAGG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AAGB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AAGA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AABR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AABG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AABB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AABA => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AAAR => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AAAG => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AAAB => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 AAAA => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="double"/> value representing the <c>w</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double w => ref this.l;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 xw => ref *(Double2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 yw => ref *(Double2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 zw => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 wx => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 wy => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 wz => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 ww => ref *(Double2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 xxw => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 xyw => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 xzw => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 xwx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 xwy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 xwz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 xww => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 yxw => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 yyw => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 yzw => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ywx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ywy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 ywz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 yww => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 zxw => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 zyw => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 zzw => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 zwx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 zwy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 zwz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 zww => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 wxx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 wxy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 wxz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 wxw => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 wyx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 wyy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 wyz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 wyw => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 wzx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 wzy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 wzz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 wzw => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 wwx => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 wwy => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 wwz => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 www => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxxw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxyw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xxww => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyxw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyyw => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 xyzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xywx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xywy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 xywz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xyww => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzxw => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 xzyw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 xzwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xzww => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwxw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 xwyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwyw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 xwzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 xwww => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxxw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxyw => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 yxzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 yxwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yxww => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyxw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyyw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yywx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yywy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yywz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yyww => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 yzxw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzyw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 yzwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 yzww => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ywxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywxw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywyw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ywzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ywww => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxxw => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 zxyw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 zxwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zxww => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 zyxw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyyw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 zywx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zywy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zywz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zyww => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzxw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzyw => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zzww => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 zwxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwxw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 zwyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwyw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 zwww => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxxw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 wxyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxyw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 wxzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wxww => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 wyxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyxw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyyw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 wyzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wywx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wywy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wywz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wyww => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 wzxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzxw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 wzyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzyw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wzww => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwxx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwxy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwxz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwxw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwyx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwyy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwyz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwyw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwzx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwzy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwzz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwzw => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwwx => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwwy => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwwz => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 wwww => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="double"/> value representing the <c>a</c> component.
    /// </summary>
    [UnscopedRef]
    public ref double a => ref this.l;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 ra => ref *(Double2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 ga => ref *(Double2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 ba => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 ar => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 ag => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double2"/> value with the components <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double2 ab => ref *(Double2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double2"/> value with the components <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double2 aa => ref *(Double2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 rra => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 rga => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 rba => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 rar => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 rag => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 rab => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 raa => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 gra => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 gga => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 gba => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 gar => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 gag => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 gab => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 gaa => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 bra => ref *(Double3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 bga => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 bba => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 bar => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 bag => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 bab => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 baa => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 arr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 arg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 arb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 ara => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 agr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 agg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 agb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 aga => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 abr => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double3 abg => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 abb => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 aba => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 aar => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 aag => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 aab => ref *(Double3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double3 aaa => ref *(Double3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrra => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrga => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rrab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rraa => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgra => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgga => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 rgba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 rgab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rgaa => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbra => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 rbga => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 rbag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rbaa => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rarr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rarg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rarb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rara => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ragr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ragg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 ragb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 raga => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rabr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 rabg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 rabb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 raba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 raar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 raag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 raab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 raaa => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grra => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grga => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 grba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 grag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 grab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 graa => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggra => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggga => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 ggaa => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 gbra => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbga => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 gbar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gbaa => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 garr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 garg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 garb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gara => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gagr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gagg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gagb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gaga => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 gabr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gabg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gabb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gaba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gaar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gaag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gaab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 gaaa => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brra => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 brga => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 brag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 brab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 braa => ref *(Double4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 bgra => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgga => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 bgar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bgaa => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbra => ref *(Double4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbga => ref *(Double4*)UndefinedData;

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

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bbaa => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 barr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 barg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 barb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bara => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 bagr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bagg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 bagb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 baga => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 babr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 babg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 babb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 baba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 baar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 baag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 baab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 baaa => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arra => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 argr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 argg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 argb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arga => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 arbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 arab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 araa => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 agrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agra => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aggr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aggg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aggb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agga => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 agbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 agaa => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abrr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 abrg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abrb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abra => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Double4 abgr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abgg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abgb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abga => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abbr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abbg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abbb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 abaa => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aarr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aarg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aarb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aara => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aagr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aagg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aagb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aaga => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aabr => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aabg => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aabb => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aaba => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aaar => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aaag => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aaab => ref *(Double4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Double4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Double4 aaaa => ref *(Double4*)UndefinedData;

#if !SOURCE_GENERATOR

    /// <inheritdoc/>
    public override readonly string ToString()
    {
        string separator = NumberFormatInfo.CurrentInfo.NumberGroupSeparator;

#if NET6_0_OR_GREATER
        return string.Create(null, stackalloc char[64], $"<{this.h}{separator} {this.j}{separator} {this.k}{separator} {this.l}>");
#else
        return $"<{this.h}{separator} {this.j}{separator} {this.k}{separator} {this.l}>";
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
            $"<{this.h}{separator} {this.j}{separator} {this.k}{separator} {this.l}>");
    }

    /// <inheritdoc/>
    public readonly bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        string separator = NumberFormatInfo.GetInstance(provider).NumberGroupSeparator;

        return TryWriteFormatInterpolatedStringHandler.TryWrite(
            destination,
            format,
            provider,
            $"<{this.h}{separator} {this.j}{separator} {this.k}{separator} {this.l}>",
            out charsWritten);
    }

#endif

    /// <summary>
    /// Negates a <see cref="Double4"/> value.
    /// </summary>
    /// <param name="hjkl">The <see cref="Double4"/> value to negate.</param>
    /// <returns>The negated value of <paramref name="hjkl"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double4 operator -(Double4 hjkl) => default;

    /// <summary>
    /// Sums two <see cref="Double4"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to sum.</param>
    /// <param name="right">The second <see cref="Double4"/> value to sum.</param>
    /// <returns>The result of adding <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double4 operator +(Double4 left, Double4 right) => default;

    /// <summary>
    /// Divides two <see cref="Double4"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to divide.</param>
    /// <param name="right">The second <see cref="Double4"/> value to divide.</param>
    /// <returns>The result of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double4 operator /(Double4 left, Double4 right) => default;

    /// <summary>
    /// Calculates the remainder of the division between two <see cref="Double4"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to divide.</param>
    /// <param name="right">The second <see cref="Double4"/> value to divide.</param>
    /// <returns>The remainder of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double4 operator %(Double4 left, Double4 right) => default;

    /// <summary>
    /// Multiplies two <see cref="Double4"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to multiply.</param>
    /// <param name="right">The second <see cref="Double4"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double4 operator *(Double4 left, Double4 right) => default;

    /// <summary>
    /// Subtracts two <see cref="Double4"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to subtract.</param>
    /// <param name="right">The second <see cref="Double4"/> value to subtract.</param>
    /// <returns>The result of subtracting <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Double4 operator -(Double4 left, Double4 right) => default;

    /// <summary>
    /// Compares two <see cref="Double4"/> values to see if the first is greater than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator >(Double4 left, Double4 right) => default;

    /// <summary>
    /// Compares two <see cref="Double4"/> values to see if the first is greater than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator >=(Double4 left, Double4 right) => default;

    /// <summary>
    /// Compares two <see cref="Double4"/> values to see if the first is lower than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator <(Double4 left, Double4 right) => default;

    /// <summary>
    /// Compares two <see cref="Double4"/> values to see if the first is lower than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator <=(Double4 left, Double4 right) => default;

    /// <summary>
    /// Compares two <see cref="Double4"/> values to see if they are equal.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator ==(Double4 left, Double4 right) => default;

    /// <summary>
    /// Compares two <see cref="Double4"/> values to see if they are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="Double4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Double4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator !=(Double4 left, Double4 right) => default;
}
