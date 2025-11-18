using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ActivityIndicatorViewModel : ObservableObject
    {
        public string Title => TitleActivityIndicator.ActivityIndicatorTitle;

        [ObservableProperty]
        private bool isLoading = true;

        [ObservableProperty]
        private bool isImageVisible = false;

        [ObservableProperty]
        private ImageSource loadedImage;

        public ActivityIndicatorViewModel()
        {
            _ = LoadImageAsync();
        }

        private async Task LoadImageAsync()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(TitleURIImages.ImageURL);
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    LoadedImage = ImageSource.FromStream(() => stream);
                    IsImageVisible = true;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}


