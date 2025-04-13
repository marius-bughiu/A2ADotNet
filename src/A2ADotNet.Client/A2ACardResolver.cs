namespace A2ADotNet.Client;

using System.Net.Http;
using System.Text.Json;

public class A2ACardResolver(string baseUrl, string agentCardPath = "/.well-known/agent.json")
{
    private readonly string _baseUrl = baseUrl.TrimEnd('/');
    private readonly string _agentCardPath = agentCardPath.TrimStart('/');

    public async Task<AgentCard> GetAgentCard()
    {
        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync($"{_baseUrl}/{_agentCardPath}");
        response.EnsureSuccessStatusCode();

        try
        {
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<AgentCard>(json)
                   ?? throw new A2AClientJSONError($"Failed to deserialize {nameof(AgentCard)}.");
        }
        catch (JsonException ex)
        {
            throw new A2AClientJSONError(ex.Message, ex);
        }
    }
}
