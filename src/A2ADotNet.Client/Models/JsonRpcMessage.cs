using System.Text.Json.Serialization;

namespace A2ADotNet.Client;

public class JsonRpcMessage
{
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; } = "2.0";

    [JsonPropertyName("id")]
    public object? Id { get; set; } = Guid.NewGuid().ToString();
}