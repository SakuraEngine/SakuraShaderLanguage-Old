﻿using System;
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

/// <inheritdoc cref="Int2"/>
[StructLayout(LayoutKind.Explicit, Size = 8, Pack = 4)]
public unsafe partial struct Int2
#if NET6_0_OR_GREATER
    : ISpanFormattable
#endif
{
    /// <summary>
    /// A private buffer to which the undefined properties will point to.
    /// </summary>
    private static readonly void* UndefinedData = (void*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Int2), sizeof(Int4));

    [FieldOffset(0)]
    private int x;

    [FieldOffset(4)]
    private int y;

    /// <summary>
    /// Gets a reference to a specific component in the current <see cref="Int2"/> instance.
    /// </summary>
    /// <param name="i">The index of the component to access.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref int this[int i] => ref *(int*)UndefinedData;

    /// <summary>
    /// Gets a <see cref="Int2"/> value with all components set to 0.
    /// </summary>
    public static Int2 Zero => 0;

    /// <summary>
    /// Gets a <see cref="Int2"/> value with all components set to 1.
    /// </summary>
    public static Int2 One => 1;

    /// <summary>
    /// Gets a <see cref="Int2"/> value with the <see cref="X"/> component set to 1, and the others to 0.
    /// </summary>
    public static Int2 UnitX => new(1, 0);

    /// <summary>
    /// Gets a <see cref="Int2"/> value with the <see cref="Y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Int2 UnitY => new(0, 1);

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>X</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int X => ref this.x;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>Y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int Y => ref this.y;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 XX => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 XY => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 YX => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 YY => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 XXX => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 XXY => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 XYX => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 XYY => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 YXX => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 YXY => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 YYX => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 YYY => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XXXX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XXXY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XXYX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XXYY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XYXX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XYXY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XYYX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XYYY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YXXX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YXXY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YXYX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YXYY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YYXX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YYXY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YYYX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YYYY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>R</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int R => ref this.x;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>G</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int G => ref this.y;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 RR => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 RG => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 GR => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 GG => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 RRR => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 RRG => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 RGR => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 RGG => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 GRR => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 GRG => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 GGR => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 GGG => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RRRR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RRRG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RRGR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RRGG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RGRR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RGRG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RGGR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RGGG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GRRR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GRRG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GRGR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GRGG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GGRR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GGRG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GGGR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GGGG => ref *(Int4*)UndefinedData;

#if !SOURCE_GENERATOR

    /// <inheritdoc/>
    public override readonly string ToString()
    {
        string separator = NumberFormatInfo.CurrentInfo.NumberGroupSeparator;

#if NET6_0_OR_GREATER
        return string.Create(null, stackalloc char[64], $"<{this.x}{separator} {this.y}>");
#else
        return $"<{this.x}{separator} {this.y}>";
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
            $"<{this.x}{separator} {this.y}>");
    }

    /// <inheritdoc/>
    public readonly bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        string separator = NumberFormatInfo.GetInstance(provider).NumberGroupSeparator;

        return TryWriteFormatInterpolatedStringHandler.TryWrite(
            destination,
            format,
            provider,
            $"<{this.x}{separator} {this.y}>",
            out charsWritten);
    }

#endif

    /// <summary>
    /// Negates a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="xy">The <see cref="Int2"/> value to negate.</param>
    /// <returns>The negated value of <paramref name="xy"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator -(Int2 xy) => default;

    /// <summary>
    /// Sums two <see cref="Int2"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to sum.</param>
    /// <param name="right">The second <see cref="Int2"/> value to sum.</param>
    /// <returns>The result of adding <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator +(Int2 left, Int2 right) => default;

    /// <summary>
    /// Divides two <see cref="Int2"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to divide.</param>
    /// <param name="right">The second <see cref="Int2"/> value to divide.</param>
    /// <returns>The result of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator /(Int2 left, Int2 right) => default;

    /// <summary>
    /// Calculates the remainder of the division between two <see cref="Int2"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to divide.</param>
    /// <param name="right">The second <see cref="Int2"/> value to divide.</param>
    /// <returns>The remainder of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator %(Int2 left, Int2 right) => default;

    /// <summary>
    /// Multiplies two <see cref="Int2"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to multiply.</param>
    /// <param name="right">The second <see cref="Int2"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator *(Int2 left, Int2 right) => default;

    /// <summary>
    /// Multiplies a pair of <see cref="Int2"/> and <see cref="int"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Int2"/> value to multiply.</param>
    /// <param name="right">The <see cref="int"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator *(Int2 left, int right) => default;

    /// <summary>
    /// Multiplies a pair of <see cref="int"/> and <see cref="Int2"/> values.
    /// </summary>
    /// <param name="left">The <see cref="int"/> value to multiply.</param>
    /// <param name="right">The <see cref="Int2"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator *(int left, Int2 right) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Int2 input value.</param>
    /// <param name="y">The second Int2x1 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="Hlsl.Mul(Int2, Int2x1)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [HlslIntrinsicName("mul", RequiresParametersMatching = true)]
    public static int operator *(Int2 x, Int2x1 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Int2 input value.</param>
    /// <param name="y">The second Int2x2 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="Hlsl.Mul(Int2, Int2x2)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [HlslIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Int2 operator *(Int2 x, Int2x2 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Int2 input value.</param>
    /// <param name="y">The second Int2x3 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="Hlsl.Mul(Int2, Int2x3)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [HlslIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Int3 operator *(Int2 x, Int2x3 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Int2 input value.</param>
    /// <param name="y">The second Int2x4 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="Hlsl.Mul(Int2, Int2x4)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [HlslIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Int4 operator *(Int2 x, Int2x4 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Int2x2 input value.</param>
    /// <param name="y">The second Int2 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="Hlsl.Mul(Int2x2, Int2)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [HlslIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Int2 operator *(Int2x2 x, Int2 y) => default;

    /// <summary>
    /// Subtracts two <see cref="Int2"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to subtract.</param>
    /// <param name="right">The second <see cref="Int2"/> value to subtract.</param>
    /// <returns>The result of subtracting <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator -(Int2 left, Int2 right) => default;

    /// <summary>
    /// Compares two <see cref="Int2"/> values to see if the first is greater than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator >(Int2 left, Int2 right) => default;

    /// <summary>
    /// Compares two <see cref="Int2"/> values to see if the first is greater than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator >=(Int2 left, Int2 right) => default;

    /// <summary>
    /// Compares two <see cref="Int2"/> values to see if the first is lower than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator <(Int2 left, Int2 right) => default;

    /// <summary>
    /// Compares two <see cref="Int2"/> values to see if the first is lower than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator <=(Int2 left, Int2 right) => default;

    /// <summary>
    /// Bitwise negates a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="xy">The <see cref="Int2"/> value to bitwise negate.</param>
    /// <returns>The bitwise negated value of <paramref name="xy"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator ~(Int2 xy) => default;

    /// <summary>
    /// Shifts right a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="xy">The <see cref="Int2"/> value to shift right.</param>
    /// <param name="amount">The amount to shift each element right by.</param>
    /// <returns>The result of shifting <paramref name="xy"/> right by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator >>(Int2 xy, Int2 amount) => default;

    /// <summary>
    /// Shifts right a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="xy">The <see cref="Int2"/> value to shift right.</param>
    /// <param name="amount">The amount to shift each element right by.</param>
    /// <returns>The result of shifting <paramref name="xy"/> right by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator >>(Int2 xy, UInt2 amount) => default;

    /// <summary>
    /// Shifts left a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="xy">The <see cref="Int2"/> value to shift left.</param>
    /// <param name="amount">The amount to shift each element left by.</param>
    /// <returns>The result of shifting <paramref name="xy"/> left by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator <<(Int2 xy, Int2 amount) => default;

    /// <summary>
    /// Shifts left a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="xy">The <see cref="Int2"/> value to shift left.</param>
    /// <param name="amount">The amount to shift each element left by.</param>
    /// <returns>The result of shifting <paramref name="xy"/> left by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator <<(Int2 xy, UInt2 amount) => default;

    /// <summary>
    /// Bitwise ands a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int2"/> value to bitwise and.</param>
    /// <param name="right">The <see cref="Int2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise and between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator &(Int2 left, Int2 right) => default;

    /// <summary>
    /// Bitwise ands a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int2"/> value to bitwise and.</param>
    /// <param name="right">The <see cref="UInt2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise and between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator &(Int2 left, UInt2 right) => default;

    /// <summary>
    /// Bitwise ors a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int2"/> value to bitwise or.</param>
    /// <param name="right">The <see cref="Int2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise or between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator |(Int2 left, Int2 right) => default;

    /// <summary>
    /// Bitwise ors a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int2"/> value to bitwise or.</param>
    /// <param name="right">The <see cref="UInt2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise or between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator |(Int2 left, UInt2 right) => default;

    /// <summary>
    /// Bitwise xors a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int2"/> value to bitwise xor.</param>
    /// <param name="right">The <see cref="Int2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise xor between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator ^(Int2 left, Int2 right) => default;

    /// <summary>
    /// Bitwise xors a <see cref="Int2"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int2"/> value to bitwise xor.</param>
    /// <param name="right">The <see cref="UInt2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise xor between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int2 operator ^(Int2 left, UInt2 right) => default;

    /// <summary>
    /// Compares two <see cref="Int2"/> values to see if they are equal.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator ==(Int2 left, Int2 right) => default;

    /// <summary>
    /// Compares two <see cref="Int2"/> values to see if they are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="Int2"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator !=(Int2 left, Int2 right) => default;
}
