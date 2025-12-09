using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class CollectionsMarvelMoviesPage : ContentPage
{
	public CollectionsMarvelMoviesPage()
	{
		InitializeComponent();
		BindingContext = new CollectionMarvelMoviesViewModel();	
    }
}