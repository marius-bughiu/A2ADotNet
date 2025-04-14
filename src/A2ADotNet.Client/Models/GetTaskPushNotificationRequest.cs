namespace A2ADotNet.Client;

public class GetTaskPushNotificationRequest : JsonRpcRequest
{
    public GetTaskPushNotificationRequest(Dictionary<string, object> payload)
    {
        Params = payload;
        Method = "getTaskCallback";
    }
}
