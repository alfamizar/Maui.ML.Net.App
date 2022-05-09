using MauiAppML.Presentation.UI.Pages.Base;
using MauiAppML.Presentation.ViewModels.Base;
using System.Diagnostics;

namespace MauiAppML;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        window.Created += (s, e) =>
        {
            // Custom logic
            ((AppShell)window.Page).OnAppWindowStopped();
        };

        window.Activated += (s, e) =>
        {
            // Custom logic
            ((AppShell)window.Page).OnAppWindowStopped();
        };

        window.Resumed += (s, e) =>
        {
            // Custom logic
            ((AppShell)window.Page).OnAppWindowStopped();
        };

        window.Backgrounding += (s, e) =>
        {
            // Custom logic
            ((AppShell)window.Page).OnAppWindowStopped();
        };

        window.Stopped += (s, e) =>
        {
            // Custom logic
            ((AppShell)window.Page).OnAppWindowStopped();
        };

        return window;
    }
}
