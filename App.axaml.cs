using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
#if DEBUG
using Live.Avalonia;
#endif

namespace HelloAvalonia;

public partial class App : Application
#if DEBUG
    , ILiveView
#endif
{
    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
#if DEBUG
            if (Debugger.IsAttached)
            {
                desktop.MainWindow = new MainWindow();
            }
            else
            {
                var live = new LiveViewHost(this, Console.WriteLine);
                live.StartWatchingSourceFilesForHotReloading();
                live.Show();
            }
#else
            desktop.MainWindow = new MainWindow();
#endif
        }

        base.OnFrameworkInitializationCompleted();
    }

#if DEBUG

    public object CreateView(Window hostWindow)
    {
        // Keep a shared DataContext if you want state persistence across reloads
        hostWindow.DataContext ??= new MainViewModel();

        hostWindow.Width = 1100;
        hostWindow.Height = 720;
        hostWindow.Title = "My App";

        var view = new RootView { DataContext = hostWindow.DataContext };
        return view;
    }

#endif
}
