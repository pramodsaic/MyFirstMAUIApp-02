using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class CollectionGOGwImagesPage : ContentPage
{
	public CollectionGOGwImagesPage()
	{
		InitializeComponent();
        BindingContext = new CollectionGOGwImagesViewModel();
    }
}