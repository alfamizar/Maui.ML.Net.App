using MauiAppML.Presentation.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppML.Presentation.UI.Pages.Base
{
    public class BasePage : ContentPage
    {
        public BaseViewModel ViewModel => BindingContext as BaseViewModel;

        public virtual void OnPageAppearing()
        {
            ViewModel.OnPageAppearing();
        }

        public virtual void OnPageDisappearing()
        {
            ViewModel.OnPageDisappearing();
        }

        protected override bool OnBackButtonPressed()
        {
            ViewModel.OnBackButtonPressed();
            return base.OnBackButtonPressed();
        }

        protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
        {
            base.OnNavigatedFrom(args);
            ViewModel.OnNavigatedFrom();
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            ViewModel.OnNavigatedTo();
        }

        protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
        {
            base.OnNavigatingFrom(args);
            ViewModel.OnNavigatingFrom();
        }
    }
}
