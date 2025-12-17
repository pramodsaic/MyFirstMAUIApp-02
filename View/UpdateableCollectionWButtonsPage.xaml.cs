using MyFirstMAUIApp.ViewViewModels.CollectionsUpdatable;
namespace MyFirstMAUIApp.View;

public partial class UpdateableCollectionWButtonsPage : ContentPage
{
    public UpdateableCollectionWButtonsPage(UpdateableCollectionViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}