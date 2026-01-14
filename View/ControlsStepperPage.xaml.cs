namespace MyFirstMAUIApp.View;

public partial class ControlsStepperPage : ContentPage
{
    public ControlsStepperPage()
    {
        InitializeComponent();
        BindingContext = new ControlsStepperViewModel();
    }
}
