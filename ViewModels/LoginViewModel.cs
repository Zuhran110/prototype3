using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using prototype3.Core.Models;

namespace prototype3.ViewModels;

public class LoginViewModel : ObservableObject
{
    private string _username;
    private string _password;
    private string _loginMessage;

    private readonly LoginModel _loginModel;

    public string Username
    {
        get => _username;
        set
        {
            SetProperty(ref _username, value);
            ((RelayCommand)LoginCommand).NotifyCanExecuteChanged();
        }
    }

    public string Password
    {
        get => _password;
        set
        {
            SetProperty(ref _password, value);
            ((RelayCommand)LoginCommand).NotifyCanExecuteChanged();
        }
    }

    public string LoginMessage
    {
        get => _loginMessage;
        set => SetProperty(ref _loginMessage, value);
    }

    public ICommand LoginCommand
    {
        get;
    }

    public LoginViewModel()
    {
        _loginModel = new LoginModel();
        LoginCommand = new RelayCommand(ExecuteLogin, CanExecuteLogin);
    }

    private void ExecuteLogin()
    {
        var user = _loginModel.VerifyUser(Username, Password);
        if (user != null)
        {
            LoginMessage = $"Welcome {user.Role}";
        }
        else
        {
            LoginMessage = "Invalid Username or Password";
        }
    }

    private bool CanExecuteLogin()
    {
        return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
    }
}