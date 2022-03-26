// <copyright file="Type.cs" company="Emik">Copyright (c) Emik. All rights reserved.</copyright>

namespace System;

/// <summary>Your favorite Type class, but now with op_Equality and op_Inequality polyfilled methods.</summary>
public abstract partial class Type : SysType
{
    /// <inheritdoc/>
    public static new readonly MemberFilter FilterAttribute = SysType.FilterAttribute;

    /// <inheritdoc/>
    public static new readonly MemberFilter FilterName = SysType.FilterName;

    /// <inheritdoc/>
    public static new readonly MemberFilter FilterNameIgnoreCase = SysType.FilterNameIgnoreCase;

    /// <inheritdoc/>
    public static new readonly object Missing = SysType.Missing;

    /// <inheritdoc/>
    public static new readonly char Delimiter = SysType.Delimiter;

    /// <inheritdoc/>
    public static new readonly SysType[] EmptyTypes = SysType.EmptyTypes;

    /// <inheritdoc/>
    public override MemberTypes MemberType => base.MemberType;

    /// <inheritdoc/>
    public new SysType DeclaringType => base.DeclaringType;

    /// <inheritdoc/>
    public override MethodBase DeclaringMethod => base.DeclaringMethod;

    /// <inheritdoc/>
    public new SysType ReflectedType => base.ReflectedType;

    /// <inheritdoc/>
    public override StructLayoutAttribute StructLayoutAttribute => base.StructLayoutAttribute;

    /// <inheritdoc/>
    public abstract override Guid GUID { get; }

    /// <inheritdoc/>
    public static new Binder DefaultBinder => SysType.DefaultBinder;

    /// <inheritdoc/>
    public abstract override Module Module { get; }

    /// <inheritdoc/>
    public abstract override Assembly Assembly { get; }

    /// <inheritdoc/>
    public override RuntimeTypeHandle TypeHandle => base.TypeHandle;

    /// <inheritdoc/>
    public abstract override string FullName { get; }

    /// <inheritdoc/>
    public abstract override string Namespace { get; }

    /// <inheritdoc/>
    public abstract override string AssemblyQualifiedName { get; }

    /// <inheritdoc/>
    public abstract override SysType BaseType { get; }

    /// <inheritdoc/>
    public new ConstructorInfo TypeInitializer => base.TypeInitializer;

    /// <inheritdoc/>
    public new bool IsNested => base.IsNested;

    /// <inheritdoc/>
    public new TypeAttributes Attributes => base.Attributes;

    /// <inheritdoc/>
    public override GenericParameterAttributes GenericParameterAttributes => base.GenericParameterAttributes;

    /// <inheritdoc/>
    public new bool IsVisible => base.IsVisible;

    /// <inheritdoc/>
    public new bool IsNotPublic => base.IsNotPublic;

    /// <inheritdoc/>
    public new bool IsPublic => base.IsPublic;

    /// <inheritdoc/>
    public new bool IsNestedPublic => base.IsNestedPublic;

    /// <inheritdoc/>
    public new bool IsNestedPrivate => base.IsNestedPrivate;

    /// <inheritdoc/>
    public new bool IsNestedFamily => base.IsNestedFamily;

    /// <inheritdoc/>
    public new bool IsNestedAssembly => base.IsNestedAssembly;

    /// <inheritdoc/>
    public new bool IsNestedFamANDAssem => base.IsNestedFamANDAssem;

    /// <inheritdoc/>
    public new bool IsNestedFamORAssem => base.IsNestedFamORAssem;

    /// <inheritdoc/>
    public new bool IsAutoLayout => base.IsAutoLayout;

    /// <inheritdoc/>
    public new bool IsLayoutSequential => base.IsLayoutSequential;

    /// <inheritdoc/>
    public new bool IsExplicitLayout => base.IsExplicitLayout;

    /// <inheritdoc/>
    public new bool IsClass => base.IsClass;

    /// <inheritdoc/>
    public new bool IsInterface => base.IsInterface;

    /// <inheritdoc/>
    public new bool IsValueType => base.IsValueType;

    /// <inheritdoc/>
    public new bool IsAbstract => base.IsAbstract;

    /// <inheritdoc/>
    public new bool IsSealed => base.IsSealed;

    /// <inheritdoc/>
    public new bool IsEnum => base.IsEnum;

    /// <inheritdoc/>
    public new bool IsSpecialName => base.IsSpecialName;

    /// <inheritdoc/>
    public new bool IsImport => base.IsImport;

    /// <inheritdoc/>
    public new bool IsSerializable => base.IsSerializable;

    /// <inheritdoc/>
    public new bool IsAnsiClass => base.IsAnsiClass;

    /// <inheritdoc/>
    public new bool IsUnicodeClass => base.IsUnicodeClass;

    /// <inheritdoc/>
    public new bool IsAutoClass => base.IsAutoClass;

    /// <inheritdoc/>
    public new bool IsArray => base.IsArray;

    /// <inheritdoc/>
    public override bool IsGenericType => base.IsGenericType;

    /// <inheritdoc/>
    public override bool IsGenericTypeDefinition => base.IsGenericTypeDefinition;

    /// <inheritdoc/>
    public override bool IsGenericParameter => base.IsGenericParameter;

    /// <inheritdoc/>
    public override int GenericParameterPosition => base.GenericParameterPosition;

    /// <inheritdoc/>
    public override bool ContainsGenericParameters => base.ContainsGenericParameters;

    /// <inheritdoc/>
    public new bool IsByRef => base.IsByRef;

    /// <inheritdoc/>
    public new bool IsPointer => base.IsPointer;

    /// <inheritdoc/>
    public new bool IsPrimitive => base.IsPrimitive;

    /// <inheritdoc/>
    public new bool IsCOMObject => base.IsCOMObject;

    /// <inheritdoc/>
    public new bool HasElementType => base.HasElementType;

    /// <inheritdoc/>
    public new bool IsContextful => base.IsContextful;

    /// <inheritdoc/>
    public new bool IsMarshalByRef => base.IsMarshalByRef;

    /// <inheritdoc/>
    public abstract override SysType UnderlyingSystemType { get; }

    /// <inheritdoc/>
    public new SysType GetType() => base.GetType();

    /// <inheritdoc/>
    public static new SysType GetType(string typeName, bool throwOnError, bool ignoreCase) =>  SysType.GetType(typeName, throwOnError, ignoreCase);

    /// <inheritdoc/>
    public static new SysType GetType(string typeName, bool throwOnError) =>  SysType.GetType(typeName, throwOnError);

    /// <inheritdoc/>
    public static new SysType GetType(string typeName) => SysType.GetType(typeName);

    /// <inheritdoc/>
    public static new SysType ReflectionOnlyGetType(string typeName, bool throwIfNotFound, bool ignoreCase) =>  SysType.ReflectionOnlyGetType(typeName, throwIfNotFound, ignoreCase);

    /// <inheritdoc/>
    public override SysType MakePointerType() => base.MakePointerType();

    /// <inheritdoc/>
    public override SysType MakeByRefType() => base.MakeByRefType();

    /// <inheritdoc/>
    public override SysType MakeArrayType() => base.MakeArrayType();

    /// <inheritdoc/>
    public override SysType MakeArrayType(int rank) =>  base.MakeArrayType(rank);

    /// <inheritdoc/>
    public static new SysType GetTypeFromProgID(string progID) =>  SysType.GetTypeFromProgID(progID);

    /// <inheritdoc/>
    public static new SysType GetTypeFromProgID(string progID, bool throwOnError) => SysType.GetTypeFromProgID(progID, throwOnError);

    /// <inheritdoc/>
    public static new SysType GetTypeFromProgID(string progID, string server) => SysType.GetTypeFromProgID(progID, server);

    /// <inheritdoc/>
    public static new SysType GetTypeFromProgID(string progID, string server, bool throwOnError) => SysType.GetTypeFromProgID(progID, server, throwOnError);

    /// <inheritdoc/>
    public static new SysType GetTypeFromCLSID(Guid clsid) => SysType.GetTypeFromCLSID(clsid);

    /// <inheritdoc/>
    public static new SysType GetTypeFromCLSID(Guid clsid, bool throwOnError) => SysType.GetTypeFromCLSID(clsid, throwOnError);

    /// <inheritdoc/>
    public static new SysType GetTypeFromCLSID(Guid clsid, string server) => SysType.GetTypeFromCLSID(clsid, server);

    /// <inheritdoc/>
    public static new SysType GetTypeFromCLSID(Guid clsid, string server, bool throwOnError) => SysType.GetTypeFromCLSID(clsid, server, throwOnError);

    /// <inheritdoc/>
    public static new TypeCode GetTypeCode(SysType type) => SysType.GetTypeCode(type);

    /// <inheritdoc/>
    public abstract override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

    /// <inheritdoc/>
    public new object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, CultureInfo culture) => base.InvokeMember(name, invokeAttr, binder, target, args, culture);

    /// <inheritdoc/>
    public new object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args) => base.InvokeMember(name, invokeAttr, binder, target, args);

    /// <inheritdoc/>
    public static new RuntimeTypeHandle GetTypeHandle(object o) => SysType.GetTypeHandle(o);

    /// <inheritdoc/>
#pragma warning disable CS0436 // Type conflicts with imported type
    public static new Type GetTypeFromHandle(RuntimeTypeHandle handle) => new Handle(SysType.GetTypeFromHandle(handle));
#pragma warning restore CS0436 // Type conflicts with imported type

    /// <inheritdoc/>
    public override int GetArrayRank() => base.GetArrayRank();

    /// <inheritdoc/>
    public new ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, SysType[] types, ParameterModifier[] modifiers) => base.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);

    /// <inheritdoc/>
    public new ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, SysType[] types, ParameterModifier[] modifiers) => base.GetConstructor(bindingAttr, binder, types, modifiers);

    /// <inheritdoc/>
    public new ConstructorInfo GetConstructor(SysType[] types) => base.GetConstructor(types);

    /// <inheritdoc/>
    public new ConstructorInfo[] GetConstructors() => base.GetConstructors();

    /// <inheritdoc/>
    public abstract override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

    /// <inheritdoc/>
    public new MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, SysType[] types, ParameterModifier[] modifiers) => base.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);

    /// <inheritdoc/>
    public new MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, SysType[] types, ParameterModifier[] modifiers) => base.GetMethod(name, bindingAttr, binder, types, modifiers);

    /// <inheritdoc/>
    public new MethodInfo GetMethod(string name, SysType[] types, ParameterModifier[] modifiers) => base.GetMethod(name, types, modifiers);

    /// <inheritdoc/>
    public new MethodInfo GetMethod(string name, SysType[] types) => base.GetMethod(name, types);

    /// <inheritdoc/>
    public new MethodInfo GetMethod(string name, BindingFlags bindingAttr) => base.GetMethod(name, bindingAttr);

    /// <inheritdoc/>
    public new MethodInfo GetMethod(string name) => base.GetMethod(name);

    /// <inheritdoc/>
    public new MethodInfo[] GetMethods() => base.GetMethods();

    /// <inheritdoc/>
    public abstract override MethodInfo[] GetMethods(BindingFlags bindingAttr);

    /// <inheritdoc/>
    public abstract override FieldInfo GetField(string name, BindingFlags bindingAttr);

    /// <inheritdoc/>
    public new FieldInfo GetField(string name) => base.GetField(name);

    /// <inheritdoc/>
    public new FieldInfo[] GetFields() => base.GetFields();

    /// <inheritdoc/>
    public abstract override FieldInfo[] GetFields(BindingFlags bindingAttr);

    /// <inheritdoc/>
    public new SysType GetInterface(string name) => base.GetInterface(name);

    /// <inheritdoc/>
    public abstract override SysType GetInterface(string name, bool ignoreCase);

    /// <inheritdoc/>
    public abstract override SysType[] GetInterfaces();

    /// <inheritdoc/>
    public override SysType[] FindInterfaces(TypeFilter filter, object filterCriteria) => base.FindInterfaces(filter, filterCriteria);

    /// <inheritdoc/>
    public new EventInfo GetEvent(string name) => base.GetEvent(name);

    /// <inheritdoc/>
    public abstract override EventInfo GetEvent(string name, BindingFlags bindingAttr);

    /// <inheritdoc/>
    public override EventInfo[] GetEvents() => base.GetEvents();

    /// <inheritdoc/>
    public abstract override EventInfo[] GetEvents(BindingFlags bindingAttr);

    /// <inheritdoc/>
    public new PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, SysType returnType, SysType[] types, ParameterModifier[] modifiers) => base.GetProperty(name, bindingAttr, binder, returnType, types, modifiers);

    /// <inheritdoc/>
    public new PropertyInfo GetProperty(string name, SysType returnType, SysType[] types, ParameterModifier[] modifiers) => base.GetProperty(name, returnType, types, modifiers);

    /// <inheritdoc/>
    public new PropertyInfo GetProperty(string name, BindingFlags bindingAttr) => base.GetProperty(name, bindingAttr);

    /// <inheritdoc/>
    public new PropertyInfo GetProperty(string name, SysType returnType, SysType[] types) => base.GetProperty(name, returnType, types);

    /// <inheritdoc/>
    public new PropertyInfo GetProperty(string name, SysType[] types) => base.GetProperty(name, types);

    /// <inheritdoc/>
    public new PropertyInfo GetProperty(string name, SysType returnType) => base.GetProperty(name, returnType);

    /// <inheritdoc/>
    public new PropertyInfo GetProperty(string name) => base.GetProperty(name);

    /// <inheritdoc/>
    public abstract override PropertyInfo[] GetProperties(BindingFlags bindingAttr);

    /// <inheritdoc/>
    public new PropertyInfo[] GetProperties() => base.GetProperties();

    /// <inheritdoc/>
    public new SysType[] GetNestedTypes() => base.GetNestedTypes();

    /// <inheritdoc/>
    public abstract override SysType[] GetNestedTypes(BindingFlags bindingAttr);

    /// <inheritdoc/>
    public new SysType GetNestedType(string name) =>  base.GetNestedType(name);

    /// <inheritdoc/>
    public abstract override SysType GetNestedType(string name, BindingFlags bindingAttr);

    /// <inheritdoc/>
    public new MemberInfo[] GetMember(string name) => base.GetMember(name);

    /// <inheritdoc/>
    public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) => base.GetMember(name, bindingAttr);

    /// <inheritdoc/>
    public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) => base.GetMember(name, type, bindingAttr);

    /// <inheritdoc/>
    public new MemberInfo[] GetMembers() => base.GetMembers();

    /// <inheritdoc/>
    public abstract override MemberInfo[] GetMembers(BindingFlags bindingAttr);

    /// <inheritdoc/>
    public override MemberInfo[] GetDefaultMembers() => base.GetDefaultMembers();

    /// <inheritdoc/>
    public override MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria) => base.FindMembers(memberType, bindingAttr, filter, filterCriteria);

    /// <inheritdoc/>
    public override SysType[] GetGenericParameterConstraints() => base.GetGenericParameterConstraints();

    /// <inheritdoc/>
    public override SysType MakeGenericType(params SysType[] typeArguments) => base.MakeGenericType(typeArguments);

    /// <inheritdoc/>
    public abstract override SysType GetElementType();

    /// <inheritdoc/>
    public override SysType[] GetGenericArguments() => base.GetGenericArguments();

    /// <inheritdoc/>
    public override SysType GetGenericTypeDefinition() => base.GetGenericTypeDefinition();

    /// <inheritdoc/>
    public override bool IsSubclassOf(SysType c) => base.IsSubclassOf(c);

    /// <inheritdoc/>
    public override bool IsInstanceOfType(object o) => base.IsInstanceOfType(o);

    /// <inheritdoc/>
    public override bool IsAssignableFrom(SysType c) => base.IsAssignableFrom(c);

    /// <inheritdoc/>
    public override string ToString() => base.ToString();

    /// <inheritdoc/>
    public static new SysType[] GetTypeArray(object[] args) => SysType.GetTypeArray(args);

    /// <inheritdoc/>
    public override bool Equals(object o) => base.Equals(o);

    /// <inheritdoc/>
    public new bool Equals(SysType o) => base.Equals(o);

    /// <inheritdoc/>
    public override int GetHashCode() => base.GetHashCode();

    /// <inheritdoc/>
    public override InterfaceMapping GetInterfaceMap(SysType interfaceType) => base.GetInterfaceMap(interfaceType);
}
