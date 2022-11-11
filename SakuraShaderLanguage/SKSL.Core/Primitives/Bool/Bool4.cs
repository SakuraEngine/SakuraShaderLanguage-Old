#pragma warning disable CS0660, CS0661

namespace SKSL;

/// <summary>
/// A <see langword="struct"/> that maps the <see langword="bool4"/> HLSL type.
/// </summary>
public partial struct Bool4
{
    /// <summary>
    /// Creates a new <see cref="Bool4"/> instance with the specified parameters.
    /// </summary>
    /// <param name="x">The value to assign to the first vector component.</param>
    /// <param name="y">The value to assign to the second vector component.</param>
    /// <param name="z">The value to assign to the third vector component.</param>
    /// <param name="w">The value to assign to the fourth vector component.</param>
    public Bool4(bool x, bool y, bool z, bool w)
    {
        this.h = x ? 1 : 0;
        this.j = y ? 1 : 0;
        this.k = z ? 1 : 0;
        this.l = w ? 1 : 0;
    }

    /// <summary>
    /// Creates a new <see cref="Bool4"/> instance with the specified parameters.
    /// </summary>
    /// <param name="xy">The value to assign to the first and second vector components.</param>
    /// <param name="z">The value to assign to the third vector component.</param>
    /// <param name="w">The value to assign to the fourth vector component.</param>
    public Bool4(Bool2 xy, bool z, bool w)
    {
        this.h = xy.X ? 1 : 0;
        this.j = xy.Y ? 1 : 0;
        this.k = z ? 1 : 0;
        this.l = w ? 1 : 0;
    }

    /// <summary>
    /// Creates a new <see cref="Bool4"/> instance with the specified parameters.
    /// </summary>
    /// <param name="x">The value to assign to the first vector component.</param>
    /// <param name="y">The value to assign to the second vector component.</param>
    /// <param name="zw">The value to assign to the third and fourth vector components.</param>
    public Bool4(bool x, bool y, Bool2 zw)
    {
        this.h = x ? 1 : 0;
        this.j = y ? 1 : 0;
        this.k = zw.X ? 1 : 0;
        this.l = zw.Y ? 1 : 0;
    }

    /// <summary>
    /// Creates a new <see cref="Bool4"/> instance with the specified parameters.
    /// </summary>
    /// <param name="xy">The value to assign to the first and second vector components.</param>
    /// <param name="zw">The value to assign to the third and fourth vector components.</param>
    public Bool4(Bool2 xy, Bool2 zw)
    {
        this.h = xy.X ? 1 : 0;
        this.j = xy.Y ? 1 : 0;
        this.k = zw.X ? 1 : 0;
        this.l = zw.Y ? 1 : 0;
    }

    /// <summary>
    /// Creates a new <see cref="Bool4"/> instance with the specified parameters.
    /// </summary>
    /// <param name="xyz">The value to assign to the first, second and third vector components.</param>
    /// <param name="w">The value to assign to the fourth vector component.</param>
    public Bool4(Bool3 xyz, bool w)
    {
        this.h = xyz.X ? 1 : 0;
        this.j = xyz.Y ? 1 : 0;
        this.k = xyz.Z ? 1 : 0;
        this.l = w ? 1 : 0;
    }

    /// <summary>
    /// Creates a new <see cref="Bool4"/> instance with the specified parameters.
    /// </summary>
    /// <param name="x">The value to assign to the first vector component.</param>
    /// <param name="yzw">The value to assign to the second, third and fourth vector components.</param>
    public Bool4(bool x, Bool3 yzw)
    {
        this.h = x ? 1 : 0;
        this.j = yzw.X ? 1 : 0;
        this.k = yzw.Y ? 1 : 0;
        this.l = yzw.Z ? 1 : 0;
    }

    /// <summary>
    /// Creates a new <see cref="Bool4"/> value with the same value for all its components.
    /// </summary>
    /// <param name="x">The value to use for the components of the new <see cref="Bool4"/> instance.</param>
    public static implicit operator Bool4(bool x) => new(x, x, x, x);
}