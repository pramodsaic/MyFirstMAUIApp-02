using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MyFirstMAUIApp.Model.Entities;

namespace MyFirstMAUIApp.ViewModel;

public partial class CollectionGOGwImagesViewModel : ObservableObject
{
    private List<MarvelCharacters> _marvelcharacters;
    public string Title => MarvelCharacters.MarvelCharactersTitle;

    //= new() -> constructs an empty ObservableCollection<MarvelMovies>
    //and assigns it to the property — using the target-typed new() shorthand.
    //Same as -> ObservableCollection<MarvelMovies> MarvelMoviesCollection =
    //  new ObservableCollection<MarvelMovies>();
    [ObservableProperty]
    public ObservableCollection<MarvelCharacters> _marvelCharactersCollection = new();

    public CollectionGOGwImagesViewModel()
    {
        _marvelcharacters = MarvelCharacters.GetCharacters();
        LoadCharacters();
    }

    private void LoadCharacters()
    {
        try
        {
            _marvelCharactersCollection.Clear();
            foreach (var p in _marvelcharacters)
            {
                _marvelCharactersCollection.Add(p);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}