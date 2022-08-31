﻿namespace MauiAppML;

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
            ((AppShell)window.Page).OnAppWindowCreated();
        };

        window.Activated += (s, e) =>
        {
            // Custom logic
            ((AppShell)window.Page).OnAppWindowActivated();
        };

        window.Resumed += (s, e) =>
        {
            // Custom logic
            ((AppShell)window.Page).OnAppWindowResumed();
        };

        window.Backgrounding += (s, e) =>
        {
            // Custom logic
            ((AppShell)window.Page).OnAppWindowBackgrounding();
        };

        window.Stopped += (s, e) =>
        {
            // Custom logic
            ((AppShell)window.Page).OnAppWindowStopped();
        };

        window.Destroying += (s, e) =>
        {
            // Custom logic
            ((AppShell)window.Page).OnAppWindowDestroying();
        };

        return window;
    }
}
