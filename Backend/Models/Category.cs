namespace Backend.Models;

public sealed partial class Category
{
    public int Idcategory { get; set; }

    public string Discriminant { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public ICollection<RailroadPoint> RailroadPoints { get; } = new List<RailroadPoint>();
}
