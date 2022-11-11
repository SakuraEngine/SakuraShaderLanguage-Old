using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if !NET6_0_OR_GREATER
using RuntimeHelpers = SKSL.Core.NetStandard.System.Runtime.CompilerServices.RuntimeHelpers;
#endif

#nullable enable
#pragma warning disable CS0660, CS0661

namespace SKSL;

/// <inheritdoc cref="Bool3"/>
[StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
public unsafe partial struct Bool3
{
    /// <summary>
    /// A private buffer to which the undefined properties will point to.
    /// </summary>
    private static readonly void* UndefinedData = (void*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Bool3), sizeof(Bool4));

    [FieldOffset(0)]
    private int h;

    [FieldOffset(4)]
    private int j;

    [FieldOffset(8)]
    private int k;

    /// <summary>
    /// Gets a reference to a specific component in the current <see cref="Bool3"/> instance.
    /// </summary>
    /// <param name="i">The index of the component to access.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref bool this[int i] => ref *(bool*)UndefinedData;

    /// <summary>
    /// Gets a <see cref="Bool3"/> value with all components set to <see langword="false"/>.
    /// </summary>
    public static Bool3 False => false;

    /// <summary>
    /// Gets a <see cref="Bool3"/> value with all components set to <see langword="true"/>.
    /// </summary>
    public static Bool3 True => true;

    /// <summary>
    /// Gets a <see cref="Bool3"/> value with the <see cref="X"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool3 TrueX => new(true, false, false);

    /// <summary>
    /// Gets a <see cref="Bool3"/> value with the <see cref="Y"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool3 TrueY => new(false, true, false);

    /// <summary>
    /// Gets a <see cref="Bool3"/> value with the <see cref="Z"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool3 TrueZ => new(false, false, true);

    /// <summary>
    /// Gets a <see cref="Bool3"/> value with the <see cref="x"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool3 Truex => new(true, false, false);

    /// <summary>
    /// Gets a <see cref="Bool3"/> value with the <see cref="y"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool3 Truey => new(false, true, false);

    /// <summary>
    /// Gets a <see cref="Bool3"/> value with the <see cref="z"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool3 Truez => new(false, false, true);

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
    /// Gets a reference to the <see cref="bool"/> value representing the <c>Z</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool Z => ref Unsafe.As<int, bool>(ref this.k);

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 XZ => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 YZ => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 ZX => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 ZY => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 ZZ => ref *(Bool2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 XXZ => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 XYZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 XZX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 XZY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 XZZ => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 YXZ => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 YYZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 YZX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 YZY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 YZZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ZXX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ZXY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ZXZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ZYX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ZYY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ZYZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ZZX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ZZY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ZZZ => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXXZ => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXZZ => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYXZ => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZZZ => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXXZ => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXZZ => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYXZ => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZZZ => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="bool"/> value representing the <c>B</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool B => ref Unsafe.As<int, bool>(ref this.k);

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 RB => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 GB => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 BR => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 BG => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 BB => ref *(Bool2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 RRB => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 RGB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 RBR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 RBG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 RBB => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 GRB => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 GGB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 GBR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 GBG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 GBB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 BRR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 BRG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 BRB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 BGR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 BGG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 BGB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 BBR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 BBG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 BBB => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRRB => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRBB => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGRB => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGBB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBRB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBBB => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRRB => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRBB => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGRB => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGBB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBRB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBBB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRRB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRBB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGRB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGBB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBRB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBBB => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="bool"/> value representing the <c>z</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool z => ref Unsafe.As<int, bool>(ref this.k);

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 xz => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 yz => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 zx => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 zy => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 zz => ref *(Bool2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 xxz => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 xyz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 xzx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 xzy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 xzz => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 yxz => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 yyz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 yzx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 yzy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 yzz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 zxx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 zxy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 zxz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 zyx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 zyy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 zyz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 zzx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 zzy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 zzz => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxxz => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxzz => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyxz => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzzz => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxxz => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxzz => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyxz => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzzz => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="bool"/> value representing the <c>b</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool b => ref Unsafe.As<int, bool>(ref this.k);

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 rb => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 gb => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 br => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 bg => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 bb => ref *(Bool2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 rrb => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 rgb => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 rbr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 rbg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 rbb => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 grb => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ggb => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 gbr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 gbg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 gbb => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 brr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 brg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 brb => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 bgr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 bgg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 bgb => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 bbr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 bbg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 bbb => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrrb => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrgb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrbb => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgrb => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rggb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgbb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbrb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbgr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbgg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbgb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbbb => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grrb => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grgb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grbb => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggrb => ref *(Bool4*)UndefinedData;

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

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gggb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggbb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbrb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbgr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbgg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbgb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbbb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brrb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brgr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brgg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brgb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brbb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgrb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bggr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bggg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bggb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgbb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbrb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbgr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbgg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbgb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbbb => ref *(Bool4*)UndefinedData;

#if !SOURCE_GENERATOR

    /// <inheritdoc/>
    public override readonly string ToString()
    {
#if NET6_0_OR_GREATER
        return string.Create(null, stackalloc char[32], $"<{this.h != 0}, {this.j != 0}, {this.k != 0}>");
#else
        return $"<{this.h != 0}, {this.j != 0}, {this.k != 0}>";
#endif
    }

#endif

    /// <summary>
    /// Negates a <see cref="Bool3"/> value.
    /// </summary>
    /// <param name="hjk">The <see cref="Bool3"/> value to negate.</param>
    /// <returns>The negated value of <paramref name="hjk"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator !(Bool3 hjk) => default;

    /// <summary>
    /// Ands two <see cref="Bool3"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Bool3"/> value to and.</param>
    /// <param name="right">The <see cref="Bool3"/> value to combine.</param>
    /// <returns>The result of performing the bitwise and between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator &(Bool3 left, Bool3 right) => default;

    /// <summary>
    /// Ors two <see cref="Bool3"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Bool3"/> value to or.</param>
    /// <param name="right">The <see cref="Bool3"/> value to combine.</param>
    /// <returns>The result of performing the or between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator |(Bool3 left, Bool3 right) => default;

    /// <summary>
    /// Xors two <see cref="Bool3"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Bool3"/> value to xor.</param>
    /// <param name="right">The <see cref="Bool3"/> value to combine.</param>
    /// <returns>The result of performing the xor between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator ^(Bool3 left, Bool3 right) => default;

    /// <summary>
    /// Compares two <see cref="Bool3"/> values to see if they are equal.
    /// </summary>
    /// <param name="left">The first <see cref="Bool3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Bool3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator ==(Bool3 left, Bool3 right) => default;

    /// <summary>
    /// Compares two <see cref="Bool3"/> values to see if they are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="Bool3"/> value to compare.</param>
    /// <param name="right">The second <see cref="Bool3"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool3 operator !=(Bool3 left, Bool3 right) => default;
}
