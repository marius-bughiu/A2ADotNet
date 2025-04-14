namespace A2ADotNet.Client;

public class CancelTaskRequest : JsonRpcRequest
{
    public CancelTaskRequest(Dictionary<string, object> payload)
    {
        Params = payload;
        Method = "cancelTask";
    }
}
