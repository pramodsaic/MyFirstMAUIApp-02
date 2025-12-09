using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel;

public partial class CollectionMarvelMoviesViewModel : ObservableObject
{
    private List<MarvelMovies> _marvelmovies;
    public string title => MarvelMovies.MarvelMoviesTitle;

    //= new() -> constructs an empty ObservableCollection<MarvelMovies>
    //and assigns it to the property — using the target-typed new() shorthand.
    //Same as -> ObservableCollection<MarvelMovies> MarvelMoviesCollection =
    //  new ObservableCollection<MarvelMovies>();
    public ObservableCollection<MarvelMovies> MarvelMoviesCollection { get; } = new();

    public CollectionMarvelMoviesViewModel()
    {
        _marvelmovies = MarvelMovies.GetMovies();
        LoadMovies();
    }

    private void LoadMovies()
    {
        try
        {
            MarvelMoviesCollection.Clear();
            foreach (var p in _marvelmovies)
            {
                MarvelMoviesCollection.Add(new MarvelMovies { NameofMovie = p.NameofMovie });
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}



