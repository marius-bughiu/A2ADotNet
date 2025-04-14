using System.Text.Json.Serialization;

namespace A2ADotNet.Client;

public class JsonRpcRequest : JsonRpcMessage
{
    [JsonPropertyName("method")]
    public string Method { get; set; } = string.Empty;

    [JsonPropertyName("params")]
    public Dictionary<string, object>? Params { get; set; }
}
