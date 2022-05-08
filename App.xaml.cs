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
        };

        window.Stopped += (s, e) =>
        {
            ((AppShell)window.Page).OnShellDisappearing();
        };

        window.Resumed += (s, e) =>
        {
            ((AppShell)window.Page).OnShellAppearing();
        };

        return window;
    }

}
