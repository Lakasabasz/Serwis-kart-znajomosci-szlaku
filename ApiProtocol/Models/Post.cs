namespace ApiProtocol.Models;

public class Post
{
    public int PostId { get; set; }
    public string PostName { get; set; } = "";
    public string CategoryName { get; set; } = "";
    public string CategoryShortcut { get; set; } = "";
}