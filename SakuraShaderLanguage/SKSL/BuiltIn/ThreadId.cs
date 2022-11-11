using SKSL.Exceptions;

namespace SKSL;

/// <summary>
/// A <see langword="class"/> that indicates the ids of a given GPU thread running a compute shader.
/// That is, it enables a shader to access info on the current iteration index along each axis.
/// </summary>
public static partial class ThreadID
{
    /// <summary>
    /// Gets the X id of the current thread.
    /// </summary>
    public static int X => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(X)}");

    /// <summary>
    /// Gets the Y id of the current thread.
    /// </summary>
    public static int Y => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(Y)}");

    /// <summary>
    /// Gets the Z id of the current thread.
    /// </summary>
    public static int Z => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(Z)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    public static Int2 XX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XX)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    public static Int2 XY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XY)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    public static Int2 XZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XZ)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    public static Int2 YX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YX)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    public static Int2 YY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YY)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    public static Int2 YZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YZ)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    public static Int2 ZX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZX)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    public static Int2 ZY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZY)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    public static Int2 ZZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZZ)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    public static Int3 XXX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XXX)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    public static Int3 XXY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XXY)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    public static Int3 XXZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XXZ)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    public static Int3 XYX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XYX)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    public static Int3 XYY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XYY)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    public static Int3 XYZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XYZ)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    public static Int3 XZX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XZX)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    public static Int3 XZY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XZY)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    public static Int3 XZZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(XZZ)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    public static Int3 YXX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YXX)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    public static Int3 YXY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YXY)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    public static Int3 YXZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YXZ)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    public static Int3 YYX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YYX)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    public static Int3 YYY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YYY)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    public static Int3 YYZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YYZ)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    public static Int3 YZX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YZX)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    public static Int3 YZY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YZY)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    public static Int3 YZZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(YZZ)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
    /// </summary>
    public static Int3 ZXX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZXX)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
    /// </summary>
    public static Int3 ZXY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZXY)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
    /// </summary>
    public static Int3 ZXZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZXZ)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
    /// </summary>
    public static Int3 ZYX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZYX)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
    /// </summary>
    public static Int3 ZYY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZYY)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
    /// </summary>
    public static Int3 ZYZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZYZ)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
    /// </summary>
    public static Int3 ZZX => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZZX)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
    /// </summary>
    public static Int3 ZZY => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZZY)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
    /// </summary>
    public static Int3 ZZZ => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(ZZZ)}");


    // --------------------------------------------------------------------------------------------------------------//


    /// <summary>
    /// Gets the x id of the current thread.
    /// </summary>
    public static int x => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(x)}");

    /// <summary>
    /// Gets the y id of the current thread.
    /// </summary>
    public static int y => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(y)}");

    /// <summary>
    /// Gets the z id of the current thread.
    /// </summary>
    public static int z => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(z)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    public static Int2 xx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xx)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    public static Int2 xy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xy)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    public static Int2 xz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xz)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    public static Int2 yx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yx)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    public static Int2 yy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yy)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    public static Int2 yz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yz)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    public static Int2 zx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zx)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    public static Int2 zy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zy)}");

    /// <summary>
    /// Gets an <see cref="Int2"/> value with the components <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    public static Int2 zz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zz)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    public static Int3 xxx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xxx)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    public static Int3 xxy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xxy)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    public static Int3 xxz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xxz)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    public static Int3 xyx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xyx)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    public static Int3 xyy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xyy)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    public static Int3 xyz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xyz)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    public static Int3 xzx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xzx)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    public static Int3 xzy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xzy)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="x"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    public static Int3 xzz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(xzz)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    public static Int3 yxx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yxx)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    public static Int3 yxy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yxy)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    public static Int3 yxz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yxz)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    public static Int3 yyx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yyx)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    public static Int3 yyy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yyy)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    public static Int3 yyz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yyz)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    public static Int3 yzx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yzx)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    public static Int3 yzy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yzy)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="y"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    public static Int3 yzz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(yzz)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="x"/>.
    /// </summary>
    public static Int3 zxx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zxx)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="y"/>.
    /// </summary>
    public static Int3 zxy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zxy)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="x"/>, <see cref="z"/>.
    /// </summary>
    public static Int3 zxz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zxz)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="x"/>.
    /// </summary>
    public static Int3 zyx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zyx)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="y"/>.
    /// </summary>
    public static Int3 zyy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zyy)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="y"/>, <see cref="z"/>.
    /// </summary>
    public static Int3 zyz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zyz)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="x"/>.
    /// </summary>
    public static Int3 zzx => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zzx)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="y"/>.
    /// </summary>
    public static Int3 zzy => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zzy)}");

    /// <summary>
    /// Gets an <see cref="Int3"/> value with the components <see cref="z"/>, <see cref="z"/>, <see cref="z"/>.
    /// </summary>
    public static Int3 zzz => throw new InvalidExecutionContextException($"{typeof(ThreadID)}.{nameof(zzz)}");
}