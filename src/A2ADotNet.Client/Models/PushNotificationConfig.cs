using System.Text.Json.Serialization;

namespace A2ADotNet.Client;

public class PushNotificationConfig
{
    [JsonPropertyName("url")]
    public string Url { get; set; } = default!;

    [JsonPropertyName("token")]
    public string? Token { get; set; }

    [JsonPropertyName("authentication")]
    public AuthenticationInfo? Authentication { get; set; }
}
