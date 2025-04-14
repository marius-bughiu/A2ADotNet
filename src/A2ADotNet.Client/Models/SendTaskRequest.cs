using System.Text.Json.Serialization;

namespace A2ADotNet.Client;

public class SendTaskRequest(TaskSendParams @params) : JsonRpcRequest
{
    [JsonPropertyName("method")]
    public new string Method { get; } = "tasks/send";

    [JsonPropertyName("params")]
    public new TaskSendParams Params { get; set; } = @params;
}
