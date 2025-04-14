namespace A2ADotNet.Client;

public class SendTaskStreamingRequest : JsonRpcRequest
{
    public SendTaskStreamingRequest(Dictionary<string, object> payload)
    {
        Params = payload;
        Method = "sendTaskStreaming";
    }
}
