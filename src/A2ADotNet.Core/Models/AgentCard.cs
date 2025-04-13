namespace A2ADotNet;

public class AgentCard
{
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public string Url { get; set; } = string.Empty;

    public AgentProvider? Provider { get; set; }

    public string Version { get; set; } = string.Empty;

    public string? DocumentationUrl { get; set; }

    public AgentCapabilities Capabilities { get; set; } = new AgentCapabilities();

    public AgentAuthentication? Authentication { get; set; }

    public List<string> DefaultInputModes { get; set; } = new List<string> { "text" };

    public List<string> DefaultOutputModes { get; set; } = new List<string> { "text" };

    public List<AgentSkill> Skills { get; set; } = new List<AgentSkill>();
}
