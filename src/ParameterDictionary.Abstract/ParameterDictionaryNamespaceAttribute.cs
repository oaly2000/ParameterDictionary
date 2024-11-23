using System;

namespace ParameterDictionary.Abstract;

[AttributeUsage(AttributeTargets.Assembly)]
public class ParameterDictionaryNamespaceAttribute(string @namespace) : Attribute
{
    public string Namespace => @namespace;
}
