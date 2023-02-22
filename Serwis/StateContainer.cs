namespace Serwis;

public class StateContainer
{
    private int? _storedValue;

    public int StoredValue
    {
        get => _storedValue ?? 0;
        set
        {
            _storedValue = value;
            NotifyStateChanged();
        }
    }

    public event EventHandler? PropertyChanged;
    private void NotifyStateChanged() => PropertyChanged?.Invoke(this, EventArgs.Empty);
}