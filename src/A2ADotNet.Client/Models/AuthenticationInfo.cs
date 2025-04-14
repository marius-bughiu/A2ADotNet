using System.Text.Json.Serialization;

namespace A2ADotNet.Client;

public class AuthenticationInfo
{
    [JsonPropertyName("schemes")]
    public List<string> Schemes { get; set; } = new List<string>();

    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    [JsonExtensionData]
    public Dictionary<string, object>? AdditionalProperties { get; set; }
}
