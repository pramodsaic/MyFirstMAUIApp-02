using MyFirstMAUIAPP.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ControlsSliderVMPage : ContentPage
{
    public ControlsSliderVMPage()
    {
        InitializeComponent();
        BindingContext = new ControlsSliderVMViewModel();
    }

}