using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLeassing.Prism.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private string _password;
        private Boolean _isRunning ;
        private bool _isEnabled;
        private DelegateCommand _loginCommand;
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {

            Title = "Login";
            _isEnabled = true;
        }

        public DelegateCommand LoginCommand => _loginCommand ?? (_loginCommand = new DelegateCommand(Login));

       

        public string Email { get; set; }
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public Boolean IsRunnig
        {
            get => IsRunnig;
            set => SetProperty(ref _isRunning, value);
        }
        public Boolean IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

        private async void Login()
        {
           if(string.IsNullOrEmpty(Email))
            {
                 await App.Current.MainPage.DisplayAlert("Error", "You must enter an email ....","Accept");
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter a passwprd ", "Accept");
                return;
            }
            await App.Current.MainPage.DisplayAlert("OK", "Por mi cojones ", "Accept");
        }
    }

}
