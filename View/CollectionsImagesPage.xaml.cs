using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class CollectionsImagesPage : ContentPage
{
	public CollectionsImagesPage()
	{
		InitializeComponent();
		BindingContext = new CollectionsImagesViewModel();
	}
}