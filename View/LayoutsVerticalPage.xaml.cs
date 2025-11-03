using MyFirstMAUIApp.ViewModels;
namespace MyFirstMAUIApp.Views;

public partial class LayoutsVerticalPage : ContentPage
{
    public LayoutsVerticalPage()
    {
        InitializeComponent();
        BindingContext = new LayoutsVerticalViewModel();
    }
}