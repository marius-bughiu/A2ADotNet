using System.Text.Json.Serialization;

namespace A2ADotNet.Client;

public class Message
{
    [JsonPropertyName("role")]
    public Role Role { get; set; }

    [JsonPropertyName("parts")]
    public List<Part> Parts { get; set; } = new();

    [JsonPropertyName("metadata")]
    public Dictionary<string, object>? Metadata { get; set; }
}

public enum Role
{
    User,
    Agent
}

public class Part
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}

public class TextPart : Part
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = default!;
}

public class FilePart : Part
{
    [JsonPropertyName("fileName")]
    public string FileName { get; set; } = default!;

    [JsonPropertyName("fileContent")]
    public byte[] FileContent { get; set; } = default!;
}

public class DataPart : Part
{
    [JsonPropertyName("data")]
    public Dictionary<string, object> Data { get; set; } = new();
}
