using ApiProtocol.Models;

namespace ApiProtocol;

public class AutocompletionListResponse: ResponseBase
{
    public AutocompletionListResponse(int code, string error) : base(code, error){}
    public AutocompletionListResponse() : base(0, ""){}

    public ICollection<Post> Posts { get; set; } = new List<Post>();
}