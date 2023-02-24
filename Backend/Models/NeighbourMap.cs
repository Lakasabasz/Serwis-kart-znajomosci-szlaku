namespace Backend.Models;

public sealed partial class NeighbourMap
{
    public int PostA { get; set; }

    public int PostB { get; set; }

    public int Linenr { get; set; }

    public double KilometerA { get; set; }

    public double KilometerB { get; set; }

    public double Distance { get; set; }

    public RailroadLine LinenrNavigation { get; set; } = null!;

    public RailroadPoint PostANavigation { get; set; } = null!;

    public RailroadPoint PostBNavigation { get; set; } = null!;
}
