namespace A2ADotNet;

public class AgentSkill
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public List<string>? Tags { get; set; }

    public List<string>? Examples { get; set; }

    public List<string>? InputModes { get; set; }

    public List<string>? OutputModes { get; set; }
}
