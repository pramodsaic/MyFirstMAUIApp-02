using MyFirstMAUIApp.ViewModels;
namespace MyFirstMAUIApp.Views;

public partial class LayoutsStackPage : ContentPage
{
    public LayoutsStackPage()
    {
        InitializeComponent();
        BindingContext = new LayoutsStackViewModel();
    }
}

