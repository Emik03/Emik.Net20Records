// <copyright file="Handle.cs" company="Emik">Copyright (c) Emik. All rights reserved.</copyright>

namespace Emik.Net20Records;

/// <summary>An implementation for <see cref="Type"/> to use in <see cref="Type.GetTypeFromHandle"/> to return its type from a returned base type.</summary>
#pragma warning disable CS0436 // Type conflicts with imported type
internal sealed class Handle : Type
#pragma warning restore CS0436 // Type conflicts with imported type
{
    private readonly SysType _fromHandler;

    internal Handle(SysType handler) => _fromHandler = handler;

    public override Guid GUID => _fromHandler.GUID;
    public override Module Module => _fromHandler.Module;
    public override Assembly Assembly => _fromHandler.Assembly;
    public override string FullName => _fromHandler.FullName;
    public override string Namespace => _fromHandler.Namespace;
    public override string AssemblyQualifiedName => _fromHandler.AssemblyQualifiedName;
    public override SysType BaseType => _fromHandler.BaseType;
    public override SysType UnderlyingSystemType => _fromHandler.UnderlyingSystemType;
    public override string Name => _fromHandler.Name;

    public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) => _fromHandler.GetConstructors(bindingAttr);
    public override object[] GetCustomAttributes(bool inherit) => _fromHandler.GetCustomAttributes(inherit);
    public override object[] GetCustomAttributes(SysType attributeType, bool inherit) => _fromHandler.GetCustomAttributes(attributeType, inherit);
    public override SysType GetElementType() => _fromHandler.GetElementType();
    public override EventInfo GetEvent(string name, BindingFlags bindingAttr) => _fromHandler.GetEvent(name, bindingAttr);
    public override EventInfo[] GetEvents(BindingFlags bindingAttr) => _fromHandler.GetEvents(bindingAttr);
    public override FieldInfo GetField(string name, BindingFlags bindingAttr) => _fromHandler.GetField(name, bindingAttr);
    public override FieldInfo[] GetFields(BindingFlags bindingAttr) => _fromHandler.GetFields(bindingAttr);
    public override SysType GetInterface(string name, bool ignoreCase) => _fromHandler.GetInterface(name, ignoreCase);
    public override SysType[] GetInterfaces() => _fromHandler.GetInterfaces();
    public override MemberInfo[] GetMembers(BindingFlags bindingAttr) => _fromHandler.GetMembers(bindingAttr);
    public override MethodInfo[] GetMethods(BindingFlags bindingAttr) => _fromHandler.GetMethods(bindingAttr);
    public override SysType GetNestedType(string name, BindingFlags bindingAttr) => _fromHandler.GetNestedType(name, bindingAttr);
    public override SysType[] GetNestedTypes(BindingFlags bindingAttr) => _fromHandler.GetNestedTypes(bindingAttr);
    public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) => _fromHandler.GetProperties(bindingAttr);
    public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) => _fromHandler.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
    public override bool IsDefined(SysType attributeType, bool inherit) => _fromHandler.IsDefined(attributeType, inherit);
    protected override TypeAttributes GetAttributeFlagsImpl() => _fromHandler.Attributes;
    protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, SysType[] types, ParameterModifier[] modifiers) => _fromHandler.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
    protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, SysType[] types, ParameterModifier[] modifiers) => _fromHandler.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
    protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, SysType returnType, SysType[] types, ParameterModifier[] modifiers) => _fromHandler.GetProperty(name, bindingAttr, binder, returnType, types, modifiers);
    protected override bool HasElementTypeImpl() => _fromHandler.HasElementType;
    protected override bool IsArrayImpl() => _fromHandler.IsArray;
    protected override bool IsByRefImpl() => _fromHandler.IsByRef;
    protected override bool IsCOMObjectImpl() => _fromHandler.IsCOMObject;
    protected override bool IsPointerImpl() => _fromHandler.IsPointer;
    protected override bool IsPrimitiveImpl() => _fromHandler.IsPrimitive;
}
