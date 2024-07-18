using IsBusyExample.Views;

namespace IsBusyExample;

public partial class App
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new FirstPage());
    }
}