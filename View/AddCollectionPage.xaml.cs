using MyFirstMAUIApp.ViewModel;
using MyFirstMAUIApp.ViewModels;

namespace MyFirstMAUIApp.View;

public partial class AddCollectionPage : ContentPage
{
    public AddCollectionPage()
    {
        InitializeComponent();
        BindingContext = new AddCollectionViewModel();
    }
}