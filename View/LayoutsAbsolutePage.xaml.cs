using FirstMauiMobileApp.ViewModels;

namespace MyFirstMAUIApp.Views;

public partial class LayoutsAbsolutePage : ContentPage
{
    public LayoutsAbsolutePage()
    {
        InitializeComponent();
        BindingContext = new LayoutsAbsoluteViewModel();

    }
}


