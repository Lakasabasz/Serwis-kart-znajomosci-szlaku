namespace Backend.Models;

public sealed partial class NodePost
{
    public int Postid { get; set; }

    public RailroadPoint Post { get; set; } = null!;
}
