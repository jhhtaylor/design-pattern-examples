//Imagine using a third-party library with a JsonSerializer class that serializes objects to JSON
//but doesn't support pretty-printing (formatting the JSON output for readability).

//You need pretty-printed JSON for debugging purposes, but the library doesn't offer this feature directly.

// Hypothetical class in a third-party library
public class JsonSerializer
{
    public string Serialize(object obj)
    {
        // Serialize obj to JSON string
        return "{}"; // Simplified for example
    }
}
