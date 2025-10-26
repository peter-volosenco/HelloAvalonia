using System;
using Avalonia;
using Avalonia.ReactiveUI;

namespace HelloAvalonia;

internal static class Program
{
    // The main entry point. Avalonia will start here.
    [STAThread]
    public static void Main(string[] args)
    {
#if DEBUG
        // Live.Avalonia automatically hooks into AvaloniaAppBuilder,
        // so we just build the app normally.
        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
#else
        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
#endif
    }

    // Standard Avalonia builder
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()               // optional, for modern font rendering
            .LogToTrace()
            .UseReactiveUI();              // required if you use ReactiveUI bindings
}
