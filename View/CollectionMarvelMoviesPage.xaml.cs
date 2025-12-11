using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class CollectionMarvelMoviesPage : ContentPage
{
	public CollectionMarvelMoviesPage()
	{
        InitializeComponent();
        BindingContext = new CollectionMarvelMoviesViewModel();
    }
}