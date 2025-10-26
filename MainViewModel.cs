using System.Windows.Input;
using ReactiveUI;

namespace HelloAvalonia;

public class MainViewModel : ReactiveObject
{
    private string _someText = "Edit me and watch live reload!";
    private bool _isChecked;

    public string Greeting => "Hello from Avalonia Live!";
    public string SomeText
    {
        get => _someText;
        set => this.RaiseAndSetIfChanged(ref _someText, value);
    }

    public bool IsChecked
    {
        get => _isChecked;
        set => this.RaiseAndSetIfChanged(ref _isChecked, value);
    }

    public ICommand DoSomething => ReactiveCommand.Create(() => { /* demo */ });
}
