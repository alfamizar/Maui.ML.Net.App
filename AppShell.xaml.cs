using MauiAppML.Presentation.UI.Pages.Base;
using MauiAppML.Presentation.ViewModels.Base;

namespace MauiAppML;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

     public void OnShellAppearing()
    {
        //(CurrentPage.BindingContext as BaseViewModel).OnPageAppearing();
        (CurrentPage as BasePage).OnPageAppearing();
    }

     public void OnShellDisappearing()
    {
        //(CurrentPage.BindingContext as BaseViewModel).OnPageDisappearing();
        (CurrentPage as BasePage).OnPageDisappearing();
    }
}
