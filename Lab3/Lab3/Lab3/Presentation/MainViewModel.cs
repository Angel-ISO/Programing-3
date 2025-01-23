using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Lab3.Presentation
{
    public partial class MainViewModel : ObservableObject
    {
        private string? username;
        private string? password;
        private string? loginMessage;

        public string? Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        public string? Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public string? LoginMessage
        {
            get => loginMessage;
            set => SetProperty(ref loginMessage, value);
        }

        public delegate void UserActionHandler(string message);
        public event UserActionHandler OnLogin;
        public event UserActionHandler OnRegister;

        private INavigator _navigator;

        public MainViewModel(INavigator navigator)
        {
            _navigator = navigator;

            OnLogin += ShowLoginMessage;
            OnRegister += ShowRegisterMessage;
        }

        public void Login()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                OnLogin?.Invoke("Por favor, ingresa todos los campos.");
            }
            else
            {
                OnLogin?.Invoke($"Bienvenido, {Username}!");
            }
        }

        public void Register()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                OnRegister?.Invoke("Por favor, ingresa todos los campos.");
            }
            else
            {
                OnRegister?.Invoke($"Usuario {Username} registrado exitosamente.");
            }
        }

        private void ShowLoginMessage(string message)
        {
            LoginMessage = message;
        }

        private void ShowRegisterMessage(string message)
        {
            LoginMessage = message; 
        }

        public ICommand LoginCommand => new RelayCommand(() => Login());
        public ICommand RegisterCommand => new RelayCommand(() => Register());
    }
}
