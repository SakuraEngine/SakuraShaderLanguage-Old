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

/// <inheritdoc cref="Float4"/>
[StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
public unsafe partial struct Float4
#if NET6_0_OR_GREATER
    : ISpanFormattable
#endif
{
    /// <summary>
    /// A private buffer to which the undefined properties will point to.
    /// </summary>
    private static readonly void* UndefinedData = (void*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Float4), sizeof(Float4));

    [FieldOffset(0)]
    private float h;

    [FieldOffset(4)]
    private float j;

    [FieldOffset(8)]
    private float k;

    [FieldOffset(12)]
    private float l;

    /// <summary>
    /// Gets a reference to a specific component in the current <see cref="Float4"/> instance.
    /// </summary>
    /// <param name="i">The index of the component to access.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref float this[int i] => ref *(float*)UndefinedData;

    /// <summary>
    /// Gets a <see cref="Float4"/> value with all components set to 0.
    /// </summary>
    public static Float4 Zero => 0;

    /// <summary>
    /// Gets a <see cref="Float4"/> value with all components set to 1.
    /// </summary>
    public static Float4 One => 1;

    /// <summary>
    /// Gets a <see cref="Float4"/> value with the <see cref="X"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float4 UnitX => new(1, 0, 0, 0);

    /// <summary>
    /// Gets a <see cref="Float4"/> value with the <see cref="Y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float4 UnitY => new(0, 1, 0, 0);

    /// <summary>
    /// Gets a <see cref="Float4"/> value with the <see cref="Z"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float4 UnitZ => new(0, 0, 1, 0);

    /// <summary>
    /// Gets a <see cref="Float4"/> value with the <see cref="W"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float4 UnitW => new(0, 0, 0, 1);

    /// <summary>
    /// Gets a <see cref="Float4"/> value with the <see cref="x"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float4 Unitx => new(1, 0, 0, 0);

    /// <summary>
    /// Gets a <see cref="Float4"/> value with the <see cref="y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float4 Unity => new(0, 1, 0, 0);

    /// <summary>
    /// Gets a <see cref="Float4"/> value with the <see cref="z"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float4 Unitz => new(0, 0, 1, 0);

    /// <summary>
    /// Gets a <see cref="Float4"/> value with the <see cref="w"/> component set to 1, and the others to 0.
    /// </summary>
    public static Float4 Unitw => new(0, 0, 0, 1);

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
    /// Gets a reference to the <see cref="float"/> value representing the <c>W</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float W => ref this.l;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 XW => ref *(Float2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 YW => ref *(Float2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 ZW => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 WX => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 WY => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 WZ => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 WW => ref *(Float2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 XXW => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 XYW => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 XZW => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 XWX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 XWY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 XWZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 XWW => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 YXW => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 YYW => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 YZW => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 YWX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 YWY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 YWZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 YWW => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ZXW => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ZYW => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ZZW => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ZWX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ZWY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ZWZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ZWW => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 WXX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 WXY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 WXZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 WXW => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 WYX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 WYY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 WYZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 WYW => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 WZX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 WZY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 WZZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 WZW => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 WWX => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 WWY => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 WWZ => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 WWW => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXXW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXYW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XXWW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYXW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYYW => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 XYZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 XYWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XYWW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZXW => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 XZYW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 XZWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XZWW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWXW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 XWYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWYW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 XWZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 XWWW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXXW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXYW => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 YXZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 YXWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YXWW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYXW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYYW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YYWW => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 YZXW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZYW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 YZWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YZWW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 YWXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWXW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWYW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 YWZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 YWWW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXXW => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ZXYW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ZXWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZXWW => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ZYXW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYYW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ZYWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZYWW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZXW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZYW => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZZWW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ZWXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWXW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ZWYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWYW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ZWWW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXXW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 WXYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXYW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 WXZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WXWW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 WYXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYXW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYYW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 WYZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WYWW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 WZXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZXW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 WZYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZYW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WZWW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWXX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWXY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWXZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWXW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWYX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWYY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWYZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWYW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWZX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWZY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWZZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWZW => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWWX => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWWY => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWWZ => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 WWWW => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="float"/> value representing the <c>A</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float A => ref this.l;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 RA => ref *(Float2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 GA => ref *(Float2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 BA => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 AR => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 AG => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 AB => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 AA => ref *(Float2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 RRA => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 RGA => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 RBA => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 RAR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 RAG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 RAB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 RAA => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 GRA => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 GGA => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 GBA => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 GAR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 GAG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 GAB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 GAA => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 BRA => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 BGA => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 BBA => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 BAR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 BAG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 BAB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 BAA => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ARR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ARG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ARB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ARA => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 AGR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 AGG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 AGB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 AGA => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ABR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ABG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ABB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ABA => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 AAR => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 AAG => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 AAB => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 AAA => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRRA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRGA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RRAA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGRA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGGA => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 RGBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 RGAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RGAA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBRA => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 RBGA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 RBAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RBAA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RARR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RARG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RARB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RARA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RAGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RAGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 RAGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RAGA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RABR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 RABG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RABB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RABA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RAAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RAAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RAAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 RAAA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRRA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRGA => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 GRBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 GRAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GRAA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGRA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGGA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GGAA => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 GBRA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBGA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 GBAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GBAA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GARR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GARG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 GARB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GARA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GAGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GAGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GAGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GAGA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 GABR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GABG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GABB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GABA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GAAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GAAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GAAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 GAAA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRRA => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 BRGA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 BRAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BRAA => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 BGRA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGGA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 BGAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BGAA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBRA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBGA => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BBAA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BARR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 BARG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BARB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BARA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 BAGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BAGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BAGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BAGA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BABR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BABG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BABB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BABA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BAAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BAAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BAAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 BAAA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARRA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ARGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARGA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ARBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ARAA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 AGRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGRA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGGA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 AGBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AGAA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABRR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ABRG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABRB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABRA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ABGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABGA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABBR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABBG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABBB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABBA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ABAA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AARR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AARG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AARB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AARA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AAGR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AAGG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AAGB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AAGA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AABR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AABG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AABB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AABA => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AAAR => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AAAG => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AAAB => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 AAAA => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="float"/> value representing the <c>w</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float w => ref this.l;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 xw => ref *(Float2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 yw => ref *(Float2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 zw => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 wx => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 wy => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 wz => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 ww => ref *(Float2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 xxw => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 xyw => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 xzw => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 xwx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 xwy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 xwz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 xww => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 yxw => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 yyw => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 yzw => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ywx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ywy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 ywz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 yww => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 zxw => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 zyw => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 zzw => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 zwx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 zwy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 zwz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 zww => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 wxx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 wxy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 wxz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 wxw => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 wyx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 wyy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 wyz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 wyw => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 wzx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 wzy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 wzz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 wzw => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 wwx => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 wwy => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 wwz => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 www => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxxw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxyw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xxww => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyxw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyyw => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 xyzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xywx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xywy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 xywz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xyww => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzxw => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 xzyw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 xzwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xzww => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwxw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 xwyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwyw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 xwzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 xwww => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxxw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxyw => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 yxzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 yxwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yxww => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyxw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyyw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yywx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yywy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yywz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yyww => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 yzxw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzyw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 yzwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 yzww => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ywxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywxw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywyw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ywzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ywww => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxxw => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 zxyw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 zxwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zxww => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 zyxw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyyw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 zywx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zywy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zywz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zyww => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzxw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzyw => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zzww => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 zwxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwxw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 zwyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwyw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 zwww => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxxw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 wxyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxyw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 wxzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wxww => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 wyxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyxw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyyw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 wyzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wywx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wywy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wywz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wyww => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 wzxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzxw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 wzyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzyw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wzww => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwxx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwxy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwxz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwxw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwyx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwyy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwyz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwyw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwzx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwzy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwzz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwzw => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwwx => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwwy => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwwz => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 wwww => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="float"/> value representing the <c>a</c> component.
    /// </summary>
    [UnscopedRef]
    public ref float a => ref this.l;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 ra => ref *(Float2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 ga => ref *(Float2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 ba => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 ar => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 ag => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float2"/> value with the components <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float2 ab => ref *(Float2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float2"/> value with the components <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float2 aa => ref *(Float2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 rra => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 rga => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 rba => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 rar => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 rag => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 rab => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 raa => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 gra => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 gga => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 gba => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 gar => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 gag => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 gab => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 gaa => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 bra => ref *(Float3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 bga => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 bba => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 bar => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 bag => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 bab => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 baa => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 arr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 arg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 arb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 ara => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 agr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 agg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 agb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 aga => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 abr => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float3 abg => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 abb => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 aba => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 aar => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 aag => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 aab => ref *(Float3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float3 aaa => ref *(Float3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrra => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrga => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rrab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rraa => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgra => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgga => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 rgba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 rgab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rgaa => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbra => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 rbga => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 rbag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rbaa => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rarr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rarg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rarb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rara => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ragr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ragg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 ragb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 raga => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rabr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 rabg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 rabb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 raba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 raar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 raag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 raab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 raaa => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grra => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grga => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 grba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 grag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 grab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 graa => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggra => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggga => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 ggaa => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 gbra => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbga => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 gbar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gbaa => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 garr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 garg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 garb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gara => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gagr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gagg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gagb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gaga => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 gabr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gabg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gabb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gaba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gaar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gaag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gaab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 gaaa => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brra => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 brga => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 brag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 brab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 braa => ref *(Float4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 bgra => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgga => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 bgar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bgaa => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbra => ref *(Float4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbga => ref *(Float4*)UndefinedData;

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

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bbaa => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 barr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 barg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 barb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bara => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 bagr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bagg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 bagb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 baga => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 babr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 babg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 babb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 baba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 baar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 baag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 baab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 baaa => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arra => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 argr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 argg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 argb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arga => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 arbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 arab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 araa => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 agrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agra => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aggr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aggg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aggb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agga => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 agbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 agaa => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abrr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 abrg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abrb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abra => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Float4 abgr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abgg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abgb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abga => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abbr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abbg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abbb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 abaa => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aarr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aarg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aarb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aara => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aagr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aagg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aagb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aaga => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aabr => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aabg => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aabb => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aaba => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aaar => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aaag => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aaab => ref *(Float4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Float4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Float4 aaaa => ref *(Float4*)UndefinedData;

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
    /// Negates a <see cref="Float4"/> value.
    /// </summary>
    /// <param name="hjkl">The <see cref="Float4"/> value to negate.</param>
    /// <returns>The negated value of <paramref name="hjkl"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float4 operator -(Float4 hjkl) => default;

    /// <summary>
    /// Sums two <see cref="Float4"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to sum.</param>
    /// <param name="right">The second <see cref="Float4"/> value to sum.</param>
    /// <returns>The result of adding <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float4 operator +(Float4 left, Float4 right) => default;

    /// <summary>
    /// Divides two <see cref="Float4"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to divide.</param>
    /// <param name="right">The second <see cref="Float4"/> value to divide.</param>
    /// <returns>The result of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float4 operator /(Float4 left, Float4 right) => default;

    /// <summary>
    /// Calculates the remainder of the division between two <see cref="Float4"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to divide.</param>
    /// <param name="right">The second <see cref="Float4"/> value to divide.</param>
    /// <returns>The remainder of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float4 operator %(Float4 left, Float4 right) => default;

    /// <summary>
    /// Multiplies two <see cref="Float4"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to multiply.</param>
    /// <param name="right">The second <see cref="Float4"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float4 operator *(Float4 left, Float4 right) => default;

    /// <summary>
    /// Multiplies a pair of <see cref="Float4"/> and <see cref="float"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Float4"/> value to multiply.</param>
    /// <param name="right">The <see cref="float"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float4 operator *(Float4 left, float right) => default;

    /// <summary>
    /// Multiplies a pair of <see cref="float"/> and <see cref="Float4"/> values.
    /// </summary>
    /// <param name="left">The <see cref="float"/> value to multiply.</param>
    /// <param name="right">The <see cref="Float4"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float4 operator *(float left, Float4 right) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Float4 input value.</param>
    /// <param name="y">The second Float4x1 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Float4, Float4x1)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static float operator *(Float4 x, Float4x1 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Float4 input value.</param>
    /// <param name="y">The second Float4x2 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Float4, Float4x2)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Float2 operator *(Float4 x, Float4x2 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Float4 input value.</param>
    /// <param name="y">The second Float4x3 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Float4, Float4x3)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Float3 operator *(Float4 x, Float4x3 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Float4 input value.</param>
    /// <param name="y">The second Float4x4 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Float4, Float4x4)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Float4 operator *(Float4 x, Float4x4 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Float4x4 input value.</param>
    /// <param name="y">The second Float4 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Float4x4, Float4)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Float4 operator *(Float4x4 x, Float4 y) => default;

    /// <summary>
    /// Subtracts two <see cref="Float4"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to subtract.</param>
    /// <param name="right">The second <see cref="Float4"/> value to subtract.</param>
    /// <returns>The result of subtracting <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Float4 operator -(Float4 left, Float4 right) => default;

    /// <summary>
    /// Compares two <see cref="Float4"/> values to see if the first is greater than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator >(Float4 left, Float4 right) => default;

    /// <summary>
    /// Compares two <see cref="Float4"/> values to see if the first is greater than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator >=(Float4 left, Float4 right) => default;

    /// <summary>
    /// Compares two <see cref="Float4"/> values to see if the first is lower than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator <(Float4 left, Float4 right) => default;

    /// <summary>
    /// Compares two <see cref="Float4"/> values to see if the first is lower than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator <=(Float4 left, Float4 right) => default;

    /// <summary>
    /// Compares two <see cref="Float4"/> values to see if they are equal.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator ==(Float4 left, Float4 right) => default;

    /// <summary>
    /// Compares two <see cref="Float4"/> values to see if they are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="Float4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Float4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator !=(Float4 left, Float4 right) => default;
}
