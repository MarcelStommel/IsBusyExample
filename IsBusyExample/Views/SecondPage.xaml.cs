namespace IsBusyExample.Views;

public partial class SecondPage
{
    public SecondPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        IsBusy = !IsBusy;
    }
}