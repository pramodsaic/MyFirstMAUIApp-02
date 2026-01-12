using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ControlsMenuPage : ContentPage
{
    public ControlsMenuPage()
    {
        InitializeComponent();
        BindingContext = new ControlsViewModel();
    }
}

