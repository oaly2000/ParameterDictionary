
using System.Text.Json;
using ParameterDictionary.Abstract;

[assembly: ParameterDictionaryNamespace("Generated")]

Console.WriteLine(JsonSerializer.Serialize(Generated.ParameterDictionary.Report));

[InParameterDictionary]
public enum Rgb
{
    [ParameterLabel("RED")]
    [ParameterMeta("color", "red")]
    R,
    [ParameterLabel("GREEN")]
    [ParameterMeta("color", "green")]
    G,
    [ParameterLabel("BLUE")]
    [ParameterMeta("color", "blue")]
    B
}

[InParameterDictionary]
public enum Abc2
{
    A = 1,
    B,
    C
}