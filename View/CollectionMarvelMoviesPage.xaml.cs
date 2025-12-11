using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class CollectionMarvelMoviesPage : ContentView
{
	public CollectionMarvelMoviesPage()
	{
        InitializeComponent();
        BindingContext = new CollectionMarvelMoviesViewModel();
    }
}