namespace Backend.Models;

public sealed partial class RailroadPoint
{
    public int Postid { get; set; }

    public string Postname { get; set; } = null!;

    public bool Platform { get; set; }

    public bool Requeststop { get; set; }

    public bool Loadingpoint { get; set; }

    public int Idcategory { get; set; }

    public Category IdcategoryNavigation { get; set; } = null!;

    public ICollection<PointsInLine> PointsInLines { get; } = new List<PointsInLine>();
}
