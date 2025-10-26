using Avalonia.Controls;

namespace HelloAvalonia;

public partial class RootView : UserControl
{
    public RootView()
    {
        InitializeComponent();
        DataContext = new MainViewModel();

    }
}
