namespace ApiProtocol;

public class ResponseBase
{
    public string Error { get; }
    public int ErrorCode { get; }

    public ResponseBase(int code, string error)
    {
        ErrorCode = code;
        Error = error;
    }
}