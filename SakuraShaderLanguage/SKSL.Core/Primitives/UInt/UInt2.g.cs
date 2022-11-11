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

/// <inheritdoc cref="UInt2"/>
[StructLayout(LayoutKind.Explicit, Size = 8, Pack = 4)]
public unsafe partial struct UInt2
#if NET6_0_OR_GREATER
    : ISpanFormattable
#endif
{
    /// <summary>
    /// A private buffer to which the undefined properties will point to.
    /// </summary>
    private static readonly void* UndefinedData = (void*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(UInt2), sizeof(UInt4));

    [FieldOffset(0)]
    private uint h;

    [FieldOffset(4)]
    private uint j;

    /// <summary>
    /// Gets a reference to a specific component in the current <see cref="UInt2"/> instance.
    /// </summary>
    /// <param name="i">The index of the component to access.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref uint this[int i] => ref *(uint*)UndefinedData;

    /// <summary>
    /// Gets a <see cref="UInt2"/> value with all components set to 0.
    /// </summary>
    public static UInt2 Zero => 0;

    /// <summary>
    /// Gets a <see cref="UInt2"/> value with all components set to 1.
    /// </summary>
    public static UInt2 One => 1;

    /// <summary>
    /// Gets a <see cref="UInt2"/> value with the <see cref="X"/> component set to 1, and the others to 0.
    /// </summary>
    public static UInt2 UnitX => new(1, 0);

    /// <summary>
    /// Gets a <see cref="UInt2"/> value with the <see cref="Y"/> component set to 1, and the others to 0.
    /// </summary>
    public static UInt2 UnitY => new(0, 1);

    /// <summary>
    /// Gets a <see cref="UInt2"/> value with the <see cref="x"/> component set to 1, and the others to 0.
    /// </summary>
    public static UInt2 Unitx => new(1, 0);

    /// <summary>
    /// Gets a <see cref="UInt2"/> value with the <see cref="y"/> component set to 1, and the others to 0.
    /// </summary>
    public static UInt2 Unity => new(0, 1);

    /// <summary>
    /// Gets a reference to the <see cref="uint"/> value representing the <c>X</c> component.
    /// </summary>
    [UnscopedRef]
    public ref uint X => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="uint"/> value representing the <c>Y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref uint Y => ref this.j;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt2"/> value with the components <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt2 XX => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="UInt2"/> value with the components <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref UInt2 XY => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="UInt2"/> value with the components <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref UInt2 YX => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt2"/> value with the components <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt2 YY => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 XXX => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 XXY => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 XYX => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 XYY => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 YXX => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 YXY => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 YYX => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 YYY => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 XXXX => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 XXXY => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 XXYX => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 XXYY => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 XYXX => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 XYXY => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 XYYX => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 XYYY => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 YXXX => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 YXXY => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 YXYX => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 YXYY => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 YYXX => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 YYXY => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 YYYX => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 YYYY => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="uint"/> value representing the <c>R</c> component.
    /// </summary>
    [UnscopedRef]
    public ref uint R => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="uint"/> value representing the <c>G</c> component.
    /// </summary>
    [UnscopedRef]
    public ref uint G => ref this.j;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt2"/> value with the components <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt2 RR => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="UInt2"/> value with the components <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref UInt2 RG => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="UInt2"/> value with the components <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref UInt2 GR => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt2"/> value with the components <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt2 GG => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 RRR => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 RRG => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 RGR => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 RGG => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 GRR => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 GRG => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 GGR => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 GGG => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 RRRR => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 RRRG => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 RRGR => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 RRGG => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 RGRR => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 RGRG => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 RGGR => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 RGGG => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 GRRR => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 GRRG => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 GRGR => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 GRGG => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 GGRR => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 GGRG => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 GGGR => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 GGGG => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="uint"/> value representing the <c>x</c> component.
    /// </summary>
    [UnscopedRef]
    public ref uint x => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="uint"/> value representing the <c>y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref uint y => ref this.j;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt2"/> value with the components <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt2 xx => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="UInt2"/> value with the components <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref UInt2 xy => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="UInt2"/> value with the components <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref UInt2 yx => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt2"/> value with the components <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt2 yy => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 xxx => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 xxy => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 xyx => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 xyy => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 yxx => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 yxy => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 yyx => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 yyy => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 xxxx => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 xxxy => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 xxyx => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 xxyy => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 xyxx => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 xyxy => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 xyyx => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 xyyy => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 yxxx => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 yxxy => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 yxyx => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 yxyy => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 yyxx => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 yyxy => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 yyyx => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 yyyy => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="uint"/> value representing the <c>r</c> component.
    /// </summary>
    [UnscopedRef]
    public ref uint r => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="uint"/> value representing the <c>g</c> component.
    /// </summary>
    [UnscopedRef]
    public ref uint g => ref this.j;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt2"/> value with the components <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt2 rr => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="UInt2"/> value with the components <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref UInt2 rg => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="UInt2"/> value with the components <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref UInt2 gr => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt2"/> value with the components <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt2 gg => ref *(UInt2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 rrr => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 rrg => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 rgr => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 rgg => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 grr => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 grg => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 ggr => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt3 ggg => ref *(UInt3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 rrrr => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 rrrg => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 rrgr => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 rrgg => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 rgrr => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 rgrg => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 rggr => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 rggg => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 grrr => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 grrg => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 grgr => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 grgg => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 ggrr => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 ggrg => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 gggr => ref *(UInt4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="UInt4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly UInt4 gggg => ref *(UInt4*)UndefinedData;

#if !SOURCE_GENERATOR

    /// <inheritdoc/>
    public override readonly string ToString()
    {
        string separator = NumberFormatInfo.CurrentInfo.NumberGroupSeparator;

#if NET6_0_OR_GREATER
        return string.Create(null, stackalloc char[64], $"<{this.h}{separator} {this.j}>");
#else
        return $"<{this.h}{separator} {this.j}>";
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
            $"<{this.h}{separator} {this.j}>");
    }

    /// <inheritdoc/>
    public readonly bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        string separator = NumberFormatInfo.GetInstance(provider).NumberGroupSeparator;

        return TryWriteFormatInterpolatedStringHandler.TryWrite(
            destination,
            format,
            provider,
            $"<{this.h}{separator} {this.j}>",
            out charsWritten);
    }

#endif

    /// <summary>
    /// Sums two <see cref="UInt2"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to sum.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to sum.</param>
    /// <returns>The result of adding <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator +(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Divides two <see cref="UInt2"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to divide.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to divide.</param>
    /// <returns>The result of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator /(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Calculates the remainder of the division between two <see cref="UInt2"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to divide.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to divide.</param>
    /// <returns>The remainder of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator %(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Multiplies two <see cref="UInt2"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to multiply.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator *(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Subtracts two <see cref="UInt2"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to subtract.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to subtract.</param>
    /// <returns>The result of subtracting <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator -(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Compares two <see cref="UInt2"/> values to see if the first is greater than the second.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to compare.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator >(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Compares two <see cref="UInt2"/> values to see if the first is greater than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to compare.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator >=(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Compares two <see cref="UInt2"/> values to see if the first is lower than the second.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to compare.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator <(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Compares two <see cref="UInt2"/> values to see if the first is lower than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to compare.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator <=(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Bitwise negates a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="hj">The <see cref="UInt2"/> value to bitwise negate.</param>
    /// <returns>The bitwise negated value of <paramref name="hj"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator ~(UInt2 hj) => default;

    /// <summary>
    /// Shifts right a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="hj">The <see cref="UInt2"/> value to shift right.</param>
    /// <param name="amount">The amount to shift each element right by.</param>
    /// <returns>The result of shifting <paramref name="hj"/> right by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator >>(UInt2 hj, Int2 amount) => default;

    /// <summary>
    /// Shifts right a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="hj">The <see cref="UInt2"/> value to shift right.</param>
    /// <param name="amount">The amount to shift each element right by.</param>
    /// <returns>The result of shifting <paramref name="hj"/> right by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator >>(UInt2 hj, UInt2 amount) => default;

    /// <summary>
    /// Shifts left a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="hj">The <see cref="UInt2"/> value to shift left.</param>
    /// <param name="amount">The amount to shift each element left by.</param>
    /// <returns>The result of shifting <paramref name="hj"/> left by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator <<(UInt2 hj, Int2 amount) => default;

    /// <summary>
    /// Shifts left a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="hj">The <see cref="UInt2"/> value to shift left.</param>
    /// <param name="amount">The amount to shift each element left by.</param>
    /// <returns>The result of shifting <paramref name="hj"/> left by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator <<(UInt2 hj, UInt2 amount) => default;

    /// <summary>
    /// Bitwise ands a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="UInt2"/> value to bitwise and.</param>
    /// <param name="right">The <see cref="Int2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise and between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator &(UInt2 left, Int2 right) => default;

    /// <summary>
    /// Bitwise ands a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="UInt2"/> value to bitwise and.</param>
    /// <param name="right">The <see cref="UInt2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise and between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator &(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Bitwise ors a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="UInt2"/> value to bitwise or.</param>
    /// <param name="right">The <see cref="Int2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise or between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator |(UInt2 left, Int2 right) => default;

    /// <summary>
    /// Bitwise ors a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="UInt2"/> value to bitwise or.</param>
    /// <param name="right">The <see cref="UInt2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise or between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator |(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Bitwise xors a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="UInt2"/> value to bitwise xor.</param>
    /// <param name="right">The <see cref="Int2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise xor between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator ^(UInt2 left, Int2 right) => default;

    /// <summary>
    /// Bitwise xors a <see cref="UInt2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="UInt2"/> value to bitwise xor.</param>
    /// <param name="right">The <see cref="UInt2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise xor between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static UInt2 operator ^(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Compares two <see cref="UInt2"/> values to see if they are equal.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to compare.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator ==(UInt2 left, UInt2 right) => default;

    /// <summary>
    /// Compares two <see cref="UInt2"/> values to see if they are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="UInt2"/> value to compare.</param>
    /// <param name="right">The second <see cref="UInt2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator !=(UInt2 left, UInt2 right) => default;
}
