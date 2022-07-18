# Emik.Net20Records

[![NuGet](https://img.shields.io/nuget/v/Emik.Net20Records.svg?style=flat)](https://nuget.org/packages/Emik.Net20Records/)
[![License](https://img.shields.io/github/license/Emik03/Emik.Net20Records.svg?style=flat)](https://github.com/Emik03/Emik.Net20Records/blob/main/LICENSE.md)

> Adds C# 9/10's record/record struct support for .NET Framework 2, 3, and 3.5.

---
## Prerequisite

This library intentionally leaves out [`System.Runtime.CompilerServices.IsExternalInit`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isexternalinit?view=net-6.0) to be able to be better integrated with other excellent polyfilling libraries such as [`Theraot.Core`](https://github.com/theraot/Theraot). Either use a package like [Manual Roemer's `IsExternalInit`](https://nuget.org/packages/IsExternalInit), or define your own within the project:

```cs
using System.ComponentModel;

namespace System.Runtime.CompilerServices;

/// <summary>Reserved to be used by the compiler for tracking metadata. This class should not be used by developers in source code.</summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class IsExternalInit
{
}
```

---
## Description

[Record types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record), introduced in C# 9 and 10 are a fantastic feature that allows for easily creating data types with lots of overriden methods that lift a lot of heavy boilerplate out of classes. The feature was originally targetted for .NET 5, but can be used in previous frameworks by polyfilling [`System.Runtime.CompilerServices.IsExternalInit`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isexternalinit?view=net-6.0).

However, prior to .NET Framework 4, the [`System.Type.op_Equality`](https://docs.microsoft.com/en-us/dotnet/api/system.type.op_equality?view=net-6.0) and [`System.Type.op_Inequality`](https://docs.microsoft.com/en-us/dotnet/api/system.type.op_equality?view=net-6.0) methods didn't exist. [Roslyn](https://github.com/dotnet/roslyn) still expects them to exist, and will therefore throw an error that this method is missing.

This library adds record and record struct functionality for old .NET Frameworks by create a wrapper class `Type` that inherits the original, and polyfilling the required `op_Equality` and `op_Inequality` static methods by calling [`System.Type.Equals(Type)`](https://docs.microsoft.com/en-us/dotnet/api/system.type.equals?view=net-6.0) which [Roslyn](https://github.com/dotnet/roslyn) scans for.

---
## Contribute

As with most [GitHub](https://github.com/) repositories, you can contribute by:
* [Creating an issue](https://github.com/Emik03/Emik.Net20Records/issues) to either address bugs, feature suggestions, or other changes.
* [Creating/reviewing pull requests](https://github.com/Emik03/Emik.Net20Records/pulls) is also welcome.
