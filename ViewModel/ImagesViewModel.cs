using MyFirstMAUIApp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.View;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ImagesViewModel : ObservableObject
    {
        public string Title => TitleImages.Title;

        [ObservableProperty]
        private string buttonTextURIImages = TitleImages.ButtonTextURIImages;

        [ObservableProperty]
        private string buttonTextEmbeddedImages = TitleImages.ButtonTextEmbeddedImages;

        [ObservableProperty]
        private string buttonTextActivity = TitleImages.ButtonTextActivity;

        public ImagesViewModel()
        {

        }

        [RelayCommand]
        private async Task URIImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesURIPage));
        }

        [RelayCommand]
        private async Task EmbeddedImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesEmbeddedPage));
        }

        [RelayCommand]
        private async Task ActivityClicked()
        {
            await Shell.Current.GoToAsync(nameof(ActivityIndicatorPage));
        }

    }
}


