﻿using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if !NET6_0_OR_GREATER
using RuntimeHelpers = SKSL.Core.NetStandard.System.Runtime.CompilerServices.RuntimeHelpers;
#endif

#nullable enable
#pragma warning disable CS0660, CS0661

namespace SKSL;

/// <inheritdoc cref="Bool2"/>
[StructLayout(LayoutKind.Explicit, Size = 8, Pack = 4)]
public unsafe partial struct Bool2
{
    /// <summary>
    /// A private buffer to which the undefined properties will point to.
    /// </summary>
    private static readonly void* UndefinedData = (void*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Bool2), sizeof(Bool4));

    [FieldOffset(0)]
    private int h;

    [FieldOffset(4)]
    private int j;

    /// <summary>
    /// Gets a reference to a specific component in the current <see cref="Bool2"/> instance.
    /// </summary>
    /// <param name="i">The index of the component to access.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref bool this[int i] => ref *(bool*)UndefinedData;

    /// <summary>
    /// Gets a <see cref="Bool2"/> value with all components set to <see langword="false"/>.
    /// </summary>
    public static Bool2 False => false;

    /// <summary>
    /// Gets a <see cref="Bool2"/> value with all components set to <see langword="true"/>.
    /// </summary>
    public static Bool2 True => true;

    /// <summary>
    /// Gets a <see cref="Bool2"/> value with the <see cref="X"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool2 TrueX => new(true, false);

    /// <summary>
    /// Gets a <see cref="Bool2"/> value with the <see cref="Y"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool2 TrueY => new(false, true);

    /// <summary>
    /// Gets a <see cref="Bool2"/> value with the <see cref="x"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool2 Truex => new(true, false);

    /// <summary>
    /// Gets a <see cref="Bool2"/> value with the <see cref="y"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool2 Truey => new(false, true);

    /// <summary>
    /// Gets a reference to the <see cref="bool"/> value representing the <c>X</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool X => ref Unsafe.As<int, bool>(ref this.h);

    /// <summary>
    /// Gets a reference to the <see cref="bool"/> value representing the <c>Y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool Y => ref Unsafe.As<int, bool>(ref this.j);

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 XX => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 XY => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 YX => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 YY => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 XXX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 XXY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 XYX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 XYY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 YXX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 YXY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 YYX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 YYY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="bool"/> value representing the <c>R</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool R => ref Unsafe.As<int, bool>(ref this.h);

    /// <summary>
    /// Gets a reference to the <see cref="bool"/> value representing the <c>G</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool G => ref Unsafe.As<int, bool>(ref this.j);

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 RR => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 RG => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 GR => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 GG => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 RRR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 RRG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 RGR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 RGG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 GRR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 GRG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 GGR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 GGG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="bool"/> value representing the <c>x</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool x => ref Unsafe.As<int, bool>(ref this.h);

    /// <summary>
    /// Gets a reference to the <see cref="bool"/> value representing the <c>y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool y => ref Unsafe.As<int, bool>(ref this.j);

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 xx => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 xy => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 yx => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 yy => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 xxx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 xxy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 xyx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 xyy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 yxx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 yxy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 yyx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 yyy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="bool"/> value representing the <c>r</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool r => ref Unsafe.As<int, bool>(ref this.h);

    /// <summary>
    /// Gets a reference to the <see cref="bool"/> value representing the <c>g</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool g => ref Unsafe.As<int, bool>(ref this.j);

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 rr => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 rg => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 gr => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 gg => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 rrr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 rrg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 rgr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 rgg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 grr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 grg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ggr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ggg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrgr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrgg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rggr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rggg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grgr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grgg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gggr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gggg => ref *(Bool4*)UndefinedData;

#if !SOURCE_GENERATOR

    /// <inheritdoc/>
    public override readonly string ToString()
    {
#if NET6_0_OR_GREATER
        return string.Create(null, stackalloc char[32], $"<{this.h != 0}, {this.j != 0}>");
#else
        return $"<{this.h != 0}, {this.j != 0}>";
#endif
    }

#endif

    /// <summary>
    /// Negates a <see cref="Bool2"/> value.
    /// </summary>
    /// <param name="hj">The <see cref="Bool2"/> value to negate.</param>
    /// <returns>The negated value of <paramref name="hj"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator !(Bool2 hj) => default;

    /// <summary>
    /// Ands two <see cref="Bool2"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Bool2"/> value to and.</param>
    /// <param name="right">The <see cref="Bool2"/> value to combine.</param>
    /// <returns>The result of performing the bitwise and between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator &(Bool2 left, Bool2 right) => default;

    /// <summary>
    /// Ors two <see cref="Bool2"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Bool2"/> value to or.</param>
    /// <param name="right">The <see cref="Bool2"/> value to combine.</param>
    /// <returns>The result of performing the or between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator |(Bool2 left, Bool2 right) => default;

    /// <summary>
    /// Xors two <see cref="Bool2"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Bool2"/> value to xor.</param>
    /// <param name="right">The <see cref="Bool2"/> value to combine.</param>
    /// <returns>The result of performing the xor between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator ^(Bool2 left, Bool2 right) => default;

    /// <summary>
    /// Compares two <see cref="Bool2"/> values to see if they are equal.
    /// </summary>
    /// <param name="left">The first <see cref="Bool2"/> value to compare.</param>
    /// <param name="right">The second <see cref="Bool2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator ==(Bool2 left, Bool2 right) => default;

    /// <summary>
    /// Compares two <see cref="Bool2"/> values to see if they are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="Bool2"/> value to compare.</param>
    /// <param name="right">The second <see cref="Bool2"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool2 operator !=(Bool2 left, Bool2 right) => default;
}
