namespace MyFirstMAUIApp.View;

public partial class ControlsStepperVMPage : ContentPage
{
    public ControlsStepperVMPage()
    {
        InitializeComponent();
        BindingContext = new ControlsStepperVMViewModel();
    }
}

