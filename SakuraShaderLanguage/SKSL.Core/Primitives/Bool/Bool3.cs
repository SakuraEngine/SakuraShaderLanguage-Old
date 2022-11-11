#pragma warning disable CS0660, CS0661

namespace SKSL;

/// <summary>
/// A <see langword="struct"/> that maps the <see langword="bool3"/> HLSL type.
/// </summary>
public partial struct Bool3
{
    /// <summary>
    /// Creates a new <see cref="Bool3"/> instance with the specified parameters.
    /// </summary>
    /// <param name="x">The value to assign to the first vector component.</param>
    /// <param name="y">The value to assign to the second vector component.</param>
    /// <param name="z">The value to assign to the third vector component.</param>
    public Bool3(bool x, bool y, bool z)
    {
        this.h = x ? 1 : 0;
        this.j = y ? 1 : 0;
        this.k = z ? 1 : 0;
    }

    /// <summary>
    /// Creates a new <see cref="Bool3"/> instance with the specified parameters.
    /// </summary>
    /// <param name="xy">The value to assign to the first and second vector components.</param>
    /// <param name="z">The value to assign to the third vector component.</param>
    public Bool3(Bool2 xy, bool z)
    {
        this.h = xy.X ? 1 : 0;
        this.j = xy.Y ? 1 : 0;
        this.k = z ? 1 : 0;
    }

    /// <summary>
    /// Creates a new <see cref="Bool3"/> instance with the specified parameters.
    /// </summary>
    /// <param name="x">The value to assign to the first vector component.</param>
    /// <param name="yz">The value to assign to the second and thirt vector components.</param>
    public Bool3(bool x, Bool2 yz)
    {
        this.k = x ? 1 : 0;
        this.j = yz.X ? 1 : 0;
        this.k = yz.Y ? 1 : 0;
    }

    /// <summary>
    /// Creates a new <see cref="Bool3"/> value with the same value for all its components.
    /// </summary>
    /// <param name="x">The value to use for the components of the new <see cref="Bool3"/> instance.</param>
    public static implicit operator Bool3(bool x) => new(x, x, x);
}