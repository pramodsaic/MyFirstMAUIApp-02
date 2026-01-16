namespace MyFirstMAUIApp.View;

using MyFirstMAUIApp.ViewModel;
using MyFirstMAUIApp.ViewModels;

public partial class ControlsPage : ContentPage
{
    public ControlsPage()
    {
        InitializeComponent();
        BindingContext = new ControlsViewModel();
    }
}
