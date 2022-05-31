using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAppML.Presentation.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public Dictionary<string, ICommand> Commands { get; protected set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public BaseViewModel()
        {
            Commands = new Dictionary<string, ICommand>();
        }

        public virtual void OnPageAppearing()
        {
            // Custom logic
        }

        public virtual void OnPageDisappearing()
        {
            // Custom logic
        }

        public virtual void OnBackButtonPressed()
        {
            // Custom logic
        }

        public virtual void OnNavigatedFrom()
        {
            // Custom logic
        }

        public virtual void OnNavigatingFrom()
        {
            // Custom logic
        }

        public virtual void OnNavigatedTo()
        {
            // Custom logic
        }

        public virtual void OnAppWindowCreated()
        {
            // Custom logic
        }

        public virtual void OnAppWindowActivated()
        {
            // Custom logic
        }

        public virtual void OnAppWindowResumed()
        {
            // Custom logic
        }

        public virtual void OnAppWindowBackgrounding()
        {
            // Custom logic
        }

        public virtual void OnAppWindowStopped()
        {
            // Custom logic
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
            {
                return false;
            }

            backingStore = value;

            onChanged?.Invoke();

            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null) return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
