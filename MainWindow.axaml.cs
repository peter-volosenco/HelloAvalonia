using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace HelloAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Width = 1100;
        Height = 720;
        Title = "My App";
    }
  
}