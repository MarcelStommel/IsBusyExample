namespace IsBusyExample.Views;

public partial class FirstPage
{
    public FirstPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new SecondPage());
    }
}