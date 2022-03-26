// <copyright file="ProtectedMethodFromHandleTypeException.cs" company="Emik">Copyright (c) Emik. All rights reserved.</copyright>

namespace Emik.Net20Records;

/// <summary>The <see cref="Exception"/> type thrown due to an unresolvable edgecase in which calling a protected method in <see cref="Type"/> is not possible with an instance that came from the return of a <see cref="Type.GetTypeFromHandle"/>.</summary>
/// <remarks><para>For more information, see <see cref="DefaultMessage"/>.</para></remarks>
[Serializable]
public sealed class ProtectedMethodFromHandleTypeException : Exception
{
#pragma warning disable CS0436 // Type conflicts with imported type
    private const string DefaultMessage = $"A protected method in {nameof(Type)} was invoked with an instance that came from the return of a {nameof(Type.GetTypeFromHandle)}. Unfortunately, this is not supported as the {nameof(Type)} wrapper is unable to access said method to return for its value, and it is required that the method returns {nameof(Type)} to be compliant with record types. Until highly unsafe upcasts can be figured out, this will have to remain unimplemented.";
#pragma warning restore CS0436 // Type conflicts with imported type

    /// <summary>Initializes a new instance of the <see cref="ProtectedMethodFromHandleTypeException"/> class.</summary>
    internal ProtectedMethodFromHandleTypeException()
        : this(DefaultMessage)
    {
    }

    private ProtectedMethodFromHandleTypeException(string expression)
        : this(expression, null)
    {
    }

    private ProtectedMethodFromHandleTypeException(string expression, Exception error)
        : base(expression, error)
    {
    }

    private ProtectedMethodFromHandleTypeException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
