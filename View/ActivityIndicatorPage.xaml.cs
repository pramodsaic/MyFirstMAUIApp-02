using MyFirstMAUIApp.ViewModel;
namespace MyFirstMAUIApp.View;

public partial class ActivityIndicatorPage : ContentPage
{
    public ActivityIndicatorPage()
    {
        InitializeComponent();
        BindingContext = new ActivityIndicatorViewModel();
    }
}


