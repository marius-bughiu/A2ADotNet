namespace A2ADotNet.Client;

public class SetTaskPushNotificationRequest : JsonRpcRequest
{
    public SetTaskPushNotificationRequest(Dictionary<string, object> payload)
    {
        Params = payload;
        Method = "setTaskCallback";
    }
}
