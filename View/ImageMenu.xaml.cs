using MyFirstMAUIApp.ViewModel;
namespace MyFirstMAUIApp.View;

public partial class ImageMenu : ContentPage
{
    public ImageMenu()
    {
        InitializeComponent();
        BindingContext = new ImagesViewModel();
    }
}


