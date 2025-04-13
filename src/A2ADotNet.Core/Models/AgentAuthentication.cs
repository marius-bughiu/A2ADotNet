namespace A2ADotNet;

public class AgentAuthentication
{
    public List<string> Schemes { get; set; } = new List<string>();

    public string? Credentials { get; set; }
}
