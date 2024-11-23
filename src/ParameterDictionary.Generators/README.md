# ParameterDictionary

A source generator for generating dictionaries based on enum values.

```c#
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
```

Above example will generate dictionaries as below.

```csharp
public static class ParameterDictionary
{
    public static Dictionary<string, IEnumerable<Dictionary<string, string>>> Report = new()
    {
        ["Rgb"] = [
            new Dictionary<string, string>
            {
                {"Label", "RED"}, {"Value", "0"}, {"color", "red"}
            }, 
            new Dictionary<string, string>
            {
                {"Label", "GREEN"}, {"Value", "1"}, {"color", "green"}
            }, 
            new Dictionary<string, string>
            {
                {"Label", "BLUE"}, {"Value", "2"}, {"color", "blue"}
            }],
        ["Abc2"] = [
            new Dictionary<string, string>
            {
                {"Label", "A"}, {"Value", "1"}
            }, 
            new Dictionary<string, string>
            {
                {"Label", "B"}, {"Value", "2"}
            }, 
            new Dictionary<string, string>
            {
                {"Label", "C"}, {"Value", "3"}
            }]
    };
}
```

And there is an optional api to customize the generated namespace(default is your project assembly name).

```c#
[assembly: ParameterDictionaryNamespace("Generated")]
```