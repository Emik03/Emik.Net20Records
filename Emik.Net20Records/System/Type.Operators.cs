// <copyright file="Type.Operators.cs" company="Emik">Copyright (c) Emik. All rights reserved.</copyright>

namespace System;

/// <inheritdoc cref="Type"/>
public abstract partial class Type : SysType
{
    /// <summary>Indicates whether two <see cref="Type"/> objects are equal.</summary>
    /// <param name="left">The first object to compare.</param>
    /// <param name="right">The second object to compare.</param>
    /// <returns><see langword="true"/> if <paramref name="left"/> is equal to <paramref name="right"/>; otherwise, <see langword="false"/>.</returns>
#pragma warning disable CS0436 // Type conflicts with imported type
    public static bool operator ==(Type left, Type right) => left is null ? right is null : left.Equals(right);
#pragma warning restore CS0436 // Type conflicts with imported type

    /// <summary>Indicates whether two <see cref="Type"/> objects are equal.</summary>
    /// <param name="left">The first object to compare.</param>
    /// <param name="right">The second object to compare.</param>
    /// <returns><see langword="true"/> if <paramref name="left"/> is equal to <paramref name="right"/>; otherwise, <see langword="false"/>.</returns>
#pragma warning disable CS0436 // Type conflicts with imported type
    public static bool operator !=(Type left, Type right) => !(left == right);
#pragma warning restore CS0436 // Type conflicts with imported type
}
