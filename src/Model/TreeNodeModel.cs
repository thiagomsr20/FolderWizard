namespace FolderWizard.Model.Node;

public class Node
{
    public string Name { get; set; } = string.Empty;

    public List<Node>? Nodes { get; set; }
}