using System;

namespace ParameterDictionary.Abstract;

[AttributeUsage(AttributeTargets.Field)]
public class ParameterLabelAttribute(string label) : Attribute
{
    public string Label => label;
}
