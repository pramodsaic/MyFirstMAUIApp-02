using MyFirstMAUIApp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.View;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class CollectionsViewModel : ObservableObject
    {
        public string Title => TitleCollections.Title;

        [ObservableProperty]
        private string buttonTextCollectionsIn = TitleCollections.ButtonTextCollectionsIn;

        [ObservableProperty]
        private string buttonTextCollectionImages = TitleCollections.ButtonTextCollectionImages;

        [ObservableProperty]
        private string buttonTextCollectionButtons = TitleCollections.ButtonTextCollectionButtons;

        [ObservableProperty]
        private string buttonTextCollectionIcons = TitleCollections.ButtonTextCollectionIcons;

        public CollectionsViewModel()
        {

        }

        [RelayCommand]
        private async Task MarvelMoviesClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionMarvelMoviesPage));
        }

        [RelayCommand]
        private async Task CollectionWImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionGOGwImagesPage));
        }

        [RelayCommand]
        private async Task CollectionButtonsClickedCommand()
        {
            await Shell.Current.GoToAsync(nameof(UpdateableCollectionWButtonsPage));
        }

    }
}