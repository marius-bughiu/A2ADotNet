namespace A2ADotNet.Client;

using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

public class A2AClient
{
    private readonly string _url;

    public A2AClient(AgentCard agentCard = null, string url = null)
    {
        if (agentCard != null)
        {
            _url = agentCard.Url;
        }
        else if (!string.IsNullOrEmpty(url))
        {
            _url = url;
        }
        else
        {
            throw new ArgumentException("Must provide either agentCard or url.");
        }
    }

    public async Task<SendTaskResponse> SendTask(TaskSendParams payload)
    {
        var request = new SendTaskRequest(payload);
        var response = await SendRequestAsync(request);
        return new SendTaskResponse(response);
    }

    public async IAsyncEnumerable<SendTaskStreamingResponse> SendTaskStreaming(Dictionary<string, object> payload)
    {
        // SSE streaming logic (placeholder).
        // In practice, connect to _url with an SSE-capable library or custom implementation,
        // then yield SendTaskStreamingResponse objects as events arrive.
        yield break;
    }

    private async Task<Dictionary<string, object>> SendRequestAsync(JsonRpcRequest request)
    {
        try
        {
            using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
            var httpResponse = await client.PostAsJsonAsync(_url, request);
            httpResponse.EnsureSuccessStatusCode();
            var content = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Dictionary<string, object>>(content);
        }
        catch (HttpRequestException e)
        {
            throw new A2AClientHttpError(400, e.Message);
        }
        catch (JsonException e)
        {
            throw new A2AClientJSONError(e.Message);
        }
    }

    public async Task<GetTaskResponse> GetTask(Dictionary<string, object> payload)
    {
        var request = new GetTaskRequest(payload);
        var response = await SendRequestAsync(request);
        return new GetTaskResponse(response);
    }

    public async Task<CancelTaskResponse> CancelTask(Dictionary<string, object> payload)
    {
        var request = new CancelTaskRequest(payload);
        var response = await SendRequestAsync(request);
        return new CancelTaskResponse(response);
    }

    public async Task<SetTaskPushNotificationResponse> SetTaskCallback(Dictionary<string, object> payload)
    {
        var request = new SetTaskPushNotificationRequest(payload);
        var response = await SendRequestAsync(request);
        return new SetTaskPushNotificationResponse(response);
    }

    public async Task<GetTaskPushNotificationResponse> GetTaskCallback(Dictionary<string, object> payload)
    {
        var request = new GetTaskPushNotificationRequest(payload);
        var response = await SendRequestAsync(request);
        return new GetTaskPushNotificationResponse(response);
    }
}
