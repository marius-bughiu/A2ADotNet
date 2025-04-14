using System.Text.Json.Serialization;

namespace A2ADotNet.Client;

public class TaskSendParams
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;

    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; } = Guid.NewGuid().ToString();

    [JsonPropertyName("message")]
    public Message Message { get; set; } = default!;

    [JsonPropertyName("acceptedOutputModes")]
    public List<string>? AcceptedOutputModes { get; set; }

    [JsonPropertyName("pushNotification")]
    public PushNotificationConfig? PushNotification { get; set; }

    [JsonPropertyName("historyLength")]
    public int? HistoryLength { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object>? Metadata { get; set; }
}
