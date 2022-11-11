using SKSL.Exceptions;

namespace SKSL;

public sealed class ReadWriteBuffer<T> : StructuredBuffer<T>
    where T : unmanaged
{
    /// <summary>
    /// Gets or sets a single <typeparamref name="T"/> value from the current writeable buffer.
    /// </summary>
    /// <param name="i">The index of the value to get or set.</param>
    /// <remarks>This API can only be used from a compute shader, and will always throw if used anywhere else.</remarks>
    public ref T this[int i] => throw new InvalidExecutionContextException($"{typeof(ReadWriteBuffer<T>)}[{typeof(int)}]");

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"ComputeSharp.ReadWriteBuffer<{typeof(T)}>";
    }
}
