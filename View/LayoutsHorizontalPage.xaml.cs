using MyFirstMAUIApp.ViewModels;

namespace MyFirstMAUIApp.Views;

public partial class LayoutsHorizontalPage : ContentPage
{
    public LayoutsHorizontalPage()
    {
        InitializeComponent();
        BindingContext = new LayoutsHorizontalViewModel();
    }
}

