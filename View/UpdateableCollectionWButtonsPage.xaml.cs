using MyFirstMAUIApp.ViewModels;
using MyFirstMAUIApp.ViewViewModels.CollectionsUpdatable;

namespace MyFirstMAUIApp.Views;

public partial class UpdateableCollectionWButtonsPage : ContentPage
{
    public UpdateableCollectionWButtonsPage(UpdateableCollectionViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}