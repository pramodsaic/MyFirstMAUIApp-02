using System.Windows.Input;
using MyFirstMAUIApp.Model;
using MyFirstMAUIApp.View;
using MyFirstMobileApp.ViewModels;

namespace MyFirstMAUIApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public string PageTitle { get; set; } = TitleMain.Title;
        public string LayoutsButton { get; set; } = TitleMain.LayoutsButton;
        public string ImagesButton { get; set; } = TitleMain.ImagesButton;
        public string CollectionsButton { get; set; } = TitleMain.CollectionsButton;
        public string ControlsButton { get; set; } = TitleMain.ControlsButton;
        public string SQLiteButton { get; set; } = TitleMain.SQLiteButton;

        public ICommand OnLayoutsClickedCommand { get; set; }

        public MainViewModel()
        {
            Title = TitleMain.Title;
            OnLayoutsClickedCommand = new Command(async () => await OnLayoutsClickedAsync());
        }

        private async Task OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }
    }
}