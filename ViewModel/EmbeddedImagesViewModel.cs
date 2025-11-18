using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
using Microsoft.Maui.Controls;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class EmbeddedImagesViewModel : ObservableObject
    {
        public string Title => TitleEmbeddedImage.EmbeddedImagesTitle;
        public ImageSource ImageSource => "building.jpg";
    }
}


