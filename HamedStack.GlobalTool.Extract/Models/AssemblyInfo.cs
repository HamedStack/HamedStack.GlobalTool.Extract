namespace HamedStack.GlobalTool.Extract.Models;

public class AssemblyInfo
{
    public string? Hash { get; set; }
    public string? Name { get; set; }
    public string? Path { get; set; }
    public IEnumerable<EmbeddedResourceInfo> EmbeddedResources { get; set; } = new List<EmbeddedResourceInfo>();
}