using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if !NET6_0_OR_GREATER
using RuntimeHelpers = SKSL.Core.NetStandard.System.Runtime.CompilerServices.RuntimeHelpers;
#endif

#nullable enable
#pragma warning disable CS0660, CS0661

namespace SKSL;

/// <inheritdoc cref="Bool4"/>
[StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
public unsafe partial struct Bool4
{
    /// <summary>
    /// A private buffer to which the undefined properties will point to.
    /// </summary>
    private static readonly void* UndefinedData = (void*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Bool4), sizeof(Bool4));

    [FieldOffset(0)]
    private int h;

    [FieldOffset(4)]
    private int j;

    [FieldOffset(8)]
    private int k;

    [FieldOffset(12)]
    private int l;

    /// <summary>
    /// Gets a reference to a specific component in the current <see cref="Bool4"/> instance.
    /// </summary>
    /// <param name="i">The index of the component to access.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref bool this[int i] => ref *(bool*)UndefinedData;

    /// <summary>
    /// Gets a <see cref="Bool4"/> value with all components set to <see langword="false"/>.
    /// </summary>
    public static Bool4 False => false;

    /// <summary>
    /// Gets a <see cref="Bool4"/> value with all components set to <see langword="true"/>.
    /// </summary>
    public static Bool4 True => true;

    /// <summary>
    /// Gets a <see cref="Bool4"/> value with the <see cref="X"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool4 TrueX => new(true, false, false, false);

    /// <summary>
    /// Gets a <see cref="Bool4"/> value with the <see cref="Y"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool4 TrueY => new(false, true, false, false);

    /// <summary>
    /// Gets a <see cref="Bool4"/> value with the <see cref="Z"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool4 TrueZ => new(false, false, true, false);

    /// <summary>
    /// Gets a <see cref="Bool4"/> value with the <see cref="W"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool4 TrueW => new(false, false, false, true);

    /// <summary>
    /// Gets a <see cref="Bool4"/> value with the <see cref="x"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool4 Truex => new(true, false, false, false);

    /// <summary>
    /// Gets a <see cref="Bool4"/> value with the <see cref="y"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool4 Truey => new(false, true, false, false);

    /// <summary>
    /// Gets a <see cref="Bool4"/> value with the <see cref="z"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool4 Truez => new(false, false, true, false);

    /// <summary>
    /// Gets a <see cref="Bool4"/> value with the <see cref="w"/> component set to <see langword="true"/>, and the others to <see langword="false"/>.
    /// </summary>
    public static Bool4 Truew => new(false, false, false, true);

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
    /// Gets a reference to the <see cref="bool"/> value representing the <c>W</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool W => ref Unsafe.As<int, bool>(ref this.l);

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 XW => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 YW => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 ZW => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 WX => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 WY => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 WZ => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 WW => ref *(Bool2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 XXW => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 XYW => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 XZW => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 XWX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 XWY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 XWZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 XWW => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 YXW => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 YYW => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 YZW => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 YWX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 YWY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 YWZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 YWW => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ZXW => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ZYW => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ZZW => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ZWX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ZWY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ZWZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ZWW => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 WXX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 WXY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 WXZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 WXW => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 WYX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 WYY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 WYZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 WYW => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 WZX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 WZY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 WZZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 WZW => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 WWX => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 WWY => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 WWZ => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 WWW => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXXW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXYW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XXWW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYXW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYYW => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 XYZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 XYWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XYWW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZXW => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 XZYW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 XZWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XZWW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWXW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 XWYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWYW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 XWZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 XWWW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXXW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXYW => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 YXZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 YXWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YXWW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYXW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYYW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YYWW => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 YZXW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZYW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 YZWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YZWW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 YWXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWXW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWYW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 YWZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 YWWW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXXW => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ZXYW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ZXWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZXWW => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ZYXW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYYW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ZYWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZYWW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZXW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZYW => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZZWW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ZWXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWXW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ZWYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWYW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ZWWW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXXW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 WXYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXYW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 WXZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WXWW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 WYXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYXW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYYW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 WYZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WYWW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 WZXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZXW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 WZYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZYW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WZWW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWXX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWXY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWXZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWXW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWYX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWYY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWYZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWYW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWZX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWZY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWZZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWZW => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWWX => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWWY => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWWZ => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 WWWW => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="bool"/> value representing the <c>A</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool A => ref Unsafe.As<int, bool>(ref this.l);

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 RA => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 GA => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 BA => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 AR => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 AG => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 AB => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 AA => ref *(Bool2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 RRA => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 RGA => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 RBA => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 RAR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 RAG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 RAB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 RAA => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 GRA => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 GGA => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 GBA => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 GAR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 GAG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 GAB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 GAA => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 BRA => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 BGA => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 BBA => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 BAR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 BAG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 BAB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 BAA => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ARR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ARG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ARB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ARA => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 AGR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 AGG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 AGB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 AGA => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ABR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ABG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ABB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ABA => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 AAR => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 AAG => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 AAB => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 AAA => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRRA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRGA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RRAA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGRA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGGA => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 RGBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 RGAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RGAA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBRA => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 RBGA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 RBAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RBAA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RARR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RARG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RARB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RARA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RAGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RAGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 RAGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RAGA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RABR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 RABG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RABB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RABA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RAAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RAAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RAAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 RAAA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRRA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRGA => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 GRBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 GRAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GRAA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGRA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGGA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GGAA => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 GBRA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBGA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 GBAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GBAA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GARR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GARG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 GARB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GARA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GAGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GAGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GAGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GAGA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 GABR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GABG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GABB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GABA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GAAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GAAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GAAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 GAAA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRRA => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 BRGA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 BRAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BRAA => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 BGRA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGGA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 BGAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BGAA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBRA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBGA => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BBAA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BARR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 BARG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BARB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BARA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 BAGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BAGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BAGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BAGA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BABR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BABG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BABB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BABA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BAAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BAAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BAAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 BAAA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARRB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARRA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ARGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARGA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ARBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARBB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ARAA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 AGRB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGRA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGGA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 AGBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGBB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AGAA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABRR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ABRG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABRB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABRA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ABGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABGA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABBR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABBG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABBB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABBA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ABAA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AARR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AARG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AARB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AARA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AAGR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AAGG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AAGB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AAGA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AABR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AABG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AABB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AABA => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AAAR => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AAAG => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AAAB => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 AAAA => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="bool"/> value representing the <c>w</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool w => ref Unsafe.As<int, bool>(ref this.l);

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 xw => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 yw => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 zw => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 wx => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 wy => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 wz => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 ww => ref *(Bool2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 xxw => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 xyw => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 xzw => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 xwx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 xwy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 xwz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 xww => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 yxw => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 yyw => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 yzw => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ywx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ywy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 ywz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 yww => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 zxw => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 zyw => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 zzw => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 zwx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 zwy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 zwz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 zww => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 wxx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 wxy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 wxz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 wxw => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 wyx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 wyy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 wyz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 wyw => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 wzx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 wzy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 wzz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 wzw => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 wwx => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 wwy => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 wwz => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 www => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxxw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxyw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xxww => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyxw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyyw => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 xyzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xywx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xywy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 xywz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xyww => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzxw => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 xzyw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 xzwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xzww => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwxw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 xwyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwyw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 xwzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="x"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 xwww => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxxw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxyw => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 yxzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 yxwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yxww => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyxw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyyw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yywx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yywy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yywz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yyww => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 yzxw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzyw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 yzwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 yzww => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ywxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywxw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywyw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ywzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="y"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ywww => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxxw => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 zxyw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 zxwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zxww => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 zyxw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyyw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 zywx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zywy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zywz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zyww => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzxw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzyw => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zzww => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 zwxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwxw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 zwyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwyw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="z"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 zwww => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxxw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 wxyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxyw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 wxzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="x"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wxww => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 wyxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyxw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyyw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 wyzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wywx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wywy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wywz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="y"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wyww => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 wzxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzxw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 wzyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzyw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="z"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wzww => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwxx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwxy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwxz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="x"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwxw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwyx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwyy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwyz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="y"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwyw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwzx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwzy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwzz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="z"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwzw => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="x"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwwx => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="y"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwwy => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="z"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwwz => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="w"/>, <see cref="w"/>, <see cref="w"/>, <see cref="w"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 wwww => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="bool"/> value representing the <c>a</c> component.
    /// </summary>
    [UnscopedRef]
    public ref bool a => ref Unsafe.As<int, bool>(ref this.l);

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 ra => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 ga => ref *(Bool2*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 ba => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 ar => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 ag => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool2 ab => ref *(Bool2*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool2 aa => ref *(Bool2*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 rra => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 rga => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 rba => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 rar => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 rag => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 rab => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 raa => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 gra => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 gga => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 gba => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 gar => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 gag => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 gab => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 gaa => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 bra => ref *(Bool3*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 bga => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 bba => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 bar => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 bag => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 bab => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 baa => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 arr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 arg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 arb => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 ara => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 agr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 agg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 agb => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 aga => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 abr => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool3 abg => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 abb => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 aba => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 aar => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 aag => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 aab => ref *(Bool3*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool3 aaa => ref *(Bool3*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrra => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrga => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rrab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rraa => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgra => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgga => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 rgba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 rgab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rgaa => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbra => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 rbga => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 rbag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rbaa => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rarr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rarg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rarb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rara => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ragr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ragg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 ragb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 raga => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rabr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 rabg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 rabb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 raba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 raar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 raag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 raab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="r"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 raaa => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grra => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grga => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 grba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 grag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 grab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 graa => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggra => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggga => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 ggaa => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 gbra => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbga => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 gbar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gbaa => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 garr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 garg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 garb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gara => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gagr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gagg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gagb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gaga => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 gabr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gabg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gabb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gaba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gaar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gaag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gaab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="g"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 gaaa => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brra => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 brga => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 brag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 brab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 braa => ref *(Bool4*)UndefinedData;

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
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 bgra => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgga => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 bgar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bgaa => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbra => ref *(Bool4*)UndefinedData;

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
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbga => ref *(Bool4*)UndefinedData;

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

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bbaa => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 barr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 barg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 barb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bara => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 bagr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bagg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 bagb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 baga => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 babr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 babg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 babb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 baba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 baar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 baag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 baab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="b"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 baaa => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arrb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arra => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 argr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 argg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 argb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arga => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 arbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arbb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 arab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="r"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 araa => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 agrb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agra => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aggr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aggg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aggb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agga => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 agbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agbb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="g"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 agaa => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abrr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 abrg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abrb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abra => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public ref Bool4 abgr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abgg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abgb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abga => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abbr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abbg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abbb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="b"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 abaa => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aarr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aarg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aarb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="r"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aara => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aagr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aagg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aagb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="g"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aaga => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aabr => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aabg => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aabb => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="b"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aaba => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="r"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aaar => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="g"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aaag => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="b"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aaab => ref *(Bool4*)UndefinedData;

    /// <summary>
    /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="a"/>, <see cref="a"/>, <see cref="a"/>, <see cref="a"/>.
    /// </summary>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    [UnscopedRef]
    public readonly ref readonly Bool4 aaaa => ref *(Bool4*)UndefinedData;

#if !SOURCE_GENERATOR

    /// <inheritdoc/>
    public override readonly string ToString()
    {
#if NET6_0_OR_GREATER
        return string.Create(null, stackalloc char[32], $"<{this.h != 0}, {this.j != 0}, {this.k != 0}, {this.l != 0}>");
#else
        return $"<{this.h != 0}, {this.j != 0}, {this.k != 0}, {this.l != 0}>";
#endif
    }

#endif

    /// <summary>
    /// Negates a <see cref="Bool4"/> value.
    /// </summary>
    /// <param name="hjkl">The <see cref="Bool4"/> value to negate.</param>
    /// <returns>The negated value of <paramref name="hjkl"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator !(Bool4 hjkl) => default;

    /// <summary>
    /// Ands two <see cref="Bool4"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Bool4"/> value to and.</param>
    /// <param name="right">The <see cref="Bool4"/> value to combine.</param>
    /// <returns>The result of performing the bitwise and between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator &(Bool4 left, Bool4 right) => default;

    /// <summary>
    /// Ors two <see cref="Bool4"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Bool4"/> value to or.</param>
    /// <param name="right">The <see cref="Bool4"/> value to combine.</param>
    /// <returns>The result of performing the or between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator |(Bool4 left, Bool4 right) => default;

    /// <summary>
    /// Xors two <see cref="Bool4"/> values.
    /// </summary>
    /// <param name="left">The <see cref="Bool4"/> value to xor.</param>
    /// <param name="right">The <see cref="Bool4"/> value to combine.</param>
    /// <returns>The result of performing the xor between <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator ^(Bool4 left, Bool4 right) => default;

    /// <summary>
    /// Compares two <see cref="Bool4"/> values to see if they are equal.
    /// </summary>
    /// <param name="left">The first <see cref="Bool4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Bool4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator ==(Bool4 left, Bool4 right) => default;

    /// <summary>
    /// Compares two <see cref="Bool4"/> values to see if they are not equal.
    /// </summary>
    /// <param name="left">The first <see cref="Bool4"/> value to compare.</param>
    /// <param name="right">The second <see cref="Bool4"/> value to compare.</param>
    /// <returns>The result of comparing <paramref name="left"/> and <paramref name="right"/>.</returns>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static Bool4 operator !=(Bool4 left, Bool4 right) => default;
}
