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

/// <inheritdoc cref="Int3"/>
[StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
public unsafe partial struct Int3
#if NET6_0_OR_GREATER
    : ISpanFormattable
#endif
{
    /// <summary>
    /// A private buffer to which the undefined properties will point to.
    /// </summary>
    private static readonly void* UndefinedData = (void*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Int3), sizeof(Int4));

    [FieldOffset(0)]
    private int h;

    [FieldOffset(4)]
    private int j;

    [FieldOffset(8)]
    private int k;

    /// <summary>
    /// Gets a reference to a specific component in the current <see cref="Int3"/> instance.
    /// </summary>
    /// <param name="i">The index of the component to access.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref int this[int i] => ref *(int*)UndefinedData;

    /// <summary>
    /// Gets a <see cref="Int3"/> value with all components set to 0.
    /// </summary>
    public static Int3 Zero => 0;

    /// <summary>
    /// Gets a <see cref="Int3"/> value with all components set to 1.
    /// </summary>
    public static Int3 One => 1;

    /// <summary>
    /// Gets a <see cref="Int3"/> value with the <see cref="X"/> component set to 1, and the others to 0.
    /// </summary>
    public static Int3 UnitX => new(1, 0, 0);

    /// <summary>
    /// Gets a <see cref="Int3"/> value with the <see cref="Y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Int3 UnitY => new(0, 1, 0);

    /// <summary>
    /// Gets a <see cref="Int3"/> value with the <see cref="Z"/> component set to 1, and the others to 0.
    /// </summary>
    public static Int3 UnitZ => new(0, 0, 1);

    /// <summary>
    /// Gets a <see cref="Int3"/> value with the <see cref="x"/> component set to 1, and the others to 0.
    /// </summary>
    public static Int3 Unitx => new(1, 0, 0);

    /// <summary>
    /// Gets a <see cref="Int3"/> value with the <see cref="y"/> component set to 1, and the others to 0.
    /// </summary>
    public static Int3 Unity => new(0, 1, 0);

    /// <summary>
    /// Gets a <see cref="Int3"/> value with the <see cref="z"/> component set to 1, and the others to 0.
    /// </summary>
    public static Int3 Unitz => new(0, 0, 1);

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>X</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int X => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>Y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int Y => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>Z</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int Z => ref this.k;

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
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 XZ => ref *(Int2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 YZ => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 ZX => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 ZY => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 ZZ => ref *(Int2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 XXZ => ref *(Int3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 XYZ => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 XZX => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 XZY => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 XZZ => ref *(Int3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 YXZ => ref *(Int3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 YYZ => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 YZX => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 YZY => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 YZZ => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 ZXX => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 ZXY => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 ZXZ => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 ZYX => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 ZYY => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 ZYZ => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 ZZX => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 ZZY => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 ZZZ => ref *(Int3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XXXZ => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XXYZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XXZX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XXZY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XXZZ => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XYXZ => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XYYZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XYZX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XYZY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XYZZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XZXX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XZXY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XZXZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XZYX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XZYY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XZYZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XZZX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XZZY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 XZZZ => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YXXZ => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YXYZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YXZX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YXZY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YXZZ => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YYXZ => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YYYZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YYZX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YYZY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YYZZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YZXX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YZXY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YZXZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YZYX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YZYY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YZYZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YZZX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YZZY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 YZZZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZXXX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZXXY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZXXZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZXYX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZXYY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZXYZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZXZX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZXZY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZXZZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZYXX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZYXY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZYXZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZYYX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZYYY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZYYZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZYZX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZYZY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZYZZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZZXX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZZXY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZZXZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZZYX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZZYY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZZYZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZZZX => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZZZY => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ZZZZ => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>R</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int R => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>G</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int G => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>B</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int B => ref this.k;

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
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 RB => ref *(Int2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 GB => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 BR => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 BG => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 BB => ref *(Int2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 RRB => ref *(Int3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 RGB => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 RBR => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 RBG => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 RBB => ref *(Int3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 GRB => ref *(Int3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 GGB => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 GBR => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 GBG => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 GBB => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 BRR => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 BRG => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 BRB => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 BGR => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 BGG => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 BGB => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 BBR => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 BBG => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 BBB => ref *(Int3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RRRB => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RRGB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RRBR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RRBG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RRBB => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RGRB => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RGGB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RGBR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RGBG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RGBB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RBRR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RBRG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RBRB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RBGR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RBGG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RBGB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RBBR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RBBG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 RBBB => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GRRB => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GRGB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GRBR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GRBG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GRBB => ref *(Int4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GGRB => ref *(Int4*)UndefinedData;

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

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GGGB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GGBR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GGBG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GGBB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GBRR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GBRG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GBRB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GBGR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GBGG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GBGB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GBBR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GBBG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 GBBB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BRRR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BRRG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BRRB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BRGR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BRGG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BRGB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BRBR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BRBG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BRBB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BGRR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BGRG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BGRB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BGGR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BGGG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BGGB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BGBR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BGBG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BGBB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BBRR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BBRG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BBRB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BBGR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BBGG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BBGB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BBBR => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BBBG => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 BBBB => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>x</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int x => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>y</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int y => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>z</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int z => ref this.k;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 xx => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 xy => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 xz => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 yx => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 yy => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 yz => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 zx => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 zy => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 zz => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 xxx => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 xxy => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 xxz => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 xyx => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 xyy => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 xyz => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 xzx => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 xzy => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 xzz => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 yxx => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 yxy => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 yxz => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 yyx => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 yyy => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 yyz => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 yzx => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 yzy => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 yzz => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 zxx => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 zxy => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 zxz => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 zyx => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 zyy => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 zyz => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 zzx => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 zzy => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 zzz => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xxxx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xxxy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xxxz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xxyx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xxyy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xxyz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xxzx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xxzy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xxzz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xyxx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xyxy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xyxz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xyyx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xyyy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xyyz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xyzx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xyzy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xyzz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xzxx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xzxy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xzxz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xzyx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xzyy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xzyz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xzzx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xzzy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 xzzz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yxxx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yxxy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yxxz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yxyx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yxyy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yxyz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yxzx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yxzy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yxzz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yyxx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yyxy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yyxz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yyyx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yyyy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yyyz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yyzx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yyzy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yyzz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yzxx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yzxy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yzxz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yzyx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yzyy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yzyz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yzzx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yzzy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 yzzz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zxxx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zxxy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zxxz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zxyx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zxyy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zxyz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zxzx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zxzy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zxzz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zyxx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zyxy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zyxz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zyyx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zyyy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zyyz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zyzx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zyzy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zyzz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zzxx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zzxy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zzxz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zzyx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zzyy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zzyz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zzzx => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zzzy => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 zzzz => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>r</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int r => ref this.h;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>g</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int g => ref this.j;

    /// <summary>
    /// Gets a reference to the <see cref="int"/> value representing the <c>b</c> component.
    /// </summary>
    [UnscopedRef]
    public ref int b => ref this.k;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 rr => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 rg => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 rb => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 gr => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 gg => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 gb => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 br => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int2"/> value with the components <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int2 bg => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int2"/> value with the components <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int2 bb => ref *(Int2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 rrr => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 rrg => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 rrb => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 rgr => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 rgg => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 rgb => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 rbr => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 rbg => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 rbb => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 grr => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 grg => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 grb => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 ggr => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 ggg => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 ggb => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 gbr => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 gbg => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 gbb => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 brr => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 brg => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 brb => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Int3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Int3 bgr => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 bgg => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 bgb => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 bbr => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 bbg => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int3 bbb => ref *(Int3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rrrr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rrrg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rrrb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rrgr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rrgg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rrgb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rrbr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rrbg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rrbb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rgrr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rgrg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rgrb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rggr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rggg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rggb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rgbr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rgbg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rgbb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rbrr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rbrg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rbrb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rbgr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rbgg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rbgb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rbbr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rbbg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 rbbb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 grrr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 grrg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 grrb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 grgr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 grgg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 grgb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 grbr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 grbg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 grbb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ggrr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ggrg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ggrb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gggr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gggg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gggb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ggbr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ggbg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 ggbb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gbrr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gbrg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gbrb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gbgr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gbgg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gbgb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gbbr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gbbg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 gbbb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 brrr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 brrg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 brrb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 brgr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 brgg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 brgb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 brbr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 brbg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 brbb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bgrr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bgrg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bgrb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bggr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bggg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bggb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bgbr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bgbg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bgbb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bbrr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bbrg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bbrb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bbgr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bbgg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bbgb => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bbbr => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bbbg => ref *(Int4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Int4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Int4 bbbb => ref *(Int4*)UndefinedData;

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
    /// Negates a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="hjk">The <see cref="Int3"/> value to negate.</param>
    /// <returns>The negated value of <paramref name="hjk"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator -(Int3 hjk) => default;

    /// <summary>
    /// Sums two <see cref="Int3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to sum.</param>
    /// <param name="right">The second <see cref="Int3"/> value to sum.</param>
    /// <returns>The result of adding <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator +(Int3 left, Int3 right) => default;

    /// <summary>
    /// Divides two <see cref="Int3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to divide.</param>
    /// <param name="right">The second <see cref="Int3"/> value to divide.</param>
    /// <returns>The result of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator /(Int3 left, Int3 right) => default;

    /// <summary>
    /// Calculates the remainder of the division between two <see cref="Int3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to divide.</param>
    /// <param name="right">The second <see cref="Int3"/> value to divide.</param>
    /// <returns>The remainder of dividing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator %(Int3 left, Int3 right) => default;

    /// <summary>
    /// Multiplies two <see cref="Int3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to multiply.</param>
    /// <param name="right">The second <see cref="Int3"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator *(Int3 left, Int3 right) => default;

    /// <summary>
    /// Multiplies a pair of <see cref="Int3"/> and <see cref="int"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Int3"/> value to multiply.</param>
    /// <param name="right">The <see cref="int"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator *(Int3 left, int right) => default;

    /// <summary>
    /// Multiplies a pair of <see cref="int"/> and <see cref="Int3"/> values.
    /// </summary>
    /// <param name="left">The <see cref="int"/> value to multiply.</param>
    /// <param name="right">The <see cref="Int3"/> value to multiply.</param>
    /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator *(int left, Int3 right) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Int3 input value.</param>
    /// <param name="y">The second Int3x1 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Int3, Int3x1)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static int operator *(Int3 x, Int3x1 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Int3 input value.</param>
    /// <param name="y">The second Int3x2 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Int3, Int3x2)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Int2 operator *(Int3 x, Int3x2 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Int3 input value.</param>
    /// <param name="y">The second Int3x3 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Int3, Int3x3)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Int3 operator *(Int3 x, Int3x3 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Int3 input value.</param>
    /// <param name="y">The second Int3x4 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Int3, Int3x4)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Int4 operator *(Int3 x, Int3x4 y) => default;

    /// <summary>
    /// Multiplies two values using matrix math.
    /// </summary>
    /// <param name="x">The first Int3x3 input value.</param>
    /// <param name="y">The second Int3 input value.</param>
    /// <returns>The result of <paramref name="x"/> times <paramref name="y"/>. The result has the dimension <paramref name="x"/>-rows by <paramref name="y"/>-columns.</returns>
    /// <remarks>
    /// <para>This operator is equivalent to using <see cref="BuiltIn.Mul(Int3x3, Int3)"/> with the same input arguments.</para>
    /// <para>For more info, see <see href="https://docs.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-mul"/>.</para>
    /// <para>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</para>
    /// </remarks>
    [BuiltInIntrinsicName("mul", RequiresParametersMatching = true)]
    public static Int3 operator *(Int3x3 x, Int3 y) => default;

    /// <summary>
    /// Subtracts two <see cref="Int3"/> values.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to subtract.</param>
    /// <param name="right">The second <see cref="Int3"/> value to subtract.</param>
    /// <returns>The result of subtracting <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator -(Int3 left, Int3 right) => default;

    /// <summary>
    /// Compares two <see cref="Int3"/> values to see if the first is greater than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator >(Int3 left, Int3 right) => default;

    /// <summary>
    /// Compares two <see cref="Int3"/> values to see if the first is greater than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator >=(Int3 left, Int3 right) => default;

    /// <summary>
    /// Compares two <see cref="Int3"/> values to see if the first is lower than the second.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator <(Int3 left, Int3 right) => default;

    /// <summary>
    /// Compares two <see cref="Int3"/> values to see if the first is lower than or equal to the second.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator <=(Int3 left, Int3 right) => default;

    /// <summary>
    /// Bitwise negates a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="hjk">The <see cref="Int3"/> value to bitwise negate.</param>
    /// <returns>The bitwise negated value of <paramref name="hjk"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator ~(Int3 hjk) => default;

    /// <summary>
    /// Shifts right a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="hjk">The <see cref="Int3"/> value to shift right.</param>
    /// <param name="amount">The amount to shift each element right by.</param>
    /// <returns>The result of shifting <paramref name="hjk"/> right by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator >>(Int3 hjk, Int3 amount) => default;

    /// <summary>
    /// Shifts right a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="hjk">The <see cref="Int3"/> value to shift right.</param>
    /// <param name="amount">The amount to shift each element right by.</param>
    /// <returns>The result of shifting <paramref name="hjk"/> right by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator >>(Int3 hjk, UInt3 amount) => default;

    /// <summary>
    /// Shifts left a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="hjk">The <see cref="Int3"/> value to shift left.</param>
    /// <param name="amount">The amount to shift each element left by.</param>
    /// <returns>The result of shifting <paramref name="hjk"/> left by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator <<(Int3 hjk, Int3 amount) => default;

    /// <summary>
    /// Shifts left a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="hjk">The <see cref="Int3"/> value to shift left.</param>
    /// <param name="amount">The amount to shift each element left by.</param>
    /// <returns>The result of shifting <paramref name="hjk"/> left by <paramref name="amount"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator <<(Int3 hjk, UInt3 amount) => default;

    /// <summary>
    /// Bitwise ands a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int3"/> value to bitwise and.</param>
    /// <param name="right">The <see cref="Int3"/> value to combine.</param>
    /// <returns>The result of performing the bitwise and between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator &(Int3 left, Int3 right) => default;

    /// <summary>
    /// Bitwise ands a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int3"/> value to bitwise and.</param>
    /// <param name="right">The <see cref="UInt3"/> value to combine.</param>
    /// <returns>The result of performing the bitwise and between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator &(Int3 left, UInt3 right) => default;

    /// <summary>
    /// Bitwise ors a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int3"/> value to bitwise or.</param>
    /// <param name="right">The <see cref="Int3"/> value to combine.</param>
    /// <returns>The result of performing the bitwise or between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator |(Int3 left, Int3 right) => default;

    /// <summary>
    /// Bitwise ors a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int3"/> value to bitwise or.</param>
    /// <param name="right">The <see cref="UInt3"/> value to combine.</param>
    /// <returns>The result of performing the bitwise or between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator |(Int3 left, UInt3 right) => default;

    /// <summary>
    /// Bitwise xors a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int3"/> value to bitwise xor.</param>
    /// <param name="right">The <see cref="Int3"/> value to combine.</param>
    /// <returns>The result of performing the bitwise xor between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator ^(Int3 left, Int3 right) => default;

    /// <summary>
    /// Bitwise xors a <see cref="Int3"/> value.
    /// </summary>
    /// <param name="left">The <see cref="Int3"/> value to bitwise xor.</param>
    /// <param name="right">The <see cref="UInt3"/> value to combine.</param>
    /// <returns>The result of performing the bitwise xor between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Int3 operator ^(Int3 left, UInt3 right) => default;

    /// <summary>
    /// Compares two <see cref="Int3"/> values to see if they are equal.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator ==(Int3 left, Int3 right) => default;

    /// <summary>
    /// Compares two <see cref="Int3"/> values to see if they are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="Int3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Int3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator !=(Int3 left, Int3 right) => default;
}
