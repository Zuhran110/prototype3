using Microsoft.UI.Xaml.Controls;
using prototype3.ViewModels;

namespace prototype3.Views;

public sealed partial class LoginPage : Page
{
    public LoginPage()
    {
        InitializeComponent();
        DataContext = new LoginViewModel();
    }
}