using MauiAppML.Presentation.UI.Pages.Base;
using MauiAppML.Presentation.ViewModels.Base;

namespace MauiAppML;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    public void OnAppWindowCreated()
    {
        //(CurrentPage.BindingContext as BaseViewModel).OnPageAppearing();
        (CurrentPage as BasePage).OnAppWindowCreated();
    }

    public void OnAppWindowActivated()
    {
        //(CurrentPage.BindingContext as BaseViewModel).OnPageAppearing();
        (CurrentPage as BasePage).OnAppWindowActivated();
    }

    public void OnAppWindowResumed()
    {
        //(CurrentPage.BindingContext as BaseViewModel).OnPageAppearing();
        (CurrentPage as BasePage).OnAppWindowResumed();
    }

    public void OnAppWindowBackgrounding()
    {
        //(CurrentPage.BindingContext as BaseViewModel).OnPageAppearing();
        (CurrentPage as BasePage).OnAppWindowBackgrounding();
    }

    public void OnAppWindowStopped()
    {
        //(CurrentPage.BindingContext as BaseViewModel).OnPageDisappearing();
        (CurrentPage as BasePage).OnAppWindowStopped();
    }
}
