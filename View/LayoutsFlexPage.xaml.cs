using MyFirstMAUIApp.ViewModels;

namespace MyFirstMAUIApp.Views;

public partial class LayoutsFlexPage : ContentPage
{
	public LayoutsFlexPage()
	{
		InitializeComponent();
        BindingContext = new LayoutsFlexViewModel();

    }
}