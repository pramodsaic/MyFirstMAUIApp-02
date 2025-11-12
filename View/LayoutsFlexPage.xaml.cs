using MyFirstMAUIApp.ViewModels;

namespace MyFirstMAUIApp.View;

public partial class LayoutsFlexPage : ContentPage
{
	public LayoutsFlexPage()
	{
		InitializeComponent();
        BindingContext = new LayoutsFlexViewModel();

    }
}