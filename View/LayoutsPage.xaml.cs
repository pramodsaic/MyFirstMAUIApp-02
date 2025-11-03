using MyFirstMAUIApp.ViewModels;

namespace MyFirstMAUIApp.Views;

public partial class LayoutsPage : ContentPage
{
    public LayoutsPage()
    {
        InitializeComponent();
        BindingContext = new LayoutsViewModel();
    }
}


