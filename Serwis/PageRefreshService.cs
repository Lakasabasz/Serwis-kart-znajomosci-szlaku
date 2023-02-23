namespace Serwis;

public sealed class PageRefreshService: IPageRefreshService
{
    public event EventHandler? PageRefreshRequestEvent;

    public void RequestRefresh()
    {
        PageRefreshRequestEvent?.Invoke(this, EventArgs.Empty);
    }
}