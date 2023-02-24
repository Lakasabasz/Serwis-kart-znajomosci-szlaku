namespace Backend.Models;

public sealed partial class RailroadLine
{
    public int Linenr { get; set; }

    public string Linename { get; set; } = null!;

    public ICollection<PointsInLine> PointsInLines { get; } = new List<PointsInLine>();
}
