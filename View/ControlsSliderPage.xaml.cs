using MyFirstMAUIApp.ViewModel;
using MyFirstMAUIApp.ViewModels;

namespace MyFirstMAUIApp.View;
public partial class ControlsSliderPage : ContentPage
{
	public ControlsSliderPage()
	{
        InitializeComponent();
        BindingContext = new ControlsSliderViewModel();
    }
}