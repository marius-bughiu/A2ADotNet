namespace A2ADotNet.Client;

public class GetTaskRequest : JsonRpcRequest
{
    public GetTaskRequest(Dictionary<string, object> payload)
    {
        Params = payload;
        Method = "getTask";
    }
}
