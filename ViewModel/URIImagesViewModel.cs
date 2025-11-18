using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
using System;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class URIImagesViewModel : ObservableObject
    {
        public string Title => TitleURIImages.URIImagesTitle;

        [ObservableProperty]
        private ImageSource imageSourceUrl;
        public URIImagesViewModel()
        {
            ImageSourceUrl = new UriImageSource
            {
                Uri = new Uri(TitleURIImages.ImageURL),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };
        }
    }
}


