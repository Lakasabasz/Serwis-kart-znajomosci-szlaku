namespace Backend.Models;

public sealed partial class PointsInLine
{
    public int Linenr { get; set; }

    public int Postid { get; set; }

    public double Kilometer { get; set; }

    public RailroadLine LinenrNavigation { get; set; } = null!;

    public RailroadPoint Post { get; set; } = null!;
}
