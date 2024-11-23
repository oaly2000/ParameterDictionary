using System;

namespace ParameterDictionary.Abstract;

[AttributeUsage(AttributeTargets.Field)]
public class ParameterMetaAttribute(string key, string value) : Attribute
{
    public string Key => key;
    public string Value => value;
}
