namespace MyFirstMAUIApp.View;

using MyFirstMAUIApp.ViewModel;

public partial class ControlsPage : ContentPage
{
    public ControlsPage()
    {
        InitializeComponent();
        BindingContext = new ControlsViewModel();
    }
}
