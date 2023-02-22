using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Serwis.Models;

public class UserData: INotifyPropertyChanged
{
    private string? _token;

    public string? Token
    {
        get => _token;
        set
        {
            if (value == _token) return;
            _token = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}